using CodeTest.Services;

namespace CodeTest.Platforms.iOS
{
    public class PlatformService : IPlatformService
    {
        public string GetPlatformName() => "iOS";
    }
}