using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    public class Weapon
    {
        public Weapon()
        {
            this.Equipped = false;
        }

        public Weapon(string name, int power, int buy, int sell)
        {
            this.Name = name;
            this.AttackPower = power;
            this.Cost = buy;
            this.SellPrice = sell;
            this.Equipped = true;
        }

        public int WeaponID { get; set; }
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int Cost { get; set; }
        public int SellPrice { get; set; }
        public bool Equipped { get; set; }

        public int Level { get; set; }
    }
}
