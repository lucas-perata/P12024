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
            this.agregarFinalBtn = new System.Windows.Forms.Button();
            this.cancionesList = new System.Windows.Forms.ListBox();
            this.borrarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblActual = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalCanciones = new System.Windows.Forms.Label();
            this.numPosicion = new System.Windows.Forms.NumericUpDown();
            this.posicionBtn = new System.Windows.Forms.Button();
            this.intercambiarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.duracionInt)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPosicion)).BeginInit();
            this.SuspendLayout();
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(260, 269);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(55, 48);
            this.playBtn.TabIndex = 0;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // anteriorBtn
            // 
            this.anteriorBtn.Location = new System.Drawing.Point(114, 282);
            this.anteriorBtn.Name = "anteriorBtn";
            this.anteriorBtn.Size = new System.Drawing.Size(75, 23);
            this.anteriorBtn.TabIndex = 1;
            this.anteriorBtn.Text = "Anterior";
            this.anteriorBtn.UseVisualStyleBackColor = true;
            this.anteriorBtn.Click += new System.EventHandler(this.anteriorBtn_Click);
            // 
            // siguienteBtn
            // 
            this.siguienteBtn.Location = new System.Drawing.Point(381, 282);
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
            this.progressBar1.Location = new System.Drawing.Point(114, 204);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(342, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.posicionBtn);
            this.groupBox1.Controls.Add(this.numPosicion);
            this.groupBox1.Controls.Add(this.agregarFinalBtn);
            this.groupBox1.Controls.Add(this.nombreText);
            this.groupBox1.Controls.Add(this.duracionInt);
            this.groupBox1.Controls.Add(this.agregarPrincipioBtn);
            this.groupBox1.Location = new System.Drawing.Point(533, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 278);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva canción";
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
            // cancionesList
            // 
            this.cancionesList.FormattingEnabled = true;
            this.cancionesList.Location = new System.Drawing.Point(114, 39);
            this.cancionesList.Name = "cancionesList";
            this.cancionesList.Size = new System.Drawing.Size(111, 147);
            this.cancionesList.TabIndex = 8;
            // 
            // borrarBtn
            // 
            this.borrarBtn.Location = new System.Drawing.Point(260, 54);
            this.borrarBtn.Name = "borrarBtn";
            this.borrarBtn.Size = new System.Drawing.Size(100, 44);
            this.borrarBtn.TabIndex = 6;
            this.borrarBtn.Text = "Borrar";
            this.borrarBtn.UseVisualStyleBackColor = true;
            this.borrarBtn.Click += new System.EventHandler(this.borrarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Reproduciendo actualmente";
            // 
            // lblActual
            // 
            this.lblActual.AutoSize = true;
            this.lblActual.Location = new System.Drawing.Point(280, 368);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(0, 13);
            this.lblActual.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cantidad total: ";
            // 
            // lblTotalCanciones
            // 
            this.lblTotalCanciones.AutoSize = true;
            this.lblTotalCanciones.Location = new System.Drawing.Point(283, 408);
            this.lblTotalCanciones.Name = "lblTotalCanciones";
            this.lblTotalCanciones.Size = new System.Drawing.Size(0, 13);
            this.lblTotalCanciones.TabIndex = 12;
            // 
            // numPosicion
            // 
            this.numPosicion.Location = new System.Drawing.Point(19, 183);
            this.numPosicion.Name = "numPosicion";
            this.numPosicion.Size = new System.Drawing.Size(100, 20);
            this.numPosicion.TabIndex = 7;
            // 
            // posicionBtn
            // 
            this.posicionBtn.Location = new System.Drawing.Point(19, 209);
            this.posicionBtn.Name = "posicionBtn";
            this.posicionBtn.Size = new System.Drawing.Size(100, 44);
            this.posicionBtn.TabIndex = 8;
            this.posicionBtn.Text = "Agregar posición";
            this.posicionBtn.UseVisualStyleBackColor = true;
            this.posicionBtn.Click += new System.EventHandler(this.posicionBtn_Click);
            // 
            // intercambiarBtn
            // 
            this.intercambiarBtn.Location = new System.Drawing.Point(260, 122);
            this.intercambiarBtn.Name = "intercambiarBtn";
            this.intercambiarBtn.Size = new System.Drawing.Size(100, 44);
            this.intercambiarBtn.TabIndex = 13;
            this.intercambiarBtn.Text = "Intercambiar derecha";
            this.intercambiarBtn.UseVisualStyleBackColor = true;
            this.intercambiarBtn.Click += new System.EventHandler(this.intercambiarBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 450);
            this.Controls.Add(this.intercambiarBtn);
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
            ((System.ComponentModel.ISupportInitialize)(this.numPosicion)).EndInit();
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
        private System.Windows.Forms.Button posicionBtn;
        private System.Windows.Forms.NumericUpDown numPosicion;
        private System.Windows.Forms.Button intercambiarBtn;
    }
}

