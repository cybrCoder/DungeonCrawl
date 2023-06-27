namespace DungeonCrawl
{
    partial class GameBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBoard));
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.lblAlias = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblHealthPts = new System.Windows.Forms.Label();
            this.lblEquipWpn = new System.Windows.Forms.Label();
            this.lblWpn = new System.Windows.Forms.Label();
            this.lblPotions = new System.Windows.Forms.Label();
            this.lblPotionsLeft = new System.Windows.Forms.Label();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnUsePotion = new System.Windows.Forms.Button();
            this.lblGoldTitle = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblMana = new System.Windows.Forms.Label();
            this.lblManaPts = new System.Windows.Forms.Label();
            this.btnMagicMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlBoard
            // 
            this.pnlBoard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBoard.BackgroundImage")));
            this.pnlBoard.Location = new System.Drawing.Point(29, 24);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(550, 400);
            this.pnlBoard.TabIndex = 0;
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(85, 457);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(27, 23);
            this.btnNorth.TabIndex = 1;
            this.btnNorth.Text = "/\\";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // btnWest
            // 
            this.btnWest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWest.Location = new System.Drawing.Point(54, 485);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(27, 23);
            this.btnWest.TabIndex = 2;
            this.btnWest.Text = "<";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
            // 
            // btnEast
            // 
            this.btnEast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEast.Location = new System.Drawing.Point(116, 485);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(27, 23);
            this.btnEast.TabIndex = 3;
            this.btnEast.Text = ">";
            this.btnEast.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(85, 514);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(27, 23);
            this.btnSouth.TabIndex = 4;
            this.btnSouth.Text = "\\/";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Location = new System.Drawing.Point(202, 454);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(35, 13);
            this.lblAlias.TabIndex = 5;
            this.lblAlias.Text = "label1";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(202, 478);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(41, 13);
            this.lblHealth.TabIndex = 6;
            this.lblHealth.Text = "Health:";
            // 
            // lblHealthPts
            // 
            this.lblHealthPts.AutoSize = true;
            this.lblHealthPts.Location = new System.Drawing.Point(249, 478);
            this.lblHealthPts.Name = "lblHealthPts";
            this.lblHealthPts.Size = new System.Drawing.Size(35, 13);
            this.lblHealthPts.TabIndex = 7;
            this.lblHealthPts.Text = "label1";
            // 
            // lblEquipWpn
            // 
            this.lblEquipWpn.AutoSize = true;
            this.lblEquipWpn.Location = new System.Drawing.Point(188, 527);
            this.lblEquipWpn.Name = "lblEquipWpn";
            this.lblEquipWpn.Size = new System.Drawing.Size(55, 13);
            this.lblEquipWpn.TabIndex = 8;
            this.lblEquipWpn.Text = "Equipped:";
            // 
            // lblWpn
            // 
            this.lblWpn.AutoSize = true;
            this.lblWpn.Location = new System.Drawing.Point(249, 527);
            this.lblWpn.Name = "lblWpn";
            this.lblWpn.Size = new System.Drawing.Size(35, 13);
            this.lblWpn.TabIndex = 9;
            this.lblWpn.Text = "label1";
            // 
            // lblPotions
            // 
            this.lblPotions.AutoSize = true;
            this.lblPotions.Location = new System.Drawing.Point(198, 550);
            this.lblPotions.Name = "lblPotions";
            this.lblPotions.Size = new System.Drawing.Size(45, 13);
            this.lblPotions.TabIndex = 10;
            this.lblPotions.Text = "Potions:";
            // 
            // lblPotionsLeft
            // 
            this.lblPotionsLeft.AutoSize = true;
            this.lblPotionsLeft.Location = new System.Drawing.Point(249, 550);
            this.lblPotionsLeft.Name = "lblPotionsLeft";
            this.lblPotionsLeft.Size = new System.Drawing.Size(35, 13);
            this.lblPotionsLeft.TabIndex = 11;
            this.lblPotionsLeft.Text = "label1";
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(488, 454);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(75, 23);
            this.btnInventory.TabIndex = 12;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnStore
            // 
            this.btnStore.Location = new System.Drawing.Point(488, 484);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(75, 23);
            this.btnStore.TabIndex = 13;
            this.btnStore.Text = "Store";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnUsePotion
            // 
            this.btnUsePotion.Location = new System.Drawing.Point(488, 514);
            this.btnUsePotion.Name = "btnUsePotion";
            this.btnUsePotion.Size = new System.Drawing.Size(75, 23);
            this.btnUsePotion.TabIndex = 14;
            this.btnUsePotion.Text = "Use Potion";
            this.btnUsePotion.UseVisualStyleBackColor = true;
            this.btnUsePotion.Click += new System.EventHandler(this.btnUsePotion_Click);
            // 
            // lblGoldTitle
            // 
            this.lblGoldTitle.AutoSize = true;
            this.lblGoldTitle.Location = new System.Drawing.Point(211, 573);
            this.lblGoldTitle.Name = "lblGoldTitle";
            this.lblGoldTitle.Size = new System.Drawing.Size(32, 13);
            this.lblGoldTitle.TabIndex = 15;
            this.lblGoldTitle.Text = "Gold:";
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(249, 573);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(35, 13);
            this.lblGold.TabIndex = 16;
            this.lblGold.Text = "label1";
            // 
            // lblMana
            // 
            this.lblMana.AutoSize = true;
            this.lblMana.Location = new System.Drawing.Point(206, 504);
            this.lblMana.Name = "lblMana";
            this.lblMana.Size = new System.Drawing.Size(37, 13);
            this.lblMana.TabIndex = 17;
            this.lblMana.Text = "Mana:";
            // 
            // lblManaPts
            // 
            this.lblManaPts.AutoSize = true;
            this.lblManaPts.Location = new System.Drawing.Point(249, 504);
            this.lblManaPts.Name = "lblManaPts";
            this.lblManaPts.Size = new System.Drawing.Size(35, 13);
            this.lblManaPts.TabIndex = 18;
            this.lblManaPts.Text = "label1";
            // 
            // btnMagicMenu
            // 
            this.btnMagicMenu.Location = new System.Drawing.Point(488, 544);
            this.btnMagicMenu.Name = "btnMagicMenu";
            this.btnMagicMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMagicMenu.TabIndex = 19;
            this.btnMagicMenu.Text = "Spell Menu";
            this.btnMagicMenu.UseVisualStyleBackColor = true;
            this.btnMagicMenu.Click += new System.EventHandler(this.btnMagicMenu_Click);
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 591);
            this.Controls.Add(this.btnMagicMenu);
            this.Controls.Add(this.lblManaPts);
            this.Controls.Add(this.lblMana);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblGoldTitle);
            this.Controls.Add(this.btnUsePotion);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.lblPotionsLeft);
            this.Controls.Add(this.lblPotions);
            this.Controls.Add(this.lblWpn);
            this.Controls.Add(this.lblEquipWpn);
            this.Controls.Add(this.lblHealthPts);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.lblAlias);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.pnlBoard);
            this.Name = "GameBoard";
            this.Text = "GameBoard";
            this.Load += new System.EventHandler(this.GameBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblHealthPts;
        private System.Windows.Forms.Label lblEquipWpn;
        private System.Windows.Forms.Label lblWpn;
        private System.Windows.Forms.Label lblPotions;
        private System.Windows.Forms.Label lblPotionsLeft;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button btnUsePotion;
        private System.Windows.Forms.Label lblGoldTitle;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblMana;
        private System.Windows.Forms.Label lblManaPts;
        private System.Windows.Forms.Button btnMagicMenu;
    }
}