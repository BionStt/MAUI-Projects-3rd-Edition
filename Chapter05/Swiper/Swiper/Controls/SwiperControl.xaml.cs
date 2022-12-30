namespace Swiper.Controls;

using Swiper.Utils;

public partial class SwiperControl : ContentView
{
    public SwiperControl()
    {
        InitializeComponent();
        var picture = new Picture();
        descriptionLabel.Text = picture.Description;
        image.Source = new UriImageSource() { Uri = picture.Uri };
    }
}