﻿using System;
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
        public void Encolar(int idPedido)
        {
            Nodo entrada = new Nodo();
            Pedido pedido = new Pedido();
            entrada.IdP = idPedido;
           

            if (primero == null)
            {               
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
        public void Desencolar(int idPedido)
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



        //metodo para mostrar elementos de la cola
        List<int> datos = new List<int>();
        int contador = 0;
        public List<int> Mostrar()
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

                    datos.Add(puntero.IdP);                   
                    puntero = puntero.Siquiente; 
                   
                }
                while (puntero != null);
                return datos;
            }
        }

        public Pedido[] QueueToArray()
        {
            Pedido[] items = new Pedido[Count()];

            if (primero != null)
            {
                Nodo puntero;
                puntero = primero;

                items[0] = puntero.Info;
                int contador = 0;
                while (puntero.Siquiente != null)
                {
                    contador++;
                    puntero = puntero.Siquiente;
                    items[contador] = puntero.Info;
                }
            }
            return items;
        }

        //metodo para conocer la cantidad de elemtos
        public int Count()
        {
            int count = 0;
            if (primero != null)
            {
                Nodo puntero;
                puntero = primero;

                count = 1;
                while (puntero.Siquiente != null)
                {
                    count++;
                    puntero = puntero.Siquiente;
                }
            }else
            {
                MessageBox.Show("La cola se encuentra vacía", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return count;
        }
    }
}
