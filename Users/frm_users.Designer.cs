
namespace Users
{
    partial class frm_users
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
            this.swSpecie = new CustomControls.SWCodi();
            this.swPlanet = new CustomControls.SWCodi();
            this.swUserCategory = new CustomControls.SWCodi();
            this.swCodeUser = new CustomControls.SWTextBox();
            this.swUserName = new CustomControls.SWTextBox();
            this.swLogin = new CustomControls.SWTextBox();
            this.swPassword = new CustomControls.SWTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.swbtnResetPass = new CustomControls.SWButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.swUserRanks = new CustomControls.SWCodi();
            this.swidUserRank = new CustomControls.SWTextBox();
            this.swidUserCategory = new CustomControls.SWTextBox();
            this.swidPlanet = new CustomControls.SWTextBox();
            this.swidSpecie = new CustomControls.SWTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // controlManteniment1
            // 
            this.controlManteniment1.Location = new System.Drawing.Point(515, 42);
            this.controlManteniment1.Margin = new System.Windows.Forms.Padding(3);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.swidSpecie);
            this.panel1.Controls.Add(this.swidPlanet);
            this.panel1.Controls.Add(this.swidUserCategory);
            this.panel1.Controls.Add(this.swidUserRank);
            this.panel1.Controls.Add(this.swUserRanks);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.swbtnResetPass);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.swPassword);
            this.panel1.Controls.Add(this.swLogin);
            this.panel1.Controls.Add(this.swUserName);
            this.panel1.Controls.Add(this.swCodeUser);
            this.panel1.Controls.Add(this.swUserCategory);
            this.panel1.Controls.Add(this.swPlanet);
            this.panel1.Controls.Add(this.swSpecie);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Controls.SetChildIndex(this.swSpecie, 0);
            this.panel1.Controls.SetChildIndex(this.swPlanet, 0);
            this.panel1.Controls.SetChildIndex(this.swUserCategory, 0);
            this.panel1.Controls.SetChildIndex(this.swCodeUser, 0);
            this.panel1.Controls.SetChildIndex(this.swUserName, 0);
            this.panel1.Controls.SetChildIndex(this.swLogin, 0);
            this.panel1.Controls.SetChildIndex(this.swPassword, 0);
            this.panel1.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel1.Controls.SetChildIndex(this.swbtnResetPass, 0);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            this.panel1.Controls.SetChildIndex(this.label3, 0);
            this.panel1.Controls.SetChildIndex(this.label4, 0);
            this.panel1.Controls.SetChildIndex(this.swUserRanks, 0);
            this.panel1.Controls.SetChildIndex(this.swidUserRank, 0);
            this.panel1.Controls.SetChildIndex(this.controlManteniment1, 0);
            this.panel1.Controls.SetChildIndex(this.swidUserCategory, 0);
            this.panel1.Controls.SetChildIndex(this.swidPlanet, 0);
            this.panel1.Controls.SetChildIndex(this.swidSpecie, 0);
            this.panel1.Controls.SetChildIndex(this.panel2, 0);
            // 
            // swSpecie
            // 
            this.swSpecie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swSpecie.ClasseCS = null;
            this.swSpecie.ControlID = "idSpecie";
            this.swSpecie.Cursor = System.Windows.Forms.Cursors.Default;
            this.swSpecie.FormCS = null;
            this.swSpecie.Location = new System.Drawing.Point(384, 206);
            this.swSpecie.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.swSpecie.Name = "swSpecie";
            this.swSpecie.NomCodi = "CodeSpecie";
            this.swSpecie.NomDesc = "DescSpecie";
            this.swSpecie.NomId = "idSpecie";
            this.swSpecie.NomTaula = "Species";
            this.swSpecie.Size = new System.Drawing.Size(369, 71);
            this.swSpecie.TabIndex = 4;
            this.swSpecie.TxtCode = null;
            this.swSpecie.TxtDesc = null;
            // 
            // swPlanet
            // 
            this.swPlanet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swPlanet.ClasseCS = null;
            this.swPlanet.ControlID = "idPlanet";
            this.swPlanet.FormCS = null;
            this.swPlanet.Location = new System.Drawing.Point(384, 170);
            this.swPlanet.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.swPlanet.Name = "swPlanet";
            this.swPlanet.NomCodi = "CodePlanet";
            this.swPlanet.NomDesc = "DescPlanet";
            this.swPlanet.NomId = "idPlanet";
            this.swPlanet.NomTaula = "Planets";
            this.swPlanet.Size = new System.Drawing.Size(369, 75);
            this.swPlanet.TabIndex = 5;
            this.swPlanet.TxtCode = null;
            this.swPlanet.TxtDesc = null;
            // 
            // swUserCategory
            // 
            this.swUserCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swUserCategory.ClasseCS = null;
            this.swUserCategory.ControlID = "idUserCategory";
            this.swUserCategory.FormCS = null;
            this.swUserCategory.Location = new System.Drawing.Point(384, 134);
            this.swUserCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.swUserCategory.Name = "swUserCategory";
            this.swUserCategory.NomCodi = "CodeCategory";
            this.swUserCategory.NomDesc = "DescCategory";
            this.swUserCategory.NomId = "idUserCategory";
            this.swUserCategory.NomTaula = "UserCategories";
            this.swUserCategory.Size = new System.Drawing.Size(369, 74);
            this.swUserCategory.TabIndex = 6;
            this.swUserCategory.TxtCode = null;
            this.swUserCategory.TxtDesc = null;
            // 
            // swCodeUser
            // 
            this.swCodeUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swCodeUser.CampBBDD = "CodeUser";
            this.swCodeUser.DadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swCodeUser.EsForana = false;
            this.swCodeUser.EsNulable = false;
            this.swCodeUser.Location = new System.Drawing.Point(138, 154);
            this.swCodeUser.Margin = new System.Windows.Forms.Padding(2);
            this.swCodeUser.Name = "swCodeUser";
            this.swCodeUser.Size = new System.Drawing.Size(191, 20);
            this.swCodeUser.TabIndex = 7;
            // 
            // swUserName
            // 
            this.swUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swUserName.CampBBDD = "UserName";
            this.swUserName.DadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swUserName.EsForana = false;
            this.swUserName.EsNulable = false;
            this.swUserName.Location = new System.Drawing.Point(138, 190);
            this.swUserName.Margin = new System.Windows.Forms.Padding(2);
            this.swUserName.Name = "swUserName";
            this.swUserName.Size = new System.Drawing.Size(191, 20);
            this.swUserName.TabIndex = 8;
            // 
            // swLogin
            // 
            this.swLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swLogin.CampBBDD = "Login";
            this.swLogin.DadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swLogin.EsForana = false;
            this.swLogin.EsNulable = false;
            this.swLogin.Location = new System.Drawing.Point(138, 229);
            this.swLogin.Margin = new System.Windows.Forms.Padding(2);
            this.swLogin.Name = "swLogin";
            this.swLogin.Size = new System.Drawing.Size(191, 20);
            this.swLogin.TabIndex = 9;
            // 
            // swPassword
            // 
            this.swPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swPassword.CampBBDD = "Password";
            this.swPassword.DadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swPassword.EsForana = false;
            this.swPassword.EsNulable = false;
            this.swPassword.Location = new System.Drawing.Point(138, 305);
            this.swPassword.Margin = new System.Windows.Forms.Padding(2);
            this.swPassword.Name = "swPassword";
            this.swPassword.ReadOnly = true;
            this.swPassword.Size = new System.Drawing.Size(482, 20);
            this.swPassword.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Location = new System.Drawing.Point(-34, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 104);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // swbtnResetPass
            // 
            this.swbtnResetPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swbtnResetPass.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.swbtnResetPass.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.swbtnResetPass.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.swbtnResetPass.BorderRadius = 0;
            this.swbtnResetPass.BorderSize = 0;
            this.swbtnResetPass.FlatAppearance.BorderSize = 0;
            this.swbtnResetPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.swbtnResetPass.ForeColor = System.Drawing.Color.White;
            this.swbtnResetPass.Location = new System.Drawing.Point(636, 301);
            this.swbtnResetPass.Margin = new System.Windows.Forms.Padding(2);
            this.swbtnResetPass.Name = "swbtnResetPass";
            this.swbtnResetPass.Size = new System.Drawing.Size(89, 26);
            this.swbtnResetPass.TabIndex = 12;
            this.swbtnResetPass.Text = "swButton1";
            this.swbtnResetPass.TextColor = System.Drawing.Color.White;
            this.swbtnResetPass.UseVisualStyleBackColor = false;
            this.swbtnResetPass.Click += new System.EventHandler(this.swbtnResetPass_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(26, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(26, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(26, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(26, 307);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "label4";
            // 
            // swUserRanks
            // 
            this.swUserRanks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swUserRanks.ClasseCS = null;
            this.swUserRanks.ControlID = "idUserRank";
            this.swUserRanks.FormCS = null;
            this.swUserRanks.Location = new System.Drawing.Point(384, 99);
            this.swUserRanks.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.swUserRanks.Name = "swUserRanks";
            this.swUserRanks.NomCodi = "CodeRank";
            this.swUserRanks.NomDesc = "DescRank";
            this.swUserRanks.NomId = "idUserRank";
            this.swUserRanks.NomTaula = "UserRanks";
            this.swUserRanks.Size = new System.Drawing.Size(369, 72);
            this.swUserRanks.TabIndex = 17;
            this.swUserRanks.TxtCode = null;
            this.swUserRanks.TxtDesc = null;
            // 
            // swidUserRank
            // 
            this.swidUserRank.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swidUserRank.CampBBDD = "idUserRank";
            this.swidUserRank.DadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swidUserRank.EsForana = false;
            this.swidUserRank.EsNulable = false;
            this.swidUserRank.Location = new System.Drawing.Point(750, 140);
            this.swidUserRank.Margin = new System.Windows.Forms.Padding(2);
            this.swidUserRank.Name = "swidUserRank";
            this.swidUserRank.Size = new System.Drawing.Size(29, 20);
            this.swidUserRank.TabIndex = 18;
            this.swidUserRank.TextChanged += new System.EventHandler(this.swidUserRank_TextChanged);
            // 
            // swidUserCategory
            // 
            this.swidUserCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swidUserCategory.CampBBDD = "idUserCategory";
            this.swidUserCategory.DadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swidUserCategory.EsForana = false;
            this.swidUserCategory.EsNulable = false;
            this.swidUserCategory.Location = new System.Drawing.Point(750, 167);
            this.swidUserCategory.Margin = new System.Windows.Forms.Padding(2);
            this.swidUserCategory.Name = "swidUserCategory";
            this.swidUserCategory.Size = new System.Drawing.Size(29, 20);
            this.swidUserCategory.TabIndex = 19;
            this.swidUserCategory.TextChanged += new System.EventHandler(this.swidUserCategory_TextChanged);
            // 
            // swidPlanet
            // 
            this.swidPlanet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swidPlanet.CampBBDD = "idPlanet";
            this.swidPlanet.DadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swidPlanet.EsForana = false;
            this.swidPlanet.EsNulable = false;
            this.swidPlanet.Location = new System.Drawing.Point(750, 196);
            this.swidPlanet.Margin = new System.Windows.Forms.Padding(2);
            this.swidPlanet.Name = "swidPlanet";
            this.swidPlanet.Size = new System.Drawing.Size(29, 20);
            this.swidPlanet.TabIndex = 20;
            this.swidPlanet.TextChanged += new System.EventHandler(this.swidPlanet_TextChanged);
            // 
            // swidSpecie
            // 
            this.swidSpecie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swidSpecie.CampBBDD = "idSpecie";
            this.swidSpecie.DadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swidSpecie.EsForana = false;
            this.swidSpecie.EsNulable = false;
            this.swidSpecie.Location = new System.Drawing.Point(750, 224);
            this.swidSpecie.Margin = new System.Windows.Forms.Padding(2);
            this.swidSpecie.Name = "swidSpecie";
            this.swidSpecie.Size = new System.Drawing.Size(29, 20);
            this.swidSpecie.TabIndex = 21;
            this.swidSpecie.TextChanged += new System.EventHandler(this.swidSpecie_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Location = new System.Drawing.Point(757, 88);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(105, 239);
            this.panel2.TabIndex = 22;
            // 
            // frm_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 487);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_users";
            this.Text = "frm_users";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.SWTextBox swLogin;
        private CustomControls.SWTextBox swUserName;
        private CustomControls.SWTextBox swCodeUser;
        private CustomControls.SWCodi swUserCategory;
        private CustomControls.SWCodi swPlanet;
        private CustomControls.SWCodi swSpecie;
        private CustomControls.SWTextBox swPassword;
        private CustomControls.SWButton swbtnResetPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.SWCodi swUserRanks;
        private CustomControls.SWTextBox swidSpecie;
        private CustomControls.SWTextBox swidPlanet;
        private CustomControls.SWTextBox swidUserCategory;
        private CustomControls.SWTextBox swidUserRank;
        private System.Windows.Forms.Panel panel2;
    }
}