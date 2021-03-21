using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Catedra_PEDG01T
{
    class Pedido
    {
        private int idPedido;
        private string fechaPedido;
        private int estadoPedido;

        public int IdPedido
        {
            get { return idPedido; }
            set { idPedido = value; }
        }

        public string FechaPedido
        {
            get { return fechaPedido; }
            set { fechaPedido = value; }
        }

        public int EstadoPedido
        {
            get { return estadoPedido; }
            set { estadoPedido = value; }
        }

    }
}
