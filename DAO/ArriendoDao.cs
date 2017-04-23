using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public interface ArriendoDao
    {
        int grabarA(DateTime inicio,DateTime termino,String arrendatario,int tipo_cliente);

        int modificar(int id,DateTime inicio,DateTime termino,String arrendatario,int tipo_cliente);
    }
}
