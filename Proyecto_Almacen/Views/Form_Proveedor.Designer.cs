namespace Proyecto_Almacen.Views
{
    partial class Form_Proveedor
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
            this.panel_mant_proveedor = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_buscar_proveedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_modificar = new System.Windows.Forms.Button();
            this.button_guardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_direccion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_correo = new System.Windows.Forms.TextBox();
            this.textBox_ruc = new System.Windows.Forms.TextBox();
            this.textBox_nombre_proveedor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_ver_proveedores = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_telefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_codigo_proveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_nuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_mant_proveedor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_cerrar
            // 
            this.button_cerrar.Image = global::Proyecto_Almacen.Properties.Resources.cerrar_sesion__1_;
            this.button_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cerrar.Location = new System.Drawing.Point(683, 451);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(124, 41);
            this.button_cerrar.TabIndex = 38;
            this.button_cerrar.Text = "CERRAR";
            this.button_cerrar.UseVisualStyleBackColor = true;
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 185);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel_mant_proveedor
            // 
            this.panel_mant_proveedor.BackColor = System.Drawing.Color.Black;
            this.panel_mant_proveedor.Controls.Add(this.label8);
            this.panel_mant_proveedor.Controls.Add(this.textBox_buscar_proveedor);
            this.panel_mant_proveedor.Controls.Add(this.label6);
            this.panel_mant_proveedor.Location = new System.Drawing.Point(16, 224);
            this.panel_mant_proveedor.Name = "panel_mant_proveedor";
            this.panel_mant_proveedor.Size = new System.Drawing.Size(766, 38);
            this.panel_mant_proveedor.TabIndex = 36;
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
            // textBox_buscar_proveedor
            // 
            this.textBox_buscar_proveedor.Location = new System.Drawing.Point(229, 10);
            this.textBox_buscar_proveedor.Name = "textBox_buscar_proveedor";
            this.textBox_buscar_proveedor.Size = new System.Drawing.Size(323, 20);
            this.textBox_buscar_proveedor.TabIndex = 1;
            this.textBox_buscar_proveedor.TextChanged += new System.EventHandler(this.textBox_buscar_proveedor_TextChanged);
            this.textBox_buscar_proveedor.Enter += new System.EventHandler(this.textBox_buscar_proveedor_Enter);
            this.textBox_buscar_proveedor.Leave += new System.EventHandler(this.textBox_buscar_proveedor_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(38, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ingresar el Nombre de Proveedor";
            // 
            // button_modificar
            // 
            this.button_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modificar.Image = global::Proyecto_Almacen.Properties.Resources.actualizar;
            this.button_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_modificar.Location = new System.Drawing.Point(603, 170);
            this.button_modificar.Name = "button_modificar";
            this.button_modificar.Size = new System.Drawing.Size(155, 48);
            this.button_modificar.TabIndex = 35;
            this.button_modificar.Text = "MODIFICAR";
            this.button_modificar.UseVisualStyleBackColor = true;
            // 
            // button_guardar
            // 
            this.button_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_guardar.Image = global::Proyecto_Almacen.Properties.Resources.guardar_carpeta;
            this.button_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_guardar.Location = new System.Drawing.Point(329, 170);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(155, 48);
            this.button_guardar.TabIndex = 34;
            this.button_guardar.Text = "GUARDAR";
            this.button_guardar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_direccion);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox_correo);
            this.panel1.Controls.Add(this.textBox_ruc);
            this.panel1.Controls.Add(this.textBox_nombre_proveedor);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button_ver_proveedores);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_telefono);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_codigo_proveedor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(9, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 139);
            this.panel1.TabIndex = 33;
            // 
            // textBox_direccion
            // 
            this.textBox_direccion.Location = new System.Drawing.Point(377, 102);
            this.textBox_direccion.Name = "textBox_direccion";
            this.textBox_direccion.Size = new System.Drawing.Size(170, 20);
            this.textBox_direccion.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(317, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Direccion";
            // 
            // textBox_correo
            // 
            this.textBox_correo.Location = new System.Drawing.Point(377, 59);
            this.textBox_correo.Name = "textBox_correo";
            this.textBox_correo.Size = new System.Drawing.Size(170, 20);
            this.textBox_correo.TabIndex = 13;
            // 
            // textBox_ruc
            // 
            this.textBox_ruc.Location = new System.Drawing.Point(126, 102);
            this.textBox_ruc.Name = "textBox_ruc";
            this.textBox_ruc.Size = new System.Drawing.Size(170, 20);
            this.textBox_ruc.TabIndex = 12;
            // 
            // textBox_nombre_proveedor
            // 
            this.textBox_nombre_proveedor.Location = new System.Drawing.Point(126, 59);
            this.textBox_nombre_proveedor.Name = "textBox_nombre_proveedor";
            this.textBox_nombre_proveedor.Size = new System.Drawing.Size(170, 20);
            this.textBox_nombre_proveedor.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ruc";
            // 
            // button_ver_proveedores
            // 
            this.button_ver_proveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ver_proveedores.Image = global::Proyecto_Almacen.Properties.Resources.lista_de_verificacion;
            this.button_ver_proveedores.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_ver_proveedores.Location = new System.Drawing.Point(607, 19);
            this.button_ver_proveedores.Name = "button_ver_proveedores";
            this.button_ver_proveedores.Size = new System.Drawing.Size(194, 40);
            this.button_ver_proveedores.TabIndex = 8;
            this.button_ver_proveedores.Text = "VER PROVEEDORES";
            this.button_ver_proveedores.UseVisualStyleBackColor = true;
            this.button_ver_proveedores.Click += new System.EventHandler(this.button_ver_proveedores_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(314, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(315, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Correo";
            // 
            // textBox_telefono
            // 
            this.textBox_telefono.Location = new System.Drawing.Point(377, 12);
            this.textBox_telefono.Name = "textBox_telefono";
            this.textBox_telefono.Size = new System.Drawing.Size(170, 20);
            this.textBox_telefono.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo Proveedor";
            // 
            // textBox_codigo_proveedor
            // 
            this.textBox_codigo_proveedor.Location = new System.Drawing.Point(126, 12);
            this.textBox_codigo_proveedor.Name = "textBox_codigo_proveedor";
            this.textBox_codigo_proveedor.Size = new System.Drawing.Size(170, 20);
            this.textBox_codigo_proveedor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre Proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(326, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "MANTENIMIENTO DE PROVEEDOR";
            // 
            // button_nuevo
            // 
            this.button_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_nuevo.Image = global::Proyecto_Almacen.Properties.Resources.nueva_cuenta;
            this.button_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nuevo.Location = new System.Drawing.Point(45, 170);
            this.button_nuevo.Name = "button_nuevo";
            this.button_nuevo.Size = new System.Drawing.Size(155, 48);
            this.button_nuevo.TabIndex = 39;
            this.button_nuevo.Text = "NUEVO";
            this.button_nuevo.UseVisualStyleBackColor = true;
            this.button_nuevo.Click += new System.EventHandler(this.button_nuevo_Click);
            // 
            // Form_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 521);
            this.Controls.Add(this.button_nuevo);
            this.Controls.Add(this.button_cerrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel_mant_proveedor);
            this.Controls.Add(this.button_modificar);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form_Proveedor";
            this.Text = "Form_Proveedor";
            this.Load += new System.EventHandler(this.Form_Proveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_mant_proveedor.ResumeLayout(false);
            this.panel_mant_proveedor.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_cerrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel_mant_proveedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_buscar_proveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_modificar;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_correo;
        private System.Windows.Forms.TextBox textBox_ruc;
        private System.Windows.Forms.TextBox textBox_nombre_proveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_ver_proveedores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_telefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_codigo_proveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_nuevo;
        private System.Windows.Forms.TextBox textBox_direccion;
        private System.Windows.Forms.Label label9;
    }
}