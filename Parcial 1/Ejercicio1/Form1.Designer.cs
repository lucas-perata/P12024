namespace Ejercicio1
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
            this.components = new System.ComponentModel.Container();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.timerLabel = new System.Windows.Forms.Label();
            this.activarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tiempoRestanteLabel = new System.Windows.Forms.Label();
            this.numerosLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(301, 226);
            this.hScrollBar1.Maximum = 14;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(206, 37);
            this.hScrollBar1.TabIndex = 0;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(526, 239);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 24);
            this.timerLabel.TabIndex = 1;
            // 
            // activarBtn
            // 
            this.activarBtn.Location = new System.Drawing.Point(328, 306);
            this.activarBtn.Name = "activarBtn";
            this.activarBtn.Size = new System.Drawing.Size(144, 53);
            this.activarBtn.TabIndex = 2;
            this.activarBtn.Text = "activarTimer";
            this.activarBtn.UseVisualStyleBackColor = true;
            this.activarBtn.Click += new System.EventHandler(this.activarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tiempo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Números";
            // 
            // tiempoRestanteLabel
            // 
            this.tiempoRestanteLabel.AutoSize = true;
            this.tiempoRestanteLabel.Location = new System.Drawing.Point(439, 125);
            this.tiempoRestanteLabel.Name = "tiempoRestanteLabel";
            this.tiempoRestanteLabel.Size = new System.Drawing.Size(0, 13);
            this.tiempoRestanteLabel.TabIndex = 5;
            // 
            // numerosLabel
            // 
            this.numerosLabel.AutoSize = true;
            this.numerosLabel.Location = new System.Drawing.Point(439, 153);
            this.numerosLabel.Name = "numerosLabel";
            this.numerosLabel.Size = new System.Drawing.Size(0, 13);
            this.numerosLabel.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numerosLabel);
            this.Controls.Add(this.tiempoRestanteLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.activarBtn);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.hScrollBar1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button activarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tiempoRestanteLabel;
        private System.Windows.Forms.Label numerosLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

