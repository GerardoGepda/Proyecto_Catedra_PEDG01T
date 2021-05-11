using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


namespace Proyecto_Catedra_PEDG01T
{
    public class Pedido
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
        private string NombreProducto;
        private int Cantidad;
        private double total;
        private Lista detallePed = new Lista();
        List<Pedido> listaPedido = new List<Pedido>();
        //propiedades de la clase
        public int IdPedido { get => idPedido; set => idPedido = value; }
        public string FechaPedido { get => fechaPedido; set => fechaPedido = value; }
        public int EstadoPedido { get => estadoPedido; set => estadoPedido = value; }
        public string IdUsuario { get => idUsuario; set => idUsuario = value; }
        public double Total { get => total; set => total = value; }
        public Lista DetallePed { get => detallePed; set => detallePed = value; }
        public string NombreProducto1 { get => NombreProducto; set => NombreProducto = value; }
        public int Cantidad1 { get => Cantidad; set => Cantidad = value; }

        //--- Métodos de clase ---//

        //total de todos los productos
        public void calcularTotal()
        {
            double total = 0;

            for (int i = 0; i < DetallePed.Count(); i++)
            {
                total += ((DetallePedido)DetallePed.ElementAtIndex(i)).PrecioTotalDetalle;
            }

            Total = total;
        }

        //Método que ingresa el pedido a la DB
        public bool CreatePedido()
        {
            bool creado = false;
            string sql = "INSERT INTO Pedido (idUsuario, estadoPedido, totalPedido) VALUES (@idUser, @estdP, @total)";

            try
            {
                conexion.Conectar();
                command = new SqlCommand(sql, conexion.Conn);
                command.Parameters.AddWithValue("@idUser", IdUsuario);
                command.Parameters.AddWithValue("@total", Total);
                command.Parameters.AddWithValue("@estdP", EstadoPedido);
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
            int idped;
            string sql = "INSERT INTO Detalle_pedido (idProducto, cantidadProducto, precioDetalle, idPedido) " +
                "VALUES (@idPrdt, @cantidad, @precio, @idPd)";
            string sql2 = "SELECT TOP 1 idPedido FROM Pedido ORDER BY idPedido DESC";

            try
            {
                conexion.Conectar();

                //Primero extraemos el id del pedido
                dataAdapter = new SqlDataAdapter(sql2, conexion.Conn);
                dataReader = dataAdapter.SelectCommand.ExecuteReader();
                if (!dataReader.HasRows)
                    throw new Exception("Error al extraer id del pedido");
                dataReader.Read();
                idped = Convert.ToInt32(dataReader[0]);
                dataReader.Close();

                //Insertamos los detalles del pedido con ayuda de un bucle
                command = new SqlCommand(sql, conexion.Conn);
                command.Parameters.AddWithValue("@idPd", idped);
                command.Parameters.Add("@idPrdt", System.Data.SqlDbType.Int);
                command.Parameters.Add("@cantidad", System.Data.SqlDbType.Int);
                command.Parameters.Add("@precio", System.Data.SqlDbType.Float);
                ///
                DetallePedido detallePedido;
                for (int i = 0; i < DetallePed.Count(); i++)
                {
                    detallePedido = (DetallePedido)DetallePed.ElementAtIndex(i);
                    command.Parameters["@idPrdt"].Value = detallePedido.IdProducto;
                    command.Parameters["@cantidad"].Value = detallePedido.Cantidad;
                    command.Parameters["@precio"].Value = detallePedido.PrecioTotalDetalle;
                    guardado = command.ExecuteNonQuery() > 0 ? true : false;
                    detallePedido = null;
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

        List<int> encontrados = new List<int>();
        public List<int> MostrarPedidio()
        {
            conexion.Conectar();
            Cola pedido = new Cola();
            String sql = "SELECT P.idPedido as Id,nombreProducto as Producto, cantidadProducto as Cantidad from Pedido as P inner join Detalle_pedido as DP on P.idPedido = DP.idPedido inner join Productos as PR on DP.idProducto = PR.idProducto  WHERE estadoPedido = 0 order by fechaPedido ASC";
            try
            {
                dataAdapter = new SqlDataAdapter(sql, conexion.Conn);
                dataReader = dataAdapter.SelectCommand.ExecuteReader();
                if (dataReader.HasRows)
                {

                    while (dataReader.Read())
                    {
                                             
                        IdPedido = int.Parse(dataReader["Id"].ToString());
                        NombreProducto = dataReader["Producto"].ToString();
                        Cantidad = int.Parse(dataReader["Cantidad"].ToString());
                         
                        encontrados.Add(idPedido);
                    }
                    return encontrados;

                }
                else
                {

                    MessageBox.Show("No hay pedidos que mostrar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataReader.Close();
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los pedidos " +
                    ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                //cerramos la conexión
                conexion.Cerrar();
            }
        }

        public void buscarPedidos(int idPedido)
        {

            conexion.Conectar();
            try
            {
                
                int id = idPedido;
                String sql = "SELECT P.idPedido as Id,nombreProducto as Producto, cantidadProducto as Cantidad, fechaPedido from Pedido as P inner join Detalle_pedido as DP on P.idPedido = DP.idPedido inner join Productos as PR on DP.idProducto = PR.idProducto  WHERE estadoPedido = 0 AND P.idPedido = @idPedido";
                dataAdapter = new SqlDataAdapter(sql, conexion.Conn);
                SqlParameter prm = new SqlParameter("@idPedido", SqlDbType.Int);
                prm.Value = id;
                dataAdapter.SelectCommand.Parameters.Add(prm);
                dataReader = dataAdapter.SelectCommand.ExecuteReader();
                while (dataReader.Read())
                {
                   
                }
                conexion.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            } 
            if (dataReader != null)
            {
                dataReader.Close();
            }
        }

        public List<Pedido> buscarPedidosPorId(int idPedido)
        {
            conexion.Conectar();
            try
            {

                int id = idPedido;
                String sql = "SELECT P.idPedido as Id,nombreProducto as Producto, cantidadProducto as Cantidad, fechaPedido from Pedido as P inner join Detalle_pedido as DP on P.idPedido = DP.idPedido inner join Productos as PR on DP.idProducto = PR.idProducto  WHERE estadoPedido = 0 AND P.idPedido = @idPedido ORDER BY fechaPedido ASC";
                dataAdapter = new SqlDataAdapter(sql, conexion.Conn);
                SqlParameter prm = new SqlParameter("@idPedido", SqlDbType.Int);
                prm.Value = id;
                dataAdapter.SelectCommand.Parameters.Add(prm);
                dataReader = dataAdapter.SelectCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    listaPedido.Add(new Pedido
                    {

                        IdPedido = (int)dataReader["Id"],
                        NombreProducto = dataReader["Producto"].ToString(),
                        Cantidad = (int)dataReader["Cantidad"],
                        fechaPedido = dataReader["fechaPedido"].ToString()
                    });

                }
                conexion.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
            if (dataReader != null)
            {
                dataReader.Close();
            }
            return listaPedido;
        }
    }
}
