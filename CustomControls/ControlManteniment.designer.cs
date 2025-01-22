
namespace CustomControls
{
    partial class ControlManteniment
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
            this.pn_manteniment = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.pn_manteniment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_manteniment
            // 
            this.pn_manteniment.BackColor = System.Drawing.Color.Transparent;
            this.pn_manteniment.Controls.Add(this.lbl_titulo);
            this.pn_manteniment.Controls.Add(this.pb_logo);
            this.pn_manteniment.Location = new System.Drawing.Point(0, 1);
            this.pn_manteniment.Name = "pn_manteniment";
            this.pn_manteniment.Size = new System.Drawing.Size(612, 63);
            this.pn_manteniment.TabIndex = 0;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_titulo.Location = new System.Drawing.Point(85, 15);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(167, 29);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "MANTENIMIENTO";
            // 
            // pb_logo
            // 
            this.pb_logo.Location = new System.Drawing.Point(12, 3);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(67, 57);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logo.TabIndex = 0;
            this.pb_logo.TabStop = false;
            // 
            // ControlManteniment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.pn_manteniment);
            this.Name = "ControlManteniment";
            this.Size = new System.Drawing.Size(626, 69);
            this.Load += new System.EventHandler(this.ControlManteniment_Load);
            this.pn_manteniment.ResumeLayout(false);
            this.pn_manteniment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_manteniment;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.PictureBox pb_logo;
    }
}
