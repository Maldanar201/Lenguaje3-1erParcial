using Modelos;

namespace Blazor.Interfaces
{
    public interface IUsuarioServicio
    {
        Task<Usuarios> GetPorCodigoAsync(string codigo);
        Task<bool> NuevoAsync(Usuarios usuario);
        Task<bool> ActualizarAsync(Usuarios usuario);
        Task<bool> EliminarAsync(string codigo);
        Task<IEnumerable<Usuarios>> GetListaAsync();
    }
}
