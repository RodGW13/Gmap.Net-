using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityClase
{
    public class Cl_usuarios
    {
        private String usuarios;

        public String Usuarios
        {
            get { return usuarios; }
            set { usuarios = value; }
        }
      
        private int id_jerarquia;

        public int Jerarquia
        {
            get { return id_jerarquia; }
            set { id_jerarquia = 2; }///se crea un usuario con su nivel respectivo solo existira una cuenta de administrador
        }

        private int rut;

        public int Rut
        {
            get { return rut; }
            set { rut = value; }
        }


        private String contrasena;

        public String Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }

        private String estado;

        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Cl_usuarios() { }

        public Cl_usuarios(String usuarios, int id_jerarquia, int rut, String contrasena, String estado)
        {
            this.usuarios = usuarios;
            this.id_jerarquia = id_jerarquia;
            this.rut = rut;
            this.contrasena = contrasena;
            this.estado = estado;
        }
    }
}
