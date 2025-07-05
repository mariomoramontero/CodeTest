using CommunityToolkit.Mvvm.ComponentModel;
using CodeTest.Services;

namespace CodeTest.ViewModels;
public partial class SecondPageViewModel(IPlatformService platformService) : ObservableObject, IQueryAttributable
{
    private readonly IPlatformService _platformService = platformService;

    [ObservableProperty]
    private string? message;

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.TryGetValue("username", out var usernameObj) && usernameObj is string username)
        {
            Message = $"Hello {username} from {_platformService.GetPlatformName()}";
        }
    }
}
