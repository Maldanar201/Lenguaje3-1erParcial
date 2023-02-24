namespace ManuelAldana
{
    partial class Descuento
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
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.agragarButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.regresarbutton = new System.Windows.Forms.Button();
            this.Salirbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DescuentoTextBox = new System.Windows.Forms.TextBox();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Precio Producto : ";
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(119, 21);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(100, 20);
            this.PrecioTextBox.TabIndex = 1;
            // 
            // agragarButton
            // 
            this.agragarButton.Location = new System.Drawing.Point(119, 57);
            this.agragarButton.Name = "agragarButton";
            this.agragarButton.Size = new System.Drawing.Size(100, 27);
            this.agragarButton.TabIndex = 2;
            this.agragarButton.Text = "Agregar";
            this.agragarButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(258, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(227, 407);
            this.listBox1.TabIndex = 3;
            // 
            // regresarbutton
            // 
            this.regresarbutton.Location = new System.Drawing.Point(12, 386);
            this.regresarbutton.Name = "regresarbutton";
            this.regresarbutton.Size = new System.Drawing.Size(100, 27);
            this.regresarbutton.TabIndex = 4;
            this.regresarbutton.Text = "Regresar";
            this.regresarbutton.UseVisualStyleBackColor = true;
            // 
            // Salirbutton
            // 
            this.Salirbutton.Location = new System.Drawing.Point(119, 386);
            this.Salirbutton.Name = "Salirbutton";
            this.Salirbutton.Size = new System.Drawing.Size(100, 27);
            this.Salirbutton.TabIndex = 5;
            this.Salirbutton.Text = "Salir";
            this.Salirbutton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "DESCUENTO : ";
            // 
            // DescuentoTextBox
            // 
            this.DescuentoTextBox.Location = new System.Drawing.Point(129, 156);
            this.DescuentoTextBox.Name = "DescuentoTextBox";
            this.DescuentoTextBox.Size = new System.Drawing.Size(100, 20);
            this.DescuentoTextBox.TabIndex = 7;
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(129, 204);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.Size = new System.Drawing.Size(100, 20);
            this.TotaltextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "TOTAL A PAGAR : ";
            // 
            // Descuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 447);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DescuentoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Salirbutton);
            this.Controls.Add(this.regresarbutton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.agragarButton);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Descuento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descuento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.Button agragarButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button regresarbutton;
        private System.Windows.Forms.Button Salirbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DescuentoTextBox;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.Label label3;
    }
}