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
    internal class LoginRepositorio : ILoginReposirorio
    {
        //almacenar la cadena de conexion a la base de Datos en una variable
        private string CadenaConexion;

        public LoginRepositorio(string _cadenaConexion)
        {
            CadenaConexion = _cadenaConexion;
        }

        // Abrir la conexion a la base de datos

        private MySqlConnection Conexion()
        {
            return new MySqlConnection(CadenaConexion);
        }

        // VALIDAR USUARIOS
        public async Task<bool> validarUsuarioAsync(Login login)
        {
            bool valido = false;

            try
            {
                using MySqlConnection _conexion = Conexion(); //abrimos un metodo using para llamar la cadena de conexion a la BD
                await _conexion.OpenAsync(); // abrimos la conexion asincronica a la BD
                string sql = "SELECT 1 FROM usuarios WHERE CodigoUSuario = @CodigoUsuario AND Contrasena = @Contrasena;";
                // valido = await _conexion.ExecuteScalarAsync<bool>(sql, new {login.CodigoUsuario, login.Contrasena});  //lo mismo que la linea de abajo
                valido = await _conexion.ExecuteScalarAsync<bool>(sql, login);
            }
            catch (Exception)
            {              
            }
            return valido;
        }
    }
}
