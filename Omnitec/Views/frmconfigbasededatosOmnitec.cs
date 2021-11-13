using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CapaNegocio;
using CapaEntidades;

namespace Omnitec.Views
{
    public partial class frmconfigbasededatosOmnitec : Form
    {
        private M_Conexion conex = new M_Conexion();

        public frmconfigbasededatosOmnitec()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmconfigbasededatosOmnitec_Load(object sender, EventArgs e)
        {
            testconexion();
            DatosDeConexion();
        }

        private void DatosDeConexion()
        {
            conex.ObtenerdatoscadenadeconexionOmnitec();
            txtserver.Texts = E_Conexion.ServernameOmnitec;
            txtbd.Texts = E_Conexion.DatabaseOmnitec;
            txtus.Texts = E_Conexion.UsernameOmnitec;
            txtpass.Texts = E_Conexion.PasswordOmnitec;
            lblstrconex.Text = E_Conexion.StringconexionOmnitec;
        }

        private void testconexion()
        {
            try
            {
               if (conex.TestconexionBDOmnitec() == true)
                {
                    btngeneraconexion.Enabled = false;
                    MessageBox.Show("Conexion con Base de datos exitosa", "Conexion Omnitec", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    btngeneraconexion.Enabled = true;
                    MessageBox.Show("Conexion con Base de datos no exitosa", "Conexion Omnitec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception )
            {
                btngeneraconexion.Enabled = true;
                MessageBox.Show("Ocurrio un error...", "Conexion Omnitec", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btngeneraconexion_Click(object sender, EventArgs e)
        {
            E_Conexion.ServernameOmnitec = txtserver.Texts;
            E_Conexion.DatabaseOmnitec = txtbd.Texts;
            E_Conexion.UsernameOmnitec = txtus .Texts;
            E_Conexion.PasswordOmnitec = txtpass.Texts;
            E_Conexion.StringconexionOmnitec = string.Format("Data Source={0};database={1};User ID={2}; Password={3}; Connect Timeout=30;", E_Conexion.ServernameOmnitec, E_Conexion.DatabaseOmnitec, E_Conexion.UsernameOmnitec, E_Conexion.PasswordOmnitec);
            conex.ActualizadatoscadenadeconexionOmnitec();
            testconexion();
            DatosDeConexion();
        }

        private void btneliminaconexion_Click(object sender, EventArgs e)
        {
            E_Conexion.ServernameOmnitec = "";
            E_Conexion.DatabaseOmnitec = "";
            E_Conexion.UsernameOmnitec = "";
            E_Conexion.PasswordOmnitec = "";
            E_Conexion.StringconexionOmnitec = "";
            conex.ActualizadatoscadenadeconexionOmnitec();
            testconexion();
            DatosDeConexion();
        }

        private void btntestconexion_Click(object sender, EventArgs e)
        {
            testconexion();
            DatosDeConexion();
        }
    }
}
