using Dapper;
using Datos.Interfaces;
using Modelos;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public class FacturaRepositorio : IFacturaRepositorio
    {
        private string CadenaConexion;

        public FacturaRepositorio(string _cadenaConexion)
        {
            CadenaConexion = _cadenaConexion;
        }       

        private MySqlConnection Conexion()
        {
            return new MySqlConnection(CadenaConexion);
        }

        public async Task<int> NuevaAsync(Factura factura)
        {
            int idFactura = 0;
            try
            {
                using MySqlConnection _conexion = Conexion(); //abrimos un metodo using para llamar la cadena de conexion a la BD
                await _conexion.OpenAsync(); // abrimos la conexion asincronica a la BD
                string sql = @"INSERT INTO factura (Fecha, IdentidadCliente, CodigoUsuario, ISV, Descuento, SubTotal, Total)
                                VALUES (@Fecha, @IdentidadCliente, @CodigoUsuario, @ISV, @Descuento, @SubTotal, @Total); SELECT LAST_INSERT_ID()";
                idFactura = Convert.ToInt32(await _conexion.ExecuteScalarAsync(sql, factura));
                
            }
            catch (Exception)
            {               
            }
            return idFactura;
        }
    }
}
