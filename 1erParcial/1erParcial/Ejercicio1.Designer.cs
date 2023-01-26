namespace _1erParcial
{
    partial class Ejercicio1
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
            this.Numero1label = new System.Windows.Forms.Label();
            this.Numero2label = new System.Windows.Forms.Label();
            this.Numero1textBox = new System.Windows.Forms.TextBox();
            this.Numero2textBox = new System.Windows.Forms.TextBox();
            this.SUMARBoton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Numero1label
            // 
            this.Numero1label.AutoSize = true;
            this.Numero1label.Location = new System.Drawing.Point(39, 39);
            this.Numero1label.Name = "Numero1label";
            this.Numero1label.Size = new System.Drawing.Size(86, 20);
            this.Numero1label.TabIndex = 0;
            this.Numero1label.Text = "Numero 1 :";
            this.Numero1label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Numero2label
            // 
            this.Numero2label.AutoSize = true;
            this.Numero2label.Location = new System.Drawing.Point(39, 97);
            this.Numero2label.Name = "Numero2label";
            this.Numero2label.Size = new System.Drawing.Size(86, 20);
            this.Numero2label.TabIndex = 1;
            this.Numero2label.Text = "Numero 2 :";
            // 
            // Numero1textBox
            // 
            this.Numero1textBox.Location = new System.Drawing.Point(131, 33);
            this.Numero1textBox.Name = "Numero1textBox";
            this.Numero1textBox.Size = new System.Drawing.Size(157, 26);
            this.Numero1textBox.TabIndex = 2;
            // 
            // Numero2textBox
            // 
            this.Numero2textBox.Location = new System.Drawing.Point(131, 94);
            this.Numero2textBox.Name = "Numero2textBox";
            this.Numero2textBox.Size = new System.Drawing.Size(157, 26);
            this.Numero2textBox.TabIndex = 3;
            // 
            // SUMARBoton
            // 
            this.SUMARBoton.Location = new System.Drawing.Point(131, 148);
            this.SUMARBoton.Name = "SUMARBoton";
            this.SUMARBoton.Size = new System.Drawing.Size(157, 31);
            this.SUMARBoton.TabIndex = 4;
            this.SUMARBoton.Text = "SUMAR";
            this.SUMARBoton.UseVisualStyleBackColor = true;
            this.SUMARBoton.Click += new System.EventHandler(this.SUMARBoton_Click);
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 532);
            this.Controls.Add(this.SUMARBoton);
            this.Controls.Add(this.Numero2textBox);
            this.Controls.Add(this.Numero1textBox);
            this.Controls.Add(this.Numero2label);
            this.Controls.Add(this.Numero1label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Ejercicio1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Numero1label;
        private System.Windows.Forms.Label Numero2label;
        private System.Windows.Forms.TextBox Numero1textBox;
        private System.Windows.Forms.TextBox Numero2textBox;
        private System.Windows.Forms.Button SUMARBoton;
    }
}

