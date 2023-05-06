import cv2
from PIL import Image
import numpy as np
from math import *

# Read file and create new image
filename = r'lena_color.jpg'
imgPIL = Image.open(filename)
img = cv2.imread(filename, cv2.IMREAD_COLOR)
width = imgPIL.size[0]
height = imgPIL.size[1]
sobelImg = Image.new(imgPIL.mode, imgPIL.size)

# Edge Detection with Sobel method
matrix_X = np.array([[-1,-2,-1], [0,0,0], [1,2,1]])
matrix_Y = np.array([[-1,0,1], [-2,0,2], [-1,0,1]])
D = 130
for x in range(1, width-1):
    for y in range(1, height-1):
        gR_X = 0
        gR_Y = 0
        gG_X = 0
        gG_Y = 0
        gB_X = 0
        gB_Y = 0
        F0 = 0
        for i in range(x-1, x+2):
            for j in range(y-1, y+2):
                R, G, B = imgPIL.getpixel((i, j))
                gR_X += R * matrix_X[i-x+1, j-y+1]
                gR_Y += R * matrix_Y[i-x+1, j-y+1]
                gG_X += G * matrix_X[i-x+1, j-y+1]
                gG_Y += G * matrix_Y[i-x+1, j-y+1]
                gB_X += B * matrix_X[i-x+1, j-y+1]
                gB_Y += B * matrix_Y[i-x+1, j-y+1]
        
        gxx = gR_X**2 + gG_X**2 + gB_X**2
        gyy = gR_Y**2 + gG_Y**2 + gB_Y**2
        gxy = gR_X*gR_Y + gG_X*gG_Y + gB_X*gB_Y

        THETA = 0.5 * (atan2(2*gxy, (gxx - gyy)))
        F0 = sqrt( ((gxx + gyy) + (gxx - gyy)*cos(2*THETA) + 2*gxy*sin(2*THETA)) * 0.5)
        if F0 >= D:
            sobelImg.putpixel((x, y), (255, 255, 255))
        else: sobelImg.putpixel((x, y), (0, 0, 0))
 
# Display RGB image after edge detection process
sobelImg = np.array(sobelImg)
cv2.imshow("Edge detection for RGB image by Sobel method", sobelImg)
cv2.waitKey(0)
cv2.destroyAllWindows()
