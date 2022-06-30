using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tes_App
{
    public partial class SettingForm : Form
    {
        // Main Form :
        mainForm main_form;

        // Canny Edge Threshold :
        int thresholdL;
        int thresholdH;

        // Gaussian Smoothing :
        int kernel_size;
        double sigmaX;
        double sigmaY;

        // Hough Transform
        int rho;
        float tetha;
        int threshold;
        int min_length;
        int gap;

        // ROI:
        int roiX;
        int roiY;
        int roiW;
        int roiH;

        // Dilation :
        int iteration;

        // Size Filtering :
        int min_size;
        int max_size;

        public SettingForm(mainForm form)
        {
            InitializeComponent();
            main_form = form;
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            numThresholdL.Value = main_form.thresholdL;
            numThresholdH.Value = main_form.thresholdH;
            numKernel.Value = main_form.kernel_size;
            numSigmaX.Value = new decimal(main_form.sigmaX);
            numSigmaY.Value = new decimal(main_form.sigmaY);
            numDilation.Value = main_form.dilation_i;
            numRoiH.Value = main_form.roiH;
            numRoiW.Value = main_form.roiW;
            numRoiX.Value = main_form.roiX;
            numRoiY.Value = main_form.roiY;
        }

        private void numSigmaX_ValueChanged(object sender, EventArgs e)
        {
            // Update Gaussian parameter:
            kernel_size = Convert.ToInt16(numKernel.Value);
            sigmaX = Convert.ToDouble(numSigmaX.Value);
            sigmaY = Convert.ToDouble(numSigmaY.Value);
            main_form.update_gaussian(kernel_size, sigmaX, sigmaY);
        }

        private void numThresholdL_ValueChanged(object sender, EventArgs e)
        {
            thresholdL = Convert.ToInt16(numThresholdL.Value);
            thresholdH = Convert.ToInt16(numThresholdH.Value);
            main_form.update_canny(thresholdL, thresholdH);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            max_size = Convert.ToInt16(num_max.Value);
            min_size = Convert.ToInt16(num_min.Value);

            roiX = Convert.ToInt16(numRoiX.Value);
            roiY = Convert.ToInt16(numRoiY.Value);
            roiH = Convert.ToInt16(numRoiH.Value);
            roiW = Convert.ToInt16(numRoiW.Value);

            main_form.update_ROI(roiX, roiY, roiW, roiH);
            main_form.update_filter(max_size, min_size);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numDilation_ValueChanged(object sender, EventArgs e)
        {
            iteration = Convert.ToInt16(numDilation.Value);
            main_form.update_dilation(iteration);
        }
    }
}
