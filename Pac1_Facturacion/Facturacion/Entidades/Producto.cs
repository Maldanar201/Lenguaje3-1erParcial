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
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public decimal Precio { get; set; }
        public byte[] imagenProducto { get; set;}
        public bool EstaActivo { get; set; }

        public Producto()
        {
        }

        public Producto(string codigo, string descripcion, int existencia, decimal precio, byte[] imagenProducto, bool estaActivo)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Existencia = existencia;
            Precio = precio;
            this.imagenProducto = imagenProducto;
            EstaActivo = estaActivo;
        }
    }
}
