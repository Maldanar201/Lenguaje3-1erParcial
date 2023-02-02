using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1erParcial
{
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void HornearPizzaButton1_Click(object sender, EventArgs e)
        {
            HornearPizza();
            MessageBox.Show("Mensaje Normal");
        }

        private void HornearPizza()
        {
            Thread.Sleep(10000);
        }

        private Task HornearPizzaAsync()
        {
            return Task.Delay(10000);
        }
        private void HornearPizzaAsynButton2_Click(object sender, EventArgs e)
        {
            HornearPizzaAsync();
            MessageBox.Show("Mensaje Asincrono");
        }

        private async void SumarBoton_Click(object sender, EventArgs e)
        {
            decimal num1 = Convert.ToDecimal(Numero1textBox.Text);
            decimal num2 = Convert.ToDecimal(Numero2textBox.Text);

            decimal Total = await SumarAsync(num1, num2);

            MessageBox.Show($" La Suma es :{Total}");
        }

        private async Task<decimal> SumarAsync(decimal n1,decimal n2)
        {
            decimal suma = await Task.Run(() =>
            {
                return n1 + n2;
            });
            return suma;
        }
    }
}
