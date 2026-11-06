namespace proyecto_final
{
    public partial class Ventana_login : Form
    {
       

        public Ventana_login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Terminar.Enabled = false;
            Apellido.MaxLength = 30;
            Nombre.MaxLength = 15;
            Matricula.MaxLength = 9;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Matricula.Clear();
            Nombre.Clear();
            Apellido.Clear();
            Nombre.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Terminar.Enabled = !string.IsNullOrWhiteSpace(Nombre.Text)
                            && !string.IsNullOrWhiteSpace(Apellido.Text)
                            && Matricula.Text.Length == 9;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Terminar.Enabled = !string.IsNullOrWhiteSpace(Nombre.Text)
                           && !string.IsNullOrWhiteSpace(Apellido.Text)
                           && Matricula.Text.Length == 9;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Terminar.Enabled = !string.IsNullOrWhiteSpace(Nombre.Text)
                            && !string.IsNullOrWhiteSpace(Apellido.Text)
                            && Matricula.Text.Length == 9;

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            
            Nucleo ventana2 = new Nucleo();
            ventana2.Show();
            this.Hide();
        }

        private void Matricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
       
    }
}
