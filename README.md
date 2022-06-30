# Scracth-Detection-for-Automated-Optical-Inpection-AOI

Automated optical inspection (AOI) is getting popular in quality control in manufacturing industry. There is a huge demand to install AOI system in production line seamlessly. Thus, a challenging problem which arises from rapid production is how to control the quality of product in reasonable amount of time.
This project developed an AOI system to inspect the defect on metal surface in a production lines. The type of the defects is a scratch defect. Here, we proposed a method of detecting the defect using several steps of digital image processing, including: 
(1) ROI
(2) Gaussian filtering
(3) Canny edge detection
(4) Dilation
(5) Contour
(6) Bounding box, and 
(7) size filtering

## Defect Detection Method

In this project, the metal surface inspection for detection the defects are performed by using digital image processing. Overall, the image processing consist of 8 steps. The first step is convert the input image (BGR) into a grayscale image (GRAY). Then, we used the Region of Interest (ROI) to select the detection area to eliminate the are outside the target of interest. By performing ROI, it can also eliminate the noice caused by the image background and the other objects around the target of interest. After that, we use 2-D Gaussian filtering to smooth the image. This process intend to reduce the noise in the image before processing the edge detection using Canny Edge Detection. Canny method is of the most commonly used image processing tools for edge detection in very robust manner. By performing edge detection, we can find all the edge in the image including the edge of the scratch defect. In the next step, we need to eliminate the edge that are not the defect. Firstly, we perform morphological operation using dilation to thick the line edge resulted by Canny. Then we used the contour detection and then determine the bounding box for each contour. At the last step, we filter the scratch based on the size of the contour and then we draw the bounding box in the image to show the defect area.

![method](images/method.PNG)

## 1. 2D gaussian filtering

The input images have a lot of noise due to unstable lighting conditions. The noises of the image need to be reduced in order to minimize the noise when performing the edge detection. Here, Gaussian filter is used for blurring and noise reduction. Blurring is used in preprocessing tasks, such as removal of small details from an image and bridging of small gaps in lines or curves. Noise reduction can be accomplished by blurring with a linear and nonlinear filtering.

![Gaussian Filtering](/images/gaussian.PNG)


