using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.UI;
using Emgu.CV.Util;
using Emgu.CV.Structure;

namespace Tes_App
{
    public partial class mainForm : Form
    {
        // Input / Output Image :
        Image<Bgr, byte> input_color_image;
        Image<Bgr, byte> output_image;

        // Process Images :
        // =========================================
        Image<Gray, byte> processImage1;
        Image<Gray, byte> processImage2;
        Image<Gray, byte> processImage3; 
        Image<Gray, byte> processImage4;

        // (Default) Canny Threshold :
        // =========================================
        public int thresholdL = 80;
        public int thresholdH = 130;

        // (Default) Gaussian Smoothing :
        public int kernel_size = 5;
        public double sigmaX = 1.4;
        public double sigmaY = 0;

        // Hough Transform
        public int rho;
        public float tetha;
        public int threshold;
        public int min_length;
        public int gap;

        // ROI:
        public int roiX = 0;
        public int roiY = 70;
        public int roiW;
        public int roiH = 930;

        // Dilation :
        public int dilation_i = 4;

        // Size Filtering :
        public int min_size = 100;
        public int max_size = 3000;
             

        string filename;
        string filepath;

        SettingForm setForm;

        public mainForm()
        {
            InitializeComponent();
            mainImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            lamp.BackColor = Color.LightGray;
            setForm = new SettingForm(this);
        }

        // ===================================================
        //                     Load Image :
        // ===================================================
        public void LoadImage()
        {
            openFileDialog1.Filter = "Image files (*.JPEG;*.JPG;*;*.BMP;*.PNG)|*.JPEG;*.JPG;*;*.BMP;*.PNG";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                input_color_image = new Image<Bgr, byte>(openFileDialog1.FileName);
                
                filename = Path.GetFileName(openFileDialog1.FileName);
                filepath = Path.GetDirectoryName(openFileDialog1.FileName);

                this.Text = "AOI System - " + filename;
                toolStripStatusLabel1.Text = filepath;

                inputImageBox.Image = input_color_image.Bitmap;

                gbInputImage.Enabled = true;
                gbMainImage.Enabled = true;
                gbOutputImage.Enabled = true;
                gbProcessImage.Enabled = true;
                gbResult.Enabled = true;
                roiW = input_color_image.Width;
            }
        }
        private void BtnOpen_Click(object sender, EventArgs e)
        {
            clearImageBox();
            LoadImage();
        }
        private void MenuOpen_Click(object sender, EventArgs e)
        {
            clearImageBox();
            LoadImage();
        }

        // ===========================================================
        // Save File :
        // ===========================================================
        private void MenuSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Image files (*.JPEG;*.JPG;*;*.BMP;*.PNG)|*.JPEG;*.JPG;*;*.BMP;*.PNG";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = filepath + "/" + filename + "_Canny.JPEG";
                CvInvoke.Imwrite(path, input_color_image);
            }
        }

        // ===========================================================
        // Show the image from the process box into the main Image box
        // ===========================================================
        private void inputImageBox_Click(object sender, EventArgs e)
        {
            mainImageBox.Image = input_color_image;
        }

        private void processBox1_Click(object sender, EventArgs e)
        {
            mainImageBox.Image = processImage1;
        }

        private void processBox2_Click(object sender, EventArgs e)
        {
            mainImageBox.Image = processImage2;
        }

        private void processBox3_Click(object sender, EventArgs e)
        {
            mainImageBox.Image = processImage3;
        }
        private void processBox4_Click(object sender, EventArgs e)
        {
            mainImageBox.Image = processImage4;
        }
        private void outputImageBox_Click(object sender, EventArgs e)
        {
            mainImageBox.Image = output_image;
        }

        private void mainImageBox_DoubleClick(object sender, EventArgs e)
        {
            int w = input_color_image.Width / 2;
            int h = input_color_image.Height / 2;
            mainImageBox.SetZoomScale(1.0, new Point(w, h));
            mainImageBox.SendToBack();
        }

        private void menuRoi_Click(object sender, EventArgs e)
        {

        }

        // Clear the picture Box :
        // ============================================================
        private void BtnClear_Click(object sender, EventArgs e)
        {
            clearImageBox();
        }
        private void clearImageBox()
        {
            if (inputImageBox.Image != null) inputImageBox.Image = null;
            if (mainImageBox.Image != null) mainImageBox.Image = null;
            if (processBox1.Image != null) processBox1.Image = null;
            if (processBox2.Image != null) processBox2.Image = null;
            if (processBox3.Image != null) processBox3.Image = null;
            if (processBox4.Image != null) processBox4.Image = null;
            if (outputImageBox.Image != null) outputImageBox = null;
        }


        // ==============================================================
        // Update Paremeter :
        // ==============================================================
        public void update_canny(int a, int b)
        {
            thresholdH = b;
            thresholdL = a;
        }
        public void update_gaussian(int kernel, double sigX, double sigY)
        {
            kernel_size = kernel;
            sigmaX = sigX;
            sigmaY = sigY;
        }
        public void update_ROI(int x, int y, int w, int h)
        {
            roiH = h;
            roiW = w;
            roiX = x;
            roiY = y;

            updateROI(input_color_image);
        }
        public void updateROI(Image<Bgr, byte> image)
        {
            Rectangle mask = new Rectangle(roiX, roiY, roiW, roiH);
            Image<Bgr, byte> roiBox = input_color_image.Copy();
            roiBox.Draw(mask, new Bgr(0, 255, 0), 2);

            Image<Bgr, byte> showImg = roiBox.Copy();
            if (mainImageBox.Image != null) mainImageBox.Image = null;
            mainImageBox.Image = showImg;
        }

        public void update_dilation(int i)
        {
            dilation_i = i;
            Image<Gray, byte> cannyImg = cannyEdgeProcessing(input_color_image, thresholdL, thresholdH);
            dilate_img(cannyImg, i);
        }

        public void update_filter(int max, int min)
        {
            max_size = max;
            min_size = min;
        }
        

        // Setting Parameter :
        // ================================================================
        private void menuConfig_Click(object sender, EventArgs e)
        {
            if (setForm.IsDisposed)
            {
                setForm = new SettingForm(this);
            }
            setForm.Show();
        }


        // =====================================================
        // Image Processing :
        // =====================================================

        // Canny Edge Detection :
        // =====================================================
        public Image<Gray, byte> cannyEdgeProcessing(Image<Bgr, byte> inputImg, int thresholdL, int thresholdH)
        {

            // Check wheter the input image has been loaded :
            if (inputImg == null)
            {
                MessageBox.Show("Load the image first", "Process error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            // Get image size :
            int width = inputImg.Width;
            int height = inputImg.Height;
           
            // Image Object :
            Image<Gray, byte> grayscaleImg = new Image<Gray, byte>(width, height);
            Image<Gray, byte> gaussianImg = new Image<Gray, byte>(width, height);
            Image<Gray, byte> cannyImg = new Image<Gray, byte>(width, height);

            // Step 1 : Convert to grayscale image
            CvInvoke.CvtColor(inputImg, grayscaleImg, ColorConversion.Bgr2Gray);
            processImage1 = grayscaleImg;
            if(processBox1.Image != null) processBox1.Image.Dispose();
            processBox1.Image = processImage1.Bitmap;

            // Step 2 : Gaussian Smoothing (Blurring)
            CvInvoke.GaussianBlur(grayscaleImg, gaussianImg, new Size(kernel_size, kernel_size), sigmaX, sigmaY, BorderType.Default);
            processImage2 = gaussianImg;
            if(processBox2.Image != null) processBox2.Image.Dispose();
            processBox2.Image = processImage2.Bitmap;

            string path = filepath + "/Result/" + filename + "_gaussian.JPEG";
            CvInvoke.Imwrite(path, gaussianImg);

            // Step 3 : Canny Edge Detection
            CvInvoke.Canny(gaussianImg, cannyImg, thresholdL, thresholdH);
            processImage3 = cannyImg;
            if (processBox3.Image != null) processBox3.Image.Dispose();
            processBox3.Image = processImage3.Bitmap;
            return cannyImg;
        }

        // Hough Transform :
        // ================================================================
        public Image<Bgr, byte> houghTransform(Image<Gray, byte> inputImg)
        {
            // Check wheter the input image has been loaded :
            if (inputImg == null)
            {
                MessageBox.Show("Load the image first", "Process error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            // Hough Transform :
            LineSegment2D[] lines = CvInvoke.HoughLinesP(inputImg, 1, Math.PI / 31.0, 20, 30, 20);

            // Draw Line :
            Image<Bgr, byte> lineImg = inputImg.Convert<Bgr, byte>();
            foreach (LineSegment2D line in lines)
            {
                lineImg.Draw(line, new Bgr(Color.Red), 2);
            }

            return lineImg;
        }

        // Image Dilation :
        // ==================================================================
        public void dilate_img(Image<Gray, byte> inputCanny, int iteration)
        {
            if (inputCanny == null)
            {
                MessageBox.Show("Do the canny first!!!", "Process error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Dilate the image :
            Image<Gray, byte> morphImg = inputCanny.Dilate(iteration); 
            mainImageBox.Image = morphImg;
        }


        // ==================================================================
        // Scrath Detection :
        // ==================================================================
        public void scrath_detection(Image<Bgr, byte> inputImg)
        {
            // Check wheter the input image has been loaded :
            if (inputImg == null)
            {
                MessageBox.Show("Load the image first", "Process error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Perform the ROI :
            Rectangle mask = new Rectangle(roiX, roiY, roiW, roiH);
            Image<Bgr, byte> roiBox = input_color_image.CopyBlank();            
            roiBox.Draw(mask, new Bgr(0, 255, 0), 2);
            inputImg.ROI = mask;

            // Get the edge :
            Image<Gray, byte> cannyImg = cannyEdgeProcessing(inputImg, thresholdL, thresholdH);

            // Dilate the image :
            Image<Gray, byte> morphImg = cannyImg.Dilate(dilation_i);
            processImage4 = morphImg.Copy();
            processBox4.Image = processImage4.Bitmap;

            // Find Contour :
            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            Mat hier = new Mat();
            CvInvoke.FindContours(morphImg, contours, hier, RetrType.External, ChainApproxMethod.ChainApproxSimple);

            Image<Bgr, byte> outputimage = input_color_image.Copy();

            int scratch_num = 0;

            // Draw Bounding Box :
            for (int i = 0; i < contours.Size; i++)
            {
                Rectangle rect = CvInvoke.BoundingRectangle(contours[i]);

                int luas = rect.Height * rect.Width;
                
                // Filtering
                if (luas > min_size && luas < max_size)
                {
                    scratch_num++;
                    outputimage.Draw(rect, new Bgr(0, 0, 255), 2);
                }
            }

            richTextBox1.AppendText(Environment.NewLine + "- Number of defect : " + scratch_num);

            if (scratch_num > 0)
                lamp.BackColor = Color.Red;
            else
                lamp.BackColor = Color.Green;

            //     outputimage.Draw(mask, new Bgr(0, 255, 255), 3);
            output_image = outputimage.Copy();
            if (mainImageBox.Image != null) mainImageBox.Image.Dispose();
            mainImageBox.Image = outputimage;
            //outputImageBox.Image = outputimage.Bitmap;


            // Save File
            string path = filepath + "/Result/" + filename + "_Result.JPEG";
            CvInvoke.Imwrite(path, outputimage);
            path = filepath + "/Result/" + filename + "_Canny.JPEG";
            CvInvoke.Imwrite(path, cannyImg);
            path = filepath + "/Result/" + filename + "_morphologic_dilation.JPEG";
            CvInvoke.Imwrite(path, processImage4);           
        }
        // Do Scratch Detection :
        // ==================================================================
        private void BtnProcess_Click(object sender, EventArgs e)
        {
            scrath_detection(input_color_image);
         }
        
        private void MenuCannyDetection_Click(object sender, EventArgs e)
        {
            Image<Gray, byte> outputImg = cannyEdgeProcessing(input_color_image, thresholdL, thresholdH);
            mainImageBox.Image = outputImg;
        }

        private void menuPose_Click(object sender, EventArgs e)
        {
            poseDetection(input_color_image);
        }



        // Pose Detection :
        // ===================================================================

        public void poseDetection(Image<Bgr, byte> inputImg)
        {
            // Check wheter the input image has been loaded :
            if (inputImg == null)
            {
                MessageBox.Show("Load the image first", "Process error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Get image size :
            int width = inputImg.Width;
            int height = inputImg.Height;

            // Image Object :

            Image<Gray, byte> thresholdImg = new Image<Gray, byte>(width, height);
            Image<Gray, byte> grayscaleImg = new Image<Gray, byte>(width, height);
            Image<Gray, byte> gaussianImg = new Image<Gray, byte>(width, height);
            Image<Gray, byte> cannyImg = new Image<Gray, byte>(width, height);

            CvInvoke.CvtColor(inputImg, grayscaleImg, ColorConversion.Bgr2Gray);

            CvInvoke.EqualizeHist(grayscaleImg, grayscaleImg);
            CvInvoke.GaussianBlur(grayscaleImg, gaussianImg, new Size(5, 5), 1.0, 0, BorderType.Default);
            CvInvoke.Threshold(gaussianImg, thresholdImg, 128, 255, ThresholdType.BinaryInv);
            cannyImg = thresholdImg.Erode(12);
            cannyImg = cannyImg.Dilate(10);
            cannyImg = cannyImg.Erode(18);
            cannyImg = cannyImg.Dilate(35);

            // Step 3 : Canny Edge Detection
            //CvInvoke.Canny(gaussianImg, cannyImg, 80, 150);
            //mainImageBox.Image = thresholdImg;

            /*
            //Find Contour :
            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            Mat hier = new Mat();
            CvInvoke.FindContours(cannyImg, contours, hier, RetrType.External, ChainApproxMethod.ChainApproxNone);

            Image<Bgr, byte> outputimage = input_color_image.Copy();

            // Draw Bounding Box :
            for (int i = 0; i < contours.Size; i++)
            {
                //Rectangle rect = CvInvoke.BoundingRectangle(contours[i]);
                RotatedRect rect = CvInvoke.MinAreaRect(contours[i]);

                Point a = new Point(2, 2);
                
                outputimage.Draw(rect, new Bgr(0, 0, 255), 2);

            }
            */

            mainImageBox.Image = cannyImg;
        }
    }
}
