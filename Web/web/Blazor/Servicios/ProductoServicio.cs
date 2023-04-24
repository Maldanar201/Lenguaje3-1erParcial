using Blazor.Interfaces;
using Datos.Interfaces;
using Datos.Repositorios;
using Modelos;

namespace Blazor.Servicios
{
    public class ProductoServicio : IProductoServicio
    {
        private readonly Config _config;
        private IProductoRepositorio productoRepositorio;

        public ProductoServicio(Config config)

        {
            _config = config;
            productoRepositorio = new ProductoRepositorio(config.CadenaConexion);
        }

        public async Task<bool> ActiualizarAsync(Producto producto)
        {
            return await productoRepositorio.ActiualizarAsync(producto);
        }

        public async Task<bool> EliminaAsync(string codigo)
        {
            return await productoRepositorio.EliminaAsync(codigo);
        }

        public async Task<IEnumerable<Producto>> GetlistaAsync()
        {
            return await productoRepositorio.GetlistaAsync();
        }

        public async Task<Producto> GetPorCodigoAsync(string codigo)
        {
            return await productoRepositorio.GetPorCodigoAsync(codigo);
        }

        public async Task<bool> NuevoAsync(Producto producto)
        {
            return await productoRepositorio.NuevoAsync(producto);
        }
    }
}

