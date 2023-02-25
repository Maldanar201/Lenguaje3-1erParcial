namespace ManuelAldana
{
    partial class Formulario3
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
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.ApellidoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ejecutarButton = new System.Windows.Forms.Button();
            this.salirButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese su Nombre :";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(153, 26);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(209, 22);
            this.nombreTextBox.TabIndex = 1;
            // 
            // ApellidoTextBox
            // 
            this.ApellidoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidoTextBox.Location = new System.Drawing.Point(153, 67);
            this.ApellidoTextBox.Name = "ApellidoTextBox";
            this.ApellidoTextBox.Size = new System.Drawing.Size(209, 22);
            this.ApellidoTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese su Apellido :";
            // 
            // ejecutarButton
            // 
            this.ejecutarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ejecutarButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ejecutarButton.Location = new System.Drawing.Point(153, 104);
            this.ejecutarButton.Name = "ejecutarButton";
            this.ejecutarButton.Size = new System.Drawing.Size(209, 26);
            this.ejecutarButton.TabIndex = 4;
            this.ejecutarButton.Text = "Ejecutar";
            this.ejecutarButton.UseVisualStyleBackColor = true;
            this.ejecutarButton.Click += new System.EventHandler(this.ejecutarButton_Click);
            // 
            // salirButton
            // 
            this.salirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.salirButton.Location = new System.Drawing.Point(153, 166);
            this.salirButton.Name = "salirButton";
            this.salirButton.Size = new System.Drawing.Size(209, 26);
            this.salirButton.TabIndex = 6;
            this.salirButton.Text = "Salir";
            this.salirButton.UseVisualStyleBackColor = true;
            this.salirButton.Click += new System.EventHandler(this.salirButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(378, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(306, 175);
            this.listBox1.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Formulario3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 218);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.salirButton);
            this.Controls.Add(this.ejecutarButton);
            this.Controls.Add(this.ApellidoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Formulario3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario3";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox ApellidoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ejecutarButton;
        private System.Windows.Forms.Button salirButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}