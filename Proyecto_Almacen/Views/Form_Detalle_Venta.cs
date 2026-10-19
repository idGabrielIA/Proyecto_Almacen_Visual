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

namespace Proyecto_Almacen.Views
{
    public partial class Form_Detalle_Venta : Form
    {
        private string placeholderTexto = "Ingresar el Nombre de Detalle Venta";
        public Form_Detalle_Venta()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Restringir ID Detalle Venta
            textBox_codigo_detalle_venta.Enabled = false;
            textBox_codigo_detalle_venta.ReadOnly = true;
            this.textBox_buscar_detalle_venta.Enter += new System.EventHandler(this.textBox_buscar_detalle_venta_Enter);
            this.textBox_buscar_detalle_venta.Leave += new System.EventHandler(this.textBox_buscar_detalle_venta_Leave);
        }

        private void button_verdetalleventa_Click(object sender, EventArgs e)
        {
            string error = "";
            DataTable dt = Detalle_VentaController.ListarDetalleVentas(out error);
            if (string.IsNullOrEmpty(error))
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Error al listar detalle de venta: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_Detalle_Venta_Load(object sender, EventArgs e)
        {
            textBox_buscar_detalle_venta.Text = placeholderTexto;
            textBox_buscar_detalle_venta.ForeColor = Color.Gray;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            CargarComboBoxes();
        }

        private void CargarComboBoxes()
        {
            string error = "";

            // 1. ComboBox Producto (Muestra el nombre del producto)
            DataTable dtProd = Detalle_VentaController.ListarProductos(out error);
            if (string.IsNullOrEmpty(error))
            {
                comboBox_producto.DataSource = dtProd;
                comboBox_producto.DisplayMember = "nombre_producto";
                comboBox_producto.ValueMember = "id_producto";
                comboBox_producto.SelectedIndex = -1;
            }

            // 2. ComboBox ID Venta
            DataTable dtVenta = Detalle_VentaController.ListarIDsVenta(out error);
            if (string.IsNullOrEmpty(error))
            {
                comboBox_venta.DataSource = dtVenta;
                comboBox_venta.DisplayMember = "id_venta";
                comboBox_venta.ValueMember = "id_venta";
                comboBox_venta.SelectedIndex = -1;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                textBox_buscar_detalle_venta.Text = fila.Cells["id_detalle_venta"].Value.ToString();
                comboBox_venta.Text = fila.Cells["id_venta"].Value.ToString();
                comboBox_producto.Text = fila.Cells["producto"].Value.ToString();
                textBox_cantidad.Text = fila.Cells["cantidad"].Value.ToString();
                textBox_precio_venta.Text = fila.Cells["precio_venta"].Value.ToString();
            }
        }

        private void button_nuevo_Click(object sender, EventArgs e)
        {
            textBox_buscar_detalle_venta.Clear();
            textBox_cantidad.Clear();
            textBox_precio_venta.Clear();

            if (comboBox_venta.Items.Count > 0) comboBox_venta.SelectedIndex = -1;
            if (comboBox_producto.Items.Count > 0) comboBox_producto.SelectedIndex = -1;

            comboBox_venta.Focus();
        }

        private void button_cerrar_Click(object sender, EventArgs e)
        {
            // Mostramos una ventana de advertencia con botones Sí y No
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que deseas cerrar este formulario?",
                "Advertencia de Cierre",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            // Si el usuario hace clic en "Sí", cerramos el formulario
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void textBox_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Bloquea cualquier letra o símbolo no permitido
            }

            // Permitir un único punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox_precio_venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Bloquea cualquier letra o símbolo no permitido
            }

            // Permitir un único punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox_buscar_detalle_venta_Enter(object sender, EventArgs e)
        {
            // Si tiene el texto por defecto, lo limpia al hacer clic y cambia el color a negro
            if (textBox_buscar_detalle_venta.Text == placeholderTexto)
            {
                textBox_buscar_detalle_venta.Text = "";
                textBox_buscar_detalle_venta.ForeColor = Color.Black;
            }
        }

        private void textBox_cantidad_Leave(object sender, EventArgs e)
        {

        }

        private void textBox_buscar_detalle_venta_Leave(object sender, EventArgs e)
        {
            // Si el usuario sale y queda vacío, vuelve a poner el texto guía en gris
            if (string.IsNullOrWhiteSpace(textBox_buscar_detalle_venta.Text))
            {
                textBox_buscar_detalle_venta.Text = placeholderTexto;
                textBox_buscar_detalle_venta.ForeColor = Color.Gray;
            }
        }

        private void textBox_buscar_detalle_venta_TextChanged(object sender, EventArgs e)
        {

            string mensajeError = "";
            // Asegúrate de usar el método de tu capa de conexión para los detalles de venta
            DataTable dtDetalleVenta = ConexionBD_Gabriel.ObtenerDetalleVentas(out mensajeError);

            if (string.IsNullOrEmpty(mensajeError) && dtDetalleVenta != null)
            {
                string textoBusqueda = textBox_buscar_detalle_venta.Text.Trim();

                var resultados = from row in dtDetalleVenta.AsEnumerable()
                                 let productoStr = row["producto"] != null ? row["producto"].ToString() : ""
                                 where productoStr.IndexOf(textoBusqueda, StringComparison.OrdinalIgnoreCase) >= 0
                                 select row;

                if (resultados.Any())
                {
                    dataGridView1.DataSource = resultados.CopyToDataTable();
                }
                else
                {
                    dataGridView1.DataSource = dtDetalleVenta.Clone(); // Muestra la tabla vacía si no hay coincidencias
                }
            }
        }
    }
}

