using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;
using CapaDatos.Services;
using CapaEntidades.Cache;

namespace Omnitec.Views.Ordenes
{
    public partial class frmub : Form
    {
        private WinTheme temaform = new WinTheme();
        public bool sinpanelizquierdo=true;
        public bool sinpanelderecho=true ;
        public int tampaneliz;
        public bool modoconsulta;
        private frmMenuPrincipal principal;
        public frmub(frmMenuPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void frmub_Load(object sender, EventArgs e)
        {
            if (sinpanelizquierdo == true)
            {
                panelmenulateralizquierdo.Visible = false;
            }
            else
            {
                panelmenulateralizquierdo.Visible = true;
            }
            if (sinpanelderecho == true)
            {
                panelmenulateralderecho.Visible = false;
            }
            else
            {
                panelmenulateralderecho.Visible = true;
            }

            //Configuro el tema
            temaform.ElegirTema(UserLoginCache.Tema);
            panelsuperior.BackColor = temaform.PanelTitulo;
            panelcontenedor.BackColor = temaform.PanelPadre;
            panelmenulateralizquierdo.BackColor  = temaform.PanelInferior;
            panelmenulateralderecho.BackColor = temaform.PanelInferior;

            //CRUDO
            buttonubicCAP1.OnButtonClick += buttonubicCAP1_Click;
            buttonubicCAP2.OnButtonClick += buttonubicCAP2_Click;
            buttonubicCAP3.OnButtonClick += buttonubic1_Click;
            buttonubicCAP4.OnButtonClick += buttonubicCAP4_Click;
            buttonubicCAP5.OnButtonClick += buttonubicCAP5_Click;
            buttonubicCAP6.OnButtonClick += buttonubicCAP6_Click;
            buttonubicCAP7.OnButtonClick += buttonubicCAP7_Click;
            buttonubicCAP8.OnButtonClick += buttonubicCAP8_Click;
            buttonubicCAP9.OnButtonClick += buttonubicCAP9_Click;
            buttonubicCAP10.OnButtonClick += buttonubicCAP10_Click;
            buttonubicCAP11.OnButtonClick += buttonubicCAP11_Click;

            buttonubicCBP1.OnButtonClick += buttonubicCBP1_Click;
            buttonubicCBP2.OnButtonClick += buttonubicCBP2_Click;
            buttonubicCBP3.OnButtonClick += buttonubicCBP3_Click;
            buttonubicCBP4.OnButtonClick += buttonubicCBP4_Click;

            buttonubicCCP1.OnButtonClick += buttonubicCCP1_Click;
            buttonubicCCP2.OnButtonClick += buttonubicCCP2_Click;

            //PRODUCCION
            buttonubicPAP1.OnButtonClick += buttonubicPAP1_Click;


            //REFRIGERADO
            buttonubicRAP1.OnButtonClick += buttonubicRAP1_Click;
            buttonubicRAP2.OnButtonClick += buttonubicRAP2_Click;
            buttonubicRAP3.OnButtonClick += buttonubicRAP3_Click;
            buttonubicRAP4.OnButtonClick += buttonubicRAP4_Click;
            buttonubicRAP5.OnButtonClick += buttonubicRAP5_Click;
            buttonubicRAP6.OnButtonClick += buttonubicRAP6_Click;
            actualizarstatus();
        }

        private void actualizarstatus()
        {
            try
            {
                //CRUDO
                
                pBubicCAP1.actualizarvalores();
                pBubicCAP2.actualizarvalores();
                pBubicCAP3.actualizarvalores();
                pBubicCAP4.actualizarvalores();
                pBubicCAP5.actualizarvalores();
                pBubicCAP6.actualizarvalores();
                pBubicCAP7.actualizarvalores();
                pBubicCAP8.actualizarvalores();
                pBubicCAP9.actualizarvalores();
                pBubicCAP10.actualizarvalores();
                pBubicCAP11.actualizarvalores();
                pBubicCBP1.actualizarvalores();
                pBubicCBP2.actualizarvalores();
                pBubicCBP3.actualizarvalores();
                pBubicCBP4.actualizarvalores();
                pBubicCCP1.actualizarvalores();
                pBubicCCP2.actualizarvalores();

                //PRODUCCION
                pBubicPAP1.actualizarvalores();

                //REFRIGERADO

                pBubicRAP1.actualizarvalores();
                pBubicRAP2.actualizarvalores();
                pBubicRAP3.actualizarvalores();
                pBubicRAP4.actualizarvalores();
                pBubicRAP5.actualizarvalores();
                pBubicRAP6.actualizarvalores();
                pBubicRAP7.actualizarvalores();
                pBubicRAP8.actualizarvalores();
                pBubicRAP9.actualizarvalores();
                pBubicRAP10.actualizarvalores();
                pBubicRAP11.actualizarvalores();
                pBubicRAP12.actualizarvalores();
                pBubicRAP13.actualizarvalores();
                pBubicRAP14.actualizarvalores();
                pBubicRAP15.actualizarvalores();
                pBubicRAP16.actualizarvalores();
                pBubicRAP17.actualizarvalores();
                pBubicRAP18.actualizarvalores();

                pBubicRBP1.actualizarvalores();
                pBubicRBP2.actualizarvalores();
                pBubicRBP3.actualizarvalores();
                pBubicRBP4.actualizarvalores();
                pBubicRBP5.actualizarvalores();
                pBubicRBP6.actualizarvalores();
                pBubicRBP7.actualizarvalores();
                pBubicRBP8.actualizarvalores();
                pBubicRBP9.actualizarvalores();
                pBubicRBP10.actualizarvalores();
                pBubicRBP11.actualizarvalores();
                pBubicRBP12.actualizarvalores();
                pBubicRBP13.actualizarvalores();
                pBubicRBP14.actualizarvalores();
                pBubicRBP15.actualizarvalores();
                pBubicRBP16.actualizarvalores();
                pBubicRBP17.actualizarvalores();
                pBubicRBP18.actualizarvalores();

                pBubicRCP1.actualizarvalores();
                pBubicRCP2.actualizarvalores();
                pBubicRCP3.actualizarvalores();
                pBubicRCP4.actualizarvalores();
                pBubicRCP5.actualizarvalores();
                pBubicRCP6.actualizarvalores();
                pBubicRCP7.actualizarvalores();
                pBubicRCP8.actualizarvalores();
                pBubicRCP9.actualizarvalores();
                pBubicRCP10.actualizarvalores();
                pBubicRCP11.actualizarvalores();
                pBubicRCP12.actualizarvalores();
                pBubicRCP13.actualizarvalores();
                pBubicRCP14.actualizarvalores();
                pBubicRCP15.actualizarvalores();
                pBubicRCP16.actualizarvalores();
                pBubicRCP17.actualizarvalores();
                pBubicRCP18.actualizarvalores();

                pBubicRDP1.actualizarvalores();
                pBubicRDP2.actualizarvalores();
                pBubicRDP3.actualizarvalores();
                pBubicRDP4.actualizarvalores();
                pBubicRDP5.actualizarvalores();
                pBubicRDP6.actualizarvalores();
                pBubicRDP7.actualizarvalores();
                pBubicRDP8.actualizarvalores();
                pBubicRDP9.actualizarvalores();
                pBubicRDP10.actualizarvalores();
                pBubicRDP11.actualizarvalores();
                pBubicRDP12.actualizarvalores();
                pBubicRDP13.actualizarvalores();
                pBubicRDP14.actualizarvalores();
                pBubicRDP15.actualizarvalores();
                pBubicRDP16.actualizarvalores();
                pBubicRDP17.actualizarvalores();
                pBubicRDP18.actualizarvalores();

                //ALERO
                pBubicALEA.actualizarvalores();
                pBubicALEB.actualizarvalores();

                //INGRESO REFRIGERADO
                pBubicIRAP1.actualizarvalores();
                pBubicIRAP2.actualizarvalores();
                pBubicIRAP3.actualizarvalores();
                pBubicIRAP4.actualizarvalores();
                pBubicIRAP5.actualizarvalores();
                pBubicIRBP1.actualizarvalores();
                pBubicIRBP2.actualizarvalores();
                pBubicIRBP3.actualizarvalores();
                pBubicIRBP4.actualizarvalores();
                pBubicIRBP5.actualizarvalores();
                pBubicIRBP6.actualizarvalores();
                pBubicIRBP7.actualizarvalores();
                pBubicIRCP1.actualizarvalores();
                pBubicIRCP2.actualizarvalores();
                pBubicIRCP3.actualizarvalores();
                pBubicIRCP4.actualizarvalores();
                pBubicIRCP5.actualizarvalores();
                pBubicIRCP6.actualizarvalores();
                pBubicIRCP7.actualizarvalores();
                pBubicIRDP1.actualizarvalores();
                pBubicIRDP2.actualizarvalores();
                pBubicIRDP3.actualizarvalores();
                pBubicIRDP4.actualizarvalores();
                pBubicIRDP5.actualizarvalores();
                pBubicIRDP6.actualizarvalores();
                pBubicIRDP7.actualizarvalores();
                pBubicIRDP8.actualizarvalores();
                pBubicIRDP9.actualizarvalores();
                pBubicIRDP10.actualizarvalores();
                pBubicIRDP11.actualizarvalores();
                pBubicIREP1.actualizarvalores();
                pBubicIREP2.actualizarvalores();
                pBubicIREP3.actualizarvalores();
            }
            catch (Exception)
            {

                
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (modoconsulta==true )
            {
                this.Close();
            }else
            {
                this.Close();
                principal.mostrarpanelorden = true;
                principal.AbrirPanelOrden();
            }
        }

        private void btnMenuizquierdo_Click(object sender, EventArgs e)
        {
            //-------CON EFECTO SLIDING
            if (panelmenulateralizquierdo.Width == 300)
            {
                this.tmContraerMenuiz.Start();
            }
            else if (panelmenulateralizquierdo.Width == 55)
            {
                this.tmExpandirMenuiz.Start();
            }

            //-------SIN EFECTO 
            //if (panelMenu.Width == 55)
            //{
            //    panelMenu.Width = 230;
            //}
            //else

            //    panelMenu.Width = 55;
        }

        private void tmContraerMenuiz_Tick(object sender, EventArgs e)
        {
            if (panelmenulateralizquierdo.Width >= 200)
                this.tmExpandirMenuiz.Stop();
            else
                panelmenulateralizquierdo.Width = panelmenulateralizquierdo.Width + 5;
        }

        private void tmExpandirMenuiz_Tick(object sender, EventArgs e)
        {
            if (panelmenulateralizquierdo.Width <= 55)
                this.tmContraerMenuiz.Stop();
            else
                panelmenulateralizquierdo.Width = panelmenulateralizquierdo.Width - 5;
        }

        private void btnMenuderecho_Click(object sender, EventArgs e)
        {
            //-------CON EFECTO SLIDING
            /*if (panelmenulateralizquierdo.Width == 200)
            {
                this.tmContraerMenuiz.Start();
            }
            else if (panelmenulateralizquierdo.Width == 55)
            {
                this.tmExpandirMenuiz.Start();
            }
            */
            //-------SIN EFECTO 
            if (panelmenulateralderecho.Width == 55)
            {
                panelmenulateralderecho.Width = 230;
            }
            else

                panelmenulateralderecho.Width = 55;
        }




        private void buttonubic1_Click(object sender, EventArgs e)
        {
            if (modoconsulta == true)
            {
                frmconsultaubicacion hijo = new frmconsultaubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            } else
            {
                frmasignarubicacion hijo = new frmasignarubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
          
        }

       

        private void buttonubicCAP1_Click(object sender, EventArgs e)
        {
            if (modoconsulta == true)
            {
                frmconsultaubicacion hijo = new frmconsultaubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
            else
            {
                frmasignarubicacion hijo = new frmasignarubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
        }

        private void buttonubicCAP2_Click(object sender, EventArgs e)
        {
            if (modoconsulta == true)
            {
                frmconsultaubicacion hijo = new frmconsultaubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
            else
            {
                frmasignarubicacion hijo = new frmasignarubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
        }

        private void buttonubicCAP4_Click(object sender, EventArgs e)
        {
            if (modoconsulta == true)
            {
                frmconsultaubicacion hijo = new frmconsultaubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
            else
            {
                frmasignarubicacion hijo = new frmasignarubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
        }

        private void buttonubicCAP5_Click(object sender, EventArgs e)
        {
            if (modoconsulta == true)
            {
                frmconsultaubicacion hijo = new frmconsultaubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
            else
            {
                frmasignarubicacion hijo = new frmasignarubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
        }

        private void buttonubicCAP6_Click(object sender, EventArgs e)
        {
            if (modoconsulta == true)
            {
                frmconsultaubicacion hijo = new frmconsultaubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
            else
            {
                frmasignarubicacion hijo = new frmasignarubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
        }

        private void buttonubicCAP7_Click(object sender, EventArgs e)
        {
            if (modoconsulta == true)
            {
                frmconsultaubicacion hijo = new frmconsultaubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
            else
            {
                frmasignarubicacion hijo = new frmasignarubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
        }

        private void buttonubicCAP8_Click(object sender, EventArgs e)
        {
            if (modoconsulta == true)
            {
                frmconsultaubicacion hijo = new frmconsultaubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
            else
            {
                frmasignarubicacion hijo = new frmasignarubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
        }

        private void buttonubicCAP9_Click(object sender, EventArgs e)
        {
            if (modoconsulta == true)
            {
                frmconsultaubicacion hijo = new frmconsultaubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
            else
            {
                frmasignarubicacion hijo = new frmasignarubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
        }

        private void buttonubicCAP10_Click(object sender, EventArgs e)
        {
            if (modoconsulta == true)
            {
                frmconsultaubicacion hijo = new frmconsultaubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
            else
            {
                frmasignarubicacion hijo = new frmasignarubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
        }

        private void buttonubicCAP11_Click(object sender, EventArgs e)
        {
            if (modoconsulta == true)
            {
                frmconsultaubicacion hijo = new frmconsultaubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
            else
            {
                frmasignarubicacion hijo = new frmasignarubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
        }

        private void buttonubicCBP1_Click(object sender, EventArgs e)
        {
            if (modoconsulta == true)
            {
                frmconsultaubicacion hijo = new frmconsultaubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
            else
            {
                frmasignarubicacion hijo = new frmasignarubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
        }

        private void buttonubicCBP2_Click(object sender, EventArgs e)
        {
            if (modoconsulta == true)
            {
                frmconsultaubicacion hijo = new frmconsultaubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
            else
            {
                frmasignarubicacion hijo = new frmasignarubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
        }

        private void buttonubicCBP3_Click(object sender, EventArgs e)
        {
            if (modoconsulta == true)
            {
                frmconsultaubicacion hijo = new frmconsultaubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
            else
            {
                frmasignarubicacion hijo = new frmasignarubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
        }

        private void buttonubicCBP4_Click(object sender, EventArgs e)
        {
            if (modoconsulta == true)
            {
                frmconsultaubicacion hijo = new frmconsultaubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
            else
            {
                frmasignarubicacion hijo = new frmasignarubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
        }

        private void buttonubicCCP1_Click(object sender, EventArgs e)
        {
            if (modoconsulta == true)
            {
                frmconsultaubicacion hijo = new frmconsultaubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
            else
            {
                frmasignarubicacion hijo = new frmasignarubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
        }

        private void buttonubicCCP2_Click(object sender, EventArgs e)
        {
            if (modoconsulta == true)
            {
                frmconsultaubicacion hijo = new frmconsultaubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
            else
            {
                frmasignarubicacion hijo = new frmasignarubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
        }

        private void buttonubicPAP1_Click(object sender, EventArgs e)
        {
            if (modoconsulta == true)
            {
                frmconsultaubicacion hijo = new frmconsultaubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
            else
            {
                frmasignarubicacion hijo = new frmasignarubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
        }

        private void buttonubicRAP1_Click(object sender, EventArgs e)
        {
            if (modoconsulta == true)
            {
                frmconsultaubicacion hijo = new frmconsultaubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
            else
            {
                frmasignarubicacion hijo = new frmasignarubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
        }

        private void buttonubicRAP2_Click(object sender, EventArgs e)
        {
            if (modoconsulta == true)
            {
                frmconsultaubicacion hijo = new frmconsultaubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
            else
            {
                frmasignarubicacion hijo = new frmasignarubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
        }

        private void buttonubicRAP3_Click(object sender, EventArgs e)
        {
            if (modoconsulta == true)
            {
                frmconsultaubicacion hijo = new frmconsultaubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
            else
            {
                frmasignarubicacion hijo = new frmasignarubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
        }

        private void buttonubicRAP4_Click(object sender, EventArgs e)
        {
            if (modoconsulta == true)
            {
                frmconsultaubicacion hijo = new frmconsultaubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
            else
            {
                frmasignarubicacion hijo = new frmasignarubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
        }

        private void buttonubicRAP5_Click(object sender, EventArgs e)
        {
            if (modoconsulta == true)
            {
                frmconsultaubicacion hijo = new frmconsultaubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
            else
            {
                frmasignarubicacion hijo = new frmasignarubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
        }

        private void buttonubicRAP6_Click(object sender, EventArgs e)
        {
            if (modoconsulta == true)
            {
                frmconsultaubicacion hijo = new frmconsultaubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
            else
            {
                frmasignarubicacion hijo = new frmasignarubicacion();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                //hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                //E_Usuario.Idusuario = 0;
                hijo.Show();
            }
        }
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            actualizarstatus();
        }

       
    }
}
