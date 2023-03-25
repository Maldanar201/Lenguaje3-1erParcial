using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleTickets
    {
        public int ID { get; set; }
        public int IDticket {get; set; }
        public string CodigoTicket { get; set; }
        public string DescripcionCliente { get; set; }
        public string DescripcionSoporte { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }

        public DetalleTickets()
        {
        }

        public DetalleTickets(int iD, int iDticket, string codigoTicket, string descripcionCliente, string descripcionSoporte, decimal precio, int cantidad, decimal total)
        {
            ID = iD;
            IDticket = iDticket;
            CodigoTicket = codigoTicket;
            DescripcionCliente = descripcionCliente;
            DescripcionSoporte = descripcionSoporte;
            Precio = precio;
            Cantidad = cantidad;
            Total = total;
        }
    }
}
