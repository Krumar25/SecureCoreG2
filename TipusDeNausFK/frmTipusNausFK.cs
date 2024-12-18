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

namespace TipusDeNausFK
{
    public partial class frmTipusNausFK : frm_Base
    {
        public frmTipusNausFK()
        {
            InitializeComponent();
            ConfigurarConsulta("SpaceShipTypes", "Tipus de Naus");
        }
    }
}
