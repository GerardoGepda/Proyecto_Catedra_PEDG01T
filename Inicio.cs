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
        public Inicio()
        {
            InitializeComponent();
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
                btnWState.BackgroundImage = Properties.Resources.Restaurar;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                btnWState.BackgroundImage = Properties.Resources.Max;
            }
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //---------------------------------------------------------------
    }
}
