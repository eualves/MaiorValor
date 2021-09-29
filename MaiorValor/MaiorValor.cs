using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaiorValor
{
    public partial class MaiorValor : Form
    {
        public MaiorValor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

            decimal valor1 = 0;
            decimal valor2 = 0;
            decimal valor3 = 0;

            valor1 = Convert.ToDecimal(txtBox1.Text);
            valor2 = Convert.ToDecimal(txtBox2.Text);
            valor3 = Convert.ToDecimal(txtBox3.Text);

            if (valor1 > valor2 && valor1 > valor3)
            {
                lblResultado.Text = "Os Valor 1 é o maior!";
            }
            else if (valor2 > valor1 && valor2 > valor3)
            {
                lblResultado.Text = "Os Valor 2 é o maior!";
            }
            else if (valor3 > valor2 && valor3 > valor1)
            {
                lblResultado.Text = "Os Valor 3 é o maior!";
            }
            else if (valor1 == valor2 && valor1 == valor3)
            {
                lblResultado.Text = "Os Valores são iguais!";
            }
            else if (valor1 > valor2 && valor1 == valor3)
            {
                lblResultado.Text = "Os valores 1 e 3 são maiores!";
            }
            else if (valor1 > valor3 && valor1 == valor2)
            {
                lblResultado.Text = "Os valores 1 e 2 são maiores!";
            }
            else if (valor3 > valor1 && valor3 == valor2)
            {
                lblResultado.Text = "Os valores 2 e 3 são maiores!";
            }
        }

    }
}
