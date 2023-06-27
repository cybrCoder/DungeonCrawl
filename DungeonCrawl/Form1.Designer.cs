namespace DungeonCrawl
{
    partial class Form1
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
            this.tabLogin = new System.Windows.Forms.TabControl();
            this.tbpGameStart = new System.Windows.Forms.TabPage();
            this.lblWarn = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.lblAlias = new System.Windows.Forms.Label();
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.tbpAdmin = new System.Windows.Forms.TabPage();
            this.btnReg = new System.Windows.Forms.Button();
            this.lblWarn2 = new System.Windows.Forms.Label();
            this.btnAdminLogIn = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.tabLogin.SuspendLayout();
            this.tbpGameStart.SuspendLayout();
            this.tbpAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.tbpGameStart);
            this.tabLogin.Controls.Add(this.tbpAdmin);
            this.tabLogin.Location = new System.Drawing.Point(12, 12);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.SelectedIndex = 0;
            this.tabLogin.Size = new System.Drawing.Size(492, 352);
            this.tabLogin.TabIndex = 0;
            // 
            // tbpGameStart
            // 
            this.tbpGameStart.Controls.Add(this.lblWarn);
            this.tbpGameStart.Controls.Add(this.btnStart);
            this.tbpGameStart.Controls.Add(this.txtAlias);
            this.tbpGameStart.Controls.Add(this.lblAlias);
            this.tbpGameStart.Controls.Add(this.lblGameTitle);
            this.tbpGameStart.Location = new System.Drawing.Point(4, 22);
            this.tbpGameStart.Name = "tbpGameStart";
            this.tbpGameStart.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGameStart.Size = new System.Drawing.Size(484, 326);
            this.tbpGameStart.TabIndex = 0;
            this.tbpGameStart.Text = "Start";
            this.tbpGameStart.UseVisualStyleBackColor = true;
            // 
            // lblWarn
            // 
            this.lblWarn.AutoSize = true;
            this.lblWarn.ForeColor = System.Drawing.Color.Red;
            this.lblWarn.Location = new System.Drawing.Point(179, 287);
            this.lblWarn.Name = "lblWarn";
            this.lblWarn.Size = new System.Drawing.Size(0, 13);
            this.lblWarn.TabIndex = 4;
            this.lblWarn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(182, 225);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(104, 37);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(114, 168);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(296, 20);
            this.txtAlias.TabIndex = 2;
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlias.Location = new System.Drawing.Point(61, 168);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(47, 20);
            this.lblAlias.TabIndex = 1;
            this.lblAlias.Text = "Alias:";
            // 
            // lblGameTitle
            // 
            this.lblGameTitle.AutoSize = true;
            this.lblGameTitle.Font = new System.Drawing.Font("MV Boli", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTitle.Location = new System.Drawing.Point(27, 52);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(405, 70);
            this.lblGameTitle.TabIndex = 0;
            this.lblGameTitle.Text = "Dungeon Crawl";
            this.lblGameTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbpAdmin
            // 
            this.tbpAdmin.Controls.Add(this.btnReg);
            this.tbpAdmin.Controls.Add(this.lblWarn2);
            this.tbpAdmin.Controls.Add(this.btnAdminLogIn);
            this.tbpAdmin.Controls.Add(this.lblAdmin);
            this.tbpAdmin.Controls.Add(this.txtPass);
            this.tbpAdmin.Controls.Add(this.txtUserName);
            this.tbpAdmin.Controls.Add(this.lblPassword);
            this.tbpAdmin.Controls.Add(this.lblAdminName);
            this.tbpAdmin.Location = new System.Drawing.Point(4, 22);
            this.tbpAdmin.Name = "tbpAdmin";
            this.tbpAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAdmin.Size = new System.Drawing.Size(484, 326);
            this.tbpAdmin.TabIndex = 1;
            this.tbpAdmin.Text = "Admin";
            this.tbpAdmin.UseVisualStyleBackColor = true;
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.Location = new System.Drawing.Point(279, 249);
            this.btnReg.Margin = new System.Windows.Forms.Padding(2);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(94, 38);
            this.btnReg.TabIndex = 7;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // lblWarn2
            // 
            this.lblWarn2.AutoSize = true;
            this.lblWarn2.ForeColor = System.Drawing.Color.Red;
            this.lblWarn2.Location = new System.Drawing.Point(194, 297);
            this.lblWarn2.Name = "lblWarn2";
            this.lblWarn2.Size = new System.Drawing.Size(0, 13);
            this.lblWarn2.TabIndex = 6;
            this.lblWarn2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAdminLogIn
            // 
            this.btnAdminLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogIn.Location = new System.Drawing.Point(100, 249);
            this.btnAdminLogIn.Name = "btnAdminLogIn";
            this.btnAdminLogIn.Size = new System.Drawing.Size(94, 38);
            this.btnAdminLogIn.TabIndex = 5;
            this.btnAdminLogIn.Text = "Login";
            this.btnAdminLogIn.UseVisualStyleBackColor = true;
            this.btnAdminLogIn.Click += new System.EventHandler(this.btnAdminLogIn_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(115, 54);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(247, 39);
            this.lblAdmin.TabIndex = 4;
            this.lblAdmin.Text = "Administration";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(190, 149);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(184, 26);
            this.txtPass.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(190, 116);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(184, 26);
            this.txtUserName.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(97, 152);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 20);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.Location = new System.Drawing.Point(97, 119);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(87, 20);
            this.lblAdminName.TabIndex = 0;
            this.lblAdminName.Text = "Username:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(516, 376);
            this.Controls.Add(this.tabLogin);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabLogin.ResumeLayout(false);
            this.tbpGameStart.ResumeLayout(false);
            this.tbpGameStart.PerformLayout();
            this.tbpAdmin.ResumeLayout(false);
            this.tbpAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabLogin;
        private System.Windows.Forms.TabPage tbpGameStart;
        private System.Windows.Forms.Label lblGameTitle;
        private System.Windows.Forms.TabPage tbpAdmin;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.Button btnAdminLogIn;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Label lblWarn2;
        private System.Windows.Forms.Label lblWarn;
        private System.Windows.Forms.Button btnReg;
    }
}

