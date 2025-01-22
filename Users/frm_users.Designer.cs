
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
            this.swbtnGenerarTarjeta = new CustomControls.SWButton();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // controlManteniment1
            // 
            this.controlManteniment1.Location = new System.Drawing.Point(747, 183);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.swbtnGenerarTarjeta);
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
            this.panel1.Size = new System.Drawing.Size(1462, 1420);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.panel1.Controls.SetChildIndex(this.swidUserCategory, 0);
            this.panel1.Controls.SetChildIndex(this.swidPlanet, 0);
            this.panel1.Controls.SetChildIndex(this.swidSpecie, 0);
            this.panel1.Controls.SetChildIndex(this.swbtnGenerarTarjeta, 0);
            this.panel1.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.Controls.SetChildIndex(this.controlManteniment1, 0);
            this.panel1.Controls.SetChildIndex(this.label5, 0);
            this.panel1.Controls.SetChildIndex(this.label6, 0);
            this.panel1.Controls.SetChildIndex(this.label7, 0);
            this.panel1.Controls.SetChildIndex(this.label8, 0);
            // 
            // swSpecie
            // 
            this.swSpecie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swSpecie.ClasseCS = null;
            this.swSpecie.ControlID = "idSpecie";
            this.swSpecie.Cursor = System.Windows.Forms.Cursors.Default;
            this.swSpecie.FormCS = null;
            this.swSpecie.Location = new System.Drawing.Point(697, 515);
            this.swSpecie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.swSpecie.Name = "swSpecie";
            this.swSpecie.NomCodi = "CodeSpecie";
            this.swSpecie.NomDesc = "DescSpecie";
            this.swSpecie.NomId = "idSpecie";
            this.swSpecie.NomTaula = "Species";
            this.swSpecie.Size = new System.Drawing.Size(554, 110);
            this.swSpecie.TabIndex = 4;
            this.swSpecie.TxtCode = null;
            this.swSpecie.TxtDesc = null;
            this.swSpecie.Validating += new System.ComponentModel.CancelEventHandler(this.swSpecie_Validating);
            // 
            // swPlanet
            // 
            this.swPlanet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swPlanet.ClasseCS = null;
            this.swPlanet.ControlID = "idPlanet";
            this.swPlanet.FormCS = null;
            this.swPlanet.Location = new System.Drawing.Point(697, 459);
            this.swPlanet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.swPlanet.Name = "swPlanet";
            this.swPlanet.NomCodi = "CodePlanet";
            this.swPlanet.NomDesc = "DescPlanet";
            this.swPlanet.NomId = "idPlanet";
            this.swPlanet.NomTaula = "Planets";
            this.swPlanet.Size = new System.Drawing.Size(554, 115);
            this.swPlanet.TabIndex = 5;
            this.swPlanet.TxtCode = null;
            this.swPlanet.TxtDesc = null;
            this.swPlanet.Validating += new System.ComponentModel.CancelEventHandler(this.swPlanet_Validating);
            // 
            // swUserCategory
            // 
            this.swUserCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swUserCategory.ClasseCS = null;
            this.swUserCategory.ControlID = "idUserCategory";
            this.swUserCategory.FormCS = null;
            this.swUserCategory.Location = new System.Drawing.Point(697, 404);
            this.swUserCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.swUserCategory.Name = "swUserCategory";
            this.swUserCategory.NomCodi = "CodeCategory";
            this.swUserCategory.NomDesc = "DescCategory";
            this.swUserCategory.NomId = "idUserCategory";
            this.swUserCategory.NomTaula = "UserCategories";
            this.swUserCategory.Size = new System.Drawing.Size(554, 114);
            this.swUserCategory.TabIndex = 6;
            this.swUserCategory.TxtCode = null;
            this.swUserCategory.TxtDesc = null;
            this.swUserCategory.Validating += new System.ComponentModel.CancelEventHandler(this.swUserCategory_Validating);
            // 
            // swCodeUser
            // 
            this.swCodeUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swCodeUser.CampBBDD = "CodeUser";
            this.swCodeUser.DadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swCodeUser.EsForana = false;
            this.swCodeUser.EsNulable = false;
            this.swCodeUser.Location = new System.Drawing.Point(272, 435);
            this.swCodeUser.Name = "swCodeUser";
            this.swCodeUser.Size = new System.Drawing.Size(284, 26);
            this.swCodeUser.TabIndex = 7;
            // 
            // swUserName
            // 
            this.swUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swUserName.CampBBDD = "UserName";
            this.swUserName.DadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swUserName.EsForana = false;
            this.swUserName.EsNulable = false;
            this.swUserName.Location = new System.Drawing.Point(272, 491);
            this.swUserName.Name = "swUserName";
            this.swUserName.Size = new System.Drawing.Size(284, 26);
            this.swUserName.TabIndex = 8;
            // 
            // swLogin
            // 
            this.swLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swLogin.CampBBDD = "Login";
            this.swLogin.DadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swLogin.EsForana = false;
            this.swLogin.EsNulable = false;
            this.swLogin.Location = new System.Drawing.Point(272, 550);
            this.swLogin.Name = "swLogin";
            this.swLogin.Size = new System.Drawing.Size(284, 26);
            this.swLogin.TabIndex = 9;
            // 
            // swPassword
            // 
            this.swPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swPassword.CampBBDD = "Password";
            this.swPassword.DadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swPassword.EsForana = false;
            this.swPassword.EsNulable = false;
            this.swPassword.Location = new System.Drawing.Point(317, 675);
            this.swPassword.Name = "swPassword";
            this.swPassword.ReadOnly = true;
            this.swPassword.Size = new System.Drawing.Size(721, 26);
            this.swPassword.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Location = new System.Drawing.Point(156, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Photo";
            // 
            // swbtnResetPass
            // 
            this.swbtnResetPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swbtnResetPass.BackColor = System.Drawing.Color.Transparent;
            this.swbtnResetPass.BackgroundColor = System.Drawing.Color.Transparent;
            this.swbtnResetPass.BorderColor = System.Drawing.Color.Yellow;
            this.swbtnResetPass.BorderRadius = 10;
            this.swbtnResetPass.BorderSize = 2;
            this.swbtnResetPass.FlatAppearance.BorderSize = 0;
            this.swbtnResetPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.swbtnResetPass.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Bold);
            this.swbtnResetPass.ForeColor = System.Drawing.Color.Yellow;
            this.swbtnResetPass.Imatge = null;
            this.swbtnResetPass.Location = new System.Drawing.Point(1060, 657);
            this.swbtnResetPass.Name = "swbtnResetPass";
            this.swbtnResetPass.Size = new System.Drawing.Size(163, 62);
            this.swbtnResetPass.TabIndex = 12;
            this.swbtnResetPass.Text = "Reset";
            this.swbtnResetPass.TextColor = System.Drawing.Color.Yellow;
            this.swbtnResetPass.UseVisualStyleBackColor = false;
            this.swbtnResetPass.Click += new System.EventHandler(this.swbtnResetPass_Click);
            this.swbtnResetPass.MouseEnter += new System.EventHandler(this.swbtnResetPass_MouseEnter);
            this.swbtnResetPass.MouseLeave += new System.EventHandler(this.swbtnResetPass_MouseLeave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(133, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(121, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(151, 549);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 27);
            this.label3.TabIndex = 15;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(148, 678);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 27);
            this.label4.TabIndex = 16;
            this.label4.Text = "Password";
            // 
            // swUserRanks
            // 
            this.swUserRanks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swUserRanks.ClasseCS = null;
            this.swUserRanks.ControlID = "idUserRank";
            this.swUserRanks.FormCS = null;
            this.swUserRanks.Location = new System.Drawing.Point(697, 350);
            this.swUserRanks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.swUserRanks.Name = "swUserRanks";
            this.swUserRanks.NomCodi = "CodeRank";
            this.swUserRanks.NomDesc = "DescRank";
            this.swUserRanks.NomId = "idUserRank";
            this.swUserRanks.NomTaula = "UserRanks";
            this.swUserRanks.Size = new System.Drawing.Size(554, 111);
            this.swUserRanks.TabIndex = 17;
            this.swUserRanks.TxtCode = null;
            this.swUserRanks.TxtDesc = null;
            this.swUserRanks.Validating += new System.ComponentModel.CancelEventHandler(this.swUserRanks_Validating);
            // 
            // swidUserRank
            // 
            this.swidUserRank.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swidUserRank.CampBBDD = "idUserRank";
            this.swidUserRank.DadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swidUserRank.EsForana = true;
            this.swidUserRank.EsNulable = false;
            this.swidUserRank.Location = new System.Drawing.Point(1275, 379);
            this.swidUserRank.Name = "swidUserRank";
            this.swidUserRank.Size = new System.Drawing.Size(41, 26);
            this.swidUserRank.TabIndex = 18;
            this.swidUserRank.TextChanged += new System.EventHandler(this.swidUserRank_TextChanged);
            // 
            // swidUserCategory
            // 
            this.swidUserCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swidUserCategory.CampBBDD = "idUserCategory";
            this.swidUserCategory.DadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swidUserCategory.EsForana = true;
            this.swidUserCategory.EsNulable = false;
            this.swidUserCategory.Location = new System.Drawing.Point(1275, 435);
            this.swidUserCategory.Name = "swidUserCategory";
            this.swidUserCategory.Size = new System.Drawing.Size(41, 26);
            this.swidUserCategory.TabIndex = 19;
            this.swidUserCategory.TextChanged += new System.EventHandler(this.swidUserCategory_TextChanged);
            // 
            // swidPlanet
            // 
            this.swidPlanet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swidPlanet.CampBBDD = "idPlanet";
            this.swidPlanet.DadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swidPlanet.EsForana = true;
            this.swidPlanet.EsNulable = false;
            this.swidPlanet.Location = new System.Drawing.Point(1275, 489);
            this.swidPlanet.Name = "swidPlanet";
            this.swidPlanet.Size = new System.Drawing.Size(41, 26);
            this.swidPlanet.TabIndex = 20;
            this.swidPlanet.TextChanged += new System.EventHandler(this.swidPlanet_TextChanged);
            // 
            // swidSpecie
            // 
            this.swidSpecie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swidSpecie.CampBBDD = "idSpecie";
            this.swidSpecie.DadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swidSpecie.EsForana = true;
            this.swidSpecie.EsNulable = false;
            this.swidSpecie.Location = new System.Drawing.Point(1275, 543);
            this.swidSpecie.Name = "swidSpecie";
            this.swidSpecie.Size = new System.Drawing.Size(41, 26);
            this.swidSpecie.TabIndex = 21;
            this.swidSpecie.TextChanged += new System.EventHandler(this.swidSpecie_TextChanged);
            // 
            // swbtnGenerarTarjeta
            // 
            this.swbtnGenerarTarjeta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swbtnGenerarTarjeta.BackColor = System.Drawing.Color.Transparent;
            this.swbtnGenerarTarjeta.BackgroundColor = System.Drawing.Color.Transparent;
            this.swbtnGenerarTarjeta.BorderColor = System.Drawing.Color.Yellow;
            this.swbtnGenerarTarjeta.BorderRadius = 10;
            this.swbtnGenerarTarjeta.BorderSize = 2;
            this.swbtnGenerarTarjeta.FlatAppearance.BorderSize = 0;
            this.swbtnGenerarTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.swbtnGenerarTarjeta.Font = new System.Drawing.Font("Lucida Sans", 11F, System.Drawing.FontStyle.Bold);
            this.swbtnGenerarTarjeta.ForeColor = System.Drawing.Color.Yellow;
            this.swbtnGenerarTarjeta.Imatge = null;
            this.swbtnGenerarTarjeta.Location = new System.Drawing.Point(1025, 1331);
            this.swbtnGenerarTarjeta.Name = "swbtnGenerarTarjeta";
            this.swbtnGenerarTarjeta.Size = new System.Drawing.Size(226, 62);
            this.swbtnGenerarTarjeta.TabIndex = 23;
            this.swbtnGenerarTarjeta.Text = "Generar Tarjeta";
            this.swbtnGenerarTarjeta.TextColor = System.Drawing.Color.Yellow;
            this.swbtnGenerarTarjeta.UseVisualStyleBackColor = false;
            this.swbtnGenerarTarjeta.Click += new System.EventHandler(this.swbtnGenerarTarjeta_Click);
            this.swbtnGenerarTarjeta.MouseEnter += new System.EventHandler(this.swbtnGenerarTarjeta_MouseEnter);
            this.swbtnGenerarTarjeta.MouseLeave += new System.EventHandler(this.swbtnGenerarTarjeta_MouseLeave);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1462, 1420);
            this.crystalReportViewer1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Location = new System.Drawing.Point(1257, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 368);
            this.panel2.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(677, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 27);
            this.label5.TabIndex = 26;
            this.label5.Text = "Rango";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(640, 467);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 27);
            this.label6.TabIndex = 27;
            this.label6.Text = "Categoria";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(666, 521);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 27);
            this.label7.TabIndex = 28;
            this.label7.Text = "Planeta";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(695, 575);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 27);
            this.label8.TabIndex = 29;
            this.label8.Text = "Raza";
            // 
            // frm_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1784, 1420);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frm_users";
            this.Text = "frm_users";
            this.Controls.SetChildIndex(this.crystalReportViewer1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private CustomControls.SWButton swbtnGenerarTarjeta;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}