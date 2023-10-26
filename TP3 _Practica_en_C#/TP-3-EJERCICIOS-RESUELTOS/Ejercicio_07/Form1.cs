using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            decimal intereses = decimal.Parse(text1.Text);
            intereses *= decimal.Parse(text2.Text);
            intereses *= decimal.Parse(text3.Text);
            intereses /= 36500;

            string[] datos = new string[] { text1.Text, text2.Text, text3.Text, intereses.ToString("#.##") };
            dataGridView1.Rows.Add(datos);
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
