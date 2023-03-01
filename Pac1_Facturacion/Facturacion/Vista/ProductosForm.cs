using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vista
{
    public partial class ProductosForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public ProductosForm()
        {
            InitializeComponent();
        }

        string TipoOperacion;
        private void habilitarControles()
        {
            CodigoTextBox.Enabled = true;
            DescripcionTextBox.Enabled = true;
            ExistenciaTextBox.Enabled = true;
            PrecioTextBox.Enabled = true;            
            AdjuntarButton.Enabled = true;
            GuardarButton.Enabled = true;
            CancelarButton.Enabled = true;
            NuevoButton.Enabled = false;
        }

        private void deshabilitarControles()
        {
            CodigoTextBox.Enabled = false;
            DescripcionTextBox.Enabled = false;
            ExistenciaTextBox.Enabled = false;
            PrecioTextBox.Enabled = false;
            AdjuntarButton.Enabled = false;
            GuardarButton.Enabled = false;
            CancelarButton.Enabled = false;
            NuevoButton.Enabled = true;
        }

        private void limpiarControles()
        {
            CodigoTextBox.Clear();
            DescripcionTextBox.Clear();
            ExistenciaTextBox.Clear();
            PrecioTextBox.Clear();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
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

        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            TipoOperacion = "Modificar"; // asigna valor a la variable para saber que hacer en boton guardar
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if(TipoOperacion == "Nuevo")
            {
                if (string.IsNullOrEmpty(CodigoTextBox.Text)) // si el texbox esta nulo o vacio 
                {
                    errorProvider1.SetError(CodigoTextBox, " Ingrese un Codigo ");
                    CodigoTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(DescripcionTextBox.Text)) // si el texbox esta nulo o vacio 
                {
                    errorProvider1.SetError(DescripcionTextBox, " Ingrese una Descripcion o nombre del producto ");
                    DescripcionTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(ExistenciaTextBox.Text)) // si el texbox esta nulo o vacio 
                {
                    errorProvider1.SetError(ExistenciaTextBox, " Ingrese las existencias del Producto ");
                    ExistenciaTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(PrecioTextBox.Text)) // si el texbox esta nulo o vacio 
                {
                    errorProvider1.SetError(PrecioTextBox, " Ingrese un precio para el producto ");
                    PrecioTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();
            }
            else if(TipoOperacion == "Modificar")
            {

            }
        }

        // Validar los valores a ingresar en un Textbox
        private void ExistenciaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar)) //si el caracter es distinto de un numero e esta bloqueado
            {
                e.Handled = true; // permite ingresar el numero
            }
        }

        private void PrecioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit((char)e.KeyChar) && (e.KeyChar != '.')) // si el caracter es diferente de numero y diferente de punto, no los permite
            {
                e.Handled = true; // si es numero o punto si lo permite
            }

            if((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.')> -1)// valida si ya existe un punto le reste y no le permita ingresar otro punto
            {
                e.Handled = true;
            }
        }
    }
}
