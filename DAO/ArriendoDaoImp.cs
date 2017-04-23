using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using EntityClase;

namespace DAO
{
    public class ArriendoDaoImp:ArriendoDao
    {

        public int grabarA(DateTime inicio, DateTime termino, string arrendatario, int tipo_cliente)
        {
              try {
                Conexion.Cl_Conexion ob = new Conexion.Cl_Conexion();
                OracleConnection cn = ob.getConexion();
                cn.Open();
                 
                OracleCommand cmd = cn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "INSERTAR_ARRIENDO";
                
                cmd.Parameters.Add("P_HORARIO_IN",OracleDbType.Date).Value=inicio;
                cmd.Parameters.Add("P_HORARIO_TE",OracleDbType.Date).Value=termino;
                cmd.Parameters.Add("P_ARRENDATARIO",OracleDbType.Date).Value=arrendatario;
                cmd.Parameters.Add("P_TIPO_CLIENTE", OracleDbType.Int32).Value = tipo_cliente;

                return cmd.ExecuteNonQuery();

               
                
            
            }catch(Exception ex){
              
                throw new Exception("no se puede grabar el listado",ex );
            }
        }
        

        public int modificar(int id, DateTime inicio, DateTime termino, string arrendatario, int tipo_cliente)
        {
            try {
                Conexion.Cl_Conexion ob = new Conexion.Cl_Conexion();
                OracleConnection cn = ob.getConexion();
                cn.Open();
                 
                OracleCommand cmd = cn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "MODIFICAR_ARRIENDO";

                cmd.Parameters.Add("P_ID", OracleDbType.Int32).Value = id;
                cmd.Parameters.Add("P_HORARIO_IN",OracleDbType.Date).Value=inicio;
                cmd.Parameters.Add("P_HORARIO_TE",OracleDbType.Date).Value=termino;
                cmd.Parameters.Add("P_ARRENDATARIO",OracleDbType.Date).Value=arrendatario;
                cmd.Parameters.Add("P_TIPO_CLIENTE", OracleDbType.Int32).Value = tipo_cliente;

                OracleTransaction tx = cn.BeginTransaction();
                cmd.ExecuteNonQuery();
                tx.Commit();
                return 1;

                cn.Close();
                cmd.Dispose();

                ob = null;
                
            
            }catch(Exception ex){
              
                throw new Exception("no se puede grabar el listado",ex );
            }
        }
    }
}
