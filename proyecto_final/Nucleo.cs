using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.Json;
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
            Calcular.Enabled = !string.IsNullOrEmpty(calificacion1.Text) && !string.IsNullOrEmpty(nombre.Text) && !string.IsNullOrEmpty(matricula.Text) && !string.IsNullOrEmpty(apellido.Text)
             && !string.IsNullOrEmpty(calificacion_examen1.Text) && !string.IsNullOrEmpty(calificacion_examen2.Text) && !string.IsNullOrEmpty(calificaion_examen3.Text) && !string.IsNullOrEmpty(calificacion2.Text)
             && !string.IsNullOrEmpty(calificacion3.Text) && !string.IsNullOrEmpty(calificacion1.Text);

        }

        private void registrosPasadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guardarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string ruta = @"C:\Users\HP\Pictures\Camera Roll\registros.Json";

            if (Lista.Rows.Count == 0 ||
                (Lista.Rows.Count == 1 && Lista.Rows[0].IsNewRow))
            {
                MessageBox.Show("No hay datos en la tabla para guardar.");
                return;
            }

            try
            {
                List<Dictionary<string, string>> listaRegistros =
                    new List<Dictionary<string, string>>();

                if (File.Exists(ruta))
                {
                    string jsonAnterior = File.ReadAllText(ruta);

                    if (!string.IsNullOrWhiteSpace(jsonAnterior))
                    {
                        listaRegistros =
                            JsonSerializer.Deserialize<List<Dictionary<string, string>>>(jsonAnterior)
                            ?? new List<Dictionary<string, string>>();
                    }
                }
                var columnasVisibles = Lista.Columns
                    .Cast<DataGridViewColumn>()
                    .Where(c => c.Visible)
                    .ToList();
                foreach (DataGridViewRow fila in Lista.Rows)
                {
                    if (!fila.IsNewRow)
                    {
                        var datosFila = new Dictionary<string, string>();

                        foreach (var col in columnasVisibles)
                        {
                            object valor = fila.Cells[col.Index].Value;

                            datosFila[col.HeaderText] =
                                valor != null ? valor.ToString() : "";
                        }

                        listaRegistros.Add(datosFila);

                    }
                }
                var opciones = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                string jsonString =
                    JsonSerializer.Serialize(listaRegistros, opciones);

                string directorio = Path.GetDirectoryName(ruta);

                if (!Directory.Exists(directorio))
                    Directory.CreateDirectory(directorio);

                File.WriteAllText(ruta, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            Lista.DataSource = null;
            Lista.Rows.Clear();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Calcular.Enabled = !string.IsNullOrEmpty(calificacion1.Text) && !string.IsNullOrEmpty(nombre.Text) && !string.IsNullOrEmpty(matricula.Text) && !string.IsNullOrEmpty(apellido.Text)
            && !string.IsNullOrEmpty(calificacion_examen1.Text) && !string.IsNullOrEmpty(calificacion_examen2.Text) && !string.IsNullOrEmpty(calificaion_examen3.Text) && !string.IsNullOrEmpty(calificacion2.Text)
            && !string.IsNullOrEmpty(calificacion3.Text) && !string.IsNullOrEmpty(calificacion1.Text);
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
            Calcular.Enabled = !string.IsNullOrEmpty(calificacion1.Text) && !string.IsNullOrEmpty(nombre.Text) && !string.IsNullOrEmpty(matricula.Text) && !string.IsNullOrEmpty(apellido.Text)
            && !string.IsNullOrEmpty(calificacion_examen1.Text) && !string.IsNullOrEmpty(calificacion_examen2.Text) && !string.IsNullOrEmpty(calificaion_examen3.Text) && !string.IsNullOrEmpty(calificacion2.Text)
            && !string.IsNullOrEmpty(calificacion3.Text) && !string.IsNullOrEmpty(calificacion1.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Calcular.Enabled = !string.IsNullOrEmpty(calificacion1.Text) && !string.IsNullOrEmpty(nombre.Text) && !string.IsNullOrEmpty(matricula.Text) && !string.IsNullOrEmpty(apellido.Text)
            && !string.IsNullOrEmpty(calificacion_examen1.Text) && !string.IsNullOrEmpty(calificacion_examen2.Text) && !string.IsNullOrEmpty(calificaion_examen3.Text) && !string.IsNullOrEmpty(calificacion2.Text)
            && !string.IsNullOrEmpty(calificacion3.Text) && !string.IsNullOrEmpty(calificacion1.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            Calcular.Enabled = !string.IsNullOrEmpty(calificacion1.Text) && !string.IsNullOrEmpty(nombre.Text) && !string.IsNullOrEmpty(matricula.Text) && !string.IsNullOrEmpty(apellido.Text)
              && !string.IsNullOrEmpty(calificacion_examen1.Text) && !string.IsNullOrEmpty(calificacion_examen2.Text) && !string.IsNullOrEmpty(calificaion_examen3.Text) && !string.IsNullOrEmpty(calificacion2.Text)
              && !string.IsNullOrEmpty(calificacion3.Text) && !string.IsNullOrEmpty(calificacion1.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Calcular.Enabled = !string.IsNullOrEmpty(calificacion1.Text) && !string.IsNullOrEmpty(nombre.Text) && !string.IsNullOrEmpty(matricula.Text) && !string.IsNullOrEmpty(apellido.Text)
             && !string.IsNullOrEmpty(calificacion_examen1.Text) && !string.IsNullOrEmpty(calificacion_examen2.Text) && !string.IsNullOrEmpty(calificaion_examen3.Text) && !string.IsNullOrEmpty(calificacion2.Text)
             && !string.IsNullOrEmpty(calificacion3.Text) && !string.IsNullOrEmpty(calificacion1.Text);

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            Calcular.Enabled = !string.IsNullOrEmpty(calificacion1.Text) && !string.IsNullOrEmpty(nombre.Text) && !string.IsNullOrEmpty(matricula.Text) && !string.IsNullOrEmpty(apellido.Text)
            && !string.IsNullOrEmpty(calificacion_examen1.Text) && !string.IsNullOrEmpty(calificacion_examen2.Text) && !string.IsNullOrEmpty(calificaion_examen3.Text) && !string.IsNullOrEmpty(calificacion2.Text)
            && !string.IsNullOrEmpty(calificacion3.Text) && !string.IsNullOrEmpty(calificacion1.Text);
            float examen1, examen2, examen3;
            float practica1, practica2, practica3;
            double promedio, porcentaje_examen, porcentaje_practica;
            Calcular calcular = new Calcular();
            if (float.TryParse(this.calificacion1.Text, out examen1) &&
                float.TryParse(calificacion_examen1.Text, out examen2) &&
                float.TryParse(calificacion_examen2.Text, out examen3) &&
                float.TryParse(calificaion_examen3.Text, out practica1) &&
                float.TryParse(calificacion3.Text, out practica2) &&
                float.TryParse(calificacion2.Text, out practica3))
            {

                promedio = calcular.Promedio(examen1, examen2, examen3, practica1, practica2, practica3);
                porcentaje_examen = Math.Round(calcular.porcentaje_examen, 1);
                porcentaje_practica = Math.Round(calcular.porcentaje_practica, 1);
                string nombre = this.nombre.Text;
                string apellido = this.apellido.Text;
                string matricula = this.matricula.Text;

                Lista.Rows.Add(nombre, apellido, matricula, examen1, examen2, examen3, practica1, practica2, practica3, porcentaje_examen, porcentaje_practica, promedio, calcular.status);

            }
            else
            {
                MessageBox.Show("Debes ingresar las calificaciones completas.");
            }
            calificacion1.Clear();
            calificacion2.Clear();
            calificacion3.Clear();
            calificacion_examen1.Clear();
            calificacion_examen2.Clear();
            calificaion_examen3.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Calcular.Enabled = !string.IsNullOrEmpty(calificacion1.Text) && !string.IsNullOrEmpty(nombre.Text) && !string.IsNullOrEmpty(matricula.Text) && !string.IsNullOrEmpty(apellido.Text)
            && !string.IsNullOrEmpty(calificacion_examen1.Text) && !string.IsNullOrEmpty(calificacion_examen2.Text) && !string.IsNullOrEmpty(calificaion_examen3.Text) && !string.IsNullOrEmpty(calificacion2.Text)
            && !string.IsNullOrEmpty(calificacion3.Text) && !string.IsNullOrEmpty(calificacion1.Text);
            apellido.MaxLength = 30;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Calcular.Enabled = !string.IsNullOrEmpty(calificacion1.Text) && !string.IsNullOrEmpty(nombre.Text) && !string.IsNullOrEmpty(matricula.Text) && !string.IsNullOrEmpty(apellido.Text)
             && !string.IsNullOrEmpty(calificacion_examen1.Text) && !string.IsNullOrEmpty(calificacion_examen2.Text) && !string.IsNullOrEmpty(calificaion_examen3.Text) && !string.IsNullOrEmpty(calificacion2.Text)
             && !string.IsNullOrEmpty(calificacion3.Text) && !string.IsNullOrEmpty(calificacion1.Text);
            matricula.MaxLength = 9;
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            Calcular.Enabled = !string.IsNullOrEmpty(calificacion1.Text) && !string.IsNullOrEmpty(nombre.Text) && !string.IsNullOrEmpty(matricula.Text) && !string.IsNullOrEmpty(apellido.Text)
            && !string.IsNullOrEmpty(calificacion_examen1.Text) && !string.IsNullOrEmpty(calificacion_examen2.Text) && !string.IsNullOrEmpty(calificaion_examen3.Text) && !string.IsNullOrEmpty(calificacion2.Text)
            && !string.IsNullOrEmpty(calificacion3.Text) && !string.IsNullOrEmpty(calificacion1.Text);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            Calcular.Enabled = !string.IsNullOrEmpty(calificacion1.Text) && !string.IsNullOrEmpty(nombre.Text) && !string.IsNullOrEmpty(matricula.Text) && !string.IsNullOrEmpty(apellido.Text)
             && !string.IsNullOrEmpty(calificacion_examen1.Text) && !string.IsNullOrEmpty(calificacion_examen2.Text) && !string.IsNullOrEmpty(calificaion_examen3.Text) && !string.IsNullOrEmpty(calificacion2.Text)
             && !string.IsNullOrEmpty(calificacion3.Text) && !string.IsNullOrEmpty(calificacion1.Text);
            if (float.TryParse(calificacion3.Text, out float valor))
            {
                if (valor > 100)
                {
                    MessageBox.Show("El valor no puede ser mayor a 100.");
                    calificacion3.Text = "100";
                }

            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {

            if (float.TryParse(calificacion_examen1.Text, out float valor))
            {
                if (valor > 100)
                {
                    MessageBox.Show("El valor no puede ser mayor a 100.");
                    calificacion_examen1.Text = "100";
                }
                else if (valor < 50)
                {
                    MessageBox.Show("El valor no puede ser menor a 50.");
                    calificacion_examen1.Text = "50";
                }
            }

        }

        private void textBox6_Leave(object sender, EventArgs e)
        {

            if (float.TryParse(calificacion_examen2.Text, out float valor))
            {
                if (valor > 100)
                {
                    MessageBox.Show("El valor no puede ser mayor a 100.");
                    calificacion_examen2.Text = "100";
                }
                else if (valor < 50)
                {
                    MessageBox.Show("El valor no puede ser menor a 50.");
                    calificacion_examen2.Text = "50";
                }
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {

            if (float.TryParse(calificaion_examen3.Text, out float valor))
            {
                if (valor > 100)
                {
                    MessageBox.Show("El valor no puede ser mayor a 100.");
                    calificaion_examen3.Text = "100";
                }
                else if (valor < 50)
                {
                    MessageBox.Show("El valor no puede ser menor a 50.");
                    calificaion_examen3.Text = "50";
                }
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {

            if (float.TryParse(calificacion1.Text, out float valor))
            {
                if (valor > 100)
                {
                    MessageBox.Show("El valor no puede ser mayor a 100.");
                    calificacion1.Text = "100";
                }
                else if (valor < 50)
                {
                    MessageBox.Show("El valor no puede ser menor a 50.");
                    calificacion1.Text = "50";
                }
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {

            if (float.TryParse(calificacion2.Text, out float valor))
            {
                if (valor > 100)
                {
                    MessageBox.Show("El valor no puede ser mayor a 100.");
                    calificacion2.Text = "100";
                }
                else if (valor < 50)
                {
                    MessageBox.Show("El valor no puede ser menor a 50.");
                    calificacion2.Text = "50";
                }
            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(calificacion3.Text, out float valor))
            {
                if (valor > 100)
                {
                    MessageBox.Show("El valor no puede ser mayor a 100.");
                    calificacion3.Text = "100";
                }
                else if (valor < 50)
                {
                    MessageBox.Show("El valor no puede ser menor a 50.");
                    calificacion3.Text = "50";
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

        private void registrosPasadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Registro ventana3 = new Registro();
            ventana3.Show();
        }

        private void eliminarRegistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro ventana3 = new Registro();
            ventana3.Show();
        }
    }
    public class Calcular
    {
        public float calificacion1,calificacion2,calificacion3;
        public float practica1, practica2,practica3;
        public float porcentaje_practica;
        public float porcentaje_examen;
        public string status;
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
            if (promedio_entero >= 70) {
                this.status = "Promovido";

            }
            else
            {
                this.status = "Reprobado";
            }
            return promedio_entero;
        }


    }

}
