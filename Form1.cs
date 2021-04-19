using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Catedra_PEDG01T
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //Eventos del formulario
        private void btntypeuser_Click(object sender, EventArgs e)
        {
            cbxtypeuser.DroppedDown = !cbxtypeuser.DroppedDown;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //--- Métodos del formulario ---//
        public bool Validar()
        {
            bool validado = true;
            if (string.IsNullOrEmpty(txtuser.Text) && string.IsNullOrEmpty(txtpassword.Text))
            {
                validado = false;
                MessageBox.Show("No debe dejar campos vacíos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!(cbxtypeuser.SelectedIndex > -1))
            {
                validado = false;
                MessageBox.Show("Debe seleccionar el tipo de usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return validado;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Usuario user = new Usuario();
                user.GetUserFromDB(txtuser.Text, txtpassword.Text, cbxtypeuser.SelectedItem.ToString());
                Inicio home = new Inicio(user);
                this.Hide();
                home.ShowDialog();
                this.Show();
            }
        }

        
    }
}
