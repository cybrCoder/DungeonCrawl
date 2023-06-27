namespace DungeonCrawl
{
    partial class ItemForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblAttPow = new System.Windows.Forms.Label();
            this.lblBuy = new System.Windows.Forms.Label();
            this.lblSell = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAttPow = new System.Windows.Forms.TextBox();
            this.txtBuy = new System.Windows.Forms.TextBox();
            this.txtSell = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblWarn = new System.Windows.Forms.Label();
            this.lblWpnLevel = new System.Windows.Forms.Label();
            this.txtWpnLevel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblAttPow
            // 
            this.lblAttPow.AutoSize = true;
            this.lblAttPow.Location = new System.Drawing.Point(25, 105);
            this.lblAttPow.Name = "lblAttPow";
            this.lblAttPow.Size = new System.Drawing.Size(74, 13);
            this.lblAttPow.TabIndex = 1;
            this.lblAttPow.Text = "Attack Power:";
            // 
            // lblBuy
            // 
            this.lblBuy.AutoSize = true;
            this.lblBuy.Location = new System.Drawing.Point(25, 146);
            this.lblBuy.Name = "lblBuy";
            this.lblBuy.Size = new System.Drawing.Size(55, 13);
            this.lblBuy.TabIndex = 2;
            this.lblBuy.Text = "Buy Price:";
            // 
            // lblSell
            // 
            this.lblSell.AutoSize = true;
            this.lblSell.Location = new System.Drawing.Point(25, 187);
            this.lblSell.Name = "lblSell";
            this.lblSell.Size = new System.Drawing.Size(54, 13);
            this.lblSell.TabIndex = 3;
            this.lblSell.Text = "Sell Price:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(105, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(142, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtAttPow
            // 
            this.txtAttPow.Location = new System.Drawing.Point(105, 102);
            this.txtAttPow.Name = "txtAttPow";
            this.txtAttPow.Size = new System.Drawing.Size(31, 20);
            this.txtAttPow.TabIndex = 5;
            // 
            // txtBuy
            // 
            this.txtBuy.Location = new System.Drawing.Point(105, 143);
            this.txtBuy.Name = "txtBuy";
            this.txtBuy.Size = new System.Drawing.Size(31, 20);
            this.txtBuy.TabIndex = 6;
            // 
            // txtSell
            // 
            this.txtSell.Location = new System.Drawing.Point(105, 184);
            this.txtSell.Name = "txtSell";
            this.txtSell.Size = new System.Drawing.Size(31, 20);
            this.txtSell.TabIndex = 7;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(61, 230);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 8;
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(172, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblWarn
            // 
            this.lblWarn.AutoSize = true;
            this.lblWarn.ForeColor = System.Drawing.Color.Red;
            this.lblWarn.Location = new System.Drawing.Point(133, 273);
            this.lblWarn.Name = "lblWarn";
            this.lblWarn.Size = new System.Drawing.Size(35, 13);
            this.lblWarn.TabIndex = 10;
            this.lblWarn.Text = "label1";
            this.lblWarn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWpnLevel
            // 
            this.lblWpnLevel.AutoSize = true;
            this.lblWpnLevel.Location = new System.Drawing.Point(28, 68);
            this.lblWpnLevel.Name = "lblWpnLevel";
            this.lblWpnLevel.Size = new System.Drawing.Size(36, 13);
            this.lblWpnLevel.TabIndex = 11;
            this.lblWpnLevel.Text = "Level:";
            // 
            // txtWpnLevel
            // 
            this.txtWpnLevel.Location = new System.Drawing.Point(105, 65);
            this.txtWpnLevel.Name = "txtWpnLevel";
            this.txtWpnLevel.Size = new System.Drawing.Size(100, 20);
            this.txtWpnLevel.TabIndex = 12;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 303);
            this.Controls.Add(this.txtWpnLevel);
            this.Controls.Add(this.lblWpnLevel);
            this.Controls.Add(this.lblWarn);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtSell);
            this.Controls.Add(this.txtBuy);
            this.Controls.Add(this.txtAttPow);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSell);
            this.Controls.Add(this.lblBuy);
            this.Controls.Add(this.lblAttPow);
            this.Controls.Add(this.lblName);
            this.Name = "ItemForm";
            this.Text = "ItemForm";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAttPow;
        private System.Windows.Forms.Label lblBuy;
        private System.Windows.Forms.Label lblSell;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAttPow;
        private System.Windows.Forms.TextBox txtBuy;
        private System.Windows.Forms.TextBox txtSell;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblWarn;
        private System.Windows.Forms.Label lblWpnLevel;
        private System.Windows.Forms.TextBox txtWpnLevel;
    }
}