using Microsoft.Reporting.WinForms;
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
        Usuario usua;
        Pedido pedido;
        DetallePedido[] Dproductos;
        public FacturaForm(Pedido pedido, Usuario usua)
        {
            InitializeComponent();
            this.usua = usua;
            this.pedido = pedido;

            Dproductos = new DetallePedido[pedido.DetallePed.Count()];
            for (int i = 0; i < pedido.DetallePed.Count(); i++)
            {
                Dproductos[i] = (DetallePedido)pedido.DetallePed.ElementAtIndex(i);
            }
        }
        

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private List<Factura> fact = new List<Factura>();
        private int edit_indice = -1;

       


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

        private void FacturaForm_Load(object sender, EventArgs e)
        {
            Usuario[] usuarios = new Usuario[1];
            usuarios[0] = usua;
            Pedido[] pedidos = new Pedido[1];
            pedidos[0] = pedido;

            this.report1.LocalReport.ReportEmbeddedResource = "Proyecto_Catedra_PEDG01T.Report1.rdlc";
            this.report1.LocalReport.DataSources.Clear();
            ReportDataSource fpedido = new ReportDataSource("FacturaPedido", pedidos);
            ReportDataSource datos = new ReportDataSource("FacturaUsuario", usuarios);
            this.report1.LocalReport.DataSources.Add(datos);
            this.report1.LocalReport.DataSources.Add(fpedido);            

            this.report1.RefreshReport();
        }
    }
}
