
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
            this.swCodi_FKFiliation = new CustomControls.SWCodi();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlManteniment1
            // 
            this.controlManteniment1.Location = new System.Drawing.Point(209, 51);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.swCodi_FKFiliation);
            this.panel1.Size = new System.Drawing.Size(843, 668);
            this.panel1.Controls.SetChildIndex(this.controlManteniment1, 0);
            this.panel1.Controls.SetChildIndex(this.swCodi_FKFiliation, 0);
            // 
            // swCodi_FKFiliation
            // 
            this.swCodi_FKFiliation.ClasseCS = "TipusDeNausFK";
            this.swCodi_FKFiliation.ControlID = "txtID";
            this.swCodi_FKFiliation.FormCS = "frmTipusNausFK";
            this.swCodi_FKFiliation.Location = new System.Drawing.Point(106, 138);
            this.swCodi_FKFiliation.Name = "swCodi_FKFiliation";
            this.swCodi_FKFiliation.NomCodi = "CodeFiliation";
            this.swCodi_FKFiliation.NomDesc = "DescFiliations";
            this.swCodi_FKFiliation.NomId = "idFiliation";
            this.swCodi_FKFiliation.NomTaula = "SpaceShipTypes";
            this.swCodi_FKFiliation.Size = new System.Drawing.Size(483, 121);
            this.swCodi_FKFiliation.TabIndex = 4;
            // 
            // frmTipusNausFK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 668);
            this.Name = "frmTipusNausFK";
            this.Text = "frmTipusNausFK";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.SWCodi swCodi_FKFiliation;
    }
}