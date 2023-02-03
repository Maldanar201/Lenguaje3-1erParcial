using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            int numero = Convert.ToInt32(NumeroTextBox.Text);
            ParImpar(numero);
            negativoPositivo(numero);
        }

        private string ParImpar(int num1)
        {
            if(num1 % 2 == 0) 
            {
                return ParImpartextBox.Text = " el Numero " + num1 + " es Par.";
            }
            else
            {
                return ParImpartextBox.Text = " el Numero " + num1 + " es Impar.";
            }
        }

        private String negativoPositivo(int num)
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
    }
}
