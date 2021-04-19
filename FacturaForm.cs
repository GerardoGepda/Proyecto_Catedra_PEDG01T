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
    public partial class FacturaForm : Form
    {
        public FacturaForm()
        {
            InitializeComponent();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private List<Factura> fact = new List<Factura>();
        private int edit_indice = -1;

        private void actualizarGrid()
        {
            dgv.DataSource = null;
            dgv.DataSource = fact;
        }

        private void limpiar()
        {
            txtnomesa.Clear();
            txtnofactura.Clear();
            txtmonto.Clear();
            txtfecha.Clear();
            txtcantidad.Clear();
        }


        private void btnimprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Se agregara el producto al pedido");
            PedidosForm n = new PedidosForm();
            n.Show();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seguro que quiere cancelar ", "Clic para continuar", MessageBoxButtons.OK);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWState_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
        }
    }
}
