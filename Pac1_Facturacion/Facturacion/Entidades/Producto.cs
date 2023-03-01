using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string Decripcion { get; set; }
        public int Existencia { get; set; }
        public decimal Precio { get; set; }
        public byte[] imagenProducto { get; set;}

        public Producto()
        {
        }

        public Producto(string codigo, string decripcion, int existencia, decimal precio, byte[] imagenProducto)
        {
            Codigo = codigo;
            Decripcion = decripcion;
            Existencia = existencia;
            Precio = precio;
            this.imagenProducto = imagenProducto;
        }
    }
}
