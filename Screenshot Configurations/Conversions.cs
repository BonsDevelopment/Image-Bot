using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageBot.Screenshot_Configurations
{
    public static class Conversions
    {
        public static Bitmap ConvertBMP(string aFilePath)
        {
            Image imgFile = Image.FromFile(aFilePath);
            imgFile.Save("temp_bmp_conv", ImageFormat.Bmp);
            return (Bitmap)Image.FromFile("temp_bmp_conv");
        }
    }
}
