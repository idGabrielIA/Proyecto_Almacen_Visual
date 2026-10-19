namespace Proyecto_Almacen.Views
{
    partial class Form_Venta
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
            this.panel_mant_venta = new System.Windows.Forms.Panel();
            this.button_apuntes = new System.Windows.Forms.Button();
            this.button_calculadora = new System.Windows.Forms.Button();
            this.button_catalogo = new System.Windows.Forms.Button();
            this.button_cliente = new System.Windows.Forms.Button();
            this.button_Quitarfila = new System.Windows.Forms.Button();
            this.button_guardarpago = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_buscar = new System.Windows.Forms.Button();
            this.textBox_direccion = new System.Windows.Forms.TextBox();
            this.textBox_nombre_cliente = new System.Windows.Forms.TextBox();
            this.textBox_telefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_a_cuenta = new System.Windows.Forms.Button();
            this.button_Agregar_producto = new System.Windows.Forms.Button();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_numero = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_ruc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_subtotal = new System.Windows.Forms.TextBox();
            this.textBox_igv = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_correo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_mant_venta.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_cerrar
            // 
            this.button_cerrar.Image = global::Proyecto_Almacen.Properties.Resources.cerrar_sesion__1_;
            this.button_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cerrar.Location = new System.Drawing.Point(686, 451);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(127, 48);
            this.button_cerrar.TabIndex = 39;
            this.button_cerrar.Text = "SALIR";
            this.button_cerrar.UseVisualStyleBackColor = true;
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 185);
            this.dataGridView1.TabIndex = 38;
            // 
            // panel_mant_venta
            // 
            this.panel_mant_venta.BackColor = System.Drawing.Color.Black;
            this.panel_mant_venta.Controls.Add(this.button_apuntes);
            this.panel_mant_venta.Controls.Add(this.button_calculadora);
            this.panel_mant_venta.Controls.Add(this.button_catalogo);
            this.panel_mant_venta.Controls.Add(this.button_cliente);
            this.panel_mant_venta.Location = new System.Drawing.Point(12, 39);
            this.panel_mant_venta.Name = "panel_mant_venta";
            this.panel_mant_venta.Size = new System.Drawing.Size(588, 51);
            this.panel_mant_venta.TabIndex = 37;
            // 
            // button_apuntes
            // 
            this.button_apuntes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_apuntes.Location = new System.Drawing.Point(440, 3);
            this.button_apuntes.Name = "button_apuntes";
            this.button_apuntes.Size = new System.Drawing.Size(124, 41);
            this.button_apuntes.TabIndex = 45;
            this.button_apuntes.Text = "APUNTES";
            this.button_apuntes.UseVisualStyleBackColor = true;
            // 
            // button_calculadora
            // 
            this.button_calculadora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_calculadora.Location = new System.Drawing.Point(296, 3);
            this.button_calculadora.Name = "button_calculadora";
            this.button_calculadora.Size = new System.Drawing.Size(124, 41);
            this.button_calculadora.TabIndex = 44;
            this.button_calculadora.Text = "CALCULADORA";
            this.button_calculadora.UseVisualStyleBackColor = true;
            // 
            // button_catalogo
            // 
            this.button_catalogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_catalogo.Location = new System.Drawing.Point(155, 3);
            this.button_catalogo.Name = "button_catalogo";
            this.button_catalogo.Size = new System.Drawing.Size(124, 41);
            this.button_catalogo.TabIndex = 43;
            this.button_catalogo.Text = "CATALOGO";
            this.button_catalogo.UseVisualStyleBackColor = true;
            // 
            // button_cliente
            // 
            this.button_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cliente.Location = new System.Drawing.Point(12, 3);
            this.button_cliente.Name = "button_cliente";
            this.button_cliente.Size = new System.Drawing.Size(124, 41);
            this.button_cliente.TabIndex = 42;
            this.button_cliente.Text = "CLIENTE";
            this.button_cliente.UseVisualStyleBackColor = true;
            this.button_cliente.Click += new System.EventHandler(this.button_cliente_Click);
            // 
            // button_Quitarfila
            // 
            this.button_Quitarfila.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Quitarfila.Image = global::Proyecto_Almacen.Properties.Resources.borrar;
            this.button_Quitarfila.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Quitarfila.Location = new System.Drawing.Point(525, 451);
            this.button_Quitarfila.Name = "button_Quitarfila";
            this.button_Quitarfila.Size = new System.Drawing.Size(155, 48);
            this.button_Quitarfila.TabIndex = 36;
            this.button_Quitarfila.Text = "QUITAR FILA";
            this.button_Quitarfila.UseVisualStyleBackColor = true;
            this.button_Quitarfila.Click += new System.EventHandler(this.button_Quitarfila_Click);
            // 
            // button_guardarpago
            // 
            this.button_guardarpago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_guardarpago.Image = global::Proyecto_Almacen.Properties.Resources.guardar_carpeta;
            this.button_guardarpago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_guardarpago.Location = new System.Drawing.Point(180, 451);
            this.button_guardarpago.Name = "button_guardarpago";
            this.button_guardarpago.Size = new System.Drawing.Size(170, 48);
            this.button_guardarpago.TabIndex = 35;
            this.button_guardarpago.Text = "GUARDAR PAGO";
            this.button_guardarpago.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_correo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button_buscar);
            this.panel1.Controls.Add(this.textBox_direccion);
            this.panel1.Controls.Add(this.textBox_nombre_cliente);
            this.panel1.Controls.Add(this.textBox_telefono);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 139);
            this.panel1.TabIndex = 34;
            // 
            // button_buscar
            // 
            this.button_buscar.Image = global::Proyecto_Almacen.Properties.Resources.lupa;
            this.button_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_buscar.Location = new System.Drawing.Point(440, 90);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(124, 41);
            this.button_buscar.TabIndex = 46;
            this.button_buscar.Text = "BUSCAR";
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // textBox_direccion
            // 
            this.textBox_direccion.Location = new System.Drawing.Point(109, 75);
            this.textBox_direccion.Name = "textBox_direccion";
            this.textBox_direccion.Size = new System.Drawing.Size(216, 20);
            this.textBox_direccion.TabIndex = 14;
            // 
            // textBox_nombre_cliente
            // 
            this.textBox_nombre_cliente.Location = new System.Drawing.Point(109, 22);
            this.textBox_nombre_cliente.Name = "textBox_nombre_cliente";
            this.textBox_nombre_cliente.Size = new System.Drawing.Size(216, 20);
            this.textBox_nombre_cliente.TabIndex = 13;
            // 
            // textBox_telefono
            // 
            this.textBox_telefono.Location = new System.Drawing.Point(394, 19);
            this.textBox_telefono.Name = "textBox_telefono";
            this.textBox_telefono.Size = new System.Drawing.Size(170, 20);
            this.textBox_telefono.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nombre Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(327, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "TOTAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(329, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "MANTENIMIENTO DE VENTA";
            // 
            // button_a_cuenta
            // 
            this.button_a_cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_a_cuenta.Image = global::Proyecto_Almacen.Properties.Resources.lista_de_verificacion;
            this.button_a_cuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_a_cuenta.Location = new System.Drawing.Point(357, 451);
            this.button_a_cuenta.Name = "button_a_cuenta";
            this.button_a_cuenta.Size = new System.Drawing.Size(162, 48);
            this.button_a_cuenta.TabIndex = 40;
            this.button_a_cuenta.Text = "A CUENTA";
            this.button_a_cuenta.UseVisualStyleBackColor = true;
            // 
            // button_Agregar_producto
            // 
            this.button_Agregar_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Agregar_producto.Image = global::Proyecto_Almacen.Properties.Resources.nueva_cuenta;
            this.button_Agregar_producto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Agregar_producto.Location = new System.Drawing.Point(3, 451);
            this.button_Agregar_producto.Name = "button_Agregar_producto";
            this.button_Agregar_producto.Size = new System.Drawing.Size(171, 48);
            this.button_Agregar_producto.TabIndex = 41;
            this.button_Agregar_producto.Text = "AGREGAR PRODUCTO";
            this.button_Agregar_producto.UseVisualStyleBackColor = true;
            this.button_Agregar_producto.Click += new System.EventHandler(this.button_Agregar_producto_Click);
            // 
            // textBox_total
            // 
            this.textBox_total.Location = new System.Drawing.Point(20, 213);
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.Size = new System.Drawing.Size(98, 20);
            this.textBox_total.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_numero);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBox_ruc);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(606, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 138);
            this.panel2.TabIndex = 42;
            // 
            // textBox_numero
            // 
            this.textBox_numero.Location = new System.Drawing.Point(70, 96);
            this.textBox_numero.Name = "textBox_numero";
            this.textBox_numero.Size = new System.Drawing.Size(109, 20);
            this.textBox_numero.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "006  N° _";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "COMPROBANTE DE VENTA";
            // 
            // textBox_ruc
            // 
            this.textBox_ruc.Location = new System.Drawing.Point(80, 15);
            this.textBox_ruc.Name = "textBox_ruc";
            this.textBox_ruc.Size = new System.Drawing.Size(127, 20);
            this.textBox_ruc.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "R. U. C.";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.textBox_subtotal);
            this.panel3.Controls.Add(this.textBox_igv);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.textBox_total);
            this.panel3.Location = new System.Drawing.Point(695, 191);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(129, 253);
            this.panel3.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "SUBTOTAL";
            // 
            // textBox_subtotal
            // 
            this.textBox_subtotal.Location = new System.Drawing.Point(20, 49);
            this.textBox_subtotal.Name = "textBox_subtotal";
            this.textBox_subtotal.Size = new System.Drawing.Size(98, 20);
            this.textBox_subtotal.TabIndex = 15;
            // 
            // textBox_igv
            // 
            this.textBox_igv.Location = new System.Drawing.Point(20, 136);
            this.textBox_igv.Name = "textBox_igv";
            this.textBox_igv.Size = new System.Drawing.Size(98, 20);
            this.textBox_igv.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(37, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "IGV 0.19%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(331, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Correo";
            // 
            // textBox_correo
            // 
            this.textBox_correo.Location = new System.Drawing.Point(394, 68);
            this.textBox_correo.Name = "textBox_correo";
            this.textBox_correo.Size = new System.Drawing.Size(170, 20);
            this.textBox_correo.TabIndex = 48;
            // 
            // Form_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 506);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button_Agregar_producto);
            this.Controls.Add(this.button_a_cuenta);
            this.Controls.Add(this.button_cerrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel_mant_venta);
            this.Controls.Add(this.button_Quitarfila);
            this.Controls.Add(this.button_guardarpago);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form_Venta";
            this.Text = "Form_Venta";
            this.Load += new System.EventHandler(this.Form_Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_mant_venta.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_cerrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel_mant_venta;
        private System.Windows.Forms.Button button_Quitarfila;
        private System.Windows.Forms.Button button_guardarpago;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_a_cuenta;
        private System.Windows.Forms.Button button_Agregar_producto;
        private System.Windows.Forms.Button button_cliente;
        private System.Windows.Forms.TextBox textBox_direccion;
        private System.Windows.Forms.TextBox textBox_nombre_cliente;
        private System.Windows.Forms.TextBox textBox_telefono;
        private System.Windows.Forms.TextBox textBox_total;
        private System.Windows.Forms.Button button_apuntes;
        private System.Windows.Forms.Button button_calculadora;
        private System.Windows.Forms.Button button_catalogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_ruc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_numero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_subtotal;
        private System.Windows.Forms.TextBox textBox_igv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.TextBox textBox_correo;
        private System.Windows.Forms.Label label5;
    }
}