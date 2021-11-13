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

namespace Omnitec.Recursos
{
    public partial class PBubicV : UserControl
    {
        M_Depositos datadepo = new M_Depositos();

        private double _idubicacion;
        private string _codubicacion;
        private int _ideposito;
        private string _bloque;
        private string _rackpasillo;
        private string _pos;
        private int _capacidad;
        private int _utilizado;
        private int _disponible;
        private bool _estado;

        public double idubicacion
        {
            get
            {
                return _idubicacion;
            }
            set
            {
                _idubicacion = value;
            }
        }
        public string codubicacion
        {
            get
            {
                return _codubicacion;
            }
            set
            {
                _codubicacion = value;
            }
        }
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
        public string pos
        {
            get
            {
                return _pos;
            }
            set
            {
                _pos = value;
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

        public PBubicV()
        {
            InitializeComponent();
            ideposito = 0;
        }

        public void actualizarvalores()
        {
            if (ideposito != 0 && bloque != "" && rackpasillo != "")
            {
                E_Deposito.Ideposito = ideposito;
                E_Deposito.Bloque = bloque;
                E_Deposito.RackPasillo = rackpasillo;
                datadepo.Checkstatusrackpasilloxidepositobloquerackpasillo();
                estado = E_Deposito.Estadoubic;
                capacidad = E_Deposito.Capacidad;
                utilizado = E_Deposito.Utilizado;
                disponible = capacidad - utilizado;
                gunaVProgressBar1.Minimum = 0;
                gunaVProgressBar1.Maximum = capacidad;
                gunaVProgressBar1.Value = utilizado;
                if (estado)
                {
                                    }
                else
                {
                    
                }
            }

        }
    }
}
