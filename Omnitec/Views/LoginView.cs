using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades.Cache;

namespace Omnitec.Views
{
    public partial class LoginView : Form
    {
        M_Usuario user = new M_Usuario();
        public LoginView()
        {
            InitializeComponent();
            
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void LoginView_Load(object sender, EventArgs e)
        {
            lblversion.Text = "VERSION: " + user.versionsistema();
        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }

        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.Silver;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.Silver;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginView_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel_lateralogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MsgError(string msg)
        {
            lblerror.Text = msg;
            lblerror.Visible = true;
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            if (txtuser.Text != "Usuario")
            {
                if (txtpass.Text != "Contraseña")
                {
                    if (user.Usuarioadmin(txtuser.Text))
                    {
                        if (user.Passwordadmin(txtpass.Text))
                        {
                            Dispose();
                            frmBienvenida frmwelcome = new frmBienvenida();
                            frmwelcome.ShowDialog();
                            AppConfigView frmappcon = new AppConfigView();
                            frmappcon.ShowDialog();
                        } else
                        {
                            MsgError("Contraseña incorrecta");
                        }
                    }
                    else
                    {
                        if (user.LoginUser(txtuser.Text, txtpass.Text) == true)
                        {
                            //si la contraseña es 12345678 solicito el cambio
                            if (txtpass.Text == "12345678")
                            {
                                user.Iniciosesion(UserLoginCache.Idusuario);
                                UserLoginCache.Refescapass = true;
                                Dispose();
                                frmmodificapassword frmcbiopass = new frmmodificapassword();
                                frmcbiopass.ShowDialog();
                            }
                            else {
                                user.Iniciosesion(UserLoginCache.Idusuario);
                                UserLoginCache.Refescapass = false;
                                Dispose();
                                frmBienvenida frmwelcome = new frmBienvenida();
                                frmwelcome.ShowDialog();
                                frmMenuPrincipal frmppal = new frmMenuPrincipal();
                                frmppal.ShowDialog();
                            }
                        }
                        else
                        {
                            MsgError("Usuario o contraseña incorrecta");
                        }
                    }
                }
                else
                    MsgError("Contraseña Invalida");
            }
            else
                MsgError("Usuario Invalido");
        }
    }
}
