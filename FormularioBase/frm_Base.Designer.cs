
namespace FormularioBase
{
    partial class frm_Base
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Base));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pn_opciones = new System.Windows.Forms.Panel();
            this.cmb_actualizar = new System.Windows.Forms.Button();
            this.cmb_nuevo = new System.Windows.Forms.Button();
            this.dtg_datos = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.controlManteniment1 = new CustomControls.ControlManteniment();
            this.pn_opciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_opciones
            // 
            this.pn_opciones.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pn_opciones.Controls.Add(this.cmb_actualizar);
            this.pn_opciones.Controls.Add(this.cmb_nuevo);
            this.pn_opciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_opciones.Location = new System.Drawing.Point(1285, 0);
            this.pn_opciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pn_opciones.Name = "pn_opciones";
            this.pn_opciones.Size = new System.Drawing.Size(200, 887);
            this.pn_opciones.TabIndex = 1;
            // 
            // cmb_actualizar
            // 
            this.cmb_actualizar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmb_actualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.cmb_actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_actualizar.ForeColor = System.Drawing.Color.Yellow;
            this.cmb_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("cmb_actualizar.Image")));
            this.cmb_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmb_actualizar.Location = new System.Drawing.Point(0, 411);
            this.cmb_actualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_actualizar.Name = "cmb_actualizar";
            this.cmb_actualizar.Size = new System.Drawing.Size(207, 62);
            this.cmb_actualizar.TabIndex = 0;
            this.cmb_actualizar.Text = " Actualizar";
            this.cmb_actualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmb_actualizar.UseVisualStyleBackColor = false;
            this.cmb_actualizar.Click += new System.EventHandler(this.cmb_actualizar_Click);
            // 
            // cmb_nuevo
            // 
            this.cmb_nuevo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmb_nuevo.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.cmb_nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_nuevo.ForeColor = System.Drawing.Color.Yellow;
            this.cmb_nuevo.Image = ((System.Drawing.Image)(resources.GetObject("cmb_nuevo.Image")));
            this.cmb_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmb_nuevo.Location = new System.Drawing.Point(0, 480);
            this.cmb_nuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_nuevo.Name = "cmb_nuevo";
            this.cmb_nuevo.Size = new System.Drawing.Size(207, 62);
            this.cmb_nuevo.TabIndex = 0;
            this.cmb_nuevo.Text = " Nuevo";
            this.cmb_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmb_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmb_nuevo.UseVisualStyleBackColor = false;
            this.cmb_nuevo.Click += new System.EventHandler(this.cmb_nuevo_Click);
            // 
            // dtg_datos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Yellow;
            this.dtg_datos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_datos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtg_datos.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dtg_datos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_datos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_datos.Location = new System.Drawing.Point(313, 480);
            this.dtg_datos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtg_datos.Name = "dtg_datos";
            this.dtg_datos.RowHeadersWidth = 62;
            this.dtg_datos.Size = new System.Drawing.Size(817, 317);
            this.dtg_datos.TabIndex = 3;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "actualizar (2).png");
            this.imageList1.Images.SetKeyName(1, "añadir.png");
            this.imageList1.Images.SetKeyName(2, "salir.png");
            // 
            // controlManteniment1
            // 
            this.controlManteniment1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.controlManteniment1.BackColor = System.Drawing.SystemColors.Desktop;
            this.controlManteniment1.Descripcio = null;
            this.controlManteniment1.ForeColor = System.Drawing.Color.Yellow;
            this.controlManteniment1.Img = ((System.Drawing.Image)(resources.GetObject("controlManteniment1.Img")));
            this.controlManteniment1.Location = new System.Drawing.Point(445, 35);
            this.controlManteniment1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.controlManteniment1.Name = "controlManteniment1";
            this.controlManteniment1.NomClase = null;
            this.controlManteniment1.NomForm = null;
            this.controlManteniment1.Size = new System.Drawing.Size(588, 98);
            this.controlManteniment1.TabIndex = 2;
            // 
            // frm_Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1485, 887);
            this.Controls.Add(this.dtg_datos);
            this.Controls.Add(this.controlManteniment1);
            this.Controls.Add(this.pn_opciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Base";
            this.Text = "Mantenimiento";
            this.Load += new System.EventHandler(this.frm_Base_Load);
            this.pn_opciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_datos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_opciones;
        private System.Windows.Forms.Button cmb_nuevo;
        private System.Windows.Forms.Button cmb_actualizar;
        private System.Windows.Forms.DataGridView dtg_datos;
        private System.Windows.Forms.ImageList imageList1;
        protected CustomControls.ControlManteniment controlManteniment1;
    }
}