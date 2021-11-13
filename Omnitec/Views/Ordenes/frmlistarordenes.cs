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
    public partial class frmlistarordenes : Form
    {

        M_Cliente Obj_cli = new M_Cliente();
        M_Ordenes Obj_orden = new M_Ordenes();
        private WinTheme temaform = new WinTheme();
        private frmMenuPrincipal principal;

        public frmlistarordenes(frmMenuPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmlistarordenes_Load(object sender, EventArgs e)
        {
            try
            {
                cmbcliente.DataSource = Obj_cli.comboclientesordenesactivas();
                cmbcliente.DisplayMember = "cliente";
                cmbcliente.ValueMember = "idcliente";
                cmbtipo.DataSource = Obj_orden.Combotiporden();
                cmbtipo.DisplayMember = "tipo";
                cmbtipo.ValueMember = "idtipo";
                E_Ordenes.IdCliente = 0;
                E_Ordenes.IdTipo = 0;
                Cargargrilla();
                //Configuro el tema
                temaform.ElegirTema(UserLoginCache.Tema);
                panelsuperior.BackColor = temaform.PanelTitulo;
                lbltituloform.BackColor = temaform.PanelBotones;
                this.BackColor = temaform.PanelPadre;
            }
            catch (Exception)
            {

            }
        }

        private void Cargargrilla()
        {
            if (E_Ordenes.IdCliente == 0 && E_Ordenes.IdTipo == 0) 
            { 
                dgvordenes.DataSource = Obj_orden.Listaordenesabiertas();
                dgvordenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            if (E_Ordenes.IdCliente != 0 && E_Ordenes.IdTipo == 0)
            {
                dgvordenes.DataSource = Obj_orden.Listaordenesabiertasxcliente();
                dgvordenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            if (E_Ordenes.IdCliente == 0 && E_Ordenes.IdTipo != 0)
            {
                dgvordenes.DataSource = Obj_orden.Listaordenesabiertasxtipo();
                dgvordenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        
        private void cmbtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                E_Ordenes.IdCliente = 0;
                E_Ordenes.IdTipo = int.Parse(cmbtipo.SelectedValue.ToString());
                Cargargrilla();
            }
            catch (Exception)
            {


            }
        }

        private void cmbcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                E_Ordenes.IdTipo = 0;
                E_Ordenes.IdCliente = int.Parse(cmbcliente.SelectedValue.ToString());
                Cargargrilla();
            }
            catch (Exception)
            {


            }
        }

        private void btnvertodaslasordenes_Click(object sender, EventArgs e)
        {
            E_Ordenes.IdCliente = 0;
            E_Ordenes.IdTipo = 0;
            Cargargrilla();
        }

        private void dgvordenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                E_Ordenes.IdOrden = int.Parse(dgvordenes.CurrentRow.Cells[8].Value.ToString());
                Obj_orden.ConsultarOrdenxIdorden();
                if (E_Ordenes.IdOrden != 0)
                {
                    this.Close();
                    E_Ordenes.EditOrden = false;
                    principal.mostrarpanelorden = true;
                    principal.AbrirPanelOrden();
                    
                }
            }
            catch (Exception)
            {

                
            }
        }

        private void btnagregarordenrecepcion_Click(object sender, EventArgs e)
        {
            this.Close();
            Ordenes.frmabmordenrecepcion frmrecep = new Ordenes.frmabmordenrecepcion(principal );
            frmrecep.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frmrecep);
           
            E_Ordenes.IdOrden = 0;
            E_Ordenes.IdTipo = 1;
            E_Ordenes.EditOrden = false;
        }

        private void btnagregarordendevolucion_Click(object sender, EventArgs e)
        {
            this.Close();
            Ordenes.frmabmordendespachodevolucion frmdedev = new Ordenes.frmabmordendespachodevolucion(principal);
            frmdedev.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frmdedev);
            frmdedev.lbltituloform.Text = "AGREGAR ORDEN DE DEVOLUCION";

            E_Ordenes.IdOrden = 0;
            E_Ordenes.IdTipo = 3;
            E_Ordenes.EditOrden = false;
        }

        private void btnagregarordenproduccion_Click(object sender, EventArgs e)
        {

            this.Close();
            Ordenes.frmabmordendeproduccion frmprod = new Ordenes.frmabmordendeproduccion(principal);
            frmprod.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frmprod);
            frmprod.lbltituloform.Text = "AGREGAR ORDEN DE PRODUCCION";
            E_Ordenes.IdOrden = 0;
            E_Ordenes.IdTipo = 2;
            E_Ordenes.EditOrden = false;
        }

        private void btnagregarordenreproceso_Click(object sender, EventArgs e)
        {
            this.Close();
            Ordenes.frmabmordendeproduccion frmreprod = new Ordenes.frmabmordendeproduccion(principal);
            frmreprod.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frmreprod);
            frmreprod.lbltituloform.Text = "AGREGAR ORDEN DE REPROCESO";
            E_Ordenes.IdOrden = 0;
            E_Ordenes.IdTipo = 5;
            E_Ordenes.EditOrden = false;
        }

        private void btnagregarordendespacho_Click(object sender, EventArgs e)
        {
            this.Close();
            Ordenes.frmabmordendespachodevolucion frmdedev = new Ordenes.frmabmordendespachodevolucion(principal);
            frmdedev.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frmdedev);
            frmdedev.lbltituloform.Text = "AGREGAR ORDEN DE DESPACHO";
            E_Ordenes.IdOrden = 0;
            E_Ordenes.IdTipo = 4;
            E_Ordenes.EditOrden = false;
        }

       
    }
}
