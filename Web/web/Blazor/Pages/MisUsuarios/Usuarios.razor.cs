﻿using Blazor.Interfaces;
using Microsoft.AspNetCore.Components;
using Modelos;


namespace Blazor.Pages.MisUsuarios
{
    public partial class Usuarios
    {
        [Inject] private IUsuarioServicio usuarioServicio { get; set; } //injeccion de dependencias

        private IEnumerable<Usuario> lista { get; set; }

        protected override async Task OnInitializedAsync()
        {
            lista = await usuarioServicio.GetListaAsync();
        }
    }
}
