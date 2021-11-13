using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades.Cache;
using CapaEntidades;
using CapaNegocio;
using CapaDatos.Services;
using System.Drawing.Printing;

namespace Omnitec.Views
{
    public partial class frmMenuPrincipal : Form
    {
        //temas

        private WinTheme temaform = new WinTheme();

        M_Usuario objuser = new M_Usuario();
        M_Ordenes objorden = new M_Ordenes();
        public bool mostrarpanelorden=false;
        //Constructor
        public frmMenuPrincipal()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }
        //METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO  TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedorPrincipal.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {

            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
       
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //METODOS PARA CERRAR,MAXIMIZAR, MINIMIZAR FORMULARIO------------------------------------------------------
        int lx, ly;
        int sw, sh;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximizar.Visible = false;
            btnNormal.Visible = true;

        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnNormal.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta¡¡", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar sesion?", "Alerta¡¡", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Dispose();
                LoginView frmlog = new LoginView();
                frmlog.ShowDialog();
            }
        }

        //METODOS PARA ANIMACION DE MENU SLIDING--
        private void btnMenu_Click(object sender, EventArgs e)
        {
            //-------CON EFECTO SLIDING
            if (panelMenu.Width == 230)
            {
                this.tmContraerMenu.Start();
            }
            else if (panelMenu.Width == 55)
            {
                this.tmExpandirMenu.Start();
            }

            //-------SIN EFECTO 
            //if (panelMenu.Width == 55)
            //{
            //    panelMenu.Width = 230;
            //}
            //else

            //    panelMenu.Width = 55;
        }

        private void tmExpandirMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width >= 230)
                this.tmExpandirMenu.Stop();
            else
                panelMenu.Width = panelMenu.Width + 5;
            
        }

        private void tmContraerMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width <= 55)
                this.tmContraerMenu.Stop();
            else
                panelMenu.Width = panelMenu.Width - 5;
        }

        //METODO PARA ABRIR FORM DENTRO DE PANEL-----------------------------------------------------
        public void AbrirFormEnPanel(object formHijo)
        {
            CerrarPanelOrden();
            if (this.panelContenedorForm.Controls.Count > 0)
                this.panelContenedorForm.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;            
            this.panelContenedorForm.Controls.Add(fh);
            this.panelContenedorForm.Tag = fh;
            fh.Show();
        }

        public void AbrirFormEnPanelinstancia(object formHijo)
        {
            CerrarPanelOrden();
            if (this.panelContenedorForm.Controls.Count > 0)
                this.panelContenedorForm.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorForm.Controls.Add(fh);
            this.panelContenedorForm.Tag = fh;
            //fh.Show(this);
            fh.Show(fh);
        }

        public void CerrarPanelOrden()
        {
            //if (this.panelContenedorForm.Controls.Count > 0)
            //    this.panelContenedorForm.Controls.RemoveAt(0);

            PanelDetalleOrdenes.Visible = false;
        
        }

        public void AbrirPanelOrden()
        {
            if (this.panelContenedorForm.Controls.Count > 0)
               this.panelContenedorForm.Controls.RemoveAt(0);
            
            PanelDetalleOrdenes.Visible = true;
            PanelDetalleOrdenes.Width = 740;
            CargarOrden();
        }

        private void CargarOrden()
        {
            lblorden.Text = "ORDEN NRO: " + E_Ordenes.Nro;
            lblfechaorden .Text = E_Ordenes.Fecha.ToString("dd/MM/yyyy");
            lbltipo.Text = E_Ordenes.Tipo;
            lblstatus.Text = E_Ordenes.Statusorden;
            lblcliente.Text = E_Ordenes.Cliente;
            lbllote.Text = E_Ordenes.Lote;
            lblkgnetos.Text = E_Ordenes.Kg.ToString();
            lblcant.Text = E_Ordenes.Cant.ToString();

        }

        private void formResize()
        {
           
        }

        //METODO PARA MOSTRAR FORMULARIO DE LOGO Al INICIAR ----------------------------------------------------------
        private void MostrarFormLogo()
        {
            menudepo.Visible = false;
            panel_hora.Visible = true;
            if (mostrarpanelorden == false )
            {
                AbrirFormEnPanel(new FormLogo());
            }
            
        }

        public void ocultarpanelhora()
        {
            panel_hora.Visible = false;
        }

        public void mostrarpanelhora()
        {
            panel_hora.Visible = true;
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            menudepo.Visible = false;
            MostrarFormLogo();
            DropdownMenuAdministrador.IsMainMenu = true;
            lblusuario.Text = UserLoginCache.Usuario;
            lblnombreusuario.Text = UserLoginCache.Nombre;
            lblperfilusuario.Text = UserLoginCache.Perfil;
            if (UserLoginCache.Perfil == PerfilUsers.Operador)
            {
                btnadministrador.Enabled = false;
            }
            if (UserLoginCache.Perfil == PerfilUsers.Consulta)
            {
                btnadministrador.Enabled = false;
                btnoperaciones.Enabled = false;
            }
            CerrarPanelOrden();
            temaform.ElegirTema(UserLoginCache.Tema );
            panel_hora.BackColor = temaform.PanelInferior;
            PanelBarraTitulo.BackColor = temaform.PanelTitulo;
            panelMenu.BackColor = temaform.PanelBotones;
            panelContenedorPrincipal.BackColor = temaform.PanelPadre;

        }
        //METODO PARA MOSTRAR FORMULARIO DE LOGO Al CERRAR OTROS FORM ----------------------------------------------------------
        public void MostrarFormLogoAlCerrarForms(object sender, FormClosedEventArgs e)
        {
            MostrarFormLogo();
        }
        //METODOS PARA ABRIR OTROS FORMULARIOS Y MOSTRAR FORM DE LOGO Al CERRAR ----------------------------------------------------------
        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            DropdownMenuOperaciones.Show(btnoperaciones, btnoperaciones.Width, 0);
        }

      

        private void btnReportes_Click(object sender, EventArgs e)
        {
            DropdownMenuReportes.Show(btnreportes, btnreportes.Width, 0);
        }

        private void btnadministrador_Click(object sender, EventArgs e)
        {
            DropdownMenuAdministrador.Show(btnadministrador, btnadministrador.Width, 0);
        }

        private void mnuadmusuarios_Click(object sender, EventArgs e)
        {
            frmadmusuarios frm = new frmadmusuarios();
            frm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(frm);
        }

        private void mnuclientes_Click(object sender, EventArgs e)
        {
            frmadmclientes frm = new frmadmclientes();
            frm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(frm);
        }

        private void btnactualizarmiusuario_Click(object sender, EventArgs e)
        {
            frmmodificapassword frmcbiopass = new frmmodificapassword();
            frmcbiopass.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(frmcbiopass);
        }

        private void mnuadmcosechasygranos_Click(object sender, EventArgs e)
        {
            frmcosechasygranos frmcg = new frmcosechasygranos();
            frmcg.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(frmcg);
        }

        private void mnuanumodifordenes_Click(object sender, EventArgs e)
        {
           
        }

        private void mnurepstock_Click(object sender, EventArgs e)
        {
            frmRepStock frmrstk = new frmRepStock();
            frmrstk.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(frmrstk);
        }


        private void mnuadmdepositos_Click(object sender, EventArgs e)
        {
            panel_Submenu.Visible = true;
            menudepo.Visible = true;
            frmdepositos frmdep = new frmdepositos();
            frmdep.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(frmdep);
            menudepo.Visible = true;
        }

        private void mnuubicaciones_Click(object sender, EventArgs e)
        {
            Depositos.frmubicaciones frmubicaciones = new Depositos.frmubicaciones();
            frmubicaciones.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(frmubicaciones);
            mnuubicaciones.Enabled = false;
            mnuverdepositos.Enabled = true;
            mnuetiquetasubicaciones.Enabled = true;
        }

        private void mnuverdepositos_Click(object sender, EventArgs e)
        {
            frmdepositos frmdep = new frmdepositos();
            frmdep.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(frmdep);
            mnuubicaciones.Enabled = true;
            mnuverdepositos.Enabled = false;
            mnuetiquetasubicaciones.Enabled = true;
        }

        private void mnuetiquetasubicaciones_Click(object sender, EventArgs e)
        {
            Depositos.frmetiquetasubicaciones frmetdep = new Depositos.frmetiquetasubicaciones();
            frmetdep.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(frmetdep);
            mnuubicaciones.Enabled = true;
            mnuverdepositos.Enabled = true;
            mnuetiquetasubicaciones.Enabled = false;
        }

        private void mnuordenesdetrabajo_Click(object sender, EventArgs e)
        {
            Ordenes.frmlistarordenes frmlord = new Ordenes.frmlistarordenes(this);
            frmlord.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            frmlord.lbltituloform.Text = "ORDENES ABIERTAS";
            AbrirFormEnPanel(frmlord);
            menudepo.Visible = false;
        }

        private void mnulistarordenesabiertas_Click(object sender, EventArgs e)
        {
            Ordenes.frmlistarordenes frmlord = new Ordenes.frmlistarordenes(this);
            frmlord.lbltituloform.Text = "ORDENES ABIERTAS";
            frmlord.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(frmlord);
            menudepo.Visible = false;
           
        }

        private void btncerrarpanelorden_Click(object sender, EventArgs e)
        {

            Ordenes.frmlistarordenes frmlord = new Ordenes.frmlistarordenes(this);
            frmlord.lbltituloform.Text = "ORDENES ABIERTAS";
            frmlord.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(frmlord);
        }

       

        private void mnuanumodifordenes_Click_1(object sender, EventArgs e)
        {
            Ordenes.frmodificaranularordenes frmaord = new Ordenes.frmodificaranularordenes(this);
            frmaord.lbltituloform.Text = "ANULAR / MODIFICAR ORDENES";
            frmaord.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(frmaord);
            menudepo.Visible = false;
        }

        private void mnuconsulubicaciones_Click(object sender, EventArgs e)
        {
            
        }

        private void mnurepstatusdeposito_Click(object sender, EventArgs e)
        {
            Reportes.frmstarusdeposito  frmsdep = new Reportes.frmstarusdeposito();
            frmsdep.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            panel_hora.Visible = false;
            AbrirFormEnPanel(frmsdep);
        }

        private void mnurepconsultarubicaciones_Click(object sender, EventArgs e)
        {
            Ordenes.frmub frmconsubic = new Ordenes.frmub(this);
            frmconsubic.modoconsulta = true;
            frmconsubic.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            panel_hora.Visible = false;
            AbrirFormEnPanel(frmconsubic);
        }

        private void gunaComboBoxtema_SelectedIndexChanged(object sender, EventArgs e)
        {
            temaform.ElegirTema(gunaComboBoxtema.Text);
            panel_hora.BackColor = temaform.PanelInferior;
            PanelBarraTitulo.BackColor = temaform.PanelTitulo;
            panelMenu.BackColor = temaform.PanelBotones;
            panelContenedorPrincipal.BackColor = temaform.PanelPadre;
            UserLoginCache.Tema = gunaComboBoxtema.Text;
            objuser.AdmTemaUsuario();
        }

        private void btnmuestrahora_Click(object sender, EventArgs e)
        {
            lblHora.Visible = true;
            pictureBoxuser.Visible = true;
            lblnombreusuario.Visible = true;
            lblusuario.Visible = true;
            lblperfilusuario.Visible = true;
            lblFecha.Visible = true;
            btnmuestrahora.Visible = false;
            btnocultahora.Visible = true;
            panel_hora.Height = 85;
        }

        private void btnocultahora_Click(object sender, EventArgs e)
        {
            lblHora.Visible = false;
            pictureBoxuser.Visible = false;
            lblnombreusuario.Visible = false;
            lblusuario.Visible = false;
            lblperfilusuario.Visible = false;
            lblFecha.Visible = false;
            btnmuestrahora.Visible = true;
            btnocultahora.Visible = false;
            panel_hora.Height = 30;
        }

        private void btnasociarloteenorden_Click(object sender, EventArgs e)
        {
            Ordenes.frmasociarordenes  frmasocorden = new Ordenes.frmasociarordenes(this);
            frmasocorden.lblote.Text = "LOTE: " + E_Ordenes.Lote;
            frmasocorden.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(frmasocorden);
        }

        private void btnubicarproducto_Click(object sender, EventArgs e)
        {
            Ordenes.frmub frmubicaprod = new Ordenes.frmub(this);
            frmubicaprod.modoconsulta = false;
            //frmubicaprod.lblote.Text = "LOTE: " + E_Ordenes.Lote;
            frmubicaprod.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(frmubicaprod);
        }

        private void btnverproductosorden_Click(object sender, EventArgs e)
        {

            Ordenes.frmverproductos  frmverprod = new Ordenes.frmverproductos(this);
            frmverprod.lblote.Text = "LOTE: " + E_Ordenes.Lote;
            frmverprod.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(frmverprod);
        }

        private void btnprocesarproductos_Click(object sender, EventArgs e)
        {

            Ordenes.frmprocesarproductosdeorden frmprocprod = new Ordenes.frmprocesarproductosdeorden(this);
            frmprocprod.lblote.Text = "LOTE: " + E_Ordenes.Lote;
            frmprocprod.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(frmprocprod);
        }

        private void btnetiquetasproductos_Click(object sender, EventArgs e)
        {
            Ordenes.frmetiquetasproductos  frmetprod = new Ordenes.frmetiquetasproductos(this);
            //frmetprod.lblote.Text = "LOTE: " + E_Ordenes.Lote;
            frmetprod.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(frmetprod);
        }

        private void btnimprimeorden_Click(object sender, EventArgs e)
        {
            //Reportes.frmreporteorden frmreporden = new Reportes.frmreporteorden(this);
            //frmetprod.lblote.Text = "LOTE: " + E_Ordenes.Lote;
            //frmreporden.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(frmreporden);
        }

        

        //METODO PARA HORA Y FECHA ACTUAL ----------------------------------------------------------
        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        

    }
}
