using Microsoft.Extensions.Logging;
using MAUI_IoRT.Data;
using MAUI_IoRT.Services;

namespace MAUI_IoRT;

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
        builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<IRobotService, RobotService>();
        builder.Services.AddSingleton<WeatherForecastService>();

        return builder.Build();
    }
}
