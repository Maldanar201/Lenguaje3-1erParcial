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
    public partial class Ejercicio6 : Form
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void ArreglosButton_Click(object sender, EventArgs e)
        {
            // VECTORES

            int[] vector = new int[5];

            vector[0] = 10;
            vector[1] = 20;
            vector[2] = 30;
            vector[3] = 50;
            vector[4] = 100;

            int[] vector2 = new int[5] {10,20,30,50,70};
            int[] vector3 = new int[] { 20, 30, 50, 60, 80, 90 };
            int[] vector4 = { 10, 20, 30, 50, 70 };

            string[] vector5 = { "Manuel", "Aida", "Emely", "Julieth" };

            for (int i = 0; i < vector5.Length; i++)
            {
                listBox1.Items.Add(vector5[i]);                
            }

            foreach (var item in vector5)
            {
                comboBox1.Items.Add(item);
            }
        }
    }
}
