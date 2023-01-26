namespace _1erParcial
{
    partial class Ejercicio2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Numero1textBox = new System.Windows.Forms.TextBox();
            this.Numero2textBox = new System.Windows.Forms.TextBox();
            this.OperacionesComboBox = new System.Windows.Forms.ComboBox();
            this.EjecutarButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Resultadolabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(80, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(80, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2 :";
            // 
            // Numero1textBox
            // 
            this.Numero1textBox.Location = new System.Drawing.Point(168, 57);
            this.Numero1textBox.Name = "Numero1textBox";
            this.Numero1textBox.Size = new System.Drawing.Size(155, 26);
            this.Numero1textBox.TabIndex = 2;
            // 
            // Numero2textBox
            // 
            this.Numero2textBox.Location = new System.Drawing.Point(168, 106);
            this.Numero2textBox.Name = "Numero2textBox";
            this.Numero2textBox.Size = new System.Drawing.Size(155, 26);
            this.Numero2textBox.TabIndex = 3;
            // 
            // OperacionesComboBox
            // 
            this.OperacionesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperacionesComboBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.OperacionesComboBox.FormattingEnabled = true;
            this.OperacionesComboBox.Items.AddRange(new object[] {
            "SUMA",
            "RESTA",
            "MULTIPLICACION",
            "DIVISION"});
            this.OperacionesComboBox.Location = new System.Drawing.Point(168, 159);
            this.OperacionesComboBox.Name = "OperacionesComboBox";
            this.OperacionesComboBox.Size = new System.Drawing.Size(155, 28);
            this.OperacionesComboBox.TabIndex = 4;
            this.OperacionesComboBox.SelectedIndexChanged += new System.EventHandler(this.OperacionesComboBox_SelectedIndexChanged);
            // 
            // EjecutarButton
            // 
            this.EjecutarButton.Location = new System.Drawing.Point(168, 207);
            this.EjecutarButton.Name = "EjecutarButton";
            this.EjecutarButton.Size = new System.Drawing.Size(155, 36);
            this.EjecutarButton.TabIndex = 5;
            this.EjecutarButton.Text = "Ejecutar";
            this.EjecutarButton.UseVisualStyleBackColor = true;
            this.EjecutarButton.Click += new System.EventHandler(this.EjecutarButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Respuesta :";
            // 
            // Resultadolabel
            // 
            this.Resultadolabel.AutoSize = true;
            this.Resultadolabel.ForeColor = System.Drawing.Color.Green;
            this.Resultadolabel.Location = new System.Drawing.Point(455, 223);
            this.Resultadolabel.Name = "Resultadolabel";
            this.Resultadolabel.Size = new System.Drawing.Size(19, 20);
            this.Resultadolabel.TabIndex = 7;
            this.Resultadolabel.Text = "--";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 356);
            this.Controls.Add(this.Resultadolabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EjecutarButton);
            this.Controls.Add(this.OperacionesComboBox);
            this.Controls.Add(this.Numero2textBox);
            this.Controls.Add(this.Numero1textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Numero1textBox;
        private System.Windows.Forms.TextBox Numero2textBox;
        private System.Windows.Forms.ComboBox OperacionesComboBox;
        private System.Windows.Forms.Button EjecutarButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Resultadolabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}