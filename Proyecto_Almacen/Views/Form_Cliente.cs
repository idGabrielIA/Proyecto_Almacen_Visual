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
    public partial class Form_Cliente : Form
    {
        private string placeholderTexto = "Ingresar el Nombre de Cliente";
        public Form_Cliente()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.StartPosition = FormStartPosition.CenterScreen;
            textBox_telefono.MaxLength = 9;
            // Deshabilitar la caja de texto del Código Cliente al iniciar
            // (Asegúrate de cambiar 'textBox1' por el nombre real de tu caja de Código Cliente en el diseñador si difiere)
            textBox_codigo_cliente.Enabled = false;
            textBox_codigo_cliente.ReadOnly = true;

        }

        private void button_ver_cliente_Click(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            string mensajeError = "";
            DataTable dtClientes = ConexionBD_Gabriel.ObtenerClientes(out mensajeError);

            if (string.IsNullOrEmpty(mensajeError))
            {
                dataGridView1.DataSource = dtClientes;
            }
            else
            {
                MessageBox.Show("No se pudieron cargar los clientes.\nDetalles: " + mensajeError,
                                "Error de Consulta",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void Form_Cliente_Load(object sender, EventArgs e)
        {
            textBox_buscar_cliente.Text = placeholderTexto;
            textBox_buscar_cliente.ForeColor = System.Drawing.Color.Gray;
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

        private void textBox_buscar_cliente_TextChanged(object sender, EventArgs e)
        {
            // Si el texto es el placeholder o está vacío, no filtramos
            if (textBox_buscar_cliente.Text == placeholderTexto || string.IsNullOrWhiteSpace(textBox_buscar_cliente.Text))
            {
                return;
            }

            string mensajeError = "";
            DataTable dtClientes = ConexionBD_Gabriel.ObtenerClientes(out mensajeError);

            if (string.IsNullOrEmpty(mensajeError) && dtClientes != null)
            {
                DataView dv = dtClientes.DefaultView;
                dv.RowFilter = $"nombre_cliente LIKE '%{textBox_buscar_cliente.Text.Replace("'", "''")}%'";
                dataGridView1.DataSource = dv.ToTable();
            }
        }

        private void textBox_buscar_cliente_Enter(object sender, EventArgs e)
        {
            if (textBox_buscar_cliente.Text == placeholderTexto)
            {
                textBox_buscar_cliente.Text = "";
                textBox_buscar_cliente.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBox_buscar_cliente_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_buscar_cliente.Text))
            {
                textBox_buscar_cliente.Text = placeholderTexto;
                textBox_buscar_cliente.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que no se haga clic en los encabezados de la tabla
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                // Llenar las cajas de texto de clientes
                textBox_codigo_cliente.Text = fila.Cells["id_cliente"].Value.ToString();
                textBox_nombre_cliente.Text = fila.Cells["nombre_cliente"].Value.ToString();
                textBox_direccion.Text = fila.Cells["direccion"].Value.ToString();
                textBox_telefono.Text = fila.Cells["telefono"].Value.ToString();
                textBox_correo.Text = fila.Cells["correo"].Value.ToString();
            }
        }

        private void button_nuevo_Click(object sender, EventArgs e)
        {
            // Limpiamos todas las cajas de texto del mantenimiento de clientes
            textBox_codigo_cliente.Clear();
            textBox_nombre_cliente.Clear();
            textBox_direccion.Clear();
            textBox_telefono.Clear();
            textBox_correo.Clear();

            textBox_nombre_cliente.Focus();
        }

        private void textBox_nombre_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite letras, espacios y la tecla de borrar (BackSpace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números enteros y la tecla de borrar para el teléfono
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_correo_Validating(object sender, CancelEventArgs e)
        {
            // Verificamos si la caja no está vacía y si le falta el '@'
            if (!string.IsNullOrWhiteSpace(textBox_correo.Text) && !textBox_correo.Text.Contains("@"))
            {
                MessageBox.Show("El correo electrónico debe contener obligatoriamente el símbolo '@'.",
                                "Validación de Correo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                textBox_correo.Focus(); // Mantiene el cursor en la caja de correo para que lo corrija
            }
        }
    }
    
}
