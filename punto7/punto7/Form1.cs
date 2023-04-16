namespace punto7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(textBox1.Text);
            double aux = numero / 10;
            MessageBox.Show("La suma de sus dos digitos es " + (Math.Truncate(aux) + (numero % 10)));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}