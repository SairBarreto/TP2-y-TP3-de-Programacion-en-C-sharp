namespace Ejercicio_08
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
            this.tirar = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.dado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Enunciado
            // 
            this.Enunciado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Enunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enunciado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Enunciado.Location = new System.Drawing.Point(141, 12);
            this.Enunciado.Multiline = true;
            this.Enunciado.Name = "Enunciado";
            this.Enunciado.ReadOnly = true;
            this.Enunciado.Size = new System.Drawing.Size(452, 57);
            this.Enunciado.TabIndex = 8;
            this.Enunciado.Text = "Desarrollar un programa que simule la tirada de un dado.";
            this.Enunciado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tirar
            // 
            this.tirar.BackColor = System.Drawing.Color.Lime;
            this.tirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tirar.Location = new System.Drawing.Point(168, 111);
            this.tirar.Name = "tirar";
            this.tirar.Size = new System.Drawing.Size(179, 34);
            this.tirar.TabIndex = 23;
            this.tirar.Text = "TIRAR DADO";
            this.tirar.UseVisualStyleBackColor = false;
            this.tirar.Click += new System.EventHandler(this.tirar_Click);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.Lime;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(353, 111);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(179, 34);
            this.salir.TabIndex = 24;
            this.salir.Text = "SALIR";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // dado
            // 
            this.dado.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dado.Location = new System.Drawing.Point(278, 151);
            this.dado.Multiline = true;
            this.dado.Name = "dado";
            this.dado.Size = new System.Drawing.Size(135, 115);
            this.dado.TabIndex = 25;
            this.dado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dado);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.tirar);
            this.Controls.Add(this.Enunciado);
            this.Name = "Form1";
            this.Text = "EJERCIO 8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Enunciado;
        private System.Windows.Forms.Button tirar;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.TextBox dado;
    }
}

