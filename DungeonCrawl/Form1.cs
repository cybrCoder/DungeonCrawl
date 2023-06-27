using DungeonCrawl.Business;
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
    /*
    *auth: Chandler Benes
    *date: 2/3/2017
    *updated: 11/30/2017 - 12/12/2017
    */
    public partial class Form1 : Form
    {
        private AdminManager aManager = new AdminManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdminLogIn_Click(object sender, EventArgs e)
        {
            bool flag = false;
            try
            {
                List<Admininster> ads = aManager.GetAllAdmins();
                foreach (Admininster a in ads)
                {
                    if (txtUserName.Text == a.UserName)
                    {
                        if (Encryption.ValidatePassword(txtPass.Text, a.Password))
                        {
                            flag = true;
                        }
                    }
                }

                txtUserName.Text = "";
                txtPass.Text = "";

                if (flag)
                {
                    Admin adForm = new Admin();
                    adForm.ShowDialog();
                }
                else
                {
                    lblWarn2.Text = "User or Password is wrong";
                }
            }
            catch (SqlException sEx)
            {
                lblWarn2.Text = sEx.Message;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtAlias.Text.Trim() != "")
            {
                Player p = new Player(txtAlias.Text);
                GameBoard board = new GameBoard();
                this.Hide();
                board.BeginGame(p);
                this.Show();
                txtAlias.Text = "";
                //this.Close();
            }
            else
            {
                lblWarn.Text = "TextBox must be filled in";
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() != "" || txtPass.Text.Trim() != "")
            {
                bool flag = true;
                Admininster ad = new Admininster();
                try
                {
                    List<Admininster> ads = aManager.GetAllAdmins();
                    foreach (Admininster a in ads)
                    {
                        if (txtUserName.Text == a.UserName)
                        {
                            flag = false;
                        }
                    }

                    if (flag)
                    {
                        ad.UserName = txtUserName.Text;
                        ad.Password = txtPass.Text;

                        ad.Password = Encryption.EncryptPassword(ad.Password);

                        aManager.AddAdmin(ad);

                        lblWarn2.ForeColor = Color.Green;
                        lblWarn2.Text = "Admin added!";
                    }
                    else
                    {
                        lblWarn2.Text = "Username already used";
                    }
                    lblWarn2.ForeColor = Color.Red;
                }
                catch (SqlException sEx)
                {
                    lblWarn2.Text = sEx.Message;
                }
            }
            else
            {
                lblWarn2.Text = "TextBox must be filled in";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
