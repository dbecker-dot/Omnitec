using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;
using CapaDatos.Services;
using CapaEntidades.Cache;

namespace Omnitec.Views.Ordenes
{
    public partial class frmabmordendespachodevolucion : Form
    {
        M_Ordenes orden = new M_Ordenes();
        M_Cliente cli = new M_Cliente();
        M_Productos prod = new M_Productos();
        private WinTheme temaform = new WinTheme();
        private frmMenuPrincipal principal;

        private void Inicializavariables()
        {
            prod.Checkcosechactual();
            E_Ordenes.IdCliente = 0;
            E_Ordenes.Cosecha = E_Producto.Cosecha;
            E_Ordenes.IdGrano = 0;
            E_Ordenes.IdCosecha = E_Producto.Idcosecha ;
            E_Ordenes.IdTipoProducto = 0;
            lblfecha.Text = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).ToString("dd/MM/yyyy");
            cmbcliente.Enabled = true;
            cmbcliente.DataSource = cli.comboclientesordenesactivas();
            cmbcliente.DisplayMember = "cliente";
            cmbcliente.ValueMember = "idcliente";
            btnanulareabreorden.Visible = false;
            if (E_Ordenes.IdTipo == 3)
            {
                lbltituloform.Text = "AGREGAR ORDEN DE DEVOLUCION";
            }
            if (E_Ordenes.IdTipo == 4)
            {
                lbltituloform.Text = "AGREGAR ORDEN DE DESPACHO";
            }
        }

        public frmabmordendespachodevolucion(frmMenuPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            if (E_Ordenes.EditOrden == false) 
            { 
                Ordenes.frmlistarordenes frmlistaorden = new Ordenes.frmlistarordenes(principal);
                frmlistaorden.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
                principal.AbrirFormEnPanel(frmlistaorden);
            } else
            {

            }
        }

        private void frmabmordendespachodevolucion_Load(object sender, EventArgs e)
        {
            if (E_Ordenes.EditOrden == true && E_Ordenes.IdOrden != 0)
            {
                cmbcliente.Text = E_Ordenes.Cliente;
                cmbcliente.Enabled = false;
                txtchasis.Text = E_Ordenes.Chasis;
                txtcomprobante.Text = E_Ordenes.Comprobante;
                lblfecha.Text = E_Ordenes.Fecha.ToString("dd/MM/yyyy");
                txtacoplado.Text = E_Ordenes.Acoplado;
                txtdnichofer.Text = E_Ordenes.DniChofer;
                txtchofer.Text = E_Ordenes.Chofer;
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
                if (E_Ordenes.IdTipo == 3)
                {
                    lbltituloform.Text = "ANULAR / MODIFICAR ORDEN DE DEVOLUCION";
                }
                if (E_Ordenes.IdTipo == 4)
                {
                    lbltituloform.Text = "ANULAR / MODIFICAR ORDEN DE DESPACHO";
                }
                Cargargrilla();
            } else
            {
                Inicializavariables();
            }
            //Configuro el tema
            temaform.ElegirTema(UserLoginCache.Tema);
            panelsuperior.BackColor = temaform.PanelTitulo;
            panelcontenedorcabecera.BackColor = temaform.PanelInferior;
            panelcontenedordatostransporte.BackColor = temaform.PanelInferior;
            lbltituloform.BackColor = temaform.PanelBotones;
            this.BackColor = temaform.PanelPadre;
        }

        private void cmbcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                E_Ordenes.IdCliente = int.Parse(cmbcliente.SelectedValue.ToString());
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
                if (E_Ordenes.EditOrden == false)
                {
                    if (E_Ordenes.IdTipo == 3)
                    {
                        E_Ordenes.IdTipoBusqueda = 1;
                    }
                    if (E_Ordenes.IdTipo == 4)
                    {
                        E_Ordenes.IdTipoBusqueda = 2;
                    }
                    dgvordenparasoc.DataSource = orden.Listaordenesabiertasparasocxcliente();
                    dgvordenparasoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void txtdnichofer_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Return))
                {
                    if (txtdnichofer.Text == "")
                    {
                        MessageBox.Show("Coloque un DNI", "Alta de Ordenes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        E_Ordenes.DniChofer = txtdnichofer.Text;
                        cmbchasis.DataSource = orden.ComboChasis();
                        cmbchasis.DisplayMember = "chasis";
                        cmbchasis.ValueMember = "dnichofer";
                        cmbacoplado.DataSource = orden.ComboAcoplado();
                        cmbacoplado.DisplayMember = "acoplado";
                        cmbacoplado.ValueMember = "dnichofer";
                        txtchofer.Text = orden.Buscarchoferxdni();
                        if (orden.Buscarchoferxdni() == "")
                        {
                            txtchofer.Enabled = false;
                        }
                        else
                        {
                            txtchofer.Enabled = true;
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                string msj = ex.Message;
            }
        }


        private void cmbchasis_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtchasis.Text = cmbchasis.Text;
            }
            catch (Exception)
            {


            }
        }

        

        private void cmbacoplado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtacoplado.Text = cmbacoplado.Text;
            }
            catch (Exception)
            {


            }
        }

        private void btnguardarcambiosorden_Click(object sender, EventArgs e)
        {
            if (E_Ordenes.EditOrden == false)
            {


                try
                {
                    BorrarMensajedeError();
                    ValidarCampos();
                    if (E_Ordenes.EditOrden == false && ValidarCampos() == true)
                    {
                        E_Ordenes.Fecha = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                        E_Ordenes.IdTipoProducto = 0;
                        E_Ordenes.IdGrano = 0;
                        E_Ordenes.Observaciones = txtobservacionesaltaorden.Text;
                        E_Ordenes.Chasis = Regex.Replace(txtchasis.Text.ToUpper(), @"\s", "");
                        E_Ordenes.Acoplado = Regex.Replace(txtacoplado.Text.ToUpper(), @"\s", "");
                        E_Ordenes.DniChofer = txtdnichofer.Text;
                        E_Ordenes.Chofer = txtchofer.Text;
                        E_Ordenes.Comprobante = txtcomprobante.Text;
                        //armo el lote
                        E_Ordenes.IdGrano = 0;
                        E_Ordenes.IdTipoProducto = 0;
                        orden.ArmarLoteOrden();
                        E_Ordenes.Lote = "";
                        E_Ordenes.IdOrden = orden.AltadeOrden();
                        if (E_Ordenes.IdOrden != 0)
                        {

                            //cargo el array con las ordenes asociadas
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


                    }
                }
                catch (Exception)
                {
                    string error = "";
                }
            } else
            {

            }
        }

        private bool ValidarCampos()
        {
            string ano =   DateTime.Now.Year.ToString();
            int cosecha = int.Parse(ano.Substring(2,2));
            bool ok = true;
            E_Ordenes.Lote = "";
            E_Ordenes.IdTipoProducto = 0;
            E_Ordenes.IdGrano = 0;
            if (txtdnichofer.Text == "")
            {
                ok = false;
                errorProvider_camposform.SetError(txtdnichofer, "Debe Indicar un DNI");
            }
            if (txtcomprobante.Text == "")
            {
                ok = false;
                errorProvider_camposform.SetError(txtcomprobante, "Debe Indicar un Comprobante");
            }
            
            
            if (E_Ordenes.IdCliente == 0)
            {
                E_Cliente.Cliente = cmbcliente.Text;
                E_Ordenes.IdCliente = cli.CheckidclientexCliente();
            }
            if (E_Ordenes.IdCosecha == 0)
            {
                E_Producto.Cosecha = cosecha;
                E_Ordenes.IdCosecha = prod.Checkcosechaxcosecha();
            }
            
            return ok;
        }

        private void BorrarMensajedeError()
        {
            errorProvider_camposform.SetError(txtdnichofer, "");
            errorProvider_camposform.SetError(txtcomprobante, "");
        }

        private void btnanulareabreorden_Click(object sender, EventArgs e)
        {
            try
            {
                E_Ordenes.IdUsuario = E_Usuario.Idusuario;
                if (E_Ordenes.IdStatusorden != 4)
                {
                    orden.AnularOrden();
                    if (E_Ordenes.ErrorBD == false)
                    {
                        MessageBox.Show("La Orden ha sido anulada", "Orden de Recepcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("La Orden no ha sido anulada", "Orden de Recepcion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    orden.ReabrirOrden();
                    if (E_Ordenes.ErrorBD == false)
                    {
                        MessageBox.Show("La Orden ha sido reabierta", "Orden de Recepcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("La Orden no ha sido reabierta, intentelo nuevamente", "Orden de Recepcion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error", "Orden de Recepcion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
    }
}
