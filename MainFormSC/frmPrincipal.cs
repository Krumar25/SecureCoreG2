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
using Planets;


namespace MainFormSC
{
    public partial class frmPrincipal : Form
    {

        #region Variables Globales

        private bool menuExpandit = false;
        private bool menuWelcomeExpandit = false;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        frm_planets mantenimiento;


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

        private void menuTransicio_Tick(object sender, EventArgs e)
        {
            if (!menuExpandit)
            {
                pnlMenu.Width -= 5;

                if (pnlMenu.Width <= 74)
                {
                    menuExpandit = true;
                    menuTransicio.Stop();
                }
            }
            else
            {
                pnlMenu.Width += 5;

                if (pnlMenu.Width >= 200)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (mantenimiento == null)
            {
                mantenimiento = new frm_planets();
                mantenimiento.FormClosed += Mantenimiento_FormClosed;
                mantenimiento.MdiParent = this;
                mantenimiento.TopLevel = false;
                mantenimiento.Dock = DockStyle.Fill;
                mantenimiento.FormBorderStyle = FormBorderStyle.None;
                mantenimiento.Show();
            }
            else
            {
                mantenimiento.Activate();
            }
        }

        private void Mantenimiento_FormClosed(object sender, FormClosedEventArgs e)
        {
            mantenimiento = null;
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

        private void DesplegableWelcome_Tick(object sender, EventArgs e)
        {
            if (!menuExpandit)
            {
                if (!menuWelcomeExpandit)
                {
                    pnlMenu.Height -= 5;

                    if (pnlMenu.Height <= 0)
                    {
                        menuWelcomeExpandit = true;
                        //DesplegableWelcome.Stop();
                    }
                }
                else
                {
                    pnlMenu.Height += 5;

                    if (pnlMenu.Height >= 200)
                    {
                        menuWelcomeExpandit = false;
                        //DesplegableWelcome.Stop();
                    }
                }
            }
        }

        private void pnlWelcome_Click(object sender, EventArgs e)
        {
            //DesplegableWelcome.Start();
        }
    }
}
