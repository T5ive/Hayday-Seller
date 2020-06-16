using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Hayday_Seller.Utility
{
    public class Win32Bot
    {
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        private static int MakeLParam(int loWord, int hiWord)
        {
            return (hiWord << 16) | (loWord & 0xFFFF);
        }

        public static void ClickInBg(IntPtr iHandle, int posX, int posY, int count = 1)
        {
            for (var i = 0; i < count; i++)
            {
                SendMessage(iHandle, 0x201, 0x00000001, MakeLParam(posX, posY));
                SendMessage(iHandle, 0x202, 0x00000000, MakeLParam(posX, posY));
            }
        }

        public static void AwaitSleep(int slp)
        {
            var task = WaitMy(slp);

            task.Wait();
        }

        private static Task WaitMy(int delay)
        {
            return Task.Run(async () => await Task.Delay(delay));
        }
    }
}