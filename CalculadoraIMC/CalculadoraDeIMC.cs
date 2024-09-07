using System.Globalization;

namespace CalculadoraIMC
{
    public partial class CalculadoraDeIMC : Form
    {
        public CalculadoraDeIMC()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double peso = Convert.ToDouble(txtPeso.Text, CultureInfo.InvariantCulture);
            double altura = Convert.ToDouble(txtAltura.Text, CultureInfo.InvariantCulture);

            double IMC = peso / (altura * altura);



            string result = string.Empty;

            if (IMC < 18.5)
            {
                txtResultado.Text = $"Seu IMC é {IMC.ToString("F2", CultureInfo.InvariantCulture)} e você está Abaixo do Peso.";
                txtResultado.Visible = true;
            }

            else if (IMC >= 18.5 && IMC <= 24.9)
            {
                txtResultado.Text = $"Seu IMC é {IMC.ToString("F2", CultureInfo.InvariantCulture)} e você está com o Peso Normal.";
                txtResultado.Visible = true;
            }

            else if (IMC >= 25.0 && IMC <= 29.9)
            {
                txtResultado.Text = $"Seu IMC é {IMC.ToString("F2", CultureInfo.InvariantCulture)} e você está com Sobrepeso.";
                txtResultado.Visible = true;
            }
            else
            {
                txtResultado.Text = $"Seu IMC é {IMC.ToString("F2", CultureInfo.InvariantCulture)} e você está com Obesidade.";
                txtResultado.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string HF = Convert.ToString(label1_Click);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
