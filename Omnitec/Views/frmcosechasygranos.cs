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

namespace Omnitec
{
    public partial class frmcosechasygranos : Form
    {
        public frmcosechasygranos()
        {
            InitializeComponent();
        }

        M_Productos prod = new M_Productos();

        private void frmcosechasygranos_Load(object sender, EventArgs e)
        {
            txttituloform.Texts = "ADMINISTRAR COSECHAS Y GRANOS";
            InsertarFilas();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //FormMantCliente frm = new FormMantCliente();
           
        }

        private void InsertarFilas()
        {
            dgvcosechas.DataSource = prod.ListarCosechas();
            dgvcosechas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvgranos.DataSource = prod.ListarGranos();
            dgvgranos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            panel_abmcosecha.Visible = false;
            panel_abmgrano.Visible = false;
        }

        private void btnagregarcosecha_Click(object sender, EventArgs e)
        {
            try
            {
                panel_abmcosecha.Visible = true;
                txtidcosecha.Texts = "";
                E_Producto.Idcosecha = 0;
                txtaccioncosecha.Texts = "ALTA DE COSECHA";
                txtcosecha.Texts = "";
                txtcosecha.Enabled = true;
                chcosactiva.Visible = false; 
            }
            catch (Exception)
            {

                
            }
        }

        private void btncerrarpanelcosecha_Click(object sender, EventArgs e)
        {
            panel_abmcosecha.Visible = false;
        }

        private void dgvcosechas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtaccioncosecha.Texts = "MODIFICAR COSECHA";
                txtidcosecha.Texts = dgvcosechas.CurrentRow.Cells[0].Value.ToString();
                E_Producto.Idcosecha = int.Parse(dgvcosechas.CurrentRow.Cells[0].Value.ToString());
                txtcosecha.Texts= dgvcosechas.CurrentRow.Cells[1].Value.ToString();
                txtcosecha.Enabled = false;
                E_Producto.Cosecha = (int)dgvcosechas.CurrentRow.Cells[1].Value;
                chcosactiva.Checked = false;
                if (dgvcosechas.CurrentRow.Cells[2].Value.ToString() == "SI")
                {
                    chcosactiva.Checked = true;
                }
                E_Producto.Hab = dgvcosechas.CurrentRow.Cells[2].Value.ToString();
                chcosactiva.Visible = true;
                panel_abmcosecha.Visible = true;
            }
            catch (Exception)
            {

                
            }
        }

        private void btnguardarcambioscosecha_Click(object sender, EventArgs e)
        {
            if (E_Producto.Idcosecha == 0)
            {
                if (txtcosecha.Texts == "")
                {
                    MessageBox.Show("Especifique una cosecha", "Cosechas", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                } else 
                {
                    E_Producto.Cosecha = Convert.ToInt32(txtcosecha.Texts);
                    prod.InsertarCosecha();
                    if (E_Producto.ErrorBD == false)
                    {
                        MessageBox.Show("La Cosecha ha sido registrada", "Cosechas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else
                    {
                        MessageBox.Show("La Cosecha no ha sido registrada", "Cosechas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
               
                
            } else
            {
                if (chcosactiva.Checked == true)
                {
                    E_Producto.Hab = "SI";
                } else
                {
                    E_Producto.Hab = "NO";
                }
                prod.ModifarCosecha();
                if (E_Producto.ErrorBD == false)
                {
                    MessageBox.Show("La Cosecha ha sido modificada", "Cosechas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La Cosecha no ha sido modificada", "Cosechas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            InsertarFilas();
        }

        private void btnagregargrano_Click(object sender, EventArgs e)
        {
            try
            {
                panel_abmgrano.Visible = true;
                txtidgrano.Texts = "";
                E_Producto.Idgrano = 0;
                txtacciongrano.Texts = "ALTA DE GRANO";
                txtgrano.Texts = "";
                txtgrano.Enabled = true;
                txtcodgrano.Texts = "";
                txtcodgrano.Enabled = true;
                chgractivo.Visible = false;
            }
            catch (Exception)
            {


            }
        }

        private void dgvgranos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtacciongrano.Texts = "MODIFICAR GRANO";
                txtidgrano.Texts = dgvgranos.CurrentRow.Cells[0].Value.ToString();
                E_Producto.Idgrano = int.Parse(dgvgranos.CurrentRow.Cells[0].Value.ToString());
                txtgrano.Texts = dgvgranos.CurrentRow.Cells[1].Value.ToString();
                txtgrano.Enabled = false;
                E_Producto.Grano = dgvgranos.CurrentRow.Cells[1].Value.ToString();
                txtcodgrano.Texts = dgvgranos.CurrentRow.Cells[2].Value.ToString();
                txtcodgrano.Enabled = false;
                E_Producto.Codgrano = dgvgranos.CurrentRow.Cells[2].Value.ToString();
                chgractivo.Checked = false;
                if (dgvgranos.CurrentRow.Cells[3].Value.ToString() == "SI")
                {
                    chgractivo.Checked = true;
                }
                E_Producto.Hab = dgvgranos.CurrentRow.Cells[3].Value.ToString();
                chgractivo.Visible = true;
                panel_abmgrano.Visible = true;
            }
            catch (Exception)
            {


            }
        }

        private void btnguardarcambiosgrano_Click(object sender, EventArgs e)
        {
            if (E_Producto.Idgrano == 0)
            {
                if (txtgrano.Texts == "")
                {
                    MessageBox.Show("Especifique un Grano", "Granos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    E_Producto.Grano = txtgrano.Texts;
                    E_Producto.Codgrano = txtcodgrano.Texts;
                    prod.InsertarGrano();
                    if (E_Producto.ErrorBD == false)
                    {
                        MessageBox.Show("El Grano ha sido registrado", "Granos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El Grano no ha sido registrado", "Granos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }


            }
            else
            {
                if (chgractivo.Checked == true)
                {
                    E_Producto.Hab = "SI";
                }
                else
                {
                    E_Producto.Hab = "NO";
                }
                prod.ModifarGrano();
                if (E_Producto.ErrorBD == false)
                {
                    MessageBox.Show("El Grano ha sido modificado", "Granos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El Grano no ha sido modificado", "Granos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            InsertarFilas();
        }

        private void btncerrarpanelgrano_Click(object sender, EventArgs e)
        {
            panel_abmgrano.Visible = false;
        }
    }
}
