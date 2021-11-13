using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public abstract class D_ConexionOmnitec
    {
        private readonly string connectionString;
        public D_ConexionOmnitec()
        {
            ValoresDBOmnitec();
            connectionString = E_Conexion.StringconexionOmnitec;
        }

        private void ValoresDBOmnitec()
        {
            E_Conexion.StringconexionOmnitec = ConfigurationManager.AppSettings["CadenaBDOmnitec"];
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
