namespace Proyecto_Almacen.Views
{
    partial class Form_Detalle_Compra
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
            this.button_cerrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel_mant_detalle_compra = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_buscar_compra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_modificar = new System.Windows.Forms.Button();
            this.button_guardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_cantidad = new System.Windows.Forms.TextBox();
            this.comboBox_producto = new System.Windows.Forms.ComboBox();
            this.textBox_subtotal = new System.Windows.Forms.TextBox();
            this.textBox_precio_compra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_verdetallecompra = new System.Windows.Forms.Button();
            this.comboBox_compra = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_codigo_detalle_compra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_nuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_mant_detalle_compra.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_cerrar
            // 
            this.button_cerrar.Image = global::Proyecto_Almacen.Properties.Resources.cerrar_sesion__1_;
            this.button_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cerrar.Location = new System.Drawing.Point(686, 447);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(124, 41);
            this.button_cerrar.TabIndex = 39;
            this.button_cerrar.Text = "CERRAR";
            this.button_cerrar.UseVisualStyleBackColor = true;
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 185);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel_mant_detalle_compra
            // 
            this.panel_mant_detalle_compra.BackColor = System.Drawing.Color.Black;
            this.panel_mant_detalle_compra.Controls.Add(this.label8);
            this.panel_mant_detalle_compra.Controls.Add(this.textBox_buscar_compra);
            this.panel_mant_detalle_compra.Controls.Add(this.label6);
            this.panel_mant_detalle_compra.Location = new System.Drawing.Point(19, 220);
            this.panel_mant_detalle_compra.Name = "panel_mant_detalle_compra";
            this.panel_mant_detalle_compra.Size = new System.Drawing.Size(766, 38);
            this.panel_mant_detalle_compra.TabIndex = 37;
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
            // textBox_buscar_compra
            // 
            this.textBox_buscar_compra.Location = new System.Drawing.Point(229, 10);
            this.textBox_buscar_compra.Name = "textBox_buscar_compra";
            this.textBox_buscar_compra.Size = new System.Drawing.Size(323, 20);
            this.textBox_buscar_compra.TabIndex = 1;
            this.textBox_buscar_compra.TextChanged += new System.EventHandler(this.textBox_buscar_compra_TextChanged);
            this.textBox_buscar_compra.Leave += new System.EventHandler(this.textBox_buscar_compra_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(38, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ingresar el Nombre de Detalle Compra";
            // 
            // button_modificar
            // 
            this.button_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modificar.Image = global::Proyecto_Almacen.Properties.Resources.actualizar;
            this.button_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_modificar.Location = new System.Drawing.Point(606, 166);
            this.button_modificar.Name = "button_modificar";
            this.button_modificar.Size = new System.Drawing.Size(155, 48);
            this.button_modificar.TabIndex = 36;
            this.button_modificar.Text = "MODIFICAR";
            this.button_modificar.UseVisualStyleBackColor = true;
            // 
            // button_guardar
            // 
            this.button_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_guardar.Image = global::Proyecto_Almacen.Properties.Resources.guardar_carpeta;
            this.button_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_guardar.Location = new System.Drawing.Point(332, 166);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(155, 48);
            this.button_guardar.TabIndex = 35;
            this.button_guardar.Text = "GUARDAR";
            this.button_guardar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_cantidad);
            this.panel1.Controls.Add(this.comboBox_producto);
            this.panel1.Controls.Add(this.textBox_subtotal);
            this.panel1.Controls.Add(this.textBox_precio_compra);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button_verdetallecompra);
            this.panel1.Controls.Add(this.comboBox_compra);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_codigo_detalle_compra);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 139);
            this.panel1.TabIndex = 34;
            // 
            // textBox_cantidad
            // 
            this.textBox_cantidad.Location = new System.Drawing.Point(431, 12);
            this.textBox_cantidad.Name = "textBox_cantidad";
            this.textBox_cantidad.Size = new System.Drawing.Size(170, 20);
            this.textBox_cantidad.TabIndex = 14;
            this.textBox_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_cantidad_KeyPress);
            // 
            // comboBox_producto
            // 
            this.comboBox_producto.FormattingEnabled = true;
            this.comboBox_producto.Location = new System.Drawing.Point(150, 106);
            this.comboBox_producto.Name = "comboBox_producto";
            this.comboBox_producto.Size = new System.Drawing.Size(170, 21);
            this.comboBox_producto.TabIndex = 13;
            // 
            // textBox_subtotal
            // 
            this.textBox_subtotal.Location = new System.Drawing.Point(431, 106);
            this.textBox_subtotal.Name = "textBox_subtotal";
            this.textBox_subtotal.Size = new System.Drawing.Size(170, 20);
            this.textBox_subtotal.TabIndex = 12;
            this.textBox_subtotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_subtotal_KeyPress);
            // 
            // textBox_precio_compra
            // 
            this.textBox_precio_compra.Location = new System.Drawing.Point(431, 58);
            this.textBox_precio_compra.Name = "textBox_precio_compra";
            this.textBox_precio_compra.Size = new System.Drawing.Size(170, 20);
            this.textBox_precio_compra.TabIndex = 11;
            this.textBox_precio_compra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_precio_compra_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(336, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Subtotal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "ID Compra";
            // 
            // button_verdetallecompra
            // 
            this.button_verdetallecompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_verdetallecompra.Image = global::Proyecto_Almacen.Properties.Resources.lista_de_verificacion;
            this.button_verdetallecompra.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_verdetallecompra.Location = new System.Drawing.Point(607, 19);
            this.button_verdetallecompra.Name = "button_verdetallecompra";
            this.button_verdetallecompra.Size = new System.Drawing.Size(222, 40);
            this.button_verdetallecompra.TabIndex = 8;
            this.button_verdetallecompra.Text = "VER DETALLE DE COMPRA";
            this.button_verdetallecompra.UseVisualStyleBackColor = true;
            this.button_verdetallecompra.Click += new System.EventHandler(this.button_verdetallecompra_Click);
            // 
            // comboBox_compra
            // 
            this.comboBox_compra.FormattingEnabled = true;
            this.comboBox_compra.Location = new System.Drawing.Point(150, 58);
            this.comboBox_compra.Name = "comboBox_compra";
            this.comboBox_compra.Size = new System.Drawing.Size(170, 21);
            this.comboBox_compra.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(336, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(336, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio Compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Producto";
            // 
            // textBox_codigo_detalle_compra
            // 
            this.textBox_codigo_detalle_compra.Location = new System.Drawing.Point(150, 12);
            this.textBox_codigo_detalle_compra.Name = "textBox_codigo_detalle_compra";
            this.textBox_codigo_detalle_compra.Size = new System.Drawing.Size(170, 20);
            this.textBox_codigo_detalle_compra.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo Detalle Compra";
            // 
            // button_nuevo
            // 
            this.button_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_nuevo.Image = global::Proyecto_Almacen.Properties.Resources.nueva_cuenta;
            this.button_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nuevo.Location = new System.Drawing.Point(69, 166);
            this.button_nuevo.Name = "button_nuevo";
            this.button_nuevo.Size = new System.Drawing.Size(155, 48);
            this.button_nuevo.TabIndex = 33;
            this.button_nuevo.Text = "NUEVO";
            this.button_nuevo.UseVisualStyleBackColor = true;
            this.button_nuevo.Click += new System.EventHandler(this.button_nuevo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(329, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "MANTENIMIENTO DETALLE DE COMPRA";
            // 
            // Form_Detalle_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 514);
            this.Controls.Add(this.button_cerrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel_mant_detalle_compra);
            this.Controls.Add(this.button_modificar);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_nuevo);
            this.Controls.Add(this.label1);
            this.Name = "Form_Detalle_Compra";
            this.Text = "Form_Detalle_Compra";
            this.Load += new System.EventHandler(this.Form_Detalle_Compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_mant_detalle_compra.ResumeLayout(false);
            this.panel_mant_detalle_compra.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_cerrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel_mant_detalle_compra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_buscar_compra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_modificar;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_producto;
        private System.Windows.Forms.TextBox textBox_subtotal;
        private System.Windows.Forms.TextBox textBox_precio_compra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_verdetallecompra;
        private System.Windows.Forms.ComboBox comboBox_compra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_codigo_detalle_compra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_nuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_cantidad;
    }
}