using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vista
{
    public partial class UsuariosForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }

        string TipoOperacion; // variable global para boton guardar
        DataTable dt = new DataTable(); // inicia la clase DateTable
        UsuariosDB usuarioDB = new UsuariosDB(); // instancia la clase Usuarios de la base de datos        
        Usuarios user = new Usuarios();// instancia la clase usuarios

        // Metodos de apoyo para habilitar y deshabilitar controles, lipiar controles
        private void habilitarControles()
        {
            CodigoTextBox.Enabled = true;
            UsuarioTextBox.Enabled = true;
            ContraseñaTextBox.Enabled = true;
            CorreoTextBox.Enabled = true;
            RolComboBox.Enabled = true;
            EstaActivoCheckBox.Enabled = true;
            AdjuntarFotobutton.Enabled = true;
            GuardarButton.Enabled = true;
            CancelarButton.Enabled = true;
            Modificarbutton.Enabled = false;
        }
        private void deshabilitarControles()
        {
            CodigoTextBox.Enabled = false;
            UsuarioTextBox.Enabled = false;
            ContraseñaTextBox.Enabled = false;
            CorreoTextBox.Enabled = false;
            RolComboBox.Enabled = false;
            EstaActivoCheckBox.Enabled = false;
            AdjuntarFotobutton.Enabled = false;
            GuardarButton.Enabled = false;
            CancelarButton.Enabled = false;
            Modificarbutton.Enabled = true;
        }

        private void limpiarControles()
        {
            CodigoTextBox.Clear();
            UsuarioTextBox.Clear();
            ContraseñaTextBox.Clear();
            CorreoTextBox.Clear();
            RolComboBox.Text = string.Empty;
            EstaActivoCheckBox.Checked = false;
            FotopictureBox.Image = null;
        }

        // Tareas que realizan los botones
        private void button1_Click(object sender, EventArgs e)
        {
            CodigoTextBox.Focus();// foco en el primer texvox
            habilitarControles();//habilita los controles
            TipoOperacion = "Nuevo";// asigna valor a la variable para hacer tarea en botron guardar
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            deshabilitarControles(); // deshabilita controles
            limpiarControles(); // limpia el texto ingresado en los controles
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if(TipoOperacion == "Nuevo") // se habilita cuando se ingresa informacion nueva
            {
                if(string.IsNullOrEmpty(CodigoTextBox.Text)) // si el texbox esta nulo o vacio 
                {
                    errorProvider1.SetError(CodigoTextBox, " Ingrese un Codigo ");
                    CodigoTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(UsuarioTextBox.Text)) // si el texbox esta nulo o vacio 
                {
                    errorProvider1.SetError(UsuarioTextBox, " Ingrese un Nombre de Usuario ");
                    UsuarioTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(ContraseñaTextBox.Text)) // si el texbox esta nulo o vacio 
                {
                    errorProvider1.SetError(ContraseñaTextBox, " Ingrese un Contraseña ");
                    ContraseñaTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(RolComboBox.Text)) // si el texbox esta nulo o vacio 
                {
                    errorProvider1.SetError(RolComboBox, " Selecione un Rol");
                    RolComboBox.Focus();
                    return;
                }
                errorProvider1.Clear();                
                
                // asigna valores capturados a las variables de la clase usuarios
                user.CodigoUsuario = CodigoTextBox.Text;
                user.Nombre = UsuarioTextBox.Text;
                user.Contraseña = ContraseñaTextBox.Text;
                user.Correo = CorreoTextBox.Text;
                user.Rol = RolComboBox.Text;
                user.EstaActivo = EstaActivoCheckBox.Checked;

                if(FotopictureBox.Image != null) // si pictureBox no esta vacio
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(); // captura y combierte el string a una imagen, o a otro archivo segun necesitemos
                    FotopictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);// al imagen del pictubox se la asigna a la variable ms en el formato elegido
                    user.Fotos = ms.GetBuffer(); // asigna el arreglo de byte a la variable de la clase usuarios
                }

                // INSERTAR EN LA BASE DE DATOS
                bool inserto = usuarioDB.Insertar(user);// valida si user trae datos y los asigna en la variable inserto

                if(inserto)
                {
                    limpiarControles();
                    deshabilitarControles();
                    TraerUsuarios();
                    MessageBox.Show(" Registro Guardado ");
                }
                else 
                {
                    MessageBox.Show(" No Se Pudo Guardar el Registro ");
                }

            }
            else if(TipoOperacion == "Modificar") // se habilita cuando se modifica informacion ya ingresada
            {

            }
        }
        

        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            TipoOperacion = "Modificar"; // asigna valor a la variable para saber que hacer en boton guardar
        }

        private void AdjuntarFotobutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog(); // abre una ventana del explorador del sistema operativo
            DialogResult resultado = dialog.ShowDialog(); // asigna a la variable y muestra la captura de la imagen en en ella

            if(resultado == DialogResult.OK) 
            {
                FotopictureBox.Image = Image.FromFile( dialog.FileName); // asigna la imagen en el pictureBox
            }
        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            TraerUsuarios();
        }

        private void TraerUsuarios()
        {
            dt = usuarioDB.DevolverUsuario();

            UsuariosDataGridView.DataSource = dt;
        }
    }
}
