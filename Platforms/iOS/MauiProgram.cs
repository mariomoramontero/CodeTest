using CodeTest.Platforms.iOS;
using CodeTest.Services;

namespace CodeTest;


public static partial class MauiProgram
{
    public static partial void ConfigurePlatformServices(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<IPlatformService, PlatformService>();
    }
}