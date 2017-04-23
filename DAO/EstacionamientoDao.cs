using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public interface EstacionamientoDao
    {
          int grabar(string direccion,string comuna,string latitud,string longitud,int precio,string arrendador,int tipo_cliente,
                      string disponibilidad,DateTime horario_i,DateTime horario_t);

          int eliminar(int id);

          int modificar(int id, string direccion, string comuna, string latitud, string longitud, int precio, string arrendador, int tipo_cliente, string disponibilidad,
                        DateTime horario_i, DateTime horario_t);
    }
}
