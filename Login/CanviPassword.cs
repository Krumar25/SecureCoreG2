using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hashing;
using Dades;

namespace Login
{
    public partial class CanviPassword : Form
    {
        #region Variables Globales

        string query_update_pass;
        private const int SaltByteSize = 24;
        private const int HashByteSize = 24;
        private const int HasingIterationsCount = 10101;
        private string username;

        public string UserName
        {
            get { return username; }
            set { username = value; }
        }

        #endregion

        public CanviPassword()
        {
            InitializeComponent();
            
        }

        #region Metodos

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

        private void btnAccess_Click(object sender, EventArgs e)
        {
            if (tbNewPass.Text == tbConfNewPass.Text)
            {
                Dictionary<string, string> Dicc = new Dictionary<string, string>();

                byte[] Salt= HashUser.GenerateSalt(SaltByteSize);
                byte[] passwordhashed = HashUser.ComputeHash(tbNewPass.Text, Salt, HasingIterationsCount, HashByteSize);
                
                Dicc.Add("@username", UserName);
                Dicc.Add("@pass", BitConverter.ToString(passwordhashed));
                Dicc.Add("@salt", BitConverter.ToString(Salt));


                query_update_pass = "UPDATE Users SET Hash = @salt, Password = @pass WHERE Login = @username";

                AccesADades dades = new AccesADades();
                dades.Executa(query_update_pass,Dicc);

                this.Hide();

                MainFormSC.frmPrincipal frmmain = new MainFormSC.frmPrincipal();
                frmmain.Show();
            }
            else
            {

            }
        }

        #endregion
    }
}
