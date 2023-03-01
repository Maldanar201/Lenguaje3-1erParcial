namespace Vista
{
    partial class UsuariosForm
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
            this.CodigoTextBox = new System.Windows.Forms.TextBox();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ContraseñaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CorreoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RolComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EstaActivoCheckBox = new System.Windows.Forms.CheckBox();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.Modificarbutton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.AdjuntarFotobutton = new System.Windows.Forms.Button();
            this.FotopictureBox = new System.Windows.Forms.PictureBox();
            this.UsuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FotopictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo : ";
            // 
            // CodigoTextBox
            // 
            this.CodigoTextBox.Enabled = false;
            this.CodigoTextBox.Location = new System.Drawing.Point(85, 12);
            this.CodigoTextBox.Name = "CodigoTextBox";
            this.CodigoTextBox.Size = new System.Drawing.Size(285, 20);
            this.CodigoTextBox.TabIndex = 1;
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Enabled = false;
            this.UsuarioTextBox.Location = new System.Drawing.Point(85, 37);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(285, 20);
            this.UsuarioTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario : ";
            // 
            // ContraseñaTextBox
            // 
            this.ContraseñaTextBox.Enabled = false;
            this.ContraseñaTextBox.Location = new System.Drawing.Point(85, 63);
            this.ContraseñaTextBox.Name = "ContraseñaTextBox";
            this.ContraseñaTextBox.PasswordChar = '*';
            this.ContraseñaTextBox.Size = new System.Drawing.Size(285, 20);
            this.ContraseñaTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña : ";
            // 
            // CorreoTextBox
            // 
            this.CorreoTextBox.Enabled = false;
            this.CorreoTextBox.Location = new System.Drawing.Point(85, 89);
            this.CorreoTextBox.Name = "CorreoTextBox";
            this.CorreoTextBox.Size = new System.Drawing.Size(285, 20);
            this.CorreoTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Correo : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ROL : ";
            // 
            // RolComboBox
            // 
            this.RolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RolComboBox.Enabled = false;
            this.RolComboBox.FormattingEnabled = true;
            this.RolComboBox.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.RolComboBox.Location = new System.Drawing.Point(85, 115);
            this.RolComboBox.Name = "RolComboBox";
            this.RolComboBox.Size = new System.Drawing.Size(285, 21);
            this.RolComboBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Estado :";
            // 
            // EstaActivoCheckBox
            // 
            this.EstaActivoCheckBox.AutoSize = true;
            this.EstaActivoCheckBox.Enabled = false;
            this.EstaActivoCheckBox.Location = new System.Drawing.Point(85, 161);
            this.EstaActivoCheckBox.Name = "EstaActivoCheckBox";
            this.EstaActivoCheckBox.Size = new System.Drawing.Size(56, 17);
            this.EstaActivoCheckBox.TabIndex = 11;
            this.EstaActivoCheckBox.Text = "Activo";
            this.EstaActivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Enabled = false;
            this.CancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Image = global::Vista.Properties.Resources.cancelar2;
            this.CancelarButton.Location = new System.Drawing.Point(420, 201);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(96, 34);
            this.CancelarButton.TabIndex = 18;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Enabled = false;
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = global::Vista.Properties.Resources.eliminar;
            this.EliminarButton.Location = new System.Drawing.Point(318, 201);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(96, 34);
            this.EliminarButton.TabIndex = 17;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Enabled = false;
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Image = global::Vista.Properties.Resources.guardar;
            this.GuardarButton.Location = new System.Drawing.Point(216, 201);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(96, 34);
            this.GuardarButton.TabIndex = 16;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // Modificarbutton
            // 
            this.Modificarbutton.Enabled = false;
            this.Modificarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificarbutton.Image = global::Vista.Properties.Resources.modificar;
            this.Modificarbutton.Location = new System.Drawing.Point(114, 201);
            this.Modificarbutton.Name = "Modificarbutton";
            this.Modificarbutton.Size = new System.Drawing.Size(96, 34);
            this.Modificarbutton.TabIndex = 15;
            this.Modificarbutton.Text = "Modificar";
            this.Modificarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Modificarbutton.UseVisualStyleBackColor = true;
            this.Modificarbutton.Click += new System.EventHandler(this.Modificarbutton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.Image = global::Vista.Properties.Resources.agregar_archivo;
            this.NuevoButton.Location = new System.Drawing.Point(12, 201);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(96, 34);
            this.NuevoButton.TabIndex = 14;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdjuntarFotobutton
            // 
            this.AdjuntarFotobutton.Enabled = false;
            this.AdjuntarFotobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdjuntarFotobutton.Image = global::Vista.Properties.Resources.buscar;
            this.AdjuntarFotobutton.Location = new System.Drawing.Point(376, 151);
            this.AdjuntarFotobutton.Name = "AdjuntarFotobutton";
            this.AdjuntarFotobutton.Size = new System.Drawing.Size(140, 33);
            this.AdjuntarFotobutton.TabIndex = 13;
            this.AdjuntarFotobutton.Text = "   Adjuntar";
            this.AdjuntarFotobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AdjuntarFotobutton.UseVisualStyleBackColor = true;
            this.AdjuntarFotobutton.Click += new System.EventHandler(this.AdjuntarFotobutton_Click);
            // 
            // FotopictureBox
            // 
            this.FotopictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FotopictureBox.Location = new System.Drawing.Point(376, 12);
            this.FotopictureBox.Name = "FotopictureBox";
            this.FotopictureBox.Size = new System.Drawing.Size(140, 124);
            this.FotopictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotopictureBox.TabIndex = 12;
            this.FotopictureBox.TabStop = false;
            // 
            // UsuariosDataGridView
            // 
            this.UsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariosDataGridView.Location = new System.Drawing.Point(-2, 241);
            this.UsuariosDataGridView.Name = "UsuariosDataGridView";
            this.UsuariosDataGridView.Size = new System.Drawing.Size(543, 257);
            this.UsuariosDataGridView.TabIndex = 19;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(540, 498);
            this.Controls.Add(this.UsuariosDataGridView);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.Modificarbutton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.AdjuntarFotobutton);
            this.Controls.Add(this.FotopictureBox);
            this.Controls.Add(this.EstaActivoCheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RolComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CorreoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ContraseñaTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CodigoTextBox);
            this.Controls.Add(this.label1);
            this.Name = "UsuariosForm";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.FotopictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodigoTextBox;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ContraseñaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CorreoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox RolComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox EstaActivoCheckBox;
        private System.Windows.Forms.PictureBox FotopictureBox;
        private System.Windows.Forms.Button AdjuntarFotobutton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button Modificarbutton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.DataGridView UsuariosDataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}