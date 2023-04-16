namespace punto9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Convertir_Click(object sender, EventArgs e)
        {
            double hora1 = Convert.ToDouble(Horas1.Text);
            double minuto1 = Convert.ToDouble(Minutos1.Text);
            double segundo1 = Convert.ToDouble(Segundos1.Text);
            double hora2 = Convert.ToDouble(Horas2.Text);
            double minuto2 = Convert.ToDouble(Minutos2.Text);
            double segundo2 = Convert.ToDouble(Segundos2.Text);

            double TotalSegundos = segundo1 + segundo2;
            double TotalMinutos = minuto1 + minuto2 + (TotalSegundos/60);
            double TotalHoras = hora1 + hora2 + (TotalMinutos/60);

            MessageBox.Show("La suma de las horas es " + Math.Truncate(TotalHoras%60) + ", la suma de los minutos es " + Math.Truncate(TotalMinutos%60) + " y la suma de los segundos es " + Math.Truncate(TotalSegundos%60));
        }
    }
}