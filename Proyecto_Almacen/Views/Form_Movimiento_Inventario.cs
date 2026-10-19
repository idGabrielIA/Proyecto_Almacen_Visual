using Proyecto_Almacen.Controllers;
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
    public partial class Form_Movimiento_Inventario : Form
    {
        private string placeholderTexto = "Ingresar el Nombre de Movimiento";
        public Form_Movimiento_Inventario()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Restringir ID Movimiento
            textBox_id_movimiento_inventario.Enabled = false;
            textBox_id_movimiento_inventario.ReadOnly = true;
        }

        private void Form_Movimiento_Inventario_Load(object sender, EventArgs e)
        {
            textBox_buscar_movimiento.Text = placeholderTexto;
            textBox_buscar_movimiento.ForeColor = Color.Gray;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            CargarComboBoxes();
        }

        private void CargarComboBoxes()
        {
            string error = "";

            // 1. Producto
            DataTable dtProd = Movimiento_InventarioController.ListarProductos(out error);
            if (string.IsNullOrEmpty(error))
            {
                comboBox_producto.DataSource = dtProd;
                comboBox_producto.DisplayMember = "nombre_producto";
                comboBox_producto.ValueMember = "id_producto";
                comboBox_producto.SelectedIndex = -1;
            }

            // 2. Almacén
            DataTable dtAlm = Movimiento_InventarioController.ListarAlmacenes(out error);
            if (string.IsNullOrEmpty(error))
            {
                comboBox_almacen.DataSource = dtAlm;
                comboBox_almacen.DisplayMember = "nombre_almacen";
                comboBox_almacen.ValueMember = "id_almacen";
                comboBox_almacen.SelectedIndex = -1;
            }

            // 3. Personal
            DataTable dtPers = Movimiento_InventarioController.ListarPersonal(out error);
            if (string.IsNullOrEmpty(error))
            {
                comboBox_personal.DataSource = dtPers;
                comboBox_personal.DisplayMember = "nombre"; // Ajustar si es nombre completo
                comboBox_personal.ValueMember = "id_personal";
                comboBox_personal.SelectedIndex = -1;
            }

            // 4. Tipo Movimiento (Ej: ENTRADA / SALIDA) - Asumiendo que es ComboBox o TextBox según diseño
            if (comboBox_tipo_movimiento != null)
            {
                comboBox_tipo_movimiento.Items.Clear();
                comboBox_tipo_movimiento.Items.Add("ENTRADA");
                comboBox_tipo_movimiento.Items.Add("SALIDA");
                comboBox_tipo_movimiento.SelectedIndex = -1;
            }

            // BLOQUEAR ESCRITURA MANUAL EN TODOS LOS COMBOBOX (Solo selección)
            comboBox_producto.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_almacen.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_personal.DropDownStyle = ComboBoxStyle.DropDownList;
            if (comboBox_tipo_movimiento != null) comboBox_tipo_movimiento.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button_vermovimiento_Click(object sender, EventArgs e)
        {
            string error = "";
            DataTable dt = Movimiento_InventarioController.ListarMovimientos(out error);
            if (string.IsNullOrEmpty(error))
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Error al cargar movimientos: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                textBox_id_movimiento_inventario.Text = fila.Cells["id_movimiento_inventario"].Value.ToString();
                comboBox_producto.Text = fila.Cells["producto"].Value.ToString();
                comboBox_almacen.Text = fila.Cells["almacen"].Value.ToString();
                comboBox_personal.Text = fila.Cells["personal"].Value.ToString();

                if (comboBox_tipo_movimiento != null)
                    comboBox_tipo_movimiento.Text = fila.Cells["tipo_movimiento"].Value.ToString();

                textBox_cantidad.Text = fila.Cells["cantidad"].Value.ToString();
                textBox_fecha.Text = fila.Cells["fecha"].Value.ToString();
            }
        }

        private void textBox_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true; // Bloquea letras, permite números y el signo menos si hay salidas negativas
            }
        }

        private void button_nuevo_Click(object sender, EventArgs e)
        {
            textBox_id_movimiento_inventario.Clear();
            textBox_cantidad.Clear();
            textBox_fecha.Clear();

            if (comboBox_producto.Items.Count > 0) comboBox_producto.SelectedIndex = -1;
            if (comboBox_almacen.Items.Count > 0) comboBox_almacen.SelectedIndex = -1;
            if (comboBox_personal.Items.Count > 0) comboBox_personal.SelectedIndex = -1;
            if (comboBox_tipo_movimiento != null && comboBox_tipo_movimiento.Items.Count > 0) comboBox_tipo_movimiento.SelectedIndex = -1;

            comboBox_producto.Focus();
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

        private void textBox_buscar_movimiento_Enter(object sender, EventArgs e)
        {
            if (textBox_buscar_movimiento.Text == placeholderTexto)
            {
                textBox_buscar_movimiento.Text = "";
                textBox_buscar_movimiento.ForeColor = Color.Black;
            }
        }

        private void textBox_buscar_movimiento_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_buscar_movimiento.Text))
            {
                textBox_buscar_movimiento.Text = placeholderTexto;
                textBox_buscar_movimiento.ForeColor = Color.Gray;
            }
        }

        private void textBox_buscar_movimiento_TextChanged(object sender, EventArgs e)
        {
            // Evita filtrar si el texto actual es el placeholder
            if (textBox_buscar_movimiento.Text != placeholderTexto && dataGridView1.DataSource != null)
            {
                try
                {
                    DataView dv = ((DataTable)dataGridView1.DataSource).DefaultView;
                    // Filtra por la columna "producto" (puedes cambiarla según lo que muestres en tu grilla)
                    dv.RowFilter = $"producto LIKE '%{textBox_buscar_movimiento.Text}%'";
                }
                catch
                {
                    // Manejo por si la columna especificada no existe en el filtro actual
                }
            }
        }

        private void comboBox_tipo_movimiento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
