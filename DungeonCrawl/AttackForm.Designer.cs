namespace DungeonCrawl
{
    partial class AttackForm
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
            this.pbxMon = new System.Windows.Forms.PictureBox();
            this.barMonHealth = new System.Windows.Forms.ProgressBar();
            this.lstBattleInfo = new System.Windows.Forms.ListBox();
            this.lblPlyHpTitle = new System.Windows.Forms.Label();
            this.lblPlyHp = new System.Windows.Forms.Label();
            this.lblWeapTitle = new System.Windows.Forms.Label();
            this.lblWeapName = new System.Windows.Forms.Label();
            this.lblPotTitle = new System.Windows.Forms.Label();
            this.lblPotions = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnUse = new System.Windows.Forms.Button();
            this.btnFlee = new System.Windows.Forms.Button();
            this.lblMonName = new System.Windows.Forms.Label();
            this.btnMagic = new System.Windows.Forms.Button();
            this.lblManaTitle = new System.Windows.Forms.Label();
            this.lblManaPts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMon)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxMon
            // 
            this.pbxMon.Location = new System.Drawing.Point(13, 13);
            this.pbxMon.Name = "pbxMon";
            this.pbxMon.Size = new System.Drawing.Size(70, 66);
            this.pbxMon.TabIndex = 0;
            this.pbxMon.TabStop = false;
            // 
            // barMonHealth
            // 
            this.barMonHealth.BackColor = System.Drawing.Color.LawnGreen;
            this.barMonHealth.ForeColor = System.Drawing.Color.DarkRed;
            this.barMonHealth.Location = new System.Drawing.Point(100, 23);
            this.barMonHealth.Name = "barMonHealth";
            this.barMonHealth.Size = new System.Drawing.Size(324, 23);
            this.barMonHealth.TabIndex = 1;
            // 
            // lstBattleInfo
            // 
            this.lstBattleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBattleInfo.FormattingEnabled = true;
            this.lstBattleInfo.ItemHeight = 16;
            this.lstBattleInfo.Location = new System.Drawing.Point(100, 92);
            this.lstBattleInfo.Name = "lstBattleInfo";
            this.lstBattleInfo.Size = new System.Drawing.Size(324, 116);
            this.lstBattleInfo.TabIndex = 2;
            // 
            // lblPlyHpTitle
            // 
            this.lblPlyHpTitle.AutoSize = true;
            this.lblPlyHpTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlyHpTitle.Location = new System.Drawing.Point(24, 246);
            this.lblPlyHpTitle.Name = "lblPlyHpTitle";
            this.lblPlyHpTitle.Size = new System.Drawing.Size(53, 17);
            this.lblPlyHpTitle.TabIndex = 4;
            this.lblPlyHpTitle.Text = "Health:";
            // 
            // lblPlyHp
            // 
            this.lblPlyHp.AutoSize = true;
            this.lblPlyHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlyHp.Location = new System.Drawing.Point(89, 246);
            this.lblPlyHp.Name = "lblPlyHp";
            this.lblPlyHp.Size = new System.Drawing.Size(46, 17);
            this.lblPlyHp.TabIndex = 5;
            this.lblPlyHp.Text = "label2";
            // 
            // lblWeapTitle
            // 
            this.lblWeapTitle.AutoSize = true;
            this.lblWeapTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeapTitle.Location = new System.Drawing.Point(24, 294);
            this.lblWeapTitle.Name = "lblWeapTitle";
            this.lblWeapTitle.Size = new System.Drawing.Size(65, 17);
            this.lblWeapTitle.TabIndex = 6;
            this.lblWeapTitle.Text = "Weapon:";
            // 
            // lblWeapName
            // 
            this.lblWeapName.AutoSize = true;
            this.lblWeapName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeapName.Location = new System.Drawing.Point(89, 294);
            this.lblWeapName.Name = "lblWeapName";
            this.lblWeapName.Size = new System.Drawing.Size(46, 17);
            this.lblWeapName.TabIndex = 7;
            this.lblWeapName.Text = "label1";
            // 
            // lblPotTitle
            // 
            this.lblPotTitle.AutoSize = true;
            this.lblPotTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotTitle.Location = new System.Drawing.Point(24, 318);
            this.lblPotTitle.Name = "lblPotTitle";
            this.lblPotTitle.Size = new System.Drawing.Size(59, 17);
            this.lblPotTitle.TabIndex = 8;
            this.lblPotTitle.Text = "Potions:";
            // 
            // lblPotions
            // 
            this.lblPotions.AutoSize = true;
            this.lblPotions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotions.Location = new System.Drawing.Point(89, 318);
            this.lblPotions.Name = "lblPotions";
            this.lblPotions.Size = new System.Drawing.Size(46, 17);
            this.lblPotions.TabIndex = 9;
            this.lblPotions.Text = "label2";
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(324, 230);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(75, 23);
            this.btnAttack.TabIndex = 10;
            this.btnAttack.Text = "Attack!";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnUse
            // 
            this.btnUse.Location = new System.Drawing.Point(324, 288);
            this.btnUse.Name = "btnUse";
            this.btnUse.Size = new System.Drawing.Size(75, 23);
            this.btnUse.TabIndex = 11;
            this.btnUse.Text = "Use Potion";
            this.btnUse.UseVisualStyleBackColor = true;
            this.btnUse.Click += new System.EventHandler(this.btnUse_Click);
            // 
            // btnFlee
            // 
            this.btnFlee.Location = new System.Drawing.Point(324, 318);
            this.btnFlee.Name = "btnFlee";
            this.btnFlee.Size = new System.Drawing.Size(75, 23);
            this.btnFlee.TabIndex = 12;
            this.btnFlee.Text = "Fleeeee!";
            this.btnFlee.UseVisualStyleBackColor = true;
            this.btnFlee.Click += new System.EventHandler(this.btnFlee_Click);
            // 
            // lblMonName
            // 
            this.lblMonName.AutoSize = true;
            this.lblMonName.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonName.Location = new System.Drawing.Point(100, 53);
            this.lblMonName.Name = "lblMonName";
            this.lblMonName.Size = new System.Drawing.Size(61, 26);
            this.lblMonName.TabIndex = 13;
            this.lblMonName.Text = "label1";
            // 
            // btnMagic
            // 
            this.btnMagic.Location = new System.Drawing.Point(324, 259);
            this.btnMagic.Name = "btnMagic";
            this.btnMagic.Size = new System.Drawing.Size(75, 23);
            this.btnMagic.TabIndex = 14;
            this.btnMagic.Text = "Magic!";
            this.btnMagic.UseVisualStyleBackColor = true;
            this.btnMagic.Click += new System.EventHandler(this.btnMagic_Click);
            // 
            // lblManaTitle
            // 
            this.lblManaTitle.AutoSize = true;
            this.lblManaTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManaTitle.Location = new System.Drawing.Point(24, 270);
            this.lblManaTitle.Name = "lblManaTitle";
            this.lblManaTitle.Size = new System.Drawing.Size(47, 17);
            this.lblManaTitle.TabIndex = 15;
            this.lblManaTitle.Text = "Mana:";
            // 
            // lblManaPts
            // 
            this.lblManaPts.AutoSize = true;
            this.lblManaPts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManaPts.Location = new System.Drawing.Point(89, 270);
            this.lblManaPts.Name = "lblManaPts";
            this.lblManaPts.Size = new System.Drawing.Size(46, 17);
            this.lblManaPts.TabIndex = 16;
            this.lblManaPts.Text = "label1";
            // 
            // AttackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 350);
            this.Controls.Add(this.lblManaPts);
            this.Controls.Add(this.lblManaTitle);
            this.Controls.Add(this.btnMagic);
            this.Controls.Add(this.lblMonName);
            this.Controls.Add(this.btnFlee);
            this.Controls.Add(this.btnUse);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.lblPotions);
            this.Controls.Add(this.lblPotTitle);
            this.Controls.Add(this.lblWeapName);
            this.Controls.Add(this.lblWeapTitle);
            this.Controls.Add(this.lblPlyHp);
            this.Controls.Add(this.lblPlyHpTitle);
            this.Controls.Add(this.lstBattleInfo);
            this.Controls.Add(this.barMonHealth);
            this.Controls.Add(this.pbxMon);
            this.Name = "AttackForm";
            this.Text = "AttackForm";
            this.Load += new System.EventHandler(this.AttackForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxMon;
        private System.Windows.Forms.ProgressBar barMonHealth;
        private System.Windows.Forms.ListBox lstBattleInfo;
        private System.Windows.Forms.Label lblPlyHpTitle;
        private System.Windows.Forms.Label lblPlyHp;
        private System.Windows.Forms.Label lblWeapTitle;
        private System.Windows.Forms.Label lblWeapName;
        private System.Windows.Forms.Label lblPotTitle;
        private System.Windows.Forms.Label lblPotions;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnUse;
        private System.Windows.Forms.Button btnFlee;
        private System.Windows.Forms.Label lblMonName;
        private System.Windows.Forms.Button btnMagic;
        private System.Windows.Forms.Label lblManaTitle;
        private System.Windows.Forms.Label lblManaPts;
    }
}