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
    public partial class UbicarProductoV : UserControl
    {
        M_Depositos datadepo = new M_Depositos();
        M_Ordenes orden = new M_Ordenes();

        private double _idubicacion;
        private string _codubicacion;
        private int _ideposito;
        private string _bloque;
        private string _rackpasillo;
        private string _pos;
        private int _capacidad;
        private int _utilizado;
        private int _disponible;
        private bool _seleccionado;
        private bool _estado;
        private bool _mostrarcheck;
        private string _modo;
        //variables para registrar la ubicacion del producto
        private string _codigoproducto;
        private double _idetalleproducto;
        private int _idusuario;
        private int _idaccionmovil;
        private int _idubicacionorigen;
        private int _idubicaciondestino;
        private int _idtiporden;
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

        public bool mostrarcheck
        {
            get
            {
                return _mostrarcheck;
            }
            set
            {
                _mostrarcheck = value;
            }
        }

        public string modo
        {
            get
            {
                return _modo;
            }
            set
            {
                _modo = value;
            }
        }

        public string codigoproducto
        {
            get
            {
                return _codigoproducto;
            }
            set
            {
                _codigoproducto = value;
            }
        }

        public double idetalleproducto
        {
            get
            {
                return _idetalleproducto;
            }
            set
            {
                _idetalleproducto = value;
            }
        }

        public int idusuario
        {
            get
            {
                return _idusuario;
            }
            set
            {
                _idusuario = value;
            }
        }

        public int idaccionmovil
        {
            get
            {
                return _idaccionmovil;
            }
            set
            {
                _idaccionmovil = value;
            }
        }

        public int idubicacionorigen
        {
            get
            {
                return _idubicacionorigen;
            }
            set
            {
                _idubicacionorigen = value;
            }
        }

        public int idubicaciondestino
        {
            get
            {
                return _idubicaciondestino;
            }
            set
            {
                _idubicaciondestino = value;
            }
        }

        public int idtiporden
        {
            get
            {
                return _idtiporden;
            }
            set
            {
                _idtiporden = value;
            }
        }

        public delegate void ButtonClick(object sender, EventArgs e);
        public event ButtonClick OnButtonClick;

        public UbicarProductoV()
        {
            InitializeComponent();
            btnubicar.Click += new EventHandler((sender, args) =>
            {
                OnButtonClick?.Invoke(this, null);
            });
        }

        private void btnubicar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnubicar.BackColor == Color.Green)
                {
                    btnubicar.BackColor = Color.Empty;
                }
                else
                {
                    btnubicar.BackColor = Color.Green;
                }
                if (ideposito != 0 && ideposito != 3 && bloque != "" && rackpasillo != "" && btnubicar.BackColor == Color.Green)
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
                    idubicacion = 0;
                }
            }
            catch (Exception)
            {


            }
        }

        private void abrirpanel(Panel pubic)
        {
            pubic.Visible = true;
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
                lblrackpasillo.Text = bloque + rackpasillo;
                progressBarubic.Minimum = 0;
                progressBarubic.Maximum = capacidad;
                progressBarubic.Value = utilizado;
                if (estado)
                {
                    lblrackpasillo.BackColor = Color.Green;
                    btnubicar.Enabled = true;
                }
                else
                {
                    lblrackpasillo.BackColor = Color.Red;
                    btnubicar.Enabled = false;
                }
            }

        }

        public void listaproductosxubicacion(DataTable data)
        {
            if (ideposito != 0 && bloque != "" && rackpasillo != "" && disponible > 0)
            {
                E_Deposito.Ideposito = ideposito;
                E_Deposito.Bloque = bloque;
                E_Deposito.RackPasillo = rackpasillo;
                data = orden.ListarProductosxdepositobloquerackpasillo();
            }
            else
            {
                data = null;
            }

        }

        
    }
}
