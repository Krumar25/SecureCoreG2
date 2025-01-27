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

namespace FormsTests
{
    public partial class Regions : frm_Base
    {
        public Regions()
        {
            InitializeComponent();
            ConfigurarConsulta("Regions", "Regions");
        }
    }
}
