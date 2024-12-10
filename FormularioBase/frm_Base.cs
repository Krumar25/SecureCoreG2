using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dades;
using System.Data.SqlClient;

namespace FormularioBase
{
    public partial class frm_Base : Form
    {
        private AccesADades BBDD = new AccesADades();
        private DataSet dts;
        private string query;
        private string nomTaula;
        private bool esNou;

        public frm_Base()
        {
            InitializeComponent();
        }

        public void ConfigurarConsulta(string taula, string nombreTabla)
        {
            this.query = "Select * from " + taula;
            this.nomTaula = nombreTabla;

            if (controlManteniment1 != null)
            {
                controlManteniment1.Descripcio = nombreTabla; // Actualiza el lbl_titulo en el UserControl
            }

        }
        public void CargarDatos()
        {
            if (DesignMode) return;

            dts = BBDD.PortarPerConsulta(query, nomTaula);

            dtg_datos.DataSource = dts.Tables[0];

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    TextBox ctr = (TextBox)item;
                    ctr.DataBindings.Add("Text", dts.Tables[0], ctr.Tag.ToString());

                    
                }
            }
            this.dtg_datos.Columns[0].Visible = false;
        }
        public void ConfigurarBinding()
        {
            dtg_datos.DataSource = dts.Tables[0];

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox ctr = (TextBox)item;
                    ctr.DataBindings.Clear();
                    ctr.DataBindings.Add("Text", dts.Tables[0], ctr.Tag.ToString());
                    ctr.Validated += new System.EventHandler(this.ValidarTextBox);
                }
                if (item is ComboBox)
                {
                    ComboBox ctr = (ComboBox)item;
                    ctr.DataBindings.Clear();
                    ctr.DataBindings.Add("Text", dts.Tables[0], ctr.Tag.ToString());
                    ctr.Validated += new System.EventHandler(this.ValidarTextBox);
                }
            }
        }
        private void ValidarTextBox(object sender, EventArgs e)
        {
            ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }

        private void frm_Base_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            CargarDatos();
            ConfigurarDataGridView();
        }
        private void ConfigurarDataGridView()
        {
            // Cambiar fuente
            dtg_datos.DefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Regular);

            // Cambiar tipo de fuente y tamaño para los encabezados
            dtg_datos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);

            // Cambiar el tamaño de las Celdas
            dtg_datos.RowTemplate.Height = 30;
            dtg_datos.Columns[1].Width = 150;
            dtg_datos.Columns[2].Width = 150;
            dtg_datos.Columns[3].Width = 150;

            // Cambiar el color de las celdas
            dtg_datos.DefaultCellStyle.BackColor = Color.DarkGray;
            dtg_datos.DefaultCellStyle.ForeColor = Color.Yellow;
            dtg_datos.AlternatingRowsDefaultCellStyle.BackColor = Color.Black;
            dtg_datos.AlternatingRowsDefaultCellStyle.ForeColor = Color.Yellow;

            // Cambiar el color a las celdas del titulo
            dtg_datos.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dtg_datos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


        }

        private void cmb_actualizar_Click(object sender, EventArgs e)
        {
            DataRow dr = dts.Tables[0].NewRow();

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    TextBox ctr = (TextBox)item;

                    dr[ctr.Tag.ToString()] = ctr.Text;
                }

            }
            dts.Tables[0].Rows.Add(dr);

            if (dts.HasChanges())
            {
                BBDD.Actualitzar(query, dts);
            }
            if (esNou)
            {
                dts = BBDD.PortarPerConsulta(query, nomTaula);
                ConfigurarBinding();

                esNou = false;
            }
        }

        private void cmb_nuevo_Click(object sender, EventArgs e)
        {
            esNou = true;

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    TextBox ctr = (TextBox)item;
                    ctr.DataBindings.Clear();
                    ctr.Text = "";
                    ctr.Validated -= new System.EventHandler(this.ValidarTextBox);
                }
            }

        }

        private void cmb_buscar_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}
