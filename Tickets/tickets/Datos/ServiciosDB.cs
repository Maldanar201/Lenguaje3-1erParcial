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
    public class ServiciosDB
    {
        string cadena = "server=localhost; user=root; database=tickets; password=123456;"; // direcion y datos para conectar a la base de datos
             
        public bool Insertar(Servicios servicio)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder(); // ayuda a capturar y ejecutar sentencias sql largas
                sql.Append(" INSERT INTO servicios VALUES ");
                sql.Append(" (@Codigo, @Descripcion, @Categoria, @Precio, @Foto, @EstaActivo); ");
                using (MySqlConnection _conexion = new MySqlConnection(cadena)) //Abre la conexion con los parametros de la BD
                {
                    _conexion.Open(); //inicia la conexion
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        //inserta los parametros ingresados en la BD
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = servicio.Codigo;
                        comando.Parameters.Add("@Descripcion", MySqlDbType.VarChar, 200).Value = servicio.Descripcion;
                        comando.Parameters.Add("@Categoria", MySqlDbType.VarChar, 100).Value = servicio.Categoria;
                        comando.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = servicio.Precio;                        
                        comando.Parameters.Add("@Foto", MySqlDbType.LongBlob).Value = servicio.imagenComponente;                        
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = servicio.EstaActivo;
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

        public bool Editar(Servicios servicio)  // metodo para modificar datos de la BD

        {
            bool edito = false;
            try
            {
                StringBuilder sql = new StringBuilder(); // ayuda a capturar y ejecutar sentencias sql largas
                sql.Append(" UPDATE servicios SET ");
                sql.Append(" Descripcion = @Descripcion, Categoria = @Categoria, Precio = @Precio, Foto = @Foto, EstaActivo = @EstaActivo ");
                sql.Append(" WHERE Codigo = @Codigo; ");
                using (MySqlConnection _conexion = new MySqlConnection(cadena)) //Abre la conexion con los parametros de la BD
                {
                    _conexion.Open(); //inicia la conexion
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        //inserta los parametros ingresados en la BD
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = servicio.Codigo;
                        comando.Parameters.Add("@Descripcion", MySqlDbType.VarChar, 200).Value = servicio.Descripcion;
                        comando.Parameters.Add("@Categoria", MySqlDbType.VarChar, 100).Value = servicio.Categoria;
                        comando.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = servicio.Precio;
                        comando.Parameters.Add("@Foto", MySqlDbType.LongBlob).Value = servicio.imagenComponente;
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = servicio.EstaActivo;
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
                sql.Append(" DELETE FROM servicios ");
                sql.Append(" WHERE Codigo = @Codigo; ");
                using (MySqlConnection _conexion = new MySqlConnection(cadena)) //Abre la conexion con los parametros de la BD
                {
                    _conexion.Open(); //inicia la conexion
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        //elimina los parametros ingresados en la BD
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = Codigo;
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

        public DataTable DevolverServicios()// metodo para leer la base de datos y verla en el formulario usuarios
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder(); // ayuda a capturar y ejecutar sentencias sql largas
                sql.Append(" SELECT * FROM servicios ");
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
                sql.Append(" SELECT Foto FROM servicios WHERE Codigo = @Codigo ");
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

        public Servicios DevolverServiciosPorCodigo(string codigo)// metodo para leer la base de datos y devolver un producto por su codigo
        {
            Servicios producto = null;
            try
            {
                StringBuilder sql = new StringBuilder(); // ayuda a capturar y ejecutar sentencias sql largas
                sql.Append(" SELECT * FROM servicios WHERE Codigo = @Codigo");
                using (MySqlConnection _conexion = new MySqlConnection(cadena)) //Abre la conexion con los parametros de la BD
                {
                    _conexion.Open(); //inicia la conexion
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = codigo;
                        MySqlDataReader dr = comando.ExecuteReader();

                        if (dr.Read())
                        {
                            producto = new Servicios();

                            producto.Codigo = codigo;
                            producto.Descripcion = dr["Descripcion"].ToString();
                            producto.Categoria = dr["Categoria"].ToString();
                            producto.Precio = Convert.ToDecimal(dr["Correo"]);                            
                            producto.EstaActivo = Convert.ToBoolean(dr["EstaActivo"]);
                        }
                    }

                }

            }
            catch (System.Exception ex)
            {
            }
            return producto;
        }

        public DataTable DevolverServiciosPorDescripcion(string descripcion)// metodo para leer la base de datos y verla en el formulario usuarios
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder(); // ayuda a capturar y ejecutar sentencias sql largas
                sql.Append(" SELECT * FROM servicios WHERE Descripcion LIKE '%" + descripcion + "%' ");
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
