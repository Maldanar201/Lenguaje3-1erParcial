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
    public partial class BuscarProductoForm : Form
    {
        public BuscarProductoForm()
        {
            InitializeComponent();
        }

        ProductoDB productoDB = new ProductoDB();
        public Producto producto = new Producto();

        private void BuscarProductoForm_Load(object sender, EventArgs e)
        {
            productosDataGridView.DataSource = productoDB.DevolverProducto();
        }

        private void DescripcionTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            productosDataGridView.DataSource = productoDB.DevolverProductoPorDescripcion(DescripcionTextBox.Text);
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if(productosDataGridView.RowCount > 0)
            {
                if(productosDataGridView.SelectedRows.Count > 0) 
                {
                    producto.Codigo = productosDataGridView.CurrentRow.Cells["Codigo"].Value.ToString();
                    producto.Descripcion = productosDataGridView.CurrentRow.Cells["Descripcion"].Value.ToString();
                    producto.Existencia = Convert.ToInt32(productosDataGridView.CurrentRow.Cells["Existencia"].Value);
                    producto.Precio = Convert.ToDecimal(productosDataGridView.CurrentRow.Cells["Precio"].Value);
                    producto.EstaActivo = Convert.ToBoolean(productosDataGridView.CurrentRow.Cells["EstaActivo"].Value);
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
