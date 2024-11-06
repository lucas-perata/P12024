namespace Parte_B
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Checked = new DataGridViewCheckBoxColumn();
            dataGridView2 = new DataGridView();
            Seleccionar1 = new DataGridViewCheckBoxColumn();
            dniAlumnos = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            notaEdit = new Button();
            notaDelete = new Button();
            alumnoEdit = new Button();
            alumnoDelete = new Button();
            nombreTxt = new TextBox();
            apellidoTxt = new TextBox();
            dniNotas = new NumericUpDown();
            notaNum = new NumericUpDown();
            dateNota = new DateTimePicker();
            submitAlumno = new Button();
            submitNota = new Button();
            dataGridView3 = new DataGridView();
            promedioBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dniAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dniNotas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)notaNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Checked });
            dataGridView1.Location = new Point(22, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(444, 155);
            dataGridView1.TabIndex = 0;
            // 
            // Checked
            // 
            Checked.HeaderText = "Seleccionar";
            Checked.Name = "Checked";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Seleccionar1 });
            dataGridView2.Location = new Point(22, 283);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(444, 155);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Seleccionar1
            // 
            Seleccionar1.HeaderText = "Seleccionar";
            Seleccionar1.Name = "Seleccionar1";
            Seleccionar1.Resizable = DataGridViewTriState.True;
            Seleccionar1.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // dniAlumnos
            // 
            dniAlumnos.Location = new Point(588, 45);
            dniAlumnos.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            dniAlumnos.Name = "dniAlumnos";
            dniAlumnos.Size = new Size(120, 23);
            dniAlumnos.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 18);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 3;
            label1.Text = "Alumnos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 256);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "Notas";
            // 
            // notaEdit
            // 
            notaEdit.Location = new Point(472, 368);
            notaEdit.Name = "notaEdit";
            notaEdit.Size = new Size(75, 23);
            notaEdit.TabIndex = 5;
            notaEdit.Text = "Modificar";
            notaEdit.UseVisualStyleBackColor = true;
            notaEdit.Click += notaEdit_Click;
            // 
            // notaDelete
            // 
            notaDelete.Location = new Point(472, 415);
            notaDelete.Name = "notaDelete";
            notaDelete.Size = new Size(75, 23);
            notaDelete.TabIndex = 6;
            notaDelete.Text = "Borrar";
            notaDelete.UseVisualStyleBackColor = true;
            notaDelete.Click += notaDelete_Click;
            // 
            // alumnoEdit
            // 
            alumnoEdit.Location = new Point(472, 122);
            alumnoEdit.Name = "alumnoEdit";
            alumnoEdit.Size = new Size(75, 23);
            alumnoEdit.TabIndex = 7;
            alumnoEdit.Text = "Modificar";
            alumnoEdit.UseVisualStyleBackColor = true;
            alumnoEdit.Click += alumnoEdit_Click;
            // 
            // alumnoDelete
            // 
            alumnoDelete.Location = new Point(472, 177);
            alumnoDelete.Name = "alumnoDelete";
            alumnoDelete.Size = new Size(75, 23);
            alumnoDelete.TabIndex = 8;
            alumnoDelete.Text = "Borrar";
            alumnoDelete.UseVisualStyleBackColor = true;
            alumnoDelete.Click += alumnoDelete_Click;
            // 
            // nombreTxt
            // 
            nombreTxt.Location = new Point(588, 91);
            nombreTxt.Name = "nombreTxt";
            nombreTxt.Size = new Size(120, 23);
            nombreTxt.TabIndex = 9;
            // 
            // apellidoTxt
            // 
            apellidoTxt.Location = new Point(588, 144);
            apellidoTxt.Name = "apellidoTxt";
            apellidoTxt.Size = new Size(120, 23);
            apellidoTxt.TabIndex = 10;
            // 
            // dniNotas
            // 
            dniNotas.Location = new Point(588, 283);
            dniNotas.Name = "dniNotas";
            dniNotas.Size = new Size(120, 23);
            dniNotas.TabIndex = 11;
            // 
            // notaNum
            // 
            notaNum.Location = new Point(588, 332);
            notaNum.Name = "notaNum";
            notaNum.Size = new Size(120, 23);
            notaNum.TabIndex = 12;
            // 
            // dateNota
            // 
            dateNota.Format = DateTimePickerFormat.Short;
            dateNota.Location = new Point(588, 379);
            dateNota.Name = "dateNota";
            dateNota.Size = new Size(120, 23);
            dateNota.TabIndex = 13;
            dateNota.Value = new DateTime(2024, 10, 30, 0, 0, 0, 0);
            // 
            // submitAlumno
            // 
            submitAlumno.Location = new Point(588, 189);
            submitAlumno.Name = "submitAlumno";
            submitAlumno.Size = new Size(120, 23);
            submitAlumno.TabIndex = 14;
            submitAlumno.Text = "Agregar alumno";
            submitAlumno.UseVisualStyleBackColor = true;
            submitAlumno.Click += submitAlumno_Click;
            // 
            // submitNota
            // 
            submitNota.Location = new Point(588, 415);
            submitNota.Name = "submitNota";
            submitNota.Size = new Size(120, 23);
            submitNota.TabIndex = 15;
            submitNota.Text = "Agregar nota";
            submitNota.UseVisualStyleBackColor = true;
            submitNota.Click += submitNota_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(22, 489);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(444, 154);
            dataGridView3.TabIndex = 16;
            // 
            // promedioBtn
            // 
            promedioBtn.Location = new Point(543, 539);
            promedioBtn.Name = "promedioBtn";
            promedioBtn.Size = new Size(133, 57);
            promedioBtn.TabIndex = 17;
            promedioBtn.Text = "Promediar";
            promedioBtn.UseVisualStyleBackColor = true;
            promedioBtn.Click += promedioBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 689);
            Controls.Add(promedioBtn);
            Controls.Add(dataGridView3);
            Controls.Add(submitNota);
            Controls.Add(submitAlumno);
            Controls.Add(dateNota);
            Controls.Add(notaNum);
            Controls.Add(dniNotas);
            Controls.Add(apellidoTxt);
            Controls.Add(nombreTxt);
            Controls.Add(alumnoDelete);
            Controls.Add(alumnoEdit);
            Controls.Add(notaDelete);
            Controls.Add(notaEdit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dniAlumnos);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dniAlumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dniNotas).EndInit();
            ((System.ComponentModel.ISupportInitialize)notaNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private NumericUpDown dniAlumnos;
        private Label label1;
        private Label label2;
        private Button notaEdit;
        private Button notaDelete;
        private Button alumnoEdit;
        private Button alumnoDelete;
        private TextBox nombreTxt;
        private TextBox apellidoTxt;
        private NumericUpDown dniNotas;
        private NumericUpDown notaNum;
        private DateTimePicker dateNota;
        private Button submitAlumno;
        private Button submitNota;
        private DataGridViewCheckBoxColumn Seleccionar1;
        private DataGridView dataGridView3;
        private Button promedioBtn;
        private DataGridViewCheckBoxColumn Checked;
    }
}
