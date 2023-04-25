using Blazor.Interfaces;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components;
using Modelos;
using Blazor.Servicios;

namespace Blazor.Pages.MisProductos
{
    public partial class EditarProducto
    {
        [Inject] private IProductoServicio productoServicio { get; set; }
        [Inject] private NavigationManager navigationManager { get; set; }
        [Inject] private SweetAlertService Swal { get; set; }

        Producto prod = new Producto();

        [Parameter] public string Codigo { get; set; }

        string imgUrl = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            if(!string.IsNullOrEmpty(Codigo))
            {
                prod = await productoServicio.GetPorCodigoAsync(Codigo);
            }
        }

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
            if (string.IsNullOrWhiteSpace(prod.Codigo) || string.IsNullOrWhiteSpace(prod.Descripcion))
            {
                return;
            }           

            bool edito = await productoServicio.ActiualizarAsync(prod);
            if (edito)
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

        protected async Task Eliminar()
        {
            bool elimino = false;

            SweetAlertResult result = await Swal.FireAsync(new SweetAlertOptions
            {
                Title = "¿Seguro que desea eliminar el Producto?",
                Icon = SweetAlertIcon.Question,
                ShowCancelButton = true,
                ConfirmButtonText = "Aceptar",
                CancelButtonText = "Cancelar",
            });

            if (!string.IsNullOrEmpty(result.Value))
            {
                elimino = await productoServicio.EliminarAsync(prod.Codigo);

                if (elimino)
                {
                    await Swal.FireAsync("Felicidades", "El Producto se Elimino", SweetAlertIcon.Success);
                    navigationManager.NavigateTo("/Productos");
                }
                else
                {
                    await Swal.FireAsync("Error", "El Producto No pudo ser Eliminado", SweetAlertIcon.Error);
                }
            }

            navigationManager.NavigateTo("/Productos");
        }
    }
}
