using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Agreamos una nueva referencia para poder utilizar visual basic y asi utilizar el inputbox
            float num1 = float.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el primer numero"));
            float num2 = float.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el segundo numero"));
            
            MessageBox.Show($"La suma de {num1} con {num2} da {num1 + num2}");
        }
    }
}
