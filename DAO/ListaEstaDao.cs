using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public interface ListaEstaDao
    {
         int grabar(string id,int id_esta,string estado);

         int eliminar(string id);

         int modificar(string estado);

    }
}
