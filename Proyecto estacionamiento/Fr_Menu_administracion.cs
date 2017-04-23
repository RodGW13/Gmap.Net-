using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_estacionamiento
{
    public partial class Fr_Menu_administracion : Form
    {
        public Fr_Menu_administracion()
        {
            InitializeComponent();
        }
       

        private void administraciónUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fr_administracion_usuario fr = new Fr_administracion_usuario();
            fr.Show();
            Fr_Menu_administracion m = new Fr_Menu_administracion();
            m.Hide();
        }

        private void administraciónEstacionamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fr_estacionamiento fr = new Fr_estacionamiento();
            fr.Show();
        }

        private void administraciónArriendoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fr_Arriendo arriendo = new Fr_Arriendo();
            this.Hide();
            arriendo.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fr_Reportes repor = new Fr_Reportes();
            this.Hide();
            repor.Show();
        }
    }
}
