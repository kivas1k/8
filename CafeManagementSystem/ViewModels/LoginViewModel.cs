using CafeManagementSystem.Models;
using CafeManagementSystem.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CafeManagementSystem.ViewModels;

public partial class LoginViewModel : ViewModelBase
{
    private readonly AuthService _authService;
    private readonly INavigationService _navigationService;
    
    [ObservableProperty]
    private string _username = string.Empty;
    
    [ObservableProperty]
    private string _password = string.Empty;
    
    [ObservableProperty]
    private string _errorMessage = string.Empty;

    public LoginViewModel(AuthService authService, INavigationService navigationService)
    {
        _authService = authService;
        _navigationService = navigationService;
    }

    [RelayCommand]
    private void Login()
    {
        if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
        {
            ErrorMessage = "Введите логин и пароль";
            return;
        }

        var user = _authService.Authenticate(Username, Password);
        
        if (user == null)
        {
            ErrorMessage = "Неверный логин или пароль";
            return;
        }

        ErrorMessage = string.Empty;
        
        // Переход на соответствующую страницу с передачей пользователя
        switch (user.Role)
        {
            case UserRole.Admin:
                _navigationService.NavigateTo(new AdminViewModel(user));
                break;
            case UserRole.Waiter:
                _navigationService.NavigateTo(new WaiterViewModel(user));
                break;
            case UserRole.Cook:
                _navigationService.NavigateTo(new CookViewModel(user));
                break;
        }
    }
}