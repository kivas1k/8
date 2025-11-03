using CafeManagementSystem.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CafeManagementSystem.ViewModels;

public partial class AdminViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _welcomeMessage = string.Empty;

    public AdminViewModel(User user)
    {
        WelcomeMessage = $"Здравствуйте, {user.DisplayName} (Администратор)";
    }
}