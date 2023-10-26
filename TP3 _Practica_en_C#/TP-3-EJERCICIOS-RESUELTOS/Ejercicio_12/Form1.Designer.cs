namespace Ejercicio_12
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Enunciado = new System.Windows.Forms.TextBox();
            this.btnSelectorDeColor = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Enunciado
            // 
            this.Enunciado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Enunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enunciado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Enunciado.Location = new System.Drawing.Point(70, 12);
            this.Enunciado.Multiline = true;
            this.Enunciado.Name = "Enunciado";
            this.Enunciado.ReadOnly = true;
            this.Enunciado.Size = new System.Drawing.Size(577, 78);
            this.Enunciado.TabIndex = 12;
            this.Enunciado.Text = "Desarrolle un programa utilizando el control ColorDialog y que el color seleccion" +
    "ado se le asigne al color de fondo del formulario.";
            this.Enunciado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSelectorDeColor
            // 
            this.btnSelectorDeColor.BackColor = System.Drawing.Color.Lime;
            this.btnSelectorDeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectorDeColor.Location = new System.Drawing.Point(200, 127);
            this.btnSelectorDeColor.Name = "btnSelectorDeColor";
            this.btnSelectorDeColor.Size = new System.Drawing.Size(300, 35);
            this.btnSelectorDeColor.TabIndex = 13;
            this.btnSelectorDeColor.Text = "Cambir Color del Formulario";
            this.btnSelectorDeColor.UseVisualStyleBackColor = false;
            this.btnSelectorDeColor.Click += new System.EventHandler(this.btnSelectorDeColor_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Lime;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(200, 213);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(300, 35);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnSelectorDeColor);
            this.Controls.Add(this.Enunciado);
            this.Name = "Form1";
            this.Text = "EJERCICIO 12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Enunciado;
        private System.Windows.Forms.Button btnSelectorDeColor;
        private System.Windows.Forms.Button btnSalir;
    }
}

