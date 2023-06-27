using DungeonCrawl.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonCrawl
{
    class Board
    {
        private Player ply = null;
        private Panel pnl = null;
        private MonsterManager monManager = new MonsterManager();
        private WeaponManager wpnManager = new WeaponManager();
        
        //Added March 2023
        private SpellManager splManager = new SpellManager();

        private PictureBox hero = null;
        private PictureBox chest = null;
        private PictureBox exit = null;

        private bool chestSpawn = false;
        private bool exitSpawn = false;
        private Random rnd = new Random();

        public void SpawnPlayer(Player p, Panel pn)
        {
            ply = p;
            pnl = pn;
            hero = new PictureBox();
            hero.Image = Resources.HeroSouth;
            hero.Height = hero.Image.Height;
            hero.Width = hero.Image.Width;
            hero.Location = new Point(270, 215);
            pnl.Controls.Add(hero);
        }

        // Moves player around room -------------------------------------------------------------------------------------------------------
        public Player Move(string dir)
        {
            bool flag = false;

            if (dir == "N")
            {
                hero.Top -= 20;
                hero.Image = Resources.HeroNorth;
                hero.Height = hero.Image.Height;
                hero.Width = hero.Image.Width;

                if (0 <= hero.Top && hero.Top <= 127)
                {
                    if (64 <= hero.Left && hero.Left <= 487)
                    {
                        flag = true;
                    }
                }
            }
            else if (dir == "S")
            {
                hero.Top += 20;
                hero.Image = Resources.HeroSouth;
                hero.Height = hero.Image.Height;
                hero.Width = hero.Image.Width;

                if (376 <= hero.Top && hero.Top <= 440)
                {
                    if (64 <= hero.Left && hero.Left <= 487)
                    {
                        flag = true;
                    }
                }
            }
            else if (dir == "W")
            {
                hero.Left -= 20;
                hero.Image = Resources.HeroWest;
                hero.Height = hero.Image.Height;
                hero.Width = hero.Image.Width;

                if (127 <= hero.Top && hero.Top <= 376)
                {
                    if (0 <= hero.Left && hero.Left <= 64)
                    {
                        flag = true;
                    }
                }
            }
            else
            {
                hero.Left += 20;
                hero.Image = Resources.HeroEast;
                hero.Height = hero.Image.Height;
                hero.Width = hero.Image.Width;

                if (127 <= hero.Top && hero.Top <= 376)
                {
                    if (486 <= hero.Left && hero.Left <= 550)
                    {
                        flag = true;
                    }
                }
            }

            // Begins checks
            Checks();

            if (flag)
            {
                RespawnRoom(dir);
            }

            return ply;
        }

        // Checks performed to see if player encounters monster, opens chest, or exits dungeon --------------------------------------------

        private void Checks()
        {
            CheckChest();
            CheckExit();
            CheckMonster();
        }

        private void CheckChest()
        {
            if (chestSpawn)
            {
                if (chest.Top <= hero.Top && hero.Top <= (chest.Top + chest.Height))
                {
                    if (chest.Left <= hero.Left && hero.Left <= (chest.Left + chest.Width))
                    {
                        if (!(bool)chest.Tag)
                        {

                            int chn = rnd.Next(1, 4);
                            List<Weapon> wpns = wpnManager.GetsWeaponsByLevel(ply.Level);
                            List<Spell> spls = splManager.GetSpellsByLevel(ply.Level);
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
                                    //added March 2023--------------------
                                    chn = rnd.Next(0, spls.Count() - 1);
                                    bool redundant = false;
                                    foreach(Spell s in ply.SplInventory)
                                    {
                                        if(s.SpellId == spls[chn].SpellId)
                                        {
                                            redundant = true;
                                        }
                                    }
                                    if (redundant)
                                    {
                                        ply.Gold += spls[chn].Sell;
                                        MessageBox.Show("You got " + spls[chn].Sell + " gold!", "Dun dun dun DUUUUUUN!!!");
                                    }
                                    else
                                    {
                                        ply.SplInventory.Add(spls[chn]);
                                        MessageBox.Show("You got spell: " + spls[chn].SpellName, "Dun dun dun DUUUUUUN!!!");
                                    }
                                    break;
                                case 4:
                                    chn = rnd.Next(1, 5);
                                    ply.HealthPotion += chn;
                                    MessageBox.Show("You got " + chn + " Health Postion(s)!", "Dun dun dun DUUUUUUN!!!");
                                    break;
                            }

                            chest.Image = Resources.OpenChest;
                            chest.Height = Resources.OpenChest.Height;
                            chest.Width = Resources.OpenChest.Width;
                            chest.Top -= 26;
                            chest.Tag = true;

                        }
                    }
                }
            }
        }

        private void CheckExit()
        {
            if (exitSpawn)
            {
                if (exit.Top <= hero.Top && hero.Top <= (exit.Top + exit.Height))
                {
                    if (exit.Left <= hero.Left && hero.Left <= (exit.Left + exit.Width))
                    {
                        ply.Escaped = true;
                    }
                }
            }
        }

        private void CheckMonster()
        {
            int chn = rnd.Next(1, 15);

            if(chn > 12)
            {
                int num = rnd.Next(0, (monManager.GetsMonsByLevel(ply.Level).Count() - 1));
                Monster mon = monManager.GetsMonsByLevel(ply.Level)[num];
                AttackForm attForm = new AttackForm();
                ply = attForm.CommenceFight(ply, mon, wpnManager.GetsWeaponsByLevel(ply.Level));
            }
        }

        // Respawns objects in room and places player opposite of the door he entered -----------------------------------------------------
        private void RespawnRoom(string direction)
        {
            // removes old exits or chests
            if (exitSpawn)
            {
                pnl.Controls.Remove(exit);
                exitSpawn = false;
            }
            if (chestSpawn)
            {
                pnl.Controls.Remove(chest);
                chestSpawn = false;
            }

            // Potentially spawns new chest or exit
            int chn = rnd.Next(0, 100);

            if (chn > 74)
            {
                // Spawn Exit
                exitSpawn = true;
                exit = new PictureBox();
                exit.Height = 50;
                exit.Width = 50;
                exit.BackColor = Color.Gold;
                exit.Location = new Point(225, 170);
                pnl.Controls.Add(exit);

            }
            else if(chn > 49)
            {
                // Spawn Chest
                int x = rnd.Next(70, 409);
                int y = rnd.Next(130, 282);

                chestSpawn = true;
                chest = new PictureBox();
                chest.Image = Resources.ClosedChest;
                chest.Height = Resources.ClosedChest.Height;
                chest.Width = Resources.ClosedChest.Width;
                chest.Location = new Point(x, y);
                chest.Tag = false;
                pnl.Controls.Add(chest);
            }

            if(direction == "N")
            {
                hero.Location = new Point(220, (pnl.Height - hero.Height)/*370*/);
            }
            else if (direction == "S")
            {
                hero.Location = new Point(220, hero.Height);
            }
            else if (direction == "W")
            {
                hero.Location = new Point((pnl.Width - hero.Width), 170);
            }
            else
            {
                hero.Location = new Point(hero.Width, 170);
            }
        }

        // Potion use, Inventory, Store ----------------------------------------------------------------------------------
        public Player UsePotion()
        {
            if (ply.HealthPotion > 0)
            {
                ply.Health = ply.MaxHealth;
                ply.HealthPotion--;

                //added March 2023 ------------------------------
                ply.Mana = ply.MaxMana;
            }
            return ply;
        }

        public Player Inventory()
        {
            InventoryForm invForm = new InventoryForm();
            ply = invForm.OpenInventory(ply);

            return ply;
        }

        public Player Store()
        {
            StoreForm strForm = new StoreForm();
            ply = strForm.OpenStore(ply, wpnManager.GetsWeaponsByLevel(ply.Level));

            return ply;
        }

        public Player MagicMenu()
        {
            MagicMenu mgcMenu = new MagicMenu();
            ply = mgcMenu.EquipSpell(ply);

            return ply;
        }
    }
}
