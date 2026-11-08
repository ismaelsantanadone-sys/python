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
            Registro_pasado = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Registro_pasado).BeginInit();
            SuspendLayout();
            // 
            // Registro_pasado
            // 
            Registro_pasado.BackgroundColor = SystemColors.ActiveCaption;
            Registro_pasado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Registro_pasado.GridColor = SystemColors.Window;
            Registro_pasado.Location = new Point(36, 54);
            Registro_pasado.Name = "Registro_pasado";
            Registro_pasado.RowHeadersWidth = 62;
            Registro_pasado.Size = new Size(1550, 336);
            Registro_pasado.TabIndex = 0;
            Registro_pasado.CellContentClick += Registro_pasado_CellContentClick;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1630, 450);
            Controls.Add(Registro_pasado);
            Name = "Registro";
            Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)Registro_pasado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Registro_pasado;
    }
}