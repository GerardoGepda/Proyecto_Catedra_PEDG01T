using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Catedra_PEDG01T
{
    class Pedido
    {
        //herramientas para la clase
        private Conexion conexion = new Conexion();
        private SqlDataAdapter dataAdapter;
        private SqlDataReader dataReader;
        private SqlCommand command;

        //campos de la clase
        private int idPedido;
        private string fechaPedido;
        private int estadoPedido;
        private string idUsuario;
        private float total;
        private Lista detallePed = new Lista();

        //propiedades de la clase
        public int IdPedido { get => idPedido; set => idPedido = value; }
        public string FechaPedido { get => fechaPedido; set => fechaPedido = value; }
        public int EstadoPedido { get => estadoPedido; set => estadoPedido = value; }
        public string IdUsuario { get => idUsuario; set => idUsuario = value; }
        public float Total { get => total; set => total = value; }
        public Lista DetallePed { get => detallePed; set => detallePed = value; }

        //--- Métodos de clase ---//

        //total de todos los productos
        public void calcularTotal()
        {
            float total = 0;
            DetallePedido[] dPedido = (DetallePedido[])DetallePed.ListToArray();

            foreach (DetallePedido item in dPedido)
            {
                total += item.PrecioTotalDetalle;
            }
            Total = total;
        }

        //Método que ingresa el pedido a la DB
        public bool CreatePedido()
        {
            bool creado = false;
            string sql = "INSERT INTO Pedido (idUsuario, totalPedido) VALUE (@idUser, @total)";

            try
            {
                conexion.Conectar();
                command = new SqlCommand(sql, conexion.Conn);
                command.Parameters.AddWithValue("@idUser", IdUsuario);
                command.Parameters.AddWithValue("@total", Total);
                creado = command.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al crear pedido en la DB: " + err.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Cerrar();
            }

            SaveDetails();

            return creado;
        }

        //Método que inserta los detalles del pedido en la DB
        private bool SaveDetails()
        {
            bool guardado = false;
            int idpedido;
            string sql = "INSERT INTO Detalle_pedido (idProducto, cantidadProducto, precioDetalle, idPedido) " +
                "VALUES (@idPrdt, @cantidad, @precio, @idPed)";
            string sql2 = "SELECT TOP 1 idPedido FROM Pedido ORDER BY idPedido DESC";
            
            try
            {
                conexion.Conectar();

                //Primero extraemos el id del pedido
                dataAdapter = new SqlDataAdapter(sql2, conexion.Conn);
                dataReader = dataAdapter.SelectCommand.ExecuteReader();
                if (!dataReader.HasRows)
                    throw new Exception("Error al extraer id del pedido");

                idpedido = Convert.ToInt32(dataReader[0].ToString());

                //Insertamos los detalles del pedido con ayuda de un bucle
                command = new SqlCommand(sql, conexion.Conn);
                command.Parameters.AddWithValue("@idPed", idPedido);

                DetallePedido[] detalles = (DetallePedido[])DetallePed.ListToArray();
                foreach (DetallePedido detalle in detalles)
                {
                    command.Parameters.AddWithValue("@idPrdt", detalle.IdProducto);
                    command.Parameters.AddWithValue("@cantidad", detalle.IdProducto);
                    command.Parameters.AddWithValue("@precio", detalle.IdProducto);
                    guardado = command.ExecuteNonQuery() > 0 ? true : false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al guardar los detalles del pedido en la DB: " + err.Message, 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dataReader.Close();
                conexion.Cerrar();
            }

            return guardado;
        }

    }
}
