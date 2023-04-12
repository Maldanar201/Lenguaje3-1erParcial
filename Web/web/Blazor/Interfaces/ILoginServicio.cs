using Modelos;

namespace Blazor.Interfaces
{
    public interface ILoginServicio
    {
        Task<bool> validarUsuarioAsync(Login login);
    }
}
