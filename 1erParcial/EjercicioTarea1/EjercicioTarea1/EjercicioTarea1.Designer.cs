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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.NumeroTextBox = new System.Windows.Forms.TextBox();
            this.Ejecutarbutton = new System.Windows.Forms.Button();
            this.ParImpartextBox = new System.Windows.Forms.TextBox();
            this.PositivoNegativotextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese  un Numero :";
            // 
            // NumeroTextBox
            // 
            this.NumeroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroTextBox.Location = new System.Drawing.Point(173, 25);
            this.NumeroTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NumeroTextBox.Name = "NumeroTextBox";
            this.NumeroTextBox.Size = new System.Drawing.Size(55, 24);
            this.NumeroTextBox.TabIndex = 1;
            this.NumeroTextBox.TextChanged += new System.EventHandler(this.NumeroTextBox_TextChanged);
            // 
            // Ejecutarbutton
            // 
            this.Ejecutarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ejecutarbutton.ForeColor = System.Drawing.Color.DarkBlue;
            this.Ejecutarbutton.Location = new System.Drawing.Point(314, 25);
            this.Ejecutarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Ejecutarbutton.Name = "Ejecutarbutton";
            this.Ejecutarbutton.Size = new System.Drawing.Size(103, 39);
            this.Ejecutarbutton.TabIndex = 2;
            this.Ejecutarbutton.Text = "Ejecutar";
            this.Ejecutarbutton.UseVisualStyleBackColor = true;
            this.Ejecutarbutton.Click += new System.EventHandler(this.Ejecutarbutton_Click);
            // 
            // ParImpartextBox
            // 
            this.ParImpartextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParImpartextBox.Location = new System.Drawing.Point(31, 86);
            this.ParImpartextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ParImpartextBox.Name = "ParImpartextBox";
            this.ParImpartextBox.ReadOnly = true;
            this.ParImpartextBox.Size = new System.Drawing.Size(386, 24);
            this.ParImpartextBox.TabIndex = 3;
            // 
            // PositivoNegativotextBox
            // 
            this.PositivoNegativotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositivoNegativotextBox.Location = new System.Drawing.Point(31, 135);
            this.PositivoNegativotextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PositivoNegativotextBox.Name = "PositivoNegativotextBox";
            this.PositivoNegativotextBox.ReadOnly = true;
            this.PositivoNegativotextBox.Size = new System.Drawing.Size(386, 24);
            this.PositivoNegativotextBox.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EjercicioTarea1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 297);
            this.Controls.Add(this.PositivoNegativotextBox);
            this.Controls.Add(this.ParImpartextBox);
            this.Controls.Add(this.Ejecutarbutton);
            this.Controls.Add(this.NumeroTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EjercicioTarea1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumeroTextBox;
        private System.Windows.Forms.Button Ejecutarbutton;
        private System.Windows.Forms.TextBox ParImpartextBox;
        private System.Windows.Forms.TextBox PositivoNegativotextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

