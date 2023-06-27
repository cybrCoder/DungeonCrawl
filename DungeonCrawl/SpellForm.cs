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
    public partial class SpellForm : Form
    {
        private Spell theSpell = null;
        private bool update = false;
        private List<TextBox> boxes = new List<TextBox>();

        public SpellForm()
        {
            InitializeComponent();
        }

        private void SpellForm_Load(object sender, EventArgs e)
        {
            btnEnter.Text = "Add";
            lblSplWrn.Text = "";

            boxes.Add(txtSplNam);
            boxes.Add(txtSplLvl);
            boxes.Add(txtSplPow);
            boxes.Add(txtSplDrn);
            boxes.Add(txtSplBuy);
            boxes.Add(txtSplSel);

            if (update)
            {
                btnEnter.Text = "Modify";

                txtSplNam.Text = theSpell.SpellName;
                txtSplLvl.Text = theSpell.Level.ToString();
                txtSplPow.Text = theSpell.SpellPower.ToString();
                txtSplDrn.Text = theSpell.Drain.ToString();
                txtSplBuy.Text = theSpell.Buy.ToString();
                txtSplSel.Text = theSpell.Sell.ToString();
            }
        }

        public Spell AddSpell()
        {
            this.ShowDialog();

            return theSpell;
        }

        public Spell Modify(Spell s)
        {
            update = true;
            theSpell = s;

            this.ShowDialog();

            return theSpell;
        }

        private void btnCnl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            lblSplWrn.Text = "";
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
                        theSpell = new Spell();
                    }
                    theSpell.SpellName  = txtSplNam.Text;
                    theSpell.Level      = Convert.ToInt32(txtSplLvl.Text);
                    theSpell.SpellPower = Convert.ToInt32(txtSplPow.Text);
                    theSpell.Drain      = Convert.ToInt32(txtSplDrn.Text);
                    theSpell.Buy        = Convert.ToInt32(txtSplBuy.Text);
                    theSpell.Sell       = Convert.ToInt32(txtSplSel.Text);
                }
            }
            catch
            {
                lblSplWrn.Text = "Not all boxes were filled or not filled correctly";
            }

            if (pass)
            {
                this.Close();
            }
        }
    }
}
