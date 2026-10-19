using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto_Almacen.Models
{
    public class ConexionBD_Gabriel
    {
        private static readonly string cadenaConexion = "Server=DESKTOP-IHUMEIM\\SQLEXPRESS;Database=bdalmacen;Trusted_Connection=True;TrustServerCertificate=True;";

        public static bool ProbarConexion(out string mensajeError)
        {
            mensajeError = string.Empty;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                mensajeError = ex.Message;
                return false;
            }
        }//FINALIZA

        // Método para consultar la tabla producto
        public static DataTable ObtenerProductos(out string mensajeError)
        {
            mensajeError = string.Empty;
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string query = @"SELECT 
                                p.id_producto,
                                p.codigo AS codigo_producto,
                                p.nombre_producto,
                                c.nombre AS categoria,
                                p.id_subcategoria,
                                sc.nombre_subcategoria,
                                p.precio_venta,
                                p.unidad_medida,
                                p.estado
                             FROM dbo.producto p
                             INNER JOIN dbo.subcategoria sc ON p.id_subcategoria = sc.id_subcategoria
                             INNER JOIN dbo.categoria c ON sc.id_categoria = c.id_categoria";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            conexion.Open();
                            adaptador.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                mensajeError = ex.Message;
            }

            return dt;
        }/*Finaliza metodo*/

        public static DataTable ObtenerSubcategorias(out string mensajeError)
        {
            mensajeError = string.Empty;
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conexionBD_Gabriel = new SqlConnection(cadenaConexion))
                {
                    string query = @"SELECT 
                                        sc.id_subcategoria,
                                        c.nombre AS categoria,
                                        sc.nombre_subcategoria,
                                        sc.descripcion
                                     FROM dbo.subcategoria sc
                                     INNER JOIN dbo.categoria c ON sc.id_categoria = c.id_categoria";
                    using (SqlCommand comando = new SqlCommand(query, conexionBD_Gabriel))
                    {
                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            conexionBD_Gabriel.Open();
                            adaptador.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                mensajeError = ex.Message;
            }

            return dt;
        }

        public static DataTable ObtenerClientes(out string mensajeError)
        {
            mensajeError = string.Empty;
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string query = @"SELECT 
                                id_cliente,
                                nombre_cliente,
                                direccion,
                                telefono,
                                correo
                             FROM dbo.cliente";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            conexion.Open();
                            adaptador.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                mensajeError = ex.Message;
            }

            return dt;
        }

        // Método para consultar la tabla compra
        public static DataTable ObtenerCompras(out string mensajeError)
        {
            mensajeError = string.Empty;
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string query = @"SELECT 
                                c.id_compra,
                                p.nombre AS proveedor,
                                a.nombre_almacen AS almacen,
                                (per.nombres + ' ' + per.apellidos) AS personal,
                                c.fecha,
                                c.total
                             FROM dbo.compra c
                             INNER JOIN dbo.proveedor p ON c.id_proveedor = p.id_proveedor
                             INNER JOIN dbo.almacen a ON c.id_almacen = a.id_almacen
                             INNER JOIN dbo.personal per ON c.id_personal = per.id_personal";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            conexion.Open();
                            adaptador.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                mensajeError = ex.Message;
            }

            return dt;
        }

        // CORREGIDO: Proveedores (Usa 'nombre' en lugar de 'nombre_proveedor')
        public static DataTable ObtenerProveedores(out string mensajeError)
        {
            mensajeError = string.Empty;
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string query = @"SELECT 
                                id_proveedor,
                                ruc,
                                nombre,
                                telefono,
                                correo,
                                direccion
                             FROM dbo.proveedor";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            conexion.Open();
                            adaptador.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex) { mensajeError = ex.Message; }
            return dt;
        }

        // Método para Almacenes (Se mantiene igual ya que tu columna es nombre_almacen)
        public static DataTable ObtenerAlmacenes(out string mensajeError)
        {
            mensajeError = string.Empty;
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string query = "SELECT id_almacen, nombre_almacen FROM almacen";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            conexion.Open();
                            adaptador.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex) { mensajeError = ex.Message; }
            return dt;
        }

        // CORREGIDO: Personal (Concatena 'nombres' y 'apellidos' como 'nombre_completo')
        public static DataTable ObtenerPersonal(out string mensajeError)
        {
            mensajeError = string.Empty;
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string query = "SELECT id_personal, (nombres + ' ' + apellidos) AS nombre_completo FROM personal";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            conexion.Open();
                            adaptador.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex) { mensajeError = ex.Message; }
            return dt;
        }
        // Método para listar los Productos (mostrando el nombre en el ComboBox)
        public static DataTable ObtenerProductosParaDetalle(out string mensajeError)
        {
            mensajeError = string.Empty;
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string query = "SELECT id_producto, nombre_producto FROM producto";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            conexion.Open();
                            adaptador.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex) { mensajeError = ex.Message; }
            return dt;
        }

        // Método para listar las Compras (para el ComboBox ID Compra)
        public static DataTable ObtenerIDsCompra(out string mensajeError)
        {
            mensajeError = string.Empty;
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string query = "SELECT id_compra FROM compra";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            conexion.Open();
                            adaptador.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex) { mensajeError = ex.Message; }
            return dt;
        }

        // Método para listar el Detalle de Compra en la grilla (con INNER JOIN para mostrar el nombre del producto)
        public static DataTable ObtenerDetalleCompras(out string mensajeError)
        {
            mensajeError = string.Empty;
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string query = @"SELECT 
                                dc.id_detalle_compra,
                                dc.id_compra,
                                p.nombre_producto AS producto,
                                dc.cantidad,
                                dc.precio_compra,
                                dc.subtotal
                             FROM dbo.detalle_compra dc
                             INNER JOIN dbo.producto p ON dc.id_producto = p.id_producto";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            conexion.Open();
                            adaptador.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex) { mensajeError = ex.Message; }
            return dt;
        }
        // Método para listar el Detalle de Venta en la grilla con INNER JOIN al producto
        public static DataTable ObtenerDetalleVentas(out string mensajeError)
        {
            mensajeError = string.Empty;
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string query = @"SELECT 
                                dv.id_detalle_venta,
                                dv.id_venta,
                                p.nombre_producto AS producto,
                                dv.cantidad,
                                dv.precio_venta
                             FROM dbo.detalle_venta dv
                             INNER JOIN dbo.producto p ON dv.id_producto = p.id_producto";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            conexion.Open();
                            adaptador.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex) { mensajeError = ex.Message; }
            return dt;
        }

        // Método para listar los IDs de Venta en el ComboBox
        public static DataTable ObtenerIDsVenta(out string mensajeError)
        {
            mensajeError = string.Empty;
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string query = "SELECT id_venta FROM venta";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            conexion.Open();
                            adaptador.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex) { mensajeError = ex.Message; }
            return dt;
        }
        public static DataTable ObtenerInventario(out string mensajeError)
        {
            mensajeError = string.Empty;
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string query = @"SELECT 
                                i.id_inventario,
                                a.nombre_almacen AS almacen,
                                p.nombre_producto AS producto,
                                i.stock_actual,
                                i.stock_minimo,
                                i.ultima_actualizacion
                             FROM dbo.inventario i
                             INNER JOIN dbo.almacen a ON i.id_almacen = a.id_almacen
                             INNER JOIN dbo.producto p ON i.id_producto = p.id_producto";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            conexion.Open();
                            adaptador.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex) { mensajeError = ex.Message; }
            return dt;
        }
        // 2. Obtener lista de productos para el ComboBox (muestra nombre_producto)
        public static DataTable ObtenerProductosParaInventario(out string mensajeError)
        {
            mensajeError = string.Empty;
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string query = "SELECT id_producto, nombre_producto FROM producto";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            conexion.Open();
                            adaptador.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex) { mensajeError = ex.Message; }
            return dt;
        }

        // 3. Obtener lista de almacenes para el ComboBox (muestra nombre_almacen)
        public static DataTable ObtenerAlmacenesParaInventario(out string mensajeError)
        {
            mensajeError = string.Empty;
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string query = "SELECT id_almacen, nombre_almacen FROM almacen";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            conexion.Open();
                            adaptador.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex) { mensajeError = ex.Message; }
            return dt;
        }
        // 1. Obtener movimiento de inventario con INNER JOIN para mostrar nombres de Producto, Almacén y Personal
        public static DataTable ObtenerMovimientosInventario(out string mensajeError)
        {
            mensajeError = string.Empty;
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string query = @"SELECT 
                                mi.id_movimiento_inventario,
                                p.nombre_producto AS producto,
                                a.nombre_almacen AS almacen,
                                per.nombres AS personal,
                                mi.tipo_movimiento,
                                mi.cantidad,
                                mi.fecha
                             FROM dbo.movimiento_inventario mi
                             INNER JOIN dbo.producto p ON mi.id_producto = p.id_producto
                             INNER JOIN dbo.almacen a ON mi.id_almacen = a.id_almacen
                             INNER JOIN dbo.personal per ON mi.id_personal = per.id_personal";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            conexion.Open();
                            adaptador.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex) { mensajeError = ex.Message; }
            return dt;
        }

        // 2. Método para listar el Personal (para el ComboBox Personal)
        public static DataTable ObtenerPersonalParaMovimiento(out string mensajeError)
        {
            mensajeError = string.Empty;
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string query = "SELECT id_personal, nombre FROM personal"; // Ajusta 'nombre' si tu columna se llama diferente
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            conexion.Open();
                            adaptador.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex) { mensajeError = ex.Message; }
            return dt;
        }
        

        // 2. Método para poblar el ComboBox de Categorías
        public static DataTable ObtenerCategoriasParaSubcategoria(out string mensajeError)
        {
            mensajeError = string.Empty;
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    // Ajusta 'nombre' si tu columna en categoria se llama distinto (ej. nombre_categoria)
                    string query = "SELECT id_categoria, nombre FROM categoria";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            conexion.Open();
                            adaptador.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex) { mensajeError = ex.Message; }
            return dt;
        }
        // Método para listar los Tipos de Personal en la grilla
        public static DataTable ObtenerTipoPersonal(out string mensajeError)
        {
            mensajeError = string.Empty;
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string query = @"SELECT 
                                id_tipo_personal,
                                nombre_tipo_personal,
                                observaciones
                             FROM dbo.tipo_personal";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            conexion.Open();
                            adaptador.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex) { mensajeError = ex.Message; }
            return dt;
        }
        // Método para buscar al cliente por su nombre en el formulario de ventas
        public static DataTable BuscarClienteParaVenta(string criterio, out string mensajeError)
        {
            mensajeError = string.Empty;
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string query = "SELECT id_cliente, nombre_cliente, direccion, telefono, correo FROM dbo.cliente WHERE nombre_cliente LIKE '%' + @criterio + '%'";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@criterio", criterio);
                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            conexion.Open();
                            adaptador.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex) { mensajeError = ex.Message; }
            return dt;
        }

        // Método para listar las ventas utilizando los INNER JOIN correspondientes
        public static DataTable ObtenerVentas(out string mensajeError)
        {
            mensajeError = string.Empty;
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string query = @"SELECT 
                                v.id_venta,
                                c.nombre_cliente AS cliente,
                                a.nombre_almacen AS almacen,
                                p.nombres AS personal,
                                v.fecha,
                                v.total
                             FROM dbo.venta v
                             INNER JOIN dbo.cliente c ON v.id_cliente = c.id_cliente
                             INNER JOIN dbo.almacen a ON v.id_almacen = a.id_almacen
                             INNER JOIN dbo.personal p ON v.id_personal = p.id_personal";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            conexion.Open();
                            adaptador.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex) { mensajeError = ex.Message; }
            return dt;
        }
        // Listar todos los clientes para el selector
        public static DataTable ObtenerTodosLosClientes(out string mensajeError)
        {
            mensajeError = string.Empty;
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string query = "SELECT id_cliente, nombre_cliente, direccion, telefono, correo FROM dbo.cliente";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            conexion.Open();
                            adaptador.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex) { mensajeError = ex.Message; }
            return dt;
        }
        // Método para listar solo los campos requeridos de la tabla producto
        public static DataTable ObtenerTodosLosProductos(out string mensajeError)
        {
            mensajeError = string.Empty;
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string query = "SELECT codigo, nombre_producto, precio_venta, unidad_medida FROM dbo.producto WHERE estado = 1";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            conexion.Open();
                            adaptador.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex) { mensajeError = ex.Message; }
            return dt;
        }
    }
}