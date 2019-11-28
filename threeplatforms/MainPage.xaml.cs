using threeplatforms.Interfaces;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace threeplatforms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            if (Device.RuntimePlatform != Device.macOS)
            {
                imgTest.WidthRequest = DeviceDisplay.MainDisplayInfo.Width;
                imgTest.HeightRequest = DeviceDisplay.MainDisplayInfo.Height;
            }
            else
            {
                imgTest.WidthRequest = DependencyService.Get<IScreenSize>().Width;
                imgTest.HeightRequest = DependencyService.Get<IScreenSize>().Height;
            }
        }
    }
}
