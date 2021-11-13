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
using System.Drawing.Printing;

namespace Omnitec.Views.Depositos
{
    public partial class frmetiquetasubicaciones : Form
    {
        M_Depositos dep = new M_Depositos();
        public frmetiquetasubicaciones()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmetiquetasubicaciones_Load(object sender, EventArgs e)
        {
            try
            {
                cmbdepoetiquetas.DataSource = dep.combodepositos();
                cmbdepoetiquetas.DisplayMember = "deposito";
                cmbdepoetiquetas.ValueMember = "ideposito";
                E_Deposito.Ideposito = 1;
                lblselectdepet.Texts = "CRUDO";
                CargarGrillas();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CargarGrillas()
        {
            if (E_Deposito.Ideposito >= 1)
            {
                dgvetiquetas.DataSource = dep.ListarUbicacionesxDepositosparaetiquetas();
                dgvetiquetas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (dgvetiquetas.RowCount > 0)
                {
                    string codigo;
                    foreach (DataGridViewRow row in dgvetiquetas.Rows) //filas
                    {
                        try
                        {
                            codigo = (string)row.Cells["ubicacion"].Value;
                            row.Cells["QR"].Value = dep.GeneraQR(codigo,2);
                        }
                        catch (System.NullReferenceException)
                        {

                            row.Cells["QR"].Value = null;
                        }
                    }

                }
            }
        }

        private void cmbdepoetiquetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblselectdepet.Texts = cmbdepoetiquetas.Text;
                E_Deposito.Ideposito = int.Parse(cmbdepoetiquetas.SelectedValue.ToString());
                CargarGrillas();

            }
            catch (Exception)
            {


            }
        }

        private void btnimprimiretiquetas_Click(object sender, EventArgs e)
        {
            try
            {

                ptretiquetasubicacion = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                ptretiquetasubicacion.PrinterSettings = ps;
                ptretiquetasubicacion.PrintPage += Imprimir;
                printPreviewDialog.Document = ptretiquetasubicacion;
                printPreviewDialog.ShowDialog();
                //ptretiquetasubicacion.Print();
            }
            catch (Exception)
            {

            }
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Pen Lapiz = new Pen(System.Drawing.Color.Black);
            string codigo;
            try
            {
                //definicion de la fuente

                Font fuente = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);
                PaperSize pksize;
                foreach (DataGridViewRow row in dgvetiquetas.Rows)
                {
                    if ((bool)row.Cells[columnName: "Imprime"].Value)
                    {
                        codigo = (string)row.Cells["ubicacion"].Value;
                        if (codigo != null)
                        {
                            e.Graphics.DrawRectangle(Lapiz, 9, 24, 300, 300);
                            e.Graphics.DrawImage(pictureBox1.Image, new RectangleF(0, 10, 70, 70));
                            codigo = (string)row.Cells["ubicacion"].Value;
                            e.Graphics.DrawImage(dep.GeneraQR(codigo,2), new RectangleF(0, 25, 200, 200));
                            e.Graphics.DrawString(codigo, fuente, Brushes.Black, new RectangleF(0, 270, 120, 20));
                        }
                    }
                }

            }
            catch (Exception)
            {


            }
        }
    }
}
