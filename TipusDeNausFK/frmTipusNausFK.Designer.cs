
namespace TipusDeNausFK
{
    partial class frmTipusNausFK
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
            this.swCodiFiliation = new CustomControls.SWCodi();
            this.swCodiCategory = new CustomControls.SWCodi();
            this.idFiliation = new CustomControls.SWTextBox();
            this.idCategory = new CustomControls.SWTextBox();
            this.swCodeSpaceShip = new CustomControls.SWTextBox();
            this.swDescSpaceShip = new CustomControls.SWTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlManteniment1
            // 
            this.controlManteniment1.Location = new System.Drawing.Point(452, 132);
            this.controlManteniment1.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.swDescSpaceShip);
            this.panel1.Controls.Add(this.swCodeSpaceShip);
            this.panel1.Controls.Add(this.idCategory);
            this.panel1.Controls.Add(this.idFiliation);
            this.panel1.Controls.Add(this.swCodiCategory);
            this.panel1.Controls.Add(this.swCodiFiliation);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Size = new System.Drawing.Size(1592, 1298);
            this.panel1.Controls.SetChildIndex(this.controlManteniment1, 0);
            this.panel1.Controls.SetChildIndex(this.swCodiFiliation, 0);
            this.panel1.Controls.SetChildIndex(this.swCodiCategory, 0);
            this.panel1.Controls.SetChildIndex(this.idFiliation, 0);
            this.panel1.Controls.SetChildIndex(this.idCategory, 0);
            this.panel1.Controls.SetChildIndex(this.swCodeSpaceShip, 0);
            this.panel1.Controls.SetChildIndex(this.swDescSpaceShip, 0);
            this.panel1.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.label3, 0);
            this.panel1.Controls.SetChildIndex(this.label4, 0);
            // 
            // swCodiFiliation
            // 
            this.swCodiFiliation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swCodiFiliation.ClasseCS = null;
            this.swCodiFiliation.ControlID = "idFiliation";
            this.swCodiFiliation.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.swCodiFiliation.FormCS = null;
            this.swCodiFiliation.Location = new System.Drawing.Point(392, 510);
            this.swCodiFiliation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swCodiFiliation.Name = "swCodiFiliation";
            this.swCodiFiliation.NomCodi = "CodeFiliation";
            this.swCodiFiliation.NomDesc = "DescFiliations";
            this.swCodiFiliation.NomId = "idFiliation";
            this.swCodiFiliation.NomTaula = "Filiations";
            this.swCodiFiliation.Size = new System.Drawing.Size(598, 104);
            this.swCodiFiliation.TabIndex = 4;
            this.swCodiFiliation.TxtCode = null;
            this.swCodiFiliation.TxtDesc = null;
            // 
            // swCodiCategory
            // 
            this.swCodiCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swCodiCategory.ClasseCS = null;
            this.swCodiCategory.ControlID = "idCategory";
            this.swCodiCategory.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.swCodiCategory.FormCS = null;
            this.swCodiCategory.Location = new System.Drawing.Point(392, 620);
            this.swCodiCategory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.swCodiCategory.Name = "swCodiCategory";
            this.swCodiCategory.NomCodi = "CodeSpaceShipCategory";
            this.swCodiCategory.NomDesc = "DescSpaceShipCategory";
            this.swCodiCategory.NomId = "idSpaceShipCategory";
            this.swCodiCategory.NomTaula = "SpaceShipCategories";
            this.swCodiCategory.Size = new System.Drawing.Size(598, 112);
            this.swCodiCategory.TabIndex = 5;
            this.swCodiCategory.TxtCode = null;
            this.swCodiCategory.TxtDesc = null;
            // 
            // idFiliation
            // 
            this.idFiliation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.idFiliation.CampBBDD = "idFiliation";
            this.idFiliation.DadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.idFiliation.EsForana = true;
            this.idFiliation.EsNulable = false;
            this.idFiliation.Location = new System.Drawing.Point(1306, 452);
            this.idFiliation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idFiliation.Name = "idFiliation";
            this.idFiliation.Size = new System.Drawing.Size(52, 26);
            this.idFiliation.TabIndex = 6;
            this.idFiliation.TextChanged += new System.EventHandler(this.idFiliation_TextChanged);
            // 
            // idCategory
            // 
            this.idCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.idCategory.CampBBDD = "idSpaceShipCategory";
            this.idCategory.DadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.idCategory.EsForana = true;
            this.idCategory.EsNulable = false;
            this.idCategory.Location = new System.Drawing.Point(1306, 542);
            this.idCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idCategory.Name = "idCategory";
            this.idCategory.Size = new System.Drawing.Size(52, 26);
            this.idCategory.TabIndex = 7;
            this.idCategory.TextChanged += new System.EventHandler(this.idCategory_TextChanged);
            // 
            // swCodeSpaceShip
            // 
            this.swCodeSpaceShip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swCodeSpaceShip.CampBBDD = "CodeSpaceShipType";
            this.swCodeSpaceShip.DadaPermesa = CustomControls.SWTextBox.TipusDada.Codi;
            this.swCodeSpaceShip.EsForana = false;
            this.swCodeSpaceShip.EsNulable = false;
            this.swCodeSpaceShip.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.swCodeSpaceShip.Location = new System.Drawing.Point(571, 378);
            this.swCodeSpaceShip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.swCodeSpaceShip.Name = "swCodeSpaceShip";
            this.swCodeSpaceShip.Size = new System.Drawing.Size(166, 33);
            this.swCodeSpaceShip.TabIndex = 8;
            // 
            // swDescSpaceShip
            // 
            this.swDescSpaceShip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swDescSpaceShip.CampBBDD = "DescSpaceShipType";
            this.swDescSpaceShip.DadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swDescSpaceShip.EsForana = false;
            this.swDescSpaceShip.EsNulable = false;
            this.swDescSpaceShip.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.swDescSpaceShip.Location = new System.Drawing.Point(571, 468);
            this.swDescSpaceShip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.swDescSpaceShip.Name = "swDescSpaceShip";
            this.swDescSpaceShip.Size = new System.Drawing.Size(436, 33);
            this.swDescSpaceShip.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Location = new System.Drawing.Point(1268, 358);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 374);
            this.panel2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(355, 376);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Código";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(355, 466);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(354, 571);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Filiación";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(338, 691);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Categoría";
            // 
            // frmTipusNausFK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1837, 1298);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmTipusNausFK";
            this.Text = "frmTipusNausFK";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWCodi swCodiFiliation;
        private CustomControls.SWCodi swCodiCategory;
        private CustomControls.SWTextBox swDescSpaceShip;
        private CustomControls.SWTextBox swCodeSpaceShip;
        private CustomControls.SWTextBox idCategory;
        private CustomControls.SWTextBox idFiliation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}