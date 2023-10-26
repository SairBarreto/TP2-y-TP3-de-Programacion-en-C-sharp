using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void iniciar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            float minimo = float.Parse(text1.Text);
            float maximo = float.Parse(text2.Text);

            if(minimo > maximo)
            {
                float aux = minimo;
                minimo = maximo;
                maximo = aux;
            }

            for(int i = (int)minimo; i <= (int)maximo; i++)
            {
                if (EsPrimo(i))
                {
                    listBox1.Items.Add(i.ToString());
                }
            }
        }

        static bool EsPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                    // No es primo
                    return false;
                }
            }

            // Es primo
            return true;
        }
    }
}
