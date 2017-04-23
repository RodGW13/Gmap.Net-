using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using DAO;



namespace Proyecto_estacionamiento
{
    public partial class Fr_Login : Form
    {
        public Fr_Login()
        {
            InitializeComponent();
        }
       
        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "admin" & TxtContrasena.Text =="rod123456" )
            {
                //Conexion.
                UsuarioDaoImpl uss = new UsuarioDaoImpl();
                //int x=uss.buscarUsuario(TxtUsuario.Text, TxtContrasena.Text);
                

                    MessageBox.Show("Bienvenido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    this.Hide();
                    Fr_Menu_administracion fr = new Fr_Menu_administracion();

                    fr.Show();
                
             
                
            }
            else
            {

                MessageBox.Show("Error debe ingresar correctamente su usuario y contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
                TxtUsuario.Focus();
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiar() {

            TxtUsuario.Text = "";
            TxtContrasena.Text = "";
        }
    }
}

   