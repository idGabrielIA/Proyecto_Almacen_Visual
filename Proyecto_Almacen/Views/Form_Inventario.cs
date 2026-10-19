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
    public partial class Form_Inventario : Form
    {
        private string placeholderTexto = "Ingresar el Nombre de Inventario";
        public Form_Inventario()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            textBox_id_inventario.Enabled = false;
            textBox_id_inventario.ReadOnly = true;
            this.textBox_buscar_inventario.TextChanged += new System.EventHandler(this.textBox_buscar_inventario_TextChanged);
        }
        

        private void Form_Inventario_Load(object sender, EventArgs e)
        {
            textBox_buscar_inventario.Text = placeholderTexto;
            textBox_buscar_inventario.ForeColor = Color.Gray;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            comboBox_almacen.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_producto.DropDownStyle = ComboBoxStyle.DropDownList;

            CargarComboBoxes();
        }

        private void CargarComboBoxes()
        {
            string error = "";

            // 1. Almacén
            DataTable dtAlm = InventarioController.ListarAlmacenes(out error);
            if (string.IsNullOrEmpty(error))
            {
                comboBox_almacen.DataSource = dtAlm;
                comboBox_almacen.DisplayMember = "nombre_almacen";
                comboBox_almacen.ValueMember = "id_almacen";
                comboBox_almacen.SelectedIndex = -1;
            }

            // 2. Producto
            DataTable dtProd = InventarioController.ListarProductos(out error);
            if (string.IsNullOrEmpty(error))
            {
                comboBox_producto.DataSource = dtProd;
                comboBox_producto.DisplayMember = "nombre_producto";
                comboBox_producto.ValueMember = "id_producto";
                comboBox_producto.SelectedIndex = -1;
            }
        }

        private void button_verinventario_Click(object sender, EventArgs e)
        {
            string error = "";
            DataTable dt = InventarioController.ListarInventario(out error);
            if (string.IsNullOrEmpty(error))
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Error al cargar inventario: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                textBox_id_inventario.Text = fila.Cells["id_inventario"].Value.ToString();
                comboBox_almacen.Text = fila.Cells["almacen"].Value.ToString();
                comboBox_producto.Text = fila.Cells["producto"].Value.ToString();
                textBox_stock_actual.Text = fila.Cells["stock_actual"].Value.ToString();
                textBox_stock_minimo.Text = fila.Cells["stock_minimo"].Value.ToString();
                textBox_ultima_actualizacion.Text = fila.Cells["ultima_actualizacion"].Value.ToString();
            }
        }

        private void button_nuevo_Click(object sender, EventArgs e)
        {
            textBox_id_inventario.Clear();
            textBox_stock_actual.Clear();
            textBox_stock_minimo.Clear();
            textBox_ultima_actualizacion.Clear();

            if (comboBox_almacen.Items.Count > 0) comboBox_almacen.SelectedIndex = -1;
            if (comboBox_producto.Items.Count > 0) comboBox_producto.SelectedIndex = -1;

            comboBox_almacen.Focus();
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

        private void textBox_stock_actual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea cualquier letra o símbolo
            }
        }

        private void textBox_stock_minimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea cualquier letra o símbolo
            }
        }

        private void textBox_buscar_inventario_TextChanged(object sender, EventArgs e)
        {
            if (textBox_buscar_inventario.Text == placeholderTexto || string.IsNullOrWhiteSpace(textBox_buscar_inventario.Text))
            {
                return;
            }

            string mensajeError = "";
            DataTable dtInventario = ConexionBD_Gabriel.ObtenerInventario(out mensajeError); // Asegúrate de usar tu método correspondiente

            if (string.IsNullOrEmpty(mensajeError) && dtInventario != null)
            {
                string textoBusqueda = textBox_buscar_inventario.Text.Trim();

                var resultados = from row in dtInventario.AsEnumerable()
                                 let almacenStr = row["almacen"] != null ? row["almacen"].ToString() : ""
                                 let productoStr = row["producto"] != null ? row["producto"].ToString() : ""
                                 where almacenStr.IndexOf(textoBusqueda, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                       productoStr.IndexOf(textoBusqueda, StringComparison.OrdinalIgnoreCase) >= 0
                                 select row;

                if (resultados.Any())
                {
                    dataGridView1.DataSource = resultados.CopyToDataTable();
                }
                else
                {
                    dataGridView1.DataSource = dtInventario.Clone(); // Muestra la grilla vacía si no encuentra coincidencias
                }
            }
        }

        private void textBox_buscar_inventario_Enter(object sender, EventArgs e)
        {
            // Si el texto actual es el placeholder, lo borramos y ponemos el color negro normal
            if (textBox_buscar_inventario.Text == placeholderTexto)
            {
                textBox_buscar_inventario.Text = "";
                textBox_buscar_inventario.ForeColor = Color.Black;
            }
        }

        private void textBox_buscar_inventario_Leave(object sender, EventArgs e)
        {
            // Si la caja se queda vacía al salir, volvemos a colocar el placeholder en gris
            if (string.IsNullOrWhiteSpace(textBox_buscar_inventario.Text))
            {
                textBox_buscar_inventario.Text = placeholderTexto;
                textBox_buscar_inventario.ForeColor = Color.Gray;
            }
        }
    }
    
}
