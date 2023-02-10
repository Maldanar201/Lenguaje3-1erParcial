using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POO;

namespace _1erParcial
{
    public partial class Ejercicio9 : Form
    {
        public Ejercicio9()
        {
            InitializeComponent();
        }

        Coche miCoche = null; // instanciar el objeto para no recargar en el programa
        List<Coche> ListaCoches = new List<Coche>(); // declaramos una lista que contiene los obtetos de la clase coches
        private void button1_Click(object sender, EventArgs e)
        {
            //Coche miCoche = new Coche();
            //Coche miCoche2 = new Coche("Toyota","Corolla S");

            //Asignamos valores a las variables para inicializar objetos
            string marca = MarcatextBox.Text;
            string modelo = ModelotextBox.Text;
            decimal precio;
            if(PreciotextBox.Text == string.Empty) 
            {
                precio = 0;
            }
            else
            {
                precio = Convert.ToDecimal(PreciotextBox.Text);
            }
            //OPERADOR TERNARIO
            int kilometros = KilometrostextBox.Text == string.Empty ? 0 : Convert.ToInt32(KilometrostextBox.Text);

            miCoche = new Coche(); // inicializamos un objeto de la clase Coche

            miCoche.Marca = marca;
            miCoche.Modelo = modelo;
            miCoche.Precio = precio;
            miCoche.Kilometros= kilometros;

            ListaCoches.Add(miCoche); // agrega objetos a la lista
            CocheDataGridView.DataSource = null; // Limpia el contenido de la tabla
            CocheDataGridView.DataSource = ListaCoches; // agrega la lista a la tabla

            LimpiarControles(); // llamada a metodo para limpiar controles
            MarcatextBox.Focus();// lleva el tabulador o foco a donde lo deseamos
        }

        private void LimpiarControles()
        {
            MarcatextBox.Text = string.Empty;
            ModelotextBox.Text = "";
            PreciotextBox.Clear();
            KilometrostextBox.Clear();
        }
    }
}
