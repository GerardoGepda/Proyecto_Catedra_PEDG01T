using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Catedra_PEDG01T
{
    class Producto
    {
        //campos de la clase
        private string nombre;
        private double precio;
        private string Codigo;
        private string descripcion;

        //propiedades de la clase
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Codigo1 { get => Codigo; set => Codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
