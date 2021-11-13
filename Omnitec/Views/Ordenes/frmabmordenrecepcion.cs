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
    public partial class frmabmordenrecepcion : Form
    {
        M_Ordenes orden = new M_Ordenes();
        M_Cliente cli = new M_Cliente();
        M_Productos prod = new M_Productos();
        private WinTheme temaform = new WinTheme();
        private frmMenuPrincipal principal;

        public frmabmordenrecepcion(frmMenuPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void Inicializavariables()
        {
            E_Ordenes.IdCliente = 0;
            E_Ordenes.Cosecha = 0;
            E_Ordenes.IdGrano = 0;
            E_Ordenes.IdCosecha = 0;
            E_Ordenes.IdTipoProducto = 0;
        }

        private void frmabmordenrecepcion_Load(object sender, EventArgs e)
        {
            if (E_Ordenes.EditOrden == true && E_Ordenes.IdOrden !=0)
            {
                cmbcliente.Text = E_Ordenes.Cliente;
                cmbcliente.Enabled = false;
                txtchasis.Text = E_Ordenes.Chasis;
                txtcomprobante.Text = E_Ordenes.Comprobante;
                lblfecha.Text = E_Ordenes.Fecha.ToString("dd/MM/yyyy");
                txtacoplado.Text = E_Ordenes.Acoplado;
                if (E_Ordenes.IdTipoProducto == 1)
                {
                    rbtipoproductoconf.Checked = true;
                }
                if (E_Ordenes.IdTipoProducto == 2)
                {
                    rbtipoproductoindustria.Checked = true;
                }
                txtdnichofer.Text = E_Ordenes.DniChofer;
                txtchofer.Text = E_Ordenes.Chofer;
                txtkgnetos.Text = E_Ordenes.Kg.ToString();
                numericUpDowncant.Value = (long)E_Ordenes.Cant;
                txtobservacionesaltaorden.Text = E_Ordenes.Observaciones;
                cmbcosecha.Text = E_Ordenes.Cosecha.ToString();
                cmbgrano.Text = E_Ordenes.Grano;
                cmbcosecha.Enabled = false;
                cmbgrano.Enabled = false;
                btnanulareabreorden.Visible = true;
                if (E_Ordenes.IdStatusorden != 4)
                {
                    btnanulareabreorden.Text = "ANULAR";
                    btnanulareabreorden.BorderColor = Color.Red;
                } else
                {
                    btnanulareabreorden.Text = "REABRIR";
                    btnanulareabreorden.BorderColor = Color.LightGreen;
                }
                lbltituloform.Text = "ANULAR / MODIFICAR ORDEN DE RECEPCION";
            } else
            {
                lblfecha.Text = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).ToString("dd/MM/yyyy");
                cmbcliente.Enabled = true;
                cmbcosecha.Enabled = true;
                cmbgrano.Enabled = true;
                cmbcliente.DataSource = cli.comboclientes();
                cmbcliente.DisplayMember = "cliente";
                cmbcliente.ValueMember = "idcliente";
                cmbgrano.DataSource = prod.ComboGranos();
                cmbgrano.DisplayMember = "grano";
                cmbgrano.ValueMember = "idgrano";
                cmbcosecha.DataSource = prod.ComboCosechas();
                cmbcosecha.DisplayMember = "cosecha";
                cmbcosecha.ValueMember = "idcosecha";
                btnanulareabreorden.Visible = false;
                Inicializavariables();
                lbltituloform.Text = "AGREGAR ORDEN DE RECEPCION";
            }
            //Configuro el tema
            temaform.ElegirTema(UserLoginCache.Tema);
            panelsuperior.BackColor = temaform.PanelTitulo;
            panelcontenedorcabecera.BackColor = temaform.PanelInferior;
            panelcontenedordatostransporte .BackColor = temaform.PanelInferior;
            panelcontenedorgranos .BackColor = temaform.PanelInferior;
            lbltituloform.BackColor = temaform.PanelBotones;
            this.BackColor = temaform.PanelPadre;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            if (E_Ordenes.EditOrden ==false)
            {
                Ordenes.frmlistarordenes frmlistaorden = new Ordenes.frmlistarordenes(principal);
                frmlistaorden.FormClosed += new FormClosedEventHandler(principal.MostrarFormLogoAlCerrarForms);
                principal.AbrirFormEnPanel(frmlistaorden);
            }
        }

        private void btnanularorden_Click(object sender, EventArgs e)
        {
           
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

      

        private void cmbcliente_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                E_Ordenes.IdCliente = int.Parse(cmbcliente.SelectedValue.ToString());
                lbllote.Text = orden.ArmarLoteOrden();
            }
            catch (Exception)
            {


            }
        }

        private void cmbcosecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                E_Ordenes.IdCosecha = int.Parse(cmbcosecha.SelectedValue.ToString());
                E_Ordenes.Cosecha = int.Parse(cmbcosecha.Text);
                lbllote.Text = orden.ArmarLoteOrden();
            }
            catch (Exception)
            {


            }
        }

        private void cmbgrano_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                E_Ordenes.IdGrano = int.Parse(cmbgrano.SelectedValue.ToString());
                lbllote.Text = orden.ArmarLoteOrden();
            }
            catch (Exception)
            {


            }
        }

        private void rbtipoproductoconf_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtipoproductoconf.Checked == true)
                {
                    E_Producto.Tipoproducto = "CONFITERIA";
                    E_Ordenes.IdTipoProducto = prod.Checkidtipoproductoxtipo();
                    lbllote.Text = orden.ArmarLoteOrden();
                }

            }
            catch (Exception)
            {

            }
        }
        private void rbtipoproductoindustria_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtipoproductoindustria.Checked == true)
                {
                    E_Producto.Tipoproducto = "INDUSTRIA";
                    E_Ordenes.IdTipoProducto = prod.Checkidtipoproductoxtipo();
                    lbllote.Text = orden.ArmarLoteOrden();
                }

            }
            catch (Exception)
            {

            }
        }

        private void btnguardarcambiosorden_Click(object sender, EventArgs e)
        {
            BorrarMensajedeError();
            ValidarCampos();
            if (E_Ordenes.EditOrden == false && ValidarCampos()==true)
            {
                E_Ordenes.Fecha.ToString("dd - MM - yyyy");
                E_Ordenes.Fecha = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                E_Ordenes.Chasis = Regex.Replace(txtchasis.Text.ToUpper(), @"\s", "");
                E_Ordenes.Acoplado = Regex.Replace(txtacoplado.Text.ToUpper(), @"\s", "");
                E_Ordenes.DniChofer = txtdnichofer.Text;
                E_Ordenes.Chofer = txtchofer.Text;
                E_Ordenes.Comprobante = txtcomprobante.Text;
                E_Ordenes.Observaciones = txtobservacionesaltaorden.Text;
                E_Ordenes.Kg = double.Parse(txtkgnetos.Text);
                E_Ordenes.Cant = (double)numericUpDowncant.Value;
                orden.AgregarOrden();
                if (E_Ordenes.ErrorBD == false)
                {
                    MessageBox.Show("Se ha generado una nuava Orden de Recepcion", "Orden de Recepcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Al Generar la Orden, intentelo nuevamente", "Orden de Recepcion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (E_Ordenes.EditOrden == true && ValidarCampos() == true)
            {
                E_Ordenes.IdTipo = 1;
                E_Ordenes.Fecha = Convert.ToDateTime(lblfecha.Text);
                E_Ordenes.Chasis = Regex.Replace(txtchasis.Text.ToUpper(), @"\s", "");
                E_Ordenes.Acoplado = Regex.Replace(txtacoplado.Text.ToUpper(), @"\s", "");
                E_Ordenes.DniChofer = txtdnichofer.Text;
                E_Ordenes.Chofer = txtchofer.Text;
                E_Ordenes.Comprobante = txtcomprobante.Text;
                E_Ordenes.Observaciones = txtobservacionesaltaorden.Text;
                orden.ModificarOrden();
                if (E_Ordenes.ErrorBD == false)
                {
                    MessageBox.Show("La Orden ha sido Modificada", "Orden de Recepcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La Orden no ha sido Modificada, intentelo nuevamente", "Orden de Recepcion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private bool ValidarCampos()
        {
            bool ok = true;
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
            if (txtkgnetos.Text == "")
            {
                ok = false;
                errorProvider_camposform.SetError(txtkgnetos, "Debe Indicar valor para Kg");
            }
            if (rbtipoproductoconf.Checked == false && rbtipoproductoindustria.Checked == false)
            {
                ok = false;
                errorProvider_camposform.SetError(gbtipoprod, "Debe Indicar un tipo de Producto") ;
                lbllote.Text = "";
            }
            if (E_Ordenes.IdCliente==0)
            {
                E_Cliente.Cliente = cmbcliente.Text;
                E_Ordenes.IdCliente = cli.CheckidclientexCliente();
            }
            if (E_Ordenes.IdCosecha == 0)
            {
                E_Producto.Cosecha = Convert.ToInt32(cmbcosecha.Text);
                E_Ordenes.IdCosecha = prod.Checkcosechaxcosecha();
            }
            if (E_Ordenes.IdGrano == 0)
            {
                E_Producto.Grano = cmbgrano.Text;
                E_Ordenes.IdGrano = prod.Checkidgranoxgrano();
            }
            return ok;
        }
        
        private void BorrarMensajedeError()
        {
            errorProvider_camposform.SetError(txtdnichofer, "");
            errorProvider_camposform.SetError(txtcomprobante, "");
            errorProvider_camposform.SetError(txtkgnetos, "");
            errorProvider_camposform.SetError(gbtipoprod, "");
        }

        private void txtkgnetos_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(txtkgnetos.Text,out num))
            {
                errorProvider_camposform.SetError(txtkgnetos, "Debe Indicar valor correcto para Kg");
                txtkgnetos.Text = "";
            } else
            {
                errorProvider_camposform.SetError(txtkgnetos, "");
            }
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
