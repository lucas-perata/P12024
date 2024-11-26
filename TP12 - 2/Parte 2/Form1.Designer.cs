namespace Parte_2
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.stockModelosData = new System.Windows.Forms.DataGridView();
            this.stockPiezasData = new System.Windows.Forms.DataGridView();
            this.pedidosData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pedidosModeloData = new System.Windows.Forms.DataGridView();
            this.pedidosPiezasData = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockModelosData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockPiezasData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosModeloData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosPiezasData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(365, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // stockModelosData
            // 
            this.stockModelosData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockModelosData.Location = new System.Drawing.Point(466, 25);
            this.stockModelosData.Name = "stockModelosData";
            this.stockModelosData.Size = new System.Drawing.Size(367, 150);
            this.stockModelosData.TabIndex = 1;
            // 
            // stockPiezasData
            // 
            this.stockPiezasData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockPiezasData.Location = new System.Drawing.Point(67, 206);
            this.stockPiezasData.Name = "stockPiezasData";
            this.stockPiezasData.Size = new System.Drawing.Size(365, 150);
            this.stockPiezasData.TabIndex = 2;
            // 
            // pedidosData
            // 
            this.pedidosData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pedidosData.Location = new System.Drawing.Point(466, 206);
            this.pedidosData.Name = "pedidosData";
            this.pedidosData.Size = new System.Drawing.Size(367, 150);
            this.pedidosData.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Composición";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stock modelos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stock piezas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pedidos";
            // 
            // pedidosModeloData
            // 
            this.pedidosModeloData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pedidosModeloData.Location = new System.Drawing.Point(26, 398);
            this.pedidosModeloData.Name = "pedidosModeloData";
            this.pedidosModeloData.Size = new System.Drawing.Size(406, 179);
            this.pedidosModeloData.TabIndex = 8;
            // 
            // pedidosPiezasData
            // 
            this.pedidosPiezasData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pedidosPiezasData.Location = new System.Drawing.Point(474, 398);
            this.pedidosPiezasData.Name = "pedidosPiezasData";
            this.pedidosPiezasData.Size = new System.Drawing.Size(401, 179);
            this.pedidosPiezasData.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pedidos por modelo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Pedidos por pieza";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 628);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pedidosPiezasData);
            this.Controls.Add(this.pedidosModeloData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pedidosData);
            this.Controls.Add(this.stockPiezasData);
            this.Controls.Add(this.stockModelosData);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockModelosData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockPiezasData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosModeloData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosPiezasData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView stockModelosData;
        private System.Windows.Forms.DataGridView stockPiezasData;
        private System.Windows.Forms.DataGridView pedidosData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView pedidosModeloData;
        private System.Windows.Forms.DataGridView pedidosPiezasData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

