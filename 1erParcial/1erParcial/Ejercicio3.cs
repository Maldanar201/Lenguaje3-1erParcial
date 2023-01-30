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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void EjecutarButton1_Click(object sender, EventArgs e)
        {
            // almacenar el contenido de la caja de texto en una variable
            string cadena = CadenaTextBox.Text;

            //asigna a la caja de texto el numero de caracteres en la variable cadena
            //Caja texto = variable.propiedad.convertir entero a string
            LongitudTextBox.Text = cadena.Length.ToString();
            //Propiedad length obtiene el numero de cacracteres que conforman una cadena de texto la longitud
            //ToString() metodo para convertir un numero a una cadena de texto

            //EXTRAER CARACTER  DE UNA CADENA
            // asigna a la caja de texto el primer caracter de la variable cadena
            PrimerCaracterTextBox.Text = cadena.Substring(0, 1);
            //Substring metodo para obtener un caracter de una cadena mediante el parametro entre parentesis(0,1) primer caracter

            //Extraer el ultimo caracter de una cadena
            //el parametro indica :(La longitud total menos un, avanza un caracter)
            UltimoCaracterTextBox.Text = cadena.Substring(cadena.Length - 1,1);
            

            //CONVERTIR UNA CADENA A TODO MAYUSCULAS
            //Asigna a la caja de texto el contenido de la variable cadena en mayusculas, utilizando el metodo ToUpper
            MayusculasTextBox.Text = cadena.ToUpper();

            //CONVERTIR UNA CADENA A TODO MINUSCULAS
            //Asigna a la caja de texto el contenido de la variable cadena en minusculas, utilizando el metodo ToLower
            MinusculasTextBox.Text = cadena.ToLower();

            //REMPLAZAR UNA CADENA DE TEXTO
            RemplazarTextBox.Text = cadena.Replace("Carlos", "GUEY");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
