namespace punto10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre1 = Nombre.Text;
            double anioI = Convert.ToDouble(AnioIngreso.Text);
            double Tarifa = Convert.ToDouble(TarifaHoraria.Text);
            double horas = Convert.ToDouble(HorasTrabajadas.Text);
            double Dias = Convert.ToDouble(DiasTrabajados.Text);

            double sueldo = (Tarifa * horas * Dias);
            double porcentaje = (1.5 * (2023 - anioI));
            double sueldoneto = (sueldo - ((20 * sueldo) / 100)) + ((porcentaje * sueldo) / 100);
            MessageBox.Show("El sueldo Bruto de " + nombre1 + " es $" + sueldo + ". se le suma un % " + porcentaje + " mas por anios de antiguedad. Su sueldo neto con las retenciones del 20% mas el porcentaje por antiguedad es $" + sueldoneto);
        }
    }
}