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
    public partial class Login : Form
    {
        public Login()
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

            //MOSTRAR EL MENU
            menu menuFormularios = new menu();
            Hide();
            menuFormularios.Show();


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
