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

        }

        private void Registro_pasado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { string ruta = File.ReadAllText(@"C:\Users\HP\source\repos\nucleo\registros.json");
           DataTable tabla=(DataTable)JsonConvert.DeserializeObject(ruta,typeof(DataTable));
            Registro_pasado.DataSource = tabla;
            Registro_pasado.Refresh();
        }
    }
}
