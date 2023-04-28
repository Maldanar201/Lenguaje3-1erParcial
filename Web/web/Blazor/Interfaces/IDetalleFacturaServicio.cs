using Modelos;

namespace Blazor.Interfaces
{
    public interface IDetalleFacturaServicio
    {
        Task<bool> NuevoAsync(DetalleFactura detalleFactura);
    }
}
