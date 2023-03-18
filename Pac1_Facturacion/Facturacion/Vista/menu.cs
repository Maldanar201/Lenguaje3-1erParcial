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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void UsuariosToolStripButton1_Click(object sender, EventArgs e)
        {
            UsuariosForm userForm = new UsuariosForm();
            userForm.MdiParent = this;
            userForm.Show();
        }

        private void ProductosToolStripButton1_Click(object sender, EventArgs e)
        {
            ProductosForm productosForm = new ProductosForm();
            productosForm.MdiParent = this;
            productosForm.Show();
        }

        private void ClientesToolStripButton1_Click(object sender, EventArgs e)
        {
            ClientesForm clientesForm = new ClientesForm();
            clientesForm.MdiParent = this;
            clientesForm.Show();
        }

        private void nuevaFacturaToolStripButton1_Click(object sender, EventArgs e)
        {
            facturaForm form = new facturaForm();
            form.MdiParent = this;
            form.Show();
        }
    }
}
