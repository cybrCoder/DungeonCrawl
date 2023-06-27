namespace DungeonCrawl
{
    partial class StoreForm
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
            this.tabStore = new System.Windows.Forms.TabControl();
            this.tpgBuy = new System.Windows.Forms.TabPage();
            this.lblWarn1 = new System.Windows.Forms.Label();
            this.btnBuyPotion = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lstvwBuy = new System.Windows.Forms.ListView();
            this.tpgSell = new System.Windows.Forms.TabPage();
            this.lblWarn2 = new System.Windows.Forms.Label();
            this.btnSell = new System.Windows.Forms.Button();
            this.lstvwSell = new System.Windows.Forms.ListView();
            this.lblPlyGoldTitle = new System.Windows.Forms.Label();
            this.lblPlyGold = new System.Windows.Forms.Label();
            this.tabStore.SuspendLayout();
            this.tpgBuy.SuspendLayout();
            this.tpgSell.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabStore
            // 
            this.tabStore.Controls.Add(this.tpgBuy);
            this.tabStore.Controls.Add(this.tpgSell);
            this.tabStore.Location = new System.Drawing.Point(13, 13);
            this.tabStore.Name = "tabStore";
            this.tabStore.SelectedIndex = 0;
            this.tabStore.Size = new System.Drawing.Size(505, 451);
            this.tabStore.TabIndex = 0;
            // 
            // tpgBuy
            // 
            this.tpgBuy.Controls.Add(this.lblWarn1);
            this.tpgBuy.Controls.Add(this.btnBuyPotion);
            this.tpgBuy.Controls.Add(this.btnBuy);
            this.tpgBuy.Controls.Add(this.lstvwBuy);
            this.tpgBuy.Location = new System.Drawing.Point(4, 22);
            this.tpgBuy.Name = "tpgBuy";
            this.tpgBuy.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpgBuy.Size = new System.Drawing.Size(497, 425);
            this.tpgBuy.TabIndex = 0;
            this.tpgBuy.Text = "Buy";
            this.tpgBuy.UseVisualStyleBackColor = true;
            // 
            // lblWarn1
            // 
            this.lblWarn1.AutoSize = true;
            this.lblWarn1.ForeColor = System.Drawing.Color.Red;
            this.lblWarn1.Location = new System.Drawing.Point(146, 402);
            this.lblWarn1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWarn1.Name = "lblWarn1";
            this.lblWarn1.Size = new System.Drawing.Size(49, 13);
            this.lblWarn1.TabIndex = 3;
            this.lblWarn1.Text = "lblWarn1";
            this.lblWarn1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBuyPotion
            // 
            this.btnBuyPotion.Location = new System.Drawing.Point(308, 365);
            this.btnBuyPotion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuyPotion.Name = "btnBuyPotion";
            this.btnBuyPotion.Size = new System.Drawing.Size(97, 29);
            this.btnBuyPotion.TabIndex = 2;
            this.btnBuyPotion.Text = "HP Potion: 45g";
            this.btnBuyPotion.UseVisualStyleBackColor = true;
            this.btnBuyPotion.Click += new System.EventHandler(this.btnBuyPotion_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(102, 365);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(78, 29);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lstvwBuy
            // 
            this.lstvwBuy.FullRowSelect = true;
            this.lstvwBuy.GridLines = true;
            this.lstvwBuy.Location = new System.Drawing.Point(7, 7);
            this.lstvwBuy.Name = "lstvwBuy";
            this.lstvwBuy.Size = new System.Drawing.Size(484, 334);
            this.lstvwBuy.TabIndex = 0;
            this.lstvwBuy.UseCompatibleStateImageBehavior = false;
            this.lstvwBuy.View = System.Windows.Forms.View.Details;
            // 
            // tpgSell
            // 
            this.tpgSell.Controls.Add(this.lblWarn2);
            this.tpgSell.Controls.Add(this.btnSell);
            this.tpgSell.Controls.Add(this.lstvwSell);
            this.tpgSell.Location = new System.Drawing.Point(4, 22);
            this.tpgSell.Name = "tpgSell";
            this.tpgSell.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpgSell.Size = new System.Drawing.Size(497, 425);
            this.tpgSell.TabIndex = 1;
            this.tpgSell.Text = "Sell";
            this.tpgSell.UseVisualStyleBackColor = true;
            // 
            // lblWarn2
            // 
            this.lblWarn2.AutoSize = true;
            this.lblWarn2.ForeColor = System.Drawing.Color.Red;
            this.lblWarn2.Location = new System.Drawing.Point(161, 401);
            this.lblWarn2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWarn2.Name = "lblWarn2";
            this.lblWarn2.Size = new System.Drawing.Size(49, 13);
            this.lblWarn2.TabIndex = 2;
            this.lblWarn2.Text = "lblWarn2";
            this.lblWarn2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(194, 358);
            this.btnSell.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(78, 29);
            this.btnSell.TabIndex = 1;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // lstvwSell
            // 
            this.lstvwSell.FullRowSelect = true;
            this.lstvwSell.GridLines = true;
            this.lstvwSell.Location = new System.Drawing.Point(7, 7);
            this.lstvwSell.Name = "lstvwSell";
            this.lstvwSell.Size = new System.Drawing.Size(484, 333);
            this.lstvwSell.TabIndex = 0;
            this.lstvwSell.UseCompatibleStateImageBehavior = false;
            this.lstvwSell.View = System.Windows.Forms.View.Details;
            // 
            // lblPlyGoldTitle
            // 
            this.lblPlyGoldTitle.AutoSize = true;
            this.lblPlyGoldTitle.Location = new System.Drawing.Point(196, 486);
            this.lblPlyGoldTitle.Name = "lblPlyGoldTitle";
            this.lblPlyGoldTitle.Size = new System.Drawing.Size(64, 13);
            this.lblPlyGoldTitle.TabIndex = 1;
            this.lblPlyGoldTitle.Text = "Player Gold:";
            // 
            // lblPlyGold
            // 
            this.lblPlyGold.AutoSize = true;
            this.lblPlyGold.Location = new System.Drawing.Point(266, 486);
            this.lblPlyGold.Name = "lblPlyGold";
            this.lblPlyGold.Size = new System.Drawing.Size(35, 13);
            this.lblPlyGold.TabIndex = 2;
            this.lblPlyGold.Text = "label2";
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 511);
            this.Controls.Add(this.lblPlyGold);
            this.Controls.Add(this.lblPlyGoldTitle);
            this.Controls.Add(this.tabStore);
            this.Name = "StoreForm";
            this.Text = "StoreForm";
            this.Load += new System.EventHandler(this.StoreForm_Load);
            this.tabStore.ResumeLayout(false);
            this.tpgBuy.ResumeLayout(false);
            this.tpgBuy.PerformLayout();
            this.tpgSell.ResumeLayout(false);
            this.tpgSell.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabStore;
        private System.Windows.Forms.TabPage tpgBuy;
        private System.Windows.Forms.TabPage tpgSell;
        private System.Windows.Forms.Label lblPlyGoldTitle;
        private System.Windows.Forms.Label lblPlyGold;
        internal System.Windows.Forms.ListView lstvwBuy;
        internal System.Windows.Forms.ListView lstvwSell;
        private System.Windows.Forms.Label lblWarn1;
        private System.Windows.Forms.Button btnBuyPotion;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label lblWarn2;
        private System.Windows.Forms.Button btnSell;
    }
}