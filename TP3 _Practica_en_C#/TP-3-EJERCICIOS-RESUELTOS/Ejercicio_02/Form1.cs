using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonSumar_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(Text1.Text);
            float num2 = float.Parse(Text2.Text);

            resultadoLabel.Text = "El resultado es: " + (num1 + num2).ToString();
        }
    }
}
