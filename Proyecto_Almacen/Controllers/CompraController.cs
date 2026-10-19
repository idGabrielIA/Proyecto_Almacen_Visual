using Proyecto_Almacen.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Almacen.Controllers
{
    public class CompraController
    {
       
            public static DataTable ListarCompras(out string error)
            {
                return ConexionBD_Gabriel.ObtenerCompras(out error);
            }

            public static DataTable ListarProveedores(out string error)
            {
                return ConexionBD_Gabriel.ObtenerProveedores(out error);
            }

            public static DataTable ListarAlmacenes(out string error)
            {
                return ConexionBD_Gabriel.ObtenerAlmacenes(out error);
            }

            public static DataTable ListarPersonal(out string error)
            {
                return ConexionBD_Gabriel.ObtenerPersonal(out error);
            }
        }
    
}
