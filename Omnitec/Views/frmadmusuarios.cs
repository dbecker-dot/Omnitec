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
    public partial class frmadmusuarios : Form
    {
        public frmadmusuarios()
        {
            InitializeComponent();
        }

        M_Usuario user = new M_Usuario();

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmadmusuarios_Load(object sender, EventArgs e)
        {
            txttituloform.Texts = "ADMINISTRACION - USUARIOS";
            dgvusuarios.DataSource = user.ListarUsuarios("");
        }

        private void btnagregarusuario_Click(object sender, EventArgs e)
        {
            frmMantusuario hijo = new frmMantusuario();
            AddOwnedForm(hijo);
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            this.Controls.Add(hijo);
            this.Tag = hijo;
            hijo.BringToFront();
            E_Usuario.Idusuario = 0;
            hijo.Show();
        }

        private void txtbuscar__TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvusuarios.DataSource = user.ListarUsuarios(txtbuscar.Texts);
            }
            catch (Exception)
            {

                
            }
        }

        private void dgvusuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                E_Usuario.Idusuario = int.Parse(dgvusuarios.CurrentRow.Cells[0].Value.ToString());
                E_Usuario.Nombre = dgvusuarios.CurrentRow.Cells[1].Value.ToString();
                E_Usuario.Usuario= dgvusuarios.CurrentRow.Cells[2].Value.ToString();
                E_Usuario.Email = dgvusuarios.CurrentRow.Cells[3].Value.ToString();
                E_Usuario.Perfil = dgvusuarios.CurrentRow.Cells[4].Value.ToString();
                E_Usuario.Diasexpclave = int.Parse(dgvusuarios.CurrentRow.Cells[5].Value.ToString());
                E_Usuario.Accesomovil = "NO";
                if (dgvusuarios.CurrentRow.Cells[7].Value.ToString() == "SI")
                {
                    E_Usuario.Accesomovil = "SI";
                }
                E_Usuario.Hab = "NO";
                if (dgvusuarios.CurrentRow.Cells[8].Value.ToString() == "SI")
                {
                    E_Usuario.Hab = "SI";
                }
                frmMantusuario hijo = new frmMantusuario();
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
