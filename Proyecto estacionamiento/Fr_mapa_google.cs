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
    public partial class Fr_mapa_google : Form
    {
        public Fr_mapa_google()
        {
            InitializeComponent();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {

            string direccion = Txt_Direccion.Text;
            string ciudad = Txt_Ciudad.Text;

            try
            {
                StringBuilder sb = new StringBuilder();//consulta 
               //sb.Append("https://maps.google.cl/maps?q=");//el navegador esta obsoleto google maps no responde
                sb.Append("http://maps.google.com/maps?q=");
                if (direccion != string.Empty)
                {
                    sb.Append(direccion + "," + ",");
                }

                if (ciudad != string.Empty)
                {
                    sb.Append(ciudad + "," + ",");
                }


                
                webBrowser1.Navigate(sb.ToString());
                toolStripTxt_url.Text = webBrowser1.Url.ToString();

               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }

           
           
        }

        private void btn_coordenadas_Click(object sender, EventArgs e)
        {



        }

        public void version_navegador()
        {

            string x = webBrowser1.Version.ToString();
            MessageBox.Show("Version internet explorer", x); ;

        }
    }
}
