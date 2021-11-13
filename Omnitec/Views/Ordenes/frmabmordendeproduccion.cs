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
    public partial class frmabmordendeproduccion : Form
    {
        M_Ordenes orden = new M_Ordenes();
        M_Cliente cli = new M_Cliente();
        M_Productos prod = new M_Productos();
        private WinTheme temaform = new WinTheme();
        private frmMenuPrincipal principal;
        // variables locales
        int idcliente = 0;
        int cosecha = 0;
        int idcosecha;

        private void Inicializavariables()
        {
            prod.Checkcosechactual();
            idcosecha = E_Producto.Idcosecha;
            cosecha = E_Producto.Cosecha;
            E_Ordenes.IdCliente = 0;
            E_Ordenes.Cosecha = 0;
            E_Ordenes.IdGrano = 0;
            E_Ordenes.IdCosecha = 0;
            E_Ordenes.IdTipoProducto = 0;
            lblfecha.Text = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).ToString("dd/MM/yyyy");
            cmbcliente.Enabled = true;
            cmbcliente.DataSource = cli.comboclientesordenesactivas();
            cmbcliente.DisplayMember = "cliente";
            cmbcliente.ValueMember = "idcliente";
            btnanulareabreorden.Visible = false;
        }

        public frmabmordendeproduccion(frmMenuPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Ordenes.frmlistarordenes frmlistaorden = new Ordenes.frmlistarordenes(principal);
            frmlistaorden.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
            principal.AbrirFormEnPanel(frmlistaorden);
        }

        private void frmabmordendeproduccion_Load(object sender, EventArgs e)
        {
            try
            {
                if (E_Ordenes.EditOrden == true && E_Ordenes.IdOrden != 0)
                {
                    cmbcliente.Text = E_Ordenes.Cliente;
                    cmbcliente.Enabled = false;
                    lblfecha.Text = E_Ordenes.Fecha.ToString("dd/MM/yyyy");
                    txtobservacionesaltaorden.Text = E_Ordenes.Observaciones;
                    btnanulareabreorden.Visible = true;
                    if (E_Ordenes.IdStatusorden != 4)
                    {
                        btnanulareabreorden.Text = "ANULAR";
                        btnanulareabreorden.BorderColor = Color.Red;
                    }
                    else
                    {
                        btnanulareabreorden.Text = "REABRIR";
                        btnanulareabreorden.BorderColor = Color.LightGreen;
                    }
                }
                else
                {
                    Inicializavariables();
                }
                //Configuro el tema
                temaform.ElegirTema(UserLoginCache.Tema);
                panelsuperior.BackColor = temaform.PanelTitulo;
                panelcontenedorcabecera.BackColor = temaform.PanelInferior;
                lbltituloform.BackColor = temaform.PanelBotones;
                this.BackColor = temaform.PanelPadre;
            }
            catch (Exception)
            {
            }
        }

        private void cmbcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                idcliente = int.Parse(cmbcliente.SelectedValue.ToString());
                Cargargrilla();
            }
            catch (Exception)
            {


            }
        }

        private void Cargargrilla()
        {
            try
            {
                E_Ordenes.IdCliente = idcliente;
                if (E_Ordenes.EditOrden == false)
                {
                    if (E_Ordenes.IdTipo == 2)
                    {
                        E_Ordenes.IdTipoBusqueda = 1;
                    }
                    if (E_Ordenes.IdTipo == 5)
                    {
                        E_Ordenes.IdTipoBusqueda = 2;
                    }
                    dgvordenparasoc.DataSource = orden.Listaordenesabiertasparasocxcliente();
                    dgvordenparasoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvordenparasoc.Columns[6].Visible = false;
                    dgvordenparasoc.Columns[7].Visible = false;
                    dgvordenparasoc.Columns[8].Visible = false;

                    //armo el lote
                    E_Ordenes.IdCosecha = idcosecha;
                    E_Ordenes.Cosecha = cosecha;
                    E_Ordenes.IdGrano = 0;
                    E_Ordenes.IdTipoProducto = 0;
                    orden.ArmarLoteOrden();
                    lblote.Text = E_Ordenes.Lote;
                }
                else
                {
                    dgvordenparasoc.DataSource = orden.Listaordenesasocxidorden();
                    dgvordenparasoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception)
            {


            }
        }

        
        private void btnguardarcambiosorden_Click(object sender, EventArgs e)
        {
            if (E_Ordenes.EditOrden == false)
            {
                E_Ordenes.Fecha = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                E_Ordenes.IdCosecha = idcosecha;
                E_Ordenes.IdTipoProducto = 0;
                E_Ordenes.IdGrano = 0;
                E_Ordenes.Observaciones = txtobservacionesaltaorden.Text;
                E_Ordenes.IdOrden = orden.AltadeOrden();
                if (E_Ordenes.IdOrden != 0)
                {
                    bool asoc;
                    int pos = 0;
                    int cantfilas = dgvordenparasoc.RowCount - 1;
                    foreach (DataGridViewRow row in dgvordenparasoc.Rows) //filas
                    {
                        try
                        {
                            if (cantfilas > 0)
                            {
                                asoc = (bool)row.Cells["Asociar"].Value;

                                if (asoc == true)
                                {
                                    E_Ordenes.IdOrdenasoc = (int)row.Cells["idorden"].Value;
                                    E_Ordenes.Cant = (int)row.Cells["cant"].Value;
                                    orden.AsocOrden();
                                    asoc = false;
                                    pos++;
                                }
                                cantfilas--;
                            }

                            
                        }
                        catch (System.NullReferenceException)
                        {

                        }

                    }
                    orden.ConsultarOrdenxIdorden();
                    if (E_Ordenes.IdOrden != 0)
                    {
                        this.Close();
                        principal.mostrarpanelorden = true;
                        principal.AbrirPanelOrden();

                    }
                }
                else
                {

                }

            }
            else
            {

            }
        }

        
    }
}
