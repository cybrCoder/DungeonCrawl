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
    public partial class ResultsForm : Form
    {
        private PlayerManager pManager = new PlayerManager();


        public ResultsForm()
        {
            InitializeComponent();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            ReloadPlayers();
        }

        public void Results(Player p)
        {
            if (p.Escaped)
            {
                lblTitle.Text = "Congradulations!! \nYou have Escaped!!";
            }
            else
            {
                lblTitle.Text = "You have Perished!!!";
            }

            pManager.AddsPlayer(p);

            this.ShowDialog();
        }

        private void ReloadPlayers()
        {
            lstvwPly.Columns.Clear();

            lstvwPly.Columns.Add("ID", 50, HorizontalAlignment.Left);
            lstvwPly.Columns.Add("Alias", 100, HorizontalAlignment.Left);
            lstvwPly.Columns.Add("Level", 50, HorizontalAlignment.Left);
            lstvwPly.Columns.Add("Gold", 75, HorizontalAlignment.Left);
            lstvwPly.Columns.Add("Escaped", 60, HorizontalAlignment.Left);
            lstvwPly.Columns.Add("Dead", 60, HorizontalAlignment.Left);

            lstvwPly.Items.Clear();

            List<Player> plys = pManager.GetsAllPlayers();
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
