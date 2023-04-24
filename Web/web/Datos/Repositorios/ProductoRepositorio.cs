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
    public class ProductoRepositorio : IProductoRepositorio
    {
        private string CadenaConexion;

        public ProductoRepositorio(string _cadenaConexion)
        {
            CadenaConexion = _cadenaConexion;
        }
                
        private MySqlConnection Conexion()
        {
            return new MySqlConnection(CadenaConexion);
        }

        public async Task<bool> ActiualizarAsync(Producto producto)
        {
            bool resultado = false;
            try
            {
                using MySqlConnection _conexion = Conexion(); 
                await _conexion.OpenAsync(); // 
                string sql = @"UPDATE producto SET Descipcion = @Descipcion, Existencia = @Existencia, Precio = @Precio, Foto = @Foto, EstaActivo = @EstaActivo 
                             WHERE Codigo = @Codigo;";
                resultado = Convert.ToBoolean(await _conexion.ExecuteAsync(sql, producto));
            }
            catch (Exception)
            {
            }
            return resultado;
        }

        public async Task<bool> EliminaAsync(string codigo)
        {
            bool resultado = false;
            try
            {
                using MySqlConnection _conexion = Conexion(); //abrimos un metodo using para llamar la cadena de conexion a la BD
                await _conexion.OpenAsync(); // abrimos la conexion asincronica a la BD
                string sql = "DELETE FROM producto WHERE Codigo = @Codigo;";
                resultado = Convert.ToBoolean(await _conexion.ExecuteAsync(sql, new { codigo }));
            }
            catch (Exception)
            {
            }
            return resultado;
        }

        public async Task<IEnumerable<Producto>> GetlistaAsync()
        {
            IEnumerable<Producto> lista = new List<Producto>();
            try
            {
                using MySqlConnection _conexion = Conexion(); //abrimos un metodo using para llamar la cadena de conexion a la BD
                await _conexion.OpenAsync(); // abrimos la conexion asincronica a la BD
                string sql = "SELECT * FROM producto;";
                lista = await _conexion.QueryAsync<Producto>(sql);

            }
            catch (Exception)
            {
            }
            return lista;
        }

        public async Task<Producto> GetPorCodigoAsync(string codigo)
        {
            Producto prod = new Producto();
            try
            {
                using MySqlConnection _conexion = Conexion(); //abrimos un metodo using para llamar la cadena de conexion a la BD
                await _conexion.OpenAsync(); // abrimos la conexion asincronica a la BD
                string sql = "SELECT * FROM producto WHERE Codigo = @Codigo;";
                prod = await _conexion.QueryFirstAsync<Producto>(sql, new { codigo });
            }
            catch (Exception)
            {
            }
            return prod;
        }

        public async Task<bool> NuevoAsync(Producto producto)
        {
            bool resultado = false;
            try
            {
                using MySqlConnection _conexion = Conexion(); //abrimos un metodo using para llamar la cadena de conexion a la BD
                await _conexion.OpenAsync(); // abrimos la conexion asincronica a la BD
                string sql = @"INSERT INTO usuarios (Codigo, Descripcion, Existencia, Precio, Foto, EstaActivo)
                                VALUES (@Codigo, @Descripcion, @Existencia, @Precio, @Foto, @EstaActivo)";
                resultado = Convert.ToBoolean(await _conexion.ExecuteAsync(sql, producto));
            }
            catch (Exception)
            {
            }
            return resultado;
        }
    }
}
