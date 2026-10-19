using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Almacen.Controllers;

namespace Proyecto_Almacen.Views
{
    public partial class Form_Venta : Form
    {
        public Form_Venta()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Bloquear campos de totales y comprobante para control exclusivo del sistema
            textBox_subtotal.Enabled = false;
            textBox_igv.Enabled = false;
            textBox_total.Enabled = false;

            textBox_subtotal.ReadOnly = true;
            textBox_igv.ReadOnly = true;
            textBox_total.ReadOnly = true;
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

        private void Form_Venta_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Definir las columnas en orden estricto
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("codigo", "Código");
                dataGridView1.Columns.Add("nombre_producto", "Producto");
                dataGridView1.Columns.Add("unidad_medida", "Unidad");
                dataGridView1.Columns.Add("precio_venta", "Precio S/.");
                dataGridView1.Columns.Add("cantidad", "Cantidad");
                dataGridView1.Columns.Add("subtotal", "Subtotal S/.");
            }
        }
        private void button_buscar_Click(object sender, EventArgs e)
        {
            string criterio = textBox_nombre_cliente.Text.Trim();
            string error = "";

            if (string.IsNullOrEmpty(criterio))
            {
                MessageBox.Show("Por favor, ingrese el nombre del cliente para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = VentaController.BuscarCliente(criterio, out error);

            if (string.IsNullOrEmpty(error))
            {
                if (dt.Rows.Count > 0)
                {
                    textBox_nombre_cliente.Text = dt.Rows[0]["nombre_cliente"].ToString();
                    textBox_direccion.Text = dt.Rows[0]["direccion"].ToString();
                    textBox_telefono.Text = dt.Rows[0]["telefono"].ToString();
                    textBox_correo.Text = dt.Rows[0]["correo"].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró ningún cliente registrado con ese nombre.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Error al buscar el cliente: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Quitarfila_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                CalcularTotalesVenta();
            }
            else
            {
                MessageBox.Show("Seleccione una fila de la grilla para quitar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CalcularTotalesVenta()
        {
            decimal subtotal = 0;
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.Cells["subtotal"].Value != null)
                {
                    subtotal += Convert.ToDecimal(fila.Cells["subtotal"].Value);
                }
            }

            decimal igv = subtotal * 0.19m;
            decimal total = subtotal + igv;

            textBox_subtotal.Text = subtotal.ToString("N2");
            textBox_igv.Text = igv.ToString("N2");
            textBox_total.Text = total.ToString("N2");
        }

        private void button_cliente_Click(object sender, EventArgs e)
        {
            // Creamos una ventana emergente rápida para seleccionar el cliente
            Form formSeleccion = new Form();
            formSeleccion.Text = "Seleccionar Cliente";
            formSeleccion.Size = new Size(600, 400);
            formSeleccion.StartPosition = FormStartPosition.CenterParent;
            formSeleccion.FormBorderStyle = FormBorderStyle.FixedDialog;
            formSeleccion.MaximizeBox = false;
            formSeleccion.MinimizeBox = false;

            DataGridView dgvClientes = new DataGridView();
            dgvClientes.Dock = DockStyle.Fill;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.ReadOnly = true;

            string error = "";
            DataTable dt = VentaController.ListarClientesParaSeleccion(out error);
            if (string.IsNullOrEmpty(error))
            {
                dgvClientes.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Error al cargar clientes: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            formSeleccion.Controls.Add(dgvClientes);

            // Evento al hacer doble clic en un cliente de la lista
            dgvClientes.CellDoubleClick += (s, ev) =>
            {
                if (ev.RowIndex >= 0)
                {
                    DataGridViewRow fila = dgvClientes.Rows[ev.RowIndex];

                    // Se autocompletan los campos en tu Form_Venta
                    textBox_nombre_cliente.Text = fila.Cells["nombre_cliente"].Value.ToString();
                    textBox_direccion.Text = fila.Cells["direccion"].Value.ToString();
                    textBox_telefono.Text = fila.Cells["telefono"].Value.ToString();
                    textBox_correo.Text = fila.Cells["correo"].Value.ToString();

                    formSeleccion.Close(); // Cierra el selector
                }
            };

            formSeleccion.ShowDialog();
        }

        private void button_Agregar_producto_Click(object sender, EventArgs e)
        {
            // 1. Crear ventana emergente personalizada
            Form formSeleccionProd = new Form();
            formSeleccionProd.Text = "Información de los productos disponibles";
            formSeleccionProd.Size = new Size(750, 480);
            formSeleccionProd.StartPosition = FormStartPosition.CenterParent;
            formSeleccionProd.FormBorderStyle = FormBorderStyle.FixedDialog;
            formSeleccionProd.MaximizeBox = false;
            formSeleccionProd.MinimizeBox = false;

            // 2. DataGridView para mostrar los productos
            DataGridView dgvProductos = new DataGridView();
            dgvProductos.Location = new Point(12, 12);
            dgvProductos.Size = new Size(710, 320);
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.ReadOnly = true;

            string error = "";
            DataTable dt = VentaController.ListarProductosParaVenta(out error);
            if (string.IsNullOrEmpty(error))
            {
                dgvProductos.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Error al cargar productos: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Etiqueta y Caja de texto para ingresar la cantidad
            Label lblCantidad = new Label();
            lblCantidad.Text = "Ingrese la cantidad:";
            lblCantidad.Location = new Point(420, 350);
            lblCantidad.AutoSize = true;

            TextBox txtCantidad = new TextBox();
            txtCantidad.Location = new Point(530, 347);
            txtCantidad.Size = new Size(80, 22);
            txtCantidad.Text = "1"; // Valor por defecto

            // 4. Botón de agregar dentro de la ventana flotante
            Button btnAgregar = new Button();
            btnAgregar.Text = "AGREGAR";
            btnAgregar.Location = new Point(625, 345);
            btnAgregar.Size = new Size(95, 28);
            btnAgregar.BackColor = Color.FromArgb(46, 139, 87); // Estilo verde similar al de tu app
            btnAgregar.ForeColor = Color.White;
            btnAgregar.FlatStyle = FlatStyle.Flat;

            // Añadir controles a la ventana flotante
            formSeleccionProd.Controls.Add(dgvProductos);
            formSeleccionProd.Controls.Add(lblCantidad);
            formSeleccionProd.Controls.Add(txtCantidad);
            formSeleccionProd.Controls.Add(btnAgregar);

            // 5. Lógica al hacer clic en el botón AGREGAR de la ventana flotante
            btnAgregar.Click += (s, ev) =>
            {
                if (dgvProductos.SelectedRows.Count > 0)
                {
                    DataGridViewRow fila = dgvProductos.SelectedRows[0];

                    // Validar que se haya ingresado una cantidad numérica válida
                    if (!int.TryParse(txtCantidad.Text.Trim(), out int cantidad) || cantidad <= 0)
                    {
                        MessageBox.Show("Por favor, ingrese una cantidad válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string codigoProd = fila.Cells["codigo"].Value.ToString();
                    string nombreProducto = fila.Cells["nombre_producto"].Value.ToString();
                    string unidadMedida = fila.Cells["unidad_medida"].Value.ToString();
                    decimal precioProducto = Convert.ToDecimal(fila.Cells["precio_venta"].Value);

                    // Verificar si el producto ya existe en la grilla principal
                    bool productoExiste = false;
                    foreach (DataGridViewRow rowGrilla in dataGridView1.Rows)
                    {
                        if (rowGrilla.Cells["codigo"].Value != null && rowGrilla.Cells["codigo"].Value.ToString() == codigoProd)
                        {
                            int cantActual = Convert.ToInt32(rowGrilla.Cells["cantidad"].Value);
                            int nuevaCant = cantActual + cantidad; // Suma la nueva cantidad ingresada
                            rowGrilla.Cells["cantidad"].Value = nuevaCant;
                            rowGrilla.Cells["subtotal"].Value = nuevaCant * precioProducto;
                            productoExiste = true;
                            break;
                        }
                    }

                    // Si no existe, se añade como nueva fila con la cantidad escrita
                    if (!productoExiste)
                    {
                        decimal subtotalItem = precioProducto * cantidad;
                        dataGridView1.Rows.Add(codigoProd, nombreProducto, unidadMedida, precioProducto.ToString("N2"), cantidad, subtotalItem.ToString("N2"));
                    }

                    // Recalcular totales generales automáticamente
                    CalcularTotalesVenta();

                    formSeleccionProd.Close(); // Cierra la ventana emergente
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un producto de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };

            formSeleccionProd.ShowDialog();
        }
    }
}
