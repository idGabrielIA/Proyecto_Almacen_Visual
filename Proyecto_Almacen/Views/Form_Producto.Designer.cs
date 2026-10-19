namespace Proyecto_Almacen.Views
{
    partial class Form_Producto
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel_mant_producto = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_buscar_producto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_unidad_medida = new System.Windows.Forms.TextBox();
            this.textBox_precio_venta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_verproducto = new System.Windows.Forms.Button();
            this.comboBox_subcategoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_nombre_producto = new System.Windows.Forms.TextBox();
            this.textBox_codigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_id_producto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_dardebaja = new System.Windows.Forms.Button();
            this.button_cerrar = new System.Windows.Forms.Button();
            this.button_modificar = new System.Windows.Forms.Button();
            this.button_guardar = new System.Windows.Forms.Button();
            this.button_nuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_mant_producto.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 185);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel_mant_producto
            // 
            this.panel_mant_producto.BackColor = System.Drawing.Color.Black;
            this.panel_mant_producto.Controls.Add(this.label8);
            this.panel_mant_producto.Controls.Add(this.textBox_buscar_producto);
            this.panel_mant_producto.Controls.Add(this.label6);
            this.panel_mant_producto.Location = new System.Drawing.Point(12, 224);
            this.panel_mant_producto.Name = "panel_mant_producto";
            this.panel_mant_producto.Size = new System.Drawing.Size(766, 38);
            this.panel_mant_producto.TabIndex = 13;
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
            // textBox_buscar_producto
            // 
            this.textBox_buscar_producto.Location = new System.Drawing.Point(229, 10);
            this.textBox_buscar_producto.Name = "textBox_buscar_producto";
            this.textBox_buscar_producto.Size = new System.Drawing.Size(323, 20);
            this.textBox_buscar_producto.TabIndex = 1;
            this.textBox_buscar_producto.TextChanged += new System.EventHandler(this.textBox_buscar_producto_TextChanged);
            this.textBox_buscar_producto.Enter += new System.EventHandler(this.textBox_buscar_producto_Enter);
            this.textBox_buscar_producto.Leave += new System.EventHandler(this.textBox_buscar_producto_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(38, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ingresar el Nombre de Producto";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_unidad_medida);
            this.panel1.Controls.Add(this.textBox_precio_venta);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button_verproducto);
            this.panel1.Controls.Add(this.comboBox_subcategoria);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_nombre_producto);
            this.panel1.Controls.Add(this.textBox_codigo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_id_producto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(5, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 139);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox_unidad_medida
            // 
            this.textBox_unidad_medida.Location = new System.Drawing.Point(431, 103);
            this.textBox_unidad_medida.Name = "textBox_unidad_medida";
            this.textBox_unidad_medida.Size = new System.Drawing.Size(170, 20);
            this.textBox_unidad_medida.TabIndex = 12;
            // 
            // textBox_precio_venta
            // 
            this.textBox_precio_venta.Location = new System.Drawing.Point(431, 54);
            this.textBox_precio_venta.Name = "textBox_precio_venta";
            this.textBox_precio_venta.Size = new System.Drawing.Size(170, 20);
            this.textBox_precio_venta.TabIndex = 11;
            this.textBox_precio_venta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_precio_venta_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(302, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Unidad Medida";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Codigo";
            // 
            // button_verproducto
            // 
            this.button_verproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_verproducto.Image = global::Proyecto_Almacen.Properties.Resources.lista_de_verificacion;
            this.button_verproducto.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_verproducto.Location = new System.Drawing.Point(607, 19);
            this.button_verproducto.Name = "button_verproducto";
            this.button_verproducto.Size = new System.Drawing.Size(194, 40);
            this.button_verproducto.TabIndex = 8;
            this.button_verproducto.Text = "VER PRODUCTO";
            this.button_verproducto.UseVisualStyleBackColor = true;
            this.button_verproducto.Click += new System.EventHandler(this.button_verproducto_Click);
            // 
            // comboBox_subcategoria
            // 
            this.comboBox_subcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_subcategoria.FormattingEnabled = true;
            this.comboBox_subcategoria.Location = new System.Drawing.Point(101, 58);
            this.comboBox_subcategoria.Name = "comboBox_subcategoria";
            this.comboBox_subcategoria.Size = new System.Drawing.Size(170, 21);
            this.comboBox_subcategoria.TabIndex = 7;
            this.comboBox_subcategoria.SelectedIndexChanged += new System.EventHandler(this.comboBox_subcategoria_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(302, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Precio Venta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre de Producto";
            // 
            // textBox_nombre_producto
            // 
            this.textBox_nombre_producto.Location = new System.Drawing.Point(431, 12);
            this.textBox_nombre_producto.Name = "textBox_nombre_producto";
            this.textBox_nombre_producto.Size = new System.Drawing.Size(170, 20);
            this.textBox_nombre_producto.TabIndex = 4;
            this.textBox_nombre_producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_nombre_producto_KeyPress);
            // 
            // textBox_codigo
            // 
            this.textBox_codigo.Location = new System.Drawing.Point(101, 106);
            this.textBox_codigo.Name = "textBox_codigo";
            this.textBox_codigo.Size = new System.Drawing.Size(170, 20);
            this.textBox_codigo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = " SubCategoria";
            // 
            // textBox_id_producto
            // 
            this.textBox_id_producto.Location = new System.Drawing.Point(101, 12);
            this.textBox_id_producto.Name = "textBox_id_producto";
            this.textBox_id_producto.Size = new System.Drawing.Size(170, 20);
            this.textBox_id_producto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(322, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "MANTENIMIENTO DE PRODUCTO";
            // 
            // button_dardebaja
            // 
            this.button_dardebaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dardebaja.Image = global::Proyecto_Almacen.Properties.Resources.borrar;
            this.button_dardebaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_dardebaja.Location = new System.Drawing.Point(632, 170);
            this.button_dardebaja.Name = "button_dardebaja";
            this.button_dardebaja.Size = new System.Drawing.Size(155, 48);
            this.button_dardebaja.TabIndex = 16;
            this.button_dardebaja.Text = "DAR DE BAJA";
            this.button_dardebaja.UseVisualStyleBackColor = true;
            // 
            // button_cerrar
            // 
            this.button_cerrar.Image = global::Proyecto_Almacen.Properties.Resources.cerrar_sesion__1_;
            this.button_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cerrar.Location = new System.Drawing.Point(679, 451);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(124, 41);
            this.button_cerrar.TabIndex = 15;
            this.button_cerrar.Text = "CERRAR";
            this.button_cerrar.UseVisualStyleBackColor = true;
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // button_modificar
            // 
            this.button_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modificar.Image = global::Proyecto_Almacen.Properties.Resources.actualizar;
            this.button_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_modificar.Location = new System.Drawing.Point(436, 170);
            this.button_modificar.Name = "button_modificar";
            this.button_modificar.Size = new System.Drawing.Size(155, 48);
            this.button_modificar.TabIndex = 12;
            this.button_modificar.Text = "MODIFICAR";
            this.button_modificar.UseVisualStyleBackColor = true;
            // 
            // button_guardar
            // 
            this.button_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_guardar.Image = global::Proyecto_Almacen.Properties.Resources.guardar_carpeta;
            this.button_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_guardar.Location = new System.Drawing.Point(241, 170);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(155, 48);
            this.button_guardar.TabIndex = 11;
            this.button_guardar.Text = "GUARDAR";
            this.button_guardar.UseVisualStyleBackColor = true;
            // 
            // button_nuevo
            // 
            this.button_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_nuevo.Image = global::Proyecto_Almacen.Properties.Resources.nueva_cuenta;
            this.button_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nuevo.Location = new System.Drawing.Point(35, 170);
            this.button_nuevo.Name = "button_nuevo";
            this.button_nuevo.Size = new System.Drawing.Size(155, 48);
            this.button_nuevo.TabIndex = 9;
            this.button_nuevo.Text = "NUEVO";
            this.button_nuevo.UseVisualStyleBackColor = true;
            this.button_nuevo.Click += new System.EventHandler(this.button_nuevo_Click);
            // 
            // Form_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 516);
            this.Controls.Add(this.button_dardebaja);
            this.Controls.Add(this.button_cerrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel_mant_producto);
            this.Controls.Add(this.button_modificar);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_nuevo);
            this.Controls.Add(this.label1);
            this.Name = "Form_Producto";
            this.Text = "Form_Producto";
            this.Load += new System.EventHandler(this.Form_Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_mant_producto.ResumeLayout(false);
            this.panel_mant_producto.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_cerrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel_mant_producto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_buscar_producto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_modificar;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_verproducto;
        private System.Windows.Forms.ComboBox comboBox_subcategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_nombre_producto;
        private System.Windows.Forms.TextBox textBox_codigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_id_producto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_nuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_unidad_medida;
        private System.Windows.Forms.TextBox textBox_precio_venta;
        private System.Windows.Forms.Button button_dardebaja;
    }
}