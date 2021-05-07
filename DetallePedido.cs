﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Catedra_PEDG01T
{
    public class DetallePedido
    {
        //herramientas para la clase
        private static Conexion conexion = new Conexion();
        private static SqlDataAdapter dataAdapter;
        private static SqlDataReader dataReader;
        private static SqlCommand command;

        //campos de la clase
        private int idProducto;
        private string codigoProducto;
        private string nombreProducto;
        private int cantidad;
        private double precioProducto;
        private double precioTotalDetalle;

        //propiedades de la clase
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double PrecioProducto { get => precioProducto; set => precioProducto = value; }
        public double PrecioTotalDetalle { get => precioTotalDetalle; set => precioTotalDetalle = value; }
        public string CodigoProducto { get => codigoProducto; set => codigoProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }

        //--- Métodos de la clase ---//

        //Método que calcula el precio total de una cantidad de un producto
        public void PrecioTotalD()
        {
            PrecioTotalDetalle = PrecioProducto * Cantidad;
        }

        //Método que extrae los detalles de un pedido desde la DB
        public static Lista GetDetails(int idPedido)
        {
            Lista detalles = new Lista();
            string sql = "SELECT * FROM Detalle_pedido WHERE idPedido = @idpd";

            try
            {
                conexion.Conectar();
                dataAdapter = new SqlDataAdapter(sql, conexion.Conn);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@idpd", idPedido);
                dataReader = dataAdapter.SelectCommand.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        DetallePedido detalle = new DetallePedido
                        {
                            IdProducto = Convert.ToInt32(dataReader["idProducto"].ToString()),
                            Cantidad = Convert.ToInt32(dataReader["cantidadProducto"].ToString()),
                            PrecioTotalDetalle = float.Parse(dataReader["precioDetalle"].ToString())
                        };
                        detalles.Add(detalle);
                        detalle = null;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al extraer detalles de los productos: " + err.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dataReader.Close();
                conexion.Cerrar();
            }

            return detalles;
        }
    }
}
