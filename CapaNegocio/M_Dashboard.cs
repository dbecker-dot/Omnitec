using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using CapaEntidades.Cache;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class M_Dashboard
    {
        public void Dashboardstk(E_Dashboard obj)
        {
            D_Dashboard datastk = new D_Dashboard();
            datastk.Stockxgrano(obj);
            datastk.StockxCliente(obj);
            datastk.SumarioDashboardStock(obj);
        }
    }
}
