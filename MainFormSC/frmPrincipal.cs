using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using mdiProperties;
using Dades;

namespace MainFormSC
{
    public partial class frmPrincipal : Form
    {
        CustomControls.SWLaunchForm launchForm;
        AccesADades AccesDades = new AccesADades();
        private string acceslevel;
        

        public frmPrincipal()
        {
            InitializeComponent();
            mdiProp();
        }
        bool menuExpandit = false;
        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }
        private void menuTransicio_Tick(object sender, EventArgs e)
        {
            if (menuExpandit)
            {
                pnlMenu.Width -= 10;

                if (pnlMenu.Width <= 200)
                {
                    menuExpandit = false;
                    menuTransicio.Stop();
                }
                else
                {
                    pnlMenu.Width += 10;

                    if (pnlMenu.Width >= 200)
                    {
                        menuExpandit = true;
                        menuTransicio.Stop();
                    }
                }
            }
        }

        private void form_ButtonClick(object sender, EventArgs e)
        {
            launchForm = (CustomControls.SWLaunchForm)sender;
            launchForm.activarForm();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM UserOptions WHERE AccesLevel <= @acceslevel";
            DataSet dts = AccesDades.GenerarConsultaCerca(query, acceslevel, "@acceslevel");

            foreach (DataRow row in dts.Tables[0].Rows)
            {
                CustomControls.SWLaunchForm buttonLaunchForm = new CustomControls.SWLaunchForm();
                buttonLaunchForm.NomClase = row["class"].ToString();
                buttonLaunchForm.NomFormulari = row["form"].ToString();
                buttonLaunchForm.Descripcio = row["DLL_name"].ToString();
                buttonLaunchForm.Imatge = row["icon_img"].ToString();
            }
        }
    }
}
