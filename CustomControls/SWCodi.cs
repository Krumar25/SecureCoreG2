using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dades;

namespace CustomControls
{
    public partial class SWCodi : UserControl
    {
        public SWCodi()
        {
            InitializeComponent();
        }
        AccesADades AccesDades = new AccesADades();
        // Aquí empieza lo del proyecto
        private string nomTaula;

        public string NomTaula
        {
            get { return nomTaula; }
            set { nomTaula = value; }
        }
        private string nomCodi;

        public string NomCodi
        {
            get { return nomCodi; }
            set { nomCodi = value; }
        }
        private string nomDesc;

        public string NomDesc
        {
            get { return nomDesc; }
            set { nomDesc = value; }
        }
        private string nomId;

        public string NomId
        {
            get { return nomId; }
            set { nomId = value; }
        }
        private string formCS;

        public string FormCS
        {
            get { return formCS; }
            set { formCS = value; }
        }
        private string classeCS;

        public string ClasseCS
        {
            get { return classeCS; }
            set { classeCS = value; }
        }
        private string controlID;

        public string ControlID
        {
            get { return controlID; }
            set { controlID = value; }
        }
        private void UpdateControlID(string id)
        {
            Form frm = this.FindForm();
            foreach(Control control in frm.Controls)
            {
                if (control.Name == ControlID)
                {
                    control.Text = id;
                }
            }
        }
        public void obreCS (string classeCS, string formCS)
        {
            //Cargamos la dll. No hacemos constar ningún path para que la compilemos en la carpeta donde compilamos todos los ensamblados
            Assembly ensamblat = Assembly.LoadFrom($"{this.classeCS}.dll");
            //Declaramos las variables
            Object dllBD;
            Type tipus;
            //Recuperamos el tipo de la clase que queremos instanciar
            tipus = ensamblat.GetType($"{this.classeCS}.{this.formCS}");
            //Instanciamos el objeto
            dllBD = Activator.CreateInstance(tipus);
            //Lo mostramos asumiendo que se trata de un form y por eso hacemos un cast con (Form)
            ((Form)dllBD).Show();
        }
        public void ValidaCodi()
        {
            Dictionary<string, string> Dicc = new Dictionary<string, string>();
            Dicc.Add("@nomTaula", NomTaula);
            Dicc.Add("@nomCodi", NomCodi);
            Dicc.Add("@NomCodi", txtCodiNivell.Text);
            string query = $"SELECT * FROM @nomTaula WHERE {NomCodi}= @NomCodi"; //Modificado 
            DataSet dts = AccesDades.GenerarConsultaCerca(query, Dicc);

            if (dts.Tables.Count > 0 && dts.Tables[0].Rows.Count > 0)
            {
                DataRow row = dts.Tables[0].Rows[0];

                txtNivell.Text = row[NomDesc].ToString();
                UpdateControlID(row[NomId].ToString());
            }
            else
            {
                txtCodiNivell.Focus();
                txtNivell.Text = "Unknown Data";
            }

        }

        private void SWCodi_Validating(object sender, CancelEventArgs e)
        {
            ValidaCodi();
        }
    }
}
