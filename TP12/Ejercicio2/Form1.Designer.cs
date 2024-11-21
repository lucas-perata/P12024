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
            this.playBtn = new System.Windows.Forms.Button();
            this.anteriorBtn = new System.Windows.Forms.Button();
            this.siguienteBtn = new System.Windows.Forms.Button();
            this.nombreText = new System.Windows.Forms.TextBox();
            this.duracionInt = new System.Windows.Forms.NumericUpDown();
            this.agregarPrincipioBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancionesList = new System.Windows.Forms.ListBox();
            this.borrarBtn = new System.Windows.Forms.Button();
            this.agregarFinalBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblActual = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalCanciones = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.duracionInt)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(362, 273);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(55, 48);
            this.playBtn.TabIndex = 0;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // anteriorBtn
            // 
            this.anteriorBtn.Location = new System.Drawing.Point(216, 286);
            this.anteriorBtn.Name = "anteriorBtn";
            this.anteriorBtn.Size = new System.Drawing.Size(75, 23);
            this.anteriorBtn.TabIndex = 1;
            this.anteriorBtn.Text = "Anterior";
            this.anteriorBtn.UseVisualStyleBackColor = true;
            this.anteriorBtn.Click += new System.EventHandler(this.anteriorBtn_Click);
            // 
            // siguienteBtn
            // 
            this.siguienteBtn.Location = new System.Drawing.Point(483, 286);
            this.siguienteBtn.Name = "siguienteBtn";
            this.siguienteBtn.Size = new System.Drawing.Size(75, 23);
            this.siguienteBtn.TabIndex = 2;
            this.siguienteBtn.Text = "Siguiente";
            this.siguienteBtn.UseVisualStyleBackColor = true;
            this.siguienteBtn.Click += new System.EventHandler(this.siguienteBtn_Click);
            // 
            // nombreText
            // 
            this.nombreText.Location = new System.Drawing.Point(19, 19);
            this.nombreText.Name = "nombreText";
            this.nombreText.Size = new System.Drawing.Size(100, 20);
            this.nombreText.TabIndex = 3;
            // 
            // duracionInt
            // 
            this.duracionInt.Location = new System.Drawing.Point(19, 45);
            this.duracionInt.Name = "duracionInt";
            this.duracionInt.Size = new System.Drawing.Size(100, 20);
            this.duracionInt.TabIndex = 4;
            // 
            // agregarPrincipioBtn
            // 
            this.agregarPrincipioBtn.Location = new System.Drawing.Point(19, 74);
            this.agregarPrincipioBtn.Name = "agregarPrincipioBtn";
            this.agregarPrincipioBtn.Size = new System.Drawing.Size(100, 44);
            this.agregarPrincipioBtn.TabIndex = 5;
            this.agregarPrincipioBtn.Text = "Agregar principio";
            this.agregarPrincipioBtn.UseVisualStyleBackColor = true;
            this.agregarPrincipioBtn.Click += new System.EventHandler(this.agregarPrincipioBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(216, 208);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(342, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.agregarFinalBtn);
            this.groupBox1.Controls.Add(this.nombreText);
            this.groupBox1.Controls.Add(this.duracionInt);
            this.groupBox1.Controls.Add(this.agregarPrincipioBtn);
            this.groupBox1.Location = new System.Drawing.Point(635, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 181);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva canción";
            // 
            // cancionesList
            // 
            this.cancionesList.FormattingEnabled = true;
            this.cancionesList.Location = new System.Drawing.Point(216, 43);
            this.cancionesList.Name = "cancionesList";
            this.cancionesList.Size = new System.Drawing.Size(111, 147);
            this.cancionesList.TabIndex = 8;
            // 
            // borrarBtn
            // 
            this.borrarBtn.Location = new System.Drawing.Point(362, 87);
            this.borrarBtn.Name = "borrarBtn";
            this.borrarBtn.Size = new System.Drawing.Size(100, 44);
            this.borrarBtn.TabIndex = 6;
            this.borrarBtn.Text = "Borrar";
            this.borrarBtn.UseVisualStyleBackColor = true;
            this.borrarBtn.Click += new System.EventHandler(this.borrarBtn_Click);
            // 
            // agregarFinalBtn
            // 
            this.agregarFinalBtn.Location = new System.Drawing.Point(19, 124);
            this.agregarFinalBtn.Name = "agregarFinalBtn";
            this.agregarFinalBtn.Size = new System.Drawing.Size(100, 44);
            this.agregarFinalBtn.TabIndex = 6;
            this.agregarFinalBtn.Text = "Agregar final";
            this.agregarFinalBtn.UseVisualStyleBackColor = true;
            this.agregarFinalBtn.Click += new System.EventHandler(this.agregarFinalBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Reproduciendo actualmente";
            // 
            // lblActual
            // 
            this.lblActual.AutoSize = true;
            this.lblActual.Location = new System.Drawing.Point(382, 372);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(35, 13);
            this.lblActual.TabIndex = 10;
            this.lblActual.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cantidad total: ";
            // 
            // lblTotalCanciones
            // 
            this.lblTotalCanciones.AutoSize = true;
            this.lblTotalCanciones.Location = new System.Drawing.Point(385, 412);
            this.lblTotalCanciones.Name = "lblTotalCanciones";
            this.lblTotalCanciones.Size = new System.Drawing.Size(35, 13);
            this.lblTotalCanciones.TabIndex = 12;
            this.lblTotalCanciones.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalCanciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblActual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.borrarBtn);
            this.Controls.Add(this.cancionesList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.siguienteBtn);
            this.Controls.Add(this.anteriorBtn);
            this.Controls.Add(this.playBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.duracionInt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button siguienteBtn;
        private System.Windows.Forms.Button anteriorBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.NumericUpDown duracionInt;
        private System.Windows.Forms.TextBox nombreText;
        private System.Windows.Forms.Button agregarPrincipioBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button agregarFinalBtn;
        private System.Windows.Forms.ListBox cancionesList;
        private System.Windows.Forms.Button borrarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblActual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalCanciones;
    }
}

