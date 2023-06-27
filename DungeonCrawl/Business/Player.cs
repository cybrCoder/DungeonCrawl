using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    public class Player
    {
        public Player()
        {
            // may change
        }

        public Player(string name)
        {
            this.PlayerName = name;
            this.Health = 100;
            this.MaxHealth = 100;
            this.HealthPotion = 5;
            this.Gold = 0;
            this.EquippedWeapon = new Weapon("Fists", 5, 0, 0);
            this.WpnInventory = new List<Weapon>();
            WpnInventory.Add(EquippedWeapon);
            this.Escaped = false;
            
            // Magic -------------------------------------------------------------
            this.Mana = 100;
            this.MaxMana = Mana;
            this.EquippedSpls = new Spell[4];
            this.EquippedSpls[0] = new Spell("Magic Missle", 10, 8, 0, 0, 0);
            this.SplInventory = new List<Spell>();
            SplInventory.Add(EquippedSpls[0]);

            // Constructing
            this.Level = 1;
            this.Exp = 0;
        }

        public int PlayerID { get; set; }
        public string PlayerName { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int HealthPotion { get; set; }

        // Magic -----------------------------------------------------------------
        public int Mana { get; set; }
        public int MaxMana { get; set; }
        public Spell[] EquippedSpls { get; set; }
        public List<Spell> SplInventory { get; set; }
        public int ManaPotion { get; set; }

        public int Gold { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public List<Weapon> WpnInventory { get; set; }
        public bool Escaped { get; set; }

        public int Level { get; set; }
        public int Exp { get; set; }

        public bool LevelUp()
        {
            bool flag = false;

            if(Exp >= (5 * Level))
            {
                Level++;
                MaxHealth += 25;
                Health = MaxHealth;
                MaxMana += 25;      // Magic
                Mana = MaxMana;     // Magic
                flag = true;
            }

            return flag;
        }
    }
}
