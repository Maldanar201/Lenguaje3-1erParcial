using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class BuscarServicioForm : Form
    {
        public BuscarServicioForm()
        {
            InitializeComponent();
        }

        ServiciosDB serviciosDB = new ServiciosDB();
        public Servicios servicios = new Servicios();

        private void BuscarProductoForm_Load(object sender, EventArgs e)
        {
            productosDataGridView.DataSource = serviciosDB.DevolverServicios();
        }

        private void DescripcionTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            productosDataGridView.DataSource = serviciosDB.DevolverServiciosPorDescripcion(DescripcionTextBox.Text);
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if(productosDataGridView.RowCount > 0)
            {
                if(productosDataGridView.SelectedRows.Count > 0) 
                {
                    servicios.Codigo = productosDataGridView.CurrentRow.Cells["Codigo"].Value.ToString();
                    servicios.Descripcion = productosDataGridView.CurrentRow.Cells["Descripcion"].Value.ToString();
                    servicios.Categoria = productosDataGridView.CurrentRow.Cells["Categoria"].Value.ToString();
                    servicios.Precio = Convert.ToDecimal(productosDataGridView.CurrentRow.Cells["Precio"].Value);
                    servicios.EstaActivo = Convert.ToBoolean(productosDataGridView.CurrentRow.Cells["EstaActivo"].Value);
                    Close();
                }
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
