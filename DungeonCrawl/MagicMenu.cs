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
    public partial class MagicMenu : Form
    {
        private bool equip;
        private int num = 0;
        private Player p;
        private List<Button> btnList = new List<Button>();
        private SpellInventoryForm splInv;
        private Spell[] spells;

        public MagicMenu()
        {
            InitializeComponent();
        }

        private void MagicMenu_Load(object sender, EventArgs e)
        {
            num = 0;
            btnList.Add(btnMgcSlot1);
            btnList.Add(btnMgcSlot2);
            btnList.Add(btnMgcSlot3);
            btnList.Add(btnMgcSlot4);
            ReloadMenu(spells);
        }

        public Player EquipSpell(Player ply)
        {
            p = ply;
            spells = ply.EquippedSpls;

            equip = true;

            this.ShowDialog();

            return p;
        }

        public int CastSpell(Player ply)
        {
            p = ply;
            spells = p.EquippedSpls;

            equip = false;

            this.ShowDialog();

            return num;
        }

        private void ReloadMenu(Spell[] spells)
        {
            for(int i = 0; i < spells.Count(); i++)
            {
                if (spells[i] != null)
                {
                    btnList[i].Text = spells[i].SpellName;
                    btnList[i].Tag = spells[i];
                    btnList[i].Enabled = true;
                }
                else
                {
                    btnList[i].Text = "Empty";
                    if (!equip)
                    {
                        btnList[i].Enabled = false;
                    }
                    else
                    {
                        btnList[i].Enabled= true;
                    }
                }
            }
        }

        private void btnMgcSlot1_Click(object sender, EventArgs e)
        {
            if (equip)
            {
                num = 1;
                LoadSplInv(p, num);
            }
            else
            {
                if(btnMgcSlot1.Tag != null)
                {
                    num = 1;
                }
            }

            this.Close();
        }

        private void btnMgcSlot2_Click(object sender, EventArgs e)
        {
            if (equip)
            {
                num = 2;
                LoadSplInv(p, num);
            }
            else
            {
                if (btnMgcSlot2.Tag != null)
                {
                    num = 2;
                }
            }

            this.Close();
        }

        private void btnMgcSlot3_Click(object sender, EventArgs e)
        {
            if (equip)
            {
                num = 3;
                LoadSplInv(p, num);
            }
            else
            {
                if (btnMgcSlot3.Tag != null)
                {
                    num = 3;
                }
            }

            this.Close();
        }

        private void btnMgcSlot4_Click(object sender, EventArgs e)
        {
            if (equip)
            {
                num = 4;
                LoadSplInv(p, num);
            }
            else
            {
                if (btnMgcSlot4.Tag != null)
                {
                    num = 4;
                }
            }

            this.Close();
        }

        private void BtnCnl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadSplInv(Player ply, int num)
        {
            splInv = new SpellInventoryForm();

            p = splInv.OpenSpellInv(ply, num - 1);
        }
    }
}
