using System;
using threeplatforms.Interfaces;
using threeplatforms.macOS.Injected;
using Xamarin.Forms;

[assembly: Dependency(typeof(ScreenSize))]
namespace threeplatforms.macOS.Injected
{
    public class ScreenSize : IScreenSize
    {
        public double Width => AppDelegate.Self.MainWindow.Frame.Width;

        public double Height => AppDelegate.Self.MainWindow.Frame.Height;
    }
}
