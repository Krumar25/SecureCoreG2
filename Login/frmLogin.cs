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
using CustomControls;

namespace Login
{
    public partial class frmLogin : Form
    {
        #region Variables Globales

        private const int SaltByteSize = 24;
        private const int HashByteSize = 24;
        private const int HasingIterationsCount = 10101;
        private string creedentials_query;
        private string idAccess;

        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        #endregion

        public frmLogin()
        {
            InitializeComponent();
        }
        AccesADades AccesDades = new AccesADades();

        #region Metodos

        private void verify_Creedentials()
        {
            Username = tbUser.Text.Trim();
            string password = tbPass.Text.Trim();
            string passwordBBDD;
            string loginBBDD;
            string Hashsalt;
            Dictionary<string, string> Dicc = new Dictionary<string, string>();
            Dicc.Add("@username", Username);
            creedentials_query = "SELECT * FROM Users WHERE Login = @username";

            // Verifica que ambos campos no estén vacíos
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, completa ambos campos.");
                return;
            }
            else
            {
                
                DataSet dts = AccesDades.GenerarConsultaCerca(creedentials_query, Dicc);
                if (dts.Tables.Count > 0 && dts.Tables[0].Rows.Count > 0)
                {
                    DataRow row = dts.Tables[0].Rows[0];
                    passwordBBDD = row["Password"].ToString();
                    loginBBDD = row["Login"].ToString();
                    idAccess = row["idUserCategory"].ToString();
                    Hashsalt = row["Hash"].ToString();

                    if (string.IsNullOrEmpty(Hashsalt))
                    {
                        this.Hide();

                        CanviPassword frmCanvi = new CanviPassword();
                        frmCanvi.FormClosed += (s, args) => this.Close();
                        frmCanvi.UserName = Username;
                        frmCanvi.Show();
                    }
                    else
                    {
                        Hashsalt = row["Hash"].ToString();
                        byte[] salt = HashUser.ConvertHexStringToBytes(Hashsalt);
                        byte[] passwordhashed = HashUser.ComputeHash(tbPass.Text, salt, HasingIterationsCount, HashByteSize);
                        string Password = BitConverter.ToString(passwordhashed);

                        if (Password== passwordBBDD && Username == loginBBDD)
                        {
                            this.Hide();                      
                            MainFormSC.frmPrincipal frmmain = new MainFormSC.frmPrincipal();
                            frmmain.FormClosed += (s, args) => this.Close();
                            frmmain.idAccess = idAccess;
                            frmmain.Show();
                        }
                        else
                        {
                            lbErrorLogin.Visible = true;
                        }
                        
                    }
                }
                else
                {
                    // No hay datos disponibles
                    MessageBox.Show("No hay datos disponibles.");
                }

            }
        }

        #endregion

        #region Eventos

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

        #endregion

    }
}
