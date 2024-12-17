
namespace Login
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pbMostrarPass = new System.Windows.Forms.PictureBox();
            this.pbOcultarPass = new System.Windows.Forms.PictureBox();
            this.lbErrorLogin = new System.Windows.Forms.Label();
            this.btnAccess = new CustomControls.SWButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.pbMinim = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultarPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinim)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMostrarPass
            // 
            this.pbMostrarPass.Image = ((System.Drawing.Image)(resources.GetObject("pbMostrarPass.Image")));
            this.pbMostrarPass.Location = new System.Drawing.Point(372, 511);
            this.pbMostrarPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbMostrarPass.Name = "pbMostrarPass";
            this.pbMostrarPass.Size = new System.Drawing.Size(37, 39);
            this.pbMostrarPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMostrarPass.TabIndex = 20;
            this.pbMostrarPass.TabStop = false;
            this.pbMostrarPass.Click += new System.EventHandler(this.pbMostrarPass_Click);
            // 
            // pbOcultarPass
            // 
            this.pbOcultarPass.Image = ((System.Drawing.Image)(resources.GetObject("pbOcultarPass.Image")));
            this.pbOcultarPass.Location = new System.Drawing.Point(372, 511);
            this.pbOcultarPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbOcultarPass.Name = "pbOcultarPass";
            this.pbOcultarPass.Size = new System.Drawing.Size(37, 39);
            this.pbOcultarPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOcultarPass.TabIndex = 19;
            this.pbOcultarPass.TabStop = false;
            this.pbOcultarPass.Visible = false;
            this.pbOcultarPass.Click += new System.EventHandler(this.pbOcultarPass_Click);
            // 
            // lbErrorLogin
            // 
            this.lbErrorLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbErrorLogin.ForeColor = System.Drawing.Color.DarkRed;
            this.lbErrorLogin.Location = new System.Drawing.Point(101, 579);
            this.lbErrorLogin.Name = "lbErrorLogin";
            this.lbErrorLogin.Size = new System.Drawing.Size(261, 39);
            this.lbErrorLogin.TabIndex = 18;
            this.lbErrorLogin.Text = "Usuario y/o contraseña incorrectos";
            this.lbErrorLogin.Visible = false;
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
            this.btnAccess.Location = new System.Drawing.Point(142, 621);
            this.btnAccess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAccess.Name = "btnAccess";
            this.btnAccess.Size = new System.Drawing.Size(169, 50);
            this.btnAccess.TabIndex = 17;
            this.btnAccess.Text = "Login";
            this.btnAccess.TextColor = System.Drawing.Color.White;
            this.btnAccess.UseVisualStyleBackColor = false;
            this.btnAccess.Click += new System.EventHandler(this.btnAccess_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(130, 59);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Contraseña";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(101, 409);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(64, 20);
            this.lbUser.TabIndex = 13;
            this.lbUser.Text = "Usuario";
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.Location = new System.Drawing.Point(105, 511);
            this.tbPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(261, 37);
            this.tbPass.TabIndex = 12;
            this.tbPass.UseSystemPasswordChar = true;
            this.tbPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPass_KeyDown);
            // 
            // tbUser
            // 
            this.tbUser.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.Location = new System.Drawing.Point(105, 434);
            this.tbUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(261, 37);
            this.tbUser.TabIndex = 11;
            // 
            // pbMinim
            // 
            this.pbMinim.Image = ((System.Drawing.Image)(resources.GetObject("pbMinim.Image")));
            this.pbMinim.Location = new System.Drawing.Point(380, 0);
            this.pbMinim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbMinim.Name = "pbMinim";
            this.pbMinim.Padding = new System.Windows.Forms.Padding(10);
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
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(479, 51);
            this.pnlHeader.TabIndex = 15;
            // 
            // pbClose
            // 
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(433, 0);
            this.pbClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbClose.Name = "pbClose";
            this.pbClose.Padding = new System.Windows.Forms.Padding(10);
            this.pbClose.Size = new System.Drawing.Size(41, 41);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 1;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(480, 808);
            this.Controls.Add(this.pbMostrarPass);
            this.Controls.Add(this.pbOcultarPass);
            this.Controls.Add(this.lbErrorLogin);
            this.Controls.Add(this.btnAccess);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLogin";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultarPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinim)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMostrarPass;
        private System.Windows.Forms.PictureBox pbOcultarPass;
        private System.Windows.Forms.Label lbErrorLogin;
        private CustomControls.SWButton btnAccess;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.PictureBox pbMinim;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pbClose;
    }
}