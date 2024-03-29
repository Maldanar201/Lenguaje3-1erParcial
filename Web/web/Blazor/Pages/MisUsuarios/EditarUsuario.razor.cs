﻿using Blazor.Interfaces;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Modelos;

namespace Blazor.Pages.MisUsuarios
{
    public partial class EditarUsuario
    {
        [Inject] private IUsuarioServicio usuarioServicio { get; set; }
        [Inject] private NavigationManager navigationManager { get; set; }

        [Inject] private SweetAlertService Swal { get; set; }

        private Modelos.Usuario user = new Modelos.Usuario();
        [Parameter] public string CodigoUsuario { get; set; }

        string imgUrl = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            if(!string.IsNullOrEmpty(CodigoUsuario)) 
            {
                user = await usuarioServicio.GetPorCodigoAsync(CodigoUsuario);
            }
        }

        private async Task SeleccionarImagen(InputFileChangeEventArgs e)
        {
            IBrowserFile imgFile = e.File;  // carga imgFile con la imagen que viene del navegador
            var buffers = new byte[imgFile.Size]; // asig a buffers el arreglo de bytes con la imagen
            user.Foto = buffers;
            await imgFile.OpenReadStream().ReadAsync(buffers); // muestra vista previa de la imagen
            string imageType = imgFile.ContentType;
            imgUrl = $"data:{imageType};base64,{Convert.ToBase64String(buffers)}";
            
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