using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_Catedra_PEDG01T
{
    public partial class RegEmpForm : Form
    {
        public RegEmpForm()
        {
            InitializeComponent();
        }

        private void btntypeuser_Click(object sender, EventArgs e)
        {
            cbxtypeuser.DroppedDown = !cbxtypeuser.DroppedDown;
        }
    }
}
