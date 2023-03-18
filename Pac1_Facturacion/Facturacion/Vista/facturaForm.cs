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
        Producto miProducto = null;
        ProductoDB productoDB = new ProductoDB();
        List<DetalleFactura> listaDetalles = new List<DetalleFactura>();
        decimal subtotal = 0;
        decimal isv = 0;
        decimal totalApagar = 0;
        decimal descuento = 0;

        //ingresar clientes en el formulario factura
        private void IDClienteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(IDClienteTextBox.Text)) // si presiona tecla enter
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
        //Busca Clientes en la base de datos
        private void buscarClienteButton_Click(object sender, EventArgs e)
        {
            BuscarClienteForm form = new BuscarClienteForm();
            form.ShowDialog(); // mustra el formulario en formato de dialogo no permite hacer nada mas en el sistema
            miCliente = new Clientes();
            miCliente = form.cliente;
            IDClienteTextBox.Text = miCliente.ID;
            NombreClienteTextBox.Text = miCliente.Nombre;
        }
        // Al cargar el formulario de factura trae el codigo de usuario
        private void facturaForm_Load(object sender, EventArgs e)
        {
            UsuarioTextBox.Text = System.Threading.Thread.CurrentPrincipal.Identity.Name;
        }
        //Al ingresar un numero de producto trae los datos al formulario factura
        private void CodigoProductoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(CodigoProductoTextBox.Text)) // si presiona tecla enter
            {
                miProducto = new Producto();
                miProducto = productoDB.DevolverProductosPorCodigo(CodigoProductoTextBox.Text);
                DescripcionProductotextBox.Text = miProducto.Descripcion;
                existenciaTextBox.Text = miProducto.Existencia.ToString();
            }
            else
            {
                miProducto = null;
                DescripcionProductotextBox.Clear();
            }
        }

        private void buscarProductobutton_Click(object sender, EventArgs e)
        {
            BuscarProductoForm form = new BuscarProductoForm();
            form.ShowDialog();
            miProducto = new Producto();
            miProducto = form.producto;
            CodigoProductoTextBox.Text = miProducto.Codigo;
            DescripcionProductotextBox.Text = miProducto.Descripcion;
            existenciaTextBox.Text = miProducto.Existencia.ToString();
        }

        private void CantidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Al Precionar enter y cantidadtexbox no esta vacio continua..
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(CantidadTextBox.Text));
            {
                DetalleFactura detalle = new DetalleFactura();
                detalle.CodigoProducto = miProducto.Codigo;
                detalle.Cantidad = Convert.ToInt32(CantidadTextBox.Text);
                detalle.Precio = Convert.ToDecimal(miProducto.Precio);
                //Total es igual a la cantidad * el precio
                detalle.Total = Convert.ToInt32(CantidadTextBox.Text) * miProducto.Precio;

                subtotal += detalle.Total;
                isv = subtotal * 0.15M;
                totalApagar = subtotal + isv - descuento;

                listaDetalles.Add(detalle);
                detalleDataGridView.DataSource = null;
                detalleDataGridView.DataSource = listaDetalles;

                subTotalTextBox.Text = subtotal.ToString();
                isvTextBox.Text = isv.ToString();
                TotalTextBox.Text = totalApagar.ToString();

            }
        }
    }
}
