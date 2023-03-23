using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class FacturaDB
    {
        string cadena = "server=localhost; user=root; database=factura; password=123456;"; // direcion y datos para conectar a la base de datos

        public bool Guardar(Factura factura, List<DetalleFactura> detalles) 
        {
            bool inserto = false;
            int idFactura = 0;

            try
            {
                StringBuilder sqlFactura = new StringBuilder(); // abre un objeto para capturar y ordenar sencias sql largas
                sqlFactura.Append(" INSERT INTO factura (fecha, IDcliente, CodigoUsuario, ISV, Descuento, SubTotal, Total) VALUES (@fecha, @IDcliente, @CodigoUsuario, @ISV, @Descuento, @SubTotal, @Total); "); // asigna tarea al objeto para insertar datos en la tabla sql
                sqlFactura.Append(" SELECT LAST_INSERT_ID(); "); // captura y devuelve el ultimo numero de la llave primaria que se ejecuto

                StringBuilder sqlDetalle = new StringBuilder();
                sqlDetalle.Append(" INSERT INTO detallefactura (IDfactura, CodigoProducto, Precio, Cantidad, Total) VALUES (@IDfactura, @CodigoProducto, @Precio, @Cantidad, @Total); ");

                StringBuilder sqlExistencia = new StringBuilder();
                sqlExistencia.Append(" UPDATE producto SET Existencia = Existencia - @Cantidad WHERE Codigo = @Codigo");

                using (MySqlConnection con = new MySqlConnection(cadena)) // cra un objeto para abrir una conexion a la BD con el parametro cadena
                {
                    con.Open(); //Abre la conexion a la BD

                    // habilita metodo de transaccion, con bloqueo para solo lectura para los ususarios
                    MySqlTransaction transaction = con.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

                    try
                    {
                        using(MySqlCommand cmd1 = new MySqlCommand(sqlFactura.ToString(), con, transaction))
                        {
                            cmd1.CommandType = System.Data.CommandType.Text;
                            cmd1.Parameters.Add("@fecha", MySqlDbType.DateTime).Value = factura.Fecha;
                            cmd1.Parameters.Add("IDcliente", MySqlDbType.VarChar, 25).Value = factura.IDcliente;
                            cmd1.Parameters.Add("CodigoUsuario", MySqlDbType.VarChar, 50).Value = factura.CodigoUsuario;
                            cmd1.Parameters.Add("ISV", MySqlDbType.Decimal).Value = factura.ISV;
                            cmd1.Parameters.Add("Descuento", MySqlDbType.Decimal).Value = factura.Descuento;
                            cmd1.Parameters.Add("SubTotal", MySqlDbType.Decimal).Value = factura.SubTotal;
                            cmd1.Parameters.Add("Total", MySqlDbType.Decimal).Value = factura.Total;
                            idFactura = Convert.ToInt32(cmd1.ExecuteScalar());// captura el ultimo id de factura usado y lo asigna a la variable
                        }

                        //itera la lista del detalle de la factura
                        foreach(DetalleFactura detalle in detalles)// de la clase DetalleFactura en el metodo detalle dentro de la lista detalles
                        {
                            using (MySqlCommand cmd2 = new MySqlCommand(sqlDetalle.ToString(), con, transaction))
                            {
                                cmd2.CommandType = System.Data.CommandType.Text;
                                cmd2.Parameters.Add("@IDfactura", MySqlDbType.Int32).Value = idFactura; // guardado en la variable al ejecutar factura
                                cmd2.Parameters.Add("@CodigoProducto", MySqlDbType.VarChar, 50).Value = detalle.CodigoProducto; // del metodo detalle 
                                cmd2.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = detalle.Precio;
                                cmd2.Parameters.Add("@Cantidad", MySqlDbType.Int32).Value = detalle.Cantidad;
                                cmd2.Parameters.Add("@Total", MySqlDbType.Decimal).Value = detalle.Total;
                                cmd2.ExecuteNonQuery(); // no nesetimos devlover solo insertar

                            }
                            using (MySqlCommand cmd3 = new MySqlCommand(sqlExistencia.ToString(), con, transaction))
                            {
                                cmd3.CommandType = System.Data.CommandType.Text;                               
                                cmd3.Parameters.Add("@Cantidad", MySqlDbType.Int32).Value = detalle.Cantidad;
                                cmd3.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = detalle.Total;
                                cmd3.ExecuteNonQuery(); // no nesetimos devlover solo insertar

                            }
                        }

                        transaction.Commit();//actualiza la transaccion
                        inserto = true;
                    }
                    catch (Exception)
                    {
                        inserto = false;
                        transaction.Rollback(); // regresa al inicio si falla o se interrumpe la transaccion 
                    }
                }
            }
            catch (Exception)
            {                
            }
            return inserto;
        }
    }
}
