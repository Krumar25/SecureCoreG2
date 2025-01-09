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
using CustomControls;
using Dades;

namespace Planets
{
    public partial class frm_planets : frm_Base
    {
        public frm_planets()
        {
            InitializeComponent();
            ConfigurarConsulta("Planets", "Planetas");
        
        }

        private void swTx_planet_TextChanged(object sender, EventArgs e)
        {
            swCodi_planet.ActualizarId(swTx_planet.Text);
        }

        private void swTx_sector_TextChanged(object sender, EventArgs e)
        {
            swCodi_sector.ActualizarId(swTx_sector.Text);
        }

        private void swTx_nativos_TextChanged(object sender, EventArgs e)
        {
            swCodi_nativos.ActualizarId(swTx_nativos.Text);
        }

        private void swTx_filiation_TextChanged(object sender, EventArgs e)
        {
            swCodi_filiation.ActualizarId(swTx_filiation.Text);
        }
    }
}
