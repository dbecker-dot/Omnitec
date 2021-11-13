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

namespace Omnitec.Views
{
    public partial class frmadmclientes : Form
    {
        public frmadmclientes()
        {
            InitializeComponent();
        }

        M_Cliente cli = new M_Cliente();

        private void frmadmclientes_Load(object sender, EventArgs e)
        {
            txttituloform.Texts = "ADMINISTRACION - CLIENTES";
            TablaCliente.DataSource = cli.ListarClientes("");
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbusqueda__TextChanged(object sender, EventArgs e)
        {
            TablaCliente.DataSource = cli.ListarClientes(txtbusqueda.Texts);
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            frmMantCliente hijo = new frmMantCliente();
            AddOwnedForm(hijo);
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            this.Controls.Add(hijo);
            this.Tag = hijo;
            hijo.BringToFront();
            E_Cliente.Idcliente = 0;
            hijo.Show();
        }

        private void TablaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                E_Cliente.Idcliente = int.Parse(TablaCliente.CurrentRow.Cells[0].Value.ToString());
                E_Cliente.Cuit = TablaCliente.CurrentRow.Cells[1].Value.ToString();
                E_Cliente.Pais = TablaCliente.CurrentRow.Cells[2].Value.ToString();
                E_Cliente.Cliente = TablaCliente.CurrentRow.Cells[3].Value.ToString();
                E_Cliente.Codcliente = TablaCliente.CurrentRow.Cells[4].Value.ToString();
                E_Cliente.Hab = TablaCliente.CurrentRow.Cells[5].Value.ToString();
                frmMantCliente hijo = new frmMantCliente();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                hijo.Show();
            }
            catch (Exception)
            {

                
            }
        }
    }
}
