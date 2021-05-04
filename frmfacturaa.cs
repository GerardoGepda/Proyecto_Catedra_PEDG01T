using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace Proyecto_Catedra_PEDG01T
{
    public partial class frmfacturaa : Form
    {
        public string servidor, usuario, clave, db;
        public string cadena;
        public SqlConnection conn;


        public frmfacturaa()
        {
            InitializeComponent();
        }

        private void frmfacturaa_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void ReporteProductos_Load(object sender, EventArgs e)
        {
            db = "Northwind";
            servidor = "";
            cadena = "server" + servidor + ";database=" + db;

            conn = new SqlConnection(cadena);


            try
            {
                conn.Open();
                string sql = "SELECT ProductID,ProductName,QuantityPerUnit FROM Products";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;

                SqlDataReader rdr = cmd.ExecuteReader();

                List<Factura> lrp = new List<Factura>();

                while (rdr.Read())
                {
                    Factura rp = new Factura();

                    rp.Cantidad = rdr[1].ToString();
                    rp.Fecha = rdr[1].ToString();
                    rp.Monto = rdr[2].ToString();
                    rp.NFactura = rdr[3].ToString();
                    rp.NMesa = rdr[4].ToString();

                    lrp.Add(rp);
                    rp = null;
                }

                rdr.Close();

                ReportDataSource rds = new ReportDataSource("Factura", lrp);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reporte.Report1.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.RefreshReport();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        }
    }
