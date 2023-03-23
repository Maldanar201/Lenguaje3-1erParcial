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
    public class ProductoDB
    {
        string cadena = "server=localhost; user=root; database=factura; password=123456;"; // direcion y datos para conectar a la base de datos
             
        public bool Insertar(Producto producto)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder(); // ayuda a capturar y ejecutar sentencias sql largas
                sql.Append(" INSERT INTO producto VALUES ");
                sql.Append(" (@Codigo, @Descripcion, @Existencia, @Precio, @Foto, @EstaActivo); ");
                using (MySqlConnection _conexion = new MySqlConnection(cadena)) //Abre la conexion con los parametros de la BD
                {
                    _conexion.Open(); //inicia la conexion
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        //inserta los parametros ingresados en la BD
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = producto.Codigo;
                        comando.Parameters.Add("@Descripcion", MySqlDbType.VarChar, 200).Value = producto.Descripcion;
                        comando.Parameters.Add("@Existencia", MySqlDbType.Int32).Value = producto.Existencia;
                        comando.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = producto.Precio;                        
                        comando.Parameters.Add("@Foto", MySqlDbType.LongBlob).Value = producto.imagenProducto;                        
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = producto.EstaActivo;
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

        public bool Editar(Producto producto)  // metodo para modificar datos de la BD

        {
            bool edito = false;
            try
            {
                StringBuilder sql = new StringBuilder(); // ayuda a capturar y ejecutar sentencias sql largas
                sql.Append(" UPDATE producto SET ");
                sql.Append(" Descripcion = @Descripcion, Existencia = @Existencia, Precio = @Precio, Foto = @Foto, EstaActivo = @EstaActivo ");
                sql.Append(" WHERE Codigo = @Codigo; ");
                using (MySqlConnection _conexion = new MySqlConnection(cadena)) //Abre la conexion con los parametros de la BD
                {
                    _conexion.Open(); //inicia la conexion
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        //inserta los parametros ingresados en la BD
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = producto.Codigo;
                        comando.Parameters.Add("@Descripcion", MySqlDbType.VarChar, 200).Value = producto.Descripcion;
                        comando.Parameters.Add("@Existencia", MySqlDbType.Int32).Value = producto.Existencia;
                        comando.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = producto.Precio;
                        comando.Parameters.Add("@Foto", MySqlDbType.LongBlob).Value = producto.imagenProducto;
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = producto.EstaActivo;
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
                sql.Append(" DELETE FROM producto ");
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

        public DataTable DevolverProducto()// metodo para leer la base de datos y verla en el formulario usuarios
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder(); // ayuda a capturar y ejecutar sentencias sql largas
                sql.Append(" SELECT * FROM producto ");
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

        public Producto DevolverProductosPorCodigo(string codigo)// metodo para leer la base de datos y devolver un producto por su codigo
        {
            Producto producto = null;
            try
            {
                StringBuilder sql = new StringBuilder(); // ayuda a capturar y ejecutar sentencias sql largas
                sql.Append(" SELECT * FROM producto WHERE Codigo = @Codigo");
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
                            producto = new Producto();

                            producto.Codigo = codigo;
                            producto.Descripcion = dr["Descripcion"].ToString();
                            producto.Existencia = Convert.ToInt32(dr["Existencia"]);
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

        public DataTable DevolverProductoPorDescripcion(string descripcion)// metodo para leer la base de datos y verla en el formulario usuarios
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder(); // ayuda a capturar y ejecutar sentencias sql largas
                sql.Append(" SELECT * FROM producto WHERE Descripcion LIKE '%" + descripcion + "%' ");
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
