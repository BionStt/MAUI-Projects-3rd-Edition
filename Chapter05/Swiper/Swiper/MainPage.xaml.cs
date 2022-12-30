namespace Swiper;

using Swiper.Controls;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        AddInitialPhotos();
    }

    private void AddInitialPhotos()
    {
        for (int i = 0; i < 10; i++)
        {
            InsertPhoto();
        }
    }

    private void InsertPhoto()
    {
        var photo = new SwiperControl(); 
        this.MainGrid.Children.Insert(0, photo);
    }

}

