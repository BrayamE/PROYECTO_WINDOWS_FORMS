namespace CalculadoraBasica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            btnResultado.Text += "+";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            btnResultado.Text += "-";
        }
        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            btnResultado.Text += "*";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            btnResultado.Text += "/";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            String dato = btnResultado.Text;
            int resultado = 0;
            string[] valores = dato.Split('+');
            foreach (string valor in valores)
            {
                if (valor.Contains("-"))
                {
                    string[] numeros = valor.Split('-');
                    int resta = int.Parse(numeros[0]);
                    for (int i = 1; i < numeros.Length; i++)
                    {
                        resta -= int.Parse(numeros[i]);
                    }
                    resultado += resta;
                }
                else if (valor.Contains("*"))
                {
                    string[] numeros = valor.Split('*');
                    int multiplicacion = int.Parse(numeros[0]);
                    for (int i = 1; i < numeros.Length; i++)
                    {
                        multiplicacion *= int.Parse(numeros[i]);
                    }
                    resultado += multiplicacion;
                }
                else if (valor.Contains("/"))
                {
                    string[] numeros = valor.Split('/');
                    double division = double.Parse(numeros[0]);
                    for (int i = 1; i < numeros.Length; i++)
                    {
                        division /= double.Parse(numeros[i]);
                    }
                    resultado += (int)division;
                }
                else
                {
                    int numero = int.Parse(valor);
                    resultado += numero;
                }
            }

            btnResultado.Text = resultado.ToString();

        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            btnResultado.Text = "";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            btnResultado.Text = btnResultado.Text + "9";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            btnResultado.Text = btnResultado.Text + "8";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            //btnResultado.Text += "7";
            btnResultado.Text = btnResultado.Text + "7";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btnResultado.Text = btnResultado.Text + "6";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btnResultado.Text = btnResultado.Text + "5";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            btnResultado.Text = btnResultado.Text + "4";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btnResultado.Text = btnResultado.Text + "3";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btnResultado.Text = btnResultado.Text + "2";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btnResultado.Text = btnResultado.Text + "1";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            btnResultado.Text = btnResultado.Text + "0";
        }

    }
}