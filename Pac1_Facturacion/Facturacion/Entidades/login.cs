using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Login
    {
        public string CodigoUsuario { get; set; }
        public string Clave { get; set; }
       

        public Login() { }

        public Login(string codigoUsuario, string clave)
        {
            this.CodigoUsuario = codigoUsuario;
            this.Clave = clave;
            
        }
    }
}
