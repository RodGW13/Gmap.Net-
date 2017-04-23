using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using DAO;

namespace Proyecto_estacionamiento
{
    public partial class Fr_estacionamiento : Form
    {
        public Fr_estacionamiento()
        {
            InitializeComponent();
            gMapControl1.DragButton = MouseButtons.Left;
            
            gMapControl1.CanDragMap = true;  //se crea el mapa 
            gMapControl1.MapProvider = GMapProviders.GoogleMap;//cargamos el mapa por defecto
            gMapControl1.Position = new PointLatLng(-33.45, -70.6667);//asignamos una ubicacion de ejemplo
            gMapControl1.MinZoom = 0;
            gMapControl1.MarkersEnabled = true;// activar la opcion de marcadores
            gMapControl1.PolygonsEnabled = true;
            gMapControl1.MaxZoom = 24;
            gMapControl1.MinZoom = 0;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;
           // gMapControl1.ShowTileGridLines = true;//mostrar las coordenadas en el mapa ; se hizo prueba 
                                                   //y genera errores en el mapa

            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(-33.45, -70.6667), 
                                                                      GMarkerGoogleType.red);

            GMapOverlay markers = new GMapOverlay("markers");//creamos el marcador
            marker.ToolTip = new GMapToolTip(marker);
           
            marker.ToolTipText = "marcador de prueba"; //crea un caja de texto sopbre el marcador
            marker.ToolTip.Format.Alignment = StringAlignment.Near;

            //marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            markers.Markers.Add(marker);
            gMapControl1.Overlays.Add(markers);

           

            dateTime_Ini.MinDate = DateTime.Now; // restringimos el ingreso de la fecha con el sistema 
            dateTime_Ter.MinDate = DateTime.Now; // restringimos el ingreso de la fecha con el sistema 
            
              
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                EstacionamientoDaoImpl es = new EstacionamientoDaoImpl();
                string arren ="si";
              es.grabar(txt_Direccion.Text, comboComuna.SelectedItem.ToString(), txt_latitud.Text, txt_longitud.Text, Int32.Parse(txt_precio.Text),arren,Int32.Parse(txt_id_tipo.Text),
                        txt_Dispo.Text,dateTime_Ini.Value,dateTime_Ter.Value);
                        MessageBox.Show("Se ha guardado el Estacionamiento ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         
            }
            catch (Exception ex) {
                throw new Exception("No se pudo guardar el estacionamiento", ex);
            }

        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if (txt_buscar_direccion != null) {

                string xx = txt_buscar_direccion.Text;
                gMapControl1.SetPositionByKeywords(txt_buscar_direccion.Text);
                gMapControl1.Zoom = 16;

                double x = gMapControl1.Position.Lng;
                double y = gMapControl1.Position.Lat;

                string longitude = x.ToString();
                string latitude = y.ToString();
                txt_longitud.Text = longitude;
                txt_latitud.Text = latitude;


                
            }
        }

        private void MouseM(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);

            double X = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;
            double Y = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;

            string longitude = X.ToString();
            string latitude = Y.ToString();
            txt_longitud.Text=longitude;
            txt_latitud.Text = latitude;

          
           

        }

        private void volverAtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fr_estacionamiento es = new Fr_estacionamiento();
            Fr_Menu_administracion fr = new Fr_Menu_administracion();
            fr.Show();
            es.Close();

        }

        private void btn_zoom_i_Click(object sender, EventArgs e)
        {
          
            gMapControl1.Zoom += 1;
          
           
            
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            try {

                EstacionamientoDaoImpl est = new EstacionamientoDaoImpl();
                String arrendador="si";
                est.modificar(Int32.Parse(txt_id_mo.Text), txt_Direccion.Text, comboComuna.SelectedItem.ToString(), txt_latitud.Text, txt_longitud.Text, Int32.Parse(txt_precio.Text), arrendador, 
                               Int32.Parse(txt_id_tipo.Text),txt_Dispo.Text, dateTime_Ini.Value, dateTime_Ter.Value);
            
            }catch(Exception ex){

                throw new Exception("No se pudo modificar" + ex);
            }
        }

        private void Fr_estacionamiento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet3.V_ESTACIONAMIENTO' Puede moverla o quitarla según sea necesario.
            this.v_ESTACIONAMIENTOTableAdapter.Fill(this.dataSet3.V_ESTACIONAMIENTO);

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            gMapControl1.Zoom = trackBar1.Value;
        }

        private void btn_zoom_ou_Click(object sender, EventArgs e)
        {
            gMapControl1.Zoom -= 1;
        }

        private void listadoEstacionamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fr_Lista_Estacionamiento lis = new Fr_Lista_Estacionamiento();
            lis.Show();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

    }
}
