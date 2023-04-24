using Blazor.Interfaces;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Identity;
using Modelos;

namespace Blazor.Pages.MisProductos
{
    public partial class NuevoProducto
    {
        [Inject] private IProductoServicio productoServicio { get; set; }
        [Inject] private NavigationManager navigationManager { get; set; }
        [Inject] private SweetAlertService Swal { get; set; }

        Producto prod = new Producto();

        string imgUrl = string.Empty;

        private async Task SeleccionarImagen(InputFileChangeEventArgs e)
        {
            IBrowserFile imgFile = e.File;  // carga imgFile con la imagen que viene del navegador
            var buffers = new byte[imgFile.Size]; // asig a buffers el arreglo de bytes con la imagen
            prod.Foto = buffers;
            await imgFile.OpenReadStream().ReadAsync(buffers); // muestra vista previa de la imagen
            string imageType = imgFile.ContentType;
            imgUrl = $"data:{imageType};base64,{Convert.ToBase64String(buffers)}";

        }

        protected async Task Guardar()
        {
            if(string.IsNullOrWhiteSpace(prod.Codigo) || string.IsNullOrWhiteSpace(prod.Descripcion))
            {
                return;
            }

            Producto prodExistente = new Producto();
            prodExistente = await productoServicio.GetPorCodigoAsync(prod.Codigo);

            if(prodExistente == null)
            {
                await Swal.FireAsync("Advertencia", "Ya esiste un producto con el mismo codigo", SweetAlertIcon.Warning);
                return;
            }

            bool inserto = await productoServicio.NuevoAsync(prod);
            if(inserto)
            {
                await Swal.FireAsync("Atencion", "Producto Guardado exitosamente", SweetAlertIcon.Success);
            }
            else
            {
                await Swal.FireAsync("Error", "El Producto no se pudo Guardar", SweetAlertIcon.Error);
            }
        }

        protected async Task Cancelar()
        {
            navigationManager.NavigateTo("/Productos");
        }
    }
}
