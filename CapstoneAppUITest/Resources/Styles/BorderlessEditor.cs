using Microsoft.Maui.Controls;
#if ANDROID
using Microsoft.Maui.Handlers;
using Android.Graphics.Drawables;
#elif IOS
using Microsoft.Maui.Handlers;
using UIKit;
#endif

namespace CapstoneAppUITest.Resources.Styles
{
    public class BorderlessEditor : Editor
    {
        public BorderlessEditor()
        {
#if ANDROID || IOS
            this.HandlerChanged += (s, e) =>
            {
                if (Handler is EditorHandler handler)
                {
#if ANDROID
                    // Android: Remove the background drawable (the border)
                    handler.PlatformView.Background = null;
#elif IOS
                    // iOS: Remove default border by setting background to clear and removing insets
                    handler.PlatformView.BackgroundColor = UIColor.Clear;
                    handler.PlatformView.Layer.BorderWidth = 0;
                    handler.PlatformView.TextContainerInset = UIEdgeInsets.Zero;
#endif
                }
            };
#endif
        }
    }
}