namespace ManuelAldana
{
    partial class Interes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ValorTextBox = new System.Windows.Forms.TextBox();
            this.InteresTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tiempoTextBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.calcularButton = new System.Windows.Forms.Button();
            this.regresarButton = new System.Windows.Forms.Button();
            this.SalirButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Depositado : ";
            // 
            // ValorTextBox
            // 
            this.ValorTextBox.Location = new System.Drawing.Point(159, 157);
            this.ValorTextBox.Name = "ValorTextBox";
            this.ValorTextBox.Size = new System.Drawing.Size(100, 20);
            this.ValorTextBox.TabIndex = 1;
            // 
            // InteresTextBox
            // 
            this.InteresTextBox.Location = new System.Drawing.Point(159, 183);
            this.InteresTextBox.Name = "InteresTextBox";
            this.InteresTextBox.Size = new System.Drawing.Size(100, 20);
            this.InteresTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Interes a ganar : ";
            // 
            // tiempoTextBox2
            // 
            this.tiempoTextBox2.Location = new System.Drawing.Point(159, 209);
            this.tiempoTextBox2.Name = "tiempoTextBox2";
            this.tiempoTextBox2.Size = new System.Drawing.Size(100, 20);
            this.tiempoTextBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tiempo en Meses : ";
            // 
            // calcularButton
            // 
            this.calcularButton.Location = new System.Drawing.Point(159, 235);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(100, 30);
            this.calcularButton.TabIndex = 6;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            // 
            // regresarButton
            // 
            this.regresarButton.Location = new System.Drawing.Point(46, 357);
            this.regresarButton.Name = "regresarButton";
            this.regresarButton.Size = new System.Drawing.Size(97, 39);
            this.regresarButton.TabIndex = 7;
            this.regresarButton.Text = "regresar";
            this.regresarButton.UseVisualStyleBackColor = true;
            // 
            // SalirButton
            // 
            this.SalirButton.Location = new System.Drawing.Point(159, 357);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(100, 39);
            this.SalirButton.TabIndex = 8;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(310, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(299, 446);
            this.listBox1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Calcular Intereses Ganados";
            // 
            // Interes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 455);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.regresarButton);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.tiempoTextBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InteresTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ValorTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Interes";
            this.Text = "Interes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ValorTextBox;
        private System.Windows.Forms.TextBox InteresTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tiempoTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.Button regresarButton;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
    }
}