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
            dtpFechaNacimiento.CustomFormat = "yyyy-MM-dd";
        }

        private void btntypeuser_Click(object sender, EventArgs e)
        {
            cbxtypeuser.DroppedDown = !cbxtypeuser.DroppedDown;
        }

        private void btnregistrarse_Click(object sender, EventArgs e)
        {
            if(txtnombre.Text != "")
            {
                if(txtApellido.Text != "")
                {
                    if (txtusuario.Text != "")
                    {
                        if (txtcontrasena.Text != "")
                        {
                            if (txtverificar.Text != "")
                            {
                                if (txtcontrasena.Text == txtverificar.Text)
                                {
                                    if (txtemail.Text != "")
                                    {
                                        if (txttelefono.Text != "")
                                        {
                                            if (cbxtypeuser.SelectedIndex > -1)
                                            {
                                                Usuario objUsuario = new Usuario();
                                                objUsuario.Nombre = txtnombre.Text;
                                                objUsuario.Apellido = txtApellido.Text;
                                                objUsuario.User = txtusuario.Text;
                                                objUsuario.Contrasena = txtcontrasena.Text;
                                                objUsuario.Email = txtemail.Text;
                                                objUsuario.Telefono = txttelefono.Text;
                                                objUsuario.IdtypeUser = obtenerId();
                                                objUsuario.FechaNacimiento = dtpFechaNacimiento.Value.ToString();
                                                objUsuario.SaveUserInDB();
                                                MessageBox.Show("Se supone que ya guardo");
                                            }
                                            else
                                            {
                                                MessageBox.Show("Debe de seleccionar tipo de usuario", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Debe de ingresar teléfono", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Debe de ingresar correo", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Las contraseñas no coinciden", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe de ingresar verificaciónd de contraseña", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe de ingresar contraseña", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe de ingresar usuario", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Debe de ingresar apellido", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                   
            }
            else
            {
                MessageBox.Show("Debe de ingresar nombre", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public string obtenerId()
        {
            if(cbxtypeuser.SelectedItem.ToString() == "Administrador")
            {
                return "1";
            }
            
            if(cbxtypeuser.SelectedItem.ToString() == "Empleado")
            {
                return "2";
            }

            return "0";
        }
    }
}
