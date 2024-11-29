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
    }
}
