namespace Planets
{
    partial class frm_planets
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
            this.swCodi_sector = new CustomControls.SWCodi();
            this.swCodi_nativos = new CustomControls.SWCodi();
            this.lbl_planet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.swTx_long = new CustomControls.SWTextBox();
            this.swTx_ip = new CustomControls.SWTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.swTx_lat = new CustomControls.SWTextBox();
            this.swCodi_filiation = new CustomControls.SWCodi();
            this.label6 = new System.Windows.Forms.Label();
            this.swTx_p1 = new CustomControls.SWTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.swCodi_planet = new CustomControls.SWCodi();
            this.pb_planets = new System.Windows.Forms.PictureBox();
            this.swTx_planet = new CustomControls.SWTextBox();
            this.swTx_sector = new CustomControls.SWTextBox();
            this.swTx_nativos = new CustomControls.SWTextBox();
            this.swTx_filiation = new CustomControls.SWTextBox();
            this.swTx_p2 = new CustomControls.SWTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_planets)).BeginInit();
            this.SuspendLayout();
            // 
            // controlManteniment1
            // 
            this.controlManteniment1.Location = new System.Drawing.Point(576, 11);
            this.controlManteniment1.Size = new System.Drawing.Size(392, 78);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.swTx_p2);
            this.panel1.Controls.Add(this.swTx_filiation);
            this.panel1.Controls.Add(this.swTx_nativos);
            this.panel1.Controls.Add(this.swTx_sector);
            this.panel1.Controls.Add(this.swTx_planet);
            this.panel1.Controls.Add(this.pb_planets);
            this.panel1.Controls.Add(this.swCodi_planet);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.swTx_p1);
            this.panel1.Controls.Add(this.swCodi_filiation);
            this.panel1.Controls.Add(this.swTx_ip);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.swTx_lat);
            this.panel1.Controls.Add(this.swTx_long);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_planet);
            this.panel1.Controls.Add(this.swCodi_nativos);
            this.panel1.Controls.Add(this.swCodi_sector);
            this.panel1.Size = new System.Drawing.Size(1026, 615);
            this.panel1.Controls.SetChildIndex(this.swCodi_sector, 0);
            this.panel1.Controls.SetChildIndex(this.controlManteniment1, 0);
            this.panel1.Controls.SetChildIndex(this.swCodi_nativos, 0);
            this.panel1.Controls.SetChildIndex(this.lbl_planet, 0);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            this.panel1.Controls.SetChildIndex(this.label3, 0);
            this.panel1.Controls.SetChildIndex(this.swTx_long, 0);
            this.panel1.Controls.SetChildIndex(this.swTx_lat, 0);
            this.panel1.Controls.SetChildIndex(this.label5, 0);
            this.panel1.Controls.SetChildIndex(this.label4, 0);
            this.panel1.Controls.SetChildIndex(this.swTx_ip, 0);
            this.panel1.Controls.SetChildIndex(this.swCodi_filiation, 0);
            this.panel1.Controls.SetChildIndex(this.swTx_p1, 0);
            this.panel1.Controls.SetChildIndex(this.label6, 0);
            this.panel1.Controls.SetChildIndex(this.label7, 0);
            this.panel1.Controls.SetChildIndex(this.label8, 0);
            this.panel1.Controls.SetChildIndex(this.label9, 0);
            this.panel1.Controls.SetChildIndex(this.label10, 0);
            this.panel1.Controls.SetChildIndex(this.swCodi_planet, 0);
            this.panel1.Controls.SetChildIndex(this.pb_planets, 0);
            this.panel1.Controls.SetChildIndex(this.swTx_planet, 0);
            this.panel1.Controls.SetChildIndex(this.swTx_sector, 0);
            this.panel1.Controls.SetChildIndex(this.swTx_nativos, 0);
            this.panel1.Controls.SetChildIndex(this.swTx_filiation, 0);
            this.panel1.Controls.SetChildIndex(this.swTx_p2, 0);
            // 
            // swCodi_sector
            // 
            this.swCodi_sector.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swCodi_sector.ClasseCS = null;
            this.swCodi_sector.ControlID = "idSector";
            this.swCodi_sector.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swCodi_sector.FormCS = null;
            this.swCodi_sector.Location = new System.Drawing.Point(111, 140);
            this.swCodi_sector.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.swCodi_sector.Name = "swCodi_sector";
            this.swCodi_sector.NomCodi = "CodeSector";
            this.swCodi_sector.NomDesc = "DescSector";
            this.swCodi_sector.NomId = "idSector";
            this.swCodi_sector.NomTaula = "Sectors";
            this.swCodi_sector.Size = new System.Drawing.Size(378, 56);
            this.swCodi_sector.TabIndex = 9;
            this.swCodi_sector.TxtCode = null;
            this.swCodi_sector.TxtDesc = null;
            // 
            // swCodi_nativos
            // 
            this.swCodi_nativos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swCodi_nativos.ClasseCS = null;
            this.swCodi_nativos.ControlID = null;
            this.swCodi_nativos.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swCodi_nativos.FormCS = null;
            this.swCodi_nativos.Location = new System.Drawing.Point(111, 192);
            this.swCodi_nativos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.swCodi_nativos.Name = "swCodi_nativos";
            this.swCodi_nativos.NomCodi = "CodeSpecie";
            this.swCodi_nativos.NomDesc = "DescSpecie";
            this.swCodi_nativos.NomId = "idSpecie";
            this.swCodi_nativos.NomTaula = "Species";
            this.swCodi_nativos.Size = new System.Drawing.Size(378, 56);
            this.swCodi_nativos.TabIndex = 10;
            this.swCodi_nativos.TxtCode = null;
            this.swCodi_nativos.TxtDesc = null;
            // 
            // lbl_planet
            // 
            this.lbl_planet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_planet.AutoSize = true;
            this.lbl_planet.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_planet.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_planet.Location = new System.Drawing.Point(40, 120);
            this.lbl_planet.Name = "lbl_planet";
            this.lbl_planet.Size = new System.Drawing.Size(76, 17);
            this.lbl_planet.TabIndex = 11;
            this.lbl_planet.Text = "PLANETA";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(129, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(253, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(60, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Longitud";
            // 
            // swTx_long
            // 
            this.swTx_long.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swTx_long.CampBBDD = "long";
            this.swTx_long.DadaPermesa = CustomControls.SWTextBox.TipusDada.Numero;
            this.swTx_long.EsForana = false;
            this.swTx_long.EsNulable = false;
            this.swTx_long.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTx_long.Location = new System.Drawing.Point(133, 310);
            this.swTx_long.Name = "swTx_long";
            this.swTx_long.Size = new System.Drawing.Size(117, 22);
            this.swTx_long.TabIndex = 17;
            // 
            // swTx_ip
            // 
            this.swTx_ip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swTx_ip.CampBBDD = "IPPlanet";
            this.swTx_ip.DadaPermesa = CustomControls.SWTextBox.TipusDada.Numero;
            this.swTx_ip.EsForana = false;
            this.swTx_ip.EsNulable = false;
            this.swTx_ip.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTx_ip.Location = new System.Drawing.Point(132, 354);
            this.swTx_ip.Name = "swTx_ip";
            this.swTx_ip.Size = new System.Drawing.Size(118, 22);
            this.swTx_ip.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(108, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "IP";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(261, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Latitud";
            // 
            // swTx_lat
            // 
            this.swTx_lat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swTx_lat.CampBBDD = "lat";
            this.swTx_lat.DadaPermesa = CustomControls.SWTextBox.TipusDada.Numero;
            this.swTx_lat.EsForana = false;
            this.swTx_lat.EsNulable = false;
            this.swTx_lat.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTx_lat.Location = new System.Drawing.Point(325, 309);
            this.swTx_lat.Name = "swTx_lat";
            this.swTx_lat.Size = new System.Drawing.Size(117, 22);
            this.swTx_lat.TabIndex = 18;
            // 
            // swCodi_filiation
            // 
            this.swCodi_filiation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swCodi_filiation.ClasseCS = null;
            this.swCodi_filiation.ControlID = null;
            this.swCodi_filiation.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swCodi_filiation.FormCS = null;
            this.swCodi_filiation.Location = new System.Drawing.Point(111, 242);
            this.swCodi_filiation.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.swCodi_filiation.Name = "swCodi_filiation";
            this.swCodi_filiation.NomCodi = "CodeFiliation";
            this.swCodi_filiation.NomDesc = "DescFiliations";
            this.swCodi_filiation.NomId = "idFiliation";
            this.swCodi_filiation.NomTaula = "Filiations";
            this.swCodi_filiation.Size = new System.Drawing.Size(378, 58);
            this.swCodi_filiation.TabIndex = 22;
            this.swCodi_filiation.TxtCode = null;
            this.swCodi_filiation.TxtDesc = null;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(252, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Puerto 1";
            // 
            // swTx_p1
            // 
            this.swTx_p1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swTx_p1.CampBBDD = "PortPlanet";
            this.swTx_p1.DadaPermesa = CustomControls.SWTextBox.TipusDada.Numero;
            this.swTx_p1.EsForana = false;
            this.swTx_p1.EsNulable = false;
            this.swTx_p1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTx_p1.Location = new System.Drawing.Point(330, 354);
            this.swTx_p1.Name = "swTx_p1";
            this.swTx_p1.Size = new System.Drawing.Size(44, 22);
            this.swTx_p1.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(380, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Puerto 2";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(48, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "SECTOR";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(48, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "NATIVOS";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(43, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "FILIACIÓN";
            // 
            // swCodi_planet
            // 
            this.swCodi_planet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swCodi_planet.ClasseCS = null;
            this.swCodi_planet.ControlID = "idPlanets";
            this.swCodi_planet.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swCodi_planet.FormCS = null;
            this.swCodi_planet.Location = new System.Drawing.Point(110, 97);
            this.swCodi_planet.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.swCodi_planet.Name = "swCodi_planet";
            this.swCodi_planet.NomCodi = "CodePlanet";
            this.swCodi_planet.NomDesc = "DescPlanet";
            this.swCodi_planet.NomId = "idPlanet";
            this.swCodi_planet.NomTaula = "planets";
            this.swCodi_planet.Size = new System.Drawing.Size(378, 56);
            this.swCodi_planet.TabIndex = 30;
            this.swCodi_planet.TxtCode = null;
            this.swCodi_planet.TxtDesc = null;
            // 
            // pb_planets
            // 
            this.pb_planets.Location = new System.Drawing.Point(603, 120);
            this.pb_planets.Name = "pb_planets";
            this.pb_planets.Size = new System.Drawing.Size(251, 212);
            this.pb_planets.TabIndex = 31;
            this.pb_planets.TabStop = false;
            this.pb_planets.Tag = "PlanetPicture";
            // 
            // swTx_planet
            // 
            this.swTx_planet.CampBBDD = "idPlanet";
            this.swTx_planet.DadaPermesa = CustomControls.SWTextBox.TipusDada.Numero;
            this.swTx_planet.EsForana = false;
            this.swTx_planet.EsNulable = false;
            this.swTx_planet.Location = new System.Drawing.Point(493, 120);
            this.swTx_planet.Name = "swTx_planet";
            this.swTx_planet.Size = new System.Drawing.Size(66, 20);
            this.swTx_planet.TabIndex = 32;
            this.swTx_planet.TextChanged += new System.EventHandler(this.swTx_planet_TextChanged);
            // 
            // swTx_sector
            // 
            this.swTx_sector.CampBBDD = "idSector";
            this.swTx_sector.DadaPermesa = CustomControls.SWTextBox.TipusDada.Numero;
            this.swTx_sector.EsForana = false;
            this.swTx_sector.EsNulable = false;
            this.swTx_sector.Location = new System.Drawing.Point(493, 165);
            this.swTx_sector.Name = "swTx_sector";
            this.swTx_sector.Size = new System.Drawing.Size(66, 20);
            this.swTx_sector.TabIndex = 33;
            this.swTx_sector.TextChanged += new System.EventHandler(this.swTx_sector_TextChanged);
            // 
            // swTx_nativos
            // 
            this.swTx_nativos.CampBBDD = "idNatives";
            this.swTx_nativos.DadaPermesa = CustomControls.SWTextBox.TipusDada.Numero;
            this.swTx_nativos.EsForana = false;
            this.swTx_nativos.EsNulable = false;
            this.swTx_nativos.Location = new System.Drawing.Point(493, 214);
            this.swTx_nativos.Name = "swTx_nativos";
            this.swTx_nativos.Size = new System.Drawing.Size(66, 20);
            this.swTx_nativos.TabIndex = 34;
            this.swTx_nativos.TextChanged += new System.EventHandler(this.swTx_nativos_TextChanged);
            // 
            // swTx_filiation
            // 
            this.swTx_filiation.CampBBDD = "idFiliation";
            this.swTx_filiation.DadaPermesa = CustomControls.SWTextBox.TipusDada.Numero;
            this.swTx_filiation.EsForana = false;
            this.swTx_filiation.EsNulable = false;
            this.swTx_filiation.Location = new System.Drawing.Point(494, 260);
            this.swTx_filiation.Name = "swTx_filiation";
            this.swTx_filiation.Size = new System.Drawing.Size(66, 20);
            this.swTx_filiation.TabIndex = 35;
            this.swTx_filiation.TextChanged += new System.EventHandler(this.swTx_filiation_TextChanged);
            // 
            // swTx_p2
            // 
            this.swTx_p2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swTx_p2.CampBBDD = "PortPlanet1";
            this.swTx_p2.DadaPermesa = CustomControls.SWTextBox.TipusDada.Numero;
            this.swTx_p2.EsForana = false;
            this.swTx_p2.EsNulable = false;
            this.swTx_p2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swTx_p2.Location = new System.Drawing.Point(458, 354);
            this.swTx_p2.Name = "swTx_p2";
            this.swTx_p2.Size = new System.Drawing.Size(44, 22);
            this.swTx_p2.TabIndex = 36;
            // 
            // frm_planets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 615);
            this.Name = "frm_planets";
            this.Text = "frm_planets";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_planets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.SWCodi swCodi_sector;
        private System.Windows.Forms.Label lbl_planet;
        private CustomControls.SWCodi swCodi_nativos;
        private System.Windows.Forms.Label label1;
        private CustomControls.SWTextBox swTx_long;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CustomControls.SWCodi swCodi_filiation;
        private CustomControls.SWTextBox swTx_ip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private CustomControls.SWTextBox swTx_lat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private CustomControls.SWTextBox swTx_p1;
        private CustomControls.SWCodi swCodi_planet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pb_planets;
        private CustomControls.SWTextBox swTx_filiation;
        private CustomControls.SWTextBox swTx_nativos;
        private CustomControls.SWTextBox swTx_sector;
        private CustomControls.SWTextBox swTx_planet;
        private CustomControls.SWTextBox swTx_p2;
    }
}