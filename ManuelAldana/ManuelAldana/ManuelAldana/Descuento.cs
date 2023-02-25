using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManuelAldana
{
    public partial class Descuento : Form
    {
        public Descuento()
        {
            InitializeComponent();
        }

        private void Salirbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
                
        private async void agragarButton_Click(object sender, EventArgs e)
        {
            if(NombreTextBox.Text == string.Empty) 
            {
                errorProvider1.SetError(NombreTextBox, " Ingrese un Producto");
                return;
            }
           
            if (NombreTextBox2.Text == string.Empty)
            {
                errorProvider1.SetError(NombreTextBox2, " Ingrese un Producto");
                return;
            }           
            if(PrecioTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(PrecioTextBox, " Ingrese un Producto");
                return;
            }
            if (PrecioTextBox2.Text == string.Empty)
            {
                errorProvider1.SetError(PrecioTextBox2, " Ingrese un Producto");
                return;
            }
            errorProvider1.Clear();
            listarDatos();                 
                  
        }

        private async void listarDatos()
        {
            int renglon = ProductosDataGridView.Rows.Add();
            int renglon2 = ProductosDataGridView.Rows.Add();
            ProductosDataGridView.Rows[renglon].Cells[0].Value = NombreTextBox.Text;
            ProductosDataGridView.Rows[renglon].Cells[1].Value = PrecioTextBox.Text;
            ProductosDataGridView.Rows[renglon2].Cells[0].Value = NombreTextBox2.Text;
            ProductosDataGridView.Rows[renglon2].Cells[1].Value = PrecioTextBox2.Text;
            SumarColumna();
            LimpiarControles();
            NombreTextBox.Focus();
        }
        private async void SumarColumna ()
        {
            decimal sumaProductos = 0;
            decimal descuento = 0.15M;
            decimal descuentoTotal = 0;
            decimal TotalCliente = 0;
            foreach(DataGridViewRow row in ProductosDataGridView.Rows) 
            {
                sumaProductos += Convert.ToDecimal(row.Cells[1].Value);
            }

            descuentoTotal = sumaProductos * descuento;
            TotalCliente = sumaProductos - descuentoTotal;

            DescuentoTextBox.Text = descuentoTotal.ToString();
            TotaltextBox.Text = TotalCliente.ToString();
            
        }
        private void LimpiarControles()
        {
            NombreTextBox.Clear();
            PrecioTextBox.Clear();
            NombreTextBox2.Clear();
            PrecioTextBox2.Clear();
        }

        private void PrecioTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(PrecioTextBox.Text, "[^0-9,.]"))
            {
                MessageBox.Show("Por Favor Ingrese un valor Numerico.");
                PrecioTextBox.Text = PrecioTextBox.Text.Remove(PrecioTextBox.Text.Length - 1);
            }
        }

        private void PrecioTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(PrecioTextBox2.Text, "[^0-9,.]"))
            {
                MessageBox.Show("Por Favor Ingrese un valor Numerico.");
                PrecioTextBox2.Text = PrecioTextBox2.Text.Remove(PrecioTextBox2.Text.Length - 1);
            }
        }
    }
}
