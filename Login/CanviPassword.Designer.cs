
namespace Login
{
    partial class CanviPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CanviPassword));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.tbConfNewPass = new System.Windows.Forms.TextBox();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbMinim = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnAccess = new CustomControls.SWButton();
            this.lbErrorLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinim)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(122, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Confirm password";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(102, 334);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(99, 17);
            this.lbUser.TabIndex = 23;
            this.lbUser.Text = "New password";
            // 
            // tbConfNewPass
            // 
            this.tbConfNewPass.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbConfNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbConfNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfNewPass.Location = new System.Drawing.Point(106, 416);
            this.tbConfNewPass.Name = "tbConfNewPass";
            this.tbConfNewPass.Size = new System.Drawing.Size(232, 31);
            this.tbConfNewPass.TabIndex = 22;
            this.tbConfNewPass.UseSystemPasswordChar = true;
            this.tbConfNewPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbConfNewPass_KeyDown);
            // 
            // tbNewPass
            // 
            this.tbNewPass.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewPass.Location = new System.Drawing.Point(106, 354);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.Size = new System.Drawing.Size(232, 31);
            this.tbNewPass.TabIndex = 21;
            this.tbNewPass.UseSystemPasswordChar = true;
            // 
            // pbClose
            // 
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(385, 0);
            this.pbClose.Name = "pbClose";
            this.pbClose.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.pbClose.Size = new System.Drawing.Size(41, 41);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 1;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // pbMinim
            // 
            this.pbMinim.Image = ((System.Drawing.Image)(resources.GetObject("pbMinim.Image")));
            this.pbMinim.Location = new System.Drawing.Point(338, 0);
            this.pbMinim.Name = "pbMinim";
            this.pbMinim.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.pbMinim.Size = new System.Drawing.Size(41, 41);
            this.pbMinim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinim.TabIndex = 0;
            this.pbMinim.TabStop = false;
            this.pbMinim.Click += new System.EventHandler(this.pbMinim_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.pnlHeader.Controls.Add(this.pbClose);
            this.pnlHeader.Controls.Add(this.pbMinim);
            this.pnlHeader.Location = new System.Drawing.Point(0, -2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(438, 41);
            this.pnlHeader.TabIndex = 30;
            // 
            // btnAccess
            // 
            this.btnAccess.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAccess.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAccess.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAccess.BorderRadius = 20;
            this.btnAccess.BorderSize = 0;
            this.btnAccess.FlatAppearance.BorderSize = 0;
            this.btnAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccess.ForeColor = System.Drawing.Color.White;
            this.btnAccess.Location = new System.Drawing.Point(146, 508);
            this.btnAccess.Name = "btnAccess";
            this.btnAccess.Size = new System.Drawing.Size(150, 40);
            this.btnAccess.TabIndex = 26;
            this.btnAccess.Text = "Reset Password";
            this.btnAccess.TextColor = System.Drawing.Color.White;
            this.btnAccess.UseVisualStyleBackColor = false;
            this.btnAccess.Click += new System.EventHandler(this.btnAccess_Click);
            // 
            // lbErrorLogin
            // 
            this.lbErrorLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbErrorLogin.ForeColor = System.Drawing.Color.DarkRed;
            this.lbErrorLogin.Location = new System.Drawing.Point(133, 464);
            this.lbErrorLogin.Name = "lbErrorLogin";
            this.lbErrorLogin.Size = new System.Drawing.Size(174, 31);
            this.lbErrorLogin.TabIndex = 31;
            this.lbErrorLogin.Text = "Contraseñas no coinciden";
            this.lbErrorLogin.Visible = false;
            // 
            // CanviPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(433, 610);
            this.Controls.Add(this.lbErrorLogin);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnAccess);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.tbConfNewPass);
            this.Controls.Add(this.tbNewPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CanviPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CanviPassword";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinim)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.SWButton btnAccess;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.TextBox tbConfNewPass;
        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbMinim;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lbErrorLogin;
    }
}