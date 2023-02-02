namespace _1erParcial
{
    partial class Ejercicio5
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
            this.HornearPizzaButton1 = new System.Windows.Forms.Button();
            this.HornearPizzaAsynButton2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Numero1textBox = new System.Windows.Forms.TextBox();
            this.Numero2textBox = new System.Windows.Forms.TextBox();
            this.SumarBoton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HornearPizzaButton1
            // 
            this.HornearPizzaButton1.Location = new System.Drawing.Point(60, 12);
            this.HornearPizzaButton1.Name = "HornearPizzaButton1";
            this.HornearPizzaButton1.Size = new System.Drawing.Size(172, 68);
            this.HornearPizzaButton1.TabIndex = 0;
            this.HornearPizzaButton1.Text = "Hornear Pizza";
            this.HornearPizzaButton1.UseVisualStyleBackColor = true;
            this.HornearPizzaButton1.Click += new System.EventHandler(this.HornearPizzaButton1_Click);
            // 
            // HornearPizzaAsynButton2
            // 
            this.HornearPizzaAsynButton2.Location = new System.Drawing.Point(404, 12);
            this.HornearPizzaAsynButton2.Name = "HornearPizzaAsynButton2";
            this.HornearPizzaAsynButton2.Size = new System.Drawing.Size(172, 68);
            this.HornearPizzaAsynButton2.TabIndex = 1;
            this.HornearPizzaAsynButton2.Text = "Hornear Pizza Asyncronica";
            this.HornearPizzaAsynButton2.UseVisualStyleBackColor = true;
            this.HornearPizzaAsynButton2.Click += new System.EventHandler(this.HornearPizzaAsynButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero 1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero 2:";
            // 
            // Numero1textBox
            // 
            this.Numero1textBox.Location = new System.Drawing.Point(211, 193);
            this.Numero1textBox.Name = "Numero1textBox";
            this.Numero1textBox.Size = new System.Drawing.Size(100, 20);
            this.Numero1textBox.TabIndex = 4;
            // 
            // Numero2textBox
            // 
            this.Numero2textBox.Location = new System.Drawing.Point(211, 239);
            this.Numero2textBox.Name = "Numero2textBox";
            this.Numero2textBox.Size = new System.Drawing.Size(100, 20);
            this.Numero2textBox.TabIndex = 5;
            // 
            // SumarBoton
            // 
            this.SumarBoton.Location = new System.Drawing.Point(342, 193);
            this.SumarBoton.Name = "SumarBoton";
            this.SumarBoton.Size = new System.Drawing.Size(96, 66);
            this.SumarBoton.TabIndex = 6;
            this.SumarBoton.Text = "Sumar";
            this.SumarBoton.UseVisualStyleBackColor = true;
            this.SumarBoton.Click += new System.EventHandler(this.SumarBoton_Click);
            // 
            // Ejercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SumarBoton);
            this.Controls.Add(this.Numero2textBox);
            this.Controls.Add(this.Numero1textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HornearPizzaAsynButton2);
            this.Controls.Add(this.HornearPizzaButton1);
            this.Name = "Ejercicio5";
            this.Text = "Ejercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HornearPizzaButton1;
        private System.Windows.Forms.Button HornearPizzaAsynButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Numero1textBox;
        private System.Windows.Forms.TextBox Numero2textBox;
        private System.Windows.Forms.Button SumarBoton;
    }
}