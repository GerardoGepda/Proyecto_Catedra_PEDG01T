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
    public partial class PedidosForm : Form
    {
        public PedidosForm()
        {
            InitializeComponent();
        }

        private void PedidosForm_Load(object sender, EventArgs e)
        {
            Cola objCola = new Cola();
            Pedido objPedido = new Pedido();
            objPedido.MostrarPedidio();
            List<Nodo> listaD = new List<Nodo>();
            listaD = objCola.Mostrar();
            dgvpedidos.DataSource = listaD;
        }
    }
}
