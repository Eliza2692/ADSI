using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace convertidor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int numini, resultado;
        
//////////////////////////////////// FUNCIONES/////////////////////////////
    
    //Hallar exponencial
        public int funcionexponencial(int num)
        {
            int exp=0;
            if (num<10)
                exp=1;
            else
                {
                int i=1;
                while ((num/(10* Convert.ToInt32(Math.Pow(10, i - 1))))>9)
                    {
                    exp = i;
		            i = i+1;
                    };
                exp = exp + 1;
                }
            return exp;
          }

    //Invertir numero        
        public void funcionInvertir(int Numero2,int exp)
        {
            int i, cociente = 0;
            resultado = 0;
            for ( i=1; i<=exp; i=i+1)
                {
                cociente = Convert.ToInt32(Numero2/Math.Pow(10,exp-i));
		        Numero2 = Numero2-(cociente* Convert.ToInt32(Math.Pow(10,exp-i)));
                resultado = resultado + (cociente * Convert.ToInt32(Math.Pow(10,i-1)));
                };
        }

    //Convertir Decimal a Bin        
        public void DecaBin(int numero)
        {
            int exp = 1, Numero2 = 0;
            while ( numero >= 2) 
		        {
                Numero2 = (Numero2*10)+ (numero % 2);
		        numero = numero/2;
		        exp = exp+1;
                }
            Numero2 = (Numero2 * 10) + numero;
            funcionInvertir(Numero2,exp);
        }

    //Convertir Decimal a Octal        
        public void DecaOct(int numero)
        {
            int exp = 1, Numero2 = 0;
            while (numero >= 8)
            {
                Numero2 = (Numero2 * 10) + (numero % 8);
                numero = numero / 8;
                exp = exp + 1;
            }
            Numero2 = (Numero2 * 10) + numero;
            funcionInvertir(Numero2, exp);
        }

        //Convertir Binario a Decimal        
        public void BinaDec(int numero)
        {
            int exp, resultado=0, suma;
            exp= funcionexponencial(numero);
            resultado=0;
            for (int i=1; i<= exp; i=i+1) 
               {
                suma=((numero/Convert.ToInt32(Math.Pow(10, exp - i)))*(Convert.ToInt32(Math.Pow(2, exp - i)))); 
                resultado=resultado+suma;
                numero = numero % Convert.ToInt32(Math.Pow(10, exp - i));
                }
        }

///////////////////////////////////////////////////////////////////////

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            string De, A;

            De = comboBoxDE.Text;
            A = comboBoxA.Text;

            if (De == A)
                TxtA.Text = TxtDE.Text;
            else
               {
                numini = Convert.ToInt32(TxtDE.Text);
                    if ((De == "Decimal") & (A == "Octal"))
                        DecaOct(numini);
                    else
                        {if ((De == "Decimal") & (A == "Binario"))
                            DecaBin(numini);
                        else
                            {
                            if ((De == "Binario") & (A == "Decimal"))
                                BinaDec(numini);
                            }
                        }
                TxtA.Text = Convert.ToString(resultado);
               }
        }
    }
}
