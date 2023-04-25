using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    public interface IProductoRepositorio
    {
        Task<bool> NuevoAsync(Producto producto);
        Task<bool> ActiualizarAsync(Producto producto);
        Task<bool> EliminarAsync(string codigo);
        Task<IEnumerable<Producto>> GetlistaAsync();
        Task<Producto> GetPorCodigoAsync(string codigo);
    }
}
