using Proyecto_Almacen.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Almacen.Controllers
{
    public class Detalle_CompraController
    {
        public static DataTable ListarDetalleCompras(out string error)
        {
            return ConexionBD_Gabriel.ObtenerDetalleCompras(out error);
        }

        public static DataTable ListarProductos(out string error)
        {
            return ConexionBD_Gabriel.ObtenerProductosParaDetalle(out error);
        }

        public static DataTable ListarIDsCompra(out string error)
        {
            return ConexionBD_Gabriel.ObtenerIDsCompra(out error);
        }
    }
}
