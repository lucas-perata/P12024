namespace Listas6
{
    partial class Ejercicio6
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
            this.agregarBtn = new System.Windows.Forms.Button();
            this.edad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.listaPersonas = new System.Windows.Forms.ListBox();
            this.edadBtn = new System.Windows.Forms.CheckBox();
            this.calculo = new System.Windows.Forms.TextBox();
            this.calcularBtn = new System.Windows.Forms.Button();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.actualizarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.edad)).BeginInit();
            this.SuspendLayout();
            // 
            // agregarBtn
            // 
            this.agregarBtn.Location = new System.Drawing.Point(118, 336);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(233, 23);
            this.agregarBtn.TabIndex = 0;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = true;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // edad
            // 
            this.edad.Location = new System.Drawing.Point(118, 298);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(120, 20);
            this.edad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Edad";
            // 
            // listaPersonas
            // 
            this.listaPersonas.FormattingEnabled = true;
            this.listaPersonas.Location = new System.Drawing.Point(182, 59);
            this.listaPersonas.Name = "listaPersonas";
            this.listaPersonas.Size = new System.Drawing.Size(120, 173);
            this.listaPersonas.TabIndex = 3;
            this.listaPersonas.SelectedIndexChanged += new System.EventHandler(this.listaPersonas_SelectedIndexChanged);
            // 
            // edadBtn
            // 
            this.edadBtn.AutoSize = true;
            this.edadBtn.Location = new System.Drawing.Point(271, 299);
            this.edadBtn.Name = "edadBtn";
            this.edadBtn.Size = new System.Drawing.Size(94, 17);
            this.edadBtn.TabIndex = 5;
            this.edadBtn.Text = "Edad aleatoria";
            this.edadBtn.UseVisualStyleBackColor = true;
            this.edadBtn.CheckedChanged += new System.EventHandler(this.edadBtn_CheckedChanged_1);
            // 
            // calculo
            // 
            this.calculo.Location = new System.Drawing.Point(564, 191);
            this.calculo.Name = "calculo";
            this.calculo.Size = new System.Drawing.Size(100, 20);
            this.calculo.TabIndex = 6;
            // 
            // calcularBtn
            // 
            this.calcularBtn.Location = new System.Drawing.Point(564, 240);
            this.calcularBtn.Name = "calcularBtn";
            this.calcularBtn.Size = new System.Drawing.Size(100, 23);
            this.calcularBtn.TabIndex = 7;
            this.calcularBtn.Text = "Calcular";
            this.calcularBtn.UseVisualStyleBackColor = true;
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.Location = new System.Drawing.Point(118, 397);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(233, 23);
            this.eliminarBtn.TabIndex = 8;
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.UseVisualStyleBackColor = true;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // actualizarBtn
            // 
            this.actualizarBtn.Location = new System.Drawing.Point(118, 366);
            this.actualizarBtn.Name = "actualizarBtn";
            this.actualizarBtn.Size = new System.Drawing.Size(233, 23);
            this.actualizarBtn.TabIndex = 9;
            this.actualizarBtn.Text = "Actualizar";
            this.actualizarBtn.UseVisualStyleBackColor = true;
            this.actualizarBtn.Click += new System.EventHandler(this.actualizarBtn_Click);
            // 
            // Ejercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.actualizarBtn);
            this.Controls.Add(this.eliminarBtn);
            this.Controls.Add(this.calcularBtn);
            this.Controls.Add(this.calculo);
            this.Controls.Add(this.edadBtn);
            this.Controls.Add(this.listaPersonas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edad);
            this.Controls.Add(this.agregarBtn);
            this.Name = "Ejercicio6";
            this.Text = "Ejercicio6";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.NumericUpDown edad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listaPersonas;
        private System.Windows.Forms.CheckBox edadBtn;
        private System.Windows.Forms.TextBox calculo;
        private System.Windows.Forms.Button calcularBtn;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Button actualizarBtn;
    }
}

