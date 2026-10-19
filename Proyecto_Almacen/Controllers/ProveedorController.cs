using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Almacen.Models;

namespace Proyecto_Almacen.Controllers
{
    public class ProveedorController
    {
        public static DataTable ListarProveedores(out string error)
        {
            return ConexionBD_Gabriel.ObtenerProveedores(out error);
        }
    }
}