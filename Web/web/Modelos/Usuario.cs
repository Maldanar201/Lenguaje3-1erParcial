using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Usuario
    {
        [Required(ErrorMessage = "El Campo Codigo es Obligatorio")] 
        public string CodigoUsuario { get; set; }
        public string Contrasena { get; set; }
        [Required(ErrorMessage = "El Campo Nombre es Obligatorio")]
        public string Nombre { get; set; }
        public string Correo { get; set; }
        [Required(ErrorMessage = "El Campo Rol es Obligatorio")]
        public string Rol { get; set; }
        public byte[] Foto { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool EstaActivo { get; set; }

        public Usuario()
        {
        }

        public Usuario(string codigoUsuario, string contrasena, string nombre, string correo, string rol, byte[] fotos, DateTime fechaCreacion, bool estaActivo)
        {
            CodigoUsuario = codigoUsuario;
            Contrasena = contrasena;
            Nombre = nombre;
            Correo = correo;
            Rol = rol;
            Foto = fotos;
            FechaCreacion = fechaCreacion;
            EstaActivo = estaActivo;
        }

    }
}
