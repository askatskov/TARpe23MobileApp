using Microsoft.Extensions.Logging;

namespace MauiPlanets
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
                    fonts.AddFont("Montserrat-Medium.ttf", "Regularfont");
                    fonts.AddFont("Montserrat-Semibold.ttf", "Mediumfont");
                    fonts.AddFont("Montserrat-Bold.ttf", "Boldfont");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
