
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlManteniment1
            // 
            this.controlManteniment1.Location = new System.Drawing.Point(277, 51);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.swDescSpaceShip);
            this.panel1.Controls.Add(this.swCodeSpaceShip);
            this.panel1.Controls.Add(this.idCategory);
            this.panel1.Controls.Add(this.idFiliation);
            this.panel1.Controls.Add(this.swCodiCategory);
            this.panel1.Controls.Add(this.swCodiFiliation);
            this.panel1.Size = new System.Drawing.Size(1211, 762);
            this.panel1.Controls.SetChildIndex(this.controlManteniment1, 0);
            this.panel1.Controls.SetChildIndex(this.swCodiFiliation, 0);
            this.panel1.Controls.SetChildIndex(this.swCodiCategory, 0);
            this.panel1.Controls.SetChildIndex(this.idFiliation, 0);
            this.panel1.Controls.SetChildIndex(this.idCategory, 0);
            this.panel1.Controls.SetChildIndex(this.swCodeSpaceShip, 0);
            this.panel1.Controls.SetChildIndex(this.swDescSpaceShip, 0);
            this.panel1.Controls.SetChildIndex(this.panel2, 0);
            // 
            // swCodiFiliation
            // 
            this.swCodiFiliation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swCodiFiliation.ClasseCS = null;
            this.swCodiFiliation.ControlID = "idFiliation";
            this.swCodiFiliation.FormCS = null;
            this.swCodiFiliation.Location = new System.Drawing.Point(522, 156);
            this.swCodiFiliation.Name = "swCodiFiliation";
            this.swCodiFiliation.NomCodi = "CodeFiliation";
            this.swCodiFiliation.NomDesc = "DescFiliations";
            this.swCodiFiliation.NomId = "idFiliation";
            this.swCodiFiliation.NomTaula = "Filiations";
            this.swCodiFiliation.Size = new System.Drawing.Size(435, 75);
            this.swCodiFiliation.TabIndex = 4;
            this.swCodiFiliation.TxtCode = null;
            this.swCodiFiliation.TxtDesc = null;
            // 
            // swCodiCategory
            // 
            this.swCodiCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swCodiCategory.ClasseCS = null;
            this.swCodiCategory.ControlID = "idCategory";
            this.swCodiCategory.FormCS = null;
            this.swCodiCategory.Location = new System.Drawing.Point(522, 226);
            this.swCodiCategory.Name = "swCodiCategory";
            this.swCodiCategory.NomCodi = "CodeSpaceShipCategory";
            this.swCodiCategory.NomDesc = "DescSpaceShipCategory";
            this.swCodiCategory.NomId = "idSpaceShipCategory";
            this.swCodiCategory.NomTaula = "SpaceShipCategories";
            this.swCodiCategory.Size = new System.Drawing.Size(419, 77);
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
            this.idFiliation.Location = new System.Drawing.Point(1051, 209);
            this.idFiliation.Name = "idFiliation";
            this.idFiliation.Size = new System.Drawing.Size(47, 22);
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
            this.idCategory.Location = new System.Drawing.Point(1051, 281);
            this.idCategory.Name = "idCategory";
            this.idCategory.Size = new System.Drawing.Size(47, 22);
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
            this.swCodeSpaceShip.Location = new System.Drawing.Point(313, 209);
            this.swCodeSpaceShip.Name = "swCodeSpaceShip";
            this.swCodeSpaceShip.Size = new System.Drawing.Size(148, 22);
            this.swCodeSpaceShip.TabIndex = 8;
            // 
            // swDescSpaceShip
            // 
            this.swDescSpaceShip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swDescSpaceShip.CampBBDD = "DescSpaceShipType";
            this.swDescSpaceShip.DadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swDescSpaceShip.EsForana = false;
            this.swDescSpaceShip.EsNulable = false;
            this.swDescSpaceShip.Location = new System.Drawing.Point(313, 272);
            this.swDescSpaceShip.Name = "swDescSpaceShip";
            this.swDescSpaceShip.Size = new System.Drawing.Size(148, 22);
            this.swDescSpaceShip.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Location = new System.Drawing.Point(1023, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 261);
            this.panel2.TabIndex = 10;
            // 
            // frmTipusNausFK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 762);
            this.Name = "frmTipusNausFK";
            this.Text = "frmTipusNausFK";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.SWCodi swCodiFiliation;
        private CustomControls.SWCodi swCodiCategory;
        private CustomControls.SWTextBox swDescSpaceShip;
        private CustomControls.SWTextBox swCodeSpaceShip;
        private CustomControls.SWTextBox idCategory;
        private CustomControls.SWTextBox idFiliation;
        private System.Windows.Forms.Panel panel2;
    }
}