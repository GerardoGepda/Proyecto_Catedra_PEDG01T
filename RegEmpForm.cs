using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Catedra_PEDG01T
{
    public partial class RegEmpForm : Form
    {
        public RegEmpForm()
        {
            InitializeComponent();
        }

        private void btnregistrarse_Click(object sender, EventArgs e)
        {
            if(txtcontraseña.Text==txtverificar.Text)
            {
                if (RegEmpleado.CrearCuenta(txtusuario.Text, txtcontraseña.Text) > 0)
                {
                    MessageBox.Show("Cuenta creada con exito");
                }
                else
                    MessageBox.Show("No se pudo crear la cuenta");
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
