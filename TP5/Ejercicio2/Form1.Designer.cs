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
            this.pueblosList = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pushBtn = new System.Windows.Forms.Button();
            this.popBtn = new System.Windows.Forms.Button();
            this.vueltaBtn = new System.Windows.Forms.Button();
            this.viajesList = new System.Windows.Forms.ListBox();
            this.idaBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pueblosList
            // 
            this.pueblosList.FormattingEnabled = true;
            this.pueblosList.Location = new System.Drawing.Point(289, 74);
            this.pueblosList.Name = "pueblosList";
            this.pueblosList.Size = new System.Drawing.Size(97, 147);
            this.pueblosList.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // pushBtn
            // 
            this.pushBtn.Location = new System.Drawing.Point(74, 119);
            this.pushBtn.Name = "pushBtn";
            this.pushBtn.Size = new System.Drawing.Size(75, 23);
            this.pushBtn.TabIndex = 3;
            this.pushBtn.Text = "Push";
            this.pushBtn.UseVisualStyleBackColor = true;
            this.pushBtn.Click += new System.EventHandler(this.pushBtn_Click);
            // 
            // popBtn
            // 
            this.popBtn.Location = new System.Drawing.Point(74, 165);
            this.popBtn.Name = "popBtn";
            this.popBtn.Size = new System.Drawing.Size(75, 23);
            this.popBtn.TabIndex = 4;
            this.popBtn.Text = "Pop";
            this.popBtn.UseVisualStyleBackColor = true;
            // 
            // vueltaBtn
            // 
            this.vueltaBtn.Location = new System.Drawing.Point(560, 296);
            this.vueltaBtn.Name = "vueltaBtn";
            this.vueltaBtn.Size = new System.Drawing.Size(75, 23);
            this.vueltaBtn.TabIndex = 5;
            this.vueltaBtn.Text = "Vuelta";
            this.vueltaBtn.UseVisualStyleBackColor = true;
            this.vueltaBtn.Click += new System.EventHandler(this.vueltaBtn_Click);
            // 
            // viajesList
            // 
            this.viajesList.FormattingEnabled = true;
            this.viajesList.Location = new System.Drawing.Point(560, 75);
            this.viajesList.Name = "viajesList";
            this.viajesList.Size = new System.Drawing.Size(96, 147);
            this.viajesList.TabIndex = 6;
            // 
            // idaBtn
            // 
            this.idaBtn.Location = new System.Drawing.Point(560, 257);
            this.idaBtn.Name = "idaBtn";
            this.idaBtn.Size = new System.Drawing.Size(75, 23);
            this.idaBtn.TabIndex = 7;
            this.idaBtn.Text = "Ida";
            this.idaBtn.UseVisualStyleBackColor = true;
            this.idaBtn.Click += new System.EventHandler(this.idaBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "origen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(557, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "destino";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idaBtn);
            this.Controls.Add(this.viajesList);
            this.Controls.Add(this.vueltaBtn);
            this.Controls.Add(this.popBtn);
            this.Controls.Add(this.pushBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pueblosList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox pueblosList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button pushBtn;
        private System.Windows.Forms.Button popBtn;
        private System.Windows.Forms.Button vueltaBtn;
        private System.Windows.Forms.ListBox viajesList;
        private System.Windows.Forms.Button idaBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

