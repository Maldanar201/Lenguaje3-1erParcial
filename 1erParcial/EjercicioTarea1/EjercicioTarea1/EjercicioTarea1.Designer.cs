namespace EjercicioTarea1
{
    partial class EjercicioTarea1
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
            this.label1 = new System.Windows.Forms.Label();
            this.NumeroTextBox = new System.Windows.Forms.TextBox();
            this.Ejecutarbutton = new System.Windows.Forms.Button();
            this.ParImpartextBox = new System.Windows.Forms.TextBox();
            this.PositivoNegativotextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese  un Numero :";
            // 
            // NumeroTextBox
            // 
            this.NumeroTextBox.Location = new System.Drawing.Point(206, 39);
            this.NumeroTextBox.Name = "NumeroTextBox";
            this.NumeroTextBox.Size = new System.Drawing.Size(100, 26);
            this.NumeroTextBox.TabIndex = 1;
            // 
            // Ejecutarbutton
            // 
            this.Ejecutarbutton.Location = new System.Drawing.Point(361, 39);
            this.Ejecutarbutton.Name = "Ejecutarbutton";
            this.Ejecutarbutton.Size = new System.Drawing.Size(107, 26);
            this.Ejecutarbutton.TabIndex = 2;
            this.Ejecutarbutton.Text = "Ejecutar";
            this.Ejecutarbutton.UseVisualStyleBackColor = true;
            this.Ejecutarbutton.Click += new System.EventHandler(this.Ejecutarbutton_Click);
            // 
            // ParImpartextBox
            // 
            this.ParImpartextBox.Location = new System.Drawing.Point(47, 132);
            this.ParImpartextBox.Name = "ParImpartextBox";
            this.ParImpartextBox.Size = new System.Drawing.Size(421, 26);
            this.ParImpartextBox.TabIndex = 3;
            // 
            // PositivoNegativotextBox
            // 
            this.PositivoNegativotextBox.Location = new System.Drawing.Point(47, 207);
            this.PositivoNegativotextBox.Name = "PositivoNegativotextBox";
            this.PositivoNegativotextBox.Size = new System.Drawing.Size(421, 26);
            this.PositivoNegativotextBox.TabIndex = 4;
            // 
            // EjercicioTarea1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PositivoNegativotextBox);
            this.Controls.Add(this.ParImpartextBox);
            this.Controls.Add(this.Ejecutarbutton);
            this.Controls.Add(this.NumeroTextBox);
            this.Controls.Add(this.label1);
            this.Name = "EjercicioTarea1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumeroTextBox;
        private System.Windows.Forms.Button Ejecutarbutton;
        private System.Windows.Forms.TextBox ParImpartextBox;
        private System.Windows.Forms.TextBox PositivoNegativotextBox;
    }
}

