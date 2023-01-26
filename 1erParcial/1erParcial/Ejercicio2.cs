using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1erParcial
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            if(Numero1textBox.Text == "")
            {
                errorProvider1.SetError(Numero1textBox, " Ingrese un Valor. ");
                return;
            }
            if (Numero2textBox.Text == "")
            {
                errorProvider1.SetError(Numero2textBox, " Ingrese un Valor. ");
                return;
            }
            if (OperacionesComboBox.Text == "")
            {
                errorProvider1.SetError(OperacionesComboBox, " Seleccione una Opción. ");
                return;
            }
            errorProvider1.Clear();

            decimal Numero1 = Convert.ToDecimal(Numero1textBox.Text);
            decimal Numero2 = Convert.ToDecimal(Numero2textBox.Text);
            decimal resultado = Ejecutar(Numero1,Numero2);

            Resultadolabel.Text = Convert.ToString(resultado);


        }

        private decimal Ejecutar(decimal num1,decimal num2) 
        {
            string operacion = OperacionesComboBox.Text;
            decimal resultado = 0;

            if (operacion == "SUMA")
                resultado = num1 + num2;
            else if(operacion == "RESTA")
                resultado = num1 - num2;
            else if(operacion == "MULTIPLICACION")
                resultado = num1 * num2;
            else if(operacion == "DIVISION")
                resultado = num1 / num2;

            return resultado;
        }

        private void OperacionesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
