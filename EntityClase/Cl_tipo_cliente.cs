using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityClase
{
   public class Cl_tipo_cliente
    {
        string arrendatario;

        public string Arrendatario
        {
            get { return arrendatario; }
            set { arrendatario = value; }
        }

        string arrendador;

        public string Arrendador
        {
            get { return arrendador; }
            set { arrendador = value; }
        }

        int rut;

        public int Rut
        {
            get { return rut; }
            set { rut = value; }
        }

        public Cl_tipo_cliente() { }
    }
}
