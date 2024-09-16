namespace Listas2
{
    partial class Ejercicio2
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
            this.nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.TextBox();
            this.dni = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.direccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.registrarBtn = new System.Windows.Forms.Button();
            this.actualizarBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agregarAntesBtn = new System.Windows.Forms.Button();
            this.agregarDespuesBtn = new System.Windows.Forms.Button();
            this.mostrarBtn = new System.Windows.Forms.Button();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dniAux = new System.Windows.Forms.NumericUpDown();
            this.telefono = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dniAux)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefono)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(58, 76);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(55, 138);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(100, 20);
            this.apellido.TabIndex = 2;
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(55, 192);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(120, 20);
            this.dni.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "DNI";
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(24, 235);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(200, 20);
            this.fecha.TabIndex = 6;
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(55, 303);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(100, 20);
            this.direccion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Teléfono";
            // 
            // registrarBtn
            // 
            this.registrarBtn.Location = new System.Drawing.Point(24, 397);
            this.registrarBtn.Name = "registrarBtn";
            this.registrarBtn.Size = new System.Drawing.Size(75, 23);
            this.registrarBtn.TabIndex = 11;
            this.registrarBtn.Text = "Registrar";
            this.registrarBtn.UseVisualStyleBackColor = true;
            this.registrarBtn.Click += new System.EventHandler(this.registrarBtn_Click);
            // 
            // actualizarBtn
            // 
            this.actualizarBtn.Location = new System.Drawing.Point(131, 397);
            this.actualizarBtn.Name = "actualizarBtn";
            this.actualizarBtn.Size = new System.Drawing.Size(75, 23);
            this.actualizarBtn.TabIndex = 12;
            this.actualizarBtn.Text = "Actualizar";
            this.actualizarBtn.UseVisualStyleBackColor = true;
            this.actualizarBtn.Click += new System.EventHandler(this.actualizarBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(289, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(476, 218);
            this.dataGridView1.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apellido";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "DNI";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fecha nacimiento";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Dirección";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Teléfono";
            this.Column6.Name = "Column6";
            // 
            // agregarAntesBtn
            // 
            this.agregarAntesBtn.Location = new System.Drawing.Point(261, 415);
            this.agregarAntesBtn.Name = "agregarAntesBtn";
            this.agregarAntesBtn.Size = new System.Drawing.Size(131, 23);
            this.agregarAntesBtn.TabIndex = 14;
            this.agregarAntesBtn.Text = "Agregar antes de";
            this.agregarAntesBtn.UseVisualStyleBackColor = true;
            this.agregarAntesBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // agregarDespuesBtn
            // 
            this.agregarDespuesBtn.Location = new System.Drawing.Point(409, 415);
            this.agregarDespuesBtn.Name = "agregarDespuesBtn";
            this.agregarDespuesBtn.Size = new System.Drawing.Size(131, 23);
            this.agregarDespuesBtn.TabIndex = 15;
            this.agregarDespuesBtn.Text = "Agregar después de";
            this.agregarDespuesBtn.UseVisualStyleBackColor = true;
            this.agregarDespuesBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // mostrarBtn
            // 
            this.mostrarBtn.Location = new System.Drawing.Point(489, 290);
            this.mostrarBtn.Name = "mostrarBtn";
            this.mostrarBtn.Size = new System.Drawing.Size(75, 23);
            this.mostrarBtn.TabIndex = 18;
            this.mostrarBtn.Text = "Mostrar";
            this.mostrarBtn.UseVisualStyleBackColor = true;
            this.mostrarBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.Location = new System.Drawing.Point(568, 415);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(75, 23);
            this.eliminarBtn.TabIndex = 20;
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.UseVisualStyleBackColor = true;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "DNI";
            // 
            // dniAux
            // 
            this.dniAux.Location = new System.Drawing.Point(409, 379);
            this.dniAux.Name = "dniAux";
            this.dniAux.Size = new System.Drawing.Size(120, 20);
            this.dniAux.TabIndex = 21;
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(55, 359);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(120, 20);
            this.telefono.TabIndex = 23;
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dniAux);
            this.Controls.Add(this.eliminarBtn);
            this.Controls.Add(this.mostrarBtn);
            this.Controls.Add(this.agregarDespuesBtn);
            this.Controls.Add(this.agregarAntesBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.actualizarBtn);
            this.Controls.Add(this.registrarBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombre);
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio2";
            this.Load += new System.EventHandler(this.Ejercicio2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dniAux)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.NumericUpDown dni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button registrarBtn;
        private System.Windows.Forms.Button actualizarBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button agregarAntesBtn;
        private System.Windows.Forms.Button agregarDespuesBtn;
        private System.Windows.Forms.Button mostrarBtn;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown dniAux;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.NumericUpDown telefono;
    }
}

