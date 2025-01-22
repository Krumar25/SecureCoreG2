
namespace CustomControls
{
    partial class LogOutButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogOutButton));
            this.lblDescripcio = new System.Windows.Forms.Label();
            this.pbOpcioMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpcioMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescripcio
            // 
            this.lblDescripcio.AutoSize = true;
            this.lblDescripcio.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescripcio.ForeColor = System.Drawing.Color.Yellow;
            this.lblDescripcio.Location = new System.Drawing.Point(155, 42);
            this.lblDescripcio.Name = "lblDescripcio";
            this.lblDescripcio.Size = new System.Drawing.Size(76, 21);
            this.lblDescripcio.TabIndex = 6;
            this.lblDescripcio.Text = "Logout";
            this.lblDescripcio.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // pbOpcioMenu
            // 
            this.pbOpcioMenu.BackColor = System.Drawing.Color.Transparent;
            this.pbOpcioMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbOpcioMenu.Image")));
            this.pbOpcioMenu.Location = new System.Drawing.Point(27, 26);
            this.pbOpcioMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbOpcioMenu.Name = "pbOpcioMenu";
            this.pbOpcioMenu.Size = new System.Drawing.Size(45, 50);
            this.pbOpcioMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOpcioMenu.TabIndex = 5;
            this.pbOpcioMenu.TabStop = false;
            this.pbOpcioMenu.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // LogOutButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.Controls.Add(this.lblDescripcio);
            this.Controls.Add(this.pbOpcioMenu);
            this.Name = "LogOutButton";
            this.Size = new System.Drawing.Size(349, 109);
            this.Click += new System.EventHandler(this.LogOutButton_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbOpcioMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcio;
        private System.Windows.Forms.PictureBox pbOpcioMenu;
    }
}
