using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto_Catedra_PEDG01T
{
    class RegEmpleado
    {
       public static int CrearCuenta(string usuario, string contrasena)
        {
           int resultado = 0;
            SqlConnection Conn = Proyecto.ObtenerConexion();
            SqlCommand Comando = new SqlCommand(string.Format("Insert int Usuarios(nombre, contrasena)values ('{0}',PwdEncrypt('{1}'))", usuario, contrasena), Conn);

            resultado = Comando.ExecuteNonQuery();
            return resultado;
        }
    }
}
