using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityClase;

namespace DAO
{
    
   public interface UsuarioIDao
    {
       int insertar(string usser,int id_jer,string pass,string est);
       int eliminar(int id);

       int bloquear(string us, string estado);

       int buscarUsuario(string us, string pas);

       List<Cl_usuarios> ListarTodo();

       List<Cl_usuarios> ListarCodigo(int id);

    }
}
