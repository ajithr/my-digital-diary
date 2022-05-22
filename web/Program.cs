using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyDigitalDiaryWeb;
using MyDigitalDiaryWeb.Shared;

using MudBlazor.Services;
using Recurop;
using BlazorStrap;
using MudBlazor;
using BlazorPro.BlazorSize;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMudServices(config =>
{
    config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.TopCenter;
    config.SnackbarConfiguration.VisibleStateDuration = 3000;
});
builder.Services.AddRecurop();
builder.Services.AddBlazorStrap();
builder.Services.AddMediaQueryService();
builder.Services.AddScoped<UserState>();

await builder.Build().RunAsync();
