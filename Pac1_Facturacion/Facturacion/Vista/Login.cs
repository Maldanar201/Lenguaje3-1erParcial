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

        }
    }
}
