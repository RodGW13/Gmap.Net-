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
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace Proyecto_estacionamiento
{
    public partial class Fr_Arriendo : Form
    {
        public Fr_Arriendo()
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

            dateTime_Ini.MinDate = DateTime.Now; // restringimos el ingreso de la fecha con el sistema 
            dateTime_Ter.MinDate = DateTime.Now; // restringimos el ingreso de la fecha con el sistema 
            


            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            GMapOverlay markersOverlay = new GMapOverlay();

            OracleDataReader myReader;
            //String Query = " SELECT direccion,latitud,longitud,precio,horario_inicio,horario_termino  FROM estacionamiento";
           // String Query = "select * from estacionamiento,lista_estacionamiento where  estacionamiento.id_estacionamiento=lista_estacionamiento.id_estacionamiento and lista_estacionamiento.estado='Libre'";
           String Query= "select * from estacionamiento,lista_estacionamiento where  estacionamiento.id_estacionamiento=lista_estacionamiento.id_estacionamiento and lista_estacionamiento.estado!='Pendiente' and lista_estacionamiento.estado!='Arrendado'";
            
            string constr = "DATA SOURCE=XE;USER ID=DESARROLLO; Password=123456";
            OracleConnection conDataBase = new OracleConnection(constr);
            conDataBase.Open();
            OracleCommand cmdDatabase = new OracleCommand(Query, conDataBase);
            myReader = cmdDatabase.ExecuteReader();
            gMapControl1.HoldInvalidation = true;



            while (myReader.Read())
            {
                string Direccion = myReader["direccion"].ToString();
                string Latitude = myReader["latitud"].ToString();
                string Longitude = myReader["longitud"].ToString();
                string Precio = myReader["precio"].ToString();
                string Hor_i = myReader["horario_inicio"].ToString();
                string Hor_f = myReader["horario_termino"].ToString();
                string estado = myReader["estado"].ToString();
               
                gMapControl1.Position = new PointLatLng(float.Parse(Latitude), float.Parse(Longitude));
                GMarkerGoogle marker = new GMarkerGoogle(gMapControl1.Position, GMarkerGoogleType.green_dot);
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                markersOverlay.Markers.Add(marker);
                gMapControl1.Overlays.Add(markersOverlay);
                marker.ToolTip = new GMapRoundedToolTip(marker);

               // marker.ToolTipText = Direccion + " \n" + Latitude + " \n" + Longitude + " \n" +"Precio :"+ Precio + " \n" +"Horario de inicio"+ Hor_i + " \n" +"Horario final"+ Hor_f;
                marker.ToolTipText = Direccion + " \n"  + "Precio :" + Precio + " \n" + "Horario de inicio: " + Hor_i + " \n" + "Horario final: " + Hor_f +" \n"+ "Estado: "+estado  ;

                


            }


            OracleDataReader myReader2;
            String Query2 = "select * from estacionamiento,lista_estacionamiento where  estacionamiento.id_estacionamiento=lista_estacionamiento.id_estacionamiento and lista_estacionamiento.estado='Pendiente'";
            string constr2 = "DATA SOURCE=XE;USER ID=DESARROLLO; Password=123456";
            OracleConnection conDataBase2 = new OracleConnection(constr2);
            conDataBase2.Open();
            OracleCommand cmdDatabase2 = new OracleCommand(Query2, conDataBase2);
            myReader2 = cmdDatabase2.ExecuteReader();
            gMapControl1.HoldInvalidation = true;



            while (myReader2.Read())
            {
                string Direccion = myReader2["direccion"].ToString();
                string Latitude = myReader2["latitud"].ToString();
                string Longitude = myReader2["longitud"].ToString();
                string Precio = myReader2["precio"].ToString();
                string Hor_i = myReader2["horario_inicio"].ToString();
                string Hor_f = myReader2["horario_termino"].ToString();
                string estado = myReader2["estado"].ToString();

                gMapControl1.Position = new PointLatLng(float.Parse(Latitude), float.Parse(Longitude));
                GMarkerGoogle marker = new GMarkerGoogle(gMapControl1.Position, GMarkerGoogleType.orange_dot);
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                markersOverlay.Markers.Add(marker);
                gMapControl1.Overlays.Add(markersOverlay);
                marker.ToolTip = new GMapRoundedToolTip(marker);

                // marker.ToolTipText = Direccion + " \n" + Latitude + " \n" + Longitude + " \n" +"Precio :"+ Precio + " \n" +"Horario de inicio"+ Hor_i + " \n" +"Horario final"+ Hor_f;
                marker.ToolTipText = Direccion + " \n" + "Precio :" + Precio + " \n" + "Horario de inicio: " + Hor_i + " \n" + "Horario final: " + Hor_f + " \n" + "Estado: " + estado;




            }


            OracleDataReader myReader3;
            String Query3 = "select * from estacionamiento,lista_estacionamiento where  estacionamiento.id_estacionamiento=lista_estacionamiento.id_estacionamiento and lista_estacionamiento.estado='Arrendado'";
            string constr3 = "DATA SOURCE=XE;USER ID=DESARROLLO; Password=123456";
            OracleConnection conDataBase3 = new OracleConnection(constr3);
            conDataBase3.Open();
            OracleCommand cmdDatabase3 = new OracleCommand(Query3, conDataBase3);
            myReader3 = cmdDatabase3.ExecuteReader();
            gMapControl1.HoldInvalidation = true;



            while (myReader3.Read())
            {
                string Direccion = myReader3["direccion"].ToString();
                string Latitude = myReader3["latitud"].ToString();
                string Longitude = myReader3["longitud"].ToString();
                string Precio = myReader3["precio"].ToString();
                string Hor_i = myReader3["horario_inicio"].ToString();
                string Hor_f = myReader3["horario_termino"].ToString();
                string estado = myReader3["estado"].ToString();

                gMapControl1.Position = new PointLatLng(float.Parse(Latitude), float.Parse(Longitude));
                GMarkerGoogle marker = new GMarkerGoogle(gMapControl1.Position, GMarkerGoogleType.red_dot);
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                markersOverlay.Markers.Add(marker);
                gMapControl1.Overlays.Add(markersOverlay);
                marker.ToolTip = new GMapRoundedToolTip(marker);

                // marker.ToolTipText = Direccion + " \n" + Latitude + " \n" + Longitude + " \n" +"Precio :"+ Precio + " \n" +"Horario de inicio"+ Hor_i + " \n" +"Horario final"+ Hor_f;
                marker.ToolTipText = Direccion + " \n" + "Precio :" + Precio + " \n" + "Horario de inicio: " + Hor_i + " \n" + "Horario final: " + Hor_f + " \n" + "Estado: " + estado;




            }


            
        }

        private void Fr_Arriendo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetV_Arriendo.V_ARRIENDO' Puede moverla o quitarla según sea necesario.
            this.v_ARRIENDOTableAdapter.Fill(this.dataSetV_Arriendo.V_ARRIENDO);

        }

       

        private void btn_Arriendo_Click(object sender, EventArgs e)
        {
            this.v_ARRIENDOTableAdapter.Fill(this.dataSetV_Arriendo.V_ARRIENDO);
        }

       
        private void volverAtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fr_Menu_administracion menu = new Fr_Menu_administracion();
            this.Hide();
            menu.Show();
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            try
            {
                ArriendoDaoImp arr = new ArriendoDaoImp();
                string x = "si";
                arr.grabarA(dateTime_Ini.Value, dateTime_Ter.Value, x, Int32.Parse(txt_id_tipo_c.Text));
                MessageBox.Show("Se ha guardado el Arriendo ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex) {
                throw new Exception("No se ha guardado el arriendo");
            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            gMapControl1.Zoom = trackBar1.Value;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            ArriendoDaoImp arr = new ArriendoDaoImp();
            String arren="si";
            arr.modificar(Int32.Parse(txt_id.Text), dateTime_Ini.Value, dateTime_Ter.Value, arren, Int32.Parse(txt_id_tipo_c.Text));
        }

        private void btn_zoom_i_Click(object sender, EventArgs e)
        {
            gMapControl1.Zoom += 1;
        }

        private void btn_zoom_ou_Click(object sender, EventArgs e)
        {
            gMapControl1.Zoom -= 1;
        }
    }
}
