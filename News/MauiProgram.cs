﻿using Microsoft.Extensions.Logging;
using News.Services;
using News.View;
using News.ViewModel;

namespace News
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
                });

            builder.Services.AddSingleton<NewsService>();

            builder.Services.AddSingleton<NewsViewModel>();
            builder.Services.AddSingleton<NewsPage>();

            builder.Services.AddSingleton<NewsDetailViewModel>();
            builder.Services.AddSingleton<NewsDetailPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}