using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls;
using Dades;

namespace Users
{
    public partial class frm_users : FormularioBase.frm_Base
    {

        public frm_users()
        {
            InitializeComponent();
            ConfigurarConsulta("Users", "USERS");
        }

        private void swidUserRank_TextChanged(object sender, EventArgs e)
        {
            swUserRanks.ActualizarId(swidUserRank.Text);
        }

        private void swidUserCategory_TextChanged(object sender, EventArgs e)
        {
            swUserCategory.ActualizarId(swidUserCategory.Text);
        }

        private void swidPlanet_TextChanged(object sender, EventArgs e)
        {
            swPlanet.ActualizarId(swidPlanet.Text);
        }

        private void swidSpecie_TextChanged(object sender, EventArgs e)
        {
            swSpecie.ActualizarId(swidSpecie.Text);
        }

        private void swbtnResetPass_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> Dicc = new Dictionary<string, string>();

            Dicc.Add("@username", swUserName.Text);

            string query_reset_pass = "UPDATE Users SET Hash = NULL, Password = '12345aA' WHERE UserName = @username";

            AccesADades dades = new AccesADades();
            dades.Executa(query_reset_pass, Dicc);
            CargarDatos();
        }

        private void swbtnGenerarTarjeta_Click(object sender, EventArgs e)
        {

            Tarjeta report_tarjeta = new Tarjeta();
            this.Hide();
            report_tarjeta.MdiParent = this.ParentForm;
            report_tarjeta.TopLevel = false;
            report_tarjeta.Dock = DockStyle.Fill;
            report_tarjeta.FormBorderStyle = FormBorderStyle.None;
            report_tarjeta.ID = swidUser.Text;
            report_tarjeta.Show();
        }
    }
}
