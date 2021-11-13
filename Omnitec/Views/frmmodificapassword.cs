using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades.Cache;
using CapaNegocio;

namespace Omnitec.Views
{
    public partial class frmmodificapassword : Form
    {
        M_Usuario user = new M_Usuario();
        public frmmodificapassword()
        {
            InitializeComponent();
        }

        private void frmmodificapassword_Load(object sender, EventArgs e)
        {
            txttituloform.Texts = "CAMBIO DE CREDENCIALES";
            txtusuario.Texts = UserLoginCache.Usuario;
            txtnombre.Texts = UserLoginCache.Nombre;
        }

        private void btnmodificarpassword_Click(object sender, EventArgs e)
        {
            if (user.checkpassactual(UserLoginCache.Idusuario,txtpasswordactual.Texts)== true)
            {
                //Verifico que las claves no sean blancos
                if (txtpasswordnueva.Texts == "" || txtrepetirpasswordnueva.Texts == "")
                {
                    MessageBox.Show("Las contraseñas no pueden ser blancos, Intentelo nuevamente", "Actualiza Credenciales", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpasswordnueva.Focus();
                }
                else
                {
                    //Verifico que las claves coincidan
                    if (txtpasswordnueva.Texts == txtrepetirpasswordnueva.Texts)
                    {
                        user.Refrescapass(UserLoginCache.Idusuario, txtpasswordnueva.Texts);
                        MessageBox.Show("La contraseña fue actualizada con exito", "Actualiza Credenciales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (UserLoginCache.Refescapass == true)
                        {
                            Dispose();
                            frmBienvenida frmwelcome = new frmBienvenida();
                            frmwelcome.ShowDialog();
                            frmMenuPrincipal frmppal = new frmMenuPrincipal();
                            frmppal.ShowDialog();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas Actual no coinciden, Intentelo nuevamente", "Actualiza Credenciales", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtpasswordnueva.Focus();
                        txtpasswordnueva.Texts = "";
                        txtrepetirpasswordnueva.Texts = "";
                    }
                }
            } else 
            {
                MessageBox.Show("La contraseña Actual no es correcta, Intentelo nuevamente", "Actualiza Credenciales", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpasswordactual.Focus();
                txtpasswordactual.Texts = "";

            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (UserLoginCache.Refescapass == true)
            {
                Dispose();
                LoginView frmlogin = new LoginView();
                frmlogin.ShowDialog();
            }
            else
            {
                this.Close();
            }
        }
    }
}
