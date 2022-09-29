namespace DoToo.ViewModels;

using DoToo.Repositories;

public class ItemViewModel : ViewModel
{
    private readonly ITodoItemRepository repository;

    public ItemViewModel(ITodoItemRepository repository)
    {
        this.repository = repository;
    }
}
