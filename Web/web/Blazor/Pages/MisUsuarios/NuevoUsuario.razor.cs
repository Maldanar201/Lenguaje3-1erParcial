using Blazor.Interfaces;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Modelos;

namespace Blazor.Pages.MisUsuarios
{
    public partial class NuevoUsuario
    {
        [Inject] private IUsuarioServicio usuarioServicio { get; set; }
        [Inject] private NavigationManager navigationManager { get; set; }

        [Inject] private SweetAlertService Swal { get; set; }

        private Usuario user = new Usuario();
        [Parameter] public string CodigoUsuario { get; set; }

        string imgUrl = string.Empty;

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
            if (string.IsNullOrWhiteSpace(user.CodigoUsuario) || string.IsNullOrWhiteSpace(user.Nombre) ||
               string.IsNullOrWhiteSpace(user.Contrasena) || string.IsNullOrWhiteSpace(user.Rol) || user.Rol == "Seleccionar")
            {
                return;
            }

            user.FechaCreacion = DateTime.Now;
            bool inserto = await usuarioServicio.NuevoAsync(user);

            if (inserto)
            {
                await Swal.FireAsync("Felicidades", "Usuario Registrado con Exito", SweetAlertIcon.Success);
            }
            else
            {
                await Swal.FireAsync("Error", "El Usuario No pudo ser Registrado", SweetAlertIcon.Error);
            }
        }

        protected async void Cancelar()
        {
            navigationManager.NavigateTo("/Usuarios");
        }
    }
}
