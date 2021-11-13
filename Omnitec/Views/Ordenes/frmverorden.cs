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
    public partial class frmverorden : Form
    {
        public frmverorden()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmverorden_Load(object sender, EventArgs e)
        {
            CargarOrden();
        }

        private void CargarOrden()
        {
            lblorden.Text  = "ORDEN NRO: " + E_Ordenes.Nro;
            lblfecha.Texts = E_Ordenes.Fecha.ToString("dd/MM/yyyy");
            lbltipo.Texts = E_Ordenes.Tipo;
            lblstatus.Texts = E_Ordenes.Statusorden;
            lblcliente.Texts = E_Ordenes.Cliente;
            lbllote.Texts = E_Ordenes.Lote;
            lblkgnetos.Texts = E_Ordenes.Kg.ToString();
            lblcant.Texts = E_Ordenes.Cant.ToString();

        }
    }
}
