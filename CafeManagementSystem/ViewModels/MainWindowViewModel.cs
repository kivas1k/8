using CafeManagementSystem.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CafeManagementSystem.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private readonly INavigationService _navigationService;

    [ObservableProperty]
    private ViewModelBase? _currentViewModel;

    public MainWindowViewModel(INavigationService navigationService, AuthService authService)
    {
        _navigationService = navigationService;
        
        // Подписываемся на изменения навигации
        _navigationService.CurrentViewModelChanged += NavigationService_CurrentViewModelChanged;

        // Начинаем с экрана логина
        CurrentViewModel = new LoginViewModel(authService, navigationService);
    }

    private void NavigationService_CurrentViewModelChanged(ViewModelBase newViewModel)
    {
        CurrentViewModel = newViewModel;
    }
}