namespace proyecto_final
{
    partial class Ventana_login
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
            Terminar = new Button();
            Eliminar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Nombre = new TextBox();
            Matricula = new TextBox();
            Apellido = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // Terminar
            // 
            Terminar.Location = new Point(665, 388);
            Terminar.Name = "Terminar";
            Terminar.Size = new Size(112, 34);
            Terminar.TabIndex = 0;
            Terminar.Text = "Terminar";
            Terminar.UseVisualStyleBackColor = true;
            Terminar.Click += button1_Click;
            // 
            // Eliminar
            // 
            Eliminar.Location = new Point(29, 395);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(112, 34);
            Eliminar.TabIndex = 1;
            Eliminar.Text = "Borrar";
            Eliminar.UseVisualStyleBackColor = true;
            Eliminar.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(49, 82);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Algerian", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(248, 19);
            label2.Name = "label2";
            label2.Size = new Size(279, 35);
            label2.TabIndex = 3;
            label2.Text = "Inicio de sesión";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(43, 165);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 4;
            label3.Text = "Matricula";
            // 
            // Nombre
            // 
            Nombre.Location = new Point(145, 81);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(317, 31);
            Nombre.TabIndex = 5;
            Nombre.TextChanged += textBox1_TextChanged;
            Nombre.KeyPress += Nombre_KeyPress;
            // 
            // Matricula
            // 
            Matricula.Location = new Point(145, 162);
            Matricula.Name = "Matricula";
            Matricula.Size = new Size(317, 31);
            Matricula.TabIndex = 6;
            Matricula.TextChanged += textBox2_TextChanged;
            Matricula.KeyPress += Matricula_KeyPress;
            // 
            // Apellido
            // 
            Apellido.Location = new Point(145, 118);
            Apellido.Name = "Apellido";
            Apellido.Size = new Size(317, 31);
            Apellido.TabIndex = 7;
            Apellido.TextChanged += textBox3_TextChanged;
            Apellido.KeyPress += Apellido_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(49, 124);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 8;
            label4.Text = "Apellido";
            // 
            // Ventana_login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(Apellido);
            Controls.Add(Matricula);
            Controls.Add(Nombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Eliminar);
            Controls.Add(Terminar);
            IsMdiContainer = true;
            Name = "Ventana_login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Terminar;
        private Button Eliminar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Nombre;
        private TextBox Matricula;
        private TextBox Apellido;
        private Label label4;
    }
}
