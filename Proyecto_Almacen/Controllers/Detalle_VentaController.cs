using System;
using System.Collections.Generic;
using System.Data; // <-- NECESARIO para DataTable
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Almacen.Models; // <-- NECESARIO para acceder a ConexionBD_Gabriel

namespace Proyecto_Almacen.Controllers
{
    public class Detalle_VentaController
    {
        public static DataTable ListarDetalleVentas(out string error)
        {
            return ConexionBD_Gabriel.ObtenerDetalleVentas(out error);
        }

        public static DataTable ListarProductos(out string error)
        {
            return ConexionBD_Gabriel.ObtenerProductosParaDetalle(out error);
        }

        public static DataTable ListarIDsVenta(out string error)
        {
            return ConexionBD_Gabriel.ObtenerIDsVenta(out error);
        }
    }
}