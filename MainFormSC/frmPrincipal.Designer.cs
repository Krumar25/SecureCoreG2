
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.swLaunchForm1 = new CustomControls.SWLaunchForm();
            this.btnDesplegable = new CustomControls.SWButton();
            this.imgBotons = new System.Windows.Forms.ImageList(this.components);
            this.pnlForm = new System.Windows.Forms.Panel();
            this.menuTransicio = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMenu.Controls.Add(this.swLaunchForm1);
            this.pnlMenu.Location = new System.Drawing.Point(12, 12);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 426);
            this.pnlMenu.TabIndex = 0;
            // 
            // swLaunchForm1
            // 
            this.swLaunchForm1.BackColor = System.Drawing.Color.Black;
            this.swLaunchForm1.Descripcio = null;
            this.swLaunchForm1.Imatge = ((System.Drawing.Image)(resources.GetObject("swLaunchForm1.Imatge")));
            this.swLaunchForm1.Location = new System.Drawing.Point(3, 3);
            this.swLaunchForm1.Name = "swLaunchForm1";
            this.swLaunchForm1.NomClase = null;
            this.swLaunchForm1.NomFormulari = null;
            this.swLaunchForm1.PanellManteniment = null;
            this.swLaunchForm1.Size = new System.Drawing.Size(200, 60);
            this.swLaunchForm1.TabIndex = 1;
            // 
            // btnDesplegable
            // 
            this.btnDesplegable.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDesplegable.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDesplegable.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDesplegable.BorderRadius = 0;
            this.btnDesplegable.BorderSize = 0;
            this.btnDesplegable.FlatAppearance.BorderSize = 0;
            this.btnDesplegable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesplegable.ForeColor = System.Drawing.Color.White;
            this.btnDesplegable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesplegable.ImageKey = "menuDesplegable.png";
            this.btnDesplegable.ImageList = this.imgBotons;
            this.btnDesplegable.Location = new System.Drawing.Point(148, 77);
            this.btnDesplegable.Name = "btnDesplegable";
            this.btnDesplegable.Size = new System.Drawing.Size(52, 44);
            this.btnDesplegable.TabIndex = 0;
            this.btnDesplegable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesplegable.TextColor = System.Drawing.Color.White;
            this.btnDesplegable.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnDesplegable.UseVisualStyleBackColor = false;
            this.btnDesplegable.Click += new System.EventHandler(this.btnDesplegable_Click);
            // 
            // imgBotons
            // 
            this.imgBotons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgBotons.ImageStream")));
            this.imgBotons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgBotons.Images.SetKeyName(0, "menuDesplegable.png");
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.btnDesplegable);
            this.pnlForm.Location = new System.Drawing.Point(218, 12);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(570, 426);
            this.pnlForm.TabIndex = 1;
            // 
            // menuTransicio
            // 
            this.menuTransicio.Interval = 30;
            this.menuTransicio.Tick += new System.EventHandler(this.menuTransicio_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlMenu);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.pnlMenu.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlForm;
        private CustomControls.SWButton btnDesplegable;
        private System.Windows.Forms.ImageList imgBotons;
        private System.Windows.Forms.Timer menuTransicio;
        private CustomControls.SWLaunchForm swLaunchForm1;
    }
}