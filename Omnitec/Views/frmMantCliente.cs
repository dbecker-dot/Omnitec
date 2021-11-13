using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades.Cache;
using CapaEntidades;
using CapaNegocio;


namespace Omnitec.Views
{
    public partial class frmMantCliente : Form
    {
        public frmMantCliente()
        {
            InitializeComponent();
        }

        M_Cliente cli = new M_Cliente();
        M_Cliente cuit = new M_Cliente();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMantCliente_Load(object sender, EventArgs e)
        {
            panel_Selectcuit.Width = 0;
            if (E_Cliente.Idcliente == 0)
            {
                lblaccioncliente.Text = "AGREGAR CLIENTE";
                txtnombre.Enabled = true;
                txtcuit.Enabled = true;
                txtcodigo.Enabled = true; 
                chactivo.Enabled = false;
                txtpais.Texts = "";
                txtcuit.Texts = "";
            }
            else
            {
                lblaccioncliente.Text = "MODIFICAR CLIENTE";
                txtnombre.Enabled = false;
                txtcuit.Enabled = false;
                txtid.Texts = E_Cliente.Idcliente.ToString();
                txtnombre.Texts = E_Cliente.Cliente;
                txtcuit.Texts = E_Cliente.Cuit;
                txtpais.Texts = E_Cliente.Pais;
                txtcodigo.Texts = E_Cliente.Codcliente;
                chactivo.Checked = false;
                if (E_Cliente.Hab == "SI")
                {
                    chactivo.Checked = true;
                }
            }
        }

        private void rbcuitexterior_CheckedChanged(object sender, EventArgs e)
        {
            if (rbcuitexterior.Checked == true)
            {
                txtcuit.Enabled = false;
                if (panel_Selectcuit.Width == 0)
                {
                    panel_Selectcuit.Width = 450;
                    dgvcuitpais.DataSource = cuit.ListarCuitpais("");
                }
                else {

                    panel_Selectcuit.Width = 0;
                }
            }
        }

        private void rbcuitinteriorarg_CheckedChanged(object sender, EventArgs e)
        {
            if (rbcuitexterior.Checked == true)
            {
                txtcuit.Texts = "";
                txtcuit.Enabled = true;
            }
        }

        private void btnocultarselectcuit_Click(object sender, EventArgs e)
        {
            if (panel_Selectcuit.Width == 0)
            {
                panel_Selectcuit.Width = 450;
            }
            else
            {

                panel_Selectcuit.Width = 0;
            }
        }

        private void dgvcuitpais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                E_Cliente.Cuit = dgvcuitpais.CurrentRow.Cells[0].Value.ToString();
                E_Cliente.Pais = dgvcuitpais.CurrentRow.Cells[1].Value.ToString();
                txtcuit.Texts = E_Cliente.Cuit;
                txtpais.Texts = E_Cliente.Pais;
                if (panel_Selectcuit.Width == 0)
                {
                    panel_Selectcuit.Width = 450;
                }
                else
                {

                    panel_Selectcuit.Width = 0;
                }
            }
            catch (Exception)
            {


            }
        }

        private void txtbusquedacuit__TextChanged(object sender, EventArgs e)
        {
            dgvcuitpais.DataSource = cuit.ListarCuitpais(txtbusquedacuit.Texts);
        }

       
    }
}
