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

namespace Omnitec.Views.Reportes
{
    public partial class frmstarusdeposito : Form
    {
        M_Depositos depo = new M_Depositos();
        public frmstarusdeposito()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmstarusdeposito_Load(object sender, EventArgs e)
        {
            actualizastatus();
            
        
        }

        private void actualizastatus()
        {
            try
            {
                //global depositos
                double porcen = 0;
                circularProgressBardepositos.Value = 0;
                circularProgressBardepositos.Minimum = 0;
                circularProgressBardepositos.Maximum = 100;
                depo.Checkstatusdeposito();
                porcen = (E_Deposito.Utilizado * 100) / E_Deposito.Capacidad;
                circularProgressBardepositos.Value = (int)porcen;
                circularProgressBardepositos.Text = porcen.ToString();

                circularProgressBarcrudo.Value = 0;
                circularProgressBarcrudo.Minimum = 0;
                circularProgressBarcrudo.Maximum = 100;
                E_Deposito.Ideposito = 1;
                depo.Checkstatusxideposito();
                porcen = (E_Deposito.Utilizado * 100) / E_Deposito.Capacidad;
                circularProgressBarcrudo.Value = (int)porcen;
                circularProgressBarcrudo.Text = porcen.ToString();

                circularProgressBarprod.Value = 0;
                circularProgressBarprod.Minimum = 0;
                circularProgressBarprod.Maximum = 100;
                E_Deposito.Ideposito = 2;
                depo.Checkstatusxideposito();
                porcen = (E_Deposito.Utilizado * 100) / E_Deposito.Capacidad;
                circularProgressBarprod.Value = (int)porcen;
                circularProgressBarprod.Text = porcen.ToString();

                circularProgressBarrefrig.Value = 0;
                circularProgressBarrefrig.Minimum = 0;
                circularProgressBarrefrig.Maximum = 100;
                E_Deposito.Ideposito = 3;
                depo.Checkstatusxideposito();
                porcen = (E_Deposito.Utilizado * 100) / E_Deposito.Capacidad;
                circularProgressBarrefrig.Value = (int)porcen;
                circularProgressBarrefrig.Text = porcen.ToString();

                circularProgressBaringrefrig.Value = 0;
                circularProgressBaringrefrig.Minimum = 0;
                circularProgressBaringrefrig.Maximum = 100;
                E_Deposito.Ideposito = 4;
                depo.Checkstatusxideposito();
                porcen = (E_Deposito.Utilizado * 100) / E_Deposito.Capacidad;
                circularProgressBaringrefrig.Value = (int)porcen;
                circularProgressBaringrefrig.Text = porcen.ToString();

                circularProgressBaralero.Value = 0;
                circularProgressBaralero.Minimum = 0;
                circularProgressBaralero.Maximum = 100;
                E_Deposito.Ideposito = 5;
                depo.Checkstatusxideposito();
                porcen = (E_Deposito.Utilizado * 100) / E_Deposito.Capacidad;
                circularProgressBaralero.Value = (int)porcen;
                circularProgressBaralero.Text = porcen.ToString();

                

            }
            catch (Exception)
            {

                throw;
            }
        }

     
    }
}
