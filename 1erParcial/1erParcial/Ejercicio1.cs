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

        private void SUMARBoton_Click(object sender, EventArgs e)
        {
            decimal Numero1 = Convert.ToDecimal(Numero1textBox.Text);
            decimal Numero2 = Convert.ToDecimal(Numero2textBox.Text);

            decimal resultado = Numero1+ Numero2;

            MessageBox.Show("La suma es : " + resultado);
        }
    }
}
