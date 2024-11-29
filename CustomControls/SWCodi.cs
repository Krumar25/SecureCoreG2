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

namespace CustomControls
{
    public partial class SWCodi : UserControl
    {
        public SWCodi()
        {
            InitializeComponent();
        }
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
        private void obreCS (string classeCS, string formCS)
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
        // Aqui acaba
        private bool requerit;

        public bool Requerit
        {
            get { return requerit; }
            set { requerit = value; }
        }

        public enum Nivell
        {
            GS,
            GM,
        }
        private Nivell dadaNivell;

        public Nivell DadaNivell
        {
            get { return dadaNivell; }
            set { dadaNivell = value; }
        }
        private void ValidaCodi()
        {
            if (DadaNivell.Equals(Nivell.GS) && this.Text != null)
            {
                if (txtCodiNivell.Text.Equals("S2AM") && this.Text != null)
                {
                    txtNivell.Text = "Desenvolupament aplicacions multiplataforma";
                } 
                else if (txtCodiNivell.Text.Equals("S2SX") && this.Text != null)
                {
                    txtNivell.Text = "Administració de sistemes Informàtics en xarxa";
                }
                else if (txtCodiNivell.Text.Equals("M2SX") && this.Text != null)
                {
                    txtNivell.Text = "Codi incorrecte";
                    txtCodiNivell.Clear();
                    txtCodiNivell.Focus();
                }
                else
                {
                    txtNivell.Text = "Uknown data";
                }
            }
            else if (DadaNivell.Equals(Nivell.GM) && this.Text != null)
            {
                if (txtCodiNivell.Text.Equals("M2SX"))
                {
                    txtNivell.Text = "Sistemes MicroInformàtics i Xarxesa";
                }
                else if (txtCodiNivell.Text.Equals("S2AM") && this.Text != null)
                {
                    txtNivell.Text = "Codi incorrecte";
                    txtCodiNivell.Clear();
                    txtCodiNivell.Focus();
                }
                else if (txtCodiNivell.Text.Equals("S2SX") && this.Text != null)
                {
                    txtNivell.Text = "Codi incorrecte";
                    txtCodiNivell.Clear();
                    txtCodiNivell.Focus();
                }
                else
                {
                    txtNivell.Text = "Uknown data";
                }
            }
        }
        private void txtCodiNivell_Validating(object sender, CancelEventArgs e)
        {
            if (Requerit && txtCodiNivell.Text.Equals(""))
            {
                e.Cancel = true;
            }
        }

        private void txtCodiNivell_Leave(object sender, EventArgs e)
        {
            ValidaCodi();
        }
    }
}
