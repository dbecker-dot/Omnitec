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
    public partial class frmusuarioadministradorapp : Form
    {
        M_Usuario useradministradorapp = new M_Usuario();
        public frmusuarioadministradorapp()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmusuarioadministradorapp_Load(object sender, EventArgs e)
        {
            if (useradministradorapp.UserAdministrador("administrador") == true)
            {
                txtusuario.Text = E_Usuario.Usuario;
                txtnombre.Text = E_Usuario.Nombre;
                txtemail.Texts = E_Usuario.Email;
                if (E_Usuario.Accesomovil == "SI")
                {
                    chaccesomovil.Checked = true;
                } else
                {
                    chaccesomovil.Checked = false;
                }
                btngenerarusuarioadministradorapp.Enabled = false;
            }
        }

        private void btnrefrescapassuseradministrador_Click(object sender, EventArgs e)
        {
            useradministradorapp.Refrescapass(E_Usuario.Idusuario, "12345678");
            MessageBox.Show("La clave del administrador ha sido Blanqueada exitosamente", "Usuario Administrador App", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
