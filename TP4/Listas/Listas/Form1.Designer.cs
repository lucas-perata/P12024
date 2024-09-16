namespace Listas
{
    partial class Form1
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
            this.agregarButton = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellidoText = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.TextBox();
            this.mostrarButton = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.actualizarButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.NumericUpDown();
            this.telefono = new System.Windows.Forms.NumericUpDown();
            this.posicion = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Posición = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.despuesDeCodigo = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.despuesDeCodigo)).BeginInit();
            this.SuspendLayout();
            // 
            // agregarButton
            // 
            this.agregarButton.Location = new System.Drawing.Point(40, 328);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(75, 23);
            this.agregarButton.TabIndex = 1;
            this.agregarButton.Text = "Agregar";
            this.agregarButton.UseVisualStyleBackColor = true;
            this.agregarButton.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(70, 118);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 3;
            // 
            // apellidoText
            // 
            this.apellidoText.Location = new System.Drawing.Point(70, 175);
            this.apellidoText.Name = "apellidoText";
            this.apellidoText.Size = new System.Drawing.Size(100, 20);
            this.apellidoText.TabIndex = 4;
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(70, 221);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(100, 20);
            this.direccion.TabIndex = 5;
            // 
            // mostrarButton
            // 
            this.mostrarButton.Location = new System.Drawing.Point(672, 267);
            this.mostrarButton.Name = "mostrarButton";
            this.mostrarButton.Size = new System.Drawing.Size(97, 43);
            this.mostrarButton.TabIndex = 7;
            this.mostrarButton.Text = "Mostrar";
            this.mostrarButton.UseVisualStyleBackColor = true;
            this.mostrarButton.Click += new System.EventHandler(this.mostrarButton_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.Location = new System.Drawing.Point(449, 287);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(75, 23);
            this.eliminarButton.TabIndex = 8;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // actualizarButton
            // 
            this.actualizarButton.Location = new System.Drawing.Point(139, 328);
            this.actualizarButton.Name = "actualizarButton";
            this.actualizarButton.Size = new System.Drawing.Size(75, 23);
            this.actualizarButton.TabIndex = 10;
            this.actualizarButton.Text = "Actualizar";
            this.actualizarButton.UseVisualStyleBackColor = true;
            this.actualizarButton.Click += new System.EventHandler(this.actualizarButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(236, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(533, 198);
            this.dataGridView1.TabIndex = 12;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Código";
            this.Column3.Name = "Column3";
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
            // Column4
            // 
            this.Column4.HeaderText = "Teléfono";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Dirección";
            this.Column5.Name = "Column5";
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(70, 59);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(120, 20);
            this.codigo.TabIndex = 13;
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(70, 268);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(120, 20);
            this.telefono.TabIndex = 14;
            // 
            // posicion
            // 
            this.posicion.Location = new System.Drawing.Point(306, 290);
            this.posicion.Name = "posicion";
            this.posicion.Size = new System.Drawing.Size(120, 20);
            this.posicion.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Teléfono";
            // 
            // Posición
            // 
            this.Posición.AutoSize = true;
            this.Posición.Location = new System.Drawing.Point(303, 267);
            this.Posición.Name = "Posición";
            this.Posición.Size = new System.Drawing.Size(47, 13);
            this.Posición.TabIndex = 21;
            this.Posición.Text = "Posición";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Código";
            // 
            // despuesDeCodigo
            // 
            this.despuesDeCodigo.Location = new System.Drawing.Point(40, 393);
            this.despuesDeCodigo.Name = "despuesDeCodigo";
            this.despuesDeCodigo.Size = new System.Drawing.Size(120, 20);
            this.despuesDeCodigo.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Agregar después de";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.despuesDeCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Posición);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.posicion);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.actualizarButton);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.mostrarButton);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.apellidoText);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.agregarButton);
            this.Name = "Form1";
            this.Text = "Ejercicio1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.despuesDeCodigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellidoText;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Button mostrarButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button actualizarButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.NumericUpDown codigo;
        private System.Windows.Forms.NumericUpDown telefono;
        private System.Windows.Forms.NumericUpDown posicion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Posición;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown despuesDeCodigo;
        private System.Windows.Forms.Button button1;
    }
}