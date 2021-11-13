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
using QRCoder;

namespace Omnitec.Views
{
    public partial class frmdepositos : Form
    {
        public frmdepositos()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        M_Depositos dep = new M_Depositos();

        private void frmdepositos_Load(object sender, EventArgs e)
        {
            txttituloform.Texts = "ADMINISTRAR DEPOSITOS";
            CargarGrillas();
        }

        private void CargarGrillas()
        {
            dgvdepositos .DataSource = dep.ListarDepositos();
            dgvdepositos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }

        

        private void btnverdepositos_Click(object sender, EventArgs e)
        {
            panel_listadepositos.Width = 930;
            panel_listadepositos.Visible = true;
            
        }

        private void btnubicaciones_Click(object sender, EventArgs e)
        {
            panel_listadepositos.Visible = false;
            CargarGrillas();
        }

        

        private void btncerrarlistadepositos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
