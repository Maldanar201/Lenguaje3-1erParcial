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
    public partial class ServiciosForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public ServiciosForm()
        {
            InitializeComponent();
        }

        string TipoOperacion;
        Servicios servicios;
        ServiciosDB serviciosDB = new ServiciosDB();
        
        private void habilitarControles()
        {
            CodigoTextBox.Enabled = true;
            DescripcionTextBox.Enabled = true;
            categoriaComboBox.Enabled = true;
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
            categoriaComboBox.Enabled = false;
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
            categoriaComboBox = null;
            PrecioTextBox.Clear();
            EstaActivoChekbox.Checked = false;
            FotoProductopictureBox.Image = null;
            servicios = null;
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
            if(ServiciosDataGridView.SelectedRows.Count > 0)
            {
                CodigoTextBox.Text = ServiciosDataGridView.CurrentRow.Cells["Codigo"].Value.ToString();
                DescripcionTextBox.Text = ServiciosDataGridView.CurrentRow.Cells["Descripcion"].Value.ToString();
                categoriaComboBox.Text = ServiciosDataGridView.CurrentRow.Cells["Categoria"].Value.ToString();
                PrecioTextBox.Text = ServiciosDataGridView.CurrentRow.Cells["Precio"].Value.ToString();
                EstaActivoChekbox.Checked = Convert.ToBoolean(ServiciosDataGridView.CurrentRow.Cells["EstaActivo"].Value);

                byte[] img = serviciosDB.DevolverFoto(ServiciosDataGridView.CurrentRow.Cells["Codigo"].Value.ToString());

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
            servicios = new Servicios();
            servicios.Codigo = CodigoTextBox.Text;
            servicios.Descripcion = DescripcionTextBox.Text;
            servicios.Categoria = categoriaComboBox.Text;
            servicios.Precio = Convert.ToDecimal(PrecioTextBox.Text);
            servicios.EstaActivo = EstaActivoChekbox.Checked;

            if (FotoProductopictureBox.Image != null) // si pictureBox no esta vacio
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(); // captura y combierte el string a una imagen, o a otro archivo segun necesitemos
                FotoProductopictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);// al imagen del pictubox se la asigna a la variable ms en el formato elegido
                servicios.imagenComponente = ms.GetBuffer(); // asigna el arreglo de byte a la variable de la clase usuarios
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
                    errorProvider1.SetError(DescripcionTextBox, " Ingrese una Descripcion o nombre del servicio ");
                    DescripcionTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(categoriaComboBox.Text)) // si el texbox esta nulo o vacio 
                {
                    errorProvider1.SetError(categoriaComboBox, " Ingrese Una categoria del servicio ");
                    categoriaComboBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(PrecioTextBox.Text)) // si el texbox esta nulo o vacio 
                {
                    errorProvider1.SetError(PrecioTextBox, " Ingrese un precio para el servicio ");
                    PrecioTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();                

                bool inserto = serviciosDB.Insertar(servicios);
                if(inserto)
                {
                    deshabilitarControles();
                    limpiarControles();
                    TraerServicios();
                    MessageBox.Show(" Registro Guardado con Exito.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    MessageBox.Show(" No se pudo Guardar el Registro.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if(TipoOperacion == "Modificar")
            {
                bool modifico = serviciosDB.Editar(servicios);
                if (modifico)
                {
                    CodigoTextBox.ReadOnly = false;
                    deshabilitarControles();
                    limpiarControles();
                    TraerServicios();
                    MessageBox.Show(" Registro se Actualizo con Exito.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(" No se pudo Actualizar el Registro.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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
            TraerServicios();
        }

        private void TraerServicios()
        {
            ServiciosDataGridView.DataSource = serviciosDB.DevolverServicios();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (ServiciosDataGridView.SelectedRows.Count > 0)
            {
                //Valida si esta seguro de eliminar el registro
                DialogResult resultado = MessageBox.Show(" Esta seguro de eliminar el registro ", " ADVERTENCIA ", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes) // si afirma la eliminacion procede
                {
                    // valida el codigo selecionado para eliminarlo
                    bool elimino = serviciosDB.Eliminar(ServiciosDataGridView.CurrentRow.Cells["Codigo"].Value.ToString());
                    if (elimino)
                    {
                        limpiarControles();
                        deshabilitarControles();
                        TraerServicios(); // actualiza la BD y el datagrid de pantalla
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
