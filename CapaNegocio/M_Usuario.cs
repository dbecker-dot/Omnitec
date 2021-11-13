using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class M_Usuario
    {
        D_Usuario usermodel = new D_Usuario();

        public string versionsistema()
        {
            return "2.0";
        }

        public bool Usuarioadmin(string user)
        {
            if (user == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Passwordadmin(string pass)
        {
            if (pass == "omnitecapp")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string GetSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        public bool LoginUser(string user, string pass)
        {
            return usermodel.Login(user, GetSHA256(pass));
        }
        public bool UserAdministrador(string user)
        {
            return usermodel.UserAdministradorapp(user);
        }
        public void Refrescapass(int iduser, string pass)
        {
            usermodel.RefrescarPassword(iduser, GetSHA256(pass));
        }

        public void Iniciosesion(int iduser)
        {
            usermodel.Registrainiciosesion(iduser);
        }

        public bool checkpassactual(int iduser, string pass)
        {
           return usermodel.Checkpassactual(iduser, GetSHA256(pass));
        }

        public DataTable ListarUsuarios(string busqueda)
        {
            return usermodel.ListarUsuarios(busqueda);
        }

        public DataTable comboperfil()
        {
            return usermodel.ComboPerfiles();
        }

        public bool checkpreinsercionusuario(int idus, string nombre,string usuario,string perfil,string diasexpiraclave)
        {
            if (nombre == "")
            {
                return false;
            }
            if (perfil == "")
            {
                return false;
            }
            if (diasexpiraclave == "")
            {
                return false;
            }
            if (usermodel.Checkexisteusuario(usuario) == true && idus==0)
            {
                return false;
            }
            return true;
        }

        public bool agregarusuario(string pass,string nombre, string usuario, string email,string perfil, int diasexpiraclave,string accesomovil)
        {
            string password = GetSHA256(pass);
            return usermodel.InsertarUsuario(password,nombre,usuario,email,perfil,diasexpiraclave,accesomovil);
        }

        public bool modificarusuario(int idus, string email, string perfil, int diasexpiraclave, string accesomovil)
        {
            return usermodel.ModificarUsuario( idus, email, perfil, diasexpiraclave, accesomovil);
        }

        public void AdmTemaUsuario()
        {
            bool existe = usermodel.Checkexistetemausuario();
            if (existe==false)
            {
                usermodel.InicializarTemaUsuario();
            } else
            {
                usermodel.ActualizarTemaUsuario();
            }
        }

    }
}
