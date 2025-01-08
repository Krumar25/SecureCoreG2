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

        private void idFiliation_TextChanged(object sender, EventArgs e)
        {
            swCodiFiliation.ActualizarId(idFiliation.Text);
        }

        private void idCategory_TextChanged(object sender, EventArgs e)
        {
            swCodiCategory.ActualizarId(idCategory.Text);
        }
    }
}
