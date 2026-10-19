using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Almacen.Models;

namespace Proyecto_Almacen.Controllers
{
    public class Movimiento_InventarioController
    {
        public static DataTable ListarMovimientos(out string error)
        {
            return ConexionBD_Gabriel.ObtenerMovimientosInventario(out error);
        }

        public static DataTable ListarProductos(out string error)
        {
            return ConexionBD_Gabriel.ObtenerProductosParaInventario(out error);
        }

        public static DataTable ListarAlmacenes(out string error)
        {
            return ConexionBD_Gabriel.ObtenerAlmacenesParaInventario(out error);
        }

        public static DataTable ListarPersonal(out string error)
        {
            return ConexionBD_Gabriel.ObtenerPersonalParaMovimiento(out error);
        }
    }
}