using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Catedra_PEDG01T
{
    class Nodo
    {
        private Pedido info;
        private int idP;
        private Nodo siguiete;
        /*private int idPedido;
        private string fechaPedidio;
        private int estadoPedido;*/


        public Pedido Info
        {
            get { return info; }
            set { info = value; }
        }


        public Nodo Siquiente
        {
            get { return siguiete; }
            set { siguiete = value; }
        }


        public int IdP { get => idP; set => idP = value; }

        

        //public int IdPedido { get => idPedido; set => idPedido = value; }
        //public string FechaPedidio { get => fechaPedidio; set => fechaPedidio = value; }
        //public int EstadoPedido { get => estadoPedido; set => estadoPedido = value; }
    }
}
