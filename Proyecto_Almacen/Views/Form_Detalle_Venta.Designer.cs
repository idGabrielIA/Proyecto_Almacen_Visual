namespace Proyecto_Almacen.Views
{
    partial class Form_Detalle_Venta
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
            this.panel_mant_detalle_venta = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_buscar_detalle_venta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_modificar = new System.Windows.Forms.Button();
            this.button_guardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_cantidad = new System.Windows.Forms.TextBox();
            this.comboBox_producto = new System.Windows.Forms.ComboBox();
            this.textBox_precio_venta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_verdetalleventa = new System.Windows.Forms.Button();
            this.comboBox_venta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_codigo_detalle_venta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_nuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_mant_detalle_venta.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_cerrar
            // 
            this.button_cerrar.Image = global::Proyecto_Almacen.Properties.Resources.cerrar_sesion__1_;
            this.button_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cerrar.Location = new System.Drawing.Point(675, 447);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(124, 41);
            this.button_cerrar.TabIndex = 47;
            this.button_cerrar.Text = "CERRAR";
            this.button_cerrar.UseVisualStyleBackColor = true;
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 185);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel_mant_detalle_venta
            // 
            this.panel_mant_detalle_venta.BackColor = System.Drawing.Color.Black;
            this.panel_mant_detalle_venta.Controls.Add(this.label8);
            this.panel_mant_detalle_venta.Controls.Add(this.textBox_buscar_detalle_venta);
            this.panel_mant_detalle_venta.Controls.Add(this.label6);
            this.panel_mant_detalle_venta.Location = new System.Drawing.Point(8, 220);
            this.panel_mant_detalle_venta.Name = "panel_mant_detalle_venta";
            this.panel_mant_detalle_venta.Size = new System.Drawing.Size(766, 38);
            this.panel_mant_detalle_venta.TabIndex = 45;
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
            // textBox_buscar_detalle_venta
            // 
            this.textBox_buscar_detalle_venta.Location = new System.Drawing.Point(229, 10);
            this.textBox_buscar_detalle_venta.Name = "textBox_buscar_detalle_venta";
            this.textBox_buscar_detalle_venta.Size = new System.Drawing.Size(323, 20);
            this.textBox_buscar_detalle_venta.TabIndex = 1;
            this.textBox_buscar_detalle_venta.TextChanged += new System.EventHandler(this.textBox_buscar_detalle_venta_TextChanged);
            this.textBox_buscar_detalle_venta.Enter += new System.EventHandler(this.textBox_buscar_detalle_venta_Enter);
            this.textBox_buscar_detalle_venta.Leave += new System.EventHandler(this.textBox_buscar_detalle_venta_Leave);
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
            this.label6.Text = "Ingresar el Nombre de Detalle Venta";
            // 
            // button_modificar
            // 
            this.button_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modificar.Image = global::Proyecto_Almacen.Properties.Resources.actualizar;
            this.button_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_modificar.Location = new System.Drawing.Point(595, 166);
            this.button_modificar.Name = "button_modificar";
            this.button_modificar.Size = new System.Drawing.Size(155, 48);
            this.button_modificar.TabIndex = 44;
            this.button_modificar.Text = "MODIFICAR";
            this.button_modificar.UseVisualStyleBackColor = true;
            // 
            // button_guardar
            // 
            this.button_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_guardar.Image = global::Proyecto_Almacen.Properties.Resources.guardar_carpeta;
            this.button_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_guardar.Location = new System.Drawing.Point(321, 166);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(155, 48);
            this.button_guardar.TabIndex = 43;
            this.button_guardar.Text = "GUARDAR";
            this.button_guardar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_cantidad);
            this.panel1.Controls.Add(this.comboBox_producto);
            this.panel1.Controls.Add(this.textBox_precio_venta);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button_verdetalleventa);
            this.panel1.Controls.Add(this.comboBox_venta);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_codigo_detalle_venta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 139);
            this.panel1.TabIndex = 42;
            // 
            // textBox_cantidad
            // 
            this.textBox_cantidad.Location = new System.Drawing.Point(431, 12);
            this.textBox_cantidad.Name = "textBox_cantidad";
            this.textBox_cantidad.Size = new System.Drawing.Size(170, 20);
            this.textBox_cantidad.TabIndex = 14;
            this.textBox_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_cantidad_KeyPress);
            this.textBox_cantidad.Leave += new System.EventHandler(this.textBox_cantidad_Leave);
            // 
            // comboBox_producto
            // 
            this.comboBox_producto.FormattingEnabled = true;
            this.comboBox_producto.Location = new System.Drawing.Point(150, 106);
            this.comboBox_producto.Name = "comboBox_producto";
            this.comboBox_producto.Size = new System.Drawing.Size(170, 21);
            this.comboBox_producto.TabIndex = 13;
            // 
            // textBox_precio_venta
            // 
            this.textBox_precio_venta.Location = new System.Drawing.Point(431, 58);
            this.textBox_precio_venta.Name = "textBox_precio_venta";
            this.textBox_precio_venta.Size = new System.Drawing.Size(170, 20);
            this.textBox_precio_venta.TabIndex = 11;
            this.textBox_precio_venta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_precio_venta_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "ID Venta";
            // 
            // button_verdetalleventa
            // 
            this.button_verdetalleventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_verdetalleventa.Image = global::Proyecto_Almacen.Properties.Resources.lista_de_verificacion;
            this.button_verdetalleventa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_verdetalleventa.Location = new System.Drawing.Point(607, 19);
            this.button_verdetalleventa.Name = "button_verdetalleventa";
            this.button_verdetalleventa.Size = new System.Drawing.Size(222, 40);
            this.button_verdetalleventa.TabIndex = 8;
            this.button_verdetalleventa.Text = "VER DETALLE DE VENTA";
            this.button_verdetalleventa.UseVisualStyleBackColor = true;
            this.button_verdetalleventa.Click += new System.EventHandler(this.button_verdetalleventa_Click);
            // 
            // comboBox_venta
            // 
            this.comboBox_venta.FormattingEnabled = true;
            this.comboBox_venta.Location = new System.Drawing.Point(150, 58);
            this.comboBox_venta.Name = "comboBox_venta";
            this.comboBox_venta.Size = new System.Drawing.Size(170, 21);
            this.comboBox_venta.TabIndex = 7;
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
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio Venta";
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
            // textBox_codigo_detalle_venta
            // 
            this.textBox_codigo_detalle_venta.Location = new System.Drawing.Point(150, 12);
            this.textBox_codigo_detalle_venta.Name = "textBox_codigo_detalle_venta";
            this.textBox_codigo_detalle_venta.Size = new System.Drawing.Size(170, 20);
            this.textBox_codigo_detalle_venta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo Detalle Venta";
            // 
            // button_nuevo
            // 
            this.button_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_nuevo.Image = global::Proyecto_Almacen.Properties.Resources.nueva_cuenta;
            this.button_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nuevo.Location = new System.Drawing.Point(58, 166);
            this.button_nuevo.Name = "button_nuevo";
            this.button_nuevo.Size = new System.Drawing.Size(155, 48);
            this.button_nuevo.TabIndex = 41;
            this.button_nuevo.Text = "NUEVO";
            this.button_nuevo.UseVisualStyleBackColor = true;
            this.button_nuevo.Click += new System.EventHandler(this.button_nuevo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(318, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "MANTENIMIENTO DETALLE DE VENTA";
            // 
            // Form_Detalle_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 497);
            this.Controls.Add(this.button_cerrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel_mant_detalle_venta);
            this.Controls.Add(this.button_modificar);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_nuevo);
            this.Controls.Add(this.label1);
            this.Name = "Form_Detalle_Venta";
            this.Text = "Form_Detalle_Venta";
            this.Load += new System.EventHandler(this.Form_Detalle_Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_mant_detalle_venta.ResumeLayout(false);
            this.panel_mant_detalle_venta.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_cerrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel_mant_detalle_venta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_buscar_detalle_venta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_modificar;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_cantidad;
        private System.Windows.Forms.ComboBox comboBox_producto;
        private System.Windows.Forms.TextBox textBox_precio_venta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_verdetalleventa;
        private System.Windows.Forms.ComboBox comboBox_venta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_codigo_detalle_venta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_nuevo;
        private System.Windows.Forms.Label label1;
    }
}