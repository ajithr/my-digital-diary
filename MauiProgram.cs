using Microsoft.AspNetCore.Components.WebView.Maui;
using MyDigitalDiary.Shared;
using MudBlazor.Services;
using Recurop;
using BlazorStrap;
using MudBlazor;
using Syncfusion.Blazor;
using BlazorPro.BlazorSize;

namespace MyDigitalDiary;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();
#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif

        //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
        builder.Services.AddMudServices(config =>
        {
            config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.TopCenter;
            config.SnackbarConfiguration.VisibleStateDuration = 3000;
        });
        builder.Services.AddRecurop();
        builder.Services.AddBlazorStrap();
        builder.Services.AddSyncfusionBlazor();
        builder.Services.AddMediaQueryService();
        builder.Services.AddScoped<UserState>();

        return builder.Build();
	}
}
