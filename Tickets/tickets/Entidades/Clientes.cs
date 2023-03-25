using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clientes
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set;}
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public bool EstaActivo { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Clientes()
        {
        }

        public Clientes(string iD, string nombre, string correo, string direccion, string telefono, bool estaActivo, DateTime fechaNacimiento)
        {
            ID = iD;
            Nombre = nombre;
            Correo = correo;
            Direccion = direccion;
            Telefono = telefono;
            EstaActivo = estaActivo;
            FechaNacimiento = fechaNacimiento;
        }
    }
}
