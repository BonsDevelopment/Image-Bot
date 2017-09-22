using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageBot.Screenshot_Configurations
{

    public static class scLocator
    {
        public static Task<Tuple<bool, Point>> Locate(Bitmap LImage, Bitmap sImage, Action<int, int,int,int> CallBack)
        {
            return Task.Run(() =>
            {
                for (int LImageX = 0; LImageX < LImage.Width; LImageX++)
                {

                    for (int LImageY = 0; LImageY < LImage.Height; LImageY++)
                    {

                        for (int sImageX = 0; sImageX < sImage.Width; sImageX++)
                        {

                            for (int sImageY = 0; sImageY < sImage.Height; sImageY++)
                            {
                                Color cSImage = sImage.GetPixel(sImageX, sImageY);
                                Color cLImage = LImage.GetPixel(LImageX + sImageX, LImageY + sImageY);

                                if (cSImage != cLImage)
                                    goto breakpoint;
                                CallBack(LImageX, LImageY,LImage.Width,LImage.Width);

                            }
                        }

                        return new Tuple<bool, Point>(true, new Point(LImageX, LImageY));
                    breakpoint:
                        continue;
                    }
                }

                return new Tuple<bool, Point>(false, new Point(0, 0));
            });
        }
    }
}
