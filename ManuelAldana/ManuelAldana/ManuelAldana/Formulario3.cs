using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManuelAldana
{
    public partial class Formulario3 : Form
    {
        List<string> listmensaje = new List<string>();
        public Formulario3()
        {
            InitializeComponent();
        }

        private void salirButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ejecutarButton_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(nombreTextBox, " Ingrese un Producto");
                return;
            }

            if (ApellidoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(ApellidoTextBox, " Ingrese un Producto");
                return;
            }            
            errorProvider1.Clear();
            
            for (int i = 0; i <= 100; i++)
            {
                string mensaje;
                string mensaje2 = i.ToString();
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    mensaje = mensaje2 + " " + nombreTextBox.Text + " " + ApellidoTextBox.Text;
                }
                else if(i % 3 == 0)
                {
                    mensaje = " " + mensaje2 + " " + nombreTextBox.Text;
                }else if(i % 5 == 0)
                {
                    mensaje = " " + mensaje2 + " " + ApellidoTextBox.Text;
                }             
                else
                {
                    mensaje = " " + mensaje2;
                }
                
                listmensaje.Add(mensaje);
                listBox1.DataSource = null;
                listBox1.DataSource = listmensaje;
            }
        }
        
    }
}
