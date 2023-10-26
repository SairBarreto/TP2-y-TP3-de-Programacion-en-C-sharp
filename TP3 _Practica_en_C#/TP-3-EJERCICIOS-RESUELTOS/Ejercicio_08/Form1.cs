using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tirar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int numeroDado = random.Next(1, 7);

            string texto = "";
            for (int i = 1; i <= numeroDado; i++)
            {
                texto += "X ";
            }

            dado.Text = texto;
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
