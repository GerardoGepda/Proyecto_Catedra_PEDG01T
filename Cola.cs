using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Catedra_PEDG01T
{
    //Clase Cola 
    class Cola
    {
        private Nodo primero;// { get; set; }
        private Nodo ultimo; //{ get; set; }

        public Cola()
        {
            primero = ultimo = null;
        }

        //Metodo para ingresar elementos a la Cola
        public void Encolar(int idPedido, string fechaPedido, int estadoPedido)
        {
            MessageBox.Show("entro a encolar");
            Nodo entrada = new Nodo();
            Pedido pedido = new Pedido();

            pedido.IdPedido = idPedido;
            pedido.FechaPedido = fechaPedido;
            pedido.EstadoPedido = estadoPedido;

            entrada.Info = pedido;
            //entrada.IdPedido = idPedido;
            //entrada.EstadoPedido = estadoPedido;
            //entrada.FechaPedidio = fechaPedido;
            MessageBox.Show("test"+entrada.Info.IdPedido);
            MessageBox.Show("test" + entrada.Info.FechaPedido);
            MessageBox.Show("test" + entrada.Info.EstadoPedido);

            if (primero == null)
            {
                MessageBox.Show("Hola");
                primero = ultimo = entrada;
                entrada.Siquiente = null;               
            }
             else
             {
                 ultimo.Siquiente = entrada;
                 entrada.Siquiente = null;
                 ultimo = entrada;
                //entrada.IdPedido = idPedido;
                //entrada.EstadoPedido = estadoPedido;
                //entrada.FechaPedidio = fechaPedido;
            }
         }
        
            //Metodo para desencolar elementos de la Cola
            public void Desencolar()
        {
            if(primero == null)
            {
                MessageBox.Show("La cola se encuentra vacía", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                primero = primero.Siquiente;
            }
        }


        //metodo para desencolar elementos de la cola
        List<Nodo> datos = new List<Nodo>();
        public List<Nodo> Mostrar()
        {
            if (primero == null)
            {
                MessageBox.Show("La cola se encuentra vacía", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            else
            {
                Nodo puntero;
                puntero = primero;
                Nodo pt = new Nodo();
                do
                {
                    /* pt.IdPedido = puntero.IdPedido;
                     pt.EstadoPedido = puntero.EstadoPedido;
                     pt.FechaPedidio = puntero.FechaPedidio;
                     datos.Add(pt);*/
                    pt.Info.IdPedido = puntero.Info.IdPedido;
                    pt.Info.EstadoPedido = puntero.Info.EstadoPedido;
                    pt.Info.FechaPedido = puntero.Info.FechaPedido;
                    datos.Add(pt); 
                }
            while (puntero != null);
                return datos;
            }
        }
    }
}
