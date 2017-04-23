using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace DAO
{
    public class ListaEstaDaoImpl: ListaEstaDao
    {
        public int grabar(string id, int id_esta,string estado)
        {
            try {
                Conexion.Cl_Conexion ob = new Conexion.Cl_Conexion();
                OracleConnection cn = ob.getConexion();
                cn.Open();

                OracleCommand cmd = cn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "ListaEsta_Insertar";
                
                cmd.Parameters.Add("p_id",OracleDbType.NVarchar2).Value=id;
                cmd.Parameters.Add("p_id_es",OracleDbType.Int32).Value=id_esta;
                cmd.Parameters.Add("p_estado", OracleDbType.Varchar2).Value = estado;

                return cmd.ExecuteNonQuery();

               
                
            
            }catch(Exception ex){
              
                throw new Exception("no se puede grabar el listado",ex );
            }
        }


        public int eliminar(string id)
        {

            try
            {
                Conexion.Cl_Conexion obj = new Conexion.Cl_Conexion();
                OracleConnection cone = obj.getConexion();
                cone.Open();
                OracleCommand cmd = cone.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "ListaEsta_ELIMINAR";

                cmd.Parameters.Add("p_id", OracleDbType.NVarchar2).Value = id;
             

                return cmd.ExecuteNonQuery();

                cone.Close();
                cmd.Dispose();

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo eliminar en el listado", ex);
            }
        }




        public int modificar(string estado)
        {
            try
            {
                Conexion.Cl_Conexion obj = new Conexion.Cl_Conexion();
                OracleConnection cone = obj.getConexion();
                cone.Open();
                OracleCommand cmd = cone.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "ListaEsta_Modificar";

                cmd.Parameters.Add("p_estado", OracleDbType.NVarchar2).Value = estado;


                return cmd.ExecuteNonQuery();

                cone.Close();
                cmd.Dispose();

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo Modificar", ex);
            }
        }
    }
}
