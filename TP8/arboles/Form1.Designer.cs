namespace arboles
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtRecorrido = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAncho = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblNombreNodo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(39, 39);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(218, 274);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Agregar derecha";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(315, 131);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "Agregar izquierda";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(315, 177);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 44);
            this.button4.TabIndex = 4;
            this.button4.Text = "Inorden";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(315, 223);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 44);
            this.button5.TabIndex = 5;
            this.button5.Text = "Preorden";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(315, 269);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 44);
            this.button6.TabIndex = 6;
            this.button6.Text = "Postorden";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtRecorrido
            // 
            this.txtRecorrido.Location = new System.Drawing.Point(315, 333);
            this.txtRecorrido.Name = "txtRecorrido";
            this.txtRecorrido.Size = new System.Drawing.Size(139, 20);
            this.txtRecorrido.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNombreNodo);
            this.groupBox1.Location = new System.Drawing.Point(39, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 33);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nodo seleccionado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAncho);
            this.groupBox2.Controls.Add(this.lblAltura);
            this.groupBox2.Location = new System.Drawing.Point(39, 360);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 51);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Árbol";
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Location = new System.Drawing.Point(139, 20);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(35, 13);
            this.lblAncho.TabIndex = 1;
            this.lblAncho.Text = "label1";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(7, 20);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(35, 13);
            this.lblAltura.TabIndex = 0;
            this.lblAltura.Text = "label1";
            // 
            // lblNombreNodo
            // 
            this.lblNombreNodo.AutoSize = true;
            this.lblNombreNodo.Location = new System.Drawing.Point(7, 13);
            this.lblNombreNodo.Name = "lblNombreNodo";
            this.lblNombreNodo.Size = new System.Drawing.Size(35, 13);
            this.lblNombreNodo.TabIndex = 2;
            this.lblNombreNodo.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 423);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtRecorrido);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtRecorrido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblNombreNodo;
    }
}

