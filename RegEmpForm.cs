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
   


        private void btnregistrarse_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            try
            {
                usuario.Nombre = txtnombre.Text;
                usuario.Email = txtemail.Text;
                usuario.Uusuario = txtusuario.Text;
                usuario.Telefono = int.Parse(txttelefono.Text);
                if (usuario.VerficarContra == txtcontraseña.Text) 
                {
                    MessageBox.Show("Contrasena creada con exito");
                }
                else
                {
                    MessageBox.Show("Error", "Intentelo de nuevo");
                }
                
   
                if (usuario.claveEsfuerte(txtcontraseña.Text))
                    usuario.Contrasena = txtcontraseña.Text;
                else
                    throw new Exception("La clave no es fuerte");
                usuario.generarCod();

                usuario.guardarusuario();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
