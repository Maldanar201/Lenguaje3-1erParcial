using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Cliente
    {
        [Required(ErrorMessage = "El Numero de identida es obligatorio")]
        public string Identidad { get; set; }
        [Required(ErrorMessage = "El Nombre del cliente es obligatorio")]
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public bool EstaActivo { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
