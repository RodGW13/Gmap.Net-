using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAO;

using System.Security.Cryptography;



namespace Proyecto_estacionamiento
{
    public partial class Fr_administracion_usuario : Form
    {
        public Fr_administracion_usuario()
        {
            InitializeComponent();
        }

        private void bnt_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
              

                if (txt_Id.Text != null)
                {
                    DAO.UsuarioDaoImpl us = new UsuarioDaoImpl();
                    int x = us.eliminar(Int32.Parse(txt_Id.Text));
                    MessageBox.Show("Se ha eliminado el usuario","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
              
              

            }
            catch (Exception ex) {
                throw new Exception("Error al eliminar" + ex);
            }

           
        }

        


        private void btn_guardar_Click(object sender, EventArgs e)
        {

            try
            {
                ClienteDaoImpl cu = new ClienteDaoImpl();
                cu.grabarCliente(Int32.Parse(txt_Rut.Text), txt_nombre_1.Text, txt_ape_p.Text, txt_ape_m.Text,
                          Int32.Parse(txt_telefono.Text), Int32.Parse(txt_celular.Text), txt_direccion.Text,
                          Int32.Parse(txt_Id_usuario.Text), txt_patente.Text, Int32.Parse(txt_tarjeta.Text), combo_comuna.SelectedItem.ToString(),
                          Int32.Parse(txt_Edad.Text));
                MessageBox.Show("Cliente Guardado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            catch (Exception ex) {

                throw new Exception("Error no se guardo el cliente " + ex);
            }
            
        
        }

        private void formularioVehículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fr_vehiculo fv = new Fr_vehiculo();
            fv.Show();
        }

        private void btn_grabar_us_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_usser.Text != null)
                {
                    if (txt_contrasena.Text == txt_Re_Pa.Text)
                    {

                        if (ch_Activo.Checked !=false) {
                            int id = 2;
                            DAO.UsuarioDaoImpl us = new UsuarioDaoImpl();
                          
                           
                            us.insertar(txt_usser.Text, id, txt_Re_Pa.Text, ch_Activo.Checked.ToString());
                            MessageBox.Show("Usuario Grabado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        }
                    }



                }

               
            }
            catch (Exception ex) {
                throw new Exception("Error no se pudo guardar el usuario", ex);
            }
        }

        private void Fr_administracion_usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet4.V_CLIENTE' Puede moverla o quitarla según sea necesario.
            this.v_CLIENTETableAdapter.Fill(this.dataSet4.V_CLIENTE);
            // TODO: esta línea de código carga datos en la tabla 'dataSet2.CLIENTE' Puede moverla o quitarla según sea necesario.
            this.cLIENTETableAdapter.Fill(this.dataSet2.CLIENTE);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.USUARIO' Puede moverla o quitarla según sea necesario.
            this.uSUARIOTableAdapter.Fill(this.dataSet1.USUARIO);

        }

        private void btn_eliminar_cliente_Click(object sender, EventArgs e)
        {
            try {
                ClienteDaoImpl cd = new ClienteDaoImpl();
                cd.eliminar(Int32.Parse(txt_eliminar_rut.Text));
                MessageBox.Show("El cliente ha sido eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }catch(Exception ex){
                throw new Exception("No se puede eliminar" + ex);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try {
                ClienteDaoImpl cd = new ClienteDaoImpl();
                cd.modificar(Int32.Parse(txt_Rut.Text), txt_nombre_1.Text, txt_ape_p.Text, txt_ape_m.Text,Int32.Parse(txt_telefono.Text),Int32.Parse(txt_celular.Text), txt_direccion.Text, txt_patente.Text,Int32.Parse(txt_tarjeta.Text), combo_comuna.SelectedItem.ToString(),Int32.Parse(txt_Edad.Text));
                MessageBox.Show("Usuario Modificado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);          

            }
            catch (Exception ex)
            {

                throw new Exception("No se pudo actualizar el cliente ", ex);
            }
        }

        private void btn_bloquear_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_usser_blo.Text != null) {
                    
                    if(ch_Inactivo.Checked!=false){
                        UsuarioDaoImpl us = new UsuarioDaoImpl();
                        us.bloquear(txt_usser_blo.Text,ch_Inactivo.Checked.ToString());
                        MessageBox.Show("Usuario Bloqueado", "Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                MessageBox.Show("No se ha bloqueado el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
            catch (Exception ex) {
                throw new Exception("Error al bloquear ", ex);
            }
        }

        private void btn_Listado_usser_Click(object sender, EventArgs e)
        {
            //DAO.UsuarioDaoImpl us = new UsuarioDaoImpl();

            //string sql = "select * from usuarios";
            this.uSUARIOTableAdapter.Fill(this.dataSet1.USUARIO);//al seleccionar se nos actualiza el data set de la grilla

        }

        private void btn_actualizar_cliente_Click(object sender, EventArgs e)
        {
            this.cLIENTETableAdapter.Fill(this.dataSet2.CLIENTE);
            this.v_CLIENTETableAdapter.Fill(this.dataSet4.V_CLIENTE);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Fr_tipo_cliente tipo = new Fr_tipo_cliente();
            tipo.Show();
        }

       
    }
}
