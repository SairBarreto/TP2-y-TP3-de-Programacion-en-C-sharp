using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_06
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
            int a = 0, b = 1;
            int maximo = int.Parse(text1.Text);

            for (int i = 1; i <= maximo; i++)
            {
                if(i % 2 == 1)
                {
                    listBox1.Items.Add(a.ToString());
                    a += b;
                }
                else
                {
                    listBox1.Items.Add(b.ToString());
                    b += a;
                }
            }
        }
    }
}
