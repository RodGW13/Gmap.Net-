using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using System.Security.Cryptography;

using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using EntityClase;

namespace DAO
{
    public class UsuarioDaoImpl: UsuarioIDao
    {


        public int insertar(string usser ,int id_jer,string pass,string est)
        {
            try {
               Conexion.Cl_Conexion ob=new Conexion.Cl_Conexion();                
                OracleConnection cn=ob.getConexion();
                cn.Open();

                OracleCommand cmd = cn.CreateCommand();
                cmd.CommandType=System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "INSERTAR_USUARIO";

               // cmd.Parameters.Add("SEQ_USUARIO_ID_USUARIO", OracleDbType.Int32);
                cmd.Parameters.Add("P_USUARIO", OracleDbType.NVarchar2).Value=usser;
                cmd.Parameters.Add("P_ID_JERARQUIA", OracleDbType.Int32).Value = id_jer;
                cmd.Parameters.Add("P_PASS", OracleDbType.NVarchar2).Value = (pass);
                
                cmd.Parameters.Add("P_ESTADO", OracleDbType.NVarchar2).Value = est;
                return cmd.ExecuteNonQuery();

                cn.Close();
                cmd.Dispose();
                cn.Dispose();
                cn = null;

            
            }catch(Exception ex){

                return 0;
                throw new Exception("Error en grabar usuario" + ex);
            }
        }


        public int bloquear(string us, string estado)
        {
            try
            {
                Conexion.Cl_Conexion ob = new Conexion.Cl_Conexion();
                OracleConnection cone = ob.getConexion();

                OracleCommand cmd = cone.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "BLOQUEAR_USUARIO";

                cmd.Parameters.Add("P_USUARIO", OracleDbType.NVarchar2).Value = us;
                cmd.Parameters.Add("P_ESTADO", OracleDbType.NVarchar2).Value = estado;

                return cmd.ExecuteNonQuery();

                cone.Close();
                cmd.Dispose();

            }
            catch (Exception ex) {
                throw new Exception("Error no se pudo bloquear", ex);
            }
        }


        public int eliminar(int id)
        {
            try {
                Conexion.Cl_Conexion cl = new Conexion.Cl_Conexion();
                OracleConnection cn = cl.getConexion();
                cn.Open();

                OracleCommand cmd = cn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "ELIMINAR_USUARIO";
                cmd.Parameters.Add("P_ID_USUARIO",OracleDbType.Int32).Value=id;

               return cmd.ExecuteNonQuery();
                
                cn.Close();
                cmd.Dispose();
                cn.Dispose();
                cn = null;

                
            }
            catch(Exception ex){

                return 0;
                throw new Exception("Error en eliminar" + ex);
               
            }
        }


        public int buscarUsuario(string us,string pas) {
            try {
                Conexion.Cl_Conexion ob = new Conexion.Cl_Conexion();
                OracleConnection con = ob.getConexion();
                con.Open();
                OracleCommand cmd = con.CreateCommand();
                string sql = "select usuario from USUARIO where USUARIO=@us and PASS=@pas";
                cmd.CommandText = sql;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add("us", OracleDbType.NVarchar2).Value = us;
                cmd.Parameters.Add("pas", OracleDbType.NVarchar2).Value = pas;


                return cmd.ExecuteNonQuery();

                con.Close();
                cmd.Dispose();

            }catch(Exception ex){

                throw new Exception("No se pudo buscar el usuario", ex);
            }
        }

        public List<Cl_usuarios> ListarTodo() 
        {
            throw new NotImplementedException();
         }

        public List<EntityClase.Cl_usuarios> ListarCodigo(int id)
        {
            throw new NotImplementedException();
        }

        

    }
}
