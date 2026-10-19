using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Almacen.Models;

namespace Proyecto_Almacen.Controllers
{
    public class Tipo_PersonalController
    {
        public static DataTable ListarTipoPersonal(out string error)
        {
            return ConexionBD_Gabriel.ObtenerTipoPersonal(out error);
        }
    }
}