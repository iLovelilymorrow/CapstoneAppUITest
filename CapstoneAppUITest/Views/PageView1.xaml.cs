using Microsoft.Maui.Graphics.Platform;
using System.Diagnostics;

namespace CapstoneAppUITest.Views;

public partial class PageView1 : ContentPage
{
	public PageView1()
	{
		InitializeComponent();
    }
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
     Debug.WriteLine("DISPLAY RES");
     Debug.WriteLine(DeviceDisplay.MainDisplayInfo.Width +" "+ DeviceDisplay.MainDisplayInfo.Height);
     Debug.WriteLine(niggaLabel.FontSize);
     Debug.WriteLine(DeviceDisplay.MainDisplayInfo.Density);
    }

    /*
    private void testButton1_Clicked(object sender, EventArgs e)
    {
     if (testButton1.Source.ToString().Contains("tangina.png"))
     {
      testButton1.Source = "tangina2.png";
     }
     else
     {
      testButton1.Source = "tangina.png";
     }
    }*/
}