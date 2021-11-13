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
    public partial class Buttonubic : UserControl
    {
        M_Depositos datadepo = new M_Depositos();

        private double _idubicacion;
        private string _codubicacion;
        private int _ideposito;
        private string _bloque;
        private string _rackpasillo;
        private string _pos;

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

        public delegate void ButtonClick(object sender, EventArgs e);
        public event ButtonClick OnButtonClick;
        public Buttonubic()
        {
            InitializeComponent();
            gunaButtonubicar.Click += new EventHandler((sender, args) =>
            {
                OnButtonClick?.Invoke(this, null);
            });
            
        }

        

        private void gunaButtonubicar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gunaButtonubicar.BackColor == Color.Green)
                {
                    gunaButtonubicar.BackColor = Color.Empty;
                }
                else
                {
                    gunaButtonubicar.BackColor = Color.Green;
                }
                if (ideposito != 0 && ideposito != 3 && bloque != "" && rackpasillo != "" && gunaButtonubicar.BackColor == Color.Green)
                {
                    E_Deposito.Ideposito = ideposito;
                    E_Deposito.Bloque = bloque;
                    E_Deposito.RackPasillo = rackpasillo;
                    E_Deposito.Pos = "01";
                    datadepo.Checkidubicacion();
                    idubicacion = E_Deposito.Idubicacion;
                    E_Ordenes.IdUbicacion = idubicacion;
                    //E_Deposito.Idubicacion = 0;

                }
                else
                {
                    E_Deposito.Ideposito = ideposito;
                    E_Deposito.Bloque = bloque;
                    E_Deposito.RackPasillo = rackpasillo;
                    idubicacion = 0;
                    E_Ordenes.IdUbicacion = idubicacion;
                }
            }
            catch (Exception)
            {


            }
        }

        private void Buttonubic_Load(object sender, EventArgs e)
        {
            if (ideposito != 0 && bloque != "" && rackpasillo != "")
            {
                gunaButtonubicar.Text = bloque + rackpasillo;
            }
        }
    }
}
