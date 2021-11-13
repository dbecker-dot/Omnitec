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
    public class M_Cliente
    {
        D_Cliente cli = new D_Cliente();

        public DataTable ListarClientes(string busqueda)
        {
            return cli.ListarClientes(busqueda);
        }

        public DataTable ListarCuitpais(string busqueda)
        {
            return cli.ListarCuitpais(busqueda);
        }

        public DataTable comboclientes()
        {
            return cli.ComboClientesactivos();
        }

        public int CheckidclientexCliente()
        {
            return cli.Checkidclientexcliente();
        }

        public string CheckcodclientexIdcliente()
        {
            return cli.CheckCodigoclientexidcliente ();
        }

        public DataTable comboclientesordenesactivas()
        {
            return cli.ComboClientesordenesactivas();
        }
    }
}
