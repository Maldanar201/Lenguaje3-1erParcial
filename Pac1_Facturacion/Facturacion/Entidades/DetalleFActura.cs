using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleFactura
    {
        public int ID { get; set; }
        public int IDfactura {get; set; }
        public string CodigoProducto { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }

        public DetalleFactura()
        {
        }

        public DetalleFactura(int iD, int iDfactura, string codigoProducto, decimal precio, int cantidad, decimal total)
        {
            ID = iD;
            IDfactura = iDfactura;
            CodigoProducto = codigoProducto;
            Precio = precio;
            Cantidad = cantidad;
            Total = total;
        }
    }
}
