using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            // validadcion de las cajas de usuario y contraseña
            if(UsuarioTextBox.Text == string.Empty) 
            {
                errorProvider1.SetError(UsuarioTextBox, " Ingrese su Codigo de Usuario ");
                UsuarioTextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if(string.IsNullOrEmpty(ContraseñaTextBox.Text) )
            {
                errorProvider1.SetError(UsuarioTextBox, " Ingrese su Contraseña ");
                ContraseñaTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            // VALIDAR EN LA BASE DE DATOS

            Login login = new Login( UsuarioTextBox.Text, ContraseñaTextBox.Text); // abre una nueva sesion con la informacion del textbox
            Usuarios usuario = new Usuarios(); //instancia un  nuevo usuario del objeto usuario
            UsuariosDB usuarioDB = new UsuariosDB();// instancia un nuevo usuario en la base de datos

            usuario = usuarioDB.Autentificar(login); // asigna el valor de suarioDB a el objeto usuario auntenticando si existe con el metodo login

            if(usuario != null) // si el usuario no esta vacio
            {
                if (usuario.EstaActivo)
                {
                    //MOSTRAR EL MENU
                    menu menuFormularios = new menu(); // instancia un nuevo menu de formulario
                    Hide(); // oculta la ventana de logueo
                    menuFormularios.Show(); // muestra la ventana del menu de formularios
                }
                else
                {
                    MessageBox.Show( " El Usuario NO esta Activo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show(" El Usuario ó Contraseña son incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        // habilitar boton ver contraseña
        private void MostrarContraseñabutton_Click(object sender, EventArgs e)
        {
            if(ContraseñaTextBox.PasswordChar == '*') //si la caja de texto es igual a ** o caracter de oculatacio
            {
                ContraseñaTextBox.PasswordChar = '\0'; // al precionar muestra la contraseña
            }
            else
            {
                ContraseñaTextBox.PasswordChar = '*';// vuelve a acultar
            }
        }
    }
}
