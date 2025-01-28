﻿using Microsoft.Extensions.Logging;

namespace Calc
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
                    fonts.AddFont("Cairo-Light.ttf", "RegularFont");
                    fonts.AddFont("Cairo-ExtraLight.ttf", "LightFon+t");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
