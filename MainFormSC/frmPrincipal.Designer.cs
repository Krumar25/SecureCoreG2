
namespace MainFormSC
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.menuTransicio = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.btnDesplegable = new System.Windows.Forms.Button();
            this.pnlSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMenu.Location = new System.Drawing.Point(0, 74);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(329, 699);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlSuperior.Controls.Add(this.btnDesplegable);
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1192, 75);
            this.pnlSuperior.TabIndex = 1;
            // 
            // btnDesplegable
            // 
            this.btnDesplegable.Location = new System.Drawing.Point(3, 4);
            this.btnDesplegable.Name = "btnDesplegable";
            this.btnDesplegable.Size = new System.Drawing.Size(110, 68);
            this.btnDesplegable.TabIndex = 3;
            this.btnDesplegable.Text = "buttonMenu";
            this.btnDesplegable.UseVisualStyleBackColor = true;
            this.btnDesplegable.Click += new System.EventHandler(this.btnDesplegable_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 773);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.pnlMenu);
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.pnlSuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer menuTransicio;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Button btnDesplegable;
    }
}