using DungeonCrawl.Business;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonCrawl
{
    class AdminDA
    {
        public static List<Admininster> GetAllAdmins()
        {
            List<Admininster> ads = new List<Admininster>();
            SqlConnection conn = DungeonDA.GetConnection();
            string selectStatement = "SELECT * FROM Admins;";
            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);

            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                Admininster a;
                while (reader.Read())
                {
                    a = new Admininster();
                    a.UserName = reader.GetString(1);
                    a.Password = reader.GetString(2);
                    ads.Add(a);
                }
            }
            catch (SqlException sEx)
            {
                MessageBox.Show(sEx.Message);
            }
            finally
            {
                conn.Close();
            }

            return ads;
        }

        public static void AddAdmin(Admininster a)
        {
            SqlConnection conn = DungeonDA.GetConnection();
            string insertStatement = "INSERT INTO Admins (AdminName, AdminPassword) VALUES (@name, @pass);";
            SqlCommand insertCommand = new SqlCommand(insertStatement, conn);
            insertCommand.Parameters.AddWithValue("@name", a.UserName);
            insertCommand.Parameters.AddWithValue("@pass", a.Password);
            int count = 0;

            try
            {
                conn.Open();

                count = insertCommand.ExecuteNonQuery();
            }
            catch (SqlException sEx)
            {
                MessageBox.Show(sEx.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
