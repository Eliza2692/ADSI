using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial
{
    public partial class Fibonacci : Form
    {
        public Fibonacci()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            long Ant = 0, Num, i, Act=1, suma=0;
            Num = Convert.ToInt64(TxtNumero.Text);
            for (i = 1; i <= Num; i = i + 1)
              {  suma = Act + Ant;
                 Ant = Act;
                 Act = suma;}
            suma = Convert.ToInt64(suma);
            TxtResultado.Text = suma.ToString();
        }
    }
}
