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
    public partial class TicketsForm : Form
    {
        public TicketsForm()
        {
            InitializeComponent();
        }

        Clientes miCliente = null;
        ClientesDB clienteDB = new ClientesDB();
        Servicios miServicios = null;
        ServiciosDB serviciosDB = new ServiciosDB();
        List<DetalleTickets> listaDetalles = new List<DetalleTickets>();
        TicketsDB ticketsDB = new TicketsDB();
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
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(CodigoServicioTextBox.Text)) // si presiona tecla enter
            {
                miServicios = new Servicios();
                miServicios = serviciosDB.DevolverServiciosPorCodigo(CodigoServicioTextBox.Text);
                DescripcionServiciotextBox.Text = miServicios.Descripcion;
                SolicitudClienteTextBox.Text = miServicios.Categoria.ToString();
            }
            else
            {
                miServicios = null;
                DescripcionServiciotextBox.Clear();
                SolicitudClienteTextBox.Clear();
            }
        }

        private void buscarProductobutton_Click(object sender, EventArgs e)
        {
            BuscarServicioForm form = new BuscarServicioForm();
            form.ShowDialog();
            miServicios = new Servicios();
            miServicios = form.servicios;
            CodigoServicioTextBox.Text = miServicios.Codigo;
            DescripcionServiciotextBox.Text = miServicios.Descripcion;
            //SolicitudClienteTextBox.Text = miServicios.Categoria.ToString();
        }

        private void CantidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Al Precionar enter y cantidadtexbox no esta vacio continua..
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(CantidadTextBox.Text))
            {
                DetalleTickets detalle = new DetalleTickets();
                detalle.CodigoTicket = miServicios.Codigo;
                detalle.Cantidad = Convert.ToInt32(CantidadTextBox.Text);
                detalle.Precio = Convert.ToDecimal(miServicios.Precio);
                //Total es igual a la cantidad * el precio
                detalle.Total = Convert.ToInt32(CantidadTextBox.Text) * miServicios.Precio;
                detalle.DescripcionCliente = SolicitudClienteTextBox.Text;
                detalle.DescripcionSoporte = DescripcionSoportetextBox.Text;

                subtotal += detalle.Total;
                isv = subtotal * 0.15M;
                totalApagar = subtotal + isv;

                listaDetalles.Add(detalle);
                detalleDataGridView.DataSource = null;
                detalleDataGridView.DataSource = listaDetalles;

                subTotalTextBox.Text = subtotal.ToString("N2");
                isvTextBox.Text = isv.ToString("N2");
                TotalTextBox.Text = totalApagar.ToString("N2");

                miServicios = null;
                CodigoServicioTextBox.Clear();
                DescripcionServiciotextBox.Clear();
                SolicitudClienteTextBox.Clear();
                CantidadTextBox.Clear();
                CodigoServicioTextBox.Focus();
                
            }
        }         
              

        private void guardarButton_Click(object sender, EventArgs e)
               {
            Tickets miTickets = new Tickets();
            miTickets.Fecha = FechaDateTimePicker.Value;
            miTickets.CodigoUsuario = System.Threading.Thread.CurrentPrincipal.Identity.Name;
            miTickets.IDcliente = miCliente.ID;
            miTickets.SubTotal = subtotal;
            miTickets.ISV = isv;
            miTickets.Descuento = descuento;
              miTickets.Total = totalApagar;

            bool inserto = ticketsDB.Guardar(miTickets, listaDetalles);

            if(inserto) 
            {
                LimpiarControles();
                IDClienteTextBox.Focus();
                MessageBox.Show(" Ticket Registrado con Exito ");
            }
            else
            
                MessageBox.Show(" El Ticket No pudo ser Registrado  ");
            
        }

        private void LimpiarControles()
        {
            miCliente = null;
            miServicios = null;
            listaDetalles = null;
            FechaDateTimePicker.Value = DateTime.Now;
            IDClienteTextBox.Clear();
            NombreClienteTextBox.Clear();
            CodigoServicioTextBox.Clear();
            DescripcionServiciotextBox.Clear();
            DescripcionSoportetextBox.Clear();
            SolicitudClienteTextBox.Clear();
            CantidadTextBox.Clear();
            detalleDataGridView.DataSource = null;
            subtotal = 0;
            subTotalTextBox.Clear();
            isv = 0;
            isvTextBox.Clear();
            descuento = 0;
            DescuentoTextBox.Clear();
            totalApagar = 0;
            TotalTextBox.Clear();
        }

        private void DescuentoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit((char)e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '\b')) // si el caracter es diferente de numero y diferente de punto, no los permite
            {
                e.Handled = true; // si es numero o punto si lo permite
            }

            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)// valida si ya existe un punto le reste y no le permita ingresar otro punto
            {
                e.Handled = true;
            }

            //Al Precionar enter y cantidadtexbox no esta vacio continua..
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(DescuentoTextBox.Text))
            {
                descuento = Convert.ToDecimal(DescuentoTextBox.Text);
                totalApagar = totalApagar - descuento;
                TotalTextBox.Text = totalApagar.ToString();
            }


        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            IDClienteTextBox.Focus();
        }

        //private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        //{
        //    try
        //    {
        //        string linea = "_________________________________________________________________________________________________________________________________";
        //        int ydetalles = 250;
        //        Bitmap bitmap = Properties.Resources.encabezado_factura;
        //        Image image = bitmap;
        //        e.Graphics.DrawImage(image, 10, 10);

        //        e.Graphics.DrawString("Cliente: ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(10, 200));
        //        e.Graphics.DrawString(miCliente.Nombre, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 200));

        //        e.Graphics.DrawString("Fecha: ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(550, 200));
        //        e.Graphics.DrawString(FechaDateTimePicker.Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(610, 200));

        //        e.Graphics.DrawString(linea, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(10, 230));

        //        e.Graphics.DrawString("Producto: ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(10, ydetalles));
        //        e.Graphics.DrawString("Cantidad: ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(420, ydetalles));
        //        e.Graphics.DrawString("Precio: ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(550, ydetalles));
        //        e.Graphics.DrawString("Total: ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(700, ydetalles));

        //        foreach (DetalleTickets item in listaDetalles)
        //        {
        //            ydetalles = ydetalles + 25;
        //            e.Graphics.DrawString(item.Descripcion, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(10, ydetalles));
        //            e.Graphics.DrawString(item.Cantidad.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(420, ydetalles));
        //            e.Graphics.DrawString(item.Precio.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(550, ydetalles));
        //            e.Graphics.DrawString(item.Total.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(700, ydetalles));
        //        }
        //        e.Graphics.DrawString(linea, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(10, 230));

        //        e.Graphics.DrawString("Sub-Total : ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, ydetalles + 50));
        //        e.Graphics.DrawString(subtotal.ToString("N2"), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(700, ydetalles + 50));
        //        e.Graphics.DrawString("ISV : ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(653, ydetalles + 75));
        //        e.Graphics.DrawString(isv.ToString("N2"), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(700, ydetalles + 75));
        //        e.Graphics.DrawString("Descuento : ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(591, ydetalles + 100));
        //        e.Graphics.DrawString(descuento.ToString("N2"), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(700, ydetalles + 100));
        //        e.Graphics.DrawString("Total : ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(640, ydetalles + 125));
        //        e.Graphics.DrawString(totalApagar.ToString("N2"), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(700, ydetalles + 1255));
        //    }
        //    catch (Exception)
        //    {              
        //    }

        //}

    }
}
