using CafeManagementSystem.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CafeManagementSystem.ViewModels;

public partial class WaiterViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _welcomeMessage = string.Empty;

    public WaiterViewModel(User user)
    {
        WelcomeMessage = $"Здравствуйте, {user.DisplayName} (Официант)";
    }
}