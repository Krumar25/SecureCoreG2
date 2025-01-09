using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormularioBase;

namespace RangUsuari
{
    public partial class frmRangUsuari : frm_Base
    {
        public frmRangUsuari()
        {
            InitializeComponent();
            ConfigurarConsulta("UserRanks", "Rangs Usuari");
        }
    }
}
