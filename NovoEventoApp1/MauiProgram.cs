using Microsoft.Extensions.Logging;

namespace NovoEventoApp1
{
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Oswald.ttf", "Oswald");
                    fonts.AddFont("DMSans-Italic.ttf", "DMSans-Italic");
                    fonts.AddFont("DMSans-VariableFont.ttf", "DMSans-Variable");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
