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
    public partial class Form_SubCategoria : Form
    {
        private string placeholderTexto = "Ingresar el Nombre de SubCategoria";
        public Form_SubCategoria()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // 1. Restringir código / ID
            textBox_id_subcategoria.Enabled = false; // Ajusta el nombre si tu caja de código se llama distinto
            textBox_id_subcategoria.ReadOnly = true;

            // 2. Enlazar eventos del Buscador (Placeholder y Filtrado)
            this.textBox_buscar.Enter += new System.EventHandler(this.textBox_buscar_Enter);
            this.textBox_buscar.Leave += new System.EventHandler(this.textBox_buscar_Leave);
            this.textBox_buscar.TextChanged += new System.EventHandler(this.textBox_buscar_TextChanged);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form_SubCategoria_Load(object sender, EventArgs e)
        {
            textBox_buscar.Text = placeholderTexto;
            textBox_buscar.ForeColor = Color.Gray;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            CargarComboBoxCategoria();
        }

        private void CargarComboBoxCategoria()
        {
            string error = "";
            DataTable dt = SubCategoriaController.ListarCategorias(out error);
            if (string.IsNullOrEmpty(error))
            {
                comboBox_categoria.DataSource = dt;
                comboBox_categoria.DisplayMember = "nombre"; // Ajusta según la columna de tu tabla categoria
                comboBox_categoria.ValueMember = "id_categoria";
                comboBox_categoria.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Error al cargar categorías: " + error, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // BLOQUEAR ESCRITURA MANUAL EN EL COMBOBOX (Solo selección)
            comboBox_categoria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_versubcategoria_Click(object sender, EventArgs e)
        {
            string error = "";
            DataTable dt = SubCategoriaController.ListarSubcategorias(out error);
            if (string.IsNullOrEmpty(error))
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Error al cargar subcategorías: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                textBox_id_subcategoria.Text = fila.Cells["id_subcategoria"].Value.ToString();
                comboBox_categoria.Text = fila.Cells["categoria"].Value.ToString();
                textBox_nombre_subcategoria.Text = fila.Cells["nombre_subcategoria"].Value.ToString();
                textBox_descripcion.Text = fila.Cells["descripcion"].Value.ToString();
            }
        }

        private void textBox_buscar_Enter(object sender, EventArgs e)
        {
           
            if (textBox_buscar.Text == placeholderTexto)
            {
                textBox_buscar.Text = "";
                textBox_buscar.ForeColor = Color.Black;
            }
        }

        private void textBox_buscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_buscar.Text))
            {
                textBox_buscar.Text = placeholderTexto;
                textBox_buscar.ForeColor = Color.Gray;
            }
        }

        private void textBox_buscar_TextChanged(object sender, EventArgs e)
        {
            if (textBox_buscar.Text != placeholderTexto && dataGridView1.DataSource != null)
            {
                try
                {
                    DataView dv = ((DataTable)dataGridView1.DataSource).DefaultView;
                    dv.RowFilter = $"nombre_subcategoria LIKE '%{textBox_buscar.Text}%'";
                }
                catch { }
            }
        }

        private void button_nuevo_Click(object sender, EventArgs e)
        {
            textBox_id_subcategoria.Clear();
            textBox_nombre_subcategoria.Clear();
            textBox_descripcion.Clear();
            if (comboBox_categoria.Items.Count > 0) comboBox_categoria.SelectedIndex = -1;

            comboBox_categoria.Focus();
        }

        private void button_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
