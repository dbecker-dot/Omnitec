using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades.Cache;
using CapaEntidades;
using CapaNegocio;

namespace Omnitec.Views
{
    public partial class frmcuitclientesexterior : Form
    {
        M_Cliente cuit = new M_Cliente();

        public frmcuitclientesexterior()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmcuitclientesexterior_Load(object sender, EventArgs e)
        {
            txtbusquedacuit.Texts = E_Cliente.Cuit;
            dgvcuitpais.DataSource = cuit.ListarCuitpais("");
        }

        private void txtbusquedacuit__TextChanged(object sender, EventArgs e)
        {
            dgvcuitpais.DataSource = cuit.ListarCuitpais(txtbusquedacuit.Texts);
        }

        private void dgvcuitpais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                E_Cliente.Cuit =dgvcuitpais.CurrentRow.Cells[0].Value.ToString();
                this.Close();
            }
            catch (Exception)
            {


            }
        }
    }
}
