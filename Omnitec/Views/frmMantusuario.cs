using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades.Cache;
using CapaEntidades;
using CapaNegocio;

namespace Omnitec.Views
{
    public partial class frmMantusuario : Form
    {
        public frmMantusuario()
        {
            InitializeComponent();
        }

        M_Usuario user = new M_Usuario();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void frmMantusuario_Load(object sender, EventArgs e)
        {
            cmbperfil.DataSource = user.comboperfil();
            cmbperfil.DisplayMember = "abrperfil";
            cmbperfil.ValueMember = "abrperfil";
            if (E_Usuario.Idusuario == 0)
            {
                lblaccionusuario.Text = "AGREGAR USUARIO";
                txtnombre.Enabled = true;
                txtusuario.Enabled = true;
                chactivo.Enabled = false;
            } else
            {
                lblaccionusuario.Text = "MODIFICAR USUARIO";
                txtnombre.Enabled = false;
                txtusuario.Enabled = false;
                txtid.Texts = E_Usuario.Idusuario.ToString();
                txtnombre.Texts = E_Usuario.Nombre;
                txtusuario.Texts = E_Usuario.Usuario;
                txtemail.Texts = E_Usuario.Email;
                txtdiasexpiraclave.Texts = E_Usuario.Diasexpclave.ToString();
                chaccesomovil.Checked = false;
                if (E_Usuario.Accesomovil == "SI")
                {
                    chaccesomovil.Checked = true;
                }
                chactivo.Checked = false;
                if (E_Usuario.Hab == "SI")
                {
                    chactivo.Checked = true;
                }
            }
        }

        private void cmbperfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtperfil.Texts = cmbperfil.Text;
            txtperfil.Texts = cmbperfil.SelectedValue.ToString();
        }

        private void cmbdiasexpiraclave_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtdiasexpiraclave.Texts = cmbdiasexpiraclave.Text;
        }

        private void btnguardarcambiosusuario_Click(object sender, EventArgs e)
        {
            string accesomovil;
            if (chaccesomovil.Checked == true)
            {
                accesomovil = "SI";
            }
            else
            {
                accesomovil = "NO";
            }
            if (user.checkpreinsercionusuario(E_Usuario.Idusuario ,txtnombre.Texts, txtusuario.Texts,txtperfil.Texts,txtdiasexpiraclave.Texts) == false)
            {
                MessageBox.Show("Ocurrio un Error, verifique los datos a ingresar", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else 
            {
                if (E_Usuario.Idusuario == 0)
                {
                    if (user.agregarusuario("12345678", txtnombre.Texts, txtusuario.Texts,txtemail.Texts, txtperfil.Texts, int.Parse(txtdiasexpiraclave.Texts), accesomovil))
                    {
                        MessageBox.Show("Usuario Agregado", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                } else
                {
                    if (user.modificarusuario(E_Usuario.Idusuario, txtemail.Texts, txtperfil.Texts, int.Parse(txtdiasexpiraclave.Texts), accesomovil))
                    {
                        MessageBox.Show("Usuario Modificado", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            
            
            
        }

        private void btnrefrescapass_Click(object sender, EventArgs e)
        {
            user.Refrescapass(E_Usuario.Idusuario, "12345678");
            MessageBox.Show("Clave de Usuario Blanqueada", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
