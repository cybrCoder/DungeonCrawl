using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    class SpellDA
    {
        public static List<Spell> GetAllSpells()
        {
            List<Spell> SpellList = new List<Spell>();
            SqlConnection conn = DungeonDA.GetConnection();
            string selectStatment = "SELECT * FROM Spells;";
            SqlCommand selectCommand = new SqlCommand(selectStatment, conn);

            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                Spell spl;
                while (reader.Read())
                {
                    spl = new Spell();
                    spl.SpellId = reader.GetInt32(0);
                    spl.SpellName = reader.GetString(1);
                    spl.Drain = reader.GetInt32(2);
                    spl.SpellPower = reader.GetInt32(3);
                    spl.Buy = reader.GetInt32(4);
                    spl.Sell = reader.GetInt32(5);
                    spl.Level = reader.GetInt32(6);
                    SpellList.Add(spl);
                }
            }
            catch(SqlException sEx)
            {
                throw sEx;
            }
            finally
            {
                conn.Close();
            }

            return SpellList;
        }

        public static List<Spell> GetSpellByLevel(int lvl)
        {
            List<Spell> SpellList = new List<Spell>();
            SqlConnection conn = DungeonDA.GetConnection();
            string selectStatment = "SELECT * FROM Spells WHERE SpellLevel = @lvl;";
            SqlCommand selectCommand = new SqlCommand(selectStatment, conn);
            selectCommand.Parameters.AddWithValue("@lvl", lvl);

            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                Spell spl;
                while (reader.Read())
                {
                    spl = new Spell();
                    spl.SpellId = reader.GetInt32(0);
                    spl.SpellName = reader.GetString(1);
                    spl.Drain = reader.GetInt32(2);
                    spl.SpellPower = reader.GetInt32(3);
                    spl.Buy = reader.GetInt32(4);
                    spl.Sell = reader.GetInt32(5);
                    spl.Level = reader.GetInt32(6);
                    SpellList.Add(spl);
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

            return SpellList;
        }

        public static void AddSpell(Spell s)
        {
            SqlConnection conn = DungeonDA.GetConnection();
            string insertStatement = "INSERT INTO Spells (SpellName, Drain, SpellPower, BuyPrice, SellPrice, SpellLevel) VALUES (@nam, @drn, @pwr, @buy, @sell, @lvl);";
            SqlCommand insertCommand = new SqlCommand(insertStatement, conn);
            insertCommand.Parameters.AddWithValue("@nam", s.SpellName);
            insertCommand.Parameters.AddWithValue("@drn", s.Drain);
            insertCommand.Parameters.AddWithValue("@pwr", s.SpellPower);
            insertCommand.Parameters.AddWithValue("@buy", s.Buy);
            insertCommand.Parameters.AddWithValue("@sell", s.Sell);
            insertCommand.Parameters.AddWithValue("@lvl", s.Level);
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

        public static void UpdateSpell(Spell s)
        {
            SqlConnection conn = DungeonDA.GetConnection();
            string updateStatement = "UPDATE Spells SET SpellName = @nam, Drain = @drn, SpellPower = @pwr, BuyPrice = @buy, SellPrice = @sell, SpellLevel = @lvl WHERE SpellId = @id;";
            SqlCommand updateCommand = new SqlCommand(updateStatement, conn);
            updateCommand.Parameters.AddWithValue("@nam", s.SpellName);
            updateCommand.Parameters.AddWithValue("@drn", s.Drain);
            updateCommand.Parameters.AddWithValue("@pwr", s.SpellPower);
            updateCommand.Parameters.AddWithValue("@buy", s.Buy);
            updateCommand.Parameters.AddWithValue("@sell", s.Sell);
            updateCommand.Parameters.AddWithValue("@lvl", s.Level);
            updateCommand.Parameters.AddWithValue("@id", s.SpellId);
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

        public static void DeleteSpell(Spell s)
        {
            SqlConnection conn = DungeonDA.GetConnection();
            string deleteStatement = "DELETE FROM Spells WHERE SpellId = @id;";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, conn);
            deleteCommand.Parameters.AddWithValue("@id", s.SpellId);

            try
            {
                conn.Open();

                deleteCommand.ExecuteNonQuery();
            }
            catch(SqlException sEx)
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
