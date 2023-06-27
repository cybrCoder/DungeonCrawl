using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    class MonsterManager
    {
        public MonsterManager()
        {

        }

        public List<Monster> GetAllMonsters()
        {
            return MonsterDA.GetsAllMonsters();
        }

        public List<Monster> GetsMonsByLevel(int lvl)
        {
            return MonsterDA.GetMonsByLevel(lvl);
        }

        public void AddsMonster(Monster m)
        {
            MonsterDA.AddsMonster(m);
        }

        public void UpdateMonster(Monster m)
        {
            MonsterDA.UpdatesMonster(m);
        }

        public void DeleteMonster(Monster m)
        {
            MonsterDA.DeletesMonster(m);
        }
    }
}
