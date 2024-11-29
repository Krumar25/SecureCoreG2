
namespace CustomControls
{
    partial class SWLaunchForm
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
            this.pbOpcioMenu = new System.Windows.Forms.PictureBox();
            this.lblDescripcio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpcioMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pbOpcioMenu
            // 
            this.pbOpcioMenu.BackColor = System.Drawing.SystemColors.Control;
            this.pbOpcioMenu.Location = new System.Drawing.Point(3, 3);
            this.pbOpcioMenu.Name = "pbOpcioMenu";
            this.pbOpcioMenu.Size = new System.Drawing.Size(40, 40);
            this.pbOpcioMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOpcioMenu.TabIndex = 3;
            this.pbOpcioMenu.TabStop = false;
            this.pbOpcioMenu.Click += new System.EventHandler(this.SWLaunchForm_Click);
            // 
            // lblDescripcio
            // 
            this.lblDescripcio.AutoSize = true;
            this.lblDescripcio.ForeColor = System.Drawing.Color.White;
            this.lblDescripcio.Location = new System.Drawing.Point(49, 13);
            this.lblDescripcio.Name = "lblDescripcio";
            this.lblDescripcio.Size = new System.Drawing.Size(38, 17);
            this.lblDescripcio.TabIndex = 4;
            this.lblDescripcio.Text = "label";
            this.lblDescripcio.Click += new System.EventHandler(this.SWLaunchForm_Click);
            // 
            // SWLaunchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lblDescripcio);
            this.Controls.Add(this.pbOpcioMenu);
            this.Name = "SWLaunchForm";
            this.Size = new System.Drawing.Size(200, 60);
            this.Load += new System.EventHandler(this.SWLaunchForm_Load);
            this.Click += new System.EventHandler(this.SWLaunchForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbOpcioMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbOpcioMenu;
        private System.Windows.Forms.Label lblDescripcio;
    }
}
