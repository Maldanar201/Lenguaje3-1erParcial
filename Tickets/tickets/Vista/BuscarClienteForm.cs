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
    public partial class BuscarClienteForm : Form
    {
        public BuscarClienteForm()
        {
            InitializeComponent();
        }

        ClientesDB clientesDB = new ClientesDB();
        public Clientes cliente = new Clientes(); // objeto que cargaremos para mostrar clientes en el dataGrid
        private void BuscarClienteForm_Load(object sender, EventArgs e)
        {
            clientesDataGridView.DataSource = clientesDB.DevolverClientes();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if(clientesDataGridView.SelectedRows.Count > 0) 
            {
                cliente.ID = clientesDataGridView.CurrentRow.Cells["IDcliente"].Value.ToString();
                cliente.Nombre = clientesDataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                cliente.Telefono = clientesDataGridView.CurrentRow.Cells["Telefono"].Value.ToString();
                cliente.Direccion = clientesDataGridView.CurrentRow.Cells["Direccion"].Value.ToString();
                cliente.Correo = clientesDataGridView.CurrentRow.Cells["Correo"].Value.ToString();
                cliente.FechaNacimiento = Convert.ToDateTime(clientesDataGridView.CurrentRow.Cells["FechaNacimiento"].Value);
                cliente.EstaActivo = Convert.ToBoolean(clientesDataGridView.CurrentRow.Cells["EstaActivo"].Value);
                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NombreTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            clientesDataGridView.DataSource = clientesDB.DevolverClientesPorNombre(NombreTextBox.Text);
        }
    }
}
