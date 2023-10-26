using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Agrega las opciones de escala a los ComboBox
            EscalaInicial.Items.AddRange(new string[] { "Celsius", "Fahrenheit", "Kelvin", "Rankine" });
            EscalaFinal.Items.AddRange(new string[] { "Celsius", "Fahrenheit", "Kelvin", "Rankine" });

            // Establece valores predeterminados
            EscalaInicial.SelectedIndex = 0;
            EscalaFinal.SelectedIndex = 1;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCantidad.Text, out double cantidad))
            {
                string escalaInicial = EscalaInicial.SelectedItem.ToString();
                string escalaFinal = EscalaFinal.SelectedItem.ToString();
                double resultado = ConvertirTemperatura(cantidad, escalaInicial, escalaFinal);
                txtResultado.Text = resultado.ToString("##.##");

                dataGridView.Rows.Add(new string[] { escalaInicial.First() + " pasa a " + escalaFinal.First(), cantidad.ToString(), resultado.ToString("##.##")});
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.");
            }
        }

        private double ConvertirTemperatura(double cantidad, string escalaInicial, string escalaFinal)
        {
            // Realiza las conversiones
            double resultado = 0.0;

            switch (escalaInicial)
            {
                case "Celsius":
                    switch (escalaFinal)
                    {
                        case "Fahrenheit":
                            resultado = (cantidad * 9 / 5) + 32;
                            break;
                        case "Kelvin":
                            resultado = cantidad + 273.15;
                            break;
                        case "Rankine":
                            resultado = (cantidad + 273.15) * 9 / 5;
                            break;
                        default:
                            resultado = cantidad;
                            break;
                    }
                    break;
                case "Fahrenheit":
                    switch (escalaFinal)
                    {
                        case "Celsius":
                            resultado = (cantidad - 32) * 5 / 9;
                            break;
                        case "Kelvin":
                            resultado = (cantidad + 459.67) * 5 / 9;
                            break;
                        case "Rankine":
                            resultado = cantidad + 459.67;
                            break;
                        default:
                            resultado = cantidad;
                            break;
                    }
                    break;
                case "Kelvin":
                    switch (escalaFinal)
                    {
                        case "Celsius":
                            resultado = cantidad - 273.15;
                            break;
                        case "Fahrenheit":
                            resultado = (cantidad * 9 / 5) - 459.67;
                            break;
                        case "Rankine":
                            resultado = cantidad * 9 / 5;
                            break;
                        default:
                            resultado = cantidad;
                            break;
                    }
                    break;
                case "Rankine":
                    switch (escalaFinal)
                    {
                        case "Celsius":
                            resultado = (cantidad - 491.67) * 5 / 9;
                            break;
                        case "Fahrenheit":
                            resultado = cantidad - 459.67;
                            break;
                        case "Kelvin":
                            resultado = cantidad * 5 / 9;
                            break;
                        default:
                            resultado = cantidad;
                            break;
                    }
                    break;
                default:
                    resultado = cantidad;
                    break;
            }

            return resultado;
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
