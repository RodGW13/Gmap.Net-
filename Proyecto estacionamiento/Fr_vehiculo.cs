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
    public partial class Fr_vehiculo : Form
    {
        public Fr_vehiculo()
        {
            InitializeComponent();
        }

        private void btn_Grabar_Click(object sender, EventArgs e)
        {
            VehiculoDaoImpl vd = new VehiculoDaoImpl();

            try {
                if(txt_Patente.Text!=null){
                    if (txt_Marca.Text != null)
                    {
                        if (txt_Color.Text != null)
                        {

                            if (txt_Descripcion.Text != null)
                            {
                                int x = vd.grabar(txt_Patente.Text, txt_Marca.Text, txt_Color.Text, txt_Descripcion.Text);
                                MessageBox.Show("Vehículo ingresado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("No se pudo ingresar el Vehículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            
            }
            catch (Exception ex) { throw new Exception("Error no se pudo  guardar "+ex); }
            


        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            VehiculoDaoImpl vd = new VehiculoDaoImpl();
            
            try
            {

                if (txt_Patente_E.Text != null)
                {
                    int x = vd.eliminar(txt_Patente_E.Text);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(""+ex);
            }
            
            

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void limpiar() {
            txt_Patente.Text = "";
            txt_Marca.Text = "";
            txt_Color.Text = "";
            txt_Descripcion.Text = "";
                         
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Patente.Text != null)
                {
                    if (txt_Marca.Text != null)
                    {
                        if (txt_Color.Text != null)
                        {

                            if (txt_Descripcion.Text != null)
                            {
                                VehiculoDaoImpl ve = new VehiculoDaoImpl();
                                ve.modificar(txt_Patente.Text, txt_Marca.Text, txt_Color.Text, txt_Descripcion.Text);
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo modificar el vehículo", ex);
            }
            
           
        }

        private void volverAtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fr_Menu_administracion ad = new Fr_Menu_administracion();
            ad.Show();
            Fr_vehiculo fe = new Fr_vehiculo();
            fe.Hide();

        }

        private void Fr_vehiculo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetVehiculo.V_VEHICULO' Puede moverla o quitarla según sea necesario.
            this.v_VEHICULOTableAdapter.Fill(this.dataSetVehiculo.V_VEHICULO);

        }

        private void btn_listado_v_Click(object sender, EventArgs e)
        {
            this.v_VEHICULOTableAdapter.Fill(this.dataSetVehiculo.V_VEHICULO);
        }
    }
}
