namespace proyecto_final
{
    partial class Registro
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
            lista = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            matricula = new DataGridViewTextBoxColumn();
            primer_examen = new DataGridViewTextBoxColumn();
            segundo_examen = new DataGridViewTextBoxColumn();
            examen_final = new DataGridViewTextBoxColumn();
            practica1 = new DataGridViewTextBoxColumn();
            practica2 = new DataGridViewTextBoxColumn();
            practica3 = new DataGridViewTextBoxColumn();
            porcentaje_de_examen = new DataGridViewTextBoxColumn();
            porcentaje_de_practica = new DataGridViewTextBoxColumn();
            promedio = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)lista).BeginInit();
            SuspendLayout();
            // 
            // lista
            // 
            lista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lista.Columns.AddRange(new DataGridViewColumn[] { Nombre, apellido, matricula, primer_examen, segundo_examen, examen_final, practica1, practica2, practica3, porcentaje_de_examen, porcentaje_de_practica, promedio, estado });
            lista.Location = new Point(12, 145);
            lista.Name = "lista";
            lista.RowHeadersWidth = 62;
            lista.Size = new Size(1616, 293);
            lista.TabIndex = 0;
            lista.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido";
            apellido.MinimumWidth = 8;
            apellido.Name = "apellido";
            apellido.Width = 150;
            // 
            // matricula
            // 
            matricula.HeaderText = "Matricula";
            matricula.MinimumWidth = 8;
            matricula.Name = "matricula";
            matricula.Width = 150;
            // 
            // primer_examen
            // 
            primer_examen.HeaderText = "Primer examen";
            primer_examen.MinimumWidth = 8;
            primer_examen.Name = "primer_examen";
            primer_examen.Width = 150;
            // 
            // segundo_examen
            // 
            segundo_examen.HeaderText = "Segundo examen";
            segundo_examen.MinimumWidth = 8;
            segundo_examen.Name = "segundo_examen";
            segundo_examen.Width = 150;
            // 
            // examen_final
            // 
            examen_final.HeaderText = "Examen final";
            examen_final.MinimumWidth = 8;
            examen_final.Name = "examen_final";
            examen_final.Width = 150;
            // 
            // practica1
            // 
            practica1.HeaderText = "Practica#1";
            practica1.MinimumWidth = 8;
            practica1.Name = "practica1";
            practica1.Width = 150;
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
            // porcentaje_de_examen
            // 
            porcentaje_de_examen.HeaderText = "Porcentaje de examen";
            porcentaje_de_examen.MinimumWidth = 8;
            porcentaje_de_examen.Name = "porcentaje_de_examen";
            porcentaje_de_examen.Width = 150;
            // 
            // porcentaje_de_practica
            // 
            porcentaje_de_practica.HeaderText = "Porcentaje de practica";
            porcentaje_de_practica.MinimumWidth = 8;
            porcentaje_de_practica.Name = "porcentaje_de_practica";
            porcentaje_de_practica.Width = 150;
            // 
            // promedio
            // 
            promedio.HeaderText = "Promedio";
            promedio.MinimumWidth = 8;
            promedio.Name = "promedio";
            promedio.Width = 150;
            // 
            // estado
            // 
            estado.HeaderText = "Estado";
            estado.MinimumWidth = 8;
            estado.Name = "estado";
            estado.Width = 150;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1630, 450);
            Controls.Add(lista);
            Name = "Registro";
            Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)lista).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView lista;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn matricula;
        private DataGridViewTextBoxColumn primer_examen;
        private DataGridViewTextBoxColumn segundo_examen;
        private DataGridViewTextBoxColumn examen_final;
        private DataGridViewTextBoxColumn practica1;
        private DataGridViewTextBoxColumn practica2;
        private DataGridViewTextBoxColumn practica3;
        private DataGridViewTextBoxColumn porcentaje_de_examen;
        private DataGridViewTextBoxColumn porcentaje_de_practica;
        private DataGridViewTextBoxColumn promedio;
        private DataGridViewTextBoxColumn estado;
    }
}