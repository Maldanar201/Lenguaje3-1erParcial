﻿using Blazor.Interfaces;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using Modelos;

namespace Blazor.Pages.MisUsuarios
{
    public partial class EditarUsuario
    {
        [Inject] private IUsuarioServicio usuarioServicio { get; set; }
        [Inject] private NavigationManager navigationManager { get; set; }

        [Inject] private SweetAlertService Swal { get; set; }

        private Usuarios user = new Usuarios();
        [Parameter] public string CodigoUsuario { get; set; }

        protected override async Task OnInitializedAsync()
        {
            if(!string.IsNullOrEmpty(CodigoUsuario)) 
            {
                user = await usuarioServicio.GetPorCodigoAsync(CodigoUsuario);
            }
        }

        protected async void Guardar()
        {
            if(string.IsNullOrWhiteSpace(user.CodigoUsuario) || string.IsNullOrWhiteSpace(user.Nombre) || 
               string.IsNullOrWhiteSpace(user.Contrasena) || string.IsNullOrWhiteSpace(user.Rol) || user.Rol == "Seleccionar") 
            {
                return;
            }

            bool edito = await usuarioServicio.ActualizarAsync(user);

            if(edito) 
            {
                await Swal.FireAsync("Felicidades", "Usuario Actualizado", SweetAlertIcon.Success);
            }
            else
            {
                await Swal.FireAsync("Error", "El Usuario No pudo ser Actualizado", SweetAlertIcon.Error);
            }
        }

        protected async void Cancelar()
        {
            navigationManager.NavigateTo("/Usuarios");
        }

        protected async void Eliminar()
        {
            SweetAlertResult result = await Swal.FireAsync(new SweetAlertOptions
            {
                Title = "¿Seguro que desea eliminar el Usuario?",
                Icon = SweetAlertIcon.Question,
                ShowCancelButton = true,
                ConfirmButtonText = "Aceptar",
                CancelButtonText = "Cancelar",
            });

            if(!string.IsNullOrEmpty(result.Value)) 
            {
                bool elimino = await usuarioServicio.EliminarAsync(user.CodigoUsuario);

                if (elimino)
                {
                    await Swal.FireAsync("Felicidades", "El Usuario se Elimino", SweetAlertIcon.Success);
                    navigationManager.NavigateTo("/Usuarios");
                }
                else
                {
                    await Swal.FireAsync("Error", "El Usuario No pudo ser Eliminado", SweetAlertIcon.Error);
                }
            }
        }
    }
}

enum Roles
{
    Selecionar,
    Administrador,
    Usuario
}