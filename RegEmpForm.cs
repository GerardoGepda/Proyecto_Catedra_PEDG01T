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

namespace Proyecto_Catedra_PEDG01T
{
    public partial class RegEmpForm : Form
    {
        public RegEmpForm()
        {
            InitializeComponent();
        }

        private string nombre;
        private string apellido;
        private string codigo;
        private string direccion;
        private int telefono;
        private string correo;
        private string tipo;
        private string clave;
        public SqlDataAdapter dataAdapter;
        public SqlDataReader dataReader;
        public SqlCommand sqlCommand;


        private void btnregistrarse_Click(object sender, EventArgs e)
        {
            string sqlinsert = "INSERT INTO Usuarios(idusuario, nombre, apellido,fechaNacimiento, email, Telefono,idTipoUsuario)" +
                        "VALUES (@codigo, @nombre, @apellido, @correo, @dir, @tel, @clave, @tipo)";

           
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
