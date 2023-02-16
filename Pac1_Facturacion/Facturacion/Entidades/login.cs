using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class login
    {
        public string codigoUsuario { get; set; }
        public string clave { get; set; }
        public string rol { get; set; }

        public login() { }

        public login(string codigoUsuario, string clave, string rol)
        {
            this.codigoUsuario = codigoUsuario;
            this.clave = clave;
            this.rol = rol;
        }
    }
}
