using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;

namespace proyecto_final
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
         string archivo = File.ReadAllText(@"C:\Users\HP\Pictures\Camera Roll\registros.Json");
         DataTable tabla = JsonConvert.DeserializeObject<DataTable>(archivo);
         lista.DataSource=tabla;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
