using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using CapaEntidades;
using System.Xml;
//using Presentacio.Properties;

namespace CapaDatos
{
    public abstract class D_ConexionBD
    {
        public static string ObtenerOmnitecConex()
        {
            string strconex = string.Format("Data Source={0};database={1};User ID={2}; Password={3}; Connect Timeout=30;", E_Conexion.ServernameOmnitec, E_Conexion.DatabaseOmnitec, E_Conexion.UsernameOmnitec, E_Conexion.PasswordOmnitec);
            return strconex;
        }

        public static string ObtenerPulseConex()
        {
            string strconex = string.Format("Data Source={0};database={1};User ID={2}; Password={3}; Connect Timeout=30;", E_Conexion.ServernamePulse, E_Conexion.DatabasePulse, E_Conexion.UsernamePulse, E_Conexion.PasswordPulse);
            return strconex;
        }

        public static void ValoresDBOmnitec()
        {
            E_Conexion.ServernameOmnitec = ConfigurationManager.AppSettings["ServidorBDOmnitec"];
            E_Conexion.DatabaseOmnitec = ConfigurationManager.AppSettings["BDOmnitec"];
            E_Conexion.UsernameOmnitec = ConfigurationManager.AppSettings["UsuarioBDOmnitec"];
            E_Conexion.PasswordOmnitec = ConfigurationManager.AppSettings["PasswordBDOmnitec"];
            E_Conexion.StringconexionOmnitec = ConfigurationManager.AppSettings["CadenaBDOmnitec"];
        }

        public static void ValoresDBPulse()
        {
            E_Conexion.ServernamePulse = ConfigurationManager.AppSettings["ServidorBDPulse"];
            E_Conexion.DatabasePulse = ConfigurationManager.AppSettings["BDPulse"];
            E_Conexion.UsernamePulse = ConfigurationManager.AppSettings["UsuarioBDPulse"];
            E_Conexion.PasswordPulse = ConfigurationManager.AppSettings["PasswordBDPulse"];
            E_Conexion.StringconexionPulse = ConfigurationManager.AppSettings["CadenaBDPulse"];
        }

        public static void ActualizarValoresDBOmnitec()
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement element in xmldoc.DocumentElement)
            {
                if (element.Name.Equals("appSettings"))
                {
                    foreach (XmlNode node in element.ChildNodes)
                    {
                        if (node.Attributes[0].Value== "ServidorBDOmnitec")
                        {
                            node.Attributes[1].Value = E_Conexion.ServernameOmnitec;
                        }
                        if (node.Attributes[0].Value == "BDOmnitec")
                        {
                            node.Attributes[1].Value = E_Conexion.DatabaseOmnitec;
                        }
                        if (node.Attributes[0].Value == "UsuarioBDOmnitec")
                        {
                            node.Attributes[1].Value = E_Conexion.UsernameOmnitec;
                        }
                        if (node.Attributes[0].Value == "PasswordBDOmnitec")
                        {
                            node.Attributes[1].Value = E_Conexion.PasswordOmnitec;
                        }
                        if (node.Attributes[0].Value == "CadenaBDOmnitec")
                        {
                            node.Attributes[1].Value = E_Conexion.StringconexionOmnitec;
                        }
                    }
                }
            }
            xmldoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("appSettings");
            E_Conexion.ServernameOmnitec = ConfigurationManager.AppSettings["ServidorBDOmnitec"];
            E_Conexion.DatabaseOmnitec = ConfigurationManager.AppSettings["BDOmnitec"];
            E_Conexion.UsernameOmnitec = ConfigurationManager.AppSettings["UsuarioBDOmnitec"];
            E_Conexion.PasswordOmnitec = ConfigurationManager.AppSettings["PasswordBDOmnitec"];
            E_Conexion.StringconexionOmnitec = ConfigurationManager.AppSettings["CadenaBDOmnitec"];
        }

        public static void ActualizarValoresDBPulse()
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement element in xmldoc.DocumentElement)
            {
                if (element.Name.Equals("appSettings"))
                {
                    foreach (XmlNode node in element.ChildNodes)
                    {
                        if (node.Attributes[0].Value == "ServidorBDPulse")
                        {
                            node.Attributes[1].Value = E_Conexion.ServernamePulse;
                        }
                        if (node.Attributes[0].Value == "BDPulse")
                        {
                            node.Attributes[1].Value = E_Conexion.DatabasePulse;
                        }
                        if (node.Attributes[0].Value == "UsuarioBDPulse")
                        {
                            node.Attributes[1].Value = E_Conexion.UsernamePulse;
                        }
                        if (node.Attributes[0].Value == "PasswordBDPulse")
                        {
                            node.Attributes[1].Value = E_Conexion.PasswordPulse;
                        }
                        if (node.Attributes[0].Value == "CadenaBDPulse")
                        {
                            node.Attributes[1].Value = E_Conexion.StringconexionPulse;
                        }
                    }
                }
            }
            xmldoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("appSettings");
            E_Conexion.ServernamePulse = ConfigurationManager.AppSettings["ServidorBDPulse"];
            E_Conexion.DatabasePulse = ConfigurationManager.AppSettings["BDPulse"];
            E_Conexion.UsernamePulse = ConfigurationManager.AppSettings["UsuarioBDPulse"];
            E_Conexion.PasswordPulse = ConfigurationManager.AppSettings["PasswordBDPulse"];
            E_Conexion.StringconexionPulse = ConfigurationManager.AppSettings["CadenaBDPulse"];
        }


        protected SqlConnection Conexion = new SqlConnection(
            string.Format("Data Source={0};database={1};User ID={2}; Password={3}; Connect Timeout=30;",E_Conexion.ServernameOmnitec, E_Conexion.DatabaseOmnitec, E_Conexion.UsernameOmnitec, E_Conexion.PasswordOmnitec));

        public static bool testconexionDBOmnitec()
        {
            string strconex = string.Format("Data Source={0};database={1};User ID={2}; Password={3}; Connect Timeout=30;", E_Conexion.ServernameOmnitec, E_Conexion.DatabaseOmnitec, E_Conexion.UsernameOmnitec, E_Conexion.PasswordOmnitec);
            SqlConnection test = new SqlConnection(strconex);
            try
            {
                test.Open();
                test.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool testconexionDBPulse()
        {
            string strconex = string.Format("Data Source={0};database={1};User ID={2}; Password={3}; Connect Timeout=30;", E_Conexion.ServernamePulse, E_Conexion.DatabasePulse, E_Conexion.UsernamePulse, E_Conexion.PasswordPulse);
            SqlConnection test = new SqlConnection(strconex);
            try
            {
                test.Open();
                test.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
