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
    public partial class SWLaunchForm : UserControl
    {
        public SWLaunchForm()
        {
            InitializeComponent();
        }
        // Nombre de la dll que tiene el formulario a abrir
        private string nomClase;

        public string NomClase
        {
            get { return nomClase; }
            set { nomClase = value; }
        }
        // Nombre del formulario
        private string nomFormulari;

        public string NomFormulari
        {
            get { return nomFormulari; }
            set { nomFormulari = value; }
        }
        // Contenido del texto que tendrá el label
        private string descripcio;
        
        public string Descripcio
        {
            get { return descripcio; }
            set { descripcio = value; }
        }
        // Imagen que tendrá el label
        private string imatge;

        public string Imatge
        {
            get { return imatge; }
            set { pbOpcioMenu.Image = new System.Drawing.Bitmap(value); }
        }
        private Form parentForm;

        public Form ParentForm
        {
            get { return parentForm; }
            set { parentForm = value; }
        }

        [Browsable(true)]

        [Category("Action")]

        [Description("Invoked when user clicks button")]

        public event EventHandler ButtonClick;

        private void SWLaunchForm_Load(object sender, EventArgs e)
        {
            // Creamos un objeto SWButton y ponemos su descripción e imagen
            if (this.Descripcio != null)
            {
                lblDescripcio.Text = this.descripcio;
                lblDescripcio.Refresh();
            }
        }

        private void SWLaunchForm_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)

                this.ButtonClick(this, e);
        }

        public void activarForm()
        {
            //Cargamos la dll. No hacemos constar ningún path para que la compilemos en la carpeta donde compilamos todos los ensamblados
            Assembly ensamblat = Assembly.LoadFrom($"{this.NomClase}.dll");
            //Declaramos las variables
            Object dllBD;
            Type tipus;
            //Recuperamos el tipo de la clase que queremos instanciar
            tipus = ensamblat.GetType($"{this.NomClase}.{this.NomFormulari}");
            //Instanciamos el objeto
            dllBD = Activator.CreateInstance(tipus);

            if (dllBD is Form formulari)
            {
                formulari.TopLevel = false;
                formulari.Dock = DockStyle.Fill;
                formulari.FormBorderStyle = FormBorderStyle.None;
                formulari.MdiParent = parentForm;
                formulari.Show();
            }
        }
    }
}
