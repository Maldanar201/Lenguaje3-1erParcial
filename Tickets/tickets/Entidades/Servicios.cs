using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Servicios
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }
        public byte[] imagenComponente { get; set;}
        public bool EstaActivo { get; set; }

        public Servicios()
        {
        }

        public Servicios(string codigo, string descripcion, string categoria, decimal precio, byte[] imagenComponente, bool estaActivo)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Categoria = categoria;
            Precio = precio;
            this.imagenComponente = imagenComponente;
            EstaActivo = estaActivo;
        }
    }
}
