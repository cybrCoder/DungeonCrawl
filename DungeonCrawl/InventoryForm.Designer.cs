namespace DungeonCrawl
{
    partial class InventoryForm
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
            this.lstvwInventory = new System.Windows.Forms.ListView();
            this.btnEquip = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWarn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstvwInventory
            // 
            this.lstvwInventory.FullRowSelect = true;
            this.lstvwInventory.GridLines = true;
            this.lstvwInventory.Location = new System.Drawing.Point(17, 16);
            this.lstvwInventory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstvwInventory.MultiSelect = false;
            this.lstvwInventory.Name = "lstvwInventory";
            this.lstvwInventory.Size = new System.Drawing.Size(748, 457);
            this.lstvwInventory.TabIndex = 0;
            this.lstvwInventory.UseCompatibleStateImageBehavior = false;
            this.lstvwInventory.View = System.Windows.Forms.View.Details;
            this.lstvwInventory.SelectedIndexChanged += new System.EventHandler(this.lstvwInventory_SelectedIndexChanged);
            // 
            // btnEquip
            // 
            this.btnEquip.Location = new System.Drawing.Point(179, 512);
            this.btnEquip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEquip.Name = "btnEquip";
            this.btnEquip.Size = new System.Drawing.Size(100, 28);
            this.btnEquip.TabIndex = 1;
            this.btnEquip.Text = "Equip";
            this.btnEquip.UseVisualStyleBackColor = true;
            this.btnEquip.Click += new System.EventHandler(this.btnEquip_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(495, 512);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Return";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWarn
            // 
            this.lblWarn.AutoSize = true;
            this.lblWarn.ForeColor = System.Drawing.Color.Red;
            this.lblWarn.Location = new System.Drawing.Point(272, 565);
            this.lblWarn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarn.Name = "lblWarn";
            this.lblWarn.Size = new System.Drawing.Size(0, 17);
            this.lblWarn.TabIndex = 3;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 596);
            this.Controls.Add(this.lblWarn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEquip);
            this.Controls.Add(this.lstvwInventory);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InventoryForm";
            this.Text = "InventoryForm";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListView lstvwInventory;
        private System.Windows.Forms.Button btnEquip;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWarn;
    }
}