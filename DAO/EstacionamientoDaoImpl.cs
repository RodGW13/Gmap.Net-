using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;

namespace DAO
{
    public class EstacionamientoDaoImpl:EstacionamientoDao
    {
        public int grabar( string direccion, string comuna, string latitud, string longitud, int precio, string arrendador,
                           int tipo_cliente, string disponibilidad, DateTime horario_i, DateTime horario_t)
        {
            try
            {
                Conexion.Cl_Conexion ob = new Conexion.Cl_Conexion();
                OracleConnection cn = ob.getConexion();
                cn.Open();

                OracleCommand cmd = cn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "ESTACIONAMIENTO_INSERTAR";

                //cmd.Parameters.Add("P_ID", OracleDbType.Int32).Value = id;
                cmd.Parameters.Add("P_DIRECCION", OracleDbType.NVarchar2).Value = direccion;
                cmd.Parameters.Add("P_COMUNA", OracleDbType.NVarchar2).Value = comuna;
                cmd.Parameters.Add("P_LATITUD", OracleDbType.NVarchar2).Value = latitud;
                cmd.Parameters.Add("P_LONGITUD", OracleDbType.NVarchar2).Value = longitud;
                cmd.Parameters.Add("P_PRECIO", OracleDbType.Int32).Value = precio;
                cmd.Parameters.Add("P_ARRENDADOR", OracleDbType.NVarchar2).Value = arrendador;
                cmd.Parameters.Add("P_TIPO", OracleDbType.Int32).Value = tipo_cliente;
                cmd.Parameters.Add("P_DIS", OracleDbType.NVarchar2).Value = disponibilidad;
                cmd.Parameters.Add("P_HORARIO_IN", OracleDbType.Date).Value = horario_i;
                cmd.Parameters.Add("P_HORARIO_TE", OracleDbType.Date).Value = horario_t;

                return cmd.ExecuteNonQuery();
               
                

                cn.Close();
                cmd.Dispose();
                cn.Dispose();
                ob = null;

            }
            catch (Exception ex) {

                throw new Exception("No se pudo grabar el estacionamiento", ex);
            }
        }

        public int eliminar(int id)
        {
            try
            {
                Conexion.Cl_Conexion obj = new Conexion.Cl_Conexion();
                OracleConnection con = obj.getConexion();

                OracleCommand cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "ESTACIONAMIENTO_ELIMINAR";
                cmd.Parameters.Add("ID_ESTACIONAMIENTO", OracleDbType.Int32).Value = id;

                return cmd.ExecuteNonQuery();

                con.Close();
                cmd.Dispose();

            }
            catch (Exception ex) {

                throw new Exception("No se pudo eliminar el estacionamiento" , ex);
            }

        }

        public int modificar(int id, string direccion, string comuna, string latitud, string longitud, int precio,string arrendador, int tipo_cliente, string disponibilidad, DateTime horario_i, DateTime horario_t)
        {
            try
            {
                Conexion.Cl_Conexion obj = new Conexion.Cl_Conexion();
                OracleConnection con = obj.getConexion();

                OracleCommand cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "ESTACIONAMIENTO_MODIFICAR";

                cmd.Parameters.Add("P_ID", OracleDbType.Int32).Value = id;
                cmd.Parameters.Add("P_DIRECCION", OracleDbType.NVarchar2).Value = direccion;
                cmd.Parameters.Add("P_COMUNA", OracleDbType.NVarchar2).Value = comuna;
                cmd.Parameters.Add("P_LATITUD", OracleDbType.NVarchar2).Value = latitud;
                cmd.Parameters.Add("P_LONGITUD", OracleDbType.NVarchar2).Value = longitud;
                cmd.Parameters.Add("P_PRECIO", OracleDbType.Int32).Value = precio;
                cmd.Parameters.Add("P_ARRENDADOR", OracleDbType.Int32).Value = arrendador;
                cmd.Parameters.Add("P_TIPO", OracleDbType.Int32).Value = tipo_cliente;
                cmd.Parameters.Add("P_DIS", OracleDbType.NVarchar2).Value = disponibilidad;
                cmd.Parameters.Add("P_HORARIO_IN", OracleDbType.Date).Value = horario_i;
                cmd.Parameters.Add("P_HORARIO_TE", OracleDbType.Date).Value = horario_t;

                OracleTransaction tx = con.BeginTransaction();
                cmd.ExecuteNonQuery();
                tx.Commit();
                return 1;

                con.Close();
                cmd.Dispose();

                obj = null;

            }
            catch (Exception ex) {

                throw new Exception("Error no se pudo modificar el estacionamiento",ex);
            }
        }
    }
}
 