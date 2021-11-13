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

namespace Omnitec.Recursos
{
    public partial class UserControl_Ubicarendeposito : UserControl
    {
        M_Ordenes obj_orden = new M_Ordenes();
        M_Depositos obj_depo = new M_Depositos();
        public UserControl_Ubicarendeposito()
        {
            InitializeComponent();
            
        }

      
        private void btncerrarctrol_Click(object sender, EventArgs e)
        {
            this.Visible  = false;
        }

        public void cargarproductos()
        {
            dgvdata.Columns.Clear();
            var check = new DataGridViewCheckBoxColumn();
            check.Name = "seleccionar";
            check.HeaderText = "Seleccionar";
            check.FalseValue = true;
            this.dgvdata.Columns.Add(check);
            dgvdata.DataSource = obj_orden.Listaubicproductosxidorden();
            dgvdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvdata.Columns[2].Visible = false;
            dgvdata.Columns[4].Visible = false;
            dgvdata.Columns[5].Visible = false;
            dgvdata.Columns[6].Visible = false;
            dgvdata.Columns[7].Visible = false;
            dgvdata.Columns[8].Visible = false;
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserControl_Ubicarendeposito_Load(object sender, EventArgs e)
        {

        }
    }
}
