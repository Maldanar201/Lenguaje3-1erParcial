using Blazor.Interfaces;
using Datos.Repositorios;
using Datos.Interfaces;
using Modelos;

namespace Blazor.Servicios
{
    public class DetalleFacturaServicio : IDetalleFacturaServicio
    {
        private readonly Config _Configuracion;
        private IDetalleFacturaRepositorio detalleFacturaRepositorio;

        public DetalleFacturaServicio(Config config)
        {
            _Configuracion = config;
            detalleFacturaRepositorio = new DetalleFacturaRepositorio(config.CadenaConexion);
        }
        public async Task<bool> NuevoAsync(DetalleFactura detalleFactura)
        {
            return await detalleFacturaRepositorio.NuevoAsync(detalleFactura);
        }
    }
}
