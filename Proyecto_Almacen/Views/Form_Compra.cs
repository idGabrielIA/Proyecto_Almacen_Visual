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
    public partial class Form_Compra : Form
    {
        private string placeholderTexto = "Ingresar el Nombre de Proveedor o Almacem";
        public Form_Compra()
        {
            this.FormBorderStyle = FormBorderStyle.None;

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Deshabilitar la caja de texto del ID al iniciar
            textBox_id_compra.Enabled = false;
            textBox_id_compra.ReadOnly = true;
        }

        private void comboBox_producto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form_Compra_Load(object sender, EventArgs e)
        {
            textBox_buscar_compra.Text = placeholderTexto;
            textBox_buscar_compra.ForeColor = System.Drawing.Color.Gray;

            // Ajustar la grilla automáticamente al ancho
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // ---> ¡ESTA LÍNEA DEBE ESTAR AQUÍ SÍ O SÍ! <---
            CargarComboBoxes();
        }

        private void button_vercompra_Click(object sender, EventArgs e)
        {
            CargarCompras();
        }

        private void CargarCompras()
        {
            string mensajeError = "";
            DataTable dtCompras = ConexionBD_Gabriel.ObtenerCompras(out mensajeError);

            if (string.IsNullOrEmpty(mensajeError))
            {
                dataGridView1.DataSource = dtCompras;
            }
            else
            {
                MessageBox.Show("No se pudieron cargar las compras.\nDetalles: " + mensajeError,
                                "Error de Consulta",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
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

        private void textBox_buscar_compra_TextChanged(object sender, EventArgs e)
        {
            if (textBox_buscar_compra.Text == placeholderTexto || string.IsNullOrWhiteSpace(textBox_buscar_compra.Text))
            {
                return;
            }

            string mensajeError = "";
            DataTable dtCompras = ConexionBD_Gabriel.ObtenerCompras(out mensajeError);

            if (string.IsNullOrEmpty(mensajeError) && dtCompras != null)
            {
                string textoBusqueda = textBox_buscar_compra.Text.Trim();
                var resultados = from row in dtCompras.AsEnumerable()
                                 let proveedorStr = row["proveedor"] != null ? row["proveedor"].ToString() : ""
                                 let almacenStr = row["almacen"] != null ? row["almacen"].ToString() : "" // <--- Cambiado a almacén
                                 where proveedorStr.IndexOf(textoBusqueda, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                       almacenStr.IndexOf(textoBusqueda, StringComparison.OrdinalIgnoreCase) >= 0  // <--- Evaluando el almacén
                                 select row;

                if (resultados.Any())
                {
                    dataGridView1.DataSource = resultados.CopyToDataTable();
                }
                else
                {
                    dataGridView1.DataSource = dtCompras.Clone(); // Muestra la tabla vacía si no hay coincidencias
                }
            }
        }

        private void textBox_buscar_compra_Enter(object sender, EventArgs e)
        {
            if (textBox_buscar_compra.Text == placeholderTexto)
            {
                textBox_buscar_compra.Text = "";
                textBox_buscar_compra.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBox_buscar_compra_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_buscar_compra.Text))
            {
                textBox_buscar_compra.Text = placeholderTexto;
                textBox_buscar_compra.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                textBox_id_compra.Text = fila.Cells["id_compra"].Value.ToString();

                // Al asignar el ValueMember con los IDs reales, el ComboBox seleccionará automáticamente el nombre correspondiente
                comboBox_proveedor.Text = fila.Cells["proveedor"].Value.ToString();
                comboBox_almacen.Text = fila.Cells["almacen"].Value.ToString();
                comboBox_personal.Text = fila.Cells["personal"].Value.ToString();

                textBox_fecha.Text = fila.Cells["fecha"].Value.ToString();
                textBox_total.Text = fila.Cells["total"].Value.ToString();
            }
        }

        private void button_nuevo_Click(object sender, EventArgs e)
        {
            textBox_id_compra.Clear();
            textBox_fecha.Clear();
            textBox_total.Clear();

            if (comboBox_proveedor.Items.Count > 0) comboBox_proveedor.SelectedIndex = -1;
            if (comboBox_almacen.Items.Count > 0) comboBox_almacen.SelectedIndex = -1;
            if (comboBox_personal.Items.Count > 0) comboBox_personal.SelectedIndex = -1;

            comboBox_proveedor.Focus();
        }
        private void CargarComboBoxes()
        {
            string error = "";

            // 1. Proveedor
            DataTable dtProveedor = CompraController.ListarProveedores(out error);
            if (string.IsNullOrEmpty(error))
            {
                comboBox_proveedor.DataSource = dtProveedor;
                comboBox_proveedor.DisplayMember = "nombre";
                comboBox_proveedor.ValueMember = "id_proveedor";
                comboBox_proveedor.SelectedIndex = -1; // <--- Esto evita que se seleccione solo
            }

            // 2. Almacén
            DataTable dtAlmacen = CompraController.ListarAlmacenes(out error);
            if (string.IsNullOrEmpty(error))
            {
                comboBox_almacen.DataSource = dtAlmacen;
                comboBox_almacen.DisplayMember = "nombre_almacen";
                comboBox_almacen.ValueMember = "id_almacen";
                comboBox_almacen.SelectedIndex = -1; // <--- Esto evita que se seleccione solo
            }

            // 3. Personal
            DataTable dtPersonal = CompraController.ListarPersonal(out error);
            if (string.IsNullOrEmpty(error))
            {
                comboBox_personal.DataSource = dtPersonal;
                comboBox_personal.DisplayMember = "nombre_completo";
                comboBox_personal.ValueMember = "id_personal";
                comboBox_personal.SelectedIndex = -1; // <--- Esto evita que se seleccione solo
            }
        }

        private void textBox_total_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir números, la tecla Backspace y un solo punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Bloquea la tecla si no es número ni punto
            }

            // Permitir solo un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
    

    
}
