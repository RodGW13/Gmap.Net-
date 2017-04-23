using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using EntityClase;

namespace DAO
{
   public class VehiculoDaoImpl:VehiculoDao
    {

       public int grabar(string patente, string marca, string color, string descripcion)
        {
            try {
                //string sql = ""; uso de prueba sentencia sql
                Conexion.Cl_Conexion ob = new Conexion.Cl_Conexion();
                OracleConnection cn = ob.getConexion();
                cn.Open();

                OracleCommand cmd = cn.CreateCommand();
                //cmd.CommandType = System.Data.CommandType.Text;se crear un constructor que recive la sentencia sql
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Vehiculo_Insertar";
                cmd.Parameters.Add("p_patente", OracleDbType.NVarchar2).Value = patente;
                cmd.Parameters.Add("p_marca", OracleDbType.NVarchar2).Value = marca;
                cmd.Parameters.Add("p_color", OracleDbType.NVarchar2).Value = color;
                cmd.Parameters.Add("p_descripcion", OracleDbType.NVarchar2).Value = descripcion;

                cmd.ExecuteNonQuery();
                int respuesta = cmd.ExecuteNonQuery();
                return respuesta;

                cn.Close();
                cmd.Dispose();
                cn.Dispose();
                ob= null;

            
            }catch(Exception ex){

                throw new Exception("No se pudo guardar el vehículo", ex);

            }
        }

        public int eliminar(string patente)
        {
            try
            {
                Conexion.Cl_Conexion obj = new Conexion.Cl_Conexion();
                OracleConnection cn = obj.getConexion();
                cn.Open();

                OracleCommand cmd = cn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Vehiculo_Eliminar";
                cmd.Parameters.Add("pat", OracleDbType.NVarchar2).Value = patente;
 
                return cmd.ExecuteNonQuery();
                cn.Close();
                cmd.Dispose();
                cn.Dispose();


            }
            catch (Exception ex) {

                throw new Exception("No se pudo eliminar el vehículo", ex);
                //return 0;
            }

        }

        public List<Cl_vehiculo> listarTodo()
        {
            throw new NotImplementedException();
        }

        public List<Cl_vehiculo> listarporId(int patente)
        {
            throw new NotImplementedException();
        }


        public int modificar(string patente, string marca, string color, string descripcion)
        {
            try {
                Conexion.Cl_Conexion cl = new Conexion.Cl_Conexion();
                OracleConnection con = cl.getConexion();
                con.Open();

                OracleCommand cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Vehiculo_Modificar";
                cmd.Parameters.Add("p_PATENTE",OracleDbType.NVarchar2).Value=patente;
                cmd.Parameters.Add("p_COLOR", OracleDbType.NVarchar2).Value=marca;
                cmd.Parameters.Add("p_MARCA ", OracleDbType.NVarchar2).Value=color;
                cmd.Parameters.Add("p_DESCRIPCION", OracleDbType.NVarchar2).Value=descripcion;

                OracleTransaction tx = con.BeginTransaction();
                cmd.ExecuteNonQuery();
                tx.Commit();
                return 1;

                con.Close();
                cmd.Dispose();
                con.Dispose();
            
            }
            catch(Exception ex){
                return 0;
                throw new Exception("Error no se pudo modificar" + ex);
            }
        }
    }
}
