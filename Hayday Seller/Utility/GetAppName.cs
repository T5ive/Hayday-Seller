using System;
using System.Runtime.InteropServices;

namespace Hayday_Seller.Utility
{
    public class GetAppName
    {
        [DllImport("User32.dll")] private static extern IntPtr FindWindow(string strClassName, string strWindowName);

        public static string App = "NoxPlayer";
        public static string Class = "Qt5QWindowIcon";
        public static IntPtr Hayday;

        public static void AppName()
        {
            Hayday = FindWindow(Class, App);
        }
    }
}