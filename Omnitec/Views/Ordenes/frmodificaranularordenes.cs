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
    public partial class frmodificaranularordenes : Form
    {
        M_Cliente Obj_cli = new M_Cliente();
        M_Ordenes Obj_orden = new M_Ordenes();
        private WinTheme temaform = new WinTheme();
        private frmMenuPrincipal principal;

        public frmodificaranularordenes(frmMenuPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void frmodificaranularordenes_Load(object sender, EventArgs e)
        {
            try
            {
                cmbcliente.DataSource = Obj_cli.comboclientesordenesactivas();
                cmbcliente.DisplayMember = "cliente";
                cmbcliente.ValueMember = "idcliente";
                cmbtipo.DataSource = Obj_orden.Combotiporden();
                cmbtipo.DisplayMember = "tipo";
                cmbtipo.ValueMember = "idtipo";
                cmbstatusorden.DataSource = Obj_orden.Combostatusoorden();
                cmbstatusorden.DisplayMember = "statusorden";
                cmbstatusorden.ValueMember = "idstatusorden";
                E_Ordenes.IdCliente = 0;
                E_Ordenes.IdTipo = 0;
                E_Ordenes.IdStatusorden = 0;
                E_Ordenes.FiltrodeTiempo = "ESTE AÑO";
                panel_lateralfiltrofechas.Width = 165;
                txtfiltrodebusqueda.Texts = E_Ordenes.FiltrodeTiempo;
                lbltipo.BackColor = Color.Red;
                E_Ordenes.IdTipo = 0;
                lblcliente.BackColor = Color.Red;
                E_Ordenes.IdCliente = 0;
                lblstatus.BackColor = Color.Red;
                E_Ordenes.IdStatusorden = 0;
                btnvertodaslasordenes.BackColor = Color.Red;
                Cargargrilla();
                //Configuro el tema
                temaform.ElegirTema(UserLoginCache.Tema);
                panel_Superior.BackColor = temaform.PanelTitulo;
                panel_lateralfiltrofechas.BackColor = temaform.PanelInferior;
                panel_contenido.BackColor = temaform.PanelPadre;
                lbltituloform.BackColor = temaform.PanelBotones;
                this.BackColor = temaform.PanelPadre;
            }

            catch (Exception)
            {

            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmExpandirMenu_Tick(object sender, EventArgs e)
        {
            if (panel_lateralfiltrofechas.Width >= 165)
                this.tmExpandirMenu.Stop();
            else
                panel_lateralfiltrofechas.Width = panel_lateralfiltrofechas.Width + 5;
        }

        private void tmContraerMenu_Tick(object sender, EventArgs e)
        {
            if (panel_lateralfiltrofechas.Width <= 50)
                this.tmContraerMenu.Stop();
            else
                panel_lateralfiltrofechas.Width = panel_lateralfiltrofechas.Width - 5;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panel_lateralfiltrofechas.Width == 165)
            {
                this.tmContraerMenu.Start();
            }
            else if (panel_lateralfiltrofechas.Width == 50)
            {
                this.tmExpandirMenu.Start();
            }
        }

        private void Cargargrilla()
        {
            try
            {
                dgvordenes.DataSource = Obj_orden.Listaordenesxfechas();
                dgvordenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception)
            {

                
            }
         
            
            
        }

        private void cmbcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblcliente.BackColor = Color.Green;
                E_Ordenes.IdCliente = int.Parse(cmbcliente.SelectedValue.ToString());
                Cargargrilla();
            }
            catch (Exception)
            {


            }
        }

        private void cmbtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbltipo.BackColor = Color.Green;
                E_Ordenes.IdTipo = int.Parse(cmbtipo.SelectedValue.ToString());
                Cargargrilla();
            }
            catch (Exception)
            {


            }
        }

        private void cmbstatusorden_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblstatus.BackColor = Color.Green;
                E_Ordenes.IdStatusorden = int.Parse(cmbstatusorden.SelectedValue.ToString());
                Cargargrilla();
            }
            catch (Exception)
            {


            }
        }

        private void cmblimpiaflitros_Click(object sender, EventArgs e)
        {
            try
            {
                lbltipo.BackColor = Color.Red;
                E_Ordenes.IdTipo = 0;
                lblcliente.BackColor = Color.Red;
                E_Ordenes.IdCliente = 0;
                lblstatus.BackColor = Color.Red;
                E_Ordenes.IdStatusorden = 0;
                btnvertodaslasordenes.BackColor = Color.Red;
            }
            catch (Exception)
            {

                
            }
        }

        private void btnvertodaslasordenes_Click(object sender, EventArgs e)
        {
            try
            {
                lbltipo.BackColor = Color.Red;
                E_Ordenes.IdTipo = 0;
                lblcliente.BackColor = Color.Red;
                E_Ordenes.IdCliente = 0;
                lblstatus.BackColor = Color.Red;
                E_Ordenes.IdStatusorden = 0;
                btnvertodaslasordenes.BackColor = Color.Green;
                Cargargrilla();
            }
            catch (Exception)
            {

                
            }
        }

        private void btnhoy_Click(object sender, EventArgs e)
        {
            try
            {
                E_Ordenes.Desde = DateTime.Today;
                E_Ordenes.Hasta = DateTime.Now;
                btnhoy.BackColor = Color.Green;
                btnestasemana.BackColor = Color.Red;
                btnestasemana.BackColor = Color.Red;
                btnesteaño.BackColor = Color.Red;
                btnestemes.BackColor = Color.Red;
                btnxrango.BackColor = Color.Red;
                Cargargrilla();
                txtfiltrodebusqueda.Texts = "HOY: " + E_Ordenes.Desde.ToString("dd - MM - yyyy");
            }
            catch (Exception)
            {

            }
        }

        private void btnesteaño_Click(object sender, EventArgs e)
        {
            try
            {
                E_Ordenes.Desde = new DateTime (DateTime.Now.Year,01,01);
                E_Ordenes.Hasta = new DateTime (DateTime.Now.Year, 12, 01);
                btnhoy.BackColor = Color.Red ;
                btnestasemana.BackColor = Color.Red;
                btnestasemana.BackColor = Color.Red;
                btnesteaño.BackColor = Color.Green;
                btnestemes.BackColor = Color.Red;
                btnxrango.BackColor = Color.Red;
                Cargargrilla();
                txtfiltrodebusqueda.Texts = "AÑO: " + DateTime.Now.Year;
            }
            catch (Exception)
            {

            }
        }

        private void btnestasemana_Click(object sender, EventArgs e)
        {
            try
            {
                E_Ordenes.Desde = new DateTime(E_Ordenes.LunesdelaSemana(E_Ordenes.Nrodediadelasemana(DateTime.Now), DateTime.Now).Year, E_Ordenes.LunesdelaSemana(E_Ordenes.Nrodediadelasemana(DateTime.Now), DateTime.Now).Month, E_Ordenes.LunesdelaSemana(E_Ordenes.Nrodediadelasemana(DateTime.Now), DateTime.Now).Day);
                E_Ordenes.Hasta = E_Ordenes.Desde.AddDays(6);
                btnhoy.BackColor = Color.Red;
                btnestasemana.BackColor = Color.Green;
                btnestemes.BackColor = Color.Red;
                btnesteaño.BackColor = Color.Red;
                btnxrango.BackColor = Color.Red;
                Cargargrilla();
                txtfiltrodebusqueda.Texts = "SEM: " + E_Ordenes.SemanaActual().ToString() + " " + E_Ordenes.Desde.ToString("dd - MM - yyyy") + " / " + E_Ordenes.Hasta.ToString("dd - MM - yyyy");
            }
            catch (Exception)
            {

            }
        }

        private void btnestemes_Click(object sender, EventArgs e)
        {
            try
            {
                E_Ordenes.Desde = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                E_Ordenes.Hasta = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                btnhoy.BackColor = Color.Red;
                btnestasemana.BackColor = Color.Red;
                btnestemes.BackColor = Color.Green;
                btnesteaño.BackColor = Color.Red;
                btnxrango.BackColor = Color.Red;
                Cargargrilla();
                txtfiltrodebusqueda.Texts = "MES: " + DateTime.Now.Month + " " + E_Ordenes.Desde.ToString("dd - MM - yyyy") + " / " + E_Ordenes.Hasta.ToString("dd - MM - yyyy");
            }
            catch (Exception)
            {

            }
        }

        private void btnxrango_Click(object sender, EventArgs e)
        {
            try
            {
                E_Ordenes.Desde = new DateTime(dtpdesde.Value.Year, dtpdesde.Value.Month, dtpdesde.Value.Day);
                E_Ordenes.Hasta = new DateTime(dtphasta.Value.Year, dtphasta.Value.Month, dtphasta.Value.Day);
                btnhoy.BackColor = Color.Red;
                btnestasemana.BackColor = Color.Red;
                btnestemes.BackColor = Color.Red;
                btnesteaño.BackColor = Color.Red;
                btnxrango.BackColor = Color.Green;
                Cargargrilla();
                txtfiltrodebusqueda.Texts = "RANGO: " + E_Ordenes.Desde.ToString("dd - MM - yyyy") + " / " + E_Ordenes.Hasta.ToString("dd - MM - yyyy");
            }
            catch (Exception)
            {

            }
        }

        private void dgvordenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                E_Ordenes.IdOrden = int.Parse(dgvordenes.CurrentRow.Cells[8].Value.ToString());
                Obj_orden.ConsultarOrdenxIdorden();
                if (E_Ordenes.IdOrden != 0)
                {
                    E_Ordenes.EditOrden = true;
                    switch (E_Ordenes.IdTipo)
                    {
                        case 1:
                            this.Close();
                            Ordenes.frmabmordenrecepcion frmordenrec = new Ordenes.frmabmordenrecepcion(principal);
                            frmordenrec.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
                            principal.AbrirFormEnPanel(frmordenrec);
                            break;
                        case 2:
                            this.Close();
                            Ordenes.frmabmordendeproduccion frmordenprod = new Ordenes.frmabmordendeproduccion(principal);
                            frmordenprod.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
                            principal.AbrirFormEnPanel(frmordenprod);
                            break;
                        case 3:
                            this.Close();
                            Ordenes.frmabmordendespachodevolucion frmordendev = new Ordenes.frmabmordendespachodevolucion(principal);
                            frmordendev.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
                            principal.AbrirFormEnPanel(frmordendev);
                            break;
                        case 4:
                            this.Close();
                            Ordenes.frmabmordendespachodevolucion frmordendes = new Ordenes.frmabmordendespachodevolucion(principal);
                            frmordendes.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
                            principal.AbrirFormEnPanel(frmordendes);
                            break;
                        default:
                            this.Close();
                            Ordenes.frmabmordendeproduccion frmordenreprod = new Ordenes.frmabmordendeproduccion(principal);
                            frmordenreprod.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
                            principal.AbrirFormEnPanel(frmordenreprod);
                            break;

                    }
                }
            }
            catch (Exception)
            {

                
            }
        }
    }
}
