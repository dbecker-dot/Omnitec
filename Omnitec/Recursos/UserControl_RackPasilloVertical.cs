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

namespace Omnitec.Recursos
{
    public partial class UserControl_RackPasilloVertical : UserControl
    {
        M_Depositos datadepo = new M_Depositos();
        private int _ideposito;
        private string _bloque;
        private string _rackpasillo;
        private int _capacidad;
        private int _utilizado;
        private int _disponible;
        private bool _seleccionado;
        private bool _estado;

        public int ideposito
        {
            get
            {
                return _ideposito;
            }
            set
            {
                _ideposito = value;
            }
        }
        public string bloque
        {
            get
            {
                return _bloque;
            }
            set
            {
                _bloque = value;
            }
        }
        public string rackpasillo
        {
            get
            {
                return _rackpasillo;
            }
            set
            {
                _rackpasillo = value;
            }
        }
        public int capacidad
        {
            get
            {
                return _capacidad;
            }
            set
            {
                _capacidad = value;
            }
        }
        public int utilizado
        {
            get
            {
                return _utilizado;
            }
            set
            {
                _utilizado = value;
            }
        }
        public int disponible
        {
            get
            {
                return _disponible;
            }
            set
            {
                _disponible = value;
            }
        }
        public bool seleccionado
        {
            get
            {
                return _seleccionado;
            }
            set
            {
                _seleccionado = value;
            }
        }
        public bool estado
        {
            get
            {
                return _estado;
            }
            set
            {
                _estado = value;
            }
        }
        public UserControl_RackPasilloVertical()
        {
            InitializeComponent();
            ideposito = 0;
            bloque = "";
            rackpasillo = "";
            capacidad = 0;
            utilizado = 0;
            estado = false;
            seleccionado = false;
            disponible = capacidad - utilizado;
            lblrackpasillo.Text = bloque + rackpasillo;

        }

        public void actualizarvalores()
        {
            E_Deposito.Ideposito = ideposito;
            E_Deposito.Bloque = bloque;
            E_Deposito.RackPasillo = rackpasillo;
            datadepo.Checkstatusrackpasilloxidepositobloquerackpasillo();
            estado = E_Deposito.Estadoubic;
            capacidad = E_Deposito.Capacidad;
            utilizado = E_Deposito.Utilizado;
            disponible = capacidad - utilizado;
            lblrackpasillo.Text = bloque + rackpasillo;
            lblcapacidad.Text = capacidad.ToString();
            lblutilizado.Text = utilizado.ToString();
            lbldisponible.Text = disponible.ToString();
            ProgressBarackpasillo.Minimum = 0;
            ProgressBarackpasillo.Maximum = capacidad;
            ProgressBarackpasillo.Value = utilizado;
            if (estado)
            {
                lblrackpasillo.BackColor = Color.Green;
            }
            else
            {
                lblrackpasillo.BackColor = Color.Red;
            }
        }
    }
}
