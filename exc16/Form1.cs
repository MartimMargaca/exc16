namespace exc16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Utilizador.nome = textBox1.Text;
            Utilizador.Email = textBox2.Text;
            Utilizador.Password = textBox3.Text;

            Utilizador.nome = "Utilizador :" + textBox1.Text;
            label1.Text = Utilizador.nome;

            MessageBox.Show("Guardado com sucesso");

        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.UseSystemPasswordChar = false;
            }

            else
            {
                textBox3.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


