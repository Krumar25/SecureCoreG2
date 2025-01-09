
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
            this.SuspendLayout();
            // 
            // txtCodiNivell
            // 
            this.txtCodiNivell.Location = new System.Drawing.Point(16, 21);
            this.txtCodiNivell.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCodiNivell.Name = "txtCodiNivell";
            this.txtCodiNivell.Size = new System.Drawing.Size(76, 20);
            this.txtCodiNivell.TabIndex = 0;
            // 
            // txtNivell
            // 
            this.txtNivell.Enabled = false;
            this.txtNivell.Location = new System.Drawing.Point(123, 21);
            this.txtNivell.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNivell.Name = "txtNivell";
            this.txtNivell.Size = new System.Drawing.Size(183, 20);
            this.txtNivell.TabIndex = 1;
            // 
            // SWCodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtNivell);
            this.Controls.Add(this.txtCodiNivell);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "SWCodi";
            this.Size = new System.Drawing.Size(369, 62);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.SWCodi_Validating);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodiNivell;
        private System.Windows.Forms.TextBox txtNivell;
    }
}
