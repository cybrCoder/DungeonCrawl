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
    public partial class StoreForm : Form
    {
        private Player ply = null;
        private List<Weapon> wpns = null;
        public StoreForm()
        {
            InitializeComponent();
        }

        private void StoreForm_Load(object sender, EventArgs e)
        {
            lblWarn1.Text = "";
            lblWarn2.Text = "";
            ReloadInv();
            ReloadShopList();
            ReloadGold();
        }

        public Player OpenStore(Player p, List<Weapon> w)
        {
            ply = p;
            wpns = w;

            this.ShowDialog();

            return ply;
        }

        private void ReloadInv()
        {
            lstvwSell.Columns.Clear();

            lstvwSell.Columns.Add("ID", 50, HorizontalAlignment.Left);
            lstvwSell.Columns.Add("Name", 150, HorizontalAlignment.Left);
            lstvwSell.Columns.Add("Attack Power", 100, HorizontalAlignment.Left);
            lstvwSell.Columns.Add("Sell Price", 60, HorizontalAlignment.Left);

            lstvwSell.Items.Clear();
            foreach (Weapon w in ply.WpnInventory)
            {
                ListViewItem lvi = new ListViewItem(w.WeaponID.ToString());
                lvi.SubItems.Add(w.Name);
                lvi.SubItems.Add(w.AttackPower.ToString());
                lvi.SubItems.Add(w.SellPrice.ToString());
                lvi.Tag = w;
                lstvwSell.Items.Add(lvi);
            }

        }

        private void ReloadShopList()
        {
            lstvwBuy.Columns.Clear();

            lstvwBuy.Columns.Add("ID", 50, HorizontalAlignment.Left);
            lstvwBuy.Columns.Add("Name", 150, HorizontalAlignment.Left);
            lstvwBuy.Columns.Add("Attack Power", 100, HorizontalAlignment.Left);
            lstvwBuy.Columns.Add("Sell Price", 60, HorizontalAlignment.Left);

            lstvwBuy.Items.Clear();
            foreach(Weapon w in wpns)
            {
                ListViewItem lvi = new ListViewItem(w.WeaponID.ToString());
                lvi.SubItems.Add(w.Name);
                lvi.SubItems.Add(w.AttackPower.ToString());
                lvi.SubItems.Add(w.Cost.ToString());
                lvi.Tag = w;
                lstvwBuy.Items.Add(lvi);
            }
        }

        private void ReloadGold()
        {
            lblPlyGold.Text = ply.Gold.ToString();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            lblWarn2.Text = "";

            if (lstvwSell.SelectedItems.Count == 0)
            {
                lblWarn2.Text = "Please select a weapon";
            }
            else
            {
                Weapon w = (Weapon)lstvwSell.SelectedItems[0].Tag;
                if (w.Equipped)
                {
                    lblWarn2.Text = "Cannot sell weapon that is already equipped";
                }
                else
                {
                    ply.WpnInventory.Remove(w);
                    ply.Gold += w.SellPrice;
                }
                ReloadInv();
                ReloadGold();
            }
        }

        private void btnBuyPotion_Click(object sender, EventArgs e)
        {
            lblWarn1.Text = "";

            if(ply.Gold >= 45)
            {
                ply.Gold -= 45;
                ply.HealthPotion++;
            }
            else
            {
                lblWarn1.Text = "Insufficient funds";
            }
            ReloadGold();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (lstvwBuy.SelectedItems.Count == 0)
            {
                lblWarn1.Text = "Please select a weapon";
            }
            else
            {
                Weapon w = (Weapon)lstvwBuy.SelectedItems[0].Tag;
                if(ply.Gold >= w.Cost)
                {
                    ply.WpnInventory.Add(w);
                    ply.Gold -= w.Cost;
                }
                else
                {
                    lblWarn1.Text = "Insufficient funds";
                }
            }
            ReloadShopList();
            ReloadInv();
            ReloadGold();
        }
    }
}
