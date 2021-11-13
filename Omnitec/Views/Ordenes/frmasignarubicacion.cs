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
    public partial class frmasignarubicacion : Form
    {
        M_Ordenes obj_orden = new M_Ordenes();
        M_Depositos obj_depo = new M_Depositos();

        public frmasignarubicacion()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmasignarubicacion_Load(object sender, EventArgs e)
        {
            if (E_Deposito.Ideposito  != 3)
            {
                cargarproductosdelaorden();
                cargarproductosdelaubicacion();
                lblote.Text = E_Ordenes.Lote;
                lbldeposito.Text = E_Deposito.Deposito;
                lblbloque.Text = E_Deposito.Bloque;
                lblrackpasillo.Text = E_Deposito.RackPasillo;
                gunaComboBoxlote.DataSource = obj_orden.Combordenesenstock();
                gunaComboBoxlote.DisplayMember = "lote";
                gunaComboBoxlote.ValueMember = "idorden";
                gunaPanelrackdepositorefrigerado.Visible = false;
            } else
            {
                gunaPanelrackdepositorefrigerado.Visible = true ;
                cargarproductosdelaorden();
                cargarproductosdelaubicacion();
                lblote.Text = E_Ordenes.Lote;
                lbldeposito.Text = E_Deposito.Deposito;
                lblbloque.Text = E_Deposito.Bloque;
                lblrackpasillo.Text = E_Deposito.RackPasillo;
                gunaComboBoxlote.DataSource = obj_orden.Combordenesenstock();
                gunaComboBoxlote.DisplayMember = "lote";
                gunaComboBoxlote.ValueMember = "idorden";
            }
            
        }

        private void cargarproductosdelaorden()
        {
            try
            {
                DataTable data = new DataTable();
                data = obj_orden.Listaproductosxidorden();
                listViewprodorden.Items.Clear();
                foreach (DataRow row in data.Rows)
                {
                    ListViewItem fila = new ListViewItem(row["codigo"].ToString());
                    fila.SubItems.Add(row["ubicacion"].ToString());
                    fila.SubItems.Add(row["idetalleproducto"].ToString());
                    fila.SubItems.Add(row["idestadoprod"].ToString());
                    fila.SubItems.Add(row["idubicacion"].ToString());
                    listViewprodorden.Items.Add(fila);

                }
            }
            catch (Exception)
            {


            }
        }

        private void cargarproductosdelaubicacion()
        {
            try
            {
                DataTable data = new DataTable();
                data = obj_orden.ListarProductosxdepositobloquerackpasillo();
                listViewprodubic.Items.Clear();
                foreach (DataRow row in data.Rows)
                {
                    ListViewItem fila = new ListViewItem(row["pos"].ToString());
                    fila.SubItems.Add(row["codigo"].ToString());
                    listViewprodubic.Items.Add(fila);
                    if (E_Deposito.Ideposito == 3)
                    {
                        if (row["pos"].ToString() == "01")
                        {
                            lblcodigo1.Text = row["codigo"].ToString();
                            if (lblcodigo1.Text != "")
                            {
                                lblcodigo1.BackColor = Color.Red;
                            } else
                            {
                                lblcodigo1.BackColor = Color.Green ;
                            }
                        }
                        if (row["pos"].ToString() == "02")
                        {
                            lblcodigo2.Text = row["codigo"].ToString();
                            if (lblcodigo2.Text != "")
                            {
                                lblcodigo2.BackColor = Color.Red;
                            }
                            else
                            {
                                lblcodigo2.BackColor = Color.Green;
                            }
                        }
                        if (row["pos"].ToString() == "03")
                        {
                            lblcodigo3.Text = row["codigo"].ToString();
                            if (lblcodigo3.Text != "")
                            {
                                lblcodigo3.BackColor = Color.Red;
                            }
                            else
                            {
                                lblcodigo3.BackColor = Color.Green;
                            }
                        }
                        if (row["pos"].ToString() == "04")
                        {
                            lblcodigo4.Text = row["codigo"].ToString();
                            if (lblcodigo4.Text != "")
                            {
                                lblcodigo4.BackColor = Color.Red;
                            }
                            else
                            {
                                lblcodigo4.BackColor = Color.Green;
                            }
                        }
                        if (row["pos"].ToString() == "05")
                        {
                            lblcodigo5.Text = row["codigo"].ToString();
                            if (lblcodigo5.Text != "")
                            {
                                lblcodigo5.BackColor = Color.Red;
                            }
                            else
                            {
                                lblcodigo5.BackColor = Color.Green;
                            }
                        }
                        if (row["pos"].ToString() == "06")
                        {
                            lblcodigo6.Text = row["codigo"].ToString();
                            if (lblcodigo6.Text != "")
                            {
                                lblcodigo6.BackColor = Color.Red;
                            }
                            else
                            {
                                lblcodigo6.BackColor = Color.Green;
                            }
                        }
                        if (row["pos"].ToString() == "07")
                        {
                            lblcodigo7.Text = row["codigo"].ToString();
                            if (lblcodigo7.Text != "")
                            {
                                lblcodigo7.BackColor = Color.Red;
                            }
                            else
                            {
                                lblcodigo7.BackColor = Color.Green;
                            }
                        }
                        if (row["pos"].ToString() == "08")
                        {
                            lblcodigo8.Text = row["codigo"].ToString();
                            if (lblcodigo8.Text != "")
                            {
                                lblcodigo8.BackColor = Color.Red;
                            }
                            else
                            {
                                lblcodigo8.BackColor = Color.Green;
                            }
                        }
                        if (row["pos"].ToString() == "09")
                        {
                            lblcodigo9.Text = row["codigo"].ToString();
                            if (lblcodigo9.Text != "")
                            {
                                lblcodigo9.BackColor = Color.Red;
                            }
                            else
                            {
                                lblcodigo9.BackColor = Color.Green;
                            }
                        }
                        if (row["pos"].ToString() == "10")
                        {
                            lblcodigo10.Text = row["codigo"].ToString();
                            if (lblcodigo10.Text != "")
                            {
                                lblcodigo10.BackColor = Color.Red;
                            }
                            else
                            {
                                lblcodigo10.BackColor = Color.Green;
                            }
                        }
                        if (row["pos"].ToString() == "11")
                        {
                            lblcodigo11.Text = row["codigo"].ToString();
                            if (lblcodigo11.Text != "")
                            {
                                lblcodigo11.BackColor = Color.Red;
                            }
                            else
                            {
                                lblcodigo11.BackColor = Color.Green;
                            }
                        }
                        if (row["pos"].ToString() == "12")
                        {
                            lblcodigo12.Text = row["codigo"].ToString();
                            if (lblcodigo12.Text != "")
                            {
                                lblcodigo12.BackColor = Color.Red;
                            }
                            else
                            {
                                lblcodigo12.BackColor = Color.Green;
                            }
                        }
                        if (row["pos"].ToString() == "13")
                        {
                            lblcodigo13.Text = row["codigo"].ToString();
                            if (lblcodigo13.Text != "")
                            {
                                lblcodigo13.BackColor = Color.Red;
                            }
                            else
                            {
                                lblcodigo13.BackColor = Color.Green;
                            }
                        }
                        if (row["pos"].ToString() == "14")
                        {
                            lblcodigo14.Text = row["codigo"].ToString();
                            if (lblcodigo14.Text != "")
                            {
                                lblcodigo14.BackColor = Color.Red;
                            }
                            else
                            {
                                lblcodigo14.BackColor = Color.Green;
                            }
                        }
                        if (row["pos"].ToString() == "15")
                        {
                            lblcodigo15.Text = row["codigo"].ToString();
                            if (lblcodigo15.Text != "")
                            {
                                lblcodigo15.BackColor = Color.Red;
                            }
                            else
                            {
                                lblcodigo10.BackColor = Color.Green;
                            }
                        }
                        if (row["pos"].ToString() == "16")
                        {
                            lblcodigo16.Text = row["codigo"].ToString();
                            if (lblcodigo16.Text != "")
                            {
                                lblcodigo16.BackColor = Color.Red;
                            }
                            else
                            {
                                lblcodigo16.BackColor = Color.Green;
                            }
                        }
                        if (row["pos"].ToString() == "17")
                        {
                            lblcodigo17.Text = row["codigo"].ToString();
                            if (lblcodigo17.Text != "")
                            {
                                lblcodigo17.BackColor = Color.Red;
                            }
                            else
                            {
                                lblcodigo17.BackColor = Color.Green;
                            }
                        }
                        if (row["pos"].ToString() == "18")
                        {
                            lblcodigo18.Text = row["codigo"].ToString();
                            if (lblcodigo18.Text != "")
                            {
                                lblcodigo18.BackColor = Color.Red;
                            }
                            else
                            {
                                lblcodigo18.BackColor = Color.Green;
                            }
                        }
                        if (row["pos"].ToString() == "19")
                        {
                            lblcodigo19.Text = row["codigo"].ToString();
                            if (lblcodigo19.Text != "")
                            {
                                lblcodigo19.BackColor = Color.Red;
                            }
                            else
                            {
                                lblcodigo19.BackColor = Color.Green;
                            }
                        }
                        if (row["pos"].ToString() == "20")
                        {
                            lblcodigo20.Text = row["codigo"].ToString();
                            if (lblcodigo20.Text != "")
                            {
                                lblcodigo20.BackColor = Color.Red;
                            }
                            else
                            {
                                lblcodigo20.BackColor = Color.Green;
                            }
                        }
                    }

                }
                
            }
            catch (Exception)
            {


            }
        }

        private void listViewprodorden_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                string indice = "0";
                if (listViewprodorden.SelectedItems.Count > 0)
                {
                    ListViewItem filaselec = listViewprodorden.SelectedItems[0];
                    indice = filaselec.SubItems[2].Text;
                }
                if (indice != "0")
                {
                    listViewprodorden.DoDragDrop(indice, DragDropEffects.Copy);
                }

            }
            catch (Exception)
            {

            }
        }

        private void listViewprodubic_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listViewprodubic_DragDrop(object sender, DragEventArgs e)
        {
            string data = "";
            try
            {
                data = (string)e.Data.GetData(DataFormats.Text);
                //E_Ordenes.IdUbicacion = idubic;
                E_Ordenes.IDetalleProducto = int.Parse(data);
                obj_orden.ActualizarUbicacion();
                cargarproductosdelaorden();
                cargarproductosdelaubicacion();
                //inicializadepo();
            }
            catch (Exception)
            {

            }
        }

        private void lblcodigo1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lblcodigo1_DragDrop(object sender, DragEventArgs e)
        {
            string data = "";
            try
            {
                data = (string)e.Data.GetData(DataFormats.Text);
                //E_Ordenes.IdUbicacion = idubic;
                E_Ordenes.IDetalleProducto = int.Parse(data);
                //consulto la ubicacion
                E_Deposito.Pos = "01";
                obj_depo.Checkidubicacion();
                E_Ordenes.IdUbicacion = E_Deposito.Idubicacion;
                if (lblcodigo1.BackColor ==Color.Red)
                {
                    MessageBox.Show("La ubicacion esta ocupada!!!", "UBICACIONES", MessageBoxButtons.OK, MessageBoxIcon.Warning );
                } else
                {
                    obj_orden.ActualizarUbicacion();
                }
                cargarproductosdelaorden();
                cargarproductosdelaubicacion();
                //inicializadepo();
            }
            catch (Exception)
            {

            }
        }

        private void lblcodigo2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lblcodigo2_DragDrop(object sender, DragEventArgs e)
        {
            string data = "";
            try
            {
                data = (string)e.Data.GetData(DataFormats.Text);
                //E_Ordenes.IdUbicacion = idubic;
                E_Ordenes.IDetalleProducto = int.Parse(data);
                //consulto la ubicacion
                E_Deposito.Pos = "02";
                obj_depo.Checkidubicacion();
                E_Ordenes.IdUbicacion = E_Deposito.Idubicacion;
                if (lblcodigo2.BackColor == Color.Red)
                {
                    MessageBox.Show("La ubicacion esta ocupada!!!", "UBICACIONES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    obj_orden.ActualizarUbicacion();
                }
                cargarproductosdelaorden();
                cargarproductosdelaubicacion();
                //inicializadepo();
            }
            catch (Exception)
            {

            }
        }

        private void lblcodigo3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lblcodigo3_DragDrop(object sender, DragEventArgs e)
        {
            string data = "";
            try
            {
                data = (string)e.Data.GetData(DataFormats.Text);
                //E_Ordenes.IdUbicacion = idubic;
                E_Ordenes.IDetalleProducto = int.Parse(data);
                //consulto la ubicacion
                E_Deposito.Pos = "03";
                obj_depo.Checkidubicacion();
                E_Ordenes.IdUbicacion = E_Deposito.Idubicacion;
                if (lblcodigo3.BackColor == Color.Red)
                {
                    MessageBox.Show("La ubicacion esta ocupada!!!", "UBICACIONES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    obj_orden.ActualizarUbicacion();
                }
                cargarproductosdelaorden();
                cargarproductosdelaubicacion();
                //inicializadepo();
            }
            catch (Exception)
            {

            }
        }

        private void lblcodigo4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lblcodigo4_DragDrop(object sender, DragEventArgs e)
        {
            string data = "";
            try
            {
                data = (string)e.Data.GetData(DataFormats.Text);
                //E_Ordenes.IdUbicacion = idubic;
                E_Ordenes.IDetalleProducto = int.Parse(data);
                //consulto la ubicacion
                E_Deposito.Pos = "04";
                obj_depo.Checkidubicacion();
                E_Ordenes.IdUbicacion = E_Deposito.Idubicacion;
                if (lblcodigo4.BackColor == Color.Red)
                {
                    MessageBox.Show("La ubicacion esta ocupada!!!", "UBICACIONES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    obj_orden.ActualizarUbicacion();
                }
                cargarproductosdelaorden();
                cargarproductosdelaubicacion();
                //inicializadepo();
            }
            catch (Exception)
            {

            }
        }

        private void lblcodigo5_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lblcodigo5_DragDrop(object sender, DragEventArgs e)
        {
            string data = "";
            try
            {
                data = (string)e.Data.GetData(DataFormats.Text);
                //E_Ordenes.IdUbicacion = idubic;
                E_Ordenes.IDetalleProducto = int.Parse(data);
                //consulto la ubicacion
                E_Deposito.Pos = "05";
                obj_depo.Checkidubicacion();
                E_Ordenes.IdUbicacion = E_Deposito.Idubicacion;
                if (lblcodigo5.BackColor == Color.Red)
                {
                    MessageBox.Show("La ubicacion esta ocupada!!!", "UBICACIONES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    obj_orden.ActualizarUbicacion();
                }
                cargarproductosdelaorden();
                cargarproductosdelaubicacion();
                //inicializadepo();
            }
            catch (Exception)
            {

            }
        }

        private void lblcodigo6_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lblcodigo6_DragDrop(object sender, DragEventArgs e)
        {
            string data = "";
            try
            {
                data = (string)e.Data.GetData(DataFormats.Text);
                //E_Ordenes.IdUbicacion = idubic;
                E_Ordenes.IDetalleProducto = int.Parse(data);
                //consulto la ubicacion
                E_Deposito.Pos = "06";
                obj_depo.Checkidubicacion();
                E_Ordenes.IdUbicacion = E_Deposito.Idubicacion;
                if (lblcodigo6.BackColor == Color.Red)
                {
                    MessageBox.Show("La ubicacion esta ocupada!!!", "UBICACIONES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    obj_orden.ActualizarUbicacion();
                }
                cargarproductosdelaorden();
                cargarproductosdelaubicacion();
                //inicializadepo();
            }
            catch (Exception)
            {

            }
        }

        private void lblcodigo7_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lblcodigo7_DragDrop(object sender, DragEventArgs e)
        {
            string data = "";
            try
            {
                data = (string)e.Data.GetData(DataFormats.Text);
                //E_Ordenes.IdUbicacion = idubic;
                E_Ordenes.IDetalleProducto = int.Parse(data);
                //consulto la ubicacion
                E_Deposito.Pos = "07";
                obj_depo.Checkidubicacion();
                E_Ordenes.IdUbicacion = E_Deposito.Idubicacion;
                if (lblcodigo7.BackColor == Color.Red)
                {
                    MessageBox.Show("La ubicacion esta ocupada!!!", "UBICACIONES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    obj_orden.ActualizarUbicacion();
                }
                cargarproductosdelaorden();
                cargarproductosdelaubicacion();
                //inicializadepo();
            }
            catch (Exception)
            {

            }
        }

        private void lblcodigo8_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lblcodigo8_DragDrop(object sender, DragEventArgs e)
        {
            string data = "";
            try
            {
                data = (string)e.Data.GetData(DataFormats.Text);
                //E_Ordenes.IdUbicacion = idubic;
                E_Ordenes.IDetalleProducto = int.Parse(data);
                //consulto la ubicacion
                E_Deposito.Pos = "08";
                obj_depo.Checkidubicacion();
                E_Ordenes.IdUbicacion = E_Deposito.Idubicacion;
                if (lblcodigo8.BackColor == Color.Red)
                {
                    MessageBox.Show("La ubicacion esta ocupada!!!", "UBICACIONES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    obj_orden.ActualizarUbicacion();
                }
                cargarproductosdelaorden();
                cargarproductosdelaubicacion();
                //inicializadepo();
            }
            catch (Exception)
            {

            }
        }

        private void lblcodigo9_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lblcodigo9_DragDrop(object sender, DragEventArgs e)
        {
            string data = "";
            try
            {
                data = (string)e.Data.GetData(DataFormats.Text);
                //E_Ordenes.IdUbicacion = idubic;
                E_Ordenes.IDetalleProducto = int.Parse(data);
                //consulto la ubicacion
                E_Deposito.Pos = "09";
                obj_depo.Checkidubicacion();
                E_Ordenes.IdUbicacion = E_Deposito.Idubicacion;
                if (lblcodigo9.BackColor == Color.Red)
                {
                    MessageBox.Show("La ubicacion esta ocupada!!!", "UBICACIONES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    obj_orden.ActualizarUbicacion();
                }
                cargarproductosdelaorden();
                cargarproductosdelaubicacion();
                //inicializadepo();
            }
            catch (Exception)
            {

            }
        }

        private void lblcodigo10_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lblcodigo10_DragDrop(object sender, DragEventArgs e)
        {
            string data = "";
            try
            {
                data = (string)e.Data.GetData(DataFormats.Text);
                //E_Ordenes.IdUbicacion = idubic;
                E_Ordenes.IDetalleProducto = int.Parse(data);
                //consulto la ubicacion
                E_Deposito.Pos = "10";
                obj_depo.Checkidubicacion();
                E_Ordenes.IdUbicacion = E_Deposito.Idubicacion;
                if (lblcodigo10.BackColor == Color.Red)
                {
                    MessageBox.Show("La ubicacion esta ocupada!!!", "UBICACIONES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    obj_orden.ActualizarUbicacion();
                }
                cargarproductosdelaorden();
                cargarproductosdelaubicacion();
                //inicializadepo();
            }
            catch (Exception)
            {

            }
        }

        private void lblcodigo11_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lblcodigo11_DragDrop(object sender, DragEventArgs e)
        {
            string data = "";
            try
            {
                data = (string)e.Data.GetData(DataFormats.Text);
                //E_Ordenes.IdUbicacion = idubic;
                E_Ordenes.IDetalleProducto = int.Parse(data);
                //consulto la ubicacion
                E_Deposito.Pos = "11";
                obj_depo.Checkidubicacion();
                E_Ordenes.IdUbicacion = E_Deposito.Idubicacion;
                if (lblcodigo11.BackColor == Color.Red)
                {
                    MessageBox.Show("La ubicacion esta ocupada!!!", "UBICACIONES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    obj_orden.ActualizarUbicacion();
                }
                cargarproductosdelaorden();
                cargarproductosdelaubicacion();
                //inicializadepo();
            }
            catch (Exception)
            {

            }
        }

        private void lblcodigo12_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lblcodigo12_DragDrop(object sender, DragEventArgs e)
        {
            string data = "";
            try
            {
                data = (string)e.Data.GetData(DataFormats.Text);
                //E_Ordenes.IdUbicacion = idubic;
                E_Ordenes.IDetalleProducto = int.Parse(data);
                //consulto la ubicacion
                E_Deposito.Pos = "12";
                obj_depo.Checkidubicacion();
                E_Ordenes.IdUbicacion = E_Deposito.Idubicacion;
                if (lblcodigo12.BackColor == Color.Red)
                {
                    MessageBox.Show("La ubicacion esta ocupada!!!", "UBICACIONES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    obj_orden.ActualizarUbicacion();
                }
                cargarproductosdelaorden();
                cargarproductosdelaubicacion();
                //inicializadepo();
            }
            catch (Exception)
            {

            }
        }

        private void lblcodigo13_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lblcodigo13_DragDrop(object sender, DragEventArgs e)
        {
            string data = "";
            try
            {
                data = (string)e.Data.GetData(DataFormats.Text);
                //E_Ordenes.IdUbicacion = idubic;
                E_Ordenes.IDetalleProducto = int.Parse(data);
                //consulto la ubicacion
                E_Deposito.Pos = "13";
                obj_depo.Checkidubicacion();
                E_Ordenes.IdUbicacion = E_Deposito.Idubicacion;
                if (lblcodigo13.BackColor == Color.Red)
                {
                    MessageBox.Show("La ubicacion esta ocupada!!!", "UBICACIONES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    obj_orden.ActualizarUbicacion();
                }
                cargarproductosdelaorden();
                cargarproductosdelaubicacion();
                //inicializadepo();
            }
            catch (Exception)
            {

            }
        }

        private void lblcodigo14_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lblcodigo14_DragDrop(object sender, DragEventArgs e)
        {
            string data = "";
            try
            {
                data = (string)e.Data.GetData(DataFormats.Text);
                //E_Ordenes.IdUbicacion = idubic;
                E_Ordenes.IDetalleProducto = int.Parse(data);
                //consulto la ubicacion
                E_Deposito.Pos = "14";
                obj_depo.Checkidubicacion();
                E_Ordenes.IdUbicacion = E_Deposito.Idubicacion;
                if (lblcodigo14.BackColor == Color.Red)
                {
                    MessageBox.Show("La ubicacion esta ocupada!!!", "UBICACIONES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    obj_orden.ActualizarUbicacion();
                }
                cargarproductosdelaorden();
                cargarproductosdelaubicacion();
                //inicializadepo();
            }
            catch (Exception)
            {

            }
        }

        private void lblcodigo15_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lblcodigo15_DragDrop(object sender, DragEventArgs e)
        {
            string data = "";
            try
            {
                data = (string)e.Data.GetData(DataFormats.Text);
                //E_Ordenes.IdUbicacion = idubic;
                E_Ordenes.IDetalleProducto = int.Parse(data);
                //consulto la ubicacion
                E_Deposito.Pos = "15";
                obj_depo.Checkidubicacion();
                E_Ordenes.IdUbicacion = E_Deposito.Idubicacion;
                if (lblcodigo15.BackColor == Color.Red)
                {
                    MessageBox.Show("La ubicacion esta ocupada!!!", "UBICACIONES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    obj_orden.ActualizarUbicacion();
                }
                cargarproductosdelaorden();
                cargarproductosdelaubicacion();
                //inicializadepo();
            }
            catch (Exception)
            {

            }
        }

        private void lblcodigo16_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lblcodigo16_DragDrop(object sender, DragEventArgs e)
        {
            string data = "";
            try
            {
                data = (string)e.Data.GetData(DataFormats.Text);
                //E_Ordenes.IdUbicacion = idubic;
                E_Ordenes.IDetalleProducto = int.Parse(data);
                //consulto la ubicacion
                E_Deposito.Pos = "16";
                obj_depo.Checkidubicacion();
                E_Ordenes.IdUbicacion = E_Deposito.Idubicacion;
                if (lblcodigo16.BackColor == Color.Red)
                {
                    MessageBox.Show("La ubicacion esta ocupada!!!", "UBICACIONES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    obj_orden.ActualizarUbicacion();
                }
                cargarproductosdelaorden();
                cargarproductosdelaubicacion();
                //inicializadepo();
            }
            catch (Exception)
            {

            }
        }

        private void lblcodigo17_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lblcodigo17_DragDrop(object sender, DragEventArgs e)
        {
            string data = "";
            try
            {
                data = (string)e.Data.GetData(DataFormats.Text);
                //E_Ordenes.IdUbicacion = idubic;
                E_Ordenes.IDetalleProducto = int.Parse(data);
                //consulto la ubicacion
                E_Deposito.Pos = "17";
                obj_depo.Checkidubicacion();
                E_Ordenes.IdUbicacion = E_Deposito.Idubicacion;
                if (lblcodigo17.BackColor == Color.Red)
                {
                    MessageBox.Show("La ubicacion esta ocupada!!!", "UBICACIONES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    obj_orden.ActualizarUbicacion();
                }
                cargarproductosdelaorden();
                cargarproductosdelaubicacion();
                //inicializadepo();
            }
            catch (Exception)
            {

            }
        }

        private void lblcodigo18_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lblcodigo18_DragDrop(object sender, DragEventArgs e)
        {
            string data = "";
            try
            {
                data = (string)e.Data.GetData(DataFormats.Text);
                //E_Ordenes.IdUbicacion = idubic;
                E_Ordenes.IDetalleProducto = int.Parse(data);
                //consulto la ubicacion
                E_Deposito.Pos = "18";
                obj_depo.Checkidubicacion();
                E_Ordenes.IdUbicacion = E_Deposito.Idubicacion;
                if (lblcodigo18.BackColor == Color.Red)
                {
                    MessageBox.Show("La ubicacion esta ocupada!!!", "UBICACIONES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    obj_orden.ActualizarUbicacion();
                }
                cargarproductosdelaorden();
                cargarproductosdelaubicacion();
                //inicializadepo();
            }
            catch (Exception)
            {

            }
        }

        private void lblcodigo19_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lblcodigo19_DragDrop(object sender, DragEventArgs e)
        {
            string data = "";
            try
            {
                data = (string)e.Data.GetData(DataFormats.Text);
                //E_Ordenes.IdUbicacion = idubic;
                E_Ordenes.IDetalleProducto = int.Parse(data);
                //consulto la ubicacion
                E_Deposito.Pos = "19";
                obj_depo.Checkidubicacion();
                E_Ordenes.IdUbicacion = E_Deposito.Idubicacion;
                if (lblcodigo19.BackColor == Color.Red)
                {
                    MessageBox.Show("La ubicacion esta ocupada!!!", "UBICACIONES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    obj_orden.ActualizarUbicacion();
                }
                cargarproductosdelaorden();
                cargarproductosdelaubicacion();
                //inicializadepo();
            }
            catch (Exception)
            {

            }
        }

        private void lblcodigo20_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lblcodigo20_DragDrop(object sender, DragEventArgs e)
        {
            string data = "";
            try
            {
                data = (string)e.Data.GetData(DataFormats.Text);
                //E_Ordenes.IdUbicacion = idubic;
                E_Ordenes.IDetalleProducto = int.Parse(data);
                //consulto la ubicacion
                E_Deposito.Pos = "20";
                obj_depo.Checkidubicacion();
                E_Ordenes.IdUbicacion = E_Deposito.Idubicacion;
                if (lblcodigo20.BackColor == Color.Red)
                {
                    MessageBox.Show("La ubicacion esta ocupada!!!", "UBICACIONES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    obj_orden.ActualizarUbicacion();
                }
                cargarproductosdelaorden();
                cargarproductosdelaubicacion();
                //inicializadepo();
            }
            catch (Exception)
            {

            }
        }

        private void gunaComboBoxlote_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                E_Ordenes.IdOrden = int.Parse(gunaComboBoxlote.SelectedValue.ToString());
                lblote.Text = gunaComboBoxlote.Text;
                cargarproductosdelaorden();
            }
            catch (Exception)
            {


            }
        }

        
    }
}
