using CafeManagementSystem.ViewModels;
using System;

namespace CafeManagementSystem.Services;

public class NavigationService : INavigationService
{
    public event Action<ViewModelBase>? CurrentViewModelChanged;

    public void NavigateTo<T>() where T : ViewModelBase
    {
        throw new InvalidOperationException("Use NavigateTo(ViewModelBase) for ViewModels with parameters");
    }

    public void NavigateTo(ViewModelBase viewModel)
    {
        CurrentViewModelChanged?.Invoke(viewModel);
    }
}