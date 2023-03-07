using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;
using System.Data;

namespace Datos
{
    public class UsuariosDB
    {
        string cadena = "server=localhost; user=rooot; database=factura; password=123456;"; // direcion y datos para conectar a la base de datos

        public Usuarios Autentificar( Login login) // metodo de para verificar conexion a la BD
        {
            Usuarios user = null;
            try
            {
                StringBuilder sql = new StringBuilder(); // ayuda a capturar y ejecutar sentencias sql largas
                sql.Append("SELEC * FROM usuario WHERE CodigoUsuario = @CodigoUsuario AND Contrasena = @Contrasena");

                using(MySqlConnection _conexion = new MySqlConnection(cadena)) //Abre la conexion con los parametros de la BD
                {
                    _conexion.Open(); //inicia la conexion
                    using(MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion)) 
                    {
                        //evalua si los parametros de conexion usuario y contraseña son validos
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = login.CodigoUsuario;
                        comando.Parameters.Add("@Contrasena", MySqlDbType.VarChar, 50).Value = login.Clave;

                        MySqlDataReader dr = comando.ExecuteReader();
                        if(dr.Read()) 
                        {
                            user = new Usuarios();// instancia un nuevo usuario a la BD

                            user.CodigoUsuario = dr["CodigoUsuario"].ToString();
                            user.Nombre = dr["Nombre"].ToString();
                            user.Contraseña = dr["Contrasena"].ToString();
                            user.Correo = dr["Correo"].ToString();
                            user.Rol = dr["Rol"].ToString();
                            user.Fotos = (byte[])dr["Foto"];
                            user.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]);
                            user.EstaActivo = Convert.ToBoolean(dr["EstaActivo"]);
                        }
                    }

                }

            }
            catch (System.Exception ex)
            {                
            }

            return user;
        }
    }
}
