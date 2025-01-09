
namespace CustomControls
{
    partial class SWCodi
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCodiNivell = new System.Windows.Forms.TextBox();
            this.txtNivell = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCodiNivell
            // 
            this.txtCodiNivell.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCodiNivell.Location = new System.Drawing.Point(71, 48);
            this.txtCodiNivell.Name = "txtCodiNivell";
            this.txtCodiNivell.Size = new System.Drawing.Size(100, 22);
            this.txtCodiNivell.TabIndex = 0;
            // 
            // txtNivell
            // 
            this.txtNivell.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNivell.Enabled = false;
            this.txtNivell.Location = new System.Drawing.Point(297, 48);
            this.txtNivell.Name = "txtNivell";
            this.txtNivell.Size = new System.Drawing.Size(243, 22);
            this.txtNivell.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(209, 51);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 17);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(13, 53);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 17);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código";
            // 
            // SWCodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtNivell);
            this.Controls.Add(this.txtCodiNivell);
            this.Name = "SWCodi";
            this.Size = new System.Drawing.Size(557, 121);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.SWCodi_Validating);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodiNivell;
        private System.Windows.Forms.TextBox txtNivell;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCodigo;
    }
}
