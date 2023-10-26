namespace Ejercicio_04
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Enunciado = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.suma = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.multiplicacion = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.potencia = new System.Windows.Forms.Button();
            this.raiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Enunciado
            // 
            this.Enunciado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Enunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enunciado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Enunciado.Location = new System.Drawing.Point(103, 12);
            this.Enunciado.Multiline = true;
            this.Enunciado.Name = "Enunciado";
            this.Enunciado.ReadOnly = true;
            this.Enunciado.Size = new System.Drawing.Size(538, 128);
            this.Enunciado.TabIndex = 4;
            this.Enunciado.Text = resources.GetString("Enunciado.Text");
            this.Enunciado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text1
            // 
            this.text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.Location = new System.Drawing.Point(247, 184);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(100, 31);
            this.text1.TabIndex = 5;
            this.text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "1er número";
            // 
            // text2
            // 
            this.text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.Location = new System.Drawing.Point(247, 240);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(100, 31);
            this.text2.TabIndex = 7;
            this.text2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resultado
            // 
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(247, 305);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(100, 31);
            this.resultado.TabIndex = 8;
            this.resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "2do número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Resultado";
            // 
            // suma
            // 
            this.suma.BackColor = System.Drawing.Color.Lime;
            this.suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suma.Location = new System.Drawing.Point(382, 210);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(79, 29);
            this.suma.TabIndex = 11;
            this.suma.Text = "SUMA";
            this.suma.UseVisualStyleBackColor = false;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // resta
            // 
            this.resta.BackColor = System.Drawing.Color.Lime;
            this.resta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resta.Location = new System.Drawing.Point(478, 210);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(79, 29);
            this.resta.TabIndex = 12;
            this.resta.Text = "RESTA";
            this.resta.UseVisualStyleBackColor = false;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // multiplicacion
            // 
            this.multiplicacion.BackColor = System.Drawing.Color.Lime;
            this.multiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicacion.Location = new System.Drawing.Point(382, 245);
            this.multiplicacion.Name = "multiplicacion";
            this.multiplicacion.Size = new System.Drawing.Size(175, 29);
            this.multiplicacion.TabIndex = 13;
            this.multiplicacion.Text = "MULTIPLICACIÓN";
            this.multiplicacion.UseVisualStyleBackColor = false;
            this.multiplicacion.Click += new System.EventHandler(this.multiplicacion_Click);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.Color.Lime;
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.Location = new System.Drawing.Point(563, 245);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(109, 31);
            this.division.TabIndex = 14;
            this.division.Text = "DIVISIÓN";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // potencia
            // 
            this.potencia.BackColor = System.Drawing.Color.Lime;
            this.potencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potencia.Location = new System.Drawing.Point(382, 280);
            this.potencia.Name = "potencia";
            this.potencia.Size = new System.Drawing.Size(109, 31);
            this.potencia.TabIndex = 15;
            this.potencia.Text = "POTENCIA";
            this.potencia.UseVisualStyleBackColor = false;
            this.potencia.Click += new System.EventHandler(this.potencia_Click);
            // 
            // raiz
            // 
            this.raiz.BackColor = System.Drawing.Color.Lime;
            this.raiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raiz.Location = new System.Drawing.Point(505, 280);
            this.raiz.Name = "raiz";
            this.raiz.Size = new System.Drawing.Size(167, 31);
            this.raiz.TabIndex = 16;
            this.raiz.Text = "RAÍZ CUADRADA";
            this.raiz.UseVisualStyleBackColor = false;
            this.raiz.Click += new System.EventHandler(this.raiz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.raiz);
            this.Controls.Add(this.potencia);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplicacion);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.Enunciado);
            this.Name = "Form1";
            this.Text = "EJERCICIO 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Enunciado;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button multiplicacion;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button potencia;
        private System.Windows.Forms.Button raiz;
    }
}

