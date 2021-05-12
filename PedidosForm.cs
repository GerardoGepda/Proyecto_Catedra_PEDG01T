﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_Catedra_PEDG01T
{
    public partial class PedidosForm : Form
    {
        string idObtenido;

        //delegado para comunicar con el form Inicio para abrir la factura
        public delegate void showFactura(Pedido pedido);
        public event showFactura VerFactura;

        public PedidosForm()
        {
            InitializeComponent();
            llenarDataGrid();
        }
       
        List<int> listaDatos1 = new List<int>();
        List<int> listaDatos2 = new List<int>();
        public List<Pedido> listaPedidos;
        Cola objCola;
        Pedido objPedido;
        private void llenarDataGrid()
        {
            listaPedidos = new List<Pedido>();
            objPedido = new Pedido();
            objCola = new Cola();
            listaDatos1 = objPedido.MostrarPedidio();
            for (int i = 0; i < listaDatos1.Count; i++)
            {
                objCola.Encolar(listaDatos1[i]);

            }

            listaDatos2 = objCola.Mostrar();
            dgvpedidos.DataSource = null;
            for (int i = 0; i < listaDatos2.Count; i++)
            {
                listaPedidos = objPedido.buscarPedidosPorId(listaDatos2[i]);
            }

            dgvpedidos.DataSource = listaPedidos;
            dgvpedidos.Columns[0].HeaderText="Número de orden";
            dgvpedidos.Columns[1].HeaderText = "Fecha de pedido";
            dgvpedidos.Columns[2].Visible = false;
            dgvpedidos.Columns[3].Visible = false;
            dgvpedidos.Columns[4].Visible = false;
            dgvpedidos.Columns[5].Visible = false;
            dgvpedidos.Columns[6].HeaderText = "Nombre de producto";
            dgvpedidos.Columns[7].HeaderText = "Cantidad";
        }
        private void PedidosForm_Load(object sender, EventArgs e)
        {           
            
        }

        private void btnentregar_Click(object sender, EventArgs e)
        {  //Aqui nos quemd
            int i = dgvpedidos.SelectedCells[0].RowIndex;
            objPedido.UpdateEstado(int.Parse(idObtenido));
            //dgvpedidos.Rows.RemoveAt(dgvpedidos.SelectedRows[i].Index);
            llenarDataGrid();

        }

        private void dgvpedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            idObtenido = dgvpedidos.Rows[e.RowIndex].Cells[0].Value.ToString();
            lblIdPedidoObtenido.Text = idObtenido;
            lblIndexdgv.Text = dgvpedidos.Rows[e.RowIndex].Cells[0].RowIndex.ToString();

        }

        private void btnfactura_Click(object sender, EventArgs e)
        {
            facutar();
        }

        public void facutar()
        {
            Console.WriteLine(listaPedidos[0].NombreProducto1);
            Pedido ped = new Pedido();
            ped.NombreProducto1 = "dsadfdsf";
            ped.IdUsuario = "1";
            ped.IdPedido = 1;
            ped.EstadoPedido = 0;
            ped.FechaPedido = "2021-04-12";
            VerFactura(listaPedidos[0]);
        }
    }
}
