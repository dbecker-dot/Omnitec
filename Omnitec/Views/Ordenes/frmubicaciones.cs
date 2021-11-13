using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omnitec.Views.Ordenes
{
    public partial class frmubicaciones : Form
    {

        public bool sinpanelizquierdo;
        public bool sinpanelderecho;

        public frmubicaciones()
        {
            InitializeComponent();
        }

        private void frmubicaciones_Load(object sender, EventArgs e)
        {
            if (sinpanelizquierdo == true)
            {
                panelmenulateralizquierdo.Visible = false;
            } else
            {
                panelmenulateralizquierdo.Visible = true;
            }
            if (sinpanelderecho == true)
            {
                panelmenulateralderecho.Visible = false;
            }
            else
            {
                panelmenulateralderecho.Visible = true;
            }
            panelmenulateralizquierdo.Width = 55;
            panelmenulateralderecho.Width = 55;
            actualizadatos();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMenuizquierdo_Click(object sender, EventArgs e)
        {
            

            //-------SIN EFECTO 
            if (panelmenulateralizquierdo.Width == 55)
            {
                panelmenulateralizquierdo.Width = 200;
            } else
            {
                panelmenulateralizquierdo.Width = 55;
            }
        }

        private void tmExpandirMenuiz_Tick(object sender, EventArgs e)
        {
            if (panelmenulateralizquierdo.Width >= 200)
                this.tmExpandirMenuiz.Stop();
            else
                panelmenulateralizquierdo.Width = panelmenulateralizquierdo.Width + 5;
        }

        private void tmContraerMenuiz_Tick(object sender, EventArgs e)
        {
            if (panelmenulateralizquierdo.Width <= 55)
                this.tmContraerMenuiz.Stop();
            else
                panelmenulateralizquierdo.Width = panelmenulateralizquierdo.Width - 5;
        }

        private void btnMenuderecho_Click(object sender, EventArgs e)
        {
            //-------CON EFECTO SLIDING
            /*if (panelmenulateralizquierdo.Width == 200)
            {
                this.tmContraerMenuiz.Start();
            }
            else if (panelmenulateralizquierdo.Width == 55)
            {
                this.tmExpandirMenuiz.Start();
            }
            */
            //-------SIN EFECTO 
            if (panelmenulateralderecho.Width == 55)
            {
                panelmenulateralderecho.Width = 230;
            }
            else

                panelmenulateralderecho.Width = 55;
        }

        private void actualizadatos()
        {
            pBubicHCA1.ideposito = 1;
            pBubicHCA1.bloque = "A";
            pBubicHCA1.rackpasillo = "1";
            pBubicHCA1.pos = "01";
            pBubicHCA1.actualizarvalores();

            pBubicVCC1.ideposito = 1;
            pBubicVCC1.bloque = "C";
            pBubicVCC1.rackpasillo = "1";
            pBubicVCC1.pos = "01";
            pBubicVCC1.actualizarvalores();

            pBubicIRC1.actualizarvalores();
            pBubicIRC2.actualizarvalores();
            pBubicIRC3.actualizarvalores();
        }

        
    }
}
