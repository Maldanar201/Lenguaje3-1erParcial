using Dapper;
using Datos.Interfaces;
using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public class DetalleFacturaRepositorio : IDetalleFacturaRepositorio
    {
        private string CadenaConexion;

        public DetalleFacturaRepositorio(string _cadenaConexion)
        {
            CadenaConexion = _cadenaConexion;
        }

        private MySqlConnection Conexion()
        {
            return new MySqlConnection(CadenaConexion);
        }
        public async Task<bool> NuevoAsync(DetalleFactura detalleFactura)
        {
            bool inserto = false;
            try
            {
                using MySqlConnection _conexion = Conexion(); //abrimos un metodo using para llamar la cadena de conexion a la BD
                await _conexion.OpenAsync(); // abrimos la conexion asincronica a la BD
                string sql = @"INSERT INTO detallefactura (IdFactura, CodigoProducto, Precio, Cantidad, Total)
                                VALUES (@IdFactura, @CodigoProducto, @Precio, @Cantidad, @Total);";
                inserto = Convert.ToBoolean(await _conexion.ExecuteAsync(sql, detalleFactura));
            }
            catch (Exception ex)
            {
            }
            return inserto;
        }
        
    }
}
