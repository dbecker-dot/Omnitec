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
using CapaDatos.Services;
using CapaEntidades.Cache;

namespace Omnitec.Views.Ordenes
{
    public partial class frmasociarordenes : Form
    {
        private WinTheme temaform = new WinTheme();
        M_Ordenes obj_orden = new M_Ordenes();
        private frmMenuPrincipal principal;
        public frmasociarordenes(frmMenuPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            principal.mostrarpanelorden = true;
            principal.AbrirPanelOrden();
        }

        private void frmasociarordenes_Load(object sender, EventArgs e)
        {
            cargarordenesasoc();
            cargarordenesdisponibles();
            //Configuro el tema
            temaform.ElegirTema(UserLoginCache.Tema);
            panel_Superior.BackColor = temaform.PanelTitulo;
            this.BackColor = temaform.PanelPadre;
            panel_contenedor.BackColor = temaform.PanelInferior;
            
        }

        private void cargarordenesasoc()
        {
            try
            {
                DataTable data = new DataTable();
                data = obj_orden.Listaordenesasocxidorden();
                listViewordasoc.Items.Clear();
                foreach (DataRow row in data.Rows)
                {
                    ListViewItem fila = new ListViewItem (row["lote"].ToString());
                    fila.SubItems.Add(row["tipo"].ToString());
                    fila.SubItems.Add(row["idasocorden"].ToString());
                    listViewordasoc.Items.Add(fila);

                }
            }
            catch (Exception)
            {

                
            }
        }

        private void cargarordenesdisponibles()
        {
            DataTable data = new DataTable();
            switch (E_Ordenes.IdTipo)
            {
                case 1:
                    //panel_conultas.Visible = false;
                    break;
                case 2:
                    E_Ordenes.IdTipoBusqueda = 1;
                    if (obj_orden.Listaordenesabiertasparasocxcliente().Rows.Count > 0)
                    {
                        data = obj_orden.Listaordenesabiertasparasocxcliente();
                        
                    }
                    else
                    {
                        
                    }
                    break;
                case 3:
                    E_Ordenes.IdTipoBusqueda = 1;
                    if (obj_orden.Listaordenesabiertasparasocxcliente().Rows.Count > 0)
                    {
                        data = obj_orden.Listaordenesabiertasparasocxcliente();

                    }
                    else
                    {

                    }
                    break;
                case 4:
                    E_Ordenes.IdTipoBusqueda = 2;
                    if (obj_orden.Listaordenesabiertasparasocxcliente().Rows.Count > 0)
                    {
                        data = obj_orden.Listaordenesabiertasparasocxcliente();

                    }
                    else
                    {

                    }
                    break;
                default:
                    E_Ordenes.IdTipoBusqueda = 2;
                    if (obj_orden.Listaordenesabiertasparasocxcliente().Rows.Count > 0)
                    {
                        data = obj_orden.Listaordenesabiertasparasocxcliente();

                    }
                    else
                    {

                    }
                    break;
            }
            bool agregar = true;
            listViewnoasoc .Items.Clear();
            foreach (DataRow row in data.Rows)
            {
                for (int i = 0; i < listViewordasoc.Items.Count; i++)
                {
                    if (listViewordasoc.Items[i].SubItems[0].Text == row["LOTE"].ToString())
                        agregar = false;
                }
                if (agregar == true)
                {
                    ListViewItem fila = new ListViewItem(row["LOTE"].ToString());
                    fila.SubItems.Add(row["CANT"].ToString());
                    fila.SubItems.Add(row["KG"].ToString());
                    fila.SubItems.Add(row["idorden"].ToString());
                    listViewnoasoc.Items.Add(fila);
                }
                agregar = true;
            }
        }

        private void listViewordasoc_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                string indice="0";
                if (listViewordasoc.SelectedItems.Count > 0)
                {
                    ListViewItem filaselec = listViewordasoc.SelectedItems[0];
                    indice = filaselec.SubItems[2].Text;
                }
                if (indice != "0")
                {
                    listViewnoasoc.DoDragDrop(indice, DragDropEffects.Copy);
                }
                
            }
            catch (Exception)
            {

            }
        }

        private void listViewnoasoc_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listViewnoasoc_DragDrop(object sender, DragEventArgs e)
        {
            string data = "";
            try
            {
                data = (string)e.Data.GetData(DataFormats.Text);
                E_Ordenes.IdAsocorden = int.Parse (data);
                obj_orden.AnularAsocOrden();
                cargarordenesasoc();
                cargarordenesdisponibles();
            }
            catch (Exception)
            {

            }
        }

        private void listViewnoasoc_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                string indice = "0";
                if (listViewnoasoc.SelectedItems.Count > 0)
                {
                    ListViewItem filaselec = listViewnoasoc.SelectedItems[0];
                    indice = filaselec.SubItems[3].Text;
                }
                if (indice != "0")
                {
                    listViewordasoc.DoDragDrop(indice, DragDropEffects.Copy);
                }

            }
            catch (Exception)
            {

            }
        }

        private void listViewordasoc_DragEnter(object sender, DragEventArgs e)
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

        private void listViewordasoc_DragDrop(object sender, DragEventArgs e)
        {
            string data = "";
            try
            {
                data = (string)e.Data.GetData(DataFormats.Text);
                E_Ordenes.IdOrdenasoc  = int.Parse(data);
                E_Ordenes.Cant = 0;
                obj_orden.AsocOrden();
                E_Ordenes.IdOrdenasoc = 0;
                cargarordenesasoc();
                cargarordenesdisponibles();
            }
            catch (Exception)
            {

            }
        }

       
    }
}
