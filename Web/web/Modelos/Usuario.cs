using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Usuario
    {
        public string CodigoUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Rol { get; set; }
        public byte[] Fotos { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool EstaActivo { get; set; }

        public Usuario()
        {
        }

        public Usuario(string codigoUsuario, string contraseña, string nombre, string correo, string rol, byte[] fotos, DateTime fechaCreacion, bool estaActivo)
        {
            CodigoUsuario = codigoUsuario;
            Contraseña = contraseña;
            Nombre = nombre;
            Correo = correo;
            Rol = rol;
            Fotos = fotos;
            FechaCreacion = fechaCreacion;
            EstaActivo = estaActivo;
        }

    }
}
