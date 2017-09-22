using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ImageBot.Screenshot_Configurations
{
    public static class Screenshot
    {
        [Flags]
        public enum nFlags
        {
            PW_NONE = 0,
            PW_PRINTCLIENT = 1
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }

        private static Bitmap GlobalBMP;
        private static RECT wRect;


        /// <summary>
        /// Screenshot of the desktop and every window on it - single monitor
        /// </summary>
        /// <param name="X">Width of the screen</param>
        /// <param name="Y">Height of the screen</param>
        /// <param name="szScreen">Size in total</param>
        /// <returns>the bitmap of the desktop</returns>
        public static Bitmap ScDesktop(int X, int Y, Size szScreen)
        {
            if (GlobalBMP != null)
                GlobalBMP.Dispose();
            GlobalBMP = new Bitmap(X, Y);
            using (Graphics gDesktop = Graphics.FromImage(GlobalBMP))
            {
                gDesktop.CopyFromScreen(0, 0, 0, 0, szScreen, CopyPixelOperation.SourceCopy);
                return GlobalBMP;
            }
        }

        /// <summary>
        /// Takes a screenshot of a window, opened or minimzed. 
        /// </summary>
        /// <param name="pHandle">Handle to window to you want the screenshot</param>
        /// <returns></returns>

        public static Bitmap ScWindow(IntPtr pHandle)
        {
            if (GlobalBMP != null)
                GlobalBMP.Dispose();
            pInvokes.GetWindowRect(pHandle, out wRect);

            GlobalBMP = new Bitmap(wRect.Right - wRect.Left + 1, wRect.Bottom - wRect.Top + 1, PixelFormat.Format32bppArgb);
            using (Graphics gWindow = Graphics.FromImage(GlobalBMP))
            {
                IntPtr hdcBitmap = gWindow.GetHdc();
                pInvokes.PrintWindow(pHandle, hdcBitmap, (int)nFlags.PW_NONE);
            }

            return GlobalBMP;
        }
        /// <summary>
        /// takes a screenshot of an open window
        /// </summary>
        /// <param name="hWnd">Handle of open window</param>
        /// <returns>screenshot of open window</returns>
        public static Bitmap OpenScWindow(IntPtr hWnd)
        {
            if (GlobalBMP != null)
            {
                GlobalBMP.Dispose();

            }
            pInvokes.GetWindowRect(hWnd, out wRect);

            int width = wRect.Right - wRect.Left;
            int height = wRect.Bottom - wRect.Top;

            GlobalBMP = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            using (Graphics graphics = Graphics.FromImage(GlobalBMP))
            {
                graphics.CopyFromScreen(wRect.Left, wRect.Top, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);
            }

            return GlobalBMP;
            

        }


    }
}
