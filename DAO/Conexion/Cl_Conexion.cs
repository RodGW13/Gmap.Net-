using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Oracle.DataAccess.Client;
using System.Configuration;


namespace DAO.Conexion
{
    public class Cl_Conexion
    {
       private OracleConnection cn { get; set; }

        public OracleConnection getConexion() {

            OracleConnection cn = new OracleConnection("DATA SOURCE=XE;USER ID=DESARROLLO; Password=123456 ");
            OracleCommand cmm = new OracleCommand();
            cmm.Connection = cn;
            return cn;

        }

        public void Cerrar() {
            cn.Close();
        }
    }
}
