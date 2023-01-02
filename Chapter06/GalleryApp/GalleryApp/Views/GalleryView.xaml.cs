namespace GalleryApp.Views;

using GalleryApp.Models;
using GalleryApp.ViewModels;

public partial class GalleryView : ContentPage
{
	public GalleryView(GalleryViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
        MainThread.InvokeOnMainThreadAsync(viewModel.Initialize);
    }
}