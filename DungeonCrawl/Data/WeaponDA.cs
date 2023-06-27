using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonCrawl
{
    class WeaponDA
    {
        public static List<Weapon> GetsAllWeapons()
        {
            List<Weapon> WeaponList = new List<Weapon>();
            SqlConnection conn = DungeonDA.GetConnection();
            string selectStatement = "SELECT * FROM Weapon;";
            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);

            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                Weapon wpn;
                while (reader.Read())
                {
                    wpn = new Weapon();
                    wpn.WeaponID = reader.GetInt32(0);
                    wpn.Name = reader.GetString(1);
                    wpn.AttackPower = reader.GetInt32(2);
                    wpn.Cost = reader.GetInt32(3);
                    wpn.SellPrice = reader.GetInt32(4);
                    wpn.Level = reader.GetInt32(5);
                    WeaponList.Add(wpn);
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

            return WeaponList;
        }

        public static List<Weapon> GetWeaponByLevel(int lvl)
        {
            List<Weapon> WeaponList = new List<Weapon>();
            List<Weapon> WpnLevelList = new List<Weapon>();
            SqlConnection conn = DungeonDA.GetConnection();
            string selectStatement = "SELECT * FROM Weapon;";
            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);

            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                Weapon wpn;
                while (reader.Read())
                {
                    wpn = new Weapon();
                    wpn.WeaponID = reader.GetInt32(0);
                    wpn.Name = reader.GetString(1);
                    wpn.AttackPower = reader.GetInt32(2);
                    wpn.Cost = reader.GetInt32(3);
                    wpn.SellPrice = reader.GetInt32(4);
                    wpn.Level = reader.GetInt32(5);
                    WeaponList.Add(wpn);
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

            foreach(Weapon w in WeaponList)
            {
                if(w.Level <= lvl)
                {
                    WpnLevelList.Add(w);
                }
            }

            return WpnLevelList;
        }

        public static void AddsWeapon(Weapon w)
        {
            SqlConnection conn = DungeonDA.GetConnection();
            string insertStatement = "INSERT INTO Weapon (WeaponName, AttackPower, BuyPrice, SellPrice, WeaponLevel) VALUES (@name, @pow, @buy, @sell, @lvl);";
            SqlCommand insertCommand = new SqlCommand(insertStatement, conn);
            insertCommand.Parameters.AddWithValue("@name", w.Name);
            insertCommand.Parameters.AddWithValue("@pow", w.AttackPower);
            insertCommand.Parameters.AddWithValue("@buy", w.Cost);
            insertCommand.Parameters.AddWithValue("@sell", w.SellPrice);
            insertCommand.Parameters.AddWithValue("@lvl", w.Level);
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

        public static void UpdatesWeapon(Weapon w)
        {
            SqlConnection conn = DungeonDA.GetConnection();
            string updateStatement = "UPDATE Weapon SET WeaponName = @name, AttackPower = @pow, BuyPrice = @buy, SellPrice = @sell, WeaponLevel = @lvl WHERE WeaponId = @id;";
            SqlCommand updateCommand = new SqlCommand(updateStatement, conn);
            updateCommand.Parameters.AddWithValue("@name", w.Name);
            updateCommand.Parameters.AddWithValue("@pow", w.AttackPower);
            updateCommand.Parameters.AddWithValue("@buy", w.Cost);
            updateCommand.Parameters.AddWithValue("@sell", w.SellPrice);
            updateCommand.Parameters.AddWithValue("@lvl", w.Level);
            updateCommand.Parameters.AddWithValue("@id", w.WeaponID);
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

        public static void DeletesWeapon(Weapon w)
        {
            SqlConnection conn = DungeonDA.GetConnection();
            string deleteStatement = "DELETE FROM Weapon WHERE WeaponId = @id;";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, conn);
            deleteCommand.Parameters.AddWithValue("@id", w.WeaponID);
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
