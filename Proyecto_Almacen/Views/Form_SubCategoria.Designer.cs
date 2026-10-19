namespace Proyecto_Almacen.Views
{
    partial class Form_SubCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_versubcategoria = new System.Windows.Forms.Button();
            this.comboBox_categoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_descripcion = new System.Windows.Forms.TextBox();
            this.textBox_nombre_subcategoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_id_subcategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_buscarsubcategoria = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_buscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_cerrar = new System.Windows.Forms.Button();
            this.button_modificar = new System.Windows.Forms.Button();
            this.button_guardar = new System.Windows.Forms.Button();
            this.button_nuevo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_buscarsubcategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(316, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANTENIMIENTO DE SUBCATEGORIA";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_versubcategoria);
            this.panel1.Controls.Add(this.comboBox_categoria);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_descripcion);
            this.panel1.Controls.Add(this.textBox_nombre_subcategoria);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_id_subcategoria);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 110);
            this.panel1.TabIndex = 2;
            // 
            // button_versubcategoria
            // 
            this.button_versubcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_versubcategoria.Image = global::Proyecto_Almacen.Properties.Resources.lista_de_verificacion;
            this.button_versubcategoria.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_versubcategoria.Location = new System.Drawing.Point(604, 19);
            this.button_versubcategoria.Name = "button_versubcategoria";
            this.button_versubcategoria.Size = new System.Drawing.Size(194, 40);
            this.button_versubcategoria.TabIndex = 8;
            this.button_versubcategoria.Text = "VER SUBCATEGORIAS";
            this.button_versubcategoria.UseVisualStyleBackColor = true;
            this.button_versubcategoria.Click += new System.EventHandler(this.button_versubcategoria_Click);
            // 
            // comboBox_categoria
            // 
            this.comboBox_categoria.FormattingEnabled = true;
            this.comboBox_categoria.Location = new System.Drawing.Point(419, 63);
            this.comboBox_categoria.Name = "comboBox_categoria";
            this.comboBox_categoria.Size = new System.Drawing.Size(130, 21);
            this.comboBox_categoria.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(339, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(339, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descripcion";
            // 
            // textBox_descripcion
            // 
            this.textBox_descripcion.Location = new System.Drawing.Point(419, 12);
            this.textBox_descripcion.Name = "textBox_descripcion";
            this.textBox_descripcion.Size = new System.Drawing.Size(170, 20);
            this.textBox_descripcion.TabIndex = 4;
            // 
            // textBox_nombre_subcategoria
            // 
            this.textBox_nombre_subcategoria.Location = new System.Drawing.Point(152, 63);
            this.textBox_nombre_subcategoria.Name = "textBox_nombre_subcategoria";
            this.textBox_nombre_subcategoria.Size = new System.Drawing.Size(170, 20);
            this.textBox_nombre_subcategoria.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre SubCategoria";
            // 
            // textBox_id_subcategoria
            // 
            this.textBox_id_subcategoria.Location = new System.Drawing.Point(152, 12);
            this.textBox_id_subcategoria.Name = "textBox_id_subcategoria";
            this.textBox_id_subcategoria.Size = new System.Drawing.Size(170, 20);
            this.textBox_id_subcategoria.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo SubCategoria";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel_buscarsubcategoria
            // 
            this.panel_buscarsubcategoria.BackColor = System.Drawing.Color.Black;
            this.panel_buscarsubcategoria.Controls.Add(this.label8);
            this.panel_buscarsubcategoria.Controls.Add(this.textBox_buscar);
            this.panel_buscarsubcategoria.Controls.Add(this.label6);
            this.panel_buscarsubcategoria.Location = new System.Drawing.Point(19, 217);
            this.panel_buscarsubcategoria.Name = "panel_buscarsubcategoria";
            this.panel_buscarsubcategoria.Size = new System.Drawing.Size(766, 38);
            this.panel_buscarsubcategoria.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Image = global::Proyecto_Almacen.Properties.Resources.lupa;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(584, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 30);
            this.label8.TabIndex = 2;
            this.label8.Text = "Buscar";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_buscar
            // 
            this.textBox_buscar.Location = new System.Drawing.Point(229, 10);
            this.textBox_buscar.Name = "textBox_buscar";
            this.textBox_buscar.Size = new System.Drawing.Size(323, 20);
            this.textBox_buscar.TabIndex = 1;
            this.textBox_buscar.TextChanged += new System.EventHandler(this.textBox_buscar_TextChanged);
            this.textBox_buscar.Enter += new System.EventHandler(this.textBox_buscar_Enter);
            this.textBox_buscar.Leave += new System.EventHandler(this.textBox_buscar_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(38, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ingresar el Nombre de SubCategoria";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 185);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_cerrar
            // 
            this.button_cerrar.Image = global::Proyecto_Almacen.Properties.Resources.cerrar_sesion__1_;
            this.button_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cerrar.Location = new System.Drawing.Point(686, 444);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(124, 41);
            this.button_cerrar.TabIndex = 7;
            this.button_cerrar.Text = "CERRAR";
            this.button_cerrar.UseVisualStyleBackColor = true;
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // button_modificar
            // 
            this.button_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modificar.Image = global::Proyecto_Almacen.Properties.Resources.actualizar;
            this.button_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_modificar.Location = new System.Drawing.Point(606, 152);
            this.button_modificar.Name = "button_modificar";
            this.button_modificar.Size = new System.Drawing.Size(155, 48);
            this.button_modificar.TabIndex = 4;
            this.button_modificar.Text = "MODIFICAR";
            this.button_modificar.UseVisualStyleBackColor = true;
            // 
            // button_guardar
            // 
            this.button_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_guardar.Image = global::Proyecto_Almacen.Properties.Resources.guardar_carpeta;
            this.button_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_guardar.Location = new System.Drawing.Point(337, 152);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(155, 48);
            this.button_guardar.TabIndex = 3;
            this.button_guardar.Text = "GUARDAR";
            this.button_guardar.UseVisualStyleBackColor = true;
            // 
            // button_nuevo
            // 
            this.button_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_nuevo.Image = global::Proyecto_Almacen.Properties.Resources.nueva_cuenta;
            this.button_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nuevo.Location = new System.Drawing.Point(69, 152);
            this.button_nuevo.Name = "button_nuevo";
            this.button_nuevo.Size = new System.Drawing.Size(155, 48);
            this.button_nuevo.TabIndex = 1;
            this.button_nuevo.Text = "NUEVO";
            this.button_nuevo.UseVisualStyleBackColor = true;
            this.button_nuevo.Click += new System.EventHandler(this.button_nuevo_Click);
            // 
            // Form_SubCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 497);
            this.Controls.Add(this.button_cerrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel_buscarsubcategoria);
            this.Controls.Add(this.button_modificar);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_nuevo);
            this.Controls.Add(this.label1);
            this.Name = "Form_SubCategoria";
            this.Text = "Form_SubCategoria";
            this.Load += new System.EventHandler(this.Form_SubCategoria_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_buscarsubcategoria.ResumeLayout(false);
            this.panel_buscarsubcategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_nuevo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_descripcion;
        private System.Windows.Forms.TextBox textBox_nombre_subcategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_id_subcategoria;
        private System.Windows.Forms.Button button_versubcategoria;
        private System.Windows.Forms.ComboBox comboBox_categoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.Button button_modificar;
        private System.Windows.Forms.Panel panel_buscarsubcategoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_buscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_cerrar;
    }
}