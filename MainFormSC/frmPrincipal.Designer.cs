
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
            this.btnDesplegable = new CustomControls.SWButton();
            this.imgBotons = new System.Windows.Forms.ImageList(this.components);
            this.pnlForm = new System.Windows.Forms.Panel();
            this.swLaunchForm1 = new CustomControls.SWLaunchForm();
            this.menuTransicio = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnDesplegable);
            this.pnlMenu.Controls.Add(this.swLaunchForm1);
            this.pnlMenu.Location = new System.Drawing.Point(9, 10);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(150, 346);
            this.pnlMenu.TabIndex = 0;
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
            this.btnDesplegable.Location = new System.Drawing.Point(2, 2);
            this.btnDesplegable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDesplegable.Name = "btnDesplegable";
            this.btnDesplegable.Size = new System.Drawing.Size(39, 36);
            this.btnDesplegable.TabIndex = 0;
            this.btnDesplegable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesplegable.TextColor = System.Drawing.Color.White;
            this.btnDesplegable.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnDesplegable.UseVisualStyleBackColor = false;
            // 
            // imgBotons
            // 
            this.imgBotons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgBotons.ImageStream")));
            this.imgBotons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgBotons.Images.SetKeyName(0, "menuDesplegable.png");
            // 
            // pnlForm
            // 
            this.pnlForm.Location = new System.Drawing.Point(164, 10);
            this.pnlForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(428, 346);
            this.pnlForm.TabIndex = 1;
            // 
            // swLaunchForm1
            // 
            this.swLaunchForm1.BackColor = System.Drawing.Color.Black;
            this.swLaunchForm1.Descripcio = "frmVermell";
            this.swLaunchForm1.Imatge = ((System.Drawing.Image)(resources.GetObject("swLaunchForm1.Imatge")));
            this.swLaunchForm1.Location = new System.Drawing.Point(2, 43);
            this.swLaunchForm1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.swLaunchForm1.Name = "swLaunchForm1";
            this.swLaunchForm1.NomClase = "FormsCustomControls";
            this.swLaunchForm1.NomFormulari = "frmVermell";
            this.swLaunchForm1.PanellManteniment = this.pnlForm;
            this.swLaunchForm1.Size = new System.Drawing.Size(150, 49);
            this.swLaunchForm1.TabIndex = 1;
            // 
            // menuTransicio
            // 
            this.menuTransicio.Tick += new System.EventHandler(this.menuTransicio_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlForm;
        private CustomControls.SWLaunchForm swLaunchForm1;
        private CustomControls.SWButton btnDesplegable;
        private System.Windows.Forms.ImageList imgBotons;
        private System.Windows.Forms.Timer menuTransicio;
    }
}