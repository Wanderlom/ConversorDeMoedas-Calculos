namespace aula03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String valorDigitado = textBox1.Text;

            int valor = Convert.ToInt32(valorDigitado);

            if (valor % 2 == 0)
            {
                comboBox1.Items.Add(valor);
            }
            else
            {
                listBox1.Items.Add(valor);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String valorDigitadoo = textBox2.Text;

            int valor = Convert.ToInt32(valorDigitadoo);

            if (radioButton1.Checked)
            {
                float real = 5.2f;

                float resultado = valor * real;

                label4.Text = resultado.ToString() + " REAIS";
            }

            if (radioButton2.Checked)
            {
                float real = 0.19f;

                float resultado = valor * real;

                label4.Text = resultado.ToString() + " DOLARES";
            }

            if (radioButton3.Checked)
            {
                float real = 1f;

                float resultado = valor * real;

                label4.Text = resultado.ToString() + " DOLARES";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String valorDigitado = textBox2.Text;

            if (valorDigitado != null && valorDigitado.Length > 0)
            {
                int valor = Convert.ToInt32(valorDigitado);
                int cont = 1;

                for (int i = 1; i < valor; i++)
                {
                    if (valor % i == 0)
                    {
                        cont++;
                    }
                }
                if (cont == 2)
                {
                    label4.Text = $"O número {valor} é primo";
                }
                else
                {
                    label4.Text = $"O número {valor} não é primo";
                }
            }
            else
            {
                MessageBox.Show("Você não pode deixar o campo vazio");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String valorDigitado = textBox2.Text;

            if (valorDigitado != null && valorDigitado.Length > 0)
            {
                int valor = Convert.ToInt32(valorDigitado);
                double resultado = 1;

                while (valor != 1)
                {
                    resultado = resultado * valor;
                    valor = valor - 1;
                }
                label4.Text = $"O fatorial de {valorDigitado} é: {resultado}";

            }
            else
            {
                MessageBox.Show("Você não pode deixar o campo vazio");
            }
        }
    }
}



