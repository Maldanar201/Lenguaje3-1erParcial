namespace EjercioTarea2
{
    partial class Form1
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
            this.Nota1txt = new System.Windows.Forms.TextBox();
            this.Nota2txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Nota4txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nota3txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.calcularButton = new System.Windows.Forms.Button();
            this.NUEVObutton = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PromedioAlumDataGridView = new System.Windows.Forms.DataGridView();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PromedioAlumDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota 1 :";
            // 
            // Nota1txt
            // 
            this.Nota1txt.Location = new System.Drawing.Point(95, 65);
            this.Nota1txt.Name = "Nota1txt";
            this.Nota1txt.Size = new System.Drawing.Size(100, 20);
            this.Nota1txt.TabIndex = 1;
            // 
            // Nota2txt
            // 
            this.Nota2txt.Location = new System.Drawing.Point(95, 91);
            this.Nota2txt.Name = "Nota2txt";
            this.Nota2txt.Size = new System.Drawing.Size(100, 20);
            this.Nota2txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota 2 :";
            // 
            // Nota4txt
            // 
            this.Nota4txt.Location = new System.Drawing.Point(95, 143);
            this.Nota4txt.Name = "Nota4txt";
            this.Nota4txt.Size = new System.Drawing.Size(100, 20);
            this.Nota4txt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nota 4 :";
            // 
            // Nota3txt
            // 
            this.Nota3txt.Location = new System.Drawing.Point(95, 117);
            this.Nota3txt.Name = "Nota3txt";
            this.Nota3txt.Size = new System.Drawing.Size(100, 20);
            this.Nota3txt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nota 3 :";
            // 
            // calcularButton
            // 
            this.calcularButton.Location = new System.Drawing.Point(225, 65);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(75, 46);
            this.calcularButton.TabIndex = 8;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // NUEVObutton
            // 
            this.NUEVObutton.Location = new System.Drawing.Point(306, 65);
            this.NUEVObutton.Name = "NUEVObutton";
            this.NUEVObutton.Size = new System.Drawing.Size(75, 46);
            this.NUEVObutton.TabIndex = 9;
            this.NUEVObutton.Text = "NUEVO";
            this.NUEVObutton.UseVisualStyleBackColor = true;
            this.NUEVObutton.Click += new System.EventHandler(this.NUEVObutton_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(95, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(353, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nombre :";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(512, 143);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(100, 20);
            this.txtPromedio.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(439, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Promedio :";
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(512, 117);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(100, 20);
            this.txtSuma.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(439, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total Notas :";
            // 
            // PromedioAlumDataGridView
            // 
            this.PromedioAlumDataGridView.AllowUserToAddRows = false;
            this.PromedioAlumDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PromedioAlumDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.PromedioAlumDataGridView.Location = new System.Drawing.Point(1, 233);
            this.PromedioAlumDataGridView.Name = "PromedioAlumDataGridView";
            this.PromedioAlumDataGridView.ReadOnly = true;
            this.PromedioAlumDataGridView.Size = new System.Drawing.Size(766, 212);
            this.PromedioAlumDataGridView.TabIndex = 16;
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(EjercioTarea2.Form1);
            // 
            // form1BindingSource1
            // 
            this.form1BindingSource1.DataSource = typeof(EjercioTarea2.Form1);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 200F;
            this.Column1.HeaderText = "Nombre Completo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 80F;
            this.Column2.HeaderText = "Nota1";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 80F;
            this.Column3.HeaderText = "Nota2";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 80F;
            this.Column4.HeaderText = "Nota3";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 80F;
            this.Column5.HeaderText = "Nota4";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Promedio";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AcceptButton = this.calcularButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 448);
            this.Controls.Add(this.PromedioAlumDataGridView);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NUEVObutton);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.Nota4txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nota3txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Nota2txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nota1txt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PromedioAlumDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nota1txt;
        private System.Windows.Forms.TextBox Nota2txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nota4txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nota3txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.Button NUEVObutton;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView PromedioAlumDataGridView;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

