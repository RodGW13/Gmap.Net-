using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityClase
{
    public class Cl_cliente
    {
        string rut;

        public string Rut
        {
            get { return rut; }
            set { rut = value; }
        }
        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        string apellido_paterno;

        public string Apellido_paterno
        {
            get { return apellido_paterno; }
            set { apellido_paterno = value; }
        }
        string apellido_materno;

        public string Apellido_materno
        {
            get { return apellido_materno; }
            set { apellido_materno = value; }
        }
        int telefono;

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        int celular;

        public int Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        int tarjeta;

        public int Tarjeta
        {
            get { return tarjeta; }
            set { tarjeta = value; }
        }
        string comuna;

        public string Comuna
        {
            get { return comuna; }
            set { comuna = value; }
        }

        public Cl_cliente() { }

    }
}
