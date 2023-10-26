using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Creo el un vector dinamico, basicamente una lista
        List<float> numeros = new List<float>();
        private void button1_Click(object sender, EventArgs e)
        {
            float num = float.Parse(textAgregar.Text);
            numeros.Add(num);

            string texto = " ";
            foreach (float i in numeros)
            {
                texto += i.ToString() + "; ";
            }

            textMostrar.Text = texto;
            label2.Text = "El resultado de la suma de los ingresados es: " + (numeros.Sum()).ToString();
        }
    }
}
