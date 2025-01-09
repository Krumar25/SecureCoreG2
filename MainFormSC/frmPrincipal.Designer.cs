
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
            this.menuTransicio = new System.Windows.Forms.Timer(this.components);
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.picBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.picBoxVentana = new System.Windows.Forms.PictureBox();
            this.picBoxCerrar = new System.Windows.Forms.PictureBox();
            this.btnDesplegable = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlWelcome = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pbWelcome = new System.Windows.Forms.PictureBox();
            this.pnlDesplegableWelcome = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.DesplegableWelcome = new System.Windows.Forms.Timer(this.components);
            this.swButton1 = new CustomControls.SWButton();
            this.swButton2 = new CustomControls.SWButton();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCerrar)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWelcome)).BeginInit();
            this.pnlDesplegableWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTransicio
            // 
            this.menuTransicio.Interval = 10;
            this.menuTransicio.Tick += new System.EventHandler(this.menuTransicio_Tick);
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlSuperior.Controls.Add(this.picBoxMinimizar);
            this.pnlSuperior.Controls.Add(this.picBoxVentana);
            this.pnlSuperior.Controls.Add(this.picBoxCerrar);
            this.pnlSuperior.Controls.Add(this.btnDesplegable);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1627, 60);
            this.pnlSuperior.TabIndex = 1;
            // 
            // picBoxMinimizar
            // 
            this.picBoxMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBoxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMinimizar.Image")));
            this.picBoxMinimizar.Location = new System.Drawing.Point(1315, 0);
            this.picBoxMinimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxMinimizar.Name = "picBoxMinimizar";
            this.picBoxMinimizar.Padding = new System.Windows.Forms.Padding(36, 8, 36, 8);
            this.picBoxMinimizar.Size = new System.Drawing.Size(104, 60);
            this.picBoxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMinimizar.TabIndex = 4;
            this.picBoxMinimizar.TabStop = false;
            this.picBoxMinimizar.Click += new System.EventHandler(this.picBoxMinimizar_Click);
            // 
            // picBoxVentana
            // 
            this.picBoxVentana.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBoxVentana.Image = ((System.Drawing.Image)(resources.GetObject("picBoxVentana.Image")));
            this.picBoxVentana.Location = new System.Drawing.Point(1419, 0);
            this.picBoxVentana.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxVentana.Name = "picBoxVentana";
            this.picBoxVentana.Padding = new System.Windows.Forms.Padding(31, 12, 31, 12);
            this.picBoxVentana.Size = new System.Drawing.Size(104, 60);
            this.picBoxVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxVentana.TabIndex = 5;
            this.picBoxVentana.TabStop = false;
            this.picBoxVentana.Click += new System.EventHandler(this.picBoxVentana_Click);
            // 
            // picBoxCerrar
            // 
            this.picBoxCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBoxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("picBoxCerrar.Image")));
            this.picBoxCerrar.Location = new System.Drawing.Point(1523, 0);
            this.picBoxCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxCerrar.Name = "picBoxCerrar";
            this.picBoxCerrar.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.picBoxCerrar.Size = new System.Drawing.Size(104, 60);
            this.picBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCerrar.TabIndex = 6;
            this.picBoxCerrar.TabStop = false;
            this.picBoxCerrar.Click += new System.EventHandler(this.picBoxCerrar_Click);
            // 
            // btnDesplegable
            // 
            this.btnDesplegable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDesplegable.BackgroundImage")));
            this.btnDesplegable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDesplegable.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDesplegable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesplegable.Location = new System.Drawing.Point(0, 0);
            this.btnDesplegable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDesplegable.Name = "btnDesplegable";
            this.btnDesplegable.Size = new System.Drawing.Size(98, 60);
            this.btnDesplegable.TabIndex = 3;
            this.btnDesplegable.UseVisualStyleBackColor = true;
            this.btnDesplegable.Click += new System.EventHandler(this.btnDesplegable_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMenu.Controls.Add(this.pnlWelcome);
            this.pnlMenu.Controls.Add(this.pnlDesplegableWelcome);
            this.pnlMenu.Controls.Add(this.button1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 60);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(292, 822);
            this.pnlMenu.TabIndex = 3;
            // 
            // pnlWelcome
            // 
            this.pnlWelcome.Controls.Add(this.lblWelcome);
            this.pnlWelcome.Controls.Add(this.pbWelcome);
            this.pnlWelcome.Location = new System.Drawing.Point(3, 3);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new System.Drawing.Size(289, 77);
            this.pnlWelcome.TabIndex = 1;
            this.pnlWelcome.Click += new System.EventHandler(this.pnlWelcome_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.ForeColor = System.Drawing.Color.Yellow;
            this.lblWelcome.Location = new System.Drawing.Point(112, 30);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(66, 17);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome";
            this.lblWelcome.Click += new System.EventHandler(this.pnlWelcome_Click);
            // 
            // pbWelcome
            // 
            this.pbWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbWelcome.Location = new System.Drawing.Point(3, -3);
            this.pbWelcome.Name = "pbWelcome";
            this.pbWelcome.Size = new System.Drawing.Size(83, 80);
            this.pbWelcome.TabIndex = 0;
            this.pbWelcome.TabStop = false;
            this.pbWelcome.Click += new System.EventHandler(this.pnlWelcome_Click);
            // 
            // pnlDesplegableWelcome
            // 
            this.pnlDesplegableWelcome.Controls.Add(this.swButton2);
            this.pnlDesplegableWelcome.Controls.Add(this.swButton1);
            this.pnlDesplegableWelcome.Location = new System.Drawing.Point(3, 86);
            this.pnlDesplegableWelcome.Name = "pnlDesplegableWelcome";
            this.pnlDesplegableWelcome.Size = new System.Drawing.Size(289, 238);
            this.pnlDesplegableWelcome.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 329);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DesplegableWelcome
            // 
            this.DesplegableWelcome.Interval = 10;
            this.DesplegableWelcome.Tick += new System.EventHandler(this.DesplegableWelcome_Tick);
            // 
            // swButton1
            // 
            this.swButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.swButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.swButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.swButton1.BorderRadius = 0;
            this.swButton1.BorderSize = 0;
            this.swButton1.FlatAppearance.BorderSize = 0;
            this.swButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.swButton1.ForeColor = System.Drawing.Color.White;
            this.swButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.swButton1.ImageKey = "close.png";
            this.swButton1.Location = new System.Drawing.Point(9, 145);
            this.swButton1.Name = "swButton1";
            this.swButton1.Size = new System.Drawing.Size(169, 60);
            this.swButton1.TabIndex = 5;
            this.swButton1.Text = "swButton1";
            this.swButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.swButton1.TextColor = System.Drawing.Color.White;
            this.swButton1.UseVisualStyleBackColor = false;
            // 
            // swButton2
            // 
            this.swButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.swButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.swButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.swButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.swButton2.BorderRadius = 0;
            this.swButton2.BorderSize = 0;
            this.swButton2.FlatAppearance.BorderSize = 0;
            this.swButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.swButton2.ForeColor = System.Drawing.Color.White;
            this.swButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.swButton2.ImageKey = "(ninguno)";
            this.swButton2.Location = new System.Drawing.Point(28, 68);
            this.swButton2.Name = "swButton2";
            this.swButton2.Size = new System.Drawing.Size(150, 45);
            this.swButton2.TabIndex = 5;
            this.swButton2.Text = "swButton2";
            this.swButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.swButton2.TextColor = System.Drawing.Color.White;
            this.swButton2.UseVisualStyleBackColor = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1627, 882);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secure Core";
            this.pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCerrar)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlWelcome.ResumeLayout(false);
            this.pnlWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWelcome)).EndInit();
            this.pnlDesplegableWelcome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer menuTransicio;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Button btnDesplegable;
        private System.Windows.Forms.PictureBox picBoxCerrar;
        private System.Windows.Forms.PictureBox picBoxVentana;
        private System.Windows.Forms.PictureBox picBoxMinimizar;
        private System.Windows.Forms.FlowLayoutPanel pnlMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlWelcome;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pbWelcome;
        private System.Windows.Forms.Timer DesplegableWelcome;
        private System.Windows.Forms.Panel pnlDesplegableWelcome;
        private CustomControls.SWButton swButton1;
        private CustomControls.SWButton swButton2;
    }
}