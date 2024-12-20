namespace p2
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
            btnPromedio = new System.Windows.Forms.Button();
            promediosGrid = new System.Windows.Forms.DataGridView();
            alumnosGrid = new System.Windows.Forms.DataGridView();
            notasGrid = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            mayorPromedioLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            mayorPromedioLegajoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)promediosGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alumnosGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)notasGrid).BeginInit();
            SuspendLayout();
            // 
            // btnPromedio
            // 
            btnPromedio.Location = new System.Drawing.Point(565, 341);
            btnPromedio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new System.Drawing.Size(161, 52);
            btnPromedio.TabIndex = 0;
            btnPromedio.Text = "Obtener promedios";
            btnPromedio.UseVisualStyleBackColor = true;
            btnPromedio.Click += btnPromedio_Click;
            // 
            // promediosGrid
            // 
            promediosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            promediosGrid.Location = new System.Drawing.Point(14, 306);
            promediosGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            promediosGrid.Name = "promediosGrid";
            promediosGrid.Size = new System.Drawing.Size(441, 173);
            promediosGrid.TabIndex = 1;
            // 
            // alumnosGrid
            // 
            alumnosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            alumnosGrid.Location = new System.Drawing.Point(13, 48);
            alumnosGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            alumnosGrid.Name = "alumnosGrid";
            alumnosGrid.Size = new System.Drawing.Size(343, 210);
            alumnosGrid.TabIndex = 2;
            // 
            // notasGrid
            // 
            notasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            notasGrid.Location = new System.Drawing.Point(403, 48);
            notasGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            notasGrid.Name = "notasGrid";
            notasGrid.Size = new System.Drawing.Size(459, 210);
            notasGrid.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(565, 445);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 15);
            label1.TabIndex = 4;
            label1.Text = "Mayor promedio: ";
            // 
            // mayorPromedioLabel
            // 
            mayorPromedioLabel.AutoSize = true;
            mayorPromedioLabel.Location = new System.Drawing.Point(688, 445);
            mayorPromedioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mayorPromedioLabel.Name = "mayorPromedioLabel";
            mayorPromedioLabel.Size = new System.Drawing.Size(38, 15);
            mayorPromedioLabel.TabIndex = 5;
            mayorPromedioLabel.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 18);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(55, 15);
            label2.TabIndex = 6;
            label2.Text = "Alumnos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(403, 18);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(38, 15);
            label3.TabIndex = 7;
            label3.Text = "Notas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(14, 276);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(64, 15);
            label4.TabIndex = 8;
            label4.Text = "Promedios";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(565, 476);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(45, 15);
            label5.TabIndex = 9;
            label5.Text = "Legajo:";
            // 
            // mayorPromedioLegajoLabel
            // 
            mayorPromedioLegajoLabel.AutoSize = true;
            mayorPromedioLegajoLabel.Location = new System.Drawing.Point(688, 476);
            mayorPromedioLegajoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mayorPromedioLegajoLabel.Name = "mayorPromedioLegajoLabel";
            mayorPromedioLegajoLabel.Size = new System.Drawing.Size(38, 15);
            mayorPromedioLegajoLabel.TabIndex = 10;
            mayorPromedioLegajoLabel.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(mayorPromedioLegajoLabel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(mayorPromedioLabel);
            Controls.Add(label1);
            Controls.Add(notasGrid);
            Controls.Add(alumnosGrid);
            Controls.Add(promediosGrid);
            Controls.Add(btnPromedio);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)promediosGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)alumnosGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)notasGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.DataGridView promediosGrid;
        private System.Windows.Forms.DataGridView alumnosGrid;
        private System.Windows.Forms.DataGridView notasGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mayorPromedioLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label mayorPromedioLegajoLabel;
    }
}

