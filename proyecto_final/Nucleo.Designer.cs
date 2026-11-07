namespace proyecto_final
{
    partial class Nucleo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nucleo));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            nombre = new TextBox();
            apellido = new TextBox();
            matricula = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            calificacion1 = new TextBox();
            calificacion_examen1 = new TextBox();
            calificacion_examen2 = new TextBox();
            calificaion_examen3 = new TextBox();
            menuStrip1 = new MenuStrip();
            registrosPasadosToolStripMenuItem = new ToolStripMenuItem();
            eliminarRegistrosToolStripMenuItem = new ToolStripMenuItem();
            guardarRegistroToolStripMenuItem = new ToolStripMenuItem();
            registrosPasadosToolStripMenuItem1 = new ToolStripMenuItem();
            Calcular = new Button();
            dataGridView1 = new DataGridView();
            Nombre_estudiante = new DataGridViewTextBoxColumn();
            Apellido_estudiante = new DataGridViewTextBoxColumn();
            Matricula_estudiante = new DataGridViewTextBoxColumn();
            Primer_examen = new DataGridViewTextBoxColumn();
            Segundo_examen = new DataGridViewTextBoxColumn();
            tercer_examen = new DataGridViewTextBoxColumn();
            Practica = new DataGridViewTextBoxColumn();
            practica2 = new DataGridViewTextBoxColumn();
            practica3 = new DataGridViewTextBoxColumn();
            Porcentaje_examen = new DataGridViewTextBoxColumn();
            porcentaje_practica = new DataGridViewTextBoxColumn();
            promedio = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            calificacion3 = new TextBox();
            calificacion2 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(21, 167);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 0;
            label1.Text = "Ingrese nomdre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(21, 254);
            label2.Name = "label2";
            label2.Size = new Size(147, 25);
            label2.TabIndex = 1;
            label2.Text = "Ingrese matricula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(21, 209);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 2;
            label3.Text = "Ingrese apellido";
            // 
            // nombre
            // 
            nombre.Location = new Point(178, 171);
            nombre.Name = "nombre";
            nombre.Size = new Size(266, 31);
            nombre.TabIndex = 3;
            nombre.TextChanged += textBox1_TextChanged;
            nombre.KeyPress += textBox1_KeyPress;
            // 
            // apellido
            // 
            apellido.Location = new Point(178, 215);
            apellido.Name = "apellido";
            apellido.Size = new Size(266, 31);
            apellido.TabIndex = 4;
            apellido.TextChanged += textBox2_TextChanged;
            apellido.KeyPress += textBox2_KeyPress;
            // 
            // matricula
            // 
            matricula.Location = new Point(183, 261);
            matricula.Name = "matricula";
            matricula.Size = new Size(196, 31);
            matricula.TabIndex = 5;
            matricula.TextChanged += textBox3_TextChanged;
            matricula.KeyPress += textBox3_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 432);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(530, 633);
            label5.Name = "label5";
            label5.Size = new Size(106, 25);
            label5.TabIndex = 7;
            label5.Text = "Practicas #1";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(217, 633);
            label6.Name = "label6";
            label6.Size = new Size(150, 25);
            label6.TabIndex = 8;
            label6.Text = "Segundo examen";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(373, 633);
            label7.Name = "label7";
            label7.Size = new Size(111, 25);
            label7.TabIndex = 9;
            label7.Text = "Examen final";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(50, 633);
            label8.Name = "label8";
            label8.Size = new Size(129, 25);
            label8.TabIndex = 10;
            label8.Text = "Primer examen";
            // 
            // calificacion1
            // 
            calificacion1.Location = new Point(530, 672);
            calificacion1.Name = "calificacion1";
            calificacion1.Size = new Size(109, 31);
            calificacion1.TabIndex = 11;
            calificacion1.TextChanged += textBox4_TextChanged;
            calificacion1.KeyPress += textBox4_KeyPress;
            calificacion1.Leave += textBox4_Leave;
            // 
            // calificacion_examen1
            // 
            calificacion_examen1.Location = new Point(50, 672);
            calificacion_examen1.Name = "calificacion_examen1";
            calificacion_examen1.Size = new Size(109, 31);
            calificacion_examen1.TabIndex = 12;
            calificacion_examen1.TextChanged += textBox5_TextChanged;
            calificacion_examen1.KeyPress += textBox4_KeyPress;
            calificacion_examen1.Leave += textBox5_Leave;
            // 
            // calificacion_examen2
            // 
            calificacion_examen2.Location = new Point(217, 672);
            calificacion_examen2.Name = "calificacion_examen2";
            calificacion_examen2.Size = new Size(109, 31);
            calificacion_examen2.TabIndex = 13;
            calificacion_examen2.TextChanged += textBox6_TextChanged;
            calificacion_examen2.KeyPress += textBox4_KeyPress;
            calificacion_examen2.Leave += textBox6_Leave;
            // 
            // calificaion_examen3
            // 
            calificaion_examen3.Location = new Point(373, 672);
            calificaion_examen3.Name = "calificaion_examen3";
            calificaion_examen3.Size = new Size(109, 31);
            calificaion_examen3.TabIndex = 14;
            calificaion_examen3.TextChanged += textBox7_TextChanged;
            calificaion_examen3.KeyPress += textBox4_KeyPress;
            calificaion_examen3.Leave += textBox7_Leave;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { registrosPasadosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1821, 33);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // registrosPasadosToolStripMenuItem
            // 
            registrosPasadosToolStripMenuItem.BackColor = SystemColors.ScrollBar;
            registrosPasadosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { eliminarRegistrosToolStripMenuItem, guardarRegistroToolStripMenuItem, registrosPasadosToolStripMenuItem1 });
            registrosPasadosToolStripMenuItem.Image = (Image)resources.GetObject("registrosPasadosToolStripMenuItem.Image");
            registrosPasadosToolStripMenuItem.Name = "registrosPasadosToolStripMenuItem";
            registrosPasadosToolStripMenuItem.Size = new Size(218, 29);
            registrosPasadosToolStripMenuItem.Text = "Opciones de registro";
            registrosPasadosToolStripMenuItem.Click += registrosPasadosToolStripMenuItem_Click;
            // 
            // eliminarRegistrosToolStripMenuItem
            // 
            eliminarRegistrosToolStripMenuItem.Image = (Image)resources.GetObject("eliminarRegistrosToolStripMenuItem.Image");
            eliminarRegistrosToolStripMenuItem.Name = "eliminarRegistrosToolStripMenuItem";
            eliminarRegistrosToolStripMenuItem.Size = new Size(259, 34);
            eliminarRegistrosToolStripMenuItem.Text = "Eliminar registros";
            // 
            // guardarRegistroToolStripMenuItem
            // 
            guardarRegistroToolStripMenuItem.Image = (Image)resources.GetObject("guardarRegistroToolStripMenuItem.Image");
            guardarRegistroToolStripMenuItem.Name = "guardarRegistroToolStripMenuItem";
            guardarRegistroToolStripMenuItem.Size = new Size(259, 34);
            guardarRegistroToolStripMenuItem.Text = "Guardar registro";
            guardarRegistroToolStripMenuItem.Click += guardarRegistroToolStripMenuItem_Click;
            // 
            // registrosPasadosToolStripMenuItem1
            // 
            registrosPasadosToolStripMenuItem1.Image = (Image)resources.GetObject("registrosPasadosToolStripMenuItem1.Image");
            registrosPasadosToolStripMenuItem1.Name = "registrosPasadosToolStripMenuItem1";
            registrosPasadosToolStripMenuItem1.Size = new Size(259, 34);
            registrosPasadosToolStripMenuItem1.Text = "Registros pasados";
            // 
            // Calcular
            // 
            Calcular.BackColor = Color.LightCoral;
            Calcular.FlatStyle = FlatStyle.Popup;
            Calcular.Location = new Point(992, 669);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(112, 34);
            Calcular.TabIndex = 16;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = false;
            Calcular.Click += Calcular_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre_estudiante, Apellido_estudiante, Matricula_estudiante, Primer_examen, Segundo_examen, tercer_examen, Practica, practica2, practica3, Porcentaje_examen, porcentaje_practica, promedio, status });
            dataGridView1.Location = new Point(0, 728);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1838, 225);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nombre_estudiante
            // 
            Nombre_estudiante.HeaderText = "Nombre";
            Nombre_estudiante.MinimumWidth = 8;
            Nombre_estudiante.Name = "Nombre_estudiante";
            Nombre_estudiante.Width = 150;
            // 
            // Apellido_estudiante
            // 
            Apellido_estudiante.HeaderText = "Apellido";
            Apellido_estudiante.MinimumWidth = 8;
            Apellido_estudiante.Name = "Apellido_estudiante";
            Apellido_estudiante.Width = 150;
            // 
            // Matricula_estudiante
            // 
            Matricula_estudiante.HeaderText = "Matricula";
            Matricula_estudiante.MinimumWidth = 8;
            Matricula_estudiante.Name = "Matricula_estudiante";
            Matricula_estudiante.Width = 150;
            // 
            // Primer_examen
            // 
            Primer_examen.HeaderText = "Primer examen";
            Primer_examen.MinimumWidth = 8;
            Primer_examen.Name = "Primer_examen";
            Primer_examen.Width = 150;
            // 
            // Segundo_examen
            // 
            Segundo_examen.HeaderText = "segundo examen";
            Segundo_examen.MinimumWidth = 8;
            Segundo_examen.Name = "Segundo_examen";
            Segundo_examen.Width = 150;
            // 
            // tercer_examen
            // 
            tercer_examen.HeaderText = "Examen final";
            tercer_examen.MinimumWidth = 8;
            tercer_examen.Name = "tercer_examen";
            tercer_examen.Width = 150;
            // 
            // Practica
            // 
            Practica.HeaderText = "Practica";
            Practica.MinimumWidth = 8;
            Practica.Name = "Practica";
            Practica.Width = 150;
            // 
            // practica2
            // 
            practica2.HeaderText = "Practica#2";
            practica2.MinimumWidth = 8;
            practica2.Name = "practica2";
            practica2.Width = 150;
            // 
            // practica3
            // 
            practica3.HeaderText = "Practica#3";
            practica3.MinimumWidth = 8;
            practica3.Name = "practica3";
            practica3.Width = 150;
            // 
            // Porcentaje_examen
            // 
            Porcentaje_examen.HeaderText = "Porcentace de examen";
            Porcentaje_examen.MinimumWidth = 8;
            Porcentaje_examen.Name = "Porcentaje_examen";
            Porcentaje_examen.Width = 150;
            // 
            // porcentaje_practica
            // 
            porcentaje_practica.HeaderText = "Porcentaje de practica";
            porcentaje_practica.MinimumWidth = 8;
            porcentaje_practica.Name = "porcentaje_practica";
            porcentaje_practica.Width = 150;
            // 
            // promedio
            // 
            promedio.HeaderText = "Promedio";
            promedio.MinimumWidth = 8;
            promedio.Name = "promedio";
            promedio.Width = 150;
            // 
            // status
            // 
            status.HeaderText = "Estado";
            status.MinimumWidth = 8;
            status.Name = "status";
            status.Width = 150;
            // 
            // calificacion3
            // 
            calificacion3.Location = new Point(808, 672);
            calificacion3.Name = "calificacion3";
            calificacion3.Size = new Size(109, 31);
            calificacion3.TabIndex = 18;
            calificacion3.TextChanged += textBox8_TextChanged;
            calificacion3.KeyPress += textBox8_KeyPress;
            calificacion3.Leave += textBox8_Leave;
            // 
            // calificacion2
            // 
            calificacion2.Location = new Point(665, 672);
            calificacion2.Name = "calificacion2";
            calificacion2.Size = new Size(109, 31);
            calificacion2.TabIndex = 19;
            calificacion2.TextChanged += textBox9_TextChanged;
            calificacion2.KeyPress += textBox9_KeyPress;
            calificacion2.Leave += textBox9_Leave;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(811, 633);
            label9.Name = "label9";
            label9.Size = new Size(106, 25);
            label9.TabIndex = 20;
            label9.Text = "Practicas #3";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Location = new Point(668, 633);
            label10.Name = "label10";
            label10.Size = new Size(106, 25);
            label10.TabIndex = 21;
            label10.Text = "Practicas #2";
            // 
            // Nucleo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_5zyk985zyk985zyk;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1821, 1050);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(calificacion2);
            Controls.Add(calificacion3);
            Controls.Add(dataGridView1);
            Controls.Add(Calcular);
            Controls.Add(calificaion_examen3);
            Controls.Add(calificacion_examen2);
            Controls.Add(calificacion_examen1);
            Controls.Add(calificacion1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(matricula);
            Controls.Add(apellido);
            Controls.Add(nombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Nucleo";
            Text = "Nucleo";
            WindowState = FormWindowState.Maximized;
            Load += Nucleo_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox nombre;
        private TextBox apellido;
        private TextBox matricula;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox calificacion1;
        private TextBox calificacion_examen1;
        private TextBox calificacion_examen2;
        private TextBox calificaion_examen3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem registrosPasadosToolStripMenuItem;
        private ToolStripMenuItem eliminarRegistrosToolStripMenuItem;
        private ToolStripMenuItem guardarRegistroToolStripMenuItem;
        private ToolStripMenuItem registrosPasadosToolStripMenuItem1;
        private Button Calcular;
        private DataGridView dataGridView1;
        private TextBox calificacion3;
        private TextBox calificacion2;
        private Label label9;
        private Label label10;
        private DataGridViewTextBoxColumn Nombre_estudiante;
        private DataGridViewTextBoxColumn Apellido_estudiante;
        private DataGridViewTextBoxColumn Matricula_estudiante;
        private DataGridViewTextBoxColumn Primer_examen;
        private DataGridViewTextBoxColumn Segundo_examen;
        private DataGridViewTextBoxColumn tercer_examen;
        private DataGridViewTextBoxColumn Practica;
        private DataGridViewTextBoxColumn practica2;
        private DataGridViewTextBoxColumn practica3;
        private DataGridViewTextBoxColumn Porcentaje_examen;
        private DataGridViewTextBoxColumn porcentaje_practica;
        private DataGridViewTextBoxColumn promedio;
        private DataGridViewTextBoxColumn status;
    }
}