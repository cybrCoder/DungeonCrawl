namespace DungeonCrawl
{
    partial class SpellInventoryForm
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
            this.lstvwSpellInventory = new System.Windows.Forms.ListView();
            this.btnEquip = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblWarn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstvwSpellInventory
            // 
            this.lstvwSpellInventory.FullRowSelect = true;
            this.lstvwSpellInventory.GridLines = true;
            this.lstvwSpellInventory.HideSelection = false;
            this.lstvwSpellInventory.Location = new System.Drawing.Point(13, 13);
            this.lstvwSpellInventory.MultiSelect = false;
            this.lstvwSpellInventory.Name = "lstvwSpellInventory";
            this.lstvwSpellInventory.Size = new System.Drawing.Size(615, 415);
            this.lstvwSpellInventory.TabIndex = 0;
            this.lstvwSpellInventory.UseCompatibleStateImageBehavior = false;
            this.lstvwSpellInventory.SelectedIndexChanged += new System.EventHandler(this.lstvwSpellInventory_SelectedIndexChanged);
            // 
            // btnEquip
            // 
            this.btnEquip.Location = new System.Drawing.Point(105, 467);
            this.btnEquip.Name = "btnEquip";
            this.btnEquip.Size = new System.Drawing.Size(75, 23);
            this.btnEquip.TabIndex = 1;
            this.btnEquip.Text = "Equip";
            this.btnEquip.UseVisualStyleBackColor = true;
            this.btnEquip.Click += new System.EventHandler(this.btnEquip_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(463, 467);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblWarn
            // 
            this.lblWarn.AutoSize = true;
            this.lblWarn.ForeColor = System.Drawing.Color.Red;
            this.lblWarn.Location = new System.Drawing.Point(181, 502);
            this.lblWarn.Name = "lblWarn";
            this.lblWarn.Size = new System.Drawing.Size(0, 13);
            this.lblWarn.TabIndex = 3;
            // 
            // SpellInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 533);
            this.Controls.Add(this.lblWarn);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEquip);
            this.Controls.Add(this.lstvwSpellInventory);
            this.Name = "SpellInventoryForm";
            this.Text = "SpellInventoryForm";
            this.Load += new System.EventHandler(this.SpellInventoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvwSpellInventory;
        private System.Windows.Forms.Button btnEquip;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblWarn;
    }
}