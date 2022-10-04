namespace DoToo.ViewModels;

using CommunityToolkit.Mvvm.Input;
using DoToo.Repositories;
using DoToo.Views;

public partial class MainViewModel : ViewModel
{
    private readonly ITodoItemRepository repository;
    private readonly IServiceProvider services;

    public MainViewModel(ITodoItemRepository repository, IServiceProvider services)
    {
        this.repository = repository;
        this.services = services;
        Task.Run(async () => await LoadData());
    }
    private async Task LoadData()
    {
    }

    [RelayCommand]
    public async Task AddItem() => await Navigation.PushAsync(services.GetRequiredService<ItemView>());

}
