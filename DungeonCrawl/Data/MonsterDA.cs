using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonCrawl
{
    class MonsterDA
    {
        public static List<Monster> GetsAllMonsters()
        {
            List<Monster> MonsterList = new List<Monster>();
            SqlConnection conn = DungeonDA.GetConnection();
            string selectStatement = "SELECT * FROM Monsters;";
            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);

            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                Monster mon;
                while (reader.Read())
                {
                    mon = new Monster();
                    mon.MonsterID = reader.GetInt32(0);
                    mon.MonsterName = reader.GetString(1);
                    mon.MonHealth = reader.GetInt32(2);
                    mon.MonAttNam = reader.GetString(3);
                    mon.MonAttPower = reader.GetInt32(4);
                    mon.MonLevel = reader.GetInt32(5);
                    MonsterList.Add(mon);
                }
            }
            catch (SqlException sEx)
            {
                throw sEx;
            }
            finally
            {
                conn.Close();
            }

            return MonsterList;
        }

        public static List<Monster> GetMonsByLevel(int lvl)
        {
            List<Monster> MonsterList = new List<Monster>();
            List<Monster> MonLevelList = new List<Monster>();
            SqlConnection conn = DungeonDA.GetConnection();
            string selectStatement = "SELECT * FROM Monsters;";
            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);

            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                Monster mon;
                while (reader.Read())
                {
                    mon = new Monster();
                    mon.MonsterID = reader.GetInt32(0);
                    mon.MonsterName = reader.GetString(1);
                    mon.MonHealth = reader.GetInt32(2);
                    mon.MonAttNam = reader.GetString(3);
                    mon.MonAttPower = reader.GetInt32(4);
                    mon.MonLevel = reader.GetInt32(5);
                    MonsterList.Add(mon);
                }
            }
            catch (SqlException sEx)
            {
                throw sEx;
            }
            finally
            {
                conn.Close();
            }

            foreach(Monster m in MonsterList)
            {
                if(m.MonLevel <= lvl)
                {
                    MonLevelList.Add(m);
                }
            }

            return MonLevelList;
        }

        public static void AddsMonster(Monster m)
        {
            SqlConnection conn = DungeonDA.GetConnection();
            string insertStatement = "INSERT INTO Monsters (MonName, MonHealth, MonAttNam, MonAttPow, MonLevel) VALUES (@name, @health, @attName, @pow, @level);";
            SqlCommand insertCommand = new SqlCommand(insertStatement, conn);
            insertCommand.Parameters.AddWithValue("@name", m.MonsterName);
            insertCommand.Parameters.AddWithValue("@health", m.MonHealth);
            insertCommand.Parameters.AddWithValue("@attName", m.MonAttNam);
            insertCommand.Parameters.AddWithValue("@pow", m.MonAttPower);
            insertCommand.Parameters.AddWithValue("@level", m.MonLevel);
            int count = 0;

            try
            {
                conn.Open();

                count = insertCommand.ExecuteNonQuery();
            }
            catch (SqlException sEx)
            {
                throw sEx;
            }
            finally
            {
                conn.Close();
            }
        }

        public static void UpdatesMonster(Monster m)
        {
            SqlConnection conn = DungeonDA.GetConnection();
            string updateStatement = "UPDATE Monsters SET MonName = @name, MonHealth = @hp, MonAttNam = @powName, MonAttPow = @pow, MonLevel = @level WHERE MonsterId = @id;";
            SqlCommand updateCommand = new SqlCommand(updateStatement, conn);
            updateCommand.Parameters.AddWithValue("@name", m.MonsterName);
            updateCommand.Parameters.AddWithValue("@hp", m.MonHealth);
            updateCommand.Parameters.AddWithValue("@powName", m.MonAttNam);
            updateCommand.Parameters.AddWithValue("@pow", m.MonAttPower);
            updateCommand.Parameters.AddWithValue("@level", m.MonLevel);
            updateCommand.Parameters.AddWithValue("@id", m.MonsterID);
            int count = 0;

            try
            {
                conn.Open();

                count = updateCommand.ExecuteNonQuery();
            }
            catch (SqlException sEx)
            {
                throw sEx;
            }
            finally
            {
                conn.Close();
            }
        }

        public static void DeletesMonster(Monster m)
        {
            SqlConnection conn = DungeonDA.GetConnection();
            string deleteStatement = "DELETE FROM Monsters WHERE MonsterId = @id;";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, conn);
            deleteCommand.Parameters.AddWithValue("@id", m.MonsterID);
            int count = 0;

            try
            {
                conn.Open();

                count = deleteCommand.ExecuteNonQuery();
            }
            catch (SqlException sEx)
            {
                throw sEx;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
