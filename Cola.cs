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
        private Nodo primero { get; set; }
        private Nodo ultimo { get; set; }

        public Cola()
        {
            primero = ultimo = null;
        }

        //Metodo para ingresar elementos a la Cola
        public void Encolar(int idPedido, string fechaPedido, int estadoPedido)
         {
             Nodo entrada = new Nodo();
             Pedido pedido = new Pedido();

             pedido.IdPedido = idPedido;
             pedido.FechaPedido = fechaPedido;
             pedido.EstadoPedido = estadoPedido;

             entrada.Info = pedido;

             if(primero == null)
             {
                 primero = ultimo = entrada;
                 entrada.Siquiente = null;
             }
             else
             {
                 ultimo.Siquiente = entrada;
                 entrada.Siquiente = null;
                 ultimo = entrada;
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


        ////metodo para desencolar elementos de la cola
        //public void Mostrar()
        //{
        //    if (primero == null)
        //    {
        //        MessageBox.Show("La cola se encuentra vacía", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    else
        //    {
        //        Nodo puntero;
        //        puntero = primero;
        //        do
        //        {

        //        }
        //        while (puntero != null);
        //    }
        //}
    }
}
