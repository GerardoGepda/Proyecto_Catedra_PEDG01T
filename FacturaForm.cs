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
            Factura per = new Factura();
            per.Cantidad = txtcantidad.Text;
            per.Fecha = txtfecha.Text;
            per.Monto = txtmonto.Text;
            per.Nfactura = txtnofactura.Text;
            per.Nmesa = txtnomesa.Text;

            if (edit_indice > -1) 
            {
                fact[edit_indice] = per;
                edit_indice = -1;
            }
            else
            {

                fact.Add(per); 

            }
            actualizarGrid();
            limpiar();

            MessageBox.Show("La factura se imprimio correctamente","Listo",MessageBoxButtons.OK);
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
            DataGridViewRow seleccion = dgv.SelectedRows[0];
            int pos = dgv.Rows.IndexOf(seleccion); 
            edit_indice = pos; 
            Factura per = fact[pos];

            txtnofactura.Text = per.Nfactura; 
            txtcantidad.Text = per.Cantidad;
            txtfecha.Text = per.Fecha;
            txtnomesa.Text = per.Nmesa;
            txtmonto.Text = per.Monto;
        }
    }
}
