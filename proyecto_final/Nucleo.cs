using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace proyecto_final
{
    public partial class Nucleo : Form
    {
        public Nucleo()
        {
            InitializeComponent();
        }

        private void Nucleo_Load(object sender, EventArgs e)
        {
            Calcular.Enabled = false;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            Calcular.Enabled=!string .IsNullOrEmpty(Practica1.Text)&& !string.IsNullOrEmpty(nombre.Text)&& !string.IsNullOrEmpty(matricula.Text) && !string.IsNullOrEmpty(apellido.Text)
             && !string.IsNullOrEmpty(Examen1.Text) && !string.IsNullOrEmpty(Examen2.Text) && !string.IsNullOrEmpty(Examen3.Text) && !string.IsNullOrEmpty(calf2.Text)
             && !string.IsNullOrEmpty(calf3.Text) && !string.IsNullOrEmpty(Practica1.Text);

        }

        private void registrosPasadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guardarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Calcular.Enabled = !string.IsNullOrEmpty(Practica1.Text) && !string.IsNullOrEmpty(nombre.Text) && !string.IsNullOrEmpty(matricula.Text) && !string.IsNullOrEmpty(apellido.Text)
            && !string.IsNullOrEmpty(Examen1.Text) && !string.IsNullOrEmpty(Examen2.Text) && !string.IsNullOrEmpty(Examen3.Text) && !string.IsNullOrEmpty(calf2.Text)
            && !string.IsNullOrEmpty(calf3.Text) && !string.IsNullOrEmpty(Practica1.Text);
            nombre.MaxLength = 15;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            Calcular.Enabled = !string.IsNullOrEmpty(Practica1.Text) && !string.IsNullOrEmpty(nombre.Text) && !string.IsNullOrEmpty(matricula.Text) && !string.IsNullOrEmpty(apellido.Text)
            && !string.IsNullOrEmpty(Examen1.Text) && !string.IsNullOrEmpty(Examen2.Text) && !string.IsNullOrEmpty(Examen3.Text) && !string.IsNullOrEmpty(calf2.Text)
            && !string.IsNullOrEmpty(calf3.Text) && !string.IsNullOrEmpty(Practica1.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Calcular.Enabled = !string.IsNullOrEmpty(Practica1.Text) && !string.IsNullOrEmpty(nombre.Text) && !string.IsNullOrEmpty(matricula.Text) && !string.IsNullOrEmpty(apellido.Text)
            && !string.IsNullOrEmpty(Examen1.Text) && !string.IsNullOrEmpty(Examen2.Text) && !string.IsNullOrEmpty(Examen3.Text) && !string.IsNullOrEmpty(calf2.Text)
            && !string.IsNullOrEmpty(calf3.Text) && !string.IsNullOrEmpty(Practica1.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            Calcular.Enabled = !string.IsNullOrEmpty(Practica1.Text) && !string.IsNullOrEmpty(nombre.Text) && !string.IsNullOrEmpty(matricula.Text) && !string.IsNullOrEmpty(apellido.Text)
              && !string.IsNullOrEmpty(Examen1.Text) && !string.IsNullOrEmpty(Examen2.Text) && !string.IsNullOrEmpty(Examen3.Text) && !string.IsNullOrEmpty(calf2.Text)
              && !string.IsNullOrEmpty(calf3.Text) && !string.IsNullOrEmpty(Practica1.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Calcular.Enabled = !string.IsNullOrEmpty(Practica1.Text) && !string.IsNullOrEmpty(nombre.Text) && !string.IsNullOrEmpty(matricula.Text) && !string.IsNullOrEmpty(apellido.Text)
             && !string.IsNullOrEmpty(Examen1.Text) && !string.IsNullOrEmpty(Examen2.Text) && !string.IsNullOrEmpty(Examen3.Text) && !string.IsNullOrEmpty(calf2.Text)
             && !string.IsNullOrEmpty(calf3.Text) && !string.IsNullOrEmpty(Practica1.Text);

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            Calcular.Enabled = !string.IsNullOrEmpty(Practica1.Text) && !string.IsNullOrEmpty(nombre.Text) && !string.IsNullOrEmpty(matricula.Text) && !string.IsNullOrEmpty(apellido.Text)
            && !string.IsNullOrEmpty(Examen1.Text) && !string.IsNullOrEmpty(Examen2.Text) && !string.IsNullOrEmpty(Examen3.Text) && !string.IsNullOrEmpty(calf2.Text)
            && !string.IsNullOrEmpty(calf3.Text) && !string.IsNullOrEmpty(Practica1.Text);
            float examen1,examen2, examen3;
            float practica1,practica2,practica3;
            double promedio, porcentaje_examen, porcentaje_practica;
            Calcular calcular = new Calcular();
            if (float.TryParse(this.Practica1.Text, out examen1) &&
                float.TryParse(Examen1.Text, out examen2) &&
                float.TryParse(Examen2.Text, out examen3) &&
                float.TryParse(Examen3.Text, out practica1) &&
                float.TryParse(calf3.Text,out practica2)&&
                float.TryParse(calf2.Text,out practica3))
            {
              
                promedio= calcular.Promedio(examen1, examen2, examen3, practica1, practica2, practica3);
                porcentaje_examen = Math.Round(calcular.porcentaje_examen, 1);
                porcentaje_practica = Math.Round(calcular.porcentaje_practica, 1);
                porcentaje_practica = calcular.porcentaje_practica;
                string nombre = this.nombre.Text;
                string apellido = this.apellido.Text;
                string matricula = this.matricula.Text;

                dataGridView1.Rows.Add(nombre, apellido, matricula, examen1, examen2, examen3, practica1, practica2, practica3, porcentaje_examen, porcentaje_practica, promedio);

            }
            else
            {
                MessageBox.Show("Debes ingresar las calificaciones completas.");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Calcular.Enabled = !string.IsNullOrEmpty(Practica1.Text) && !string.IsNullOrEmpty(nombre.Text) && !string.IsNullOrEmpty(matricula.Text) && !string.IsNullOrEmpty(apellido.Text)
            && !string.IsNullOrEmpty(Examen1.Text) && !string.IsNullOrEmpty(Examen2.Text) && !string.IsNullOrEmpty(Examen3.Text) && !string.IsNullOrEmpty(calf2.Text)
            && !string.IsNullOrEmpty(calf3.Text) && !string.IsNullOrEmpty(Practica1.Text);
            apellido.MaxLength = 30;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Calcular.Enabled = !string.IsNullOrEmpty(Practica1.Text) && !string.IsNullOrEmpty(nombre.Text) && !string.IsNullOrEmpty(matricula.Text) && !string.IsNullOrEmpty(apellido.Text)
             && !string.IsNullOrEmpty(Examen1.Text) && !string.IsNullOrEmpty(Examen2.Text) && !string.IsNullOrEmpty(Examen3.Text) && !string.IsNullOrEmpty(calf2.Text)
             && !string.IsNullOrEmpty(calf3.Text) && !string.IsNullOrEmpty(Practica1.Text);
            matricula.MaxLength = 9;
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            Calcular.Enabled = !string.IsNullOrEmpty(Practica1.Text) && !string.IsNullOrEmpty(nombre.Text) && !string.IsNullOrEmpty(matricula.Text) && !string.IsNullOrEmpty(apellido.Text)
            && !string.IsNullOrEmpty(Examen1.Text) && !string.IsNullOrEmpty(Examen2.Text) && !string.IsNullOrEmpty(Examen3.Text) && !string.IsNullOrEmpty(calf2.Text)
            && !string.IsNullOrEmpty(calf3.Text) && !string.IsNullOrEmpty(Practica1.Text);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            Calcular.Enabled = !string.IsNullOrEmpty(Practica1.Text) && !string.IsNullOrEmpty(nombre.Text) && !string.IsNullOrEmpty(matricula.Text) && !string.IsNullOrEmpty(apellido.Text)
             && !string.IsNullOrEmpty(Examen1.Text) && !string.IsNullOrEmpty(Examen2.Text) && !string.IsNullOrEmpty(Examen3.Text) && !string.IsNullOrEmpty(calf2.Text)
             && !string.IsNullOrEmpty(calf3.Text) && !string.IsNullOrEmpty(Practica1.Text);
            if (float.TryParse(calf3.Text, out float valor))
            {
                if (valor > 100)
                {
                    MessageBox.Show("El valor no puede ser mayor a 100.");
                    calf3.Text = "100";
                }

            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
          
            if (float.TryParse(Examen1.Text, out float valor))
            {
                if (valor > 100)
                {
                    MessageBox.Show("El valor no puede ser mayor a 100.");
                    Examen1.Text = "100";
                }
                else if (valor < 50)
                {
                    MessageBox.Show("El valor no puede ser menor a 50.");
                    Examen1.Text = "50";
                }
            }

        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
           
            if (float.TryParse(Examen2.Text, out float valor))
            {
                if (valor > 100)
                {
                    MessageBox.Show("El valor no puede ser mayor a 100.");
                    Examen2.Text = "100";
                }
                else if (valor < 50)
                {
                    MessageBox.Show("El valor no puede ser menor a 50.");
                    Examen2.Text = "50";
                }
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
           
            if (float.TryParse(Examen3.Text, out float valor))
            {
                if (valor > 100)
                {
                    MessageBox.Show("El valor no puede ser mayor a 100.");
                    Examen3.Text = "100";
                }
                else if (valor < 50)
                {
                    MessageBox.Show("El valor no puede ser menor a 50.");
                    Examen3.Text = "50";
                }
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
           
            if (float.TryParse(Practica1.Text, out float valor))
            {
                if (valor > 100)
                {
                    MessageBox.Show("El valor no puede ser mayor a 100.");
                    Practica1.Text = "100";
                }
                else if (valor < 50)
                {
                    MessageBox.Show("El valor no puede ser menor a 50.");
                    Practica1.Text = "50";
                }
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
           
            if (float.TryParse(calf2.Text, out float valor))
            {
                if (valor > 100)
                {
                    MessageBox.Show("El valor no puede ser mayor a 100.");
                    calf2.Text = "100";
                }
                else if (valor < 50)
                {
                    MessageBox.Show("El valor no puede ser menor a 50.");
                    calf2.Text = "50";
                }
            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(calf3.Text, out float valor))
            {
                if (valor > 100)
                {
                    MessageBox.Show("El valor no puede ser mayor a 100.");
                    calf3.Text = "100";
                }
                else if (valor < 50)
                {
                    MessageBox.Show("El valor no puede ser menor a 50.");
                    calf3.Text = "50";
                }
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
    public class Calcular
    {
        public float calificacion1,calificacion2,calificacion3;
        public float practica1, practica2,practica3;
        public float porcentaje_practica;
        public float porcentaje_examen;
        public float Promedio(float valor1,float valor2,float valor3,float practica1, float practica2, float practica3)
        {this.calificacion1 = valor1;
         this.calificacion2 = valor2;
        this.calificacion3 = valor3;
         this.practica1 = practica1;
         this.practica2 = practica2;
         this.practica3 = practica3;
         porcentaje_practica = ((practica1+practica2+practica3)/3)*0.40f;
           porcentaje_examen = ((valor1 + valor2 + valor3)/3)*0.60f;
            float promedio = (porcentaje_examen)+(porcentaje_practica);
            int promedio_entero = (int)Math.Round(promedio);

            return promedio_entero;
        }
    }

}
