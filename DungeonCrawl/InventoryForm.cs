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
    public partial class InventoryForm : Form
    {
        private Player ply = null;

        public InventoryForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            ReloadInv();
            lblWarn.Text = "";
        }

        public Player OpenInventory(Player p)
        {
            ply = p;

            this.ShowDialog();

            return ply;
        }

        private void ReloadInv()
        {
            lstvwInventory.Columns.Clear();

            lstvwInventory.Columns.Add("ID", 50, HorizontalAlignment.Left);
            lstvwInventory.Columns.Add("Name", 100, HorizontalAlignment.Left);
            lstvwInventory.Columns.Add("Attack Power", 100, HorizontalAlignment.Left);
            lstvwInventory.Columns.Add("Sell Price", 60, HorizontalAlignment.Left);

            lstvwInventory.Items.Clear();
            foreach(Weapon w in ply.WpnInventory)
            {
                ListViewItem lvi = new ListViewItem(w.WeaponID.ToString());
                lvi.SubItems.Add(w.Name);
                lvi.SubItems.Add(w.AttackPower.ToString());
                lvi.SubItems.Add(w.SellPrice.ToString());
                lvi.Tag = w;
                lstvwInventory.Items.Add(lvi);
            }
            
        }

        private void lstvwInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvwInventory.SelectedItems.Count > 0)
            {
                Weapon w = (Weapon)lstvwInventory.SelectedItems[0].Tag;
                if (w.Equipped)
                {
                    btnEquip.Enabled = false;
                    lblWarn.Text = "This weapon is already equipped";
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
            if(lstvwInventory.SelectedItems.Count == 0)
            {
                lblWarn.Text = "Please select a weapon";
            }
            else
            {
                lblWarn.Text = "";

                Weapon wpn = (Weapon)lstvwInventory.SelectedItems[0].Tag;
                foreach(Weapon w in ply.WpnInventory)
                {
                    if (wpn.Equals(w))
                    {
                        w.Equipped = true;
                        ply.EquippedWeapon = w;
                    }
                    else
                    {
                        w.Equipped = false;
                    }
                }
            }
            ReloadInv();
        }
    }
}
