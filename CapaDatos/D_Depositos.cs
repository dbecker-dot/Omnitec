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
    public class D_Depositos : D_ConexionOmnitec
    {
        //Crud Depositos
        public DataTable ListaDepositos()
        {
            var connection = GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select * from vista_depositos", connection);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ComboDepositos()
        {
            var connection = GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select ideposito,deposito from vista_depositos", connection);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ListaUbicacionesxDeposito()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT ubicacion,bloque,rackpasillo,pos,cliente,capacidad,cant as utilizado,disponible,estubic,idubicacion FROM vista_statusubicaciones WHERE ideposito=@ideposito ORDER BY bloque,rackpasillo";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@ideposito", E_Deposito.Ideposito);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public DataTable ListastatusreckapasilloxDeposito()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM vista_statusrackpasillos WHERE ideposito=@ideposito";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@ideposito", E_Deposito.Ideposito);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public void Checkstatusdeposito()
        {
            SqlDataReader reader;
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from vista_statusdeposito";
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            E_Deposito.Capacidad = reader.GetInt32(0);
                            E_Deposito.Utilizado = reader.GetInt32(1);
                            E_Deposito.Disponible = reader.GetInt32(2);
                        }
                    }
                    else
                    {
                        E_Deposito.Capacidad = 0;
                        E_Deposito.Utilizado = 0;
                        E_Deposito.Disponible = 0;
                    }

                }
            }

        }

        public void Checkubicacionseleccionadaxdepbloquerackpasillopos()
        {
            SqlDataReader reader;
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select idubicacion,ubicacion,deposito from vista_statusubicaciones where ideposito=@ideposito and bloque=@bloque and rackpasillo=@rackpasillo and pos=@pos";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@ideposito", E_Deposito.Ideposito);
                    command.Parameters.AddWithValue("@bloque", E_Deposito.Bloque);
                    command.Parameters.AddWithValue("@rackpasillo", E_Deposito.RackPasillo);
                    command.Parameters.AddWithValue("@pos", E_Deposito.Pos);
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            E_Deposito.Idubicacion = reader.GetInt32(0);
                            E_Deposito.Codubicacion = reader.GetString(1);
                            E_Deposito.Deposito = reader.GetString(2);
                        }
                    }
                    else
                    {
                        E_Deposito.Idubicacion = 0;
                        E_Deposito.Codubicacion = "";
                    }
                }
            }
        }

        public void Consultaubicacionseleccionadaxidubicacion()
        {
            SqlDataReader reader;
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select  * from vista_statusubicaciones where idubicacion=@idubicacion";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idubicacion", E_Deposito.Idubicacion );
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            E_Deposito.Codubicacion  = reader.GetString(0);
                            E_Deposito.Capacidad  = reader.GetInt32 (1);
                            E_Deposito.Utilizado  = reader.GetInt32(2);
                            E_Deposito.Disponible  = reader.GetInt32(3);
                            E_Deposito.Ideposito = reader.GetInt32(4);
                        }
                    }
                    else
                    {
                        E_Deposito.Codubicacion = "";
                    }
                }
            }
        }

        public void Checkstatusxideposito()
        {
            SqlDataReader reader;
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from vista_statusdepositos where ideposito=@ideposito";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@ideposito", E_Deposito.Ideposito);
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            E_Deposito.Capacidad = reader.GetInt32(0);
                            E_Deposito.Utilizado = reader.GetInt32(1);
                            E_Deposito.Disponible = reader.GetInt32(2);
                        }
                    }
                    else
                    {
                        E_Deposito.Capacidad = 0;
                        E_Deposito.Utilizado = 0;
                        E_Deposito.Disponible = 0;
                    }

                }
            }

        }

        public void Checkstatusrackpasilloxidepositobloquerackpasillo()
        {
            SqlDataReader reader;
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from vista_statusrackpasillos where ideposito=@ideposito and bloque=@bloque and rackpasillo=@rackpasillo";
                    command.CommandType = CommandType.Text ;
                    command.Parameters.AddWithValue("@ideposito", E_Deposito.Ideposito);
                    command.Parameters.AddWithValue("@bloque", E_Deposito.Bloque);
                    command.Parameters.AddWithValue("@rackpasillo", E_Deposito.RackPasillo);
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (reader.GetString(3) == "SI")
                            {
                                E_Deposito.Estadoubic = true;
                            } else
                            {
                                E_Deposito.Estadoubic = false;
                            }
                            E_Deposito.Capacidad = reader.GetInt32(4);
                            E_Deposito.Utilizado = reader.GetInt32(5);
                            E_Deposito.Disponible = reader.GetInt32(6);
                        }
                    }
                    else
                    {
                        E_Deposito.Estadoubic = false;
                        E_Deposito.Capacidad = 0;
                        E_Deposito.Utilizado = 0;
                        E_Deposito.Disponible = 0;
                    }

                }
            }
            
        }

        public DataTable ListaUbicacionesxDepositoparaetiquetas()
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT ubicacion,bloque,rackpasillo,pos FROM vista_statusubicaciones WHERE ideposito=@ideposito ORDER BY idubicacion";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@ideposito", E_Deposito.Ideposito);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public void ModificarCapacidadUbicacion()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "Update ubicaciones SET capacidad=@capacidad where idubicacion=@idubicacion";
                        command.Parameters.AddWithValue("@idubicacion", E_Deposito.Idubicacion);
                        command.Parameters.AddWithValue("@capacidad", E_Deposito.Capacidad);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                        E_Deposito.ErrorBD = false;
                    }
                }
            }
            catch (Exception)
            {
                E_Deposito.ErrorBD = true;
            }
        }

        public void ModificarEstadoubicacionenrackrefrigerado()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select idubicacion,hab from ubicaciones where bloque=@bloque and rackpasillo=@rackpasillo and ideposito=3";
                    command.Parameters.AddWithValue("@bloque", E_Deposito.Bloque);
                    command.Parameters.AddWithValue("@rackpasillo", E_Deposito.RackPasillo);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            E_Deposito.Idubicacion = reader.GetInt32(0);
                            ModificarEstadoUbicacion();
                        }
                        E_Deposito.ErrorBD = false;
                    }
                    else
                        E_Deposito.ErrorBD = true;
                }
            }
        }

        public void ModificarEstadoUbicacion()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "Update ubicaciones SET hab=@hab where idubicacion=@idubicacion";
                        command.Parameters.AddWithValue("@idubicacion", E_Deposito.Idubicacion);
                        command.Parameters.AddWithValue("@hab", E_Deposito.Hab);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                        E_Deposito.ErrorBD = false;
                    }
                }
            }
            catch (Exception)
            {
                E_Deposito.ErrorBD = true;
            }
        }


        // para el depo refrigerado busco los id de ubicaciones, para reservar todo el rack

        public void Reservarubicacionenrackrefrigerado ()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select idubicacion from ubicaciones where bloque=@bloque and rackpasillo=@rackpasillo and ideposito=3";
                    command.Parameters.AddWithValue("@bloque", E_Deposito.Bloque);
                    command.Parameters.AddWithValue("@rackpasillo", E_Deposito.RackPasillo);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            E_Deposito.Idubicacion = reader.GetInt32(0);
                            AgregarReservaUbicacion();
                        }
                        E_Deposito.ErrorBD = false;
                    }
                    else
                        E_Deposito.ErrorBD = true ;
                }
            }
        }

        public void AgregarReservaUbicacion()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "Insert into reservaubicacionesclientes (idcliente,idubicacion,idusuarioreg) values (@idcliente,@idubicacion,@idusuario)";
                        command.Parameters.AddWithValue("@idcliente", E_Deposito.IdCliente);
                        command.Parameters.AddWithValue("@idubicacion", E_Deposito.Idubicacion);
                        command.Parameters.AddWithValue("@idusuario", E_Usuario.Idusuario);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                        E_Deposito.ErrorBD = false;
                    }
                }
            }
            catch (Exception)
            {
                E_Deposito.ErrorBD = true;
            }
        }


        public void Anulareservarubicacionenrackrefrigerado()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select idubicacion from ubicaciones where bloque=@bloque and rackpasillo=@rackpasillo and ideposito=3";
                    command.Parameters.AddWithValue("@bloque", E_Deposito.Bloque);
                    command.Parameters.AddWithValue("@rackpasillo", E_Deposito.RackPasillo);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            E_Deposito.Idubicacion = reader.GetInt32(0);
                            AnularReservaUbicacion();
                        }
                        E_Deposito.ErrorBD = false;
                    }
                    else
                        E_Deposito.ErrorBD = true;
                }
            }
        }

        public void AnularReservaUbicacion()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "Update reservaubicacionesclientes set Hab='NO',idusuarioanul=@idusuario,fechahoranul=getdate() Where idubicacion=@idubicacion";
                        command.Parameters.AddWithValue("@idubicacion", E_Deposito.Idubicacion);
                        command.Parameters.AddWithValue("@idusuario", E_Deposito.IdUsuario);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                        E_Deposito.ErrorBD = false;
                    }
                }
            }
            catch (Exception)
            {
                E_Deposito.ErrorBD = true;
            }
        }
    }
}
