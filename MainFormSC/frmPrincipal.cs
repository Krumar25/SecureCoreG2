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
using UserOptions;
using Users;
using Dades;
using CustomControls;

namespace MainFormSC
{
    public partial class frmPrincipal : Form
    {

        #region Variables Globales

        private bool menuExpandit = false;
        private bool dragging = false;
        public bool logout = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private AccesADades AccessDades = new AccesADades();

        private string _idAccess;

        public string idAccess
        {
            get { return _idAccess; }
            set { _idAccess = value; }
        }

        #endregion
        public frmPrincipal()
        {
            InitializeComponent();
            mdiProp();
        }


        #region Metodos

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }

        #endregion

        #region Eventos

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmBackground background = new frmBackground();
            background.MdiParent = this;
            background.Dock = DockStyle.Fill;
            background.Show();

            string query = $"SELECT * FROM Users WHERE idUser = '{_idAccess}'";
            DataSet dts = AccessDades.PortarPerConsulta(query, "Users");
            DataRow row = dts.Tables[0].Rows[0];

            try
            {
                string photoPath = row["Photo"].ToString();
                pbWelcome.Image = Bitmap.FromFile(photoPath);
            }
            catch (Exception ex)
            {
                // Manejar el error, como asignar una imagen predeterminada o dejar el PictureBox vacío
                pbWelcome.Image = null; // O puedes usar una imagen predeterminada
                                        // pbWelcome.Image = Properties.Resources.DefaultImage;

                // Opcional: Registrar el error para depuración
                Console.WriteLine($"Error al cargar la imagen: {ex.Message}");
            }
            lblWelcome.Text = "Welcome " + row["UserName"].ToString();

            //Obtencion del idUserCategory
            query = $"SELECT * FROM Users WHERE idUser = {_idAccess}";
            dts = AccessDades.PortarPerConsulta(query, "Users");
            row = dts.Tables[0].Rows[0];
            string idUserCategory = row["idUserCategory"].ToString();

            //Obtencion del AccessLevel
            query = $"SELECT * FROM UserCategories WHERE idUserCategory = {idUserCategory}";
            dts = AccessDades.PortarPerConsulta(query, "UserCategories");
            row = dts.Tables[0].Rows[0];
            string accessLevel = row["AccessLevel"].ToString();

            //Obtencion de las DLLs por AccessLevel
            query = $"SELECT * FROM UserOptions WHERE AccessLevel <= {accessLevel}";
            dts = AccessDades.PortarPerConsulta(query, "UserOptions");

            //Introduccion de los custom controls al form
            foreach (DataRow rows in dts.Tables["UserOptions"].Rows)
            {
                SWLaunchForm control = new SWLaunchForm
                {
                    NomClase = rows["class"].ToString(),
                    NomFormulari = rows["form"].ToString(),
                    Descripcio = rows["DLL_name"].ToString(),
                    Imatge = Bitmap.FromFile(rows["icon_img"].ToString()),
                    PanellManteniment = pnlMenu
                };

                // Configurar posición del UserControl en el panel
                control.Size = new Size(pnlMenu.Width, 100); // Ajustar el tamaño del control
                control.Dock = DockStyle.Top;

                // Agregar el control al panel
                pnlMenu.Controls.Add(control);
            }

            LogOutButton button = new LogOutButton();
            button.Size = new Size(pnlMenu.Width, 100); // Ajustar el tamaño del control
            button.Dock = DockStyle.Top;
            button.ButtonClick += LogoutButton_ButtonClick;
            pnlMenu.Controls.Add(button);
        }

        private void menuTransicio_Tick(object sender, EventArgs e)
        {
            if (!menuExpandit)
            {
                pnlMenu.Width -= 4;

                if (pnlMenu.Width <= 74)
                {
                    menuExpandit = true;
                    menuTransicio.Stop();
                }
            }
            else
            {
                pnlMenu.Width += 4;

                if (pnlMenu.Width >= 330)
                {
                    menuExpandit = false;
                    menuTransicio.Stop();
                }
            }
        }

        private void btnDesplegable_Click(object sender, EventArgs e)
        {
            menuTransicio.Start();
        }

        private void picBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picBoxVentana_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                picBoxVentana.Image = Bitmap.FromFile("Imatges/window.png");
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                picBoxVentana.Image = Bitmap.FromFile("Imatges/maximize.png");
            }
        }

        private void picBoxCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Método que se ejecutará cuando se haga clic en el botón del UserControl
        private void LogoutButton_ButtonClick(object sender, EventArgs e)
        {
            // Llamar al evento Button_Click existente
            Button_Click(sender, e);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            logout = true; // Indica que el cierre fue intencional
            this.Close(); // Cierra frmMain
        }

        #endregion

        #region Eventos para mover el formulario
        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        }

        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void Control_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = false;
            }
        }

        #endregion
    }
}
