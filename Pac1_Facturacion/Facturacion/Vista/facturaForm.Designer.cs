namespace Vista
{
    partial class facturaForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.buscarClienteButton = new System.Windows.Forms.Button();
            this.IDClienteTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.existenciaTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DescripcionProductotextBox = new System.Windows.Forms.TextBox();
            this.buscarProductobutton = new System.Windows.Forms.Button();
            this.CodigoProductoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.detalleDataGridView = new System.Windows.Forms.DataGridView();
            this.subTotalTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.isvTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DescuentoTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.guardarButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva Factura";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FechaDateTimePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.UsuarioTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(1, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1054, 45);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(855, 15);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(185, 22);
            this.FechaDateTimePicker.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(765, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha :";
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Location = new System.Drawing.Point(81, 15);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.ReadOnly = true;
            this.UsuarioTextBox.Size = new System.Drawing.Size(200, 22);
            this.UsuarioTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NombreClienteTextBox);
            this.groupBox2.Controls.Add(this.buscarClienteButton);
            this.groupBox2.Controls.Add(this.IDClienteTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(1, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1054, 63);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Cliente";
            // 
            // NombreClienteTextBox
            // 
            this.NombreClienteTextBox.Location = new System.Drawing.Point(353, 24);
            this.NombreClienteTextBox.Name = "NombreClienteTextBox";
            this.NombreClienteTextBox.ReadOnly = true;
            this.NombreClienteTextBox.Size = new System.Drawing.Size(687, 22);
            this.NombreClienteTextBox.TabIndex = 4;
            // 
            // buscarClienteButton
            // 
            this.buscarClienteButton.Image = global::Vista.Properties.Resources.buscar;
            this.buscarClienteButton.Location = new System.Drawing.Point(287, 24);
            this.buscarClienteButton.Name = "buscarClienteButton";
            this.buscarClienteButton.Size = new System.Drawing.Size(60, 23);
            this.buscarClienteButton.TabIndex = 3;
            this.buscarClienteButton.Text = "...";
            this.buscarClienteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buscarClienteButton.UseVisualStyleBackColor = true;
            this.buscarClienteButton.Click += new System.EventHandler(this.buscarClienteButton_Click);
            // 
            // IDClienteTextBox
            // 
            this.IDClienteTextBox.Location = new System.Drawing.Point(81, 24);
            this.IDClienteTextBox.Name = "IDClienteTextBox";
            this.IDClienteTextBox.Size = new System.Drawing.Size(200, 22);
            this.IDClienteTextBox.TabIndex = 2;
            this.IDClienteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDClienteTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Identidad :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CantidadTextBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.existenciaTextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.DescripcionProductotextBox);
            this.groupBox3.Controls.Add(this.buscarProductobutton);
            this.groupBox3.Controls.Add(this.CodigoProductoTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(1, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1054, 87);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Productos";
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Location = new System.Drawing.Point(855, 52);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(185, 22);
            this.CantidadTextBox.TabIndex = 12;
            this.CantidadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantidadTextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(765, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cantidad :";
            // 
            // existenciaTextBox
            // 
            this.existenciaTextBox.Location = new System.Drawing.Point(81, 49);
            this.existenciaTextBox.Name = "existenciaTextBox";
            this.existenciaTextBox.ReadOnly = true;
            this.existenciaTextBox.Size = new System.Drawing.Size(200, 22);
            this.existenciaTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Existencia :";
            // 
            // DescripcionProductotextBox
            // 
            this.DescripcionProductotextBox.Location = new System.Drawing.Point(353, 21);
            this.DescripcionProductotextBox.Name = "DescripcionProductotextBox";
            this.DescripcionProductotextBox.ReadOnly = true;
            this.DescripcionProductotextBox.Size = new System.Drawing.Size(687, 22);
            this.DescripcionProductotextBox.TabIndex = 8;
            // 
            // buscarProductobutton
            // 
            this.buscarProductobutton.Image = global::Vista.Properties.Resources.buscar;
            this.buscarProductobutton.Location = new System.Drawing.Point(287, 21);
            this.buscarProductobutton.Name = "buscarProductobutton";
            this.buscarProductobutton.Size = new System.Drawing.Size(60, 23);
            this.buscarProductobutton.TabIndex = 7;
            this.buscarProductobutton.Text = "...";
            this.buscarProductobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buscarProductobutton.UseVisualStyleBackColor = true;
            this.buscarProductobutton.Click += new System.EventHandler(this.buscarProductobutton_Click);
            // 
            // CodigoProductoTextBox
            // 
            this.CodigoProductoTextBox.Location = new System.Drawing.Point(81, 21);
            this.CodigoProductoTextBox.Name = "CodigoProductoTextBox";
            this.CodigoProductoTextBox.Size = new System.Drawing.Size(200, 22);
            this.CodigoProductoTextBox.TabIndex = 6;
            this.CodigoProductoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodigoProductoTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Codigo :";
            // 
            // detalleDataGridView
            // 
            this.detalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalleDataGridView.Location = new System.Drawing.Point(1, 245);
            this.detalleDataGridView.Name = "detalleDataGridView";
            this.detalleDataGridView.Size = new System.Drawing.Size(1054, 150);
            this.detalleDataGridView.TabIndex = 4;
            // 
            // subTotalTextBox
            // 
            this.subTotalTextBox.Location = new System.Drawing.Point(856, 401);
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.ReadOnly = true;
            this.subTotalTextBox.Size = new System.Drawing.Size(185, 22);
            this.subTotalTextBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(766, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "SubTotal :";
            // 
            // isvTextBox
            // 
            this.isvTextBox.Location = new System.Drawing.Point(856, 429);
            this.isvTextBox.Name = "isvTextBox";
            this.isvTextBox.ReadOnly = true;
            this.isvTextBox.Size = new System.Drawing.Size(185, 22);
            this.isvTextBox.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(766, 432);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "ISV :";
            // 
            // DescuentoTextBox
            // 
            this.DescuentoTextBox.Location = new System.Drawing.Point(856, 457);
            this.DescuentoTextBox.Name = "DescuentoTextBox";
            this.DescuentoTextBox.Size = new System.Drawing.Size(185, 22);
            this.DescuentoTextBox.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(766, 460);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Descuento :";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(856, 485);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(185, 22);
            this.TotalTextBox.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(766, 488);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Total Pagar :";
            // 
            // cancelarButton
            // 
            this.cancelarButton.Image = global::Vista.Properties.Resources.cancelar;
            this.cancelarButton.Location = new System.Drawing.Point(123, 460);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(105, 44);
            this.cancelarButton.TabIndex = 22;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelarButton.UseVisualStyleBackColor = true;
            // 
            // guardarButton
            // 
            this.guardarButton.Image = global::Vista.Properties.Resources.comprobado;
            this.guardarButton.Location = new System.Drawing.Point(12, 460);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(105, 44);
            this.guardarButton.TabIndex = 21;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click);
            // 
            // facturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1058, 518);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DescuentoTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.isvTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.subTotalTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.detalleDataGridView);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "facturaForm";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.facturaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IDClienteTextBox;
        private System.Windows.Forms.TextBox NombreClienteTextBox;
        private System.Windows.Forms.Button buscarClienteButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox existenciaTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DescripcionProductotextBox;
        private System.Windows.Forms.Button buscarProductobutton;
        private System.Windows.Forms.TextBox CodigoProductoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView detalleDataGridView;
        private System.Windows.Forms.TextBox subTotalTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox isvTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DescuentoTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button guardarButton;
        private System.Windows.Forms.Button cancelarButton;
    }
}