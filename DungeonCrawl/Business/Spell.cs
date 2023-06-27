using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    public class Spell
    {
        public Spell()
        {
            this.Equipped = false;
        }

        public Spell(string nam, int drn, int pwr, int buy, int sell, int level)
        {
            this.SpellName = nam;
            this.Drain = drn;
            this.SpellPower = pwr;
            this.Buy = buy;
            this.Sell = sell;
            this.Level = level;
            this.Equipped = false;
        }

        public int SpellId { get; set; }
        public string SpellName { get; set; }
        public int Drain { get; set; }
        public int SpellPower { get; set; }
        public int Buy { get; set; }
        public int Sell { get; set; }
        public int Level { get; set; }
        public bool Equipped { get; set; }
    }
}
