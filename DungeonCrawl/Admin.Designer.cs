namespace DungeonCrawl
{
    partial class Admin
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
            this.tbcAdmin = new System.Windows.Forms.TabControl();
            this.tbpPlayer = new System.Windows.Forms.TabPage();
            this.lblWarnPly = new System.Windows.Forms.Label();
            this.btnPlyDelete = new System.Windows.Forms.Button();
            this.lstvwPly = new System.Windows.Forms.ListView();
            this.tbpWeapons = new System.Windows.Forms.TabPage();
            this.lblWarnItems = new System.Windows.Forms.Label();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnUpdItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lstvwItems = new System.Windows.Forms.ListView();
            this.tbpMonsters = new System.Windows.Forms.TabPage();
            this.lblWarnMon = new System.Windows.Forms.Label();
            this.btnDelMon = new System.Windows.Forms.Button();
            this.btnUpdMon = new System.Windows.Forms.Button();
            this.btnAddMon = new System.Windows.Forms.Button();
            this.lstvwMons = new System.Windows.Forms.ListView();
            this.tbpSpells = new System.Windows.Forms.TabPage();
            this.btnDelSpl = new System.Windows.Forms.Button();
            this.btnUpdSpl = new System.Windows.Forms.Button();
            this.btnAddSpl = new System.Windows.Forms.Button();
            this.lblWarnSpl = new System.Windows.Forms.Label();
            this.lstvwSpell = new System.Windows.Forms.ListView();
            this.tbcAdmin.SuspendLayout();
            this.tbpPlayer.SuspendLayout();
            this.tbpWeapons.SuspendLayout();
            this.tbpMonsters.SuspendLayout();
            this.tbpSpells.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcAdmin
            // 
            this.tbcAdmin.Controls.Add(this.tbpPlayer);
            this.tbcAdmin.Controls.Add(this.tbpWeapons);
            this.tbcAdmin.Controls.Add(this.tbpMonsters);
            this.tbcAdmin.Controls.Add(this.tbpSpells);
            this.tbcAdmin.Location = new System.Drawing.Point(12, 12);
            this.tbcAdmin.Name = "tbcAdmin";
            this.tbcAdmin.SelectedIndex = 0;
            this.tbcAdmin.Size = new System.Drawing.Size(528, 425);
            this.tbcAdmin.TabIndex = 0;
            // 
            // tbpPlayer
            // 
            this.tbpPlayer.Controls.Add(this.lblWarnPly);
            this.tbpPlayer.Controls.Add(this.btnPlyDelete);
            this.tbpPlayer.Controls.Add(this.lstvwPly);
            this.tbpPlayer.Location = new System.Drawing.Point(4, 22);
            this.tbpPlayer.Name = "tbpPlayer";
            this.tbpPlayer.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPlayer.Size = new System.Drawing.Size(520, 399);
            this.tbpPlayer.TabIndex = 0;
            this.tbpPlayer.Text = "Players";
            this.tbpPlayer.UseVisualStyleBackColor = true;
            // 
            // lblWarnPly
            // 
            this.lblWarnPly.AutoSize = true;
            this.lblWarnPly.ForeColor = System.Drawing.Color.Red;
            this.lblWarnPly.Location = new System.Drawing.Point(239, 367);
            this.lblWarnPly.Name = "lblWarnPly";
            this.lblWarnPly.Size = new System.Drawing.Size(30, 13);
            this.lblWarnPly.TabIndex = 2;
            this.lblWarnPly.Text = "warn";
            this.lblWarnPly.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPlyDelete
            // 
            this.btnPlyDelete.Location = new System.Drawing.Point(219, 325);
            this.btnPlyDelete.Name = "btnPlyDelete";
            this.btnPlyDelete.Size = new System.Drawing.Size(75, 23);
            this.btnPlyDelete.TabIndex = 1;
            this.btnPlyDelete.Text = "Delete";
            this.btnPlyDelete.UseVisualStyleBackColor = true;
            this.btnPlyDelete.Click += new System.EventHandler(this.btnPlyDelete_Click);
            // 
            // lstvwPly
            // 
            this.lstvwPly.FullRowSelect = true;
            this.lstvwPly.GridLines = true;
            this.lstvwPly.Location = new System.Drawing.Point(15, 17);
            this.lstvwPly.MultiSelect = false;
            this.lstvwPly.Name = "lstvwPly";
            this.lstvwPly.Size = new System.Drawing.Size(488, 284);
            this.lstvwPly.TabIndex = 0;
            this.lstvwPly.UseCompatibleStateImageBehavior = false;
            this.lstvwPly.View = System.Windows.Forms.View.Details;
            // 
            // tbpWeapons
            // 
            this.tbpWeapons.Controls.Add(this.lblWarnItems);
            this.tbpWeapons.Controls.Add(this.btnDeleteItem);
            this.tbpWeapons.Controls.Add(this.btnUpdItem);
            this.tbpWeapons.Controls.Add(this.btnAddItem);
            this.tbpWeapons.Controls.Add(this.lstvwItems);
            this.tbpWeapons.Location = new System.Drawing.Point(4, 22);
            this.tbpWeapons.Name = "tbpWeapons";
            this.tbpWeapons.Padding = new System.Windows.Forms.Padding(3);
            this.tbpWeapons.Size = new System.Drawing.Size(520, 399);
            this.tbpWeapons.TabIndex = 1;
            this.tbpWeapons.Text = "Items";
            this.tbpWeapons.UseVisualStyleBackColor = true;
            // 
            // lblWarnItems
            // 
            this.lblWarnItems.AutoSize = true;
            this.lblWarnItems.ForeColor = System.Drawing.Color.Red;
            this.lblWarnItems.Location = new System.Drawing.Point(239, 367);
            this.lblWarnItems.Name = "lblWarnItems";
            this.lblWarnItems.Size = new System.Drawing.Size(30, 13);
            this.lblWarnItems.TabIndex = 4;
            this.lblWarnItems.Text = "warn";
            this.lblWarnItems.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(376, 321);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteItem.TabIndex = 3;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnUpdItem
            // 
            this.btnUpdItem.Location = new System.Drawing.Point(219, 321);
            this.btnUpdItem.Name = "btnUpdItem";
            this.btnUpdItem.Size = new System.Drawing.Size(75, 23);
            this.btnUpdItem.TabIndex = 2;
            this.btnUpdItem.Text = "Modify";
            this.btnUpdItem.UseVisualStyleBackColor = true;
            this.btnUpdItem.Click += new System.EventHandler(this.btnUpdItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(68, 322);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lstvwItems
            // 
            this.lstvwItems.FullRowSelect = true;
            this.lstvwItems.GridLines = true;
            this.lstvwItems.Location = new System.Drawing.Point(15, 19);
            this.lstvwItems.MultiSelect = false;
            this.lstvwItems.Name = "lstvwItems";
            this.lstvwItems.Size = new System.Drawing.Size(485, 272);
            this.lstvwItems.TabIndex = 0;
            this.lstvwItems.UseCompatibleStateImageBehavior = false;
            this.lstvwItems.View = System.Windows.Forms.View.Details;
            // 
            // tbpMonsters
            // 
            this.tbpMonsters.Controls.Add(this.lblWarnMon);
            this.tbpMonsters.Controls.Add(this.btnDelMon);
            this.tbpMonsters.Controls.Add(this.btnUpdMon);
            this.tbpMonsters.Controls.Add(this.btnAddMon);
            this.tbpMonsters.Controls.Add(this.lstvwMons);
            this.tbpMonsters.Location = new System.Drawing.Point(4, 22);
            this.tbpMonsters.Name = "tbpMonsters";
            this.tbpMonsters.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMonsters.Size = new System.Drawing.Size(520, 399);
            this.tbpMonsters.TabIndex = 2;
            this.tbpMonsters.Text = "Monsters";
            this.tbpMonsters.UseVisualStyleBackColor = true;
            // 
            // lblWarnMon
            // 
            this.lblWarnMon.AutoSize = true;
            this.lblWarnMon.ForeColor = System.Drawing.Color.Red;
            this.lblWarnMon.Location = new System.Drawing.Point(239, 367);
            this.lblWarnMon.Name = "lblWarnMon";
            this.lblWarnMon.Size = new System.Drawing.Size(30, 13);
            this.lblWarnMon.TabIndex = 4;
            this.lblWarnMon.Text = "warn";
            this.lblWarnMon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDelMon
            // 
            this.btnDelMon.Location = new System.Drawing.Point(376, 321);
            this.btnDelMon.Name = "btnDelMon";
            this.btnDelMon.Size = new System.Drawing.Size(75, 23);
            this.btnDelMon.TabIndex = 3;
            this.btnDelMon.Text = "Delete";
            this.btnDelMon.UseVisualStyleBackColor = true;
            this.btnDelMon.Click += new System.EventHandler(this.btnDelMon_Click);
            // 
            // btnUpdMon
            // 
            this.btnUpdMon.Location = new System.Drawing.Point(219, 321);
            this.btnUpdMon.Name = "btnUpdMon";
            this.btnUpdMon.Size = new System.Drawing.Size(75, 23);
            this.btnUpdMon.TabIndex = 2;
            this.btnUpdMon.Text = "Modify";
            this.btnUpdMon.UseVisualStyleBackColor = true;
            this.btnUpdMon.Click += new System.EventHandler(this.btnUpdMon_Click);
            // 
            // btnAddMon
            // 
            this.btnAddMon.Location = new System.Drawing.Point(68, 322);
            this.btnAddMon.Name = "btnAddMon";
            this.btnAddMon.Size = new System.Drawing.Size(75, 23);
            this.btnAddMon.TabIndex = 1;
            this.btnAddMon.Text = "Add";
            this.btnAddMon.UseVisualStyleBackColor = true;
            this.btnAddMon.Click += new System.EventHandler(this.btnAddMon_Click);
            // 
            // lstvwMons
            // 
            this.lstvwMons.FullRowSelect = true;
            this.lstvwMons.GridLines = true;
            this.lstvwMons.Location = new System.Drawing.Point(18, 19);
            this.lstvwMons.MultiSelect = false;
            this.lstvwMons.Name = "lstvwMons";
            this.lstvwMons.Size = new System.Drawing.Size(485, 272);
            this.lstvwMons.TabIndex = 0;
            this.lstvwMons.UseCompatibleStateImageBehavior = false;
            this.lstvwMons.View = System.Windows.Forms.View.Details;
            // 
            // tbpSpells
            // 
            this.tbpSpells.Controls.Add(this.btnDelSpl);
            this.tbpSpells.Controls.Add(this.btnUpdSpl);
            this.tbpSpells.Controls.Add(this.btnAddSpl);
            this.tbpSpells.Controls.Add(this.lblWarnSpl);
            this.tbpSpells.Controls.Add(this.lstvwSpell);
            this.tbpSpells.Location = new System.Drawing.Point(4, 22);
            this.tbpSpells.Name = "tbpSpells";
            this.tbpSpells.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSpells.Size = new System.Drawing.Size(520, 399);
            this.tbpSpells.TabIndex = 3;
            this.tbpSpells.Text = "Spells";
            this.tbpSpells.UseVisualStyleBackColor = true;
            // 
            // btnDelSpl
            // 
            this.btnDelSpl.Location = new System.Drawing.Point(376, 321);
            this.btnDelSpl.Name = "btnDelSpl";
            this.btnDelSpl.Size = new System.Drawing.Size(75, 23);
            this.btnDelSpl.TabIndex = 4;
            this.btnDelSpl.Text = "Delete";
            this.btnDelSpl.UseVisualStyleBackColor = true;
            this.btnDelSpl.Click += new System.EventHandler(this.btnDelSpl_Click);
            // 
            // btnUpdSpl
            // 
            this.btnUpdSpl.Location = new System.Drawing.Point(219, 321);
            this.btnUpdSpl.Name = "btnUpdSpl";
            this.btnUpdSpl.Size = new System.Drawing.Size(75, 23);
            this.btnUpdSpl.TabIndex = 3;
            this.btnUpdSpl.Text = "Modify";
            this.btnUpdSpl.UseVisualStyleBackColor = true;
            this.btnUpdSpl.Click += new System.EventHandler(this.btnUpdSpl_Click);
            // 
            // btnAddSpl
            // 
            this.btnAddSpl.Location = new System.Drawing.Point(68, 322);
            this.btnAddSpl.Name = "btnAddSpl";
            this.btnAddSpl.Size = new System.Drawing.Size(75, 23);
            this.btnAddSpl.TabIndex = 2;
            this.btnAddSpl.Text = "Add";
            this.btnAddSpl.UseVisualStyleBackColor = true;
            this.btnAddSpl.Click += new System.EventHandler(this.btnAddSpl_Click);
            // 
            // lblWarnSpl
            // 
            this.lblWarnSpl.AutoSize = true;
            this.lblWarnSpl.ForeColor = System.Drawing.Color.Red;
            this.lblWarnSpl.Location = new System.Drawing.Point(239, 367);
            this.lblWarnSpl.Name = "lblWarnSpl";
            this.lblWarnSpl.Size = new System.Drawing.Size(30, 13);
            this.lblWarnSpl.TabIndex = 1;
            this.lblWarnSpl.Text = "warn";
            this.lblWarnSpl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstvwSpell
            // 
            this.lstvwSpell.FullRowSelect = true;
            this.lstvwSpell.GridLines = true;
            this.lstvwSpell.Location = new System.Drawing.Point(16, 17);
            this.lstvwSpell.MultiSelect = false;
            this.lstvwSpell.Name = "lstvwSpell";
            this.lstvwSpell.Size = new System.Drawing.Size(485, 272);
            this.lstvwSpell.TabIndex = 0;
            this.lstvwSpell.UseCompatibleStateImageBehavior = false;
            this.lstvwSpell.View = System.Windows.Forms.View.Details;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 449);
            this.Controls.Add(this.tbcAdmin);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tbcAdmin.ResumeLayout(false);
            this.tbpPlayer.ResumeLayout(false);
            this.tbpPlayer.PerformLayout();
            this.tbpWeapons.ResumeLayout(false);
            this.tbpWeapons.PerformLayout();
            this.tbpMonsters.ResumeLayout(false);
            this.tbpMonsters.PerformLayout();
            this.tbpSpells.ResumeLayout(false);
            this.tbpSpells.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcAdmin;
        private System.Windows.Forms.TabPage tbpPlayer;
        private System.Windows.Forms.TabPage tbpWeapons;
        private System.Windows.Forms.TabPage tbpMonsters;
        private System.Windows.Forms.Button btnPlyDelete;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnUpdItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnDelMon;
        private System.Windows.Forms.Button btnUpdMon;
        private System.Windows.Forms.Button btnAddMon;
        private System.Windows.Forms.Label lblWarnPly;
        private System.Windows.Forms.Label lblWarnItems;
        private System.Windows.Forms.Label lblWarnMon;
        internal System.Windows.Forms.ListView lstvwMons;
        internal System.Windows.Forms.ListView lstvwPly;
        internal System.Windows.Forms.ListView lstvwItems;
        private System.Windows.Forms.TabPage tbpSpells;
        internal System.Windows.Forms.ListView lstvwSpell;
        private System.Windows.Forms.Label lblWarnSpl;
        private System.Windows.Forms.Button btnDelSpl;
        private System.Windows.Forms.Button btnUpdSpl;
        private System.Windows.Forms.Button btnAddSpl;
    }
}