using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clientes
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string ID { get; set;}
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public bool EstaActivo { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Clientes()
        {
        }

        public Clientes(string codigo, string nombre, string iD, string direccion, string telefono, bool estaActivo, DateTime fechaCreacion)
        {
            Codigo = codigo;
            Nombre = nombre;
            ID = iD;
            Direccion = direccion;
            Telefono = telefono;
            EstaActivo = estaActivo;
            FechaCreacion = fechaCreacion;
        }
    }
}
