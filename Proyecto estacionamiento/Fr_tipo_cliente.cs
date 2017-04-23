using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DAO;


namespace Proyecto_estacionamiento
{
    public partial class Fr_tipo_cliente : Form
    {
        public Fr_tipo_cliente()
        {
            InitializeComponent();
        }

        private void btn_grabarT_Click(object sender, EventArgs e)
        {
            
            try
            {
                //if (comboArrendador.SelectedIndex.Equals(-1)){
                 //  if(comboArrendatario.SelectedIndex.Equals(-1)){
                      // if (txt_rut_t.Text !=null) {
                           Tipo_ClienteDaoImpl t = new Tipo_ClienteDaoImpl();
                           t.grabar(comboArrendador.SelectedItem.ToString(), comboArrendatario.SelectedItem.ToString(), Int32.Parse(txt_rut_t.Text));
                           MessageBox.Show("Se ha grabado el tipo de usuario","Mensaje" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                     //  }
                   //}
                //}
                 }
            catch (Exception ex) {
                throw new Exception("No se pudo grabar el tipo de cliente", ex);
            }
        }

        private void btn_EliminarT_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_Rut_e.Text != null)
                {
                    Tipo_ClienteDaoImpl t = new Tipo_ClienteDaoImpl();
                    t.eliminar(Int32.Parse(txt_Rut_e.Text));
                    MessageBox.Show("Se ha eliminador el tipo de usuario","Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex) {
                throw new Exception("No se pudo elimianr el tipo de usuario", ex);
            }
        }

        private void btn_ModificarT_Click(object sender, EventArgs e)
        {

        }

        private void Fr_tipo_cliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetV_TipoCliente.V_TIPO_CLIENTE' Puede moverla o quitarla según sea necesario.
            this.v_TIPO_CLIENTETableAdapter.Fill(this.dataSetV_TipoCliente.V_TIPO_CLIENTE);

        }

        private void btn_listarTipo_Click(object sender, EventArgs e)
        {
            this.v_TIPO_CLIENTETableAdapter.Fill(this.dataSetV_TipoCliente.V_TIPO_CLIENTE);
        }
    }
}
