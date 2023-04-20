﻿using Dapper;
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
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        //almacenar la cadena de conexion a la base de Datos en una variable
        private string CadenaConexion;

        public UsuarioRepositorio(string _cadenaConexion)
        {
            CadenaConexion = _cadenaConexion;
        }

        // Abrir la conexion a la base de datos

        private MySqlConnection Conexion()
        {
            return new MySqlConnection(CadenaConexion);
        }


        public async Task<bool> ActualizarAsync(Usuario usuario)
        {
            bool resultado = false;
            try
            {
                using MySqlConnection _conexion = Conexion(); //abrimos un metodo using para llamar la cadena de conexion a la BD
                await _conexion.OpenAsync(); // abrimos la conexion asincronica a la BD
                string sql = @"UPDATE usuarios SET Nombre = @Nombre, Contrasena = @Contrasena, Correo = @Correo, Rol = @Rol, Foto = @Foto, EstaActivo = @EstaActivo 
                             WHERE CodigoUSuario = @CodigoUsuario;";               
                resultado = Convert.ToBoolean(await _conexion.ExecuteAsync(sql, usuario));
            }
            catch (Exception)
            {               
            }
            return resultado;
        }

        public async Task<bool> EliminarAsync(string codigoUsuario)
        {
            bool resultado = false;
            try
            {
                using MySqlConnection _conexion = Conexion(); //abrimos un metodo using para llamar la cadena de conexion a la BD
                await _conexion.OpenAsync(); // abrimos la conexion asincronica a la BD
                string sql = "DELETE FROM usuarios WHERE CodigoUSuario = @CodigoUsuario;";                
                resultado = Convert.ToBoolean(await _conexion.ExecuteAsync(sql, new {codigoUsuario}));
            }
            catch (Exception)
            {
            }
            return resultado;
        }

        public async Task<IEnumerable<Usuario>> GetListaAsync()
        {
            IEnumerable<Usuario> lista = new List<Usuario>();
            try
            {
                using MySqlConnection _conexion = Conexion(); //abrimos un metodo using para llamar la cadena de conexion a la BD
                await _conexion.OpenAsync(); // abrimos la conexion asincronica a la BD
                string sql = "SELECT * FROM usuarios;";
                lista = await _conexion.QueryAsync<Usuario>(sql);               
                
            }
            catch (Exception)
            {
            }
            return lista;
        }

        public async Task<Usuario> GetPorCodigoAsync(string codigoUsuario)
        {
            Usuario user = new Usuario();
            try
            {
                using MySqlConnection _conexion = Conexion(); //abrimos un metodo using para llamar la cadena de conexion a la BD
                await _conexion.OpenAsync(); // abrimos la conexion asincronica a la BD
                string sql = "SELECT * FROM usuarios WHERE CodigoUSuario = @CodigoUsuario;";
                user = await _conexion.QueryFirstAsync<Usuario>(sql, new {codigoUsuario});
            }
            catch (Exception)
            {
            }
            return user;
        }

        public async Task<bool> NuevoAsync(Usuario usuario)
        {
            bool resultado = false;
            try
            {
                using MySqlConnection _conexion = Conexion(); //abrimos un metodo using para llamar la cadena de conexion a la BD
                await _conexion.OpenAsync(); // abrimos la conexion asincronica a la BD
                string sql = @"INSERT INTO usuarios (CodigoUsuario, Nombre, Contrasena, Correo, Rol, Foto, FechaCreacion, EstaActivo)
                                VALUES (@CodigoUsuario, @Nombre, @Contrasena, @Correo, @Rol, @Foto, @FechaCreacion, @EstaActivo)";
                resultado = Convert.ToBoolean(await _conexion.ExecuteAsync(sql, usuario));
            }
            catch (Exception)
            {
            }
            return resultado;
        }
    }
}
