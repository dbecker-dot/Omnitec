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
    public partial class frmetiquetasproductos : Form
    {
        private WinTheme temaform = new WinTheme();
        M_Ordenes obj_orden = new M_Ordenes();
        M_Depositos obj_dep = new M_Depositos();
        private frmMenuPrincipal principal;
        int indice,i=0;
        string codigo;
        DateTime fecha;
        bool imprimetodas;
        public frmetiquetasproductos(frmMenuPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void frmetiquetasproductos_Load(object sender, EventArgs e)
        {
            CargarGrillas();
            indice=-1;

            if (IsTheSameCellValue(0, indice) && dgvetiquetas.RowCount>0)
            {
                return;
            }
        }

        private void CargarGrillas()
        {
            try
            {
                dgvetiquetas.DataSource = obj_orden.Listaetiquetasproductosxidorden();
            }
            catch (Exception)
            {

                throw;
            }
            
           
        }


        bool IsTheSameCellValue(int column, int row)
        {
            try
            {
                indice = row;
                DataGridViewCell cell1 = dgvetiquetas[column, row];
                DataGridViewCell cell2 = dgvetiquetas[column, row - 1];
                if (cell1.Value == null || cell2.Value == null)
                {
                    //indice = -1;
                    indice = 0;
                    //anterior = 0;
                    fecha = (DateTime)dgvetiquetas.Rows[indice].Cells["ingreso"].Value;
                    lblfeingreso.Text = fecha.ToString("dd/MM/yyyy");
                    lblcliente.Text = (string)dgvetiquetas.Rows[indice].Cells["cliente"].Value;
                    lblgrano.Text = (string)dgvetiquetas.Rows[indice].Cells["grano"].Value;
                    lbltipoproducto.Text = (string)dgvetiquetas.Rows[indice].Cells["tipoproducto"].Value;
                    lblkg.Text = dgvetiquetas.Rows[indice].Cells["kg"].Value.ToString();
                    lblcodigo.Text = (string)dgvetiquetas.Rows[indice].Cells["codigo"].Value;
                    codigo = (string)dgvetiquetas.Rows[indice].Cells["codigo"].Value;
                    pb_etiqueta.Image = obj_dep.GeneraQR(codigo, 12);
                    return true ;
                }
                else
                {
                    fecha = (DateTime)dgvetiquetas.Rows[indice].Cells["ingreso"].Value;
                    lblfeingreso.Text = fecha.ToString("dd/MM/yyyy");
                    lblcliente.Text = (string)dgvetiquetas.Rows[indice].Cells["cliente"].Value;
                    lblgrano.Text = (string)dgvetiquetas.Rows[indice].Cells["grano"].Value;
                    lbltipoproducto.Text = (string)dgvetiquetas.Rows[indice].Cells["tipoproducto"].Value;
                    lblkg.Text = dgvetiquetas.Rows[indice].Cells["kg"].Value.ToString();
                    lblcodigo.Text = (string)dgvetiquetas.Rows[indice].Cells["codigo"].Value;
                    codigo = (string)dgvetiquetas.Rows[indice].Cells["codigo"].Value;
                    pb_etiqueta.Image = obj_dep.GeneraQR(codigo, 12);
                    return true;
                }
            }
            catch (Exception)
            {
                indice = 0;
                //anterior = 0;
                fecha = (DateTime)dgvetiquetas.Rows[indice].Cells["ingreso"].Value;
                lblfeingreso.Text = fecha.ToString("dd/MM/yyyy");
                lblcliente.Text = (string)dgvetiquetas.Rows[indice].Cells["cliente"].Value;
                lblgrano.Text = (string)dgvetiquetas.Rows[indice].Cells["grano"].Value;
                lbltipoproducto.Text = (string)dgvetiquetas.Rows[indice].Cells["tipoproducto"].Value;
                lblkg.Text = dgvetiquetas.Rows[indice].Cells["kg"].Value.ToString();
                lblcodigo.Text = (string)dgvetiquetas.Rows[indice].Cells["codigo"].Value;
                codigo = (string)dgvetiquetas.Rows[indice].Cells["codigo"].Value;
                pb_etiqueta.Image = obj_dep.GeneraQR(codigo, 12);
                return false;
            }
          //return cell1.Value.ToString() == cell2.Value.ToString();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            
            int anterior = indice;

            if (IsTheSameCellValue(0, anterior))
            {
                indice=anterior-1;
                //btnAnterior_Click(sender, e);
            }
            return;
            
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int siguiente = indice;
            if (IsTheSameCellValue(0, siguiente))
            {
                indice=siguiente+1;
                //btnSiguiente_Click(sender, e);
            } else
            {
                if (indice == 0)
                {
                    indice = siguiente + 1;
                }
            }
            return;
        }

        

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            principal.mostrarpanelorden = true;
            principal.AbrirPanelOrden();
        }

        private void btnimprimiretiqueta_Click(object sender, EventArgs e)
        {
            printDocument_etiquetas = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument_etiquetas.PrinterSettings = ps;
            printDocument_etiquetas.PrintPage += imprimir;
            printPreviewDialog_etiquetas.Document = printDocument_etiquetas;
            printPreviewDialog_etiquetas.ShowDialog();
            imprimetodas = false;
            //printDocument_etiquetas.Print();
        }

        private void btnimprimirtodasetiqueta_Click(object sender, EventArgs e)
        {
            printDocument_etiquetas = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument_etiquetas.PrinterSettings = ps;
            printDocument_etiquetas.PrintPage += imprimir;
            printPreviewDialog_etiquetas.Document = printDocument_etiquetas;
            printPreviewDialog_etiquetas.ShowDialog();
            imprimetodas = true;
            i = 0;
        }

        private void imprimir(object sender, PrintPageEventArgs e)
        {
            Pen Lapiz = new Pen(System.Drawing.Color.Black);
            Font fuente = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);
            try
            {
                if (imprimetodas == false)
                {
                    e.Graphics.DrawRectangle(Lapiz, 9, 24, 350, 350);
                    e.Graphics.DrawString("PAF SA", fuente, Brushes.Black, new RectangleF(10, 30, 200, 20));
                    e.Graphics.DrawImage(pb_etiqueta.Image, new RectangleF(50, 50, 200, 200));
                    codigo = lblcodigo.Text ;
                    //e.Graphics.DrawImage(obj_dep.GeneraQR(codigo, 2), new RectangleF(0, 25, 200, 200));
                    e.Graphics.DrawString(lblcliente.Text , fuente, Brushes.Black, new RectangleF(10, 240, 330, 20));
                    e.Graphics.DrawString(lblgrano.Text, fuente, Brushes.Black, new RectangleF(10, 260, 200, 20));
                    e.Graphics.DrawString(lbltipoproducto.Text , fuente, Brushes.Black, new RectangleF(10, 280, 330, 20));
                    e.Graphics.DrawString(lblkg.Text + "Kg", fuente, Brushes.Black, new RectangleF(10, 300, 300, 20));
                    e.Graphics.DrawString(codigo, fuente, Brushes.Black, new RectangleF(10, 320,300, 20));
                }
                else
                {
                    string cliente,grano,tipoproducto,kg="";
                    if (i == dgvetiquetas.RowCount - 1)
                    {
                        i = -1;
                        //e.HasMorePages = false;
                        //break;
                    }
                    while (i <= dgvetiquetas.RowCount - 1)
                    {
                        cliente = (string)dgvetiquetas.Rows[i].Cells["cliente"].Value;
                        grano = (string)dgvetiquetas.Rows[i].Cells["grano"].Value;
                        tipoproducto = (string)dgvetiquetas.Rows[i].Cells["tipoproducto"].Value;
                        kg = dgvetiquetas.Rows[i].Cells["kg"].Value.ToString();
                        codigo = (string)dgvetiquetas.Rows[i].Cells["codigo"].Value;
                        e.Graphics.DrawRectangle(Lapiz, 9, 24, 350, 350);
                        e.Graphics.DrawString("PAF SA", fuente, Brushes.Black, new RectangleF(10, 30, 200, 20));
                        e.Graphics.DrawImage(pb_etiqueta.Image, new RectangleF(50, 50, 200, 200));
                        
                        //e.Graphics.DrawImage(obj_dep.GeneraQR(codigo, 2), new RectangleF(0, 25, 200, 200));
                        e.Graphics.DrawString(cliente, fuente, Brushes.Black, new RectangleF(10, 240, 330, 20));
                        e.Graphics.DrawString(grano, fuente, Brushes.Black, new RectangleF(10, 260, 200, 20));
                        e.Graphics.DrawString(tipoproducto, fuente, Brushes.Black, new RectangleF(10, 280, 330, 20));
                        e.Graphics.DrawString(kg + "Kg", fuente, Brushes.Black, new RectangleF(10, 300, 300, 20));
                        e.Graphics.DrawString(codigo, fuente, Brushes.Black, new RectangleF(10, 320, 300, 20));
                        break;
                    }
                    
                    if (i >= 0)
                    {
                        i = i + 1;
                        e.HasMorePages = true;
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }
                    return;
                    foreach (DataGridViewRow row in dgvetiquetas.Rows)
                    {
                        if (row.Index == dgvetiquetas.RowCount - 1)
                        {
                            i = -1;
                            //e.HasMorePages = false;
                            //break;
                        }
                        if (i >= 0)
                        {
                            cliente = (string)dgvetiquetas.Rows[i].Cells["cliente"].Value;
                            grano = (string)dgvetiquetas.Rows[i].Cells["grano"].Value;
                            tipoproducto = (string)dgvetiquetas.Rows[i].Cells["tipoproducto"].Value;
                            kg = dgvetiquetas.Rows[i].Cells["kg"].Value.ToString();
                            codigo = (string)dgvetiquetas.Rows[i].Cells["codigo"].Value;
                            e.Graphics.DrawRectangle(Lapiz, 9, 24, 350, 350);
                            e.Graphics.DrawString("PAF SA", fuente, Brushes.Black, new RectangleF(10, 30, 200, 20));
                            e.Graphics.DrawImage(pb_etiqueta.Image, new RectangleF(50, 50, 200, 200));
                            codigo = lblcodigo.Text;
                            //e.Graphics.DrawImage(obj_dep.GeneraQR(codigo, 2), new RectangleF(0, 25, 200, 200));
                            e.Graphics.DrawString(cliente, fuente, Brushes.Black, new RectangleF(10, 240, 330, 20));
                            e.Graphics.DrawString(grano, fuente, Brushes.Black, new RectangleF(10, 260, 200, 20));
                            e.Graphics.DrawString(tipoproducto, fuente, Brushes.Black, new RectangleF(10, 280, 330, 20));
                            e.Graphics.DrawString(kg + "Kg", fuente, Brushes.Black, new RectangleF(10, 300, 300, 20));
                            e.Graphics.DrawString(codigo, fuente, Brushes.Black, new RectangleF(10, 320, 300, 20));
                            i = i + 1;
                        }
                        if (i > 0)
                        {
                            i = i + 1;
                            e.HasMorePages = true;
                        } else
                        {
                            e.HasMorePages = false;
                        }
                        
                       
                        
                    }
                        
                }
            }
            catch (Exception)
            {
                return ;
            }
            

        }

       
    }
}
