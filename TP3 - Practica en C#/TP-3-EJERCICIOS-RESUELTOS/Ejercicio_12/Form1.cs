using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectorDeColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            // Configura las opciones del ColorDialog
            colorDialog.AllowFullOpen = true; // Permite al usuario definir un color personalizado.
            colorDialog.ShowHelp = true; // Muestra el botón "Ayuda".
            colorDialog.Color = this.BackColor; // Establece el color actual del formulario como color inicial.

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtiene el color seleccionado por el usuario.
                Color selectedColor = colorDialog.Color;

                // Asigna el color de fondo del formulario al color seleccionado.
                this.BackColor = selectedColor;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
