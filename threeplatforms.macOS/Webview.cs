using AppKit;
using threeplatforms;
using threeplatforms.macOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.MacOS;

[assembly: ExportRenderer(typeof(CustomWebView), typeof(CustomWebviewRenderer))]
namespace threeplatforms.macOS
{
    public class CustomWebviewRenderer : ViewRenderer<CustomWebView, WebKit.WebView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<CustomWebView> e)
        {
            base.OnElementChanged(e);

            var view = Element as CustomWebView;
            if (view == null || NativeView == null)
            {
                return;
            }

            AutoresizingMask = NSViewResizingMask.HeightSizable | NSViewResizingMask.WidthSizable;
            ScaleUnitSquareToSize(new CoreGraphics.CGSize(1.5, 1.5));
            NeedsDisplay = true;
        }
    }
}
