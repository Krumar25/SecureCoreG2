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

namespace MainFormSC
{
    public partial class frmPrincipal : Form
    {

        #region Variables Globales

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        #endregion
        public frmPrincipal()
        {
            InitializeComponent();
            mdiProp();
        }

        bool menuExpandit = false;

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
