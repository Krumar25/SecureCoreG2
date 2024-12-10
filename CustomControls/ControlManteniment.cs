using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace CustomControls
{
    public partial class ControlManteniment : UserControl
    {
        public ControlManteniment()
        {
            InitializeComponent();
        }

        private string nomClase;
        private string nomForm;
        private string descripcio;

        private Image img;

        public string NomClase
        {
            get { return nomClase; }
            set { nomClase = value; }
        }
        public string NomForm
        {
            get { return nomForm; }
            set { nomForm = value; }
        }

        public string Descripcio
        {
            get { return descripcio; }
            set {descripcio = value; }
        }
        public Image Img
        {
            get { return img; }
            set { img = value; }
        }

        private void ControlManteniment_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(descripcio))
            {
                lbl_titulo.Text = descripcio;
                lbl_titulo.ForeColor = Color.Yellow;
            }
            if (img != null)
            {
                pb_logo.Image = this.Img;
            }

        }

        private void pb_logo_Click(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.LoadFrom($@"{this.NomClase}.dll");
            Object dllBD;
            Type type;

            type = assembly.GetType($"{this.NomForm}.{this.NomClase}");
            dllBD = Activator.CreateInstance(type);

            ((Form)dllBD).Show();
        }
    }
}
