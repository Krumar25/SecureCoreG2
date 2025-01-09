
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
            this.button1 = new System.Windows.Forms.Button();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCerrar)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWelcome)).BeginInit();
            this.SuspendLayout();
            // 
            // menuTransicio
            // 
            this.menuTransicio.Interval = 1;
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
            this.pnlSuperior.Size = new System.Drawing.Size(2586, 94);
            this.pnlSuperior.TabIndex = 1;
            this.pnlSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
            this.pnlSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
            this.pnlSuperior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Control_MouseUp);
            // 
            // picBoxMinimizar
            // 
            this.picBoxMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBoxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMinimizar.Image")));
            this.picBoxMinimizar.Location = new System.Drawing.Point(2235, 0);
            this.picBoxMinimizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBoxMinimizar.Name = "picBoxMinimizar";
            this.picBoxMinimizar.Padding = new System.Windows.Forms.Padding(40, 10, 40, 10);
            this.picBoxMinimizar.Size = new System.Drawing.Size(117, 94);
            this.picBoxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMinimizar.TabIndex = 4;
            this.picBoxMinimizar.TabStop = false;
            this.picBoxMinimizar.Click += new System.EventHandler(this.picBoxMinimizar_Click);
            // 
            // picBoxVentana
            // 
            this.picBoxVentana.Dock = System.Windows.Forms.DockStyle.Right;
            this.picBoxVentana.Image = ((System.Drawing.Image)(resources.GetObject("picBoxVentana.Image")));
            this.picBoxVentana.Location = new System.Drawing.Point(2352, 0);
            this.picBoxVentana.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBoxVentana.Name = "picBoxVentana";
            this.picBoxVentana.Padding = new System.Windows.Forms.Padding(35, 15, 35, 15);
            this.picBoxVentana.Size = new System.Drawing.Size(117, 94);
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
            this.picBoxCerrar.Location = new System.Drawing.Point(2469, 0);
            this.picBoxCerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBoxCerrar.Name = "picBoxCerrar";
            this.picBoxCerrar.Padding = new System.Windows.Forms.Padding(45, 25, 45, 25);
            this.picBoxCerrar.Size = new System.Drawing.Size(117, 94);
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
            this.btnDesplegable.FlatAppearance.BorderSize = 0;
            this.btnDesplegable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesplegable.Location = new System.Drawing.Point(0, 0);
            this.btnDesplegable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDesplegable.Name = "btnDesplegable";
            this.btnDesplegable.Size = new System.Drawing.Size(110, 94);
            this.btnDesplegable.TabIndex = 3;
            this.btnDesplegable.UseVisualStyleBackColor = true;
            this.btnDesplegable.Click += new System.EventHandler(this.btnDesplegable_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMenu.Controls.Add(this.pnlWelcome);
            this.pnlMenu.Controls.Add(this.button1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 94);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(500, 1532);
            this.pnlMenu.TabIndex = 3;
            this.pnlMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
            this.pnlMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
            this.pnlMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Control_MouseUp);
            // 
            // pnlWelcome
            // 
            this.pnlWelcome.Controls.Add(this.lblWelcome);
            this.pnlWelcome.Controls.Add(this.pbWelcome);
            this.pnlWelcome.Location = new System.Drawing.Point(3, 4);
            this.pnlWelcome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new System.Drawing.Size(497, 155);
            this.pnlWelcome.TabIndex = 1;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Yellow;
            this.lblWelcome.Location = new System.Drawing.Point(122, 64);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(121, 27);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome";
            // 
            // pbWelcome
            // 
            this.pbWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbWelcome.ImageLocation = "";
            this.pbWelcome.Location = new System.Drawing.Point(0, 21);
            this.pbWelcome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbWelcome.Name = "pbWelcome";
            this.pbWelcome.Size = new System.Drawing.Size(93, 100);
            this.pbWelcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWelcome.TabIndex = 0;
            this.pbWelcome.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(3, 165);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(397, 117);
            this.button1.TabIndex = 0;
            this.button1.Text = "pruebas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(2586, 1626);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secure Core";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCerrar)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlWelcome.ResumeLayout(false);
            this.pnlWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWelcome)).EndInit();
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
    }
}