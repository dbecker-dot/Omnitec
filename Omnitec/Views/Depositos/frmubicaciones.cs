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

namespace Omnitec.Views.Depositos
{
    public partial class frmubicaciones : Form
    {
        M_Depositos dep = new M_Depositos();
        public frmubicaciones()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmubicaciones_Load(object sender, EventArgs e)
        {
            try
            {
                cmbdeposito.DataSource = dep.combodepositos();
                cmbdeposito.DisplayMember = "deposito";
                cmbdeposito.ValueMember = "ideposito";
                cmbcliente.DataSource = dep.combocliente();
                cmbcliente.DisplayMember = "cliente";
                cmbcliente.ValueMember = "idcliente";
                E_Deposito.Ideposito = 1;
                CargarGrillas();
            }
            catch (Exception)
            {

                
            }
        }

        private void CargarGrillas()
        {
            if (E_Deposito.Ideposito >= 1)
            {
                dgvubicaciones.DataSource = dep.ListarUbicacionesxDepositos();
                dgvubicaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

        }

        private void cmbdeposito_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbldeposelect.Texts = cmbdeposito.Text;
                E_Deposito.Ideposito = int.Parse(cmbdeposito.SelectedValue.ToString());
                CargarGrillas();

            }
            catch (Exception)
            {


            }
        }

        private void dgvubicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblubicacion.Texts = dgvubicaciones.CurrentRow.Cells[0].Value.ToString();
                lblbloqueubic.Texts = dgvubicaciones.CurrentRow.Cells[1].Value.ToString();
                lblrackpasilloubic.Texts = dgvubicaciones.CurrentRow.Cells[2].Value.ToString();
                lblreserva.Texts = dgvubicaciones.CurrentRow.Cells[4].Value.ToString();
                if (lblreserva.Texts == "")
                {
                    btneliminareserva.Visible = false;
                }
                else
                {
                    btneliminareserva.Visible = true;
                }
                numericUpDowncapacidad.Value = int.Parse(dgvubicaciones.CurrentRow.Cells[5].Value.ToString());
                if (int.Parse(dgvubicaciones.CurrentRow.Cells[6].Value.ToString()) == 0)
                {
                    chubicactiva.Enabled = true;
                }
                else
                {
                    chubicactiva.Enabled = false;
                }
                chubicactiva.Checked = false;
                if (dgvubicaciones.CurrentRow.Cells[8].Value.ToString() == "SI")
                {
                    chubicactiva.Checked = true;
                }
                //Generacion del QR
                pictureBoxQR.Image = dep.GeneraQR(lblubicacion.Texts,7);
                panel_editubicaciones.Visible = true;
            }
            catch (Exception)
            {


            }
        }

        private void cmbcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblreserva.Texts = cmbcliente.Text;
                E_Deposito.IdCliente = int.Parse(cmbcliente.SelectedValue.ToString());
                E_Deposito.Bloque = lblbloqueubic.Texts;
                E_Deposito.RackPasillo = lblrackpasilloubic.Texts;
                dep.Insertareserva();
                if (E_Deposito.ErrorBD == false)
                {
                    MessageBox.Show("La Reserva ha sido registrada", "Ubicaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La Reserva no ha sido registrada", "Ubicaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                CargarGrillas();

            }
            catch (Exception)
            {


            }

        }

        private void btneliminareserva_Click(object sender, EventArgs e)
        {
            try
            {
                lblreserva.Texts = "";
                E_Deposito.Bloque = lblbloqueubic.Texts;
                E_Deposito.RackPasillo = lblrackpasilloubic.Texts;
                dep.Anulareserva();
                if (E_Deposito.ErrorBD == false)
                {
                    MessageBox.Show("La Reserva ha sido registrada", "Ubicaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La Reserva no ha sido registrada", "Ubicaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                CargarGrillas();
                panel_editubicaciones.Visible = false;
            }
            catch (Exception)
            {


            }
        }

        private void chubicactiva_Click(object sender, EventArgs e)
        {
            if (chubicactiva.Checked == true)
            {
                E_Deposito.Hab = "SI";
            }
            else
            {
                E_Deposito.Hab = "NO";
            }
            dep.ModificarEstadoUbicacion();
            if (E_Deposito.ErrorBD == false)
            {
                MessageBox.Show("Se ha modificado el estado de la ubicacion", "Ubicaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se ha modificado el estado de la ubicacion", "Ubicaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            CargarGrillas();
        }

        private void btnmodificarcapacidad_Click(object sender, EventArgs e)
        {
            E_Deposito.Capacidad = int.Parse(numericUpDowncapacidad.Value.ToString());
            dep.ModificarCapacidad();
            if (E_Deposito.ErrorBD == false)
            {
                MessageBox.Show("Se ha modificado la capacidad de la ubicacion", "Ubicaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se ha modificado la capacidad de la ubicacion", "Ubicaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            CargarGrillas();
            panel_editubicaciones.Visible = false;
        }

        private void btnexportaexcelubicaciones_Click(object sender, EventArgs e)
        {
            dep.ExportarExcel();
        }
    }
}
