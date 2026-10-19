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
    public partial class Form_Detalle_Compra : Form
    {
        private string placeholderTexto = "Ingresar el Nombre de Detalle Compra";
        public Form_Detalle_Compra()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
           
            this.StartPosition = FormStartPosition.CenterScreen;
            // Restringir ID Detalle Compra
            textBox_codigo_detalle_compra.Enabled = false;
            textBox_codigo_detalle_compra.ReadOnly = true;
            // Vinculamos los eventos de enfoque para que borre el texto al hacer clic
            this.textBox_buscar_compra.Enter += new System.EventHandler(this.textBox_buscar_compra_Enter);
            this.textBox_buscar_compra.Leave += new System.EventHandler(this.textBox_buscar_compra_Leave);
        }
        

        private void Form_Detalle_Compra_Load(object sender, EventArgs e)
        {
            textBox_buscar_compra.Text = placeholderTexto;
            textBox_buscar_compra.ForeColor = Color.Gray;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            CargarComboBoxes();
        }

        private void CargarComboBoxes()
        {
            string error = "";

            // 1. ComboBox Producto (Muestra el nombre del producto)
            DataTable dtProd = Detalle_CompraController.ListarProductos(out error);
            if (string.IsNullOrEmpty(error))
            {
                comboBox_producto.DataSource = dtProd;
                comboBox_producto.DisplayMember = "nombre_producto";
                comboBox_producto.ValueMember = "id_producto";
                comboBox_producto.SelectedIndex = -1;
            }

            // 2. ComboBox ID Compra
            DataTable dtComp = Detalle_CompraController.ListarIDsCompra(out error);
            if (string.IsNullOrEmpty(error))
            {
                comboBox_compra.DataSource = dtComp;
                comboBox_compra.DisplayMember = "id_compra";
                comboBox_compra.ValueMember = "id_compra";
                comboBox_compra.SelectedIndex = -1;
            }
        }

        private void textBox_buscar_compra_TextChanged(object sender, EventArgs e)
        {
            if (textBox_buscar_compra.Text == placeholderTexto || string.IsNullOrWhiteSpace(textBox_buscar_compra.Text))
            {
                return;
            }

            string mensajeError = "";
            // Reemplaza 'ConexionBD_Gabriel.ObtenerDetalleCompra' por el método real que llena tu grilla de detalles
            DataTable dtDetalle = ConexionBD_Gabriel.ObtenerDetalleCompras(out mensajeError);

            if (string.IsNullOrEmpty(mensajeError) && dtDetalle != null)
            {
                string textoBusqueda = textBox_buscar_compra.Text.Trim();

                var resultados = from row in dtDetalle.AsEnumerable()
                                 let productoStr = row["producto"] != null ? row["producto"].ToString() : ""
                                 where productoStr.IndexOf(textoBusqueda, StringComparison.OrdinalIgnoreCase) >= 0
                                 select row;

                if (resultados.Any())
                {
                    dataGridView1.DataSource = resultados.CopyToDataTable();
                }
                else
                {
                    dataGridView1.DataSource = dtDetalle.Clone(); // Muestra la tabla vacía si no encuentra coincidencias
                }
            }
        }

        private void button_verdetallecompra_Click(object sender, EventArgs e)
        {
            string error = "";
            DataTable dt = Detalle_CompraController.ListarDetalleCompras(out error);
            if (string.IsNullOrEmpty(error))
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Error al listar: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                textBox_codigo_detalle_compra.Text = fila.Cells["id_detalle_compra"].Value.ToString();
                comboBox_compra.Text = fila.Cells["id_compra"].Value.ToString();
                comboBox_producto.Text = fila.Cells["producto"].Value.ToString();
                textBox_cantidad.Text = fila.Cells["cantidad"].Value.ToString();
                textBox_precio_compra.Text = fila.Cells["precio_compra"].Value.ToString();
                textBox_subtotal.Text = fila.Cells["subtotal"].Value.ToString();
            }
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

        private void button_nuevo_Click(object sender, EventArgs e)
        {
            textBox_codigo_detalle_compra.Clear();
            textBox_cantidad.Clear();
            textBox_precio_compra.Clear();
            textBox_subtotal.Clear();

            if (comboBox_compra.Items.Count > 0) comboBox_compra.SelectedIndex = -1;
            if (comboBox_producto.Items.Count > 0) comboBox_producto.SelectedIndex = -1;

            comboBox_compra.Focus();
        }

        private void textBox_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox_precio_compra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox_subtotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox_buscar_compra_Enter(object sender, EventArgs e)
        {
            // Si el texto actual es el placeholder, lo borramos y cambiamos el color a negro
            if (textBox_buscar_compra.Text == placeholderTexto)
            {
                textBox_buscar_compra.Text = "";
                textBox_buscar_compra.ForeColor = Color.Black;
            }
        }

        private void textBox_buscar_compra_Leave(object sender, EventArgs e)
        {
            // Si la caja se queda vacía al salir, volvemos a poner el placeholder en gris
            if (string.IsNullOrWhiteSpace(textBox_buscar_compra.Text))
            {
                textBox_buscar_compra.Text = placeholderTexto;
                textBox_buscar_compra.ForeColor = Color.Gray;
            }
        }
    }
    
}
