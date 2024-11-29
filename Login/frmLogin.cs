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
using Hashing;


namespace Login
{
    public partial class frmLogin : Form
    {
        //private const int SaltByteSize = 24;
        private const int HashByteSize = 24;
        private const int HasingIterationsCount = 10101;
        private string creedentials_query;
        public frmLogin()
        {
            InitializeComponent();
        }
        AccesADades AccesDades = new AccesADades();

        private void verify_Creedentials()
        {
            string username = tbUser.Text.Trim();
            string password = tbPass.Text.Trim();
            //creedentials_query = "SELECT * FROM Users WHERE Login = @username";
            creedentials_query = "SELECT * FROM LoginFrancescRubio WHERE Login = @username";


            // Verifica que ambos campos no estén vacíos
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, completa ambos campos.");
                return;
            }
            else
            {
                DataSet dts = AccesDades.GenerarConsultaCerca(creedentials_query, username, "@username");
                if (dts.Tables.Count > 0 && dts.Tables[0].Rows.Count > 0)
                {
                    DataRow row = dts.Tables[0].Rows[0];

                    byte[] salt = Convert.FromBase64String(row["Salt"].ToString());
                    byte[] passwordhashed = HashUser.ComputeHash(password, salt, HasingIterationsCount, HashByteSize);
                    byte[] passwordBBDD = Convert.FromBase64String(row["Password"].ToString());

                    if (HashUser.AreHashesEqual(passwordhashed, passwordBBDD)) // Validación de ejemplo
                    {
                        this.Hide();

                        Main.frmMain frmmain = new Main.frmMain();
                        frmmain.Show();
                        //MessageBox.Show("Usuario y contraseña correctos");
                    }
                    else
                    {
                        // Si falla el login, muestra un mensaje de error
                        lbErrorLogin.Visible = true;
                    }
                }
                else
                {
                    // No hay datos disponibles
                    MessageBox.Show("No hay datos disponibles.");
                }

            }
        }
        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMinim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbMostrarPass_Click(object sender, EventArgs e)
        {
            pbMostrarPass.Visible = false;
            pbOcultarPass.Visible = true;
            tbPass.UseSystemPasswordChar = false;
        }

        private void pbOcultarPass_Click(object sender, EventArgs e)
        {
            pbOcultarPass.Visible = false;
            pbMostrarPass.Visible = true;
            tbPass.UseSystemPasswordChar = true;
        }

        private void tbPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                verify_Creedentials();
            }
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            verify_Creedentials();
        }
    
}
}
