using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace DAO
{
    public class Tipo_ClienteDaoImpl:Tipo_ClienteDAO
    {
        public int grabar(string arrendador, string arrendatario,int rut)
        {
            try {
                Conexion.Cl_Conexion obj = new Conexion.Cl_Conexion();
                OracleConnection con = obj.getConexion();
                con.Open();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "INSERTAR_TIPO_CLIENTE";
                
                cmd.Parameters.Add("P_ARRENDADOR", OracleDbType.Varchar2).Value = arrendador;
                cmd.Parameters.Add("P_ARRENDATARIO", OracleDbType.Varchar2).Value = arrendatario;
                cmd.Parameters.Add("P_RUT", OracleDbType.Int32).Value = rut;

                return cmd.ExecuteNonQuery();

                con.Close();
                cmd.Dispose();
                
                obj = null;
            
            }catch(Exception ex){
                throw new Exception("No se pudo grabar el tipo de cliente" + ex);
                
            }
        }

        public int eliminar(int id)
        {
            try
            {
                Conexion.Cl_Conexion obj = new Conexion.Cl_Conexion();
                OracleConnection con = obj.getConexion();
                con.Open();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "ELIMINAR_TIPO_CLIENTE";
                cmd.Parameters.Add("ID_TIPO", OracleDbType.Int32).Value = id;

                return cmd.ExecuteNonQuery();

                con.Close();
                cmd.Dispose();
            }
            catch (Exception ex) {

                throw new Exception("No se pudo eliminar el tipo de cliente"+ex);
            }
        }

        public int modificar(string arrendador, string arrendatario, int rut)
        {
            try
            {
                Conexion.Cl_Conexion obj = new Conexion.Cl_Conexion();
                OracleConnection con = obj.getConexion();
                con.Open();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "MODIFICAR_TIPO_CLIENTE";
               // cmd.Parameters.Add("P_ID_TIPO", OracleDbType.Int32).Value = x;
                cmd.Parameters.Add("P_ARRENDADOR", OracleDbType.Varchar2).Value = arrendador;
                cmd.Parameters.Add("P_ARRENDATARIO", OracleDbType.Varchar2).Value = arrendatario;
                cmd.Parameters.Add("P_RUT", OracleDbType.Int32).Value = rut;

                
                OracleTransaction tx = con.BeginTransaction();
                cmd.ExecuteNonQuery();
                tx.Commit();
                return 1;

                con.Close();
                cmd.Dispose();

                obj = null;

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo modificar el tipo de cliente" + ex);

            }
        }

    }
}
