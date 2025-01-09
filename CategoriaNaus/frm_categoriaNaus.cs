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

namespace CategoriaNaus
{
    public partial class frm_categoriaNaus : frm_Base
    {
        public frm_categoriaNaus()
        {
            InitializeComponent();
            ConfigurarConsulta("SpaceShipCategories", "CATEGORIA DE NAVES");
        }
    }
}
