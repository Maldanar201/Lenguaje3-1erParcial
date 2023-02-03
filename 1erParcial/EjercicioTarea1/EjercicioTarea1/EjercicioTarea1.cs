using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EjercicioTarea1
{
    public partial class EjercicioTarea1 : Form
    {
        public EjercicioTarea1()
        {
            InitializeComponent();
        }

        private void Ejecutarbutton_Click(object sender, EventArgs e)
        {
            // Valida que el campo a comprobar no este vacio
            if(NumeroTextBox.Text == "")
            {
                errorProvider1.SetError(NumeroTextBox, " Ingrese un Valor Numerico. ");
                return;
            }     
            errorProvider1.Clear();

            // inicializa el proceso
            int numero = Convert.ToInt32(NumeroTextBox.Text);            
            ParImpar(numero);
            negativoPositivo(numero);
        }

        //Proceso para validar numeros pares e impares
        private string ParImpar(int num1)
        {
            if(num1 % 2 == 0) 
            {
                return ParImpartextBox.Text = " El Numero " + num1 + " es Par.";
            }
            else
            {
                return ParImpartextBox.Text = " El Numero " + num1 + " es Impar.";
            }
        }
        //Proceso para validar si el numero es positivo o negativo
        private string negativoPositivo(int num)
        {
            if(num <= 0)
            {
                return PositivoNegativotextBox.Text = " El Numero " + num + " es Negativo";
            }
            else
            {
                return PositivoNegativotextBox.Text = " El Numero " + num + " es Positivo";
            }
        }
        // Restriccion en TexBox para permitir numeros unicamente
        private void NumeroTextBox_TextChanged(object sender, EventArgs e)
        {
            // Permitir unicamente los caracteres selecionados en la caja de texto, "[ejemplo]" lo que esta dentro
            if (System.Text.RegularExpressions.Regex.IsMatch(NumeroTextBox.Text, "[^0-9,-]"))
            {
                MessageBox.Show("Por Favor Ingrese un valor Numerico.");
                NumeroTextBox.Text = NumeroTextBox.Text.Remove(NumeroTextBox.Text.Length - 1);
            }
        }
    }
}
