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

namespace Omnitec.Views.Ordenes
{
    public partial class frmvisualizarorden : Form
    {

        M_Ordenes Obj_Orden = new M_Ordenes();

        public frmvisualizarorden()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmvisualizarorden_Load(object sender, EventArgs e)
        {
            try
            {
                Ordenes.frmverorden frm = new Ordenes.frmverorden();
                AbrirFormEnPanel(frm);
            }
            catch (Exception)
            {


            }
        }

        public void AbrirFormEnPanel(object formHijo)
        {
            if (this.panel_contenido.Controls.Count > 0)
                this.panel_contenido.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel_contenido.Controls.Add(fh);
            this.panel_contenido.Tag = fh;
            fh.BringToFront();
            fh.Show();
        }

        private void CargarOrden()
        {
            //txttituloform.Texts = "ORDEN NRO: " + E_Ordenes.Nro;
            lblfecha.Texts = E_Ordenes.Fecha.ToString("dd/MM/yyyy");
            lbltipo.Texts = E_Ordenes.Tipo;
            lblstatus.Texts = E_Ordenes.Statusorden;
            lblcliente.Texts = E_Ordenes.Cliente;
            lbllote.Texts = E_Ordenes.Lote;
            lblkgnetos.Texts = E_Ordenes.Kg.ToString();
            lblcant.Texts = E_Ordenes.Cant.ToString();

        }

       

       

        private void cmbloteasoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                E_Ordenes.IdordenBus = int.Parse(cmbloteasoc.SelectedValue.ToString());
                dgvdata.Columns.Clear();
                var check = new DataGridViewCheckBoxColumn();
                check.Name = "seleccionar";
                check.HeaderText = "Seleccionar";
                check.FalseValue = true;
                this.dgvdata.Columns.Add(check);
                dgvdata.DataSource = Obj_Orden.Listaproductosenstkxidorden();
                dgvdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception)
            {


            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                
                //TODO - Button Clicked - Execute Code Here
            }
        }

        private void btnubicar_Click(object sender, EventArgs e)
        {
            try
            {
                Ordenes.frmconsultaubicacion frm = new Ordenes.frmconsultaubicacion();
                AbrirFormEnPanel(frm);
            }
            catch (Exception)
            {


            }
        }

        private void btnregistranalisis_Click(object sender, EventArgs e)
        {
            try
            {
                Ordenes.frmanalisisordenes frm = new Ordenes.frmanalisisordenes();
                AbrirFormEnPanel(frm);
            }
            catch (Exception)
            {


            }
        }

       

       
    }
}
