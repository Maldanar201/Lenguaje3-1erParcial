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
        string cadena = "server=localhost; user=root; database=tickets; password=123456;"; // direcion y datos para conectar a la base de datos


        public Clientes DevolverClientesPorIdentidad(string identidad)// metodo para leer la base de datos y devolver informacion de cliente atraves de la identidad
        {
            Clientes cliente = null;
            try
            {
                StringBuilder sql = new StringBuilder(); // ayuda a capturar y ejecutar sentencias sql largas
                sql.Append(" SELECT * FROM clientes WHERE IDcliente = @IDcliente");
                using (MySqlConnection _conexion = new MySqlConnection(cadena)) //Abre la conexion con los parametros de la BD
                {
                    _conexion.Open(); //inicia la conexion
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@IDcliente", MySqlDbType.VarChar, 25).Value = identidad;
                        MySqlDataReader dr = comando.ExecuteReader();
                        
                        if(dr.Read()) 
                        {
                            cliente = new Clientes();

                            cliente.ID = identidad;
                            cliente.Nombre = dr["Nombre"].ToString();
                            cliente.Direccion = dr["Direccion"].ToString();
                            cliente.Correo = dr["Correo"].ToString();
                            cliente.Telefono = dr["Telefono"].ToString();
                            cliente.EstaActivo = Convert.ToBoolean(dr["EstaActivo"]);
                            cliente.FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]);
                        }
                    }

                }

            }
            catch (System.Exception ex)
            {
            }
            return cliente;
        }

        public bool Insertar(Clientes clientes)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder(); // ayuda a capturar y ejecutar sentencias sql largas
                sql.Append(" INSERT INTO clientes VALUES ");
                sql.Append(" (@IDcliente, @Nombre, @Direccion, @Correo, @Telefono, @EstaActivo, @FechaNacimiento); ");
                using (MySqlConnection _conexion = new MySqlConnection(cadena)) //Abre la conexion con los parametros de la BD
                {
                    _conexion.Open(); //inicia la conexion
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        //inserta los parametros ingresados en la BD
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@IDcliente", MySqlDbType.VarChar, 25).Value = clientes.ID;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 50).Value = clientes.Nombre;                        
                        comando.Parameters.Add("@Direccion", MySqlDbType.VarChar, 100).Value = clientes.Direccion;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = clientes.Correo;
                        comando.Parameters.Add("@Telefono", MySqlDbType.VarChar,15).Value = clientes.Telefono;                        
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = clientes.EstaActivo;
                        comando.Parameters.Add("@FechaNacimiento", MySqlDbType.DateTime).Value = clientes.FechaNacimiento;
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
                sql.Append(" Nombre = @Nombre, Direccion = @Direccion, Correo = @Correo, Telefono = @Telefono, EstaActivo = @EstaActivo, FechaNacimiento = @FechaNacimiento ");
                sql.Append(" WHERE IDcliente = @IDcliente; ");
                using (MySqlConnection _conexion = new MySqlConnection(cadena)) //Abre la conexion con los parametros de la BD
                {
                    _conexion.Open(); //inicia la conexion
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        //inserta los parametros ingresados en la BD
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@IDcliente", MySqlDbType.VarChar, 25).Value = clientes.ID;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 50).Value = clientes.Nombre;
                        comando.Parameters.Add("@Direccion", MySqlDbType.VarChar, 100).Value = clientes.Direccion;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = clientes.Correo;
                        comando.Parameters.Add("@Telefono", MySqlDbType.VarChar, 15).Value = clientes.Telefono;
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = clientes.EstaActivo;
                        comando.Parameters.Add("@FechaNacimiento", MySqlDbType.DateTime).Value = clientes.FechaNacimiento;
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

        public bool Eliminar(string ID)  // metodo para eliminar registros de la BD

        {
            bool elimino = false;
            try
            {
                StringBuilder sql = new StringBuilder(); // ayuda a capturar y ejecutar sentencias sql largas
                sql.Append(" DELETE FROM clientes ");
                sql.Append(" WHERE IDcliente = @IDcliente; ");
                using (MySqlConnection _conexion = new MySqlConnection(cadena)) //Abre la conexion con los parametros de la BD
                {
                    _conexion.Open(); //inicia la conexion
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        //elimina los parametros ingresados en la BD
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@IDcliente", MySqlDbType.VarChar, 25).Value = ID;
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

        public DataTable DevolverClientesPorNombre(string nombre)// metodo para leer la base de datos y verla en el formulario clientes
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder(); // ayuda a capturar y ejecutar sentencias sql largas
                sql.Append(" SELECT * FROM clientes WHERE Nombre LIKE '%" + nombre + "%' "); //LIKE filtro para presentar todo lo que contega dentro de ('% %')
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
        
    }
}
