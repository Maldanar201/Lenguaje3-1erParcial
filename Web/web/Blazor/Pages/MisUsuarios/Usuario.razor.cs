using Blazor.Interfaces;
using Microsoft.AspNetCore.Components;
using Modelos;


namespace Blazor.Pages.MisUsuarios
{
    public partial class Usuario
    {
        [Inject] private IUsuarioServicio usuarioServicio { get; set; } //injeccion de dependencias

        private IEnumerable<Modelos.Usuarios> lista { get; set; }

        protected override async Task OnInitializedAsync()
        {
            lista = await usuarioServicio.GetListaAsync();
        }
    }
}
