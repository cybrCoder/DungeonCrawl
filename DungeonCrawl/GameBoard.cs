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
    public partial class GameBoard : Form
    {
        private Player ply = null;
        private Board board = new Board();

        public GameBoard()
        {
            InitializeComponent();
            btnNorth.PreviewKeyDown += new PreviewKeyDownEventHandler(Move_PreviewKeyDown);
            btnNorth.KeyDown += new KeyEventHandler(Move_KeyDown);
        }

        public void BeginGame (Player p)
        {
            ply = p;
            this.ShowDialog();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            ply = board.Inventory();
            LoadPlayerInfo();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            ply = board.Store();
            LoadPlayerInfo();
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
            LoadPlayerInfo();
            board.SpawnPlayer(ply, pnlBoard);
        }

        private void btnUsePotion_Click(object sender, EventArgs e)
        {
            ply = board.UsePotion();
            LoadPlayerInfo();
        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            ply = board.Move("N");
            LoadPlayerInfo();
            EndGame();
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            ply = board.Move("S");
            LoadPlayerInfo();
            EndGame();
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            ply = board.Move("W");
            LoadPlayerInfo();
            EndGame();
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            ply = board.Move("E");
            LoadPlayerInfo();
            EndGame();
        }

        private void LoadPlayerInfo()
        {
            lblAlias.Text = ply.PlayerName + " Lv. " + ply.Level;
            lblHealthPts.Text = ply.Health.ToString();
            lblManaPts.Text = ply.Mana.ToString();
            lblPotionsLeft.Text = ply.HealthPotion.ToString();
            lblWpn.Text = ply.EquippedWeapon.Name;
            lblGold.Text = ply.Gold.ToString();
        }

        private void EndGame()
        {
            if(ply.Escaped || ply.Health <= 0)
            {
                //go to results
                ResultsForm resForm = new ResultsForm();
                this.Hide();
                resForm.Results(ply);
                //MessageBox.Show("Game End");
                this.Close();
            }
        }
        
        private void Move_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    e.IsInputKey = true;
                    break;
                case Keys.Down:
                    e.IsInputKey = true;
                    break;
                case Keys.Left:
                    e.IsInputKey = true;
                    break;
                case Keys.Right:
                    e.IsInputKey = true;
                    break;
                case Keys.I:
                    e.IsInputKey = true;
                    break;
            }
        }

        private void Move_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    ply = board.Move("N");
                    break;
                case Keys.Down:
                    ply = board.Move("S");
                    break;
                case Keys.Left:
                    ply = board.Move("W");
                    break;
                case Keys.Right:
                    ply = board.Move("E");
                    break;
                case Keys.I:
                    ply = board.Inventory();
                    break;
            }
            LoadPlayerInfo();
            EndGame();
        }

        private void btnMagicMenu_Click(object sender, EventArgs e)
        {
            ply = board.MagicMenu();
            LoadPlayerInfo();
        }
    }
}
