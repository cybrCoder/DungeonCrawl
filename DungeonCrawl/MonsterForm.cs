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
    public partial class MonsterForm : Form
    {
        private Monster theMonster = null;
        private bool update = false;
        private List<TextBox> boxes = new List<TextBox>();

        public MonsterForm()
        {
            InitializeComponent();
        }

        public Monster AddMonster()
        {
            this.ShowDialog();

            return theMonster;
        }

        public Monster ModifyMonster(Monster m)
        {
            update = true;
            theMonster = m;

            this.ShowDialog();

            return theMonster;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MonsterForm_Load(object sender, EventArgs e)
        {
            btnEnter.Text = "Add";
            lblWarn.Text = "";

            boxes.Add(txtName);
            boxes.Add(txtMonLevel);
            boxes.Add(txtHealth);
            boxes.Add(txtAttNam);
            boxes.Add(txtAttPow);

            if (update)
            {
                btnEnter.Text = "Modify";

                txtName.Text = theMonster.MonsterName;
                txtMonLevel.Text = theMonster.MonLevel.ToString();
                txtHealth.Text = theMonster.MonHealth.ToString();
                txtAttNam.Text = theMonster.MonAttNam;
                txtAttPow.Text = theMonster.MonAttPower.ToString();
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
                        theMonster = new Monster();
                    }
                    theMonster.MonsterName = txtName.Text;
                    theMonster.MonLevel = Convert.ToInt32(txtMonLevel.Text);
                    theMonster.MonHealth = Convert.ToInt32(txtHealth.Text);
                    theMonster.MonAttNam = txtAttNam.Text;
                    theMonster.MonAttPower = Convert.ToInt32(txtAttPow.Text);
                }
            }
            catch
            {
                lblWarn.Text = "Not all boxes were filled or not filled correctly";
                pass = false;
            }

            if (pass)
            {
                this.Close();
            }
        }
    }
}
