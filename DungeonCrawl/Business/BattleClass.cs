using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonCrawl
{
    class BattleClass
    {
        Random rnd = new Random();

        public BattleClass()
        {
                
        }

        public int Attack(Player ply, ListBox lstBattleInfo)
        {
            int chn = rnd.Next(1, 6);
            int damage = ply.EquippedWeapon.AttackPower;

            if (chn == 1)
            {
                lstBattleInfo.Items.Add("Your attack missed");
                damage = 0;
            }
            else if (chn < 5)
            {
                lstBattleInfo.Items.Add("Attack Successful!");
            }
            else
            {
                lstBattleInfo.Items.Add("Critical Hit!");
                damage += Convert.ToInt32(damage * 0.25);
            }

            return damage;
        }

        public Player UseHPPotion(Player ply, ListBox lstBattleInfo)
        {
            if (ply.HealthPotion > 0)
            {
                ply.Health = ply.MaxHealth;
                ply.Mana = ply.MaxMana;
                ply.HealthPotion--;
            }
            else
            {
                lstBattleInfo.Items.Add("No postions left");
            }

            return ply;
        }

        public Player MonsterAttack(Monster mon, Player ply, ListBox lstBattleInfo)
        {
            int chn = rnd.Next(1, 6);

            if (chn == 1)
            {
                lstBattleInfo.Items.Add("Monster missed");
            }
            else if (chn < 5)
            {
                lstBattleInfo.Items.Add(mon.MonsterName + " uses " + mon.MonAttNam);
                ply.Health -= mon.MonAttPower;
            }
            else
            {
                lstBattleInfo.Items.Add(mon.MonsterName + " uses " + mon.MonAttNam);
                lstBattleInfo.Items.Add(" it was super-effective!");
                ply.Health -= mon.MonAttPower + Convert.ToInt32(mon.MonAttPower * 0.25);
            }

            return ply;
        }

        // Added February 2023
        public int MagicCast(Player ply, ListBox lstBattleInfo)
        {
            MagicMenu menu = new MagicMenu();
            int num = 0;
            num = menu.CastSpell(ply);

            if (num == 0)
            {
                lstBattleInfo.Items.Add("Spell cancelled!");
            }
            else if (ply.EquippedSpls[num - 1].Drain > ply.Mana)
            {
                lstBattleInfo.Items.Add("Not Enough Mana!");
                num = 0;
            }
            else
            {
                lstBattleInfo.Items.Add("Spell Cast!");
            }

            return num;
        }

        public int MagicHit(Spell spl, ListBox lstBattleInfo)
        {
            int damage;
            int chn = rnd.Next(1, 6);

            if (chn == 1)
            {
                lstBattleInfo.Items.Add(spl.SpellName + " missed!");
                damage = 0;
            }
            else if (chn <= 5)
            {
                lstBattleInfo.Items.Add(spl.SpellName + " casted!");
                damage = spl.SpellPower;
            }
            else
            {
                lstBattleInfo.Items.Add(spl.SpellName + " crits!");
                damage = spl.SpellPower + Convert.ToInt32(spl.SpellPower * 0.25);
            }

            return damage;
        }
    }
}
