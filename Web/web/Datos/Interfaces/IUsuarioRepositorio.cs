using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<Usuarios> GetPorCodigoAsync(string codigoUsuario);
        Task<bool> NuevoAsync(Usuarios usuario);
        Task<bool> ActualizarAsync(Usuarios usuario);
        Task<bool> EliminarAsync(string codigoUsuario);
        Task<IEnumerable<Usuarios>> GetListaAsync();
    }
}
