using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Catedra_PEDG01T
{
    class Factura
    {
        //campos
        private string nMesa;
        private string monto;
        private string fecha;
        private string nFactura;
        private string cantidad;

        //propiedades
        public string NMesa { get => nMesa; set => nMesa = value; }
        public string Monto { get => monto; set => monto = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string NFactura { get => nFactura; set => nFactura = value; }
        public string Cantidad { get => cantidad; set => cantidad = value; }

    }
}
