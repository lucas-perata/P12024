namespace Ejercicio3
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
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.caratula = new System.Windows.Forms.TextBox();
            this.numero = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pushBtn = new System.Windows.Forms.Button();
            this.expedientesBox = new System.Windows.Forms.ListBox();
            this.ordenadosBox = new System.Windows.Forms.ListBox();
            this.ordenarBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numero)).BeginInit();
            this.SuspendLayout();
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(33, 214);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(200, 20);
            this.fecha.TabIndex = 0;
            // 
            // caratula
            // 
            this.caratula.Location = new System.Drawing.Point(33, 144);
            this.caratula.Name = "caratula";
            this.caratula.Size = new System.Drawing.Size(120, 20);
            this.caratula.TabIndex = 1;
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(33, 79);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(120, 20);
            this.numero.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Carátula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha";
            // 
            // pushBtn
            // 
            this.pushBtn.Location = new System.Drawing.Point(33, 270);
            this.pushBtn.Name = "pushBtn";
            this.pushBtn.Size = new System.Drawing.Size(75, 23);
            this.pushBtn.TabIndex = 6;
            this.pushBtn.Text = "Apilar";
            this.pushBtn.UseVisualStyleBackColor = true;
            this.pushBtn.Click += new System.EventHandler(this.pushBtn_Click);
            // 
            // expedientesBox
            // 
            this.expedientesBox.FormattingEnabled = true;
            this.expedientesBox.Location = new System.Drawing.Point(281, 81);
            this.expedientesBox.Name = "expedientesBox";
            this.expedientesBox.Size = new System.Drawing.Size(239, 212);
            this.expedientesBox.TabIndex = 7;
            // 
            // ordenadosBox
            // 
            this.ordenadosBox.FormattingEnabled = true;
            this.ordenadosBox.Location = new System.Drawing.Point(540, 81);
            this.ordenadosBox.Name = "ordenadosBox";
            this.ordenadosBox.Size = new System.Drawing.Size(233, 212);
            this.ordenadosBox.TabIndex = 8;
            // 
            // ordenarBtn
            // 
            this.ordenarBtn.Location = new System.Drawing.Point(499, 325);
            this.ordenarBtn.Name = "ordenarBtn";
            this.ordenarBtn.Size = new System.Drawing.Size(75, 23);
            this.ordenarBtn.TabIndex = 9;
            this.ordenarBtn.Text = "Ordenar";
            this.ordenarBtn.UseVisualStyleBackColor = true;
            this.ordenarBtn.Click += new System.EventHandler(this.ordenarBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Expedientes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(588, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Expedientes ordenados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ordenarBtn);
            this.Controls.Add(this.ordenadosBox);
            this.Controls.Add(this.expedientesBox);
            this.Controls.Add(this.pushBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.caratula);
            this.Controls.Add(this.fecha);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.TextBox caratula;
        private System.Windows.Forms.NumericUpDown numero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pushBtn;
        private System.Windows.Forms.ListBox expedientesBox;
        private System.Windows.Forms.ListBox ordenadosBox;
        private System.Windows.Forms.Button ordenarBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

