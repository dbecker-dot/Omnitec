using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;
using CapaEntidades.Cache;

namespace CapaDatos
{
    public class D_Dashboard: D_ConexionOmnitec
    {
        SqlCommand cmd;
        SqlDataReader dr;

        public void Stockxgrano(E_Dashboard obj)
        {
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_Dashboard_1_stkxgrano";
                    command.CommandType = CommandType.StoredProcedure;
                    dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        obj.P_Granos.Add(dr.GetString(0));
                        obj.P_CantGranos.Add(dr.GetInt32(1));
                    }
                }
            }
        }

        public void StockxCliente(E_Dashboard obj)
        {
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_Dashboard_1_stkxcliente";
                    command.CommandType = CommandType.StoredProcedure;
                    dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        obj.P_Clientes.Add(dr.GetString(0));
                        obj.P_Cantxclientes.Add(dr.GetInt32(1));
                    }
                }
            }
        }

        public void SumarioDashboardStock(E_Dashboard obj)
        {
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_Dashboard_1_Stock";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter TotConfiteria = new SqlParameter("@totconfiteria", 0); TotConfiteria.Direction = ParameterDirection.Output;
                    SqlParameter TotIndustria = new SqlParameter("@totindustria", 0); TotIndustria.Direction = ParameterDirection.Output;
                    SqlParameter TotBlanchado = new SqlParameter("@totblanchado", 0); TotBlanchado.Direction = ParameterDirection.Output;
                    SqlParameter TotRechazoseleccion = new SqlParameter("@totrechazoseleccion", 0); TotRechazoseleccion.Direction = ParameterDirection.Output;
                    command.Parameters.Add(TotConfiteria);
                    command.Parameters.Add(TotIndustria);
                    command.Parameters.Add(TotBlanchado);
                    command.Parameters.Add(TotRechazoseleccion);
                    command.ExecuteNonQuery();
                    obj.Totconfiteria = command.Parameters["@totconfiteria"].Value.ToString();
                    obj.Totindustria = command.Parameters["@totindustria"].Value.ToString();
                    obj.Totblanchado = command.Parameters["@totblanchado"].Value.ToString();
                    obj.Totrechazoseleccion = command.Parameters["@totrechazoseleccion"].Value.ToString();
                }
            }
        }
    }
}
