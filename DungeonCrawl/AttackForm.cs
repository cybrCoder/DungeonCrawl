using DungeonCrawl.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DungeonCrawl
{
    public partial class AttackForm : Form
    {
        private Player ply = null;
        private Monster mon = null;
        private List<Weapon> wpns = null;
        private Random rnd = new Random();
        private BattleClass bat = new BattleClass();

        public AttackForm()
        {
            InitializeComponent();
        }

        public Player CommenceFight(Player p, Monster m, List<Weapon> w)
        {
            ply = p;
            mon = m;
            wpns = w;

            this.ShowDialog();

            return ply;
        }

        private void AttackForm_Load(object sender, EventArgs e)
        {
            pbxMon.Image = Resources.MonsterPortrait;
            lblMonName.Text = mon.MonsterName;
            barMonHealth.Maximum = mon.MonHealth;
            barMonHealth.Value = mon.MonHealth;
            LoadPlayerStats();
        }

        private void LoadPlayerStats()
        {
            BlankLine();
            lstBattleInfo.Items.Add("Your Move!");
            int visibleItems = lstBattleInfo.ClientSize.Height / lstBattleInfo.ItemHeight;
            lstBattleInfo.TopIndex = Math.Max(lstBattleInfo.Items.Count - visibleItems + 1, 0);

            lblPlyHp.Text = ply.Health.ToString();
            lblManaPts.Text = ply.Mana.ToString();
            lblPotions.Text = ply.HealthPotion.ToString();
            lblWeapName.Text = ply.EquippedWeapon.Name;
        }

        // Form Buttons -----------------------------------------------------------------------

        private void btnUse_Click(object sender, EventArgs e)
        {
            ply = bat.UseHPPotion(ply, lstBattleInfo);

            LoadPlayerStats();

            MonsterTurn();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            int damage = 0;
            damage = bat.Attack(ply, lstBattleInfo);

            if (barMonHealth.Value < damage)
            {
                barMonHealth.Value = 0;
            }
            else
            {
                barMonHealth.Value -= damage;
            }

            if (barMonHealth.Value > 0)
            {
                MonsterTurn();
            }
            else
            {
                EndBattle();
            }
        }

        /*
         * Magic Option added February 2023
         */
        private void btnMagic_Click(object sender, EventArgs e)
        {
            int slot;
            int damage;
            slot = bat.MagicCast(ply, lstBattleInfo);

            
            if(slot == 0)
            {
                MonsterTurn();
            }
            else
            {
                ply.Mana -= ply.EquippedSpls[slot - 1].Drain;
                LoadPlayerStats();

                damage = bat.MagicHit(ply.EquippedSpls[slot - 1], lstBattleInfo);

                if (barMonHealth.Value < damage)
                {
                    barMonHealth.Value = 0;
                }
                else
                {
                    barMonHealth.Value -= damage;
                }

                if (barMonHealth.Value > 0)
                {
                    MonsterTurn();
                }
                else
                {
                    EndBattle();
                }
            }

        }

        private void btnFlee_Click(object sender, EventArgs e)
        {
            int chn = rnd.Next(1, 10);

            if(chn > 8)
            {
                lstBattleInfo.Items.Add("Fleeee Successful!");
                this.Close();
            }
            else
            {
                lstBattleInfo.Items.Add("Failed to Fleeee!");
                MonsterTurn();
            }
        }

        //Form Methods ---------------------------------------------------------------------

        private void MonsterTurn()
        {
            // Monster Portrait is replaced if damaged enough
            if(barMonHealth.Value < (mon.MonHealth / 2))
            {
                pbxMon.Image = Resources.DamagedMonsterPortrait;
            }
            
            BlankLine();
            lstBattleInfo.Items.Add("Monsters Turn");

            // Randomized Chance on Monster Attack
            
            ply = bat.MonsterAttack(mon, ply, lstBattleInfo);
            
            if(ply.Health <= 0)
            {
                lstBattleInfo.Items.Add("PLAYER " + ply.PlayerName + " DEFEATED!!!");
                this.Close();
            }
            else
            {
                LoadPlayerStats();
            }
        }

        private void EndBattle()
        {
            lstBattleInfo.Items.Add(mon.MonsterName + " DEFEATED!!");
            ply.Exp++;

            // Check if player Levelled Up
            bool flag = ply.LevelUp();

            if (flag)
            {
                MessageBox.Show("Your max Health has increased by 25!", "Level Up!");
            }

            // Get Random amount of gold or weapon or nothing
            int chn = rnd.Next(1, 4);
            switch (chn)
            {
                case 1:
                    chn = rnd.Next(0, (wpns.Count() - 1));
                    ply.WpnInventory.Add(wpns[chn]);
                    MessageBox.Show("You got " + wpns[chn].Name, "Dun dun dun DUUUUUUN!!!");
                    break;
                case 2:
                    chn = rnd.Next(25, 200);
                    ply.Gold += chn;
                    MessageBox.Show("You got " + chn + " gold!", "Dun dun dun DUUUUUUN!!!");
                    break;
                case 3:
                    MessageBox.Show("You got nothing!", "Dun dun dun DUUUUUUN!!!");
                    break;
            }

            this.Close();
        }


        // Miscellaneous Methods
        
        private void BlankLine()
        {
            lstBattleInfo.Items.Add("");
        }

        
    }
}
