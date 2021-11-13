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
    public class D_Usuario : D_ConexionOmnitec
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_validar_usuario";
                    command.Parameters.AddWithValue("@usuario", user);
                    command.Parameters.AddWithValue("@password", pass);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.Idusuario = reader.GetInt32(0);
                            UserLoginCache.Nombre = reader.GetString(1);
                            UserLoginCache.Usuario = reader.GetString(2);
                            UserLoginCache.Email = reader.GetString(5);
                            UserLoginCache.Perfil = reader.GetString(6);
                            UserLoginCache.Diasexpclave = reader.GetInt32(7);
                            UserLoginCache.Tema = reader.GetString (12);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        public bool Checkpassactual(int iduser, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_validar_claveactual";
                    command.Parameters.AddWithValue("@idusuario", iduser);
                    command.Parameters.AddWithValue("@password", pass);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        public bool Checkexisteusuario( string user)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select usuario from usuarios where usuario=@user";
                    command.Parameters.AddWithValue("@user", user);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        public bool Checkexistetemausuario()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select tema from configvistausuario where idusuario=@iduser";
                    command.Parameters.AddWithValue("@iduser", UserLoginCache.Idusuario );
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        public bool InicializarTemaUsuario()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_insertar_temausuario";
                    command.Parameters.AddWithValue("@idusuario", UserLoginCache.Idusuario);
                    command.Parameters.AddWithValue("@tema", UserLoginCache.Tema);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    return true;
                }
            }
        }

        public bool ActualizarTemaUsuario()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_modificar_temausuario";
                    command.Parameters.AddWithValue("@idusuario", UserLoginCache.Idusuario );
                    command.Parameters.AddWithValue("@tema", UserLoginCache.Tema );
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    return true;
                }
            }
        }


        public bool RefrescarPassword(int iduser, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_modificar_actualizaclave";
                    command.Parameters.AddWithValue("@idusuario", iduser);
                    command.Parameters.AddWithValue("@fecha", DateTime.Now);
                    command.Parameters.AddWithValue("@password", pass);
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    return true;
                }    
            }
        }

        public bool Registrainiciosesion(int iduser)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_modificar_feultimoiniciousuario";
                    command.Parameters.AddWithValue("@idusuario", iduser);
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    E_Usuario.Idusuario = iduser;
                    return true;
                }
            }
        }

        public DataTable ComboPerfiles()
        {
            var connection = GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select abrperfil from perfilus where hab='SI'", connection);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool UserAdministradorapp(string user)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select * from usuarios where usuario=@user";
                    command.Parameters.AddWithValue("@user", user);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            E_Usuario.Idusuario = reader.GetInt32(0);
                            E_Usuario.Nombre = reader.GetString(1);
                            E_Usuario.Usuario = reader.GetString(2);
                            E_Usuario.Password = reader.GetString(3);
                            E_Usuario.Passwordmovil = reader.GetString(4);
                            E_Usuario.Email = reader.GetString(5);
                            E_Usuario.Perfil = reader.GetString(6);
                            E_Usuario.Diasexpclave = reader.GetInt32(7);
                            E_Usuario.Fechaactclave = reader.GetDateTime(8);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        public DataTable ListarUsuarios(string Condicion)
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            using (var connection = GetConnection())
            {
                
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_buscar_usuarionombre";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Condicion", Condicion);
                    dr = command.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public bool InsertarUsuario(string pass,string nombre,string usuario,string email,string perfil,int diasexpiraclave,string accesomovil)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_insertar_usuario";
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@password", pass);
                    command.Parameters.AddWithValue("@passwordmovil", pass);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@perfil", perfil);
                    command.Parameters.AddWithValue("@diasexpiraclave", diasexpiraclave);
                    command.Parameters.AddWithValue("@feactclave", DateTime.Now);
                    command.Parameters.AddWithValue("@accesomovil", accesomovil);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    return true;
                }
            }
        }

        public bool ModificarUsuario( int idusuario,string email, string perfil, int diasexpiraclave, string accesomovil)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "proc_modificar_usuario";
                    command.Parameters.AddWithValue("@idusuario", idusuario);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@perfil", perfil);
                    command.Parameters.AddWithValue("@diasexpiraclave", diasexpiraclave);
                    command.Parameters.AddWithValue("@accesomovil", accesomovil);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    return true;
                }
            }
        }

    }
}
