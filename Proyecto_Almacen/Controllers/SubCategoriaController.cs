using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Almacen.Models;

namespace Proyecto_Almacen.Controllers
{
    public class SubCategoriaController
    {
        public static DataTable ListarSubcategorias(out string error)
        {
            return ConexionBD_Gabriel.ObtenerSubcategorias(out error);
        }

        public static DataTable ListarCategorias(out string error)
        {
            return ConexionBD_Gabriel.ObtenerCategoriasParaSubcategoria(out error);
        }
    }
}