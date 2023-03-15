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
    public partial class facturaForm : Form
    {
        public facturaForm()
        {
            InitializeComponent();
        }

        Clientes miCliente = null;
        ClientesDB clienteDB = new ClientesDB();

        private void IDClienteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter) // si presiona tecla enter
            {
                miCliente = new Clientes();
                miCliente = clienteDB.DevolverClientesPorIdentidad(IDClienteTextBox.Text);
                NombreClienteTextBox.Text = miCliente.Nombre;
            }
            else
            {
                miCliente = null;
                NombreClienteTextBox.Clear();
            }
        }

        private void buscarClienteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
