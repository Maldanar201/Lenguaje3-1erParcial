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
        string cadena = "server=localhost; user=root; database=factura; password=123456;"; // direcion y datos para conectar a la base de datos

        public Usuarios Autentificar( Login login) // metodo de para verificar conexion a la BD
        {
            Usuarios user = null;
            try
            {
                StringBuilder sql = new StringBuilder(); // ayuda a capturar y ejecutar sentencias sql largas
                sql.Append("SELECT * FROM usuarios WHERE CodigoUsuario = @CodigoUsuario AND Contrasena = @Contrasena ");

                using(MySqlConnection _conexion = new MySqlConnection(cadena)) //Abre la conexion con los parametros de la BD
                {
                    _conexion.Open(); //inicia la conexion
                    using(MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion)) 
                    {
                        //evalua si los parametros de conexion usuario y contraseña son validos
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = login.CodigoUsuario;
                        comando.Parameters.Add("@Contrasena", MySqlDbType.VarChar, 80).Value = login.Contrasena;

                        MySqlDataReader dr = comando.ExecuteReader();
                        if(dr.Read()) 
                        {
                            user = new Usuarios();// instancia un nuevo usuario a la BD

                            user.CodigoUsuario = dr["CodigoUsuario"].ToString();
                            user.Nombre = dr["Nombre"].ToString();
                            user.Contraseña = dr["Contrasena"].ToString();
                            user.Correo = dr["Correo"].ToString();
                            user.Rol = dr["Rol"].ToString();                         
                            user.FechaCreacion = Convert.ToDateTime(dr["FechaCreacion"]);
                            user.EstaActivo = Convert.ToBoolean(dr["EstaActivo"]);
                            if (dr["Foto"].GetType() != typeof(DBNull))  // si el tipo de dato en dr es diferente de nulo
                            {
                                user.Fotos = (byte[])dr["Foto"];
                            }                           

                        }
                    }

                }

            }
            catch (System.Exception ex)
            {                
            }
            return user;
        }

        public bool Insertar(Usuarios user)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder(); // ayuda a capturar y ejecutar sentencias sql largas
                sql.Append(" INSERT INTO usuarios VALUES ");
                sql.Append(" (@CodigoUsuario, @Nombre, @Contrasena, @Correo, @Rol, @Foto, @FechaCreacion, @EstaActivo); ");
                using (MySqlConnection _conexion = new MySqlConnection(cadena)) //Abre la conexion con los parametros de la BD
                {
                    _conexion.Open(); //inicia la conexion
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        //inserta los parametros ingresados en la BD
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = user.CodigoUsuario;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 50).Value = user.Nombre;
                        comando.Parameters.Add("@Contrasena", MySqlDbType.VarChar, 80).Value = user.Contraseña;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = user.Correo;
                        comando.Parameters.Add("@Rol", MySqlDbType.VarChar, 20).Value = user.Rol;
                        comando.Parameters.Add("@Foto", MySqlDbType.LongBlob).Value = user.Fotos;
                        comando.Parameters.Add("@FechaCreacion", MySqlDbType.DateTime).Value = user.FechaCreacion;
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = user.EstaActivo;
                        comando.ExecuteNonQuery(); // ejecutamos, no devolvemos nada
                        inserto = true;
                    }

                }

            }
            catch (System.Exception ex)
            {
            }
            return inserto;
        } // metodo para insertar datos a la BD

        public bool Editar(Usuarios user)  // metodo para modificar datos de la BD

        {
            bool edito = false;
            try
            {
                StringBuilder sql = new StringBuilder(); // ayuda a capturar y ejecutar sentencias sql largas
                sql.Append(" UPDATE usuarios SET ");
                sql.Append(" Nombre = @Nombre, Contrasena = @Contrasena, Correo = @Correo, Rol = @Rol, Foto = @Foto, EstaActivo = @EstaActivo ");
                sql.Append(" WHERE CodigoUsuario = @CodigoUsuario; ");
                using (MySqlConnection _conexion = new MySqlConnection(cadena)) //Abre la conexion con los parametros de la BD
                {
                    _conexion.Open(); //inicia la conexion
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        //inserta los parametros ingresados en la BD
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = user.CodigoUsuario;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 50).Value = user.Nombre;
                        comando.Parameters.Add("@Contrasena", MySqlDbType.VarChar, 80).Value = user.Contraseña;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = user.Correo;
                        comando.Parameters.Add("@Rol", MySqlDbType.VarChar, 20).Value = user.Rol;
                        comando.Parameters.Add("@Foto", MySqlDbType.LongBlob).Value = user.Fotos;                        
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = user.EstaActivo;
                        comando.ExecuteNonQuery(); // ejecutamos, no devolvemos nada
                        edito = true;
                    }

                }

            }
            catch (System.Exception ex)
            {
            }
            return edito;
        }

        public bool Eliminar(string CodigoUsuario)  // metodo para eliminar registros de la BD

        {
            bool elimino = false;
            try
            {
                StringBuilder sql = new StringBuilder(); // ayuda a capturar y ejecutar sentencias sql largas
                sql.Append(" DELETE FROM usuarios ");                
                sql.Append(" WHERE CodigoUsuario = @CodigoUsuario; ");
                using (MySqlConnection _conexion = new MySqlConnection(cadena)) //Abre la conexion con los parametros de la BD
                {
                    _conexion.Open(); //inicia la conexion
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        //elimina los parametros ingresados en la BD
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = CodigoUsuario;                        
                        comando.ExecuteNonQuery(); // ejecutamos, no devolvemos nada
                        elimino = true;
                    }

                }

            }
            catch (System.Exception ex)
            {
            }
            return elimino;
        }  

        public DataTable DevolverUsuario()// metodo para leer la base de datos y verla en el formulario usuarios
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder(); // ayuda a capturar y ejecutar sentencias sql largas
                sql.Append(" SELECT * FROM usuarios ");                
                using (MySqlConnection _conexion = new MySqlConnection(cadena)) //Abre la conexion con los parametros de la BD
                {
                    _conexion.Open(); //inicia la conexion
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {                        
                        comando.CommandType = CommandType.Text;
                        MySqlDataReader dr = comando.ExecuteReader();
                        dt.Load(dr);
                    }

                }

            }
            catch (System.Exception ex)
            {
            }
            return dt;
        }

        public byte[] DevolverFoto(string CodigoUsuario) // Metodo Para obtener la foto guardada en la base de datos 
        {
            byte[] foto = new byte[0];
            try
            {
                StringBuilder sql = new StringBuilder(); // ayuda a capturar y ejecutar sentencias sql largas
                sql.Append(" SELECT Foto FROM usuarios WHERE CodigoUsuario = @CodigoUsuario ");
                using (MySqlConnection _conexion = new MySqlConnection(cadena)) //Abre la conexion con los parametros de la BD
                {
                    _conexion.Open(); //inicia la conexion
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = CodigoUsuario;
                        MySqlDataReader dr = comando.ExecuteReader();
                        if(dr.Read()) 
                        {
                            foto = (byte[])dr["Foto"];
                        }
                    }

                }

            }
            catch (System.Exception ex)
            {
            }
            return foto;
        }
    }
    
}
