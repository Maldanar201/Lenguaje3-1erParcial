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
        public Clientes Cliente = new Clientes(); // objeto que cargaremos para mostrar clientes en el dataGrid
        private void BuscarClienteForm_Load(object sender, EventArgs e)
        {
            clientesDataGridView.DataSource = clientesDB.DevolverClientes();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if(clientesDataGridView.SelectedRows.Count > 0) 
            {
                Cliente.ID = clientesDataGridView.CurrentRow.Cells["ID"].Value.ToString();
                Cliente.Nombre = clientesDataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                Cliente.Telefono = clientesDataGridView.CurrentRow.Cells["Telefono"].Value.ToString();
                Cliente.Direccion = clientesDataGridView.CurrentRow.Cells["Diereccion"].Value.ToString();
                Cliente.Correo = clientesDataGridView.CurrentRow.Cells["Correo"].Value.ToString();
                Cliente.FechaNacimiento = Convert.ToDateTime(clientesDataGridView.CurrentRow.Cells["FechaNacimiento"].Value);
                Cliente.EstaActivo = Convert.ToBoolean(clientesDataGridView.CurrentRow.Cells["EstaActivo"].Value);
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
