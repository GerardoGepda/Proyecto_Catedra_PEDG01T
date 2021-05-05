using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Proyecto_Catedra_PEDG01T
{
    public partial class PerfilForm : Form
    {
        public PerfilForm()
        {
            InitializeComponent();
        }
        //Método que nos ayuda a controlar campos de solo letras
        private void Validarletras(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras en el campo de Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validarletras(e);
        }
        //Función para validar el formato del correo
        public static bool ValidarcorreoE(string correo)
        {
            string ex = "^[_a-z0-9-]+(.[_a-z0-9-]+)*@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$";
            if (Regex.IsMatch(correo, ex))
            {
                if (Regex.Replace(correo, ex, string.Empty).Length == 0)
                {
                    return false;

                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }
        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (ValidarcorreoE(txtemail.Text) == false)
            {
            }
            else
            {

                MessageBox.Show("El formato del correo electrónico no es correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtemail.Focus();
            }
        }
    }
}
