using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using CapaEntidades.Cache;
using System.Data;
using System.Drawing;
using CapaDatos;
using System.Windows.Forms;
using CapaDatos.Services;

namespace CapaNegocio
{
    public class M_Depositos
    {
        D_Depositos dep = new D_Depositos();
        D_Cliente cli = new D_Cliente();
        FileServices archivo = new FileServices();

        public DataTable ListarDepositos()
        {
            return dep.ListaDepositos();
        }

        public DataTable ListarUbicacionesxDepositos()
        {
            return dep.ListaUbicacionesxDeposito();
        }

        public DataTable ListarUbicacionesxDepositosparaetiquetas()
        {
            return dep.ListaUbicacionesxDepositoparaetiquetas();
        }

        public DataTable Listarstatusrackpasillosxdeposito()
        {
            return dep.ListastatusreckapasilloxDeposito();
        }

        public void Checkubicacionseleccionada()
        {
            dep.Checkubicacionseleccionadaxdepbloquerackpasillopos();
        }

        public void Checkidubicacion()
        {
            dep.Checkubicacionseleccionadaxdepbloquerackpasillopos();
        }

        public void Consultaubicacionxidubicacion()
        {
            dep.Consultaubicacionseleccionadaxidubicacion ();
        }

        public void Checkstatusdeposito()
        {
            dep.Checkstatusdeposito();
        }

        public void Checkstatusxideposito()
        {
            dep.Checkstatusxideposito();
        }

        public void Checkstatusrackpasilloxidepositobloquerackpasillo()
        {
             dep.Checkstatusrackpasilloxidepositobloquerackpasillo();
        }


        public DataTable combodepositos()
        {
            return dep.ComboDepositos();
        }

        public DataTable combocliente()
        {
            return cli.ComboClientes();
        }

        public void ModificarCapacidad()
        {
            if (E_Deposito.Ideposito != 3)
            {
                dep.ModificarCapacidadUbicacion();
            }
        }

        public void ModificarEstadoUbicacion()
        {
            if (E_Deposito.Ideposito != 3)
            {
                dep.ModificarEstadoUbicacion();
            }
        }

        public void Insertareserva()
        {
            if (E_Deposito.Ideposito != 3)
            {
                dep.AgregarReservaUbicacion();
            } else
            {
                dep.Reservarubicacionenrackrefrigerado();
            }
            
        }

        public void Anulareserva()
        {
            if (E_Deposito.Ideposito != 3)
            {
                dep.AnularReservaUbicacion();
            }
            else
            {
                dep.Anulareservarubicacionenrackrefrigerado();
            }

        }

        public void ExportarExcel()
        {
            DataTable grilla = ListarUbicacionesxDepositos();
            try
            {
                archivo.ExportarExcel(grilla);
            }
            catch (Exception)
            {

                
            }
        }

        public Bitmap GeneraQR(string codigo,int tamimg)
        {
            try
            {
               return archivo.imagenQR(codigo,tamimg);
            }
            catch (Exception)
            {

                return null;
            }
        }

    }
}
