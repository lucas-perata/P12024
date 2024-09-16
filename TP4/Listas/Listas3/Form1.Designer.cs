namespace Listas3
{
    partial class Ejercicio3
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generarBtn = new System.Windows.Forms.Button();
            this.recaudacionBtn = new System.Windows.Forms.Button();
            this.edad = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.posicionB = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.posicionA = new System.Windows.Forms.NumericUpDown();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadPersonas = new System.Windows.Forms.TextBox();
            this.totalRecaudado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posicionB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posicionA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de personas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total recaudado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(501, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 381);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Edad";
            this.Column1.Name = "Column1";
            // 
            // generarBtn
            // 
            this.generarBtn.Location = new System.Drawing.Point(81, 153);
            this.generarBtn.Name = "generarBtn";
            this.generarBtn.Size = new System.Drawing.Size(75, 23);
            this.generarBtn.TabIndex = 3;
            this.generarBtn.Text = "Generar lista";
            this.generarBtn.UseVisualStyleBackColor = true;
            this.generarBtn.Click += new System.EventHandler(this.generarBtn_Click);
            // 
            // recaudacionBtn
            // 
            this.recaudacionBtn.Location = new System.Drawing.Point(81, 202);
            this.recaudacionBtn.Name = "recaudacionBtn";
            this.recaudacionBtn.Size = new System.Drawing.Size(116, 23);
            this.recaudacionBtn.TabIndex = 4;
            this.recaudacionBtn.Text = "Calcular recaudación";
            this.recaudacionBtn.UseVisualStyleBackColor = true;
            this.recaudacionBtn.Click += new System.EventHandler(this.recaudacionBtn_Click);
            // 
            // edad
            // 
            this.edad.Location = new System.Drawing.Point(81, 300);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(120, 20);
            this.edad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Edad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Posición";
            // 
            // posicionB
            // 
            this.posicionB.Location = new System.Drawing.Point(304, 348);
            this.posicionB.Name = "posicionB";
            this.posicionB.Size = new System.Drawing.Size(120, 20);
            this.posicionB.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(304, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Posición";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // posicionA
            // 
            this.posicionA.Location = new System.Drawing.Point(81, 345);
            this.posicionA.Name = "posicionA";
            this.posicionA.Size = new System.Drawing.Size(120, 20);
            this.posicionA.TabIndex = 11;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Numero";
            this.Column2.Name = "Column2";
            // 
            // cantidadPersonas
            // 
            this.cantidadPersonas.Location = new System.Drawing.Point(239, 36);
            this.cantidadPersonas.Name = "cantidadPersonas";
            this.cantidadPersonas.Size = new System.Drawing.Size(100, 20);
            this.cantidadPersonas.TabIndex = 13;
            // 
            // totalRecaudado
            // 
            this.totalRecaudado.Location = new System.Drawing.Point(239, 77);
            this.totalRecaudado.Name = "totalRecaudado";
            this.totalRecaudado.Size = new System.Drawing.Size(100, 20);
            this.totalRecaudado.TabIndex = 14;
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalRecaudado);
            this.Controls.Add(this.cantidadPersonas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.posicionA);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.posicionB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edad);
            this.Controls.Add(this.recaudacionBtn);
            this.Controls.Add(this.generarBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio3";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Ejercicio3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posicionB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posicionA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button generarBtn;
        private System.Windows.Forms.Button recaudacionBtn;
        private System.Windows.Forms.NumericUpDown edad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown posicionB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown posicionA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox cantidadPersonas;
        private System.Windows.Forms.TextBox totalRecaudado;
    }
}

