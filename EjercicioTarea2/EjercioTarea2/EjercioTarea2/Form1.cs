using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercioTarea2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private async void calcularButton_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Ingrese un Nombre");
                return;
            }
            string nombre = txtNombre.Text;
            decimal nota1 = Nota1txt.Text == string.Empty ? 0 : Convert.ToDecimal(Nota1txt.Text);
            decimal nota2 = Nota2txt.Text == string.Empty ? 0 : Convert.ToDecimal(Nota2txt.Text);
            decimal nota3 = Nota3txt.Text == string.Empty ? 0 : Convert.ToDecimal(Nota3txt.Text);
            decimal nota4 = Nota4txt.Text == string.Empty ? 0 : Convert.ToDecimal(Nota4txt.Text);

            decimal total = await SumarAsync(nota1, nota2, nota3, nota4);
            txtSuma.Text = total.ToString();
            decimal PromedioTotal = await PromedioAsyn(nota1, nota2, nota3, nota4);
            txtPromedio.Text = PromedioTotal.ToString();
        }

        private async Task<decimal> SumarAsync(decimal n1, decimal n2, decimal n3, decimal n4)
        {
            decimal suma = await Task.Run(() =>
            {
                return n1 + n2 + n3 + n4;
            });
            return suma;
        }
        private async Task<decimal> PromedioAsyn(decimal n1, decimal n2, decimal n3, decimal n4)
        {
            decimal Promedio = await Task.Run(() =>
            {
                return (n1 + n2 + n3 + n4) / 4;
            });
            return Promedio;
        }

        
        private async void NUEVObutton_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Ingrese un Nombre");
                return;
            }

            // adicionar renglon en la Tabla
            int renglon = PromedioAlumDataGridView.Rows.Add();
            //Agragar informacion en las celdas
            PromedioAlumDataGridView.Rows[renglon].Cells[0].Value = txtNombre.Text;
            PromedioAlumDataGridView.Rows[renglon].Cells[1].Value = Nota1txt.Text;
            PromedioAlumDataGridView.Rows[renglon].Cells[2].Value = Nota2txt.Text;
            PromedioAlumDataGridView.Rows[renglon].Cells[3].Value = Nota3txt.Text;
            PromedioAlumDataGridView.Rows[renglon].Cells[4].Value = Nota4txt.Text;
            PromedioAlumDataGridView.Rows[renglon].Cells[5].Value = txtSuma.Text;
            PromedioAlumDataGridView.Rows[renglon].Cells[6].Value = txtPromedio.Text;


            LimpiarControles();
        }

        private void LimpiarControles()
        {
            txtNombre.Clear();
            Nota1txt.Clear();
            Nota2txt.Clear();   
            Nota3txt.Clear();
            Nota4txt.Clear();
            txtPromedio.Clear();
            txtSuma.Clear();
            txtNombre.Focus();

        }

        
    }
}
