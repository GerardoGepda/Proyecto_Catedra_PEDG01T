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
    public partial class PedidosForm : Form
    {
        public PedidosForm()
        {
            InitializeComponent();
            llenarDataGrid();
        }
       
        List<int> listaDatos1 = new List<int>();
        List<int> listaDatos2 = new List<int>();
        List<Pedido> listaPedidos;
        Cola objCola;
        Pedido objPedido;
        private void llenarDataGrid()
        {
            listaPedidos = new List<Pedido>();
            objPedido = new Pedido();
            objCola = new Cola();
            listaDatos1 = objPedido.MostrarPedidio();
            for (int i = 0; i < listaDatos1.Count; i++)
            {
                objCola.Encolar(listaDatos1[i]);

            }

            listaDatos2 = objCola.Mostrar();
            dgvpedidos.DataSource = null;
            for (int i = 0; i < listaDatos2.Count; i++)
            {
                listaPedidos = objPedido.buscarPedidosPorId(listaDatos2[i]);
            }

            dgvpedidos.DataSource = listaPedidos;
            dgvpedidos.Columns[0].Visible = false;
            dgvpedidos.Columns[1].HeaderText = "Fecha de pedido";
            dgvpedidos.Columns[2].Visible = false;
            dgvpedidos.Columns[3].Visible = false;
            dgvpedidos.Columns[4].Visible = false;
            dgvpedidos.Columns[5].Visible = false;
            dgvpedidos.Columns[6].HeaderText = "Nombre de producto";
            dgvpedidos.Columns[7].HeaderText = "Cantidad";
        }
        private void PedidosForm_Load(object sender, EventArgs e)
        {           
            
        }
    }
}
