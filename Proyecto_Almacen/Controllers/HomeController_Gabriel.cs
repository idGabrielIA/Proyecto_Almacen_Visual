using Proyecto_Almacen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Almacen.Controllers
{
    public class HomeController_Gabriel
    {
        public string EjecutarPruebaConexion()
        {
            bool resultado = ConexionBD_Gabriel.ProbarConexion(out string error);

            if (resultado)
            {
                return "¡Conexión exitosa a la base de datos 'bdalmacen'!";
            }
            else
            {
                return $"Error de conexión: {error}";
            }
        }
    }
}
