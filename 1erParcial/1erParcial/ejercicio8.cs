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
    public partial class Ejercicio8 : Form
    {
        public Ejercicio8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RecorrerUnoEnUno(1, 100);
        }

        private void RecorrerUnoEnUno(int valorInicial, int valorFinal) 
        {
            listBox1.Items.Add(valorInicial);

            if(valorInicial < valorFinal) 
            {
                RecorrerUnoEnUno(valorInicial + 1, valorFinal);
            }
        }
    }
}
