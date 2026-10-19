namespace Proyecto_Almacen.Views
{
    partial class Form_Movimiento_Inventario
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
            this.panel_mant_movimiento = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_buscar_movimiento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_tipo_movimiento = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_personal = new System.Windows.Forms.ComboBox();
            this.comboBox_almacen = new System.Windows.Forms.ComboBox();
            this.textBox_cantidad = new System.Windows.Forms.TextBox();
            this.textBox_fecha = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_vermovimiento = new System.Windows.Forms.Button();
            this.comboBox_producto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_id_movimiento_inventario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_cerrar = new System.Windows.Forms.Button();
            this.button_modificar = new System.Windows.Forms.Button();
            this.button_guardar = new System.Windows.Forms.Button();
            this.button_nuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_mant_movimiento.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 185);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel_mant_movimiento
            // 
            this.panel_mant_movimiento.BackColor = System.Drawing.Color.Black;
            this.panel_mant_movimiento.Controls.Add(this.label8);
            this.panel_mant_movimiento.Controls.Add(this.textBox_buscar_movimiento);
            this.panel_mant_movimiento.Controls.Add(this.label6);
            this.panel_mant_movimiento.Location = new System.Drawing.Point(20, 264);
            this.panel_mant_movimiento.Name = "panel_mant_movimiento";
            this.panel_mant_movimiento.Size = new System.Drawing.Size(766, 38);
            this.panel_mant_movimiento.TabIndex = 37;
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
            // textBox_buscar_movimiento
            // 
            this.textBox_buscar_movimiento.Location = new System.Drawing.Point(229, 10);
            this.textBox_buscar_movimiento.Name = "textBox_buscar_movimiento";
            this.textBox_buscar_movimiento.Size = new System.Drawing.Size(323, 20);
            this.textBox_buscar_movimiento.TabIndex = 1;
            this.textBox_buscar_movimiento.TextChanged += new System.EventHandler(this.textBox_buscar_movimiento_TextChanged);
            this.textBox_buscar_movimiento.Enter += new System.EventHandler(this.textBox_buscar_movimiento_Enter);
            this.textBox_buscar_movimiento.Leave += new System.EventHandler(this.textBox_buscar_movimiento_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(38, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ingresar el Nombre de Movimiento";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_tipo_movimiento);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.comboBox_personal);
            this.panel1.Controls.Add(this.comboBox_almacen);
            this.panel1.Controls.Add(this.textBox_cantidad);
            this.panel1.Controls.Add(this.textBox_fecha);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button_vermovimiento);
            this.panel1.Controls.Add(this.comboBox_producto);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_id_movimiento_inventario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(9, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 178);
            this.panel1.TabIndex = 34;
            // 
            // comboBox_tipo_movimiento
            // 
            this.comboBox_tipo_movimiento.FormattingEnabled = true;
            this.comboBox_tipo_movimiento.Location = new System.Drawing.Point(163, 58);
            this.comboBox_tipo_movimiento.Name = "comboBox_tipo_movimiento";
            this.comboBox_tipo_movimiento.Size = new System.Drawing.Size(154, 21);
            this.comboBox_tipo_movimiento.TabIndex = 16;
            this.comboBox_tipo_movimiento.SelectedIndexChanged += new System.EventHandler(this.comboBox_tipo_movimiento_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "ID Tipo Movimiento ";
            // 
            // comboBox_personal
            // 
            this.comboBox_personal.FormattingEnabled = true;
            this.comboBox_personal.Location = new System.Drawing.Point(422, 11);
            this.comboBox_personal.Name = "comboBox_personal";
            this.comboBox_personal.Size = new System.Drawing.Size(152, 21);
            this.comboBox_personal.TabIndex = 14;
            // 
            // comboBox_almacen
            // 
            this.comboBox_almacen.FormattingEnabled = true;
            this.comboBox_almacen.Location = new System.Drawing.Point(163, 141);
            this.comboBox_almacen.Name = "comboBox_almacen";
            this.comboBox_almacen.Size = new System.Drawing.Size(154, 21);
            this.comboBox_almacen.TabIndex = 13;
            // 
            // textBox_cantidad
            // 
            this.textBox_cantidad.Location = new System.Drawing.Point(422, 102);
            this.textBox_cantidad.Name = "textBox_cantidad";
            this.textBox_cantidad.Size = new System.Drawing.Size(152, 20);
            this.textBox_cantidad.TabIndex = 12;
            this.textBox_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_cantidad_KeyPress);
            // 
            // textBox_fecha
            // 
            this.textBox_fecha.Location = new System.Drawing.Point(422, 58);
            this.textBox_fecha.Name = "textBox_fecha";
            this.textBox_fecha.Size = new System.Drawing.Size(152, 20);
            this.textBox_fecha.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(341, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Producto";
            // 
            // button_vermovimiento
            // 
            this.button_vermovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_vermovimiento.Image = global::Proyecto_Almacen.Properties.Resources.lista_de_verificacion;
            this.button_vermovimiento.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_vermovimiento.Location = new System.Drawing.Point(607, 19);
            this.button_vermovimiento.Name = "button_vermovimiento";
            this.button_vermovimiento.Size = new System.Drawing.Size(194, 40);
            this.button_vermovimiento.TabIndex = 8;
            this.button_vermovimiento.Text = "VER MOVIMIENTO";
            this.button_vermovimiento.UseVisualStyleBackColor = true;
            this.button_vermovimiento.Click += new System.EventHandler(this.button_vermovimiento_Click);
            // 
            // comboBox_producto
            // 
            this.comboBox_producto.FormattingEnabled = true;
            this.comboBox_producto.Location = new System.Drawing.Point(163, 101);
            this.comboBox_producto.Name = "comboBox_producto";
            this.comboBox_producto.Size = new System.Drawing.Size(154, 21);
            this.comboBox_producto.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(341, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Personal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(341, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Almacen";
            // 
            // textBox_id_movimiento_inventario
            // 
            this.textBox_id_movimiento_inventario.Location = new System.Drawing.Point(163, 11);
            this.textBox_id_movimiento_inventario.Name = "textBox_id_movimiento_inventario";
            this.textBox_id_movimiento_inventario.Size = new System.Drawing.Size(154, 20);
            this.textBox_id_movimiento_inventario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Movimiento Inventario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(326, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "MANTENIMIENTO DE MOVIMIENTO INVENTARIO";
            // 
            // button_cerrar
            // 
            this.button_cerrar.Image = global::Proyecto_Almacen.Properties.Resources.cerrar_sesion__1_;
            this.button_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cerrar.Location = new System.Drawing.Point(686, 491);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(124, 41);
            this.button_cerrar.TabIndex = 39;
            this.button_cerrar.Text = "CERRAR";
            this.button_cerrar.UseVisualStyleBackColor = true;
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // button_modificar
            // 
            this.button_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modificar.Image = global::Proyecto_Almacen.Properties.Resources.actualizar;
            this.button_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_modificar.Location = new System.Drawing.Point(607, 210);
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
            this.button_guardar.Location = new System.Drawing.Point(333, 210);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(155, 48);
            this.button_guardar.TabIndex = 35;
            this.button_guardar.Text = "GUARDAR";
            this.button_guardar.UseVisualStyleBackColor = true;
            // 
            // button_nuevo
            // 
            this.button_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_nuevo.Image = global::Proyecto_Almacen.Properties.Resources.nueva_cuenta;
            this.button_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nuevo.Location = new System.Drawing.Point(70, 210);
            this.button_nuevo.Name = "button_nuevo";
            this.button_nuevo.Size = new System.Drawing.Size(155, 48);
            this.button_nuevo.TabIndex = 33;
            this.button_nuevo.Text = "NUEVO";
            this.button_nuevo.UseVisualStyleBackColor = true;
            this.button_nuevo.Click += new System.EventHandler(this.button_nuevo_Click);
            // 
            // Form_Movimiento_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 544);
            this.Controls.Add(this.button_cerrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel_mant_movimiento);
            this.Controls.Add(this.button_modificar);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_nuevo);
            this.Controls.Add(this.label1);
            this.Name = "Form_Movimiento_Inventario";
            this.Text = "Form_Movimiento_Inventario";
            this.Load += new System.EventHandler(this.Form_Movimiento_Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_mant_movimiento.ResumeLayout(false);
            this.panel_mant_movimiento.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_cerrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel_mant_movimiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_buscar_movimiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_modificar;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_personal;
        private System.Windows.Forms.ComboBox comboBox_almacen;
        private System.Windows.Forms.TextBox textBox_cantidad;
        private System.Windows.Forms.TextBox textBox_fecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_vermovimiento;
        private System.Windows.Forms.ComboBox comboBox_producto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_id_movimiento_inventario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_nuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_tipo_movimiento;
    }
}