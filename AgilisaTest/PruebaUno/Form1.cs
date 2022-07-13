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
            int txtNumber = (int)tablamultiplicarInput.Value;

            for (int i = 1; i < txtNumber + 1; i++)
            {
                string result = string.Empty;

                for (int j = 1; j < 13; j++)
                {
                    result += i + " x " + j + " = " + (j * i) + "\n";
                }

                richTextBox1.Text = result;
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
            string result = string.Empty;

            for (int x = 0; x < txtAleatorio; x++)
            {
                result += aleatorio.Next(txtAleatorio) + "\n";
            }

            richTextBox3.Text = result;
        }

        //Desglose de Billetes
        private void btnDesglose_Click(object sender, EventArgs e)
        {
            int retiro = (int)DesgloseInput.Value;

            int b100 = 0;
            int b200 = 0;
            int b500 = 0;
            int b1000 = 0;
            int b2000 = 0;

            while (retiro > 0)
            {
                if (retiro % 2000 == 0)
                {
                    b2000++;
                    retiro -= 2000;
                }
                else if (retiro % 1000 == 0)
                {
                    b1000++;
                    retiro -= 1000;
                }
                else if (retiro % 500 == 0)
                {
                    b500++;
                    retiro -= 500;
                }
                else if (retiro % 200 == 0)
                {
                    b200++;
                    retiro -= 200;
                }
                else if (retiro % 100 == 0)
                {
                    b100++;
                    retiro -= 100;
                }
            }


            if (b2000 > 1)
            {
                richTextBox4.Text += b2000 + "billetes de 2000";

            }
            else
            {
                if (b1000 == 1)
                {
                    richTextBox4.Text = b1000 + "Billetes de 1000";
                }
            }

            if (b500 > 1)
            {
                richTextBox4.Text = b500 + "Billetes de 500";
            }
            else
            {
                if (b500 == 1)
                {
                    richTextBox4.Text = b500 + "billetes de 500";
                }

            }

            if (b200 > 1)
            {
                richTextBox4.Text = b200 + "Billetes de 200";
            }
            else
            {
                if (b200 == 1)
                {
                    richTextBox4.Text = b200 + "Billetes de 200";
                }
            }

            if (b100 > 1)
            {
                richTextBox4.Text = b100 + "Billetes de 100";
            }
            else
            {
                if (b100 == 1)
                {
                    richTextBox4.Text = b100 + "Billetes de 100";
                }
            }

        }
    }
}

