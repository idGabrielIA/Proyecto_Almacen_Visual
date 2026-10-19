namespace Proyecto_Almacen.Views
{
    partial class Form_Tipo_Personal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_verTIPO_PERSONAL = new System.Windows.Forms.Button();
            this.textBox_observaciones = new System.Windows.Forms.TextBox();
            this.textBox_nombre_tipo_personal = new System.Windows.Forms.TextBox();
            this.textBox_id_tipo_personal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_nuevo = new System.Windows.Forms.Button();
            this.button_guardar = new System.Windows.Forms.Button();
            this.button_modificar = new System.Windows.Forms.Button();
            this.button_cerrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel_buscarTipopersonal = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_buscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_buscarTipopersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_verTIPO_PERSONAL);
            this.panel1.Controls.Add(this.textBox_observaciones);
            this.panel1.Controls.Add(this.textBox_nombre_tipo_personal);
            this.panel1.Controls.Add(this.textBox_id_tipo_personal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 129);
            this.panel1.TabIndex = 0;
            // 
            // button_verTIPO_PERSONAL
            // 
            this.button_verTIPO_PERSONAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_verTIPO_PERSONAL.Image = global::Proyecto_Almacen.Properties.Resources.lista_de_verificacion;
            this.button_verTIPO_PERSONAL.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_verTIPO_PERSONAL.Location = new System.Drawing.Point(572, 52);
            this.button_verTIPO_PERSONAL.Name = "button_verTIPO_PERSONAL";
            this.button_verTIPO_PERSONAL.Size = new System.Drawing.Size(194, 40);
            this.button_verTIPO_PERSONAL.TabIndex = 9;
            this.button_verTIPO_PERSONAL.Text = "VER TIPO PERSONAL";
            this.button_verTIPO_PERSONAL.UseVisualStyleBackColor = true;
            this.button_verTIPO_PERSONAL.Click += new System.EventHandler(this.button_verTIPO_PERSONAL_Click);
            // 
            // textBox_observaciones
            // 
            this.textBox_observaciones.Location = new System.Drawing.Point(412, 22);
            this.textBox_observaciones.Name = "textBox_observaciones";
            this.textBox_observaciones.Size = new System.Drawing.Size(165, 20);
            this.textBox_observaciones.TabIndex = 5;
            this.textBox_observaciones.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox_nombre_tipo_personal
            // 
            this.textBox_nombre_tipo_personal.Location = new System.Drawing.Point(135, 76);
            this.textBox_nombre_tipo_personal.Name = "textBox_nombre_tipo_personal";
            this.textBox_nombre_tipo_personal.Size = new System.Drawing.Size(174, 20);
            this.textBox_nombre_tipo_personal.TabIndex = 4;
            // 
            // textBox_id_tipo_personal
            // 
            this.textBox_id_tipo_personal.Location = new System.Drawing.Point(135, 22);
            this.textBox_id_tipo_personal.Name = "textBox_id_tipo_personal";
            this.textBox_id_tipo_personal.Size = new System.Drawing.Size(174, 20);
            this.textBox_id_tipo_personal.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Observaciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Tipo Personal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Tipo Personal";
            // 
            // button_nuevo
            // 
            this.button_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_nuevo.Image = global::Proyecto_Almacen.Properties.Resources.nueva_cuenta;
            this.button_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nuevo.Location = new System.Drawing.Point(66, 160);
            this.button_nuevo.Name = "button_nuevo";
            this.button_nuevo.Size = new System.Drawing.Size(155, 48);
            this.button_nuevo.TabIndex = 2;
            this.button_nuevo.Text = "NUEVO";
            this.button_nuevo.UseVisualStyleBackColor = true;
            this.button_nuevo.Click += new System.EventHandler(this.button_nuevo_Click);
            // 
            // button_guardar
            // 
            this.button_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_guardar.Image = global::Proyecto_Almacen.Properties.Resources.guardar_carpeta;
            this.button_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_guardar.Location = new System.Drawing.Point(293, 160);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(155, 48);
            this.button_guardar.TabIndex = 4;
            this.button_guardar.Text = "GUARDAR";
            this.button_guardar.UseVisualStyleBackColor = true;
            // 
            // button_modificar
            // 
            this.button_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modificar.Image = global::Proyecto_Almacen.Properties.Resources.actualizar;
            this.button_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_modificar.Location = new System.Drawing.Point(537, 160);
            this.button_modificar.Name = "button_modificar";
            this.button_modificar.Size = new System.Drawing.Size(155, 48);
            this.button_modificar.TabIndex = 5;
            this.button_modificar.Text = "MODIFICAR";
            this.button_modificar.UseVisualStyleBackColor = true;
            // 
            // button_cerrar
            // 
            this.button_cerrar.Image = global::Proyecto_Almacen.Properties.Resources.cerrar_sesion__1_;
            this.button_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cerrar.Location = new System.Drawing.Point(683, 441);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(124, 41);
            this.button_cerrar.TabIndex = 10;
            this.button_cerrar.Text = "CERRAR";
            this.button_cerrar.UseVisualStyleBackColor = true;
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 185);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel_buscarTipopersonal
            // 
            this.panel_buscarTipopersonal.BackColor = System.Drawing.Color.Black;
            this.panel_buscarTipopersonal.Controls.Add(this.label8);
            this.panel_buscarTipopersonal.Controls.Add(this.textBox_buscar);
            this.panel_buscarTipopersonal.Controls.Add(this.label6);
            this.panel_buscarTipopersonal.Location = new System.Drawing.Point(16, 214);
            this.panel_buscarTipopersonal.Name = "panel_buscarTipopersonal";
            this.panel_buscarTipopersonal.Size = new System.Drawing.Size(766, 38);
            this.panel_buscarTipopersonal.TabIndex = 8;
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
            this.label6.Size = new System.Drawing.Size(179, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ingresar el Nombre de Tipo Personal";
            // 
            // Form_Tipo_Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 496);
            this.Controls.Add(this.button_cerrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel_buscarTipopersonal);
            this.Controls.Add(this.button_modificar);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.button_nuevo);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Tipo_Personal";
            this.Text = "Tipo_Personal";
            this.Load += new System.EventHandler(this.Form_Tipo_Personal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_buscarTipopersonal.ResumeLayout(false);
            this.panel_buscarTipopersonal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_observaciones;
        private System.Windows.Forms.TextBox textBox_nombre_tipo_personal;
        private System.Windows.Forms.TextBox textBox_id_tipo_personal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_verTIPO_PERSONAL;
        private System.Windows.Forms.Button button_nuevo;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.Button button_modificar;
        private System.Windows.Forms.Button button_cerrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel_buscarTipopersonal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_buscar;
        private System.Windows.Forms.Label label6;
    }
}