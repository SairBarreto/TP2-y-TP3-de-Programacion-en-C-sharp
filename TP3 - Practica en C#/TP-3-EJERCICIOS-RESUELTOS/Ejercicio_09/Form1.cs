using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_09
{
    public partial class Form1 : Form
    {
        int totalTiradas = 0;
        private Random random1 = new Random();
        private Random random2 = new Random();
        public Form1()
        {
            InitializeComponent();

            string[] dos = { "2", "0", "0" };
            string[] tres = { "3", "0", "0" };
            string[] cuatro = { "4", "0", "0" };
            string[] cinco = { "5", "0", "0" };
            string[] seis = { "6", "0", "0" };
            string[] siete = { "7", "0", "0" };
            string[] ocho = { "8", "0", "0" };
            string[] nueve = { "9", "0", "0" };
            string[] diez = { "10", "0", "0" };
            string[] once = { "11", "0", "0" };
            string[] doce = { "12", "0", "0" };

            dataGridView1.Rows.Add(dos);
            dataGridView1.Rows.Add(tres);
            dataGridView1.Rows.Add(cuatro);
            dataGridView1.Rows.Add(cinco);
            dataGridView1.Rows.Add(seis);
            dataGridView1.Rows.Add(siete);
            dataGridView1.Rows.Add(ocho);
            dataGridView1.Rows.Add(nueve);
            dataGridView1.Rows.Add(diez);
            dataGridView1.Rows.Add(once);
            dataGridView1.Rows.Add(doce);
        }

        private void tirar_Click(object sender, EventArgs e)
        {
            int numeroDado1 = random1.Next(1, 7);
            int numeroDado2 = random2.Next(1, 7);
            int sum = numeroDado1 + numeroDado2;

            string texto = dado.Text = "La suma de los dos dados es: " + sum.ToString();
            
            foreach (DataGridViewRow i in dataGridView1.Rows)
            {
                int valor = Convert.ToInt32(i.Cells[0].Value);

                if (valor == sum)
                {
                    totalTiradas++;

                    int vecesAparecidas = Convert.ToInt32(i.Cells[1].Value);
                    vecesAparecidas++;
                    i.Cells[1].Value = vecesAparecidas.ToString();

                    float porcentaje = ((float)vecesAparecidas * 100) / totalTiradas;
                    i.Cells[2].Value = porcentaje.ToString("##.##");
                }
            }

            //Modifico los demas ya que el total de tiradas cambio
            foreach (DataGridViewRow i in dataGridView1.Rows)
            {
                int vecesAparecidas = Convert.ToInt32(i.Cells[1].Value);

                float porcentaje = ((float)vecesAparecidas * 100) / totalTiradas;
                i.Cells[2].Value = porcentaje.ToString("##.##");
            }
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
