using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainFormSC
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        bool menuExpandit = false;
        private void menuTransicio_Tick(object sender, EventArgs e)
        {
            if (!menuExpandit)
            {
                pnlMenu.Width -= 20;

                if (pnlMenu.Width <= 44)
                {
                    menuExpandit = true;
                    menuTransicio.Stop();
                }
            }
            else
            {
                pnlMenu.Width += 20;

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
    }
}
