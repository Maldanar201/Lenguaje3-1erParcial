namespace ManuelAldana
{
    partial class Bienvenida
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
            this.interesesButton = new System.Windows.Forms.Button();
            this.desceuntoButton = new System.Windows.Forms.Button();
            this.formulario3Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hola Bienvenido";
            // 
            // interesesButton
            // 
            this.interesesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interesesButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.interesesButton.Location = new System.Drawing.Point(6, 78);
            this.interesesButton.Name = "interesesButton";
            this.interesesButton.Size = new System.Drawing.Size(146, 73);
            this.interesesButton.TabIndex = 1;
            this.interesesButton.Text = "Calcular interes";
            this.interesesButton.UseVisualStyleBackColor = true;
            this.interesesButton.Click += new System.EventHandler(this.interesesButton_Click);
            // 
            // desceuntoButton
            // 
            this.desceuntoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desceuntoButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.desceuntoButton.Location = new System.Drawing.Point(158, 78);
            this.desceuntoButton.Name = "desceuntoButton";
            this.desceuntoButton.Size = new System.Drawing.Size(146, 73);
            this.desceuntoButton.TabIndex = 2;
            this.desceuntoButton.Text = "Calcular Descuento";
            this.desceuntoButton.UseVisualStyleBackColor = true;
            this.desceuntoButton.Click += new System.EventHandler(this.desceuntoButton_Click);
            // 
            // formulario3Button
            // 
            this.formulario3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formulario3Button.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.formulario3Button.Location = new System.Drawing.Point(310, 78);
            this.formulario3Button.Name = "formulario3Button";
            this.formulario3Button.Size = new System.Drawing.Size(146, 73);
            this.formulario3Button.TabIndex = 3;
            this.formulario3Button.Text = "Funcion Nombre";
            this.formulario3Button.UseVisualStyleBackColor = true;
            this.formulario3Button.Click += new System.EventHandler(this.formulario3Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Que desea hacer Hoy!!";
            // 
            // Bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 194);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.formulario3Button);
            this.Controls.Add(this.desceuntoButton);
            this.Controls.Add(this.interesesButton);
            this.Controls.Add(this.label1);
            this.Name = "Bienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manuel Aldana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button interesesButton;
        private System.Windows.Forms.Button desceuntoButton;
        private System.Windows.Forms.Button formulario3Button;
        private System.Windows.Forms.Label label2;
    }
}

