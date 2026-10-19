using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Almacen.Models;

namespace Proyecto_Almacen.Controllers
{
    public class VentaController
    {
        // Método para listar todas las ventas en la grilla general
        public static DataTable ListarVentas(out string error)
        {
            return ConexionBD_Gabriel.ObtenerVentas(out error);
        }

        // Método para buscar un cliente por su nombre y autocompletar la venta
        public static DataTable BuscarCliente(string criterio, out string error)
        {
            return ConexionBD_Gabriel.BuscarClienteParaVenta(criterio, out error);
        }
        public static DataTable ListarClientesParaSeleccion(out string error)
        {
            return ConexionBD_Gabriel.ObtenerTodosLosClientes(out error);
        }
        public static DataTable ListarProductosParaVenta(out string error)
        {
            return ConexionBD_Gabriel.ObtenerTodosLosProductos(out error);
        }
    }
}