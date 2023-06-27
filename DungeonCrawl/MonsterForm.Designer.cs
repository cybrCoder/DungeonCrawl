namespace DungeonCrawl
{
    partial class MonsterForm
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
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblAttPow = new System.Windows.Forms.Label();
            this.txtAttPow = new System.Windows.Forms.TextBox();
            this.txtHealth = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblWarn = new System.Windows.Forms.Label();
            this.lblAttNam = new System.Windows.Forms.Label();
            this.txtAttNam = new System.Windows.Forms.TextBox();
            this.lblMonLevel = new System.Windows.Forms.Label();
            this.txtMonLevel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(24, 95);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(41, 13);
            this.lblHealth.TabIndex = 1;
            this.lblHealth.Text = "Health:";
            // 
            // lblAttPow
            // 
            this.lblAttPow.AutoSize = true;
            this.lblAttPow.Location = new System.Drawing.Point(24, 158);
            this.lblAttPow.Name = "lblAttPow";
            this.lblAttPow.Size = new System.Drawing.Size(74, 13);
            this.lblAttPow.TabIndex = 2;
            this.lblAttPow.Text = "Attack Power:";
            // 
            // txtAttPow
            // 
            this.txtAttPow.Location = new System.Drawing.Point(104, 155);
            this.txtAttPow.Name = "txtAttPow";
            this.txtAttPow.Size = new System.Drawing.Size(46, 20);
            this.txtAttPow.TabIndex = 3;
            // 
            // txtHealth
            // 
            this.txtHealth.Location = new System.Drawing.Point(104, 92);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(46, 20);
            this.txtHealth.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 25);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 20);
            this.txtName.TabIndex = 5;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(54, 206);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 6;
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(169, 206);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblWarn
            // 
            this.lblWarn.AutoSize = true;
            this.lblWarn.ForeColor = System.Drawing.Color.Red;
            this.lblWarn.Location = new System.Drawing.Point(133, 249);
            this.lblWarn.Name = "lblWarn";
            this.lblWarn.Size = new System.Drawing.Size(35, 13);
            this.lblWarn.TabIndex = 8;
            this.lblWarn.Text = "label1";
            // 
            // lblAttNam
            // 
            this.lblAttNam.AutoSize = true;
            this.lblAttNam.Location = new System.Drawing.Point(24, 127);
            this.lblAttNam.Name = "lblAttNam";
            this.lblAttNam.Size = new System.Drawing.Size(72, 13);
            this.lblAttNam.TabIndex = 9;
            this.lblAttNam.Text = "Attack Name:";
            // 
            // txtAttNam
            // 
            this.txtAttNam.Location = new System.Drawing.Point(104, 124);
            this.txtAttNam.MaxLength = 30;
            this.txtAttNam.Name = "txtAttNam";
            this.txtAttNam.Size = new System.Drawing.Size(100, 20);
            this.txtAttNam.TabIndex = 10;
            // 
            // lblMonLevel
            // 
            this.lblMonLevel.AutoSize = true;
            this.lblMonLevel.Location = new System.Drawing.Point(27, 62);
            this.lblMonLevel.Name = "lblMonLevel";
            this.lblMonLevel.Size = new System.Drawing.Size(36, 13);
            this.lblMonLevel.TabIndex = 11;
            this.lblMonLevel.Text = "Level:";
            // 
            // txtMonLevel
            // 
            this.txtMonLevel.Location = new System.Drawing.Point(104, 59);
            this.txtMonLevel.Name = "txtMonLevel";
            this.txtMonLevel.Size = new System.Drawing.Size(100, 20);
            this.txtMonLevel.TabIndex = 12;
            // 
            // MonsterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 296);
            this.Controls.Add(this.txtMonLevel);
            this.Controls.Add(this.lblMonLevel);
            this.Controls.Add(this.txtAttNam);
            this.Controls.Add(this.lblAttNam);
            this.Controls.Add(this.lblWarn);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.txtAttPow);
            this.Controls.Add(this.lblAttPow);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.lblName);
            this.Name = "MonsterForm";
            this.Text = "MonsterForm";
            this.Load += new System.EventHandler(this.MonsterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblAttPow;
        private System.Windows.Forms.TextBox txtAttPow;
        private System.Windows.Forms.TextBox txtHealth;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblWarn;
        private System.Windows.Forms.Label lblAttNam;
        private System.Windows.Forms.TextBox txtAttNam;
        private System.Windows.Forms.Label lblMonLevel;
        private System.Windows.Forms.TextBox txtMonLevel;
    }
}