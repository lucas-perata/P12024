namespace Ejercicio4
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
            this.mujerBtn = new System.Windows.Forms.Button();
            this.hombreBtn = new System.Windows.Forms.Button();
            this.mainList = new System.Windows.Forms.ListBox();
            this.hombresList = new System.Windows.Forms.ListBox();
            this.mujeresList = new System.Windows.Forms.ListBox();
            this.separarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mujerBtn
            // 
            this.mujerBtn.Location = new System.Drawing.Point(45, 112);
            this.mujerBtn.Name = "mujerBtn";
            this.mujerBtn.Size = new System.Drawing.Size(101, 23);
            this.mujerBtn.TabIndex = 0;
            this.mujerBtn.Text = "Agregar Mujer";
            this.mujerBtn.UseVisualStyleBackColor = true;
            this.mujerBtn.Click += new System.EventHandler(this.mujerBtn_Click);
            // 
            // hombreBtn
            // 
            this.hombreBtn.Location = new System.Drawing.Point(45, 168);
            this.hombreBtn.Name = "hombreBtn";
            this.hombreBtn.Size = new System.Drawing.Size(101, 23);
            this.hombreBtn.TabIndex = 1;
            this.hombreBtn.Text = "Agregar Hombre";
            this.hombreBtn.UseVisualStyleBackColor = true;
            this.hombreBtn.Click += new System.EventHandler(this.hombreBtn_Click);
            // 
            // mainList
            // 
            this.mainList.FormattingEnabled = true;
            this.mainList.Location = new System.Drawing.Point(216, 47);
            this.mainList.Name = "mainList";
            this.mainList.Size = new System.Drawing.Size(154, 199);
            this.mainList.TabIndex = 2;
            // 
            // hombresList
            // 
            this.hombresList.FormattingEnabled = true;
            this.hombresList.Location = new System.Drawing.Point(428, 47);
            this.hombresList.Name = "hombresList";
            this.hombresList.Size = new System.Drawing.Size(149, 199);
            this.hombresList.TabIndex = 3;
            // 
            // mujeresList
            // 
            this.mujeresList.FormattingEnabled = true;
            this.mujeresList.Location = new System.Drawing.Point(621, 47);
            this.mujeresList.Name = "mujeresList";
            this.mujeresList.Size = new System.Drawing.Size(143, 199);
            this.mujeresList.TabIndex = 4;
            // 
            // separarBtn
            // 
            this.separarBtn.Location = new System.Drawing.Point(370, 298);
            this.separarBtn.Name = "separarBtn";
            this.separarBtn.Size = new System.Drawing.Size(148, 23);
            this.separarBtn.TabIndex = 5;
            this.separarBtn.Text = "Separar de a uno";
            this.separarBtn.UseVisualStyleBackColor = true;
            this.separarBtn.Click += new System.EventHandler(this.separarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fila varones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(621, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fila mujeres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fila principal";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Separar todos juntos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(45, 297);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 10;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.separarBtn);
            this.Controls.Add(this.mujeresList);
            this.Controls.Add(this.hombresList);
            this.Controls.Add(this.mainList);
            this.Controls.Add(this.hombreBtn);
            this.Controls.Add(this.mujerBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mujerBtn;
        private System.Windows.Forms.Button hombreBtn;
        private System.Windows.Forms.ListBox mainList;
        private System.Windows.Forms.ListBox hombresList;
        private System.Windows.Forms.ListBox mujeresList;
        private System.Windows.Forms.Button separarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button resetBtn;
    }
}

