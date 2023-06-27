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
    public partial class ItemForm : Form
    {
        private Weapon theWeapon = null;
        private bool update = false;
        private List<TextBox> boxes = new List<TextBox>();

        public ItemForm()
        {
            InitializeComponent();
        }

        public Weapon AddItem()
        {
            this.ShowDialog();

            return theWeapon;
        }

        public Weapon Modify(Weapon w)
        {
            update = true;
            theWeapon = w;

            this.ShowDialog();

            return theWeapon;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            btnEnter.Text = "Add";
            lblWarn.Text = "";

            boxes.Add(txtName);
            boxes.Add(txtWpnLevel);
            boxes.Add(txtAttPow);
            boxes.Add(txtBuy);
            boxes.Add(txtSell);

            if (update)
            {
                btnEnter.Text = "Modify";

                txtName.Text = theWeapon.Name;
                txtWpnLevel.Text = theWeapon.Level.ToString();
                txtAttPow.Text = theWeapon.AttackPower.ToString();
                txtBuy.Text = theWeapon.Cost.ToString();
                txtSell.Text = theWeapon.SellPrice.ToString();
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            lblWarn.Text = "";
            bool pass = true;
            try
            {
                foreach (TextBox t in boxes)
                {
                    if (t.Text == "")
                    {
                        pass = false;
                    }
                }

                if (pass)
                {
                    if (!update)
                    {
                        theWeapon = new Weapon();
                    }
                    theWeapon.Name        = txtName.Text;
                    theWeapon.Level       = Convert.ToInt32(txtWpnLevel.Text);
                    theWeapon.AttackPower = Convert.ToInt32(txtAttPow.Text);
                    theWeapon.Cost        = Convert.ToInt32(txtBuy.Text);
                    theWeapon.SellPrice   = Convert.ToInt32(txtSell.Text);
                }
            }
            catch
            {
                lblWarn.Text = "Not all boxes were filled or not filled correctly";
            }

            if (pass)
            {
                this.Close();
            }
        }
    }
}
