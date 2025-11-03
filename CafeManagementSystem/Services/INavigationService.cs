using CafeManagementSystem.ViewModels;
using System;

namespace CafeManagementSystem.Services;

public interface INavigationService
{
    // Добавьте это событие
    event Action<ViewModelBase>? CurrentViewModelChanged;
    
    void NavigateTo<T>() where T : ViewModelBase;
    void NavigateTo(ViewModelBase viewModel);
}