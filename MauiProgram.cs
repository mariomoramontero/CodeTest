using CodeTest.Services;
using CodeTest.ViewModels;
using Microsoft.Extensions.Logging;

namespace CodeTest
{
    public static partial class MauiProgram
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

            // Call platform-specific service registration
            builder.ConfigurePlatformServices();
#if DEBUG
            builder.Logging.AddDebug();
#endif
            builder.Services.AddTransient<MainPageViewModel>();
            builder.Services.AddTransient<SecondPageViewModel>();

            //builder.Services.AddSingleton<IPlatformService, PlatformService>();

            return builder.Build();
        }

        // Partial method to be implemented per platform
        public static partial void ConfigurePlatformServices(this MauiAppBuilder builder);
    }
}
