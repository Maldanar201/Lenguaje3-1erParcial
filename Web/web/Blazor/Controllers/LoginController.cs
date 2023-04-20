using Microsoft.AspNetCore.Mvc;
using Datos.Interfaces;
using Org.BouncyCastle.Security;
using Datos.Repositorios;
using Modelos;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace Blazor.Controllers
{
    public class LoginController : Controller
    {
        private readonly Config _config;
        private ILoginRepositorio _loginRepositorio;
        private IUsuarioRepositorio _usuarioRepositorio; 

        public LoginController(Config config)
        {
            _config = config;
            _loginRepositorio = new LoginRepositorio(config.CadenaConexion);
            _usuarioRepositorio = new UsuarioRepositorio(config.CadenaConexion);
        }

        [HttpPost("/autenticar/validar")]
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
                        rol = user.Rol;

                        //almacenar sesion
                        var claims = new[]
                        {
                            new Claim(ClaimTypes.Name, user.CodigoUsuario),
                            new Claim(ClaimTypes.Role, user.Rol)
                        };

                        ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme); //ejecuta la sesion
                        ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);//guarda los datos

                        //inicia la secion
                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal, new AuthenticationProperties { IsPersistent = true, ExpiresUtc = DateTime.UtcNow.AddMinutes(25) });                        
                    }
                    else
                    {
                        return LocalRedirect("/login/El usuario no esta Activo");
                    }
                }
                else
                {
                    return LocalRedirect("/login/Datos de Usuario no son validos");
                }
            }
            catch (Exception)
            {
            }

            return LocalRedirect("/");
        }

        [HttpGet("/Salir")]
        public async Task<IActionResult> Cerrar()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return LocalRedirect("/login");
        }
    }
}
