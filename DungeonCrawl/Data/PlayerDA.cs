using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonCrawl
{
    class PlayerDA
    {
        public static List<Player> GetsAllPlayers()
        {
            List<Player> PlayerList = new List<Player>();
            SqlConnection conn = DungeonDA.GetConnection();
            string selectStatement = "SELECT * FROM Player;";
            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);

            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                Player ply;
                while (reader.Read())
                {
                    ply = new Player();
                    ply.PlayerID = reader.GetInt32(0);
                    ply.PlayerName = reader.GetString(1);
                    ply.Gold = reader.GetInt32(2);
                    ply.Escaped = reader.GetBoolean(3);
                    ply.Level = reader.GetInt32(4);
                    PlayerList.Add(ply);
                }
            }
            catch (SqlException sEx)
            {
                throw sEx;//MessageBox.Show(sEx.Message);
            }
            finally
            {
                conn.Close();
            }

            return PlayerList;
        }

        public static void AddsPlayer(Player p)
        {
            SqlConnection conn = DungeonDA.GetConnection();
            string insertStatement = "INSERT INTO Player (PlayerName, Gold, Escaped, Level) VALUES (@name, @gold, @escape, @lvl);";
            SqlCommand insertCommand = new SqlCommand(insertStatement, conn);
            insertCommand.Parameters.AddWithValue("@name", p.PlayerName);
            insertCommand.Parameters.AddWithValue("@gold", p.Gold);
            insertCommand.Parameters.AddWithValue("@escape", p.Escaped);
            insertCommand.Parameters.AddWithValue("@lvl", p.Level);
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

        public static void DeletesPlayer(Player p)
        {
            SqlConnection conn = DungeonDA.GetConnection();
            string deleteStatement = "DELETE FROM Player WHERE PlayerId = @id;";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, conn);
            deleteCommand.Parameters.AddWithValue("@id", p.PlayerID);
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
