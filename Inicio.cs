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
    public partial class Inicio : Form
    {
        public Inicio(string userType)
        {
            InitializeComponent();
            if (userType == "Administrador")
            {
                btnperfil.Location = new Point(0, 327);
                pnladmin.Visible = true;
                pnladmin.Enabled = true;
                pbxperfil.Location = new Point(12, 334);
            }
        }


        //-------- Eventos de los botones de la barra horizontal --------
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnWState_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                btnWState.BackgroundImage = Properties.Resources.Round_Resturar;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                btnWState.BackgroundImage = Properties.Resources.Round_Max;
            }
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //---------------------------------------------------------------

        #region Eventos de la barra vertical

        private void btnmenu_Click(object sender, EventArgs e)
        {
            OpenForm<MenuForm>();
        }

        private void btnpedidos_Click(object sender, EventArgs e)
        {
            OpenForm<PedidosForm>();
        }

        private void btnperfil_Click(object sender, EventArgs e)
        {
            OpenForm<PerfilForm>();
        }

        private void btnaddproduct_Click(object sender, EventArgs e)
        {
            OpenForm<AddProductoForm>();
        }

        private void btnadmproduct_Click(object sender, EventArgs e)
        {
            OpenForm<AdmProductoForm>();
        }

        private void btnadmuser_Click(object sender, EventArgs e)
        {
            OpenForm<RegEmpForm>();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region métodos del Form Inicio

        private void OpenForm <MiForm>() where MiForm : Form, new(){
            Form form;
            form = pnlcontent.Controls.OfType<MiForm>().FirstOrDefault();

            if (form == null)
            {
                form = new MiForm();
                form.TopLevel = false;
                pnlcontent.Controls.Add(form);
                pnlcontent.Tag = form;
                form.Show();
                form.BringToFront();
            }
            else
            {
                form.BringToFront();
            }
        }


        #endregion

    }
}
