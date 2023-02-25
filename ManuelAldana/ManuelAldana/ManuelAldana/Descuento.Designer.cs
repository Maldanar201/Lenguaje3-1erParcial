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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.agragarButton = new System.Windows.Forms.Button();
            this.Salirbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DescuentoTextBox = new System.Windows.Forms.TextBox();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductosDataGridView = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTextBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NombreTextBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Producto : ";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTextBox.Location = new System.Drawing.Point(146, 12);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(126, 22);
            this.NombreTextBox.TabIndex = 1;
            // 
            // agragarButton
            // 
            this.agragarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agragarButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.agragarButton.Location = new System.Drawing.Point(146, 166);
            this.agragarButton.Name = "agragarButton";
            this.agragarButton.Size = new System.Drawing.Size(126, 27);
            this.agragarButton.TabIndex = 2;
            this.agragarButton.Text = "Agregar";
            this.agragarButton.UseVisualStyleBackColor = true;
            this.agragarButton.Click += new System.EventHandler(this.agragarButton_Click);
            // 
            // Salirbutton
            // 
            this.Salirbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salirbutton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Salirbutton.Location = new System.Drawing.Point(146, 386);
            this.Salirbutton.Name = "Salirbutton";
            this.Salirbutton.Size = new System.Drawing.Size(126, 27);
            this.Salirbutton.TabIndex = 5;
            this.Salirbutton.Text = "Salir";
            this.Salirbutton.UseVisualStyleBackColor = true;
            this.Salirbutton.Click += new System.EventHandler(this.Salirbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "DESCUENTO : ";
            // 
            // DescuentoTextBox
            // 
            this.DescuentoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescuentoTextBox.Location = new System.Drawing.Point(146, 266);
            this.DescuentoTextBox.Name = "DescuentoTextBox";
            this.DescuentoTextBox.ReadOnly = true;
            this.DescuentoTextBox.Size = new System.Drawing.Size(126, 22);
            this.DescuentoTextBox.TabIndex = 7;
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotaltextBox.Location = new System.Drawing.Point(146, 314);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.ReadOnly = true;
            this.TotaltextBox.Size = new System.Drawing.Size(126, 22);
            this.TotaltextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "TOTAL A PAGAR : ";
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioTextBox.Location = new System.Drawing.Point(146, 38);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(126, 22);
            this.PrecioTextBox.TabIndex = 11;
            this.PrecioTextBox.TextChanged += new System.EventHandler(this.PrecioTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Precio Producto : ";
            // 
            // ProductosDataGridView
            // 
            this.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Precio});
            this.ProductosDataGridView.Location = new System.Drawing.Point(278, 3);
            this.ProductosDataGridView.Name = "ProductosDataGridView";
            this.ProductosDataGridView.ReadOnly = true;
            this.ProductosDataGridView.Size = new System.Drawing.Size(240, 445);
            this.ProductosDataGridView.TabIndex = 12;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // PrecioTextBox2
            // 
            this.PrecioTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioTextBox2.Location = new System.Drawing.Point(146, 102);
            this.PrecioTextBox2.Name = "PrecioTextBox2";
            this.PrecioTextBox2.Size = new System.Drawing.Size(126, 22);
            this.PrecioTextBox2.TabIndex = 16;
            this.PrecioTextBox2.TextChanged += new System.EventHandler(this.PrecioTextBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Precio Producto : ";
            // 
            // NombreTextBox2
            // 
            this.NombreTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTextBox2.Location = new System.Drawing.Point(146, 76);
            this.NombreTextBox2.Name = "NombreTextBox2";
            this.NombreTextBox2.Size = new System.Drawing.Size(126, 22);
            this.NombreTextBox2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nombre Producto : ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Descuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 447);
            this.Controls.Add(this.PrecioTextBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NombreTextBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ProductosDataGridView);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DescuentoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Salirbutton);
            this.Controls.Add(this.agragarButton);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Descuento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descuento";
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Button agragarButton;
        private System.Windows.Forms.Button Salirbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DescuentoTextBox;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ProductosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.TextBox PrecioTextBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NombreTextBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}