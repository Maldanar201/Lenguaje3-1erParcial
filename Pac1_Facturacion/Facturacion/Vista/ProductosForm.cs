using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Vista
{
    public partial class ProductosForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public ProductosForm()
        {
            InitializeComponent();
        }

        string TipoOperacion;
        Producto producto;
        ProductoDB productoDB = new ProductoDB();
        
        private void habilitarControles()
        {
            CodigoTextBox.Enabled = true;
            DescripcionTextBox.Enabled = true;
            ExistenciaTextBox.Enabled = true;
            PrecioTextBox.Enabled = true;            
            AdjuntarButton.Enabled = true;
            GuardarButton.Enabled = true;
            CancelarButton.Enabled = true;
            NuevoButton.Enabled = false;
        }

        private void deshabilitarControles()
        {
            CodigoTextBox.Enabled = false;
            DescripcionTextBox.Enabled = false;
            ExistenciaTextBox.Enabled = false;
            PrecioTextBox.Enabled = false;
            AdjuntarButton.Enabled = false;
            GuardarButton.Enabled = false;
            CancelarButton.Enabled = false;
            NuevoButton.Enabled = true;
        }

        private void limpiarControles()
        {
            CodigoTextBox.Clear();
            DescripcionTextBox.Clear();
            ExistenciaTextBox.Clear();
            PrecioTextBox.Clear();
            EstaActivoChekbox.Checked = false;
            FotoProductopictureBox.Image = null;
            producto = null;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            CodigoTextBox.Focus();// foco en el primer texvox
            habilitarControles();//habilita los controles
            TipoOperacion = "Nuevo";// asigna valor a la variable para hacer tarea en botron guardar
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            deshabilitarControles(); // deshabilita controles
            limpiarControles(); // limpia el texto ingresado en los controles
        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            TipoOperacion = "Modificar"; // asigna valor a la variable para saber que hacer en boton guardar
            if(ProductosDataGridView.SelectedRows.Count > 0)
            {
                CodigoTextBox.Text = ProductosDataGridView.CurrentRow.Cells["Codigo"].Value.ToString();
                DescripcionTextBox.Text = ProductosDataGridView.CurrentRow.Cells["Descripcion"].Value.ToString();
                ExistenciaTextBox.Text = ProductosDataGridView.CurrentRow.Cells["Existencia"].Value.ToString();
                PrecioTextBox.Text = ProductosDataGridView.CurrentRow.Cells["Precio"].Value.ToString();
                EstaActivoChekbox.Checked = Convert.ToBoolean(ProductosDataGridView.CurrentRow.Cells["EstaActivo"].Value);

                byte[] img = productoDB.DevolverFoto(ProductosDataGridView.CurrentRow.Cells["Codigo"].Value.ToString());

                if(img.Length > 0)
                {
                    MemoryStream ms = new MemoryStream();
                    FotoProductopictureBox.Image = System.Drawing.Bitmap.FromStream(ms);
                }
                habilitarControles();
                CodigoTextBox.ReadOnly = true;
            }
            else
            {
                MessageBox.Show(" Debe seleccionar un Registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            producto = new Producto();
            producto.Codigo = CodigoTextBox.Text;
            producto.Decripcion = DescripcionTextBox.Text;
            producto.Existencia = Convert.ToInt32(ExistenciaTextBox.Text);
            producto.Precio = Convert.ToDecimal(PrecioTextBox.Text);
            producto.EstaActivo = EstaActivoChekbox.Checked;

            if (FotoProductopictureBox.Image != null) // si pictureBox no esta vacio
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(); // captura y combierte el string a una imagen, o a otro archivo segun necesitemos
                FotoProductopictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);// al imagen del pictubox se la asigna a la variable ms en el formato elegido
                producto.imagenProducto = ms.GetBuffer(); // asigna el arreglo de byte a la variable de la clase usuarios
            }

            if (TipoOperacion == "Nuevo")
            {
                if (string.IsNullOrEmpty(CodigoTextBox.Text)) // si el texbox esta nulo o vacio 
                {
                    errorProvider1.SetError(CodigoTextBox, " Ingrese un Codigo ");
                    CodigoTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(DescripcionTextBox.Text)) // si el texbox esta nulo o vacio 
                {
                    errorProvider1.SetError(DescripcionTextBox, " Ingrese una Descripcion o nombre del producto ");
                    DescripcionTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(ExistenciaTextBox.Text)) // si el texbox esta nulo o vacio 
                {
                    errorProvider1.SetError(ExistenciaTextBox, " Ingrese las existencias del Producto ");
                    ExistenciaTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(PrecioTextBox.Text)) // si el texbox esta nulo o vacio 
                {
                    errorProvider1.SetError(PrecioTextBox, " Ingrese un precio para el producto ");
                    PrecioTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();                

                bool inserto = productoDB.Insertar(producto);
                if(inserto)
                {
                    deshabilitarControles();
                    limpiarControles();
                    TraerProductos();
                    MessageBox.Show(" Registro Guardado con Exito.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    MessageBox.Show(" No se pudo Guardar el Registro.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if(TipoOperacion == "Modificar")
            {
                bool modifico = productoDB.Editar(producto);
                if (modifico)
                {
                    CodigoTextBox.ReadOnly = false;
                    deshabilitarControles();
                    limpiarControles();
                    TraerProductos();
                    MessageBox.Show(" Registro se Actualizo con Exito.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(" No se pudo Actualizar el Registro.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        // Validar los valores a ingresar en un Textbox
        private void ExistenciaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar)) //si el caracter es distinto de un numero e esta bloqueado
            {
                e.Handled = true; // permite ingresar el numero
            }
        }

        private void PrecioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit((char)e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '\b')) // si el caracter es diferente de numero y diferente de punto, no los permite
            {
                e.Handled = true; // si es numero o punto si lo permite
            }

            if((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.')> -1)// valida si ya existe un punto le reste y no le permita ingresar otro punto
            {
                e.Handled = true;
            }
        }

        private void AdjuntarButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog(); // abre una ventana del explorador del sistema operativo
            DialogResult resultado = dialog.ShowDialog(); // asigna a la variable y muestra la captura de la imagen en en ella

            if (resultado == DialogResult.OK)
            {
                FotoProductopictureBox.Image = Image.FromFile(dialog.FileName); // asigna la imagen en el pictureBox
            }
        }

        private void ProductosForm_Load(object sender, EventArgs e)
        {
            TraerProductos();
        }

        private void TraerProductos()
        {
            ProductosDataGridView.DataSource = productoDB.DevolverProducto();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (ProductosDataGridView.SelectedRows.Count > 0)
            {
                //Valida si esta seguro de eliminar el registro
                DialogResult resultado = MessageBox.Show(" Esta seguro de eliminar el registro ", " ADVERTENCIA ", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes) // si afirma la eliminacion procede
                {
                    // valida el codigo selecionado para eliminarlo
                    bool elimino = productoDB.Eliminar(ProductosDataGridView.CurrentRow.Cells["Codigo"].Value.ToString());
                    if (elimino)
                    {
                        limpiarControles();
                        deshabilitarControles();
                        TraerProductos(); // actualiza la BD y el datagrid de pantalla
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
