using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class UsuariosDB
    {
        string cadena = "server=localhost; user=rooot; database=factura; password=123456;"; // direcion y datos para conectar a la base de datos

        public Usuarios Autentificar( login login) // metodo de para verificar conexion a la BD
        {
            Usuarios user = null;
            try
            {
                StringBuilder sql = new StringBuilder(); // ayuda a capturar y ejecutar sentencias sql largas
                sql.Append("SELEC * FROM usuario WHERE CodigoUsuario = @CodigoUsuario AND Contrasena = @Contrasena");

            }
            catch (System.Exception ex)
            {

                throw;
            }

            return user;
        }
    }
}
