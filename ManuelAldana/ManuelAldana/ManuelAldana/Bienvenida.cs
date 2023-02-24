using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManuelAldana
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void interesesButton_Click(object sender, EventArgs e)
        {
            
            Interes interesFormulario = new Interes();
            interesFormulario.Show();
            
        }

        private void desceuntoButton_Click(object sender, EventArgs e)
        {
           
            Descuento descuentoFormulario = new Descuento();
            descuentoFormulario.Show();
        }

        private void formulario3Button_Click(object sender, EventArgs e)
        {
            
            Formulario3 formulario3 = new Formulario3();
            formulario3.Show();
        }
        
    }
}
