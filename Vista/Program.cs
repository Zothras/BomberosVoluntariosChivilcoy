using Vista.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Vista.Services;
using Microsoft.AspNetCore.Localization;
using System.Globalization;
using AntDesign;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration["ConnectionString"];

var serverVersion = ServerVersion.AutoDetect(connectionString);

builder.Services.AddDbContextFactory<BomberosDbContext>(
    dbContextOptions => dbContextOptions
    .UseMySql(connectionString, serverVersion)
    .LogTo(Console.WriteLine, LogLevel.Information)
    .EnableSensitiveDataLogging()
    .EnableDetailedErrors()
    );

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddAntDesign();
builder.Services.AddHostedService<InitData>();
builder.Services.AddScoped<IBomberoService, BomberoService>();
builder.Services.AddScoped<IBrigadaService, BrigadaService>();
builder.Services.AddScoped<IDepositoService, DepositoService>();
builder.Services.AddScoped<IVehiculoService, VehiculoService>();
builder.Services.AddScoped<ISalidaService, SalidaService>();
builder.Services.AddScoped<IParteService, ParteService>();

//Errores detallados
builder.Services.AddServerSideBlazor().AddCircuitOptions(options => { options.DetailedErrors = true; });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//Localizacion AntDesign
LocaleProvider.SetLocale("es-Es");

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.Run();
