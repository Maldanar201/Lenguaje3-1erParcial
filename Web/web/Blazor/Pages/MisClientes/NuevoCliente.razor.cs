﻿using Blazor.Interfaces;
using Blazor.Servicios;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using Modelos;

namespace Blazor.Pages.MisClientes
{
    public partial class NuevoCliente
    {
        [Inject] private IClienteServicio clienteServicio { get; set; }
        [Inject] private NavigationManager navigationManager { get; set; }
        [Inject] private SweetAlertService Swal { get; set; }

        Cliente clien = new Cliente();

        protected async Task Guardar()
        {
            if (string.IsNullOrWhiteSpace(clien.Identidad) || string.IsNullOrWhiteSpace(clien.Nombre))
            {
                return;
            }

            Cliente clienExistente = new Cliente();
            clienExistente = await clienteServicio.GetPorIdentidadAsync(clien.Identidad);

            if (clienExistente == null)
            {
                await Swal.FireAsync("Advertencia", "Ya esiste un Cliente con el mismo numero de Identidad", SweetAlertIcon.Warning);
                return;
            }

            bool inserto = await clienteServicio.NuevoAsync(clien);
            if (inserto)
            {
                await Swal.FireAsync("Atencion", "Cliente Guardado exitosamente", SweetAlertIcon.Success);
            }
            else
            {
                await Swal.FireAsync("Error", "El Cliente no se pudo Guardar", SweetAlertIcon.Error);
            }
        }

        protected async Task Cancelar()
        {
            navigationManager.NavigateTo("/Clientes");
        }
    }
}
