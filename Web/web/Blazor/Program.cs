//using Blazor.Data;
using Blazor;
using Blazor.Interfaces;
using Blazor.Servicios;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

Config cadena = new Config(builder.Configuration.GetConnectionString("MySQL"));
builder.Services.AddSingleton(cadena);

builder.Services.AddScoped<ILoginServicio, LoginServicio>();
builder.Services.AddScoped<IUsuarioServicio, UsuarioServicio>();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(); // tipo de autentificacion que usamos
builder.Services.AddHttpContextAccessor(); // acceder a los ususarios de la BD
builder.Services.AddResponseCompression();
builder.Services.AddControllers();
builder.Services.AddSweetAlert2();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthentication(); //valida el ususario si existe o esta activo
app.UseAuthorization();  // valida los roles o permisos del ususario

app.UseRouting();
app.MapControllers(); // indica que la aplicacion utilizara controles de blazor
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
