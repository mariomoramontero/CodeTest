using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CodeTest.ViewModels;
public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty]
    private string? username;

    [RelayCommand]
    async Task GoToSecondPage()
    {
        if (!string.IsNullOrWhiteSpace(Username))
        {
            await Shell.Current.GoToAsync($"SecondPage?username={Username}");
        }
    }
}
