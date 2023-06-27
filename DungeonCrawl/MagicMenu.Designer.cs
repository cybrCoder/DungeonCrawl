namespace DungeonCrawl
{
    partial class MagicMenu
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
            this.btnMgcSlot1 = new System.Windows.Forms.Button();
            this.btnMgcSlot2 = new System.Windows.Forms.Button();
            this.btnMgcSlot3 = new System.Windows.Forms.Button();
            this.btnMgcSlot4 = new System.Windows.Forms.Button();
            this.BtnCnl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMgcSlot1
            // 
            this.btnMgcSlot1.Location = new System.Drawing.Point(40, 27);
            this.btnMgcSlot1.Name = "btnMgcSlot1";
            this.btnMgcSlot1.Size = new System.Drawing.Size(130, 23);
            this.btnMgcSlot1.TabIndex = 0;
            this.btnMgcSlot1.Text = "Slot 1";
            this.btnMgcSlot1.UseVisualStyleBackColor = true;
            this.btnMgcSlot1.Click += new System.EventHandler(this.btnMgcSlot1_Click);
            // 
            // btnMgcSlot2
            // 
            this.btnMgcSlot2.Location = new System.Drawing.Point(40, 57);
            this.btnMgcSlot2.Name = "btnMgcSlot2";
            this.btnMgcSlot2.Size = new System.Drawing.Size(130, 23);
            this.btnMgcSlot2.TabIndex = 1;
            this.btnMgcSlot2.Text = "Slot 2";
            this.btnMgcSlot2.UseVisualStyleBackColor = true;
            this.btnMgcSlot2.Click += new System.EventHandler(this.btnMgcSlot2_Click);
            // 
            // btnMgcSlot3
            // 
            this.btnMgcSlot3.Location = new System.Drawing.Point(40, 87);
            this.btnMgcSlot3.Name = "btnMgcSlot3";
            this.btnMgcSlot3.Size = new System.Drawing.Size(130, 23);
            this.btnMgcSlot3.TabIndex = 2;
            this.btnMgcSlot3.Text = "Slot 3";
            this.btnMgcSlot3.UseVisualStyleBackColor = true;
            this.btnMgcSlot3.Click += new System.EventHandler(this.btnMgcSlot3_Click);
            // 
            // btnMgcSlot4
            // 
            this.btnMgcSlot4.Location = new System.Drawing.Point(40, 117);
            this.btnMgcSlot4.Name = "btnMgcSlot4";
            this.btnMgcSlot4.Size = new System.Drawing.Size(130, 23);
            this.btnMgcSlot4.TabIndex = 3;
            this.btnMgcSlot4.Text = "Slot 4";
            this.btnMgcSlot4.UseVisualStyleBackColor = true;
            this.btnMgcSlot4.Click += new System.EventHandler(this.btnMgcSlot4_Click);
            // 
            // BtnCnl
            // 
            this.BtnCnl.Location = new System.Drawing.Point(40, 147);
            this.BtnCnl.Name = "BtnCnl";
            this.BtnCnl.Size = new System.Drawing.Size(130, 23);
            this.BtnCnl.TabIndex = 4;
            this.BtnCnl.Text = "Cancel";
            this.BtnCnl.UseVisualStyleBackColor = true;
            this.BtnCnl.Click += new System.EventHandler(this.BtnCnl_Click);
            // 
            // MagicMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 197);
            this.Controls.Add(this.BtnCnl);
            this.Controls.Add(this.btnMgcSlot4);
            this.Controls.Add(this.btnMgcSlot3);
            this.Controls.Add(this.btnMgcSlot2);
            this.Controls.Add(this.btnMgcSlot1);
            this.Name = "MagicMenu";
            this.Text = "MagicMenu";
            this.Load += new System.EventHandler(this.MagicMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMgcSlot1;
        private System.Windows.Forms.Button btnMgcSlot2;
        private System.Windows.Forms.Button btnMgcSlot3;
        private System.Windows.Forms.Button btnMgcSlot4;
        private System.Windows.Forms.Button BtnCnl;
    }
}