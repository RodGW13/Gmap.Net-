using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityClase
{
    public class Cl_estacionamiento
    {
        string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        string comuna;

        public string Comuna
        {
            get { return comuna; }
            set { comuna = value; }
        }
        string latitud;

        public string Latitud
        {
            get { return latitud; }
            set { latitud = value; }
        }
        string longitud;

        public string Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }
        string precio;

        public string Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        int arrendador;

        public int Arrendador
        {
            get { return arrendador; }
            set { arrendador = value; }
        }
        int tipo_cliente;

        public int Tipo_cliente
        {
            get { return tipo_cliente; }
            set { tipo_cliente = value; }
        }
        string disponibilidad;

        public string Disponibilidad
        {
            get { return disponibilidad; }
            set { disponibilidad = value; }
        }
        DateTime horario_inicio;

        public DateTime Horario_inicio
        {
            get { return horario_inicio; }
            set { horario_inicio = value; }
        }
        DateTime horario_termino;

        public DateTime Horario_termino
        {
            get { return horario_termino; }
            set { horario_termino = value; }
        }

        public Cl_estacionamiento() { }


    }
}
