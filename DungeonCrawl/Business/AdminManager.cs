using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl.Business
{
    class AdminManager
    {
        public List<Admininster> GetAllAdmins()
        {
            return AdminDA.GetAllAdmins();
        }

        public void AddAdmin(Admininster a)
        {
            AdminDA.AddAdmin(a);
        }
    }
}
