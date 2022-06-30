using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// OpenCV
using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

namespace Image_Processing
{
    class ImageProcessing
    {
        
        /*
        public Image<Gray, byte> histogramEqualization(Image<Bgr, byte> inputImg)
        {
            // Convert to grayscale image:
            Image<Gray, byte> grayImg = inputImg.Convert<Gray, byte>();

            Mat newImg = new Mat();
            
            int height = grayImg.Width;
            int width = grayImg.Height;

            // Create Matrix:
            Image<Gray, byte> img = new Image<Gray, byte>(width, height);
            Image<Gray, byte> new_img = new Image<Gray, byte>(width, height);

            grayImg = img;

            byte gray_level;
            int  S;

            int[] img_hist = new int[256];
            int[] output_hist = new int[256];

            double[] pdf = new double[256];
            double[] cdf = new double[256];

            int total = width * height;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    gray_level = img[i, j];

                    img_hist[gray_level]++;
                }
            }

            for (int i = 0; i < 256; i++)
            {
                pdf[i] = (double)img_hist[i] / (double)total;

                if (i == 0)
                {
                    cdf[i] = pdf[i];
                }
                else
                {
                    cdf[i] = cdf[i - 1] + pdf[i];
                }
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    gray_level = Convert.ToInt32(img[i, j]);
                    S = (int)(cdf[gray_level] * 255.0 + 0.5);

                    Gray l = new Gray(S);
                    new_img[i, j] = l;

                    output_hist[S]++;
                }
            }

            newImg.CopyTo(grayImg);
            return grayImg;
        }
        */
        
    }
}
