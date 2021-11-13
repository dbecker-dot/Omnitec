using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omnitec.Recursos
{
    public partial class RackPasillovertical : UserControl
    {
        public RackPasillovertical()
        {
            InitializeComponent();
        }

        public void inicializarp(int rp,string nombrerp)
        {
            switch (rp)
            {
                case 1:
                    NomRP1.Visible = true;
                    NomRP1.Text = nombrerp + "1";
                    RP1.Visible = true;
                    break;
                case 2:
                    NomRP1.Visible = true;
                    RP1.Visible = true;
                    NomRP1.Text = nombrerp + "1";
                    NomRP2.Visible = true;
                    RP2.Visible = true;
                    NomRP2.Text = nombrerp + "2";
                    break;
                case 3:
                    NomRP1.Visible = true;
                    RP1.Visible = true;
                    NomRP1.Text = nombrerp + "1";
                    NomRP2.Visible = true;
                    RP2.Visible = true;
                    NomRP2.Text = nombrerp + "2";
                    NomRP3.Visible = true;
                    NomRP3.Text = nombrerp + "3";
                    RP3.Visible = true;
                    break;
                case 4:
                    NomRP1.Visible = true;
                    RP1.Visible = true;
                    NomRP2.Visible = true;
                    RP2.Visible = true;
                    NomRP3.Visible = true;
                    RP3.Visible = true;
                    NomRP4.Visible = true;
                    RP4.Visible = true;
                    break;
                case 5:
                    NomRP1.Visible = true;
                    RP1.Visible = true;
                    NomRP2.Visible = true;
                    RP2.Visible = true;
                    NomRP3.Visible = true;
                    RP3.Visible = true;
                    NomRP4.Visible = true;
                    RP4.Visible = true;
                    NomRP5.Visible = true;
                    RP5.Visible = true;
                    break;
            }
            int i = 0;
            for (i = 0; i < 5; i++)
            {
                if (i >= rp )
                {
                    tlp_rackpasillo.ColumnStyles[i].Width = 0;
                }

            }
        }

        public void ActualizarPasillo(int valor)
        {
            RP1.Value = valor;
        }
    }
}
