using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    public class Monster
    {
        public Monster()
        {

        }

        public Monster(string name, int health, int attack)
        {
            this.MonsterName = name;
            this.MonHealth = health;
            this.MonAttPower = attack;
        }

        public int MonsterID { get; set; }
        public string MonsterName { get; set; }
        public int MonHealth { get; set; }
        public string MonAttNam { get; set; }
        public int MonAttPower { get; set; }

        public int MonLevel { get; set; }
    }
}
