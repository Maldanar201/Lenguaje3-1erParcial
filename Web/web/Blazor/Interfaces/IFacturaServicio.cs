using Modelos;

namespace Blazor.Interfaces
{
    public interface IFacturaServicio
    {
        Task<int> NuevaAsync(Factura factura);
    }
}
