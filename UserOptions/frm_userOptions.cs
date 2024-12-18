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

namespace UserOptions
{
    public partial class frm_userOptions : frm_Base
    {
        public frm_userOptions()
        {
            InitializeComponent();
            ConfigurarConsulta("UserOptions", "USER OPTIONS");
        }
    }
}
