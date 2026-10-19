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
    public partial class Form_Tipo_Personal : Form
    {
        private string placeholderTexto = "Ingresar el Nombre de Tipo Personal";
        public Form_Tipo_Personal()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // 1. Restringir código / ID
            textBox_id_tipo_personal.Enabled = false; // Ajusta si tu caja de código tiene otro nombre en el diseño
            textBox_id_tipo_personal.ReadOnly = true;

            // 2. Enlazar eventos del Buscador por código (Placeholder y Filtrado)
            this.textBox_buscar.Enter += new System.EventHandler(this.textBox_buscar_Enter);
            this.textBox_buscar.Leave += new System.EventHandler(this.textBox_buscar_Leave);
            this.textBox_buscar.TextChanged += new System.EventHandler(this.textBox_buscar_TextChanged);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_verTIPO_PERSONAL_Click(object sender, EventArgs e)
        {
            string error = "";
            DataTable dt = Tipo_PersonalController.ListarTipoPersonal(out error);
            if (string.IsNullOrEmpty(error))
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Error al cargar tipo de personal: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_Tipo_Personal_Load(object sender, EventArgs e)
        {
            textBox_buscar.Text = placeholderTexto;
            textBox_buscar.ForeColor = Color.Gray;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                textBox_id_tipo_personal.Text = fila.Cells["id_tipo_personal"].Value.ToString();
                textBox_nombre_tipo_personal.Text = fila.Cells["nombre_tipo_personal"].Value.ToString();
                textBox_observaciones.Text = fila.Cells["observaciones"].Value.ToString();
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
                    dv.RowFilter = $"nombre_tipo_personal LIKE '%{textBox_buscar.Text}%'";
                }
                catch { }
            }
        }

        private void button_nuevo_Click(object sender, EventArgs e)
        {
            textBox_id_tipo_personal.Clear();
            textBox_nombre_tipo_personal.Clear();
            textBox_observaciones.Clear();

            textBox_nombre_tipo_personal.Focus();
        }

        private void button_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
