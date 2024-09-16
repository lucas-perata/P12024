namespace _10
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ran1Btn = new System.Windows.Forms.RadioButton();
            this.kel1Btn = new System.Windows.Forms.RadioButton();
            this.far1Btn = new System.Windows.Forms.RadioButton();
            this.cel1Btn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ran2Btn = new System.Windows.Forms.RadioButton();
            this.kel2Btn = new System.Windows.Forms.RadioButton();
            this.far2Btn = new System.Windows.Forms.RadioButton();
            this.cel2Btn = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(200, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Valor Inicial";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Valor final";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "De";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "A";
            this.Column4.Name = "Column4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(464, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ran1Btn);
            this.groupBox1.Controls.Add(this.kel1Btn);
            this.groupBox1.Controls.Add(this.far1Btn);
            this.groupBox1.Controls.Add(this.cel1Btn);
            this.groupBox1.Location = new System.Drawing.Point(112, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "De";
            // 
            // ran1Btn
            // 
            this.ran1Btn.AutoSize = true;
            this.ran1Btn.Location = new System.Drawing.Point(147, 69);
            this.ran1Btn.Name = "ran1Btn";
            this.ran1Btn.Size = new System.Drawing.Size(65, 17);
            this.ran1Btn.TabIndex = 3;
            this.ran1Btn.TabStop = true;
            this.ran1Btn.Text = "Rankine";
            this.ran1Btn.UseVisualStyleBackColor = true;
            // 
            // kel1Btn
            // 
            this.kel1Btn.AutoSize = true;
            this.kel1Btn.Location = new System.Drawing.Point(147, 29);
            this.kel1Btn.Name = "kel1Btn";
            this.kel1Btn.Size = new System.Drawing.Size(54, 17);
            this.kel1Btn.TabIndex = 2;
            this.kel1Btn.TabStop = true;
            this.kel1Btn.Text = "Kelvin";
            this.kel1Btn.UseVisualStyleBackColor = true;
            // 
            // far1Btn
            // 
            this.far1Btn.AutoSize = true;
            this.far1Btn.Location = new System.Drawing.Point(23, 69);
            this.far1Btn.Name = "far1Btn";
            this.far1Btn.Size = new System.Drawing.Size(75, 17);
            this.far1Btn.TabIndex = 1;
            this.far1Btn.TabStop = true;
            this.far1Btn.Text = "Fahrenheit";
            this.far1Btn.UseVisualStyleBackColor = true;
            // 
            // cel1Btn
            // 
            this.cel1Btn.AutoSize = true;
            this.cel1Btn.Location = new System.Drawing.Point(23, 29);
            this.cel1Btn.Name = "cel1Btn";
            this.cel1Btn.Size = new System.Drawing.Size(58, 17);
            this.cel1Btn.TabIndex = 0;
            this.cel1Btn.TabStop = true;
            this.cel1Btn.Text = "Celsius";
            this.cel1Btn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ran2Btn);
            this.groupBox2.Controls.Add(this.kel2Btn);
            this.groupBox2.Controls.Add(this.far2Btn);
            this.groupBox2.Controls.Add(this.cel2Btn);
            this.groupBox2.Location = new System.Drawing.Point(462, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "A";
            // 
            // ran2Btn
            // 
            this.ran2Btn.AutoSize = true;
            this.ran2Btn.Location = new System.Drawing.Point(130, 69);
            this.ran2Btn.Name = "ran2Btn";
            this.ran2Btn.Size = new System.Drawing.Size(65, 17);
            this.ran2Btn.TabIndex = 3;
            this.ran2Btn.TabStop = true;
            this.ran2Btn.Text = "Rankine";
            this.ran2Btn.UseVisualStyleBackColor = true;
            // 
            // kel2Btn
            // 
            this.kel2Btn.AutoSize = true;
            this.kel2Btn.Location = new System.Drawing.Point(130, 29);
            this.kel2Btn.Name = "kel2Btn";
            this.kel2Btn.Size = new System.Drawing.Size(54, 17);
            this.kel2Btn.TabIndex = 2;
            this.kel2Btn.TabStop = true;
            this.kel2Btn.Text = "Kelvin";
            this.kel2Btn.UseVisualStyleBackColor = true;
            // 
            // far2Btn
            // 
            this.far2Btn.AutoSize = true;
            this.far2Btn.Location = new System.Drawing.Point(17, 69);
            this.far2Btn.Name = "far2Btn";
            this.far2Btn.Size = new System.Drawing.Size(75, 17);
            this.far2Btn.TabIndex = 1;
            this.far2Btn.TabStop = true;
            this.far2Btn.Text = "Fahrenheit";
            this.far2Btn.UseVisualStyleBackColor = true;
            // 
            // cel2Btn
            // 
            this.cel2Btn.AutoSize = true;
            this.cel2Btn.Location = new System.Drawing.Point(17, 29);
            this.cel2Btn.Name = "cel2Btn";
            this.cel2Btn.Size = new System.Drawing.Size(58, 17);
            this.cel2Btn.TabIndex = 0;
            this.cel2Btn.TabStop = true;
            this.cel2Btn.Text = "Celsius";
            this.cel2Btn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Convertir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ran1Btn;
        private System.Windows.Forms.RadioButton kel1Btn;
        private System.Windows.Forms.RadioButton far1Btn;
        private System.Windows.Forms.RadioButton cel1Btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton ran2Btn;
        private System.Windows.Forms.RadioButton kel2Btn;
        private System.Windows.Forms.RadioButton far2Btn;
        private System.Windows.Forms.RadioButton cel2Btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button button1;
    }
}

