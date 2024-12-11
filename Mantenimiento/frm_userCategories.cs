using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantenimiento
{
    public partial class frm_userCategories : FormularioBase.frm_Base
    {
        public frm_userCategories()
        {
            InitializeComponent();
            ConfigurarConsulta("UserCategories", "USER CATEGORIES");
        }
    }
}
