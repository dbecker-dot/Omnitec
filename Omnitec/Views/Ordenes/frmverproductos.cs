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
using System.Drawing.Printing;

namespace Omnitec.Views.Ordenes
{
    public partial class frmverproductos : Form
    {
        string codtp;
        private WinTheme temaform = new WinTheme();
        M_Ordenes obj_orden = new M_Ordenes();
        M_Productos  obj_prod = new M_Productos();
        M_Cliente  obj_cli = new M_Cliente();
        private frmMenuPrincipal principal;

        public frmverproductos(frmMenuPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

       

        private void frmverproductos_Load(object sender, EventArgs e)
        {
            cargarproductosdelaorden();
            dtpfeingstk.Value = E_Ordenes.Fecha;
            switch (E_Ordenes.IdTipo)
            {
                case 1:
                    gbtipoproducto.Enabled = false;
                    gbgrano.Enabled = false;
                    if (E_Ordenes.IdTipoProducto == 2)
                    {
                        rbtipogranoindustria.Checked = true;
                        cmbgrano.Text = E_Ordenes.Grano;
                    }
                    break;
                case 2:
                    gbtipoproducto.Enabled = true;
                    gbgrano.Enabled = true;
                    rbtipogranoblanchado.Checked = false;
                    rbtipogranorechazoseleccion .Checked = false;
                    rbtipogranoindustria.Checked = false;
                    break;
                case 5:
                    gbtipoproducto.Enabled = true;
                    gbgrano.Enabled = true;
                    rbtipogranoblanchado.Checked = false;
                    rbtipogranorechazoseleccion.Checked = false;
                    rbtipogranoindustria.Checked = false;
                    break;
            }
            cmbgrano.DataSource = obj_prod.ComboGranos();
            cmbgrano.DisplayMember = "grano";
            cmbgrano.ValueMember = "idgrano";
        }

        private void cargarproductosdelaorden()
        {
            try
            {
                DataTable data = new DataTable();
                data = obj_orden.Listaproductosxidorden();
                dgvproductosordenes.DataSource = data;
                dgvproductosordenes.Columns[7].Visible  = false;
                dgvproductosordenes.Columns[9].Visible = false;
                dgvproductosordenes.Columns[10].Visible = false;
                dgvproductosordenes.Columns[11].Visible = false;
                dgvproductosordenes.Columns[12].Visible = false;
            }
            catch (Exception)
            {


            }
        }

        private void btnMenuizquierdo_Click(object sender, EventArgs e)
        {
            if (panelmenulateralizquierdo.Width == 55)
            {
               panelmenulateralizquierdo .Width = 400;
            }
            else
            {
                panelmenulateralizquierdo.Width = 55;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            principal.mostrarpanelorden = true;
            principal.AbrirPanelOrden();
        }

        private void btnagregarproducto_Click(object sender, EventArgs e)
        {
            try
            {
                switch (E_Ordenes.IdTipo)
                {
                    case 2:
                        obj_prod.Checkcosechactual();
                        E_Ordenes.IdCosecha = E_Producto.Idcosecha;
                        E_Ordenes.Cosecha = E_Producto.Cosecha;
                        E_Producto.Idgrano = E_Ordenes.IdGrano;
                        E_Cliente.Idcliente = E_Ordenes.IdCliente;
                        E_Ordenes.CodigoProd = E_Ordenes.Cosecha + obj_prod.Checkcodgranoxidgrano() + E_Ordenes.Nro + codtp + obj_cli.CheckcodclientexIdcliente ();
                        break;
                    case 5:
                        obj_prod.Checkcosechactual();
                        E_Ordenes.IdCosecha = E_Producto.Idcosecha;
                        E_Ordenes.Cosecha = E_Producto.Cosecha;
                        E_Producto.Idgrano = E_Ordenes.IdGrano;
                        E_Cliente.Idcliente = E_Ordenes.IdCliente;
                        E_Ordenes.CodigoProd = E_Ordenes.Cosecha + obj_prod.Checkcodgranoxidgrano() + E_Ordenes.Nro + codtp + obj_cli.CheckcodclientexIdcliente();
                        break;
                }

                if (lblgrano.Text =="" || E_Ordenes.IdGrano == 0)
                {
                    MessageBox.Show("Seleccione un grano", "Alta de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    return;
                }
                if (E_Ordenes.IdTipo == 2 || E_Ordenes.IdTipo == 5)
                {
                    if (rbtipogranoblanchado.Checked == false && rbtipogranorechazoseleccion.Checked == false && rbtipogranoindustria.Checked == false && E_Ordenes.IdTipoProducto == 0)
                    {
                        MessageBox.Show("Seleccione un tipo de producto", "Alta de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (txtkgprod .Text == "" || txtkgprod.Text =="0")
                {
                    MessageBox.Show("Los Kg deben ser un numero mayor a cero", "Alta de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } else
                {
                    E_Ordenes.Fechaingstk = dtpfeingstk.Value;
                    E_Ordenes.KgxBulto = Convert.ToDouble(txtkgprod.Text);
                    obj_orden.AgregarProducto();
                    obj_orden.ConsultarOrdenxIdorden();
                    cargarproductosdelaorden();
                    rbtipogranoblanchado.Checked = false;
                    rbtipogranorechazoseleccion.Checked = false;
                    rbtipogranoindustria.Checked = false;
                    lblgrano.Text = "";
                }
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
                lblgrano .Text = cmbgrano.Text ;
            }
            catch (Exception)
            {


            }
        }

        private void rbtipogranoblanchado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtipogranoblanchado .Checked == true)
            {
                E_Ordenes.IdTipoProducto = 3;
                codtp = "BL";
            }
        }

        private void rbtipogranorechazoseleccion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtipogranorechazoseleccion.Checked == true)
            {
                E_Ordenes.IdTipoProducto = 4;
                codtp = "RS";
            }
        }

        private void rbtipogranoindustria_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtipogranoindustria.Checked == true)
            {
                E_Ordenes.IdTipoProducto = 2;
                codtp = "IN";
            }
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.DefaultPageSettings.Landscape = true;
            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            doc.DefaultPageSettings.Margins.Left = 5;
            doc.DefaultPageSettings.Margins.Right  = 5;
            PrintPreviewDialog ppd = new PrintPreviewDialog { Document = doc };
            ((Form)ppd).WindowState = FormWindowState.Maximized;

            doc.PrintPage += delegate (object ev, PrintPageEventArgs ep)
            {
                
                const int DGV_ALTO = 35;
                int left = ep.MarginBounds.Left, top = ep.MarginBounds.Top;
                int filasxpagina= (int)E_Ordenes.Cant;

                if (filasxpagina >= 16)
                {
                    ep.HasMorePages = true;
                }
                else
                {
                    ep.HasMorePages = false;
                }

                //imprimo logo
                ep.Graphics.DrawImage(pictureBoxlogo.Image, new RectangleF(5,5, 50, 50));
                ep.Graphics.DrawString("CLIENTE: " + E_Ordenes.Cliente, new Font("Segoe UI", 16, FontStyle.Bold), Brushes.Black, left + 85, 5);
                ep.Graphics.DrawString("TIPO DE ORDEN: " + E_Ordenes.Tipo, new Font("Segoe UI", 16, FontStyle.Bold), Brushes.Black, left + 550, 5);
                ep.Graphics.DrawString(lblote.Text , new Font("Segoe UI", 16, FontStyle.Bold), Brushes.Black, left + 85, 25);
                ep.Graphics.DrawString("CANT: " + E_Ordenes.Cant, new Font("Segoe UI", 16, FontStyle.Bold), Brushes.Black, left + 350, 25);
                ep.Graphics.DrawString("KG: " + E_Ordenes.Kg, new Font("Segoe UI", 16, FontStyle.Bold), Brushes.Black, left + 450, 25);
                //imprimo columas de la grilla
                left = ep.MarginBounds.Left;
                ep.Graphics.FillRectangle(Brushes.Black, left, top , ep.MarginBounds.Right, 3);
                ep.Graphics.FillRectangle(Brushes.Black, left, top + 40, ep.MarginBounds.Right , 3);
                ep.Graphics.DrawString("#", new Font("Segoe UI", 16, FontStyle.Bold), Brushes.DeepSkyBlue, left, top);
                ep.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top + 43);
                left += 50;
                ep.Graphics.DrawString("Grano", new Font("Segoe UI", 16, FontStyle.Bold), Brushes.DeepSkyBlue, left, top);
                ep.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top + 43);
                left += 120;
                ep.Graphics.DrawString("Tipo", new Font("Segoe UI", 16, FontStyle.Bold), Brushes.DeepSkyBlue, left, top);
                ep.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top + 43);
                left += 220;
                ep.Graphics.DrawString("Producto", new Font("Segoe UI", 16, FontStyle.Bold), Brushes.DeepSkyBlue, left, top);
                ep.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top + 43);
                left += 220;
                ep.Graphics.DrawString("Estado", new Font("Segoe UI", 16, FontStyle.Bold), Brushes.DeepSkyBlue, left, top);
                ep.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top + 43);
                left += 220;
                ep.Graphics.DrawString("Kg", new Font("Segoe UI", 16, FontStyle.Bold), Brushes.DeepSkyBlue, left, top);
                ep.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top + 43);
                left += 120;
                ep.Graphics.DrawString("Ubicacion", new Font("Segoe UI", 16, FontStyle.Bold), Brushes.DeepSkyBlue, left, top);
                ep.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top + 43);
                left = 5;
                top += 43;
                filasxpagina = 1;
                if (dgvproductosordenes.RowCount > 0)
                {
                    foreach (DataGridViewRow row in dgvproductosordenes.Rows)
                    {
                        if (row.Index == dgvproductosordenes.RowCount ) break;
                        ep.Graphics.DrawString(Convert.ToString(filasxpagina), new Font("Segoe UI", 13), Brushes.Black, left, top);
                        ep.Graphics.DrawLine(Pens.Gray, left - 5, top + 43, left - 5, top);
                        left += 50;
                        ep.Graphics.DrawString(Convert.ToString(row.Cells["grano"].Value), new Font("Segoe UI", 13), Brushes.Black, left, top);
                        ep.Graphics.DrawLine(Pens.Gray, left - 5, top+43, left - 5, top );
                        left += 120;
                        ep.Graphics.DrawString(Convert.ToString(row.Cells["tipoproducto"].Value), new Font("Segoe UI", 13), Brushes.Black, left, top);
                        ep.Graphics.DrawLine(Pens.Gray, left - 5, top + 43, left - 5, top+43);
                        left += 220;
                        ep.Graphics.DrawString(Convert.ToString(row.Cells["codigo"].Value), new Font("Segoe UI", 13), Brushes.Black, left, top);
                        ep.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top+43);
                        left += 220;
                        ep.Graphics.DrawString(Convert.ToString(row.Cells["estadoprod"].Value), new Font("Segoe UI", 13), Brushes.Black, left, top);
                        ep.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top);
                        left += 220;
                        ep.Graphics.DrawString(Convert.ToString(row.Cells["kg"].Value), new Font("Segoe UI", 13), Brushes.Black, left, top);
                        ep.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top);
                        left += 120;
                        ep.Graphics.DrawString(Convert.ToString(row.Cells["ubicacion"].Value), new Font("Segoe UI", 13), Brushes.Black, left, top);
                        ep.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top);
                        left = 5;
                        top += 43;
                        filasxpagina += 1;
                       
                    }
                }
                
                return;
                foreach (DataGridViewColumn col in dgvproductosordenes.Columns)
                {
                    if (col.Visible == true)
                    {
                        ep.Graphics.DrawString("Grano", new Font("Segoe UI", 16, FontStyle.Bold), Brushes.DeepSkyBlue, left, top);

                        ep.Graphics.DrawString(col.HeaderText, new Font("Segoe UI", 16, FontStyle.Bold), Brushes.DeepSkyBlue, left, top);
                        left += col.Width;

                        if (col.Index < dgvproductosordenes.ColumnCount - 1)
                            ep.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top + 43 + (dgvproductosordenes.RowCount - 1) * DGV_ALTO);
                    }
                }
                left = ep.MarginBounds.Left;
                ep.Graphics.FillRectangle(Brushes.Black, left, top + 40, ep.MarginBounds.Right - left, 3);
                top += 43;

                foreach (DataGridViewRow row in dgvproductosordenes.Rows)
                {
                    if (row.Index == dgvproductosordenes.RowCount - 1) break;
                    left = ep.MarginBounds.Left;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Visible == true)
                        {
                            ep.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Segoe UI", 13), Brushes.Black, left, top + 4);
                            //agrega el ancho de la columna
                            //left += cell.OwningColumn.Width;

                        }
                    }
                    top += DGV_ALTO;
                    ep.Graphics.DrawLine(Pens.Gray, ep.MarginBounds.Left, top, ep.MarginBounds.Right, top);
                }
            };
            ppd.ShowDialog();
        }
    }
}
