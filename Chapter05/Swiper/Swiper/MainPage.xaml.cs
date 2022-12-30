namespace Swiper;

using Swiper.Controls;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        MainGrid.Children.Add(new SwiperControl());
    }
}

