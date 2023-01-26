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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        decimal SumaTotal = 0;

        private void SUMARBoton_Click(object sender, EventArgs e)
        {
            // Variables
            //tipo variable, Nombre variable = pasar texto a decimal(cactura de datos a convertir)
            decimal Numero1 = Convert.ToDecimal(Numero1textBox.Text);
            decimal Numero2 = Convert.ToDecimal(Numero2textBox.Text);

            //// Operacion
            //decimal resultado = Numero1+ Numero2;

            //// mostrar mensaje en pantalla ventana emergente
            //MessageBox.Show("La suma es : " + resultado);
            
            // llamada de proceso Suma
            //Suma(Numero1,Numero2);

            SumaTotal = Sumatoria(Numero1, Numero2);

            //mostar en pantalla("respuesta", "TITULO", boton de aceptar, icono en la ventana emergente); 
            MessageBox.Show(" La Suma es : " + SumaTotal, " Mensaje ", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        //PROCEDIMIENTO
        private void Suma(decimal num1, decimal num2) 
        {
            SumaTotal = num1 + num2;
        }

        // FUNCION
        private decimal Sumatoria(decimal num1, decimal num2) 
        {
            return num1 + num2;
        }
    }
}
