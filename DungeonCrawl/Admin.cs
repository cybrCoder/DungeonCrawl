using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonCrawl
{
    public partial class Admin : Form
    {

        private PlayerManager plyManager = new PlayerManager();
        private WeaponManager weapsManager = new WeaponManager();
        private MonsterManager monsManager = new MonsterManager();
        // added spell manager 5/8/18
        private SpellManager splManager = new SpellManager();

        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            ReloadPlayers();
            ReloadItems();
            ReloadMonsters();
            //Added spell reload 6/11/2018
            ReloadSpells();
            lblWarnPly.Text = "";
            lblWarnItems.Text = "";
            lblWarnMon.Text = "";
            lblWarnSpl.Text = "";
        }

        private void ReloadPlayers()
        {
            lstvwPly.Columns.Clear();

            lstvwPly.Columns.Add("ID", 50, HorizontalAlignment.Left);
            lstvwPly.Columns.Add("Alias", 100, HorizontalAlignment.Left);
            lstvwPly.Columns.Add("Level", 60, HorizontalAlignment.Left);
            lstvwPly.Columns.Add("Gold", 75, HorizontalAlignment.Left);
            lstvwPly.Columns.Add("Escaped", 60, HorizontalAlignment.Left);
            lstvwPly.Columns.Add("Dead", 60, HorizontalAlignment.Left);

            lstvwPly.Items.Clear();
            
            try
            {
                List<Player> plys = plyManager.GetsAllPlayers();

                foreach (Player p in plys)
                {
                    ListViewItem lvi = new ListViewItem(p.PlayerID.ToString());
                    lvi.SubItems.Add(p.PlayerName);
                    lvi.SubItems.Add(p.Level.ToString());
                    lvi.SubItems.Add(p.Gold.ToString());
                    if (p.Escaped)
                    {
                        lvi.SubItems.Add("Yes");
                        lvi.SubItems.Add("No");
                    }
                    else
                    {
                        lvi.SubItems.Add("No");
                        lvi.SubItems.Add("Yes");
                    }
                    lvi.Tag = p;
                    lstvwPly.Items.Add(lvi);
                }
            }
            catch(SqlException sEx)
            {
                lblWarnPly.Text = sEx.Message;
            }
        }
        
        private void ReloadItems()
        {
            lstvwItems.Columns.Clear();

            lstvwItems.Columns.Add("ID", 50, HorizontalAlignment.Left);
            lstvwItems.Columns.Add("Name", 100, HorizontalAlignment.Left);
            lstvwItems.Columns.Add("Level", 50, HorizontalAlignment.Left);
            lstvwItems.Columns.Add("AttackPow", 60, HorizontalAlignment.Left);
            lstvwItems.Columns.Add("Buy Price", 60, HorizontalAlignment.Left);
            lstvwItems.Columns.Add("Sell Price", 60, HorizontalAlignment.Left);

            lstvwItems.Items.Clear();

            try
            {
                List<Weapon> weaps = weapsManager.GetAllWeapons();
                foreach (Weapon w in weaps)
                {
                    ListViewItem lvi = new ListViewItem(w.WeaponID.ToString());
                    lvi.SubItems.Add(w.Name);
                    lvi.SubItems.Add(w.Level.ToString());
                    lvi.SubItems.Add(w.AttackPower.ToString());
                    lvi.SubItems.Add(w.Cost.ToString());
                    lvi.SubItems.Add(w.SellPrice.ToString());

                    lvi.Tag = w;
                    lstvwItems.Items.Add(lvi);
                }
            }
            catch (SqlException sEx)
            {
                lblWarnItems.Text = sEx.Message;
            }
        }
        
        private void ReloadMonsters()
        {
            lstvwMons.Columns.Clear();

            lstvwMons.Columns.Add("ID", 50, HorizontalAlignment.Left);
            lstvwMons.Columns.Add("Name", 100, HorizontalAlignment.Left);
            lstvwMons.Columns.Add("Level", 50, HorizontalAlignment.Left);
            lstvwMons.Columns.Add("Health", 70, HorizontalAlignment.Left);
            lstvwMons.Columns.Add("MonAttNam", 100, HorizontalAlignment.Left);
            lstvwMons.Columns.Add("AttackPow", 70, HorizontalAlignment.Left);
            
            lstvwMons.Items.Clear();

            try
            {
                List<Monster> mons = monsManager.GetAllMonsters();
                foreach (Monster m in mons)
                {
                    ListViewItem lvi = new ListViewItem(m.MonsterID.ToString());
                    lvi.SubItems.Add(m.MonsterName);
                    lvi.SubItems.Add(m.MonLevel.ToString());
                    lvi.SubItems.Add(m.MonHealth.ToString());
                    lvi.SubItems.Add(m.MonAttNam.ToString());
                    lvi.SubItems.Add(m.MonAttPower.ToString());

                    lvi.Tag = m;
                    lstvwMons.Items.Add(lvi);
                }
            }
            catch (SqlException sEx)
            {
                lblWarnMon.Text = sEx.Message;
            }
        }

        private void ReloadSpells()
        {
            lstvwSpell.Columns.Clear();

            lstvwSpell.Columns.Add("ID", 50, HorizontalAlignment.Left);
            lstvwSpell.Columns.Add("Name", 100, HorizontalAlignment.Left);
            lstvwSpell.Columns.Add("Level", 50, HorizontalAlignment.Left);
            lstvwSpell.Columns.Add("Drain", 70, HorizontalAlignment.Left);
            lstvwSpell.Columns.Add("Power", 70, HorizontalAlignment.Left);
            lstvwSpell.Columns.Add("Buy", 70, HorizontalAlignment.Left);
            lstvwSpell.Columns.Add("Sell", 70, HorizontalAlignment.Left);

            lstvwSpell.Items.Clear();

            try
            {
                List<Spell> spls = splManager.GetAllSpells();
                foreach(Spell s in spls)
                {
                    ListViewItem lvi = new ListViewItem(s.SpellId.ToString());
                    lvi.SubItems.Add(s.SpellName);
                    lvi.SubItems.Add(s.Level.ToString());
                    lvi.SubItems.Add(s.Drain.ToString());
                    lvi.SubItems.Add(s.SpellPower.ToString());
                    lvi.SubItems.Add(s.Buy.ToString());
                    lvi.SubItems.Add(s.Sell.ToString());

                    lvi.Tag = s;
                    lstvwSpell.Items.Add(lvi);
                }
            }
            catch (SqlException sEx)
            {
                lblWarnSpl.Text = sEx.Message;
            }
        }

        // player buttons -----------------------------------------------------------

        private void btnPlyDelete_Click(object sender, EventArgs e)
        {
            lblWarnPly.Text = "";

            if(lstvwPly.SelectedItems.Count == 0)
            {
                lblWarnPly.Text = "Select a Player";
            }
            else
            {
                Player p = (Player)lstvwPly.SelectedItems[0].Tag;
                try
                {
                    plyManager.DeletesPlayer(p);
                }
                catch (SqlException sEx)
                {
                    lblWarnPly.Text = sEx.Message;
                }
            }
            ReloadPlayers();
        }

        // item buttons -------------------------------------------------------------

        private void btnUpdItem_Click(object sender, EventArgs e)
        {
            lblWarnItems.Text = "";

            if (lstvwItems.SelectedItems.Count == 0)
            {
                lblWarnItems.Text = "Select an Item";
            }
            else
            {
                Weapon w = (Weapon)lstvwItems.SelectedItems[0].Tag;
                ItemForm itForm = new ItemForm();
                w = itForm.Modify(w);

                try
                {
                    weapsManager.UpdateWeapon(w);
                }
                catch(SqlException sEx)
                {
                    lblWarnItems.Text = sEx.Message;
                }
            }
            ReloadItems();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            lblWarnItems.Text = "";

            if (lstvwItems.SelectedItems.Count == 0)
            {
                lblWarnItems.Text = "Select an Item";
            }
            else
            {
                Weapon w = (Weapon)lstvwItems.SelectedItems[0].Tag;

                try
                {
                    weapsManager.DeleteWeapon(w);
                }
                catch(SqlException sEx)
                {
                    lblWarnItems.Text = sEx.Message;
                }
            }
            ReloadItems();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Weapon w = null;
            ItemForm itForm = new ItemForm();
            w = itForm.AddItem();

            if (!w.Equals(null))
            {
                try
                {
                    weapsManager.AddsWeapon(w);
                }
                catch (SqlException sEx)
                {
                    lblWarnItems.Text = sEx.Message;
                }
            }
            ReloadItems();
        }

        // monster buttons ----------------------------------------------------------

        private void btnAddMon_Click(object sender, EventArgs e)
        {
            Monster m = null;
            MonsterForm monForm = new MonsterForm();
            m = monForm.AddMonster();

            if (m != null)
            {
                try
                {
                    monsManager.AddsMonster(m);
                }
                catch (SqlException sEx)
                {
                    lblWarnMon.Text = sEx.Message;
                }
            }
            ReloadMonsters();
        }

        private void btnUpdMon_Click(object sender, EventArgs e)
        {
            lblWarnMon.Text = "";

            if (lstvwMons.SelectedItems.Count == 0)
            {
                lblWarnMon.Text = "Select an Item";
            }
            else
            {
                Monster m = (Monster)lstvwMons.SelectedItems[0].Tag;
                MonsterForm monForm = new MonsterForm();
                m = monForm.ModifyMonster(m);

                try
                {
                    monsManager.UpdateMonster(m);
                }
                catch (SqlException sEx)
                {
                    lblWarnMon.Text = sEx.Message;
                }
            }
            ReloadMonsters();
        }

        private void btnDelMon_Click(object sender, EventArgs e)
        {
            lblWarnMon.Text = "";

            if (lstvwMons.SelectedItems.Count == 0)
            {
                lblWarnMon.Text = "Select a Monster";
            }
            else
            {
                Monster m = (Monster)lstvwMons.SelectedItems[0].Tag;

                try
                {
                    monsManager.DeleteMonster(m);
                }
                catch (SqlException sEx)
                {
                    lblWarnMon.Text = sEx.Message;
                }
            }
            ReloadMonsters();
        }

        // spell buttons ---------------------------------------------------------------

        private void btnAddSpl_Click(object sender, EventArgs e)
        {
            Spell s = null;
            SpellForm splForm = new SpellForm();
            s = splForm.AddSpell();

            if(s != null)
            {
                try
                {
                    splManager.AddSpell(s);
                }
                catch(SqlException sEx)
                {
                    lblWarnSpl.Text = sEx.Message;
                }
            }
            ReloadSpells();
        }

        private void btnUpdSpl_Click(object sender, EventArgs e)
        {
            lblWarnSpl.Text = "";

            if (lstvwSpell.SelectedItems.Count == 0)
            {
                lblWarnSpl.Text = "Select a Spell";
            }
            else
            {
                Spell s = (Spell)lstvwSpell.SelectedItems[0].Tag;
                SpellForm splForm = new SpellForm();
                s = splForm.Modify(s);

                try
                {
                    splManager.UpdateSpell(s);
                }
                catch (SqlException sEx)
                {
                    lblWarnSpl.Text = sEx.Message;
                }
            }
            ReloadSpells();

        }

        private void btnDelSpl_Click(object sender, EventArgs e)
        {
            lblWarnSpl.Text = "";

            if (lstvwSpell.SelectedItems.Count == 0)
            {
                lblWarnSpl.Text = "Select a Spell";
            }
            else
            {
                Spell s = (Spell)lstvwSpell.SelectedItems[0].Tag;

                try
                {
                    splManager.DeleteSpell(s);
                }
                catch (SqlException sEx)
                {
                    lblWarnSpl.Text = sEx.Message;
                }
            }
            ReloadSpells();
        }
    }
}
