using Microsoft.AspNetCore.Mvc;
using Datos.Interfaces;
using Org.BouncyCastle.Security;
using Datos.Repositorios;
using Modelos;

namespace Blazor.Controller
{
    public class LoginController : Controller
    {
        private readonly Config _config;
        private ILoginRepositorio _loginRepositorio;
        private IUsuarioRepositorio _usuarioRepositorio; 

        LoginController(Config config)
        {
            _config = config;
            _loginRepositorio = new LoginRepositorio(config.CadenaConexion);
            _usuarioRepositorio = new UsuarioRepositorio(config.CadenaConexion);
        }

        [HttpPost("autenticar/validar")]
        public async Task<IActionResult> Validacion(Login login)
        {
            string rol = string.Empty;
            try
            {
                bool usuarioValido = await _loginRepositorio.validarUsuarioAsync(login);

                if (usuarioValido) 
                {
                    Usuario user = await _usuarioRepositorio.GetPorCodigoAsync(login.CodigoUsuario);

                    if(user.EstaActivo)
                    {

                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
