using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using EntityClase;

namespace DAO
{
   public class ClienteDaoImpl: ClienteDao
    {

       public int grabarCliente(int rut, string nombre, string apellido_p, string apellido_m, int telefono, int celular, string direccion, 
                         int id_usuario, string patente, int id_tarjeta, string comuna, int edad)
       {
           Conexion.Cl_Conexion obj = new Conexion.Cl_Conexion();
           OracleConnection cone = obj.getConexion();
           cone.Open();

           OracleCommand cmd = cone.CreateCommand();
           cmd.CommandType = System.Data.CommandType.StoredProcedure;
           cmd.CommandText = "INSERTAR_CLIENTE";

           cmd.Parameters.Add("P_RUT", OracleDbType.Int32).Value = rut;
           cmd.Parameters.Add("P_NOMBRE", OracleDbType.NVarchar2).Value = nombre;
           cmd.Parameters.Add("P_APELLIDO_PATERNO", OracleDbType.NVarchar2).Value = apellido_p;
           cmd.Parameters.Add("P_APELLIDO_MATERNO", OracleDbType.NVarchar2).Value = apellido_m;
           cmd.Parameters.Add("P_TELEFONO", OracleDbType.Int32).Value = telefono;
           cmd.Parameters.Add("P_CELULAR", OracleDbType.Int32).Value = celular;
           cmd.Parameters.Add("P_DIRECCION", OracleDbType.Varchar2).Value = direccion;
           cmd.Parameters.Add("P_ID_USUARIO", OracleDbType.Int32).Value = id_usuario;
           cmd.Parameters.Add("P_PATENTE", OracleDbType.NVarchar2).Value = patente;
           cmd.Parameters.Add("P_ID_TARJETA", OracleDbType.Int32).Value = id_tarjeta;
           cmd.Parameters.Add("P_COMUNA", OracleDbType.NVarchar2).Value = comuna;
           cmd.Parameters.Add("P_EDAD", OracleDbType.Int32).Value = edad;



           return cmd.ExecuteNonQuery();
       }
      
        public int eliminar(int rut)
        {
            Conexion.Cl_Conexion ob = new Conexion.Cl_Conexion();
            OracleConnection con = ob.getConexion();

            OracleCommand cmd = con.CreateCommand();

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "CLIENTE_ELIMINAR";
                cmd.Parameters.Add("P_RUT", OracleDbType.Int32).Value = rut;
                return cmd.ExecuteNonQuery();

                con.Close();
                cmd.Dispose();
                

        }

        public int modificar(int rut, string nombre, string apellido_p, string apellido_m, int telefono, int celular, 
                             string direccion,  string patente, int id_tarjeta, string comuna,int edad)
        {
            try
            {
                Conexion.Cl_Conexion ob = new Conexion.Cl_Conexion();
                OracleConnection cone = ob.getConexion();

                OracleCommand cmd = cone.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "MODIFICAR_CLIENTE";

                cmd.Parameters.Add("P_RUT", OracleDbType.Int32).Value = rut;
                cmd.Parameters.Add("P_NOMBRE", OracleDbType.NVarchar2).Value = nombre;
                cmd.Parameters.Add("P_APELLIDO_PATERNO", OracleDbType.NVarchar2).Value = apellido_p;
                cmd.Parameters.Add("P_APELLIDO_MATERNO", OracleDbType.NVarchar2).Value = apellido_m;
                cmd.Parameters.Add("P_TELEFONO", OracleDbType.Int32).Value = telefono;
                cmd.Parameters.Add("P_CELULAR", OracleDbType.Int32).Value = celular;
                cmd.Parameters.Add("P_DIRECCION", OracleDbType.Varchar2).Value = direccion;
                //cmd.Parameters.Add("P_ID_USUARIO", OracleDbType.Int32).Value = id_usuario;
                cmd.Parameters.Add("P_PATENTE", OracleDbType.NVarchar2).Value = patente;
                cmd.Parameters.Add("P_ID_TARJETA", OracleDbType.Int32).Value = id_tarjeta;
                cmd.Parameters.Add("P_COMUNA", OracleDbType.NVarchar2).Value = comuna;
                cmd.Parameters.Add("P_EDAD", OracleDbType.Int32).Value = edad;
                


                return cmd.ExecuteNonQuery();

            }
            catch (Exception ex) {

                throw new Exception("Error no se pudo modificar el cliente ", ex);
            }
        }

       

       
    }
}
