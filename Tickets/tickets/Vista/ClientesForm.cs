using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        string TipoOperacion;
        Clientes cliente;
        ClientesDB clienteDB = new ClientesDB();

        private void habilitarControles()
        {
            NombreTextBox.Enabled = true;            
            idTextBox.Enabled = true;
            DireccionTextBox.Enabled = true;
            CorreotextBox.Enabled = true;
            telefonoTextBox.Enabled = true;
            EstaActivoChekbox.Enabled = true;
            fechaNacimientodateTimePicker.Enabled = true;
            GuardarButton.Enabled = true;
            CancelarButton.Enabled = true;
            NuevoButton.Enabled = false;
        }

        private void deshabilitarControles()
        {
            NombreTextBox.Enabled = false;            
            idTextBox.Enabled = false;
            DireccionTextBox.Enabled = false;
            CorreotextBox.Enabled = false;
            telefonoTextBox.Enabled = false;
            EstaActivoChekbox.Enabled = false;
            fechaNacimientodateTimePicker.Enabled = false;
            GuardarButton.Enabled = false;
            CancelarButton.Enabled = false;
            NuevoButton.Enabled = true;
        }

        private void limpiarControles()
        {
            NombreTextBox.Clear();
            idTextBox.Clear();
            DireccionTextBox.Clear();
            CorreotextBox.Clear();
            telefonoTextBox.Clear();
            EstaActivoChekbox.Checked = false;
            fechaNacimientodateTimePicker.CustomFormat = "";
            cliente = null;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            NombreTextBox.Focus(); // Foco en el primer texbox
            habilitarControles(); //habilita los texbos y controles
            TipoOperacion = "Nuevo"; // asigana valor a la variable, para utilizarla en guardar.
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            deshabilitarControles(); // deshabilita controles
            limpiarControles(); // limpia el texto ingresado en los controles
        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            TipoOperacion = "Modificar"; // asigna valor a la variable para saber que hacer en boton guardar
            if (ClientesDataGridView.SelectedRows.Count > 0) // al selecionar un registro asigna esos valores a los controles
            {
                idTextBox.Text = ClientesDataGridView.CurrentRow.Cells["IDCliente"].Value.ToString();
                NombreTextBox.Text = ClientesDataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                fechaNacimientodateTimePicker.Value = Convert.ToDateTime(ClientesDataGridView.CurrentRow.Cells["FechaNacimiento"].Value);
                DireccionTextBox.Text = ClientesDataGridView.CurrentRow.Cells["Direccion"].Value.ToString();
                CorreotextBox.Text = ClientesDataGridView.CurrentRow.Cells["Correo"].Value.ToString();
                telefonoTextBox.Text = ClientesDataGridView.CurrentRow.Cells["Telefono"].Value.ToString();
                EstaActivoChekbox.Checked = Convert.ToBoolean(ClientesDataGridView.CurrentRow.Cells["EstaActivo"].Value);

                habilitarControles();
                idTextBox.ReadOnly = true;
            }
            else
            {
                MessageBox.Show(" Debe seleccionar un Registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

            cliente = new Clientes();
            cliente.ID = idTextBox.Text;
            cliente.Nombre = NombreTextBox.Text;
            cliente.FechaNacimiento = fechaNacimientodateTimePicker.Value;
            cliente.Direccion = DireccionTextBox.Text;
            cliente.Correo = CorreotextBox.Text;
            cliente.Telefono = telefonoTextBox.Text;
            cliente.EstaActivo = EstaActivoChekbox.Checked;

            if (TipoOperacion == "Nuevo")
            {
                if (string.IsNullOrEmpty(NombreTextBox.Text)) // si el texbox esta nulo o vacio 
                {
                    errorProvider1.SetError(NombreTextBox, " Ingrese un Codigo ");
                    NombreTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(idTextBox.Text)) // si el texbox esta nulo o vacio 
                {
                    errorProvider1.SetError(idTextBox, " Ingrese una Descripcion o nombre del producto ");
                    idTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                

                bool inserto = clienteDB.Insertar(cliente);
                if (inserto)
                {
                    deshabilitarControles();
                    limpiarControles();
                    TraerClientes();
                    MessageBox.Show(" Registro Guardado con Exito.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(" No se pudo Guardar el Registro.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (TipoOperacion == "Modificar")
            {
                bool modifico = clienteDB.Editar(cliente);
                if (modifico)
                {
                    idTextBox.ReadOnly = false;
                    deshabilitarControles();
                    limpiarControles();
                    TraerClientes();
                    MessageBox.Show(" Registro se Actualizo con Exito.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(" No se pudo Actualizar el Registro.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }


        private void TraerClientes()
        {
            ClientesDataGridView.DataSource = clienteDB.DevolverClientes();
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            TraerClientes();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (ClientesDataGridView.SelectedRows.Count > 0)
            {
                //Valida si esta seguro de eliminar el registro
                DialogResult resultado = MessageBox.Show(" Esta seguro de eliminar el registro ", " ADVERTENCIA ", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes) // si afirma la eliminacion procede
                {
                    // valida el codigo selecionado para eliminarlo
                    bool elimino = clienteDB.Eliminar(ClientesDataGridView.CurrentRow.Cells["IDcliente"].Value.ToString());
                    if (elimino)
                    {
                        limpiarControles();
                        deshabilitarControles();
                        TraerClientes(); // actualiza la BD y el datagrid de pantalla
                        MessageBox.Show(" Registro Eliminado");
                    }
                    else
                    {
                        MessageBox.Show(" El Registro NO se pudo eliminar ");
                    }
                }
            }
            else
            {
                MessageBox.Show(" Debe Seleccionar un Registro ");
            }
        }
    }
}
