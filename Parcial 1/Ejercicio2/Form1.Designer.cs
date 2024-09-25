namespace Ejercicio2
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
            this.clientesList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreCliente = new System.Windows.Forms.TextBox();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.cobrarBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.totalCobradoLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.importeCliente = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.importeCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // clientesList
            // 
            this.clientesList.FormattingEnabled = true;
            this.clientesList.Location = new System.Drawing.Point(553, 89);
            this.clientesList.Name = "clientesList";
            this.clientesList.Size = new System.Drawing.Size(161, 238);
            this.clientesList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(550, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cola para pagar";
            // 
            // nombreCliente
            // 
            this.nombreCliente.Location = new System.Drawing.Point(228, 137);
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.Size = new System.Drawing.Size(120, 20);
            this.nombreCliente.TabIndex = 3;
            // 
            // agregarBtn
            // 
            this.agregarBtn.Location = new System.Drawing.Point(228, 252);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(120, 23);
            this.agregarBtn.TabIndex = 4;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = true;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // cobrarBtn
            // 
            this.cobrarBtn.Location = new System.Drawing.Point(609, 377);
            this.cobrarBtn.Name = "cobrarBtn";
            this.cobrarBtn.Size = new System.Drawing.Size(75, 23);
            this.cobrarBtn.TabIndex = 5;
            this.cobrarBtn.Text = "Cobrar";
            this.cobrarBtn.UseVisualStyleBackColor = true;
            this.cobrarBtn.Click += new System.EventHandler(this.cobrarBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total: ";
            // 
            // totalCobradoLabel
            // 
            this.totalCobradoLabel.AutoSize = true;
            this.totalCobradoLabel.Location = new System.Drawing.Point(627, 348);
            this.totalCobradoLabel.Name = "totalCobradoLabel";
            this.totalCobradoLabel.Size = new System.Drawing.Size(0, 13);
            this.totalCobradoLabel.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Importe";
            // 
            // importeCliente
            // 
            this.importeCliente.Location = new System.Drawing.Point(228, 207);
            this.importeCliente.Name = "importeCliente";
            this.importeCliente.Size = new System.Drawing.Size(120, 20);
            this.importeCliente.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.importeCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalCobradoLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cobrarBtn);
            this.Controls.Add(this.agregarBtn);
            this.Controls.Add(this.nombreCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientesList);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.importeCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox clientesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreCliente;
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.Button cobrarBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalCobradoLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown importeCliente;
    }
}

