using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;

namespace Omnitec.Views
{
    public partial class frmRepStock : Form
    {
        public frmRepStock()
        {
            InitializeComponent();
        }

        private void frmRepStock_Load(object sender, EventArgs e)
        {
            Dashboard();
        }

        private void Dashboard()
        {
            M_Dashboard data = new M_Dashboard();
            E_Dashboard datos = new E_Dashboard();
            data.Dashboardstk(datos);

            chartstkxgrano.Series[0].Points.DataBindXY(datos.P_Granos, datos.P_CantGranos);
            chartstkxcliente.Series[0].Points.DataBindXY(datos.P_Clientes, datos.P_Cantxclientes);
            lbltotconfiteria.Text = datos.Totconfiteria;
            lbltotindustria.Text = datos.Totindustria;
            lbltotblanchado.Text = datos.Totblanchado;
            lbltotrechazoseleccion.Text = datos.Totrechazoseleccion;
        }

        private void SumarioStk()
        {

        }

    }
}
