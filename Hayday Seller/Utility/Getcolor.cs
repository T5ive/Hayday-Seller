using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Hayday_Seller.Utility
{
    public class GetColor
    {
        #region DllImport

        [DllImport("user32.dll", SetLastError = true)] private static extern int GetWindowDC(int window);

        [DllImport("gdi32.dll", SetLastError = true)] private static extern uint GetPixel(int dc, int x, int y);

        [DllImport("user32.dll", SetLastError = true)] private static extern int ReleaseDC(int window, int dc);

        #endregion DllImport

        private static Color GetColorAt(int hwnd, int x, int y)
        {
            var dc = GetWindowDC(hwnd);
            var a = (int)GetPixel(dc, x, y);
            ReleaseDC(hwnd, dc);
            return Color.FromArgb(255, (a >> 0) & 0xff, (a >> 8) & 0xff, (a >> 16) & 0xff);
        }

        private static string HexConverterOld(Color c)
        {
            return $"0x{c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2")}";
        }

        public static bool GetColorFast(IntPtr iHandle, int x, int y, int pixelColorX)
        {
            var appHandle = iHandle;
            var hexStr = $"{pixelColorX:x}";
            hexStr = hexStr.ToUpper();
            if (hexStr.Length == 5)
            {
                hexStr = "0x0" + hexStr;
            }
            else
            {
                hexStr = "0x" + hexStr;
            }
            return HexConverterOld(GetColorAt(appHandle.ToInt32(), x, y)) == hexStr;
        }
    }
}