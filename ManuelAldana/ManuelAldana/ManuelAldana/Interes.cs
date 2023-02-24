using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace ManuelAldana
{
    public partial class Interes : Form
    {
        public Interes()
        {
            InitializeComponent();
        }

        private void regresarButton_Click(object sender, EventArgs e)
        {            
            Hide();          
           
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Close();       
            
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            decimal Valor = Convert.ToDecimal(ValorTextBox.Text);
            decimal Interes = Convert.ToDecimal(InteresTextBox.Text);
            decimal tiempo = Convert.ToDecimal(tiempoTextBox2.Text);

            for(int i = 0;i < tiempo; i++) 
            {
                decimal Total = Valor * (Interes / 100) * tiempo;
                Valor = Total;
            }
            
            
        }

        
    }
}
