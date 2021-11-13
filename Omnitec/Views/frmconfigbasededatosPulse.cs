using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;


namespace Omnitec.Views
{
    public partial class frmconfigbasededatosPulse : Form
    {
        private M_Conexion conex = new M_Conexion();
        public frmconfigbasededatosPulse()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmconfigbasededatosPulse_Load(object sender, EventArgs e)
        {
            testconexion();
            DatosdeConexion();
        }

        private void DatosdeConexion()
        {
            conex.ObtenerdatoscadenadeconexionPulse();
            txtserver.Texts = E_Conexion.ServernamePulse;
            txtbd.Texts = E_Conexion.DatabasePulse;
            txtus.Texts = E_Conexion.UsernamePulse;
            txtpass.Texts = E_Conexion.PasswordPulse;
            lblstrconex.Text = E_Conexion.StringconexionPulse;
        }

        private void testconexion()
        {
            try
            {
                if (conex.TestconexionBDPulse() == true)
                {
                    btngeneraconexion.Enabled = false;
                    MessageBox.Show("Conexion con Base de datos exitosa", "Conexion Pulse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    btngeneraconexion.Enabled = true;
                    MessageBox.Show("Conexion con Base de datos no exitosa", "Conexion Pulse", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                btngeneraconexion.Enabled = true;
                MessageBox.Show("Ocurrio un error...", "Conexion Omnitec", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btngeneraconexion_Click(object sender, EventArgs e)
        {
            E_Conexion.ServernamePulse = txtserver.Texts;
            E_Conexion.DatabasePulse = txtbd.Texts;
            E_Conexion.UsernamePulse = txtus.Texts;
            E_Conexion.PasswordPulse = txtpass.Texts;
            E_Conexion.StringconexionPulse = string.Format("Data Source={0};database={1};User ID={2}; Password={3}; Connect Timeout=30;", E_Conexion.ServernamePulse, E_Conexion.DatabasePulse, E_Conexion.UsernamePulse, E_Conexion.PasswordPulse);
            conex.ActualizadatoscadenadeconexionPulse();
            testconexion();
            DatosdeConexion();
        }

        private void btneliminaconexion_Click(object sender, EventArgs e)
        {
            E_Conexion.ServernamePulse = "";
            E_Conexion.DatabasePulse = "";
            E_Conexion.UsernamePulse = "";
            E_Conexion.PasswordPulse = "";
            E_Conexion.StringconexionPulse = "";
            conex.ActualizadatoscadenadeconexionPulse();
            testconexion();
            DatosdeConexion();
        }

        private void btntestconexion_Click(object sender, EventArgs e)
        {
            testconexion();
            DatosdeConexion();
        }
    }
}
