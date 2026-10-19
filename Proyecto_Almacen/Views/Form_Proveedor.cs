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
    public partial class Form_Proveedor : Form
    {
        private string placeholderTexto = "Ingresar el Nombre de Proveedor";
        public Form_Proveedor()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // 1. Restringir código/ID de proveedor
            textBox_codigo_proveedor.Enabled = false;
            textBox_codigo_proveedor.ReadOnly = true;
            this.textBox_buscar_proveedor.Enter += new System.EventHandler(this.textBox_buscar_proveedor_Enter );
            this.textBox_buscar_proveedor.Leave += new System.EventHandler(this.textBox_buscar_proveedor_Leave);
            this.textBox_buscar_proveedor.TextChanged += new System.EventHandler(this.textBox_buscar_proveedor_TextChanged);

        }

        private void Form_Proveedor_Load(object sender, EventArgs e)
        {
            // Configuración inicial del buscador con Placeholder
            textBox_buscar_proveedor.Text = placeholderTexto;
            textBox_buscar_proveedor.ForeColor = Color.Gray;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button_ver_proveedores_Click(object sender, EventArgs e)
        {
            string error = "";
            DataTable dt = ProveedorController.ListarProveedores(out error);
            if (string.IsNullOrEmpty(error))
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Error al cargar proveedores: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                textBox_codigo_proveedor.Text = fila.Cells["id_proveedor"].Value.ToString();
                textBox_ruc.Text = fila.Cells["ruc"].Value.ToString();
                textBox_nombre_proveedor.Text = fila.Cells["nombre"].Value.ToString();
                textBox_telefono.Text = fila.Cells["telefono"].Value.ToString();
                textBox_correo.Text = fila.Cells["correo"].Value.ToString();
                textBox_direccion.Text = fila.Cells["direccion"].Value.ToString();
            }
        }

        private void textBox_buscar_proveedor_Enter(object sender, EventArgs e)
        {
            if (textBox_buscar_proveedor.Text == placeholderTexto)
            {
                textBox_buscar_proveedor.Text = "";
                textBox_buscar_proveedor.ForeColor = Color.Black;
            }
        }

        private void textBox_buscar_proveedor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_buscar_proveedor.Text))
            {
                textBox_buscar_proveedor.Text = placeholderTexto;
                textBox_buscar_proveedor.ForeColor = Color.Gray;
            }
        }

        private void textBox_buscar_proveedor_TextChanged(object sender, EventArgs e)
        {
            if (textBox_buscar_proveedor.Text != placeholderTexto && dataGridView1.DataSource != null)
            {
                try
                {
                    DataView dv = ((DataTable)dataGridView1.DataSource).DefaultView;
                    dv.RowFilter = $"nombre LIKE '%{textBox_buscar_proveedor.Text}%'";
                }
                catch { }
            }
        }

        private void button_nuevo_Click(object sender, EventArgs e)
        {
            textBox_codigo_proveedor.Clear();
            textBox_ruc.Clear();
            textBox_nombre_proveedor.Clear();
            textBox_telefono.Clear();
            textBox_correo.Clear();
            textBox_direccion.Clear();

            textBox_ruc.Focus();
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
    }
}
