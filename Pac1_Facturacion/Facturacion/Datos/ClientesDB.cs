using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ClientesDB
    {
        string cadena = "server=localhost; user=root; database=factura; password=123456;"; // direcion y datos para conectar a la base de datos

        public bool Insertar(Clientes clientes)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder(); // ayuda a capturar y ejecutar sentencias sql largas
                sql.Append(" INSERT INTO clientes VALUES ");
                sql.Append(" (@Codigo, @Nombre, @ID, @Direccion, @Telefono, @EstaActivo, @FechaCreacion); ");
                using (MySqlConnection _conexion = new MySqlConnection(cadena)) //Abre la conexion con los parametros de la BD
                {
                    _conexion.Open(); //inicia la conexion
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        //inserta los parametros ingresados en la BD
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 50).Value = clientes.Codigo;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 100).Value = clientes.Nombre;
                        comando.Parameters.Add("@ID", MySqlDbType.VarChar, 25).Value = clientes.ID;
                        comando.Parameters.Add("@Direccion", MySqlDbType.VarChar, 200).Value = clientes.Direccion;
                        comando.Parameters.Add("@Telefono", MySqlDbType.VarChar,45).Value = clientes.Telefono;                        
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = clientes.EstaActivo;
                        comando.Parameters.Add("@FechaCreacion", MySqlDbType.DateTime).Value = clientes.FechaCreacion;
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

        public bool Editar(Clientes clientes)  // metodo para modificar datos de la BD

        {
            bool edito = false;
            try
            {
                StringBuilder sql = new StringBuilder(); // ayuda a capturar y ejecutar sentencias sql largas
                sql.Append(" UPDATE clientes SET ");
                sql.Append(" Nombre = @Nombre, ID = @ID, Direccion = @Direccion, Telefono = @Telefono, EstaActivo = @EstaActivo ");
                sql.Append(" WHERE Codigo = @Codigo; ");
                using (MySqlConnection _conexion = new MySqlConnection(cadena)) //Abre la conexion con los parametros de la BD
                {
                    _conexion.Open(); //inicia la conexion
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        //inserta los parametros ingresados en la BD
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 50).Value = clientes.Codigo;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 100).Value = clientes.Nombre;
                        comando.Parameters.Add("@ID", MySqlDbType.VarChar, 25).Value = clientes.ID;
                        comando.Parameters.Add("@Direccion", MySqlDbType.VarChar, 200).Value = clientes.Direccion;
                        comando.Parameters.Add("@Telefono", MySqlDbType.VarChar, 45).Value = clientes.Telefono;
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = clientes.EstaActivo;
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

        public bool Eliminar(string Codigo)  // metodo para eliminar registros de la BD

        {
            bool elimino = false;
            try
            {
                StringBuilder sql = new StringBuilder(); // ayuda a capturar y ejecutar sentencias sql largas
                sql.Append(" DELETE FROM clientes ");
                sql.Append(" WHERE Codigo = @Codigo; ");
                using (MySqlConnection _conexion = new MySqlConnection(cadena)) //Abre la conexion con los parametros de la BD
                {
                    _conexion.Open(); //inicia la conexion
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        //elimina los parametros ingresados en la BD
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 50).Value = Codigo;
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

        public DataTable DevolverClientes()// metodo para leer la base de datos y verla en el formulario clientes
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder(); // ayuda a capturar y ejecutar sentencias sql largas
                sql.Append(" SELECT * FROM clientes ");
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

        public byte[] DevolverFoto(string Codigo) // Metodo Para obtener la foto guardada en la base de datos 
        {
            byte[] foto = new byte[0];
            try
            {
                StringBuilder sql = new StringBuilder(); // ayuda a capturar y ejecutar sentencias sql largas
                sql.Append(" SELECT Foto FROM producto WHERE Codigo = @Codigo ");
                using (MySqlConnection _conexion = new MySqlConnection(cadena)) //Abre la conexion con los parametros de la BD
                {
                    _conexion.Open(); //inicia la conexion
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = Codigo;
                        MySqlDataReader dr = comando.ExecuteReader();
                        if (dr.Read())
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
