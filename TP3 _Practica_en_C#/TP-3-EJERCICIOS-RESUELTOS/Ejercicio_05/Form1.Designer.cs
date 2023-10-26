namespace Ejercicio_05
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
            this.label2 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.iniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Enunciado
            // 
            this.Enunciado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Enunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enunciado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Enunciado.Location = new System.Drawing.Point(101, 12);
            this.Enunciado.Multiline = true;
            this.Enunciado.Name = "Enunciado";
            this.Enunciado.ReadOnly = true;
            this.Enunciado.Size = new System.Drawing.Size(538, 86);
            this.Enunciado.TabIndex = 5;
            this.Enunciado.Text = "Desarrollar un programa que le permita al usuario indicar un número mínimo y un n" +
    "úmero máximo. Mostrar en un Listbox todos aquellos que son primos.";
            this.Enunciado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nº MAXIMO";
            // 
            // text2
            // 
            this.text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.Location = new System.Drawing.Point(257, 169);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(100, 31);
            this.text2.TabIndex = 12;
            this.text2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nº MINIMO";
            // 
            // text1
            // 
            this.text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.Location = new System.Drawing.Point(257, 113);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(100, 31);
            this.text1.TabIndex = 10;
            this.text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBox1
            // 
            this.listBox1.ColumnWidth = 35;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(125, 274);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(334, 164);
            this.listBox1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nº PRIMOS EN EL INTERVALO";
            // 
            // iniciar
            // 
            this.iniciar.BackColor = System.Drawing.Color.Lime;
            this.iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciar.Location = new System.Drawing.Point(389, 138);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(89, 34);
            this.iniciar.TabIndex = 16;
            this.iniciar.Text = "INICIAR";
            this.iniciar.UseVisualStyleBackColor = false;
            this.iniciar.Click += new System.EventHandler(this.iniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iniciar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.Enunciado);
            this.Name = "Form1";
            this.Text = "EJERCICIO 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Enunciado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button iniciar;
    }
}

