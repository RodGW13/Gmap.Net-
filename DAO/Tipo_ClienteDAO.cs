using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public interface Tipo_ClienteDAO
    {
        int grabar(string arrendador, string arrendatario,int rut);

         int eliminar(int id);

         int modificar(string arrendador, string arrendatario, int rut);


        

    }
}
