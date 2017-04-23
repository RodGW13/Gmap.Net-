using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityClase;

namespace DAO
{
    public interface ClienteDao
    {
        int grabarCliente(int rut,string nombre,string apellido_p,string apellido_m,int telefono,int celular,string direccion,int id_usuario,string patente,int id_tarjeta,string comuna,int edad);

        int eliminar(int rut);

        int modificar(int rut, string nombre, string apellido_p, string apellido_m, int telefono, int celular, string direccion, string patente, int id_tarjeta, string comuna, int edad);

   

    }
}
