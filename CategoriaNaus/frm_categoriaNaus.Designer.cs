
namespace CategoriaNaus
{
    partial class frm_categoriaNaus
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
            this.swCodigo = new CustomControls.SWTextBox();
            this.swDescripcion = new CustomControls.SWTextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlManteniment1
            // 
            this.controlManteniment1.Location = new System.Drawing.Point(471, 228);
            this.controlManteniment1.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.controlManteniment1.NomClase = "CategoriaNaus";
            this.controlManteniment1.NomForm = "frm_categoriaNaus";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Controls.Add(this.swDescripcion);
            this.panel1.Controls.Add(this.swCodigo);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Size = new System.Drawing.Size(1516, 1298);
            this.panel1.Controls.SetChildIndex(this.controlManteniment1, 0);
            this.panel1.Controls.SetChildIndex(this.swCodigo, 0);
            this.panel1.Controls.SetChildIndex(this.swDescripcion, 0);
            this.panel1.Controls.SetChildIndex(this.lblCodigo, 0);
            this.panel1.Controls.SetChildIndex(this.lblDescripcion, 0);
            // 
            // swCodigo
            // 
            this.swCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swCodigo.CampBBDD = "CodeSpaceShipCategory";
            this.swCodigo.DadaPermesa = CustomControls.SWTextBox.TipusDada.Codi;
            this.swCodigo.EsForana = false;
            this.swCodigo.EsNulable = false;
            this.swCodigo.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.swCodigo.Location = new System.Drawing.Point(601, 477);
            this.swCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.swCodigo.Name = "swCodigo";
            this.swCodigo.Size = new System.Drawing.Size(112, 33);
            this.swCodigo.TabIndex = 4;
            // 
            // swDescripcion
            // 
            this.swDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swDescripcion.CampBBDD = "DescSpaceShipCategory";
            this.swDescripcion.DadaPermesa = CustomControls.SWTextBox.TipusDada.Text;
            this.swDescripcion.EsForana = false;
            this.swDescripcion.EsNulable = false;
            this.swDescripcion.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.swDescripcion.Location = new System.Drawing.Point(601, 578);
            this.swDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.swDescripcion.Name = "swDescripcion";
            this.swDescripcion.Size = new System.Drawing.Size(366, 33);
            this.swDescripcion.TabIndex = 5;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Yellow;
            this.lblCodigo.Location = new System.Drawing.Point(455, 478);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(98, 27);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "Código";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Yellow;
            this.lblDescripcion.Location = new System.Drawing.Point(398, 578);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDescripcion.Size = new System.Drawing.Size(155, 27);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Descripción";
            // 
            // frm_categoriaNaus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1838, 1298);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frm_categoriaNaus";
            this.Text = "frm_categoriaNaus";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextBox swDescripcion;
        private CustomControls.SWTextBox swCodigo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCodigo;
    }
}