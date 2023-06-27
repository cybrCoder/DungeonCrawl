using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonCrawl
{
    public partial class SpellInventoryForm : Form
    {
        private Player ply = null;
        private int slotNum;
        public SpellInventoryForm()
        {
            InitializeComponent();
        }

        private void SpellInventoryForm_Load(object sender, EventArgs e)
        {
            ReloadSpellInv();
            lblWarn.Text = "";
        }

        public Player OpenSpellInv(Player p, int i)
        {
            ply = p;
            slotNum = i;

            this.ShowDialog();

            return ply;
        }

        private void ReloadSpellInv()
        {
            lstvwSpellInventory.Items.Clear();

            lstvwSpellInventory.Columns.Add("ID", 50, HorizontalAlignment.Left);
            lstvwSpellInventory.Columns.Add("Name", 100, HorizontalAlignment.Left);
            lstvwSpellInventory.Columns.Add("Spell Power", 100, HorizontalAlignment.Left);
            lstvwSpellInventory.Columns.Add("Mana Drain", 100, HorizontalAlignment.Left);
            lstvwSpellInventory.Columns.Add("Sell Price", 60, HorizontalAlignment.Left);

            foreach (Spell s in ply.SplInventory)
            {
                ListViewItem liv = new ListViewItem(s.SpellId.ToString());
                liv.SubItems.Add(s.SpellName);
                liv.SubItems.Add(s.SpellPower.ToString());
                liv.SubItems.Add(s.Drain.ToString());
                liv.SubItems.Add(s.Sell.ToString());
                liv.Tag = s;
                lstvwSpellInventory.Items.Add(liv);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstvwSpellInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstvwSpellInventory.SelectedItems.Count > 0)
            {
                Spell s = (Spell)lstvwSpellInventory.SelectedItems[0].Tag;
                if (s.Equipped)
                {
                    btnEquip.Enabled = false;
                    lblWarn.Text = "This spell is already equipped";
                }
                else
                {
                    btnEquip.Enabled = true;
                    lblWarn.Text = "";
                }
            }
        }

        private void btnEquip_Click(object sender, EventArgs e)
        {
            if(lstvwSpellInventory.SelectedItems.Count == 0)
            {
                lblWarn.Text = "Please select a spell!";
            }
            else
            {
                lblWarn.Text = "";

                Spell spl = (Spell)lstvwSpellInventory.SelectedItems[0].Tag;
                foreach (Spell s in ply.SplInventory)
                {
                    if (spl.Equals(s))
                    {
                        s.Equipped = true;
                        ply.EquippedSpls[slotNum] = s;
                    }
                    else
                    {
                        s.Equipped = false;
                    }
                }
            }

            ReloadSpellInv();
        }
    }
}
