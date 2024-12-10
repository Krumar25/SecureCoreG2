using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CustomControls
{
    public partial class SWTextBox : TextBox
    {
        #region Variables Globals

        public enum TipusDada
        {
            Numero,
            Text,
            Codi
        }

        // Permite decidir si el TextBox será un número, un texto o un código
        private TipusDada dadaPermesa;

        public TipusDada DadaPermesa
        {
            get { return dadaPermesa; }
            set { dadaPermesa = value; }
        }

        // Permite decidir si el TextBox puede estar vacío o no (verificar al validar el dato)
        private bool esNulable;
        public bool EsNulable
        {
            get { return esNulable; }
            set { esNulable = value; }
        }

        // Indica si es una clave foránea
        private bool esForana;
        public bool EsForana
        {
            get { return esForana; }
            set { esForana = value; }
        }

        // Indica el nombre del campo de la base de datos al que enlazaremos el control
        private string campBBDD;

        public string CampBBDD
        {
            get { return campBBDD; }
            set { campBBDD = value; }
        }

        // Regex para el código: YXXX001
        private Regex regex = new Regex(@"^[AEIOU][A-Z]{3}\d{2}[13579]$");


        #endregion

        public SWTextBox()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SWTextBox
            // 
            this.Enter += new System.EventHandler(this.SWTextBox_Enter);
            this.Leave += new System.EventHandler(this.SWTextBox_Leave);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.SWTextBox_Validating);
            this.ResumeLayout(false);
        }

        #region Events

        // Cambio de color al recibir el foco
        private void SWTextBox_Enter(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Yellow;
        }
        // Cambio de color al color por defecto al salir del foco
        private void SWTextBox_Leave(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;
        }
        private void SWTextBox_Validating(object sender, CancelEventArgs e)
        {
            // Validación de la propiedad EsNulable
            if (!EsNulable)
            {
                if (this.Text is null)
                {
                    MessageBox.Show("Aquest camp no pot ser nul");
                }
            }
            // Validación de la propiedad TipusDada
            if (DadaPermesa.Equals(TipusDada.Numero) && this.Text != null)
            {
                Regex regex = new Regex(@"^\d*$");

                if (!regex.IsMatch(this.Text))
                {
                    MessageBox.Show("Això no és un número");
                    this.Clear();
                }
            }
            else if (DadaPermesa.Equals(TipusDada.Codi) && this.Text != null)
            {
                if (!regex.IsMatch(this.Text))
                {
                    MessageBox.Show("Codi incorrecte");
                    this.Clear();
                }
            }
            // Enlazar el control 
            if (CampBBDD != null)
            {
                Form frm = this.FindForm();

                foreach (Control ctrl in frm.Controls)
                {
                    if (CampBBDD.Equals(ctrl.Name))
                    {
                        ctrl.Text = this.Text;
                    }
                }
            }
        }

        #endregion

    }
}
