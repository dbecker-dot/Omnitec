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
    public class M_Productos
    {
        D_Productos prod = new D_Productos();

        public DataTable ListarCosechas()
        {
            return prod.ListaCosechas();
        }

        public DataTable ComboCosechas()
        {
            return prod.ComboCosechashab();
        }

        public DataTable ListarGranos()
        {
            return prod.ListaGranos();
        }

        public DataTable ComboGranos()
        {
            return prod.ComboGranoshab();
        }

        public void InsertarCosecha()
        {
            prod.AgregarCosecha();
        }

        public int Checkcosechaxcosecha()
        {
            return prod.Checkidcosechaxcosecha();
        }

        public void Checkcosechactual()
        {
            prod.Checkcosechactual();
        }

        public void ModifarCosecha()
        {
            prod.ModificarCosecha();
        }

        public int Checkidtipoproductoxtipo()
        {
            return prod.Checkidtipoproductoxtipoproducto();
        }

        public string  Checkcodtipoproductoxidtipoproducto()
        {
            return prod.CheckCodigotipoproductoxidtipoproducto();
        }

        public int Checkidgranoxgrano()
        {
            return prod.CheckIdgranoxgrano();
        }

        public string Checkcodgranoxidgrano()
        {
            return prod.CheckCodigranoxidgrano ();
        }

        public void InsertarGrano()
        {
            prod.AgregarGrano();
        }

        public void ModifarGrano()
        {
            prod.ModificarGrano();
        }


    }
}
