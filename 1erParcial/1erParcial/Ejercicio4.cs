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
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            // cactura la fecha ingresada por el usuario en una variable
            DateTime fecha = FechaDateTimePicker.Value;

            // Extraer el dia apartir de una fecha
            DiaTextBox.Text = fecha.Day.ToString();
            // Extraer el Mes apartir de una fecha
            MesTextBox.Text = fecha.Month.ToString();
            // Extraer el año apartir de una fecha
            AnioTextBox.Text = fecha.Year.ToString();
            // Extraer el dia de la semana apartir de una fecha
            DiaSemanaTextBox.Text = fecha.DayOfWeek.ToString();
            // Extraer el Mes apartir de una fecha y obtener resultado en letras
            Mes2TextBox.Text = fecha.ToString("MMMM");
            // Extraer el dia de la semana apartir de una fecha y obtener resultado en letras
            DiaSemana2extBox.Text = fecha.ToString("dddd"); // usa idioma predeterminado del equipo en que se trabaja

            //Sumar o restar dias apartir de una fecha
            int numeroDias = Convert.ToInt32(DiasCitatextBox.Text);
            DateTime fechaActual = DateTime.Now;

            CitaTextBox.Text = fechaActual.AddDays(numeroDias).ToLongDateString();// Restar el argumento de AddDays se le antepone el signo negativo, ejemplo(-numerodias)
            //MessageBox.Show(" La Edad es : " + DevolverEdad(fecha)); //muestra edad en una caja de texto o advertencia
            EdadTextBox.Text = DevolverEdad(fecha).ToString();

        }

        private int DevolverEdad(DateTime FechaNacimiento)
        {
            DateTime FechaActual = DateTime.Now;
            int edad = 0;

            if(FechaNacimiento >= FechaActual) // validad fecha de nacimiento anterior a la actual
            {
                return 0;
            }
            else
            {
                edad = FechaActual.Year - FechaNacimiento.Year; // obtiene años
                if(FechaNacimiento > FechaActual) // equipara años si el mes aun no se cumple
                {
                    --edad;
                }
                return edad;
            }

        }

        private void DiaSemanaTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
