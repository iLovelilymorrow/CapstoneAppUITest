using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneAppUITest.Helpers {
    public static class UIScaler
    {
        public static double screenWidth => DeviceDisplay.MainDisplayInfo.Width;
        public static double screenDensity => DeviceDisplay.MainDisplayInfo.Density;

        public static double fontSizeByDensity => 65 / screenDensity;
        public static double imageSizeByDensity => 105 / screenDensity;

        public static double fontSize => 65 * (screenWidth / 1920);

        public static double imageSize => 105 * (screenWidth / 1920);
    }
}