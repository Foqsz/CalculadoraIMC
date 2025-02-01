using System.Globalization;

namespace CalculadoraIMC
{
    public partial class CalculadoraDeIMC : Form
    {
        public CalculadoraDeIMC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double peso = Convert.ToDouble(txtPeso.Text, CultureInfo.InvariantCulture);
            double altura = Convert.ToDouble(txtAltura.Text, CultureInfo.InvariantCulture);

            double IMC = peso / (altura * altura);

            if (IMC < 18.5)
            {
                txtResultado.Text = $"Seu IMC é {IMC.ToString("F2", CultureInfo.InvariantCulture)} e você está Abaixo do Peso.";
            }
            else if (IMC >= 18.5 && IMC <= 24.9)
            {
                txtResultado.Text = $"Seu IMC é {IMC.ToString("F2", CultureInfo.InvariantCulture)} e você está com o Peso Normal.";
            }
            else if (IMC >= 25.0 && IMC <= 29.9)
            {
                txtResultado.Text = $"Seu IMC é {IMC.ToString("F2", CultureInfo.InvariantCulture)} e você está com Sobrepeso.";
            }
            else
            {
                txtResultado.Text = $"Seu IMC é {IMC.ToString("F2", CultureInfo.InvariantCulture)} e você está com Obesidade.";
            }
            txtResultado.Visible = true;
        }
    }
}
