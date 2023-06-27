using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    class DungeonDA
    {
        public static SqlConnection GetConnection()
        {
            //string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\College_CB\Capstone\IndividualProject\DungeonCrawl\DungeonCrawl\DungeonDB.mdf;Integrated Security=True";
            //string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\COLLEGE_CB\CAPSTONE\INDIVIDUALPROJECT\DUNGEONCRAWL\DUNGEONCRAWL\DUNGEONDB.MDF;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string conn = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\College_CB\Capstone\IndividualProject\DungeonCrawl\DungeonCrawl\DungeonDB.mdf; Integrated Security = True";
            //string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=N:\Capstone\DungeonCrawl\DungeonCrawl\DungeonDB.mdf;Integrated Security=True;Connect Timeout=30;
            return new SqlConnection(conn);
        }
    }
}
