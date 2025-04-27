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
    public class BorderlessEntry : Entry
    {
        public BorderlessEntry()
        {
#if ANDROID || IOS
            this.HandlerChanged += (s, e) =>
            {
                if (Handler is EntryHandler handler)
                {
#if ANDROID
                    // Android: Remove background (remove underline)
                    handler.PlatformView.Background = null;
#elif IOS
                    // iOS: Remove border style
                    handler.PlatformView.BorderStyle = UITextBorderStyle.None;
#endif
                }
            };
#endif
        }
    }
}