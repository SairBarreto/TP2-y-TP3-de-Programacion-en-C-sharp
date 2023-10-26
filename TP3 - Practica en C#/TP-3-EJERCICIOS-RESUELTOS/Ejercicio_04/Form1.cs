using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void suma_Click(object sender, EventArgs e)
        {
            float num = float.Parse(text1.Text);
            num += float.Parse(text2.Text);

            resultado.Text = num.ToString();
        }

        private void resta_Click(object sender, EventArgs e)
        {
            float num = float.Parse(text1.Text);
            num -= float.Parse(text2.Text);

            resultado.Text = num.ToString();
        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            float num = float.Parse(text1.Text);
            num *= float.Parse(text2.Text);

            resultado.Text = num.ToString();
        }

        private void division_Click(object sender, EventArgs e)
        {
            float num = float.Parse(text1.Text);
            num /= float.Parse(text2.Text);

            resultado.Text = num.ToString();
        }

        private void potencia_Click(object sender, EventArgs e)
        {
            float num = float.Parse(text1.Text);
            float potencia = float.Parse(text2.Text);

            resultado.Text = (Math.Pow(num, potencia)).ToString();
        }

        private void raiz_Click(object sender, EventArgs e)
        {
            float num = float.Parse(text1.Text);
            num += float.Parse(text2.Text);

            resultado.Text = (Math.Sqrt(num)).ToString();
        }
    }
}
