using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityClase;

namespace DAO
{
    public interface VehiculoDao
    {
        int grabar(string patente,string marca,string color,string descripcion);
        int eliminar(string patente);

        int modificar(string patente, string marca, string color, string descripcion);
        List<Cl_vehiculo> listarTodo();
        List<Cl_vehiculo> listarporId(int patente);



    }
}
