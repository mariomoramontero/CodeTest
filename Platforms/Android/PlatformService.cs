using CodeTest.Services;

namespace CodeTest.Platforms.Android
{
    public class PlatformService : IPlatformService
    {
        public string GetPlatformName() => "Android";
    }
}