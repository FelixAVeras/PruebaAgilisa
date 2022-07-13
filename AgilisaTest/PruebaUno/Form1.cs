using System;
using System.Windows.Forms;

namespace PruebaUno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Tabla multiplicar
        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int txtNumero = (int)tablamultiplicarInput.Value;

            for (int i = 1; i < txtNumero + 1; i++)
            {
                string resultado = string.Empty;

                for (int j = 1; j < 13; j++)
                {
                    resultado += i + " x " + j + " = " + (j * i) + "\n";
                }
                richTextBox1.Text = resultado;
            }
        }

        //Secuencia 0, 1, 1
        private void btnSecuencia_Click(object sender, EventArgs e)
        {
            int firstNumber = 0;
            int SecondNumber = 1;
            int nextNumber; 
            int numberOfElements = (int)secuenciaInput.Value;
            
            richTextBox2.Text = firstNumber + "\n" + SecondNumber + "\n";
            
            for (int i = 2; i < numberOfElements; i++)
            {
                nextNumber = firstNumber + SecondNumber;
                richTextBox2.Text += nextNumber + "\n";
                firstNumber = SecondNumber;
                SecondNumber = nextNumber;
            }
        }

        //Orden Aleatorio
        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            Random aleatorio = new Random();

            int txtAleatorio = (int)aleatorioInput.Value;
            string resultado = string.Empty;

            for (int x = 0; x < txtAleatorio; x++)
            {
                resultado += aleatorio.Next(txtAleatorio) + "\n";
            }

            richTextBox3.Text = resultado;
        }

        //Desglose de Billetes
        private void btnDesglose_Click(object sender, EventArgs e)
        {

        }
    }
}
