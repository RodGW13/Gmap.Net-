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
    public partial class Fr_Lista_Estacionamiento : Form
    {
        public Fr_Lista_Estacionamiento()
        {
            InitializeComponent();
        }

        private void volverAtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            Fr_Menu_administracion fr = new Fr_Menu_administracion();
            fr.Show();

        }

        private void Fr_Lista_Estacionamiento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetListado_es.V_LISTA_ESTACIONAMIENTO' Puede moverla o quitarla según sea necesario.
            this.v_LISTA_ESTACIONAMIENTOTableAdapter.Fill(this.dataSetListado_es.V_LISTA_ESTACIONAMIENTO);

        }

        private void btn_actualizar_li_Click(object sender, EventArgs e)
        {
            this.v_LISTA_ESTACIONAMIENTOTableAdapter.Fill(this.dataSetListado_es.V_LISTA_ESTACIONAMIENTO);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ListaEstaDaoImpl le = new ListaEstaDaoImpl();
                le.eliminar(txt_Id_listado.Text);
                MessageBox.Show("Listado Eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                throw new Exception("No se puede eliminar", ex);
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                ListaEstaDaoImpl le = new ListaEstaDaoImpl();

                le.modificar(comboEstado.SelectedItem.ToString());
                MessageBox.Show("Campo modificado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo modificar ", ex);
            }
        }

        private void btn_Grabar_Click(object sender, EventArgs e)
        {
            try
            {
               // if (txt_Id_listado.Text != null && txt_id_es != null)
               // {
                    ListaEstaDaoImpl le = new ListaEstaDaoImpl();
                    le.grabar(txt_Id_listado.Text, Int32.Parse(txt_id_es.Text), comboEstado.SelectedItem.ToString());
                    MessageBox.Show("Listado ingresado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo grabar ", ex);
            }

        }
    }
}
