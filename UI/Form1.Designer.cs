namespace UI
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
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            label4 = new Label();
            cmbCurso = new ComboBox();
            label5 = new Label();
            txtPromedio = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtIdEstudiante = new TextBox();
            label8 = new Label();
            txtNuevoNombre = new TextBox();
            label9 = new Label();
            txtNuevoPromedio = new TextBox();
            label10 = new Label();
            cmbNuevoCurso = new ComboBox();
            btnModificarEstudiante = new Button();
            btnCargarEstudiante = new Button();
            btnAgregarLista = new Button();
            btnConfirmarLista = new Button();
            label11 = new Label();
            label12 = new Label();
            txtEliminarEstudiante = new TextBox();
            btnEliminarEstudiante = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(23, 270);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(228, 23);
            txtNombre.TabIndex = 0;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 210);
            label1.Name = "label1";
            label1.Size = new Size(179, 22);
            label1.TabIndex = 1;
            label1.Text = "Registrar Estudiante:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 252);
            label2.Name = "label2";
            label2.Size = new Size(208, 17);
            label2.TabIndex = 2;
            label2.Text = "Nombre y Apellido del  Alumno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 307);
            label3.Name = "label3";
            label3.Size = new Size(140, 17);
            label3.TabIndex = 3;
            label3.Text = "Fecha de Nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(23, 325);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(228, 23);
            dtpFechaNacimiento.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 366);
            label4.Name = "label4";
            label4.Size = new Size(46, 17);
            label4.TabIndex = 5;
            label4.Text = "Curso:";
            // 
            // cmbCurso
            // 
            cmbCurso.FormattingEnabled = true;
            cmbCurso.Location = new Point(24, 384);
            cmbCurso.Name = "cmbCurso";
            cmbCurso.Size = new Size(279, 23);
            cmbCurso.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.Location = new Point(270, 307);
            label5.Name = "label5";
            label5.Size = new Size(71, 17);
            label5.TabIndex = 7;
            label5.Text = "Promedio:";
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(272, 325);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(144, 23);
            txtPromedio.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.Location = new Point(484, 210);
            label6.Name = "label6";
            label6.Size = new Size(183, 22);
            label6.TabIndex = 9;
            label6.Text = "Modificar Estudiante:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.Location = new Point(484, 250);
            label7.Name = "label7";
            label7.Size = new Size(27, 19);
            label7.TabIndex = 10;
            label7.Text = "ID:";
            // 
            // txtIdEstudiante
            // 
            txtIdEstudiante.Location = new Point(484, 270);
            txtIdEstudiante.Name = "txtIdEstudiante";
            txtIdEstudiante.Size = new Size(239, 23);
            txtIdEstudiante.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label8.Location = new Point(484, 305);
            label8.Name = "label8";
            label8.Size = new Size(222, 19);
            label8.TabIndex = 12;
            label8.Text = "Nombre y Apellido del Alumno:";
            // 
            // txtNuevoNombre
            // 
            txtNuevoNombre.Location = new Point(484, 326);
            txtNuevoNombre.Name = "txtNuevoNombre";
            txtNuevoNombre.Size = new Size(239, 23);
            txtNuevoNombre.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label9.Location = new Point(482, 360);
            label9.Name = "label9";
            label9.Size = new Size(80, 19);
            label9.TabIndex = 14;
            label9.Text = "Promedio:";
            // 
            // txtNuevoPromedio
            // 
            txtNuevoPromedio.Location = new Point(484, 382);
            txtNuevoPromedio.Name = "txtNuevoPromedio";
            txtNuevoPromedio.Size = new Size(117, 23);
            txtNuevoPromedio.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label10.Location = new Point(482, 412);
            label10.Name = "label10";
            label10.Size = new Size(46, 17);
            label10.TabIndex = 16;
            label10.Text = "Curso:";
            // 
            // cmbNuevoCurso
            // 
            cmbNuevoCurso.FormattingEnabled = true;
            cmbNuevoCurso.Location = new Point(484, 430);
            cmbNuevoCurso.Name = "cmbNuevoCurso";
            cmbNuevoCurso.Size = new Size(288, 23);
            cmbNuevoCurso.TabIndex = 17;
            // 
            // btnModificarEstudiante
            // 
            btnModificarEstudiante.BackColor = Color.Yellow;
            btnModificarEstudiante.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnModificarEstudiante.Location = new Point(645, 360);
            btnModificarEstudiante.Name = "btnModificarEstudiante";
            btnModificarEstudiante.Size = new Size(127, 60);
            btnModificarEstudiante.TabIndex = 18;
            btnModificarEstudiante.Text = "Actualizar Estudiante";
            btnModificarEstudiante.UseVisualStyleBackColor = false;
            btnModificarEstudiante.Click += btnModificarEstudiante_Click_1;
            // 
            // btnCargarEstudiante
            // 
            btnCargarEstudiante.BackColor = Color.Cyan;
            btnCargarEstudiante.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCargarEstudiante.Location = new Point(24, 423);
            btnCargarEstudiante.Name = "btnCargarEstudiante";
            btnCargarEstudiante.Size = new Size(114, 64);
            btnCargarEstudiante.TabIndex = 19;
            btnCargarEstudiante.Text = "Cargar  Estudiante";
            btnCargarEstudiante.UseVisualStyleBackColor = false;
            btnCargarEstudiante.Click += btnCargarEstudiante_Click_1;
            // 
            // btnAgregarLista
            // 
            btnAgregarLista.BackColor = Color.FromArgb(255, 128, 0);
            btnAgregarLista.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAgregarLista.Location = new Point(156, 423);
            btnAgregarLista.Name = "btnAgregarLista";
            btnAgregarLista.Size = new Size(118, 64);
            btnAgregarLista.TabIndex = 20;
            btnAgregarLista.Text = "Cargar en la lista";
            btnAgregarLista.UseVisualStyleBackColor = false;
            btnAgregarLista.Click += btnAgregarLista_Click_1;
            // 
            // btnConfirmarLista
            // 
            btnConfirmarLista.BackColor = Color.FromArgb(128, 128, 255);
            btnConfirmarLista.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnConfirmarLista.Location = new Point(293, 423);
            btnConfirmarLista.Name = "btnConfirmarLista";
            btnConfirmarLista.Size = new Size(122, 64);
            btnConfirmarLista.TabIndex = 21;
            btnConfirmarLista.Text = "Confirmar Lista";
            btnConfirmarLista.UseVisualStyleBackColor = false;
            btnConfirmarLista.Click += btnConfirmarLista_Click_1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label11.Location = new Point(668, 12);
            label11.Name = "label11";
            label11.Size = new Size(164, 22);
            label11.TabIndex = 22;
            label11.Text = "Baja de Estudiante:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.Location = new Point(668, 50);
            label12.Name = "label12";
            label12.Size = new Size(30, 17);
            label12.TabIndex = 23;
            label12.Text = "ID :";
            // 
            // txtEliminarEstudiante
            // 
            txtEliminarEstudiante.Location = new Point(704, 50);
            txtEliminarEstudiante.Name = "txtEliminarEstudiante";
            txtEliminarEstudiante.Size = new Size(103, 23);
            txtEliminarEstudiante.TabIndex = 24;
            // 
            // btnEliminarEstudiante
            // 
            btnEliminarEstudiante.BackColor = Color.Red;
            btnEliminarEstudiante.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEliminarEstudiante.Location = new Point(668, 89);
            btnEliminarEstudiante.Name = "btnEliminarEstudiante";
            btnEliminarEstudiante.Size = new Size(164, 62);
            btnEliminarEstudiante.TabIndex = 25;
            btnEliminarEstudiante.Text = "Borrar Estudiante";
            btnEliminarEstudiante.UseVisualStyleBackColor = false;
            btnEliminarEstudiante.Click += btnEliminarEstudiante_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(629, 154);
            dataGridView1.TabIndex = 26;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(844, 496);
            Controls.Add(dataGridView1);
            Controls.Add(btnEliminarEstudiante);
            Controls.Add(txtEliminarEstudiante);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(btnConfirmarLista);
            Controls.Add(btnAgregarLista);
            Controls.Add(btnCargarEstudiante);
            Controls.Add(btnModificarEstudiante);
            Controls.Add(cmbNuevoCurso);
            Controls.Add(label10);
            Controls.Add(txtNuevoPromedio);
            Controls.Add(label9);
            Controls.Add(txtNuevoNombre);
            Controls.Add(label8);
            Controls.Add(txtIdEstudiante);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtPromedio);
            Controls.Add(label5);
            Controls.Add(cmbCurso);
            Controls.Add(label4);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpFechaNacimiento;
        private Label label4;
        private ComboBox cmbCurso;
        private Label label5;
        private TextBox txtPromedio;
        private Label label6;
        private Label label7;
        private TextBox txtIdEstudiante;
        private Label label8;
        private TextBox txtNuevoNombre;
        private Label label9;
        private TextBox txtNuevoPromedio;
        private Label label10;
        private ComboBox cmbNuevoCurso;
        private Button btnModificarEstudiante;
        private Button btnCargarEstudiante;
        private Button btnAgregarLista;
        private Button btnConfirmarLista;
        private Label label11;
        private Label label12;
        private TextBox txtEliminarEstudiante;
        private Button btnEliminarEstudiante;
        private DataGridView dataGridView1;
    }
}
