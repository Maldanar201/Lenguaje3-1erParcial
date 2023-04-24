using Modelos;

namespace Blazor.Interfaces
{
    public interface IProductoServicio
    {
        Task<bool> NuevoAsync(Producto producto);
        Task<bool> ActiualizarAsync(Producto producto);
        Task<bool> EliminaAsync(string codigo);
        Task<IEnumerable<Producto>> GetlistaAsync();
        Task<Producto> GetPorCodigoAsync(string codigo);
    }
}
