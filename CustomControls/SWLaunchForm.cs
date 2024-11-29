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
        private Image imatge;

        public Image Imatge
        {
            get { return imatge; }
            set { imatge = value; }
        }
        private Panel panellManteniment;

        public Panel PanellManteniment
        {
            get { return panellManteniment; }
            set { panellManteniment = value; }
        }


        private void SWLaunchForm_Click(object sender, EventArgs e)
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
                panellManteniment.Controls.Clear();
                panellManteniment.Controls.Add(formulari);
                formulari.Show();
            }
        }

        private void SWLaunchForm_Load(object sender, EventArgs e)
        {
            // Creamos un objeto SWButton y ponemos su descripción e imagen
            if (this.Descripcio != null)
            {
                lblDescripcio.Text = this.descripcio;
                lblDescripcio.Refresh();
            }
            if (this.Imatge != null)
            {
                pbOpcioMenu.Image = this.Imatge;
            }
        }
    }
}
