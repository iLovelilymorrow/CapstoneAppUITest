using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneAppUITest.Helpers {
    public static class UIScaler
    {
        public static double screenWidth => DeviceDisplay.MainDisplayInfo.Width;

        public static double fontSize => 45 * (screenWidth / 1920);

        public static double imageSize => 75 * (screenWidth / 1920);
    }
}