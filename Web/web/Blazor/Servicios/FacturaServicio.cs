using Blazor.Interfaces;
using Datos.Interfaces;
using Datos.Repositorios;
using Modelos;

namespace Blazor.Servicios
{
    public class FacturaServicio : IFacturaServicio
    {
        private readonly Config _config;
        private IFacturaRepositorio facturaRepositorio;

        public FacturaServicio(Config config)
        {
            _config = config;
            facturaRepositorio = new FacturaRepositorio(config.CadenaConexion);
        }
        public async Task<int> NuevaAsync(Factura factura)
        {
            return await facturaRepositorio.NuevaAsync(factura);
        }
    }
}
