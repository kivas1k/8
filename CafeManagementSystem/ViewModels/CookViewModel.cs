using CafeManagementSystem.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CafeManagementSystem.ViewModels;

public partial class CookViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _welcomeMessage = string.Empty;

    public CookViewModel(User user)
    {
        WelcomeMessage = $"Здравствуйте, {user.DisplayName} (Повар)";
    }
}