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

namespace UserCategories
{
    public partial class frm_userCategories : frm_Base
    {
        public frm_userCategories()
        {
            InitializeComponent();
            ConfigurarConsulta("UserCategories", "Categorias de Usuario");
        }

    }
}
