using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Catedra_PEDG01T
{
    class Factura
    {
        //atributos
        
        private string nMesa;
        private string monto;
        private string fecha;
        private string nFactura;
        private string cantidad;

        //métodos
       
        public string Nmesa
        {
            get { return nMesa; }
            set { nMesa = value; }
        }
        public string Monto
        {
            get { return monto; }
            set { monto = value; }
        }
        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string Nfactura
        {
            get { return nFactura; }
            set { nFactura = value; }
        }

        public string Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
    }
}
