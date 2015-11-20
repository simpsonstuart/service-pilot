using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace ServiceTime
{
    public static class Colours
    {
        //sets the colors we can reference later in the pages
        public static Color DarkText = Color.Black;
        public static Color PositiveBackground = Color.FromRgb(200, 200, 200);
        public static Color NegativeBackground = Color.FromHsla(Color.Red.Hue, 1.0, 0.75);
        public static Color BackgroundGrey = Color.FromRgb(249, 249, 249);
        public static Color PositiveBalance = Color.FromRgb(37, 64, 33);
        public static Color NegativeBalance = Color.FromRgb(167, 167, 167);
        public static Color GreyBrown = Color.FromRgb(222, 221, 219);
        public static Color SubTitle = Color.FromRgb(121, 121, 119);
        public static Color NavText = Color.FromRgb(171, 0, 111);

        static Colours()
        {
            Device.OnPlatform(
                Android: () => {
                    PositiveBalance = PositiveBalance.AddLuminosity(0.3);
                    NegativeBalance = NegativeBalance.AddLuminosity(0.3);
                    SubTitle = Color.FromRgb(115, 129, 130);
                },
                WinPhone: () => {
                    PositiveBalance = PositiveBalance.AddLuminosity(0.3);
                    NegativeBalance = NegativeBalance.AddLuminosity(0.3);
                }
                );
        }
    }
}
