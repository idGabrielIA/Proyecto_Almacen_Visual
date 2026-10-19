using Proyecto_Almacen.Controllers;
using Proyecto_Almacen.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Almacen.Views
{
    public partial class Form_Producto : Form
    {
        // 1. Declarar la variable del texto guía (FALTABA ESTO)
        private string placeholderTexto = "Ingresar el Nombre de Producto";
        public Form_Producto()
        {
            this.FormBorderStyle = FormBorderStyle.None;

            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen; // Forzar a que el formulario se centre al iniciar
            // Deshabilitar la caja de texto del ID al iniciar el formulario
            textBox_id_producto.Enabled = false;

            // (Opcional: Si también quieres que aparezca con un fondo gris claro característico de deshabilitado)
            textBox_id_producto.ReadOnly = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_Producto_Load(object sender, EventArgs e)
        {
            textBox_buscar_producto.Text = placeholderTexto;
            textBox_buscar_producto.ForeColor = System.Drawing.Color.Gray;
        }
        private void CargarSubcategorias()
        {
            string mensajeError = "";
            DataTable dt = ConexionBD_Gabriel.ObtenerSubcategorias(out mensajeError);

            if (string.IsNullOrEmpty(mensajeError))
            {
                comboBox_subcategoria.DataSource = dt;
                comboBox_subcategoria.DisplayMember = "nombre_subcategoria";
                comboBox_subcategoria.ValueMember = "id_subcategoria";
            }
            else
            {
                MessageBox.Show("Error al cargar subcategorías: " + mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void comboBox_subcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_verproducto_Click(object sender, EventArgs e)
        {

            // Aquí debes llamar a CargarProductos para que recién salgan los registros al hacer clic
            CargarProductos();
            CargarSubcategorias();
        }

        private void CargarProductos()
        {
            string mensajeError = "";
            DataTable dtProductos = ConexionBD_Gabriel.ObtenerProductos(out mensajeError);

            if (string.IsNullOrEmpty(mensajeError))
            {
                dataGridView1.DataSource = dtProductos;
            }
            else
            {
                MessageBox.Show("No se pudieron cargar los productos.\nDetalles: " + mensajeError,
                                "Error de Consulta",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void button_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_buscar_producto_TextChanged(object sender, EventArgs e)
        {
            // Si el texto es el placeholder o está vacío, no filtramos
            if (textBox_buscar_producto.Text == placeholderTexto || string.IsNullOrWhiteSpace(textBox_buscar_producto.Text))
            {
                return;
            }

            string mensajeError = "";
            DataTable dtProductos = ConexionBD_Gabriel.ObtenerProductos(out mensajeError);

            if (string.IsNullOrEmpty(mensajeError) && dtProductos != null)
            {
                DataView dv = dtProductos.DefaultView;
                dv.RowFilter = $"nombre_producto LIKE '%{textBox_buscar_producto.Text.Replace("'", "''")}%'";
                dataGridView1.DataSource = dv.ToTable();
            }
        }

       

        private void textBox_buscar_producto_Enter(object sender, EventArgs e)
        {
            if (textBox_buscar_producto.Text == placeholderTexto)
            {
                textBox_buscar_producto.Text = "";
                textBox_buscar_producto.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBox_buscar_producto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_buscar_producto.Text))
            {
                textBox_buscar_producto.Text = placeholderTexto;
                textBox_buscar_producto.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que no se haga clic en los encabezados de la tabla
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                // 1. Llenar las cajas de texto (Ajusta los nombres si tus TextBox se llaman diferente)
                textBox_id_producto.Text = fila.Cells["id_producto"].Value.ToString();

                // Ejemplo de los demás campos (reemplaza por los nombres reales de tus TextBox si varían):
                 textBox_codigo.Text = fila.Cells["codigo_producto"].Value.ToString();
                 textBox_nombre_producto.Text = fila.Cells["nombre_producto"].Value.ToString();
                 textBox_precio_venta.Text = fila.Cells["precio_venta"].Value.ToString();
                 textBox_unidad_medida.Text = fila.Cells["unidad_medida"].Value.ToString();

                // 2. Seleccionar automáticamente la subcategoría en el ComboBox
                if (fila.Cells["id_subcategoria"].Value != DBNull.Value)
                {
                    comboBox_subcategoria.SelectedValue = fila.Cells["id_subcategoria"].Value;
                }
            }
        }

        private void button_nuevo_Click(object sender, EventArgs e)
        {
            // Limpiamos todas las cajas de texto del mantenimiento
            textBox_id_producto.Clear();
            textBox_codigo.Clear();
            textBox_nombre_producto.Clear();
            textBox_precio_venta.Clear();
            textBox_unidad_medida.Clear();

            // Restablecemos el ComboBox para que no muestre ninguna selección activa
            if (comboBox_subcategoria.Items.Count > 0)
            {
                comboBox_subcategoria.SelectedIndex = -1;
            }
        }

        private void textBox_nombre_producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite letras, espacios y la tecla de borrar (BackSpace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Cancela la tecla presionada si no cumple la condición
            }
        }

        private void textBox_precio_venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            // Permite números, la tecla de borrar y el punto decimal
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Evita que se escriba más de un punto decimal
            if (e.KeyChar == '.' && txt != null && txt.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }
    }
}
    
    

