namespace GalleryApp.ViewModels;

using CommunityToolkit.Mvvm.ComponentModel;
using GalleryApp.Models;
using GalleryApp.Services;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

public partial class GalleryViewModel : ViewModel
{
    private readonly IPhotoImporter photoImporter;

    [ObservableProperty]
    public ObservableCollection<Photo> photos;

    public GalleryViewModel(IPhotoImporter photoImporter) : base()
    {
        this.photoImporter = photoImporter; 
    }

    override protected internal async Task Initialize()
    {
        IsBusy = true;
        Photos = await photoImporter.Get(0, 20); 

        Photos.CollectionChanged += Photos_CollectionChanged;
        await Task.Delay(3000);
        IsBusy = false;
    }

    private void Photos_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
    {
        if (e.NewItems != null && e.NewItems.Count > 0)
        {
            IsBusy = false;
            Photos.CollectionChanged -= Photos_CollectionChanged;
        }
    }
}