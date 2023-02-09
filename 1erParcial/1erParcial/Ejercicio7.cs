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
    public partial class Ejercicio7 : Form
    {
        public Ejercicio7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Matriz

            int[,] matriz1 = new int[3, 3]
            {
                {3,0,3},
                {4,1,4},
                {5,2,5}
            };

            //int[,] matriz2 = new int[3, 4];
            //Random random = new Random();
            //// AL CONCER EL TAMAÑO DE LA MATRIZ UTILIZAMOS
            //for (int fila = 0; fila < 3; fila++)
            //{
            //    for (int columna = 0; columna < 4; columna++)
            //    {

            //    }
            //}


            // CUANDO DESCONOCEMOS EL TAMAÑO DE LA MATRIZ UTILIZAMOS
            //() dentro del argumento utilizamos (0) para Filas, (1) para columnas
            listBox1.Items.Clear();

            Random random = new Random();
            int rfila = random.Next(1,10); // los parametros limitan los numeros que puede asignar la funcion randon
            int rcolumna = random.Next(1,10);

            int[,] matriz2 = new int[rfila, rcolumna];
            

            for (int fila = 0; fila < matriz2.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz2.GetLength(1); columna++)
                {
                    matriz2[fila, columna] = random.Next(1, 99); // llena la matriz
                }
            }

            // Mostras los valores de la matriz en un listbox
            for (int fila = 0; fila < matriz2.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz2.GetLength(1); columna++)
                {
                    listBox1.Items.Add(" La posición : [ " + fila + " , " + columna + " ]" + matriz2[fila,columna]);
                };
            }

            textBox1.Text = matriz2.GetLength(0).ToString() + " X " + matriz2.GetLength(1).ToString();
        }
    }
}
