using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Globalization;

namespace calclucladorafinal
{
    public partial class Form1 : Form
    {
    //Campos *************************************************************
        private string punto = NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator.ToString();
        private double valor1, valor2, resultado;
        private string operador = "";

    //Eventos ************************************************************
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                if (b.Text != "," && b.Text != "+/-")
                    TxtDisplay.Text += b.Text;
                else if (b.Text == ",")
                {
                    if (TxtDisplay.Text.IndexOf(punto) < 0)
                        TxtDisplay.Text += punto;
                }
                else
                {
                    double v = Convert.ToDouble(TxtDisplay.Text);
                    v = -1 * v;
                    TxtDisplay.Text = v.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operador = b.Text;
            if (TxtDisplay.Text.Length > 0)
                valor1 = Convert.ToDouble(TxtDisplay.Text);
            TxtDisplay.Clear();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            switch (b.Text)
            {
                case "<<":
                    if (TxtDisplay.Text.Length>0)
                    {
                        TxtDisplay.Text=TxtDisplay.Text.Substring(0,TxtDisplay.Text.Length-1);
                        if (TxtDisplay.Text == "-")
                            TxtDisplay.Clear();
                    }
                    break;
                case "AC":
                    valor1=0;
                    valor2=0;
                    operador="";
                    TxtDisplay.Clear();
                    break;
            }
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text.Length > 0)
                valor2 = Convert.ToDouble(TxtDisplay.Text);
            switch (operador)
            {
                case "*":
                    resultado = valor1 * valor2;
                    break;
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "/":
                    resultado = valor1 / valor2;
                    break;
            }
            TxtDisplay.Text = resultado.ToString();
            operador = "";
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (TxtDisplay.Text.Length > 0)
                valor1 = Convert.ToDouble(TxtDisplay.Text);
            double v=valor1;
            switch (b.Text)
            {
                case "^2":
                    resultado = Math.Pow(v, 2);
                    break;
                case "^3":
                    resultado = Math.Pow(v, 3);
                    break;
                case "^(1/2)":
                    resultado = Math.Pow(v, 0.5);
                    break;
            }
            TxtDisplay.Text = resultado.ToString();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            int factorial = 1;
            if (TxtDisplay.Text.Length > 0)
                valor1 = Convert.ToDouble(TxtDisplay.Text);
            for (int i=1; i<= valor1; i=i+1)
            {
                factorial = factorial * i;
            }
            TxtDisplay.Text = factorial.ToString();
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (TxtDisplay.Text.Length > 0)
                valor1 = Convert.ToInt32(TxtDisplay.Text);
            string convertido = "";
            switch (b.Text)
            {
                case "Bin":
                    while ( valor1 >= 2) 
    		        {
                    resultado = Convert.ToInt32(valor1 % 2);
		            valor1 = Convert.ToInt32(valor1 / 2);
                    convertido = resultado.ToString() + convertido;
                    }
                    convertido = valor1.ToString() + convertido;
                    break;
                case "Oct":
                    while ( valor1 >= 8) 
    		        {
                    resultado = Convert.ToInt32(valor1 % 8);
		            valor1 = Convert.ToInt32(valor1 / 8);
                    convertido = resultado.ToString() + convertido;
                    }
                    convertido = valor1.ToString() + convertido;
                    break;
                case "Hex":
                    resultado = 0;
                    break;
            }
            TxtDisplay.Text = convertido;
        }
    }
}
