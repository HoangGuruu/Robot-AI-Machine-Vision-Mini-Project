import cv2
import numpy as np
from PIL import Image
from math import *

### SEGMENTATION IN RGB VECTOR SPACE ###
def Segmentation_RGB(imgPIL, x1, y1, x2, y2, D0):
    img_Segmentation = Image.new(imgPIL.mode, imgPIL.size)
    width = img_Segmentation.size[0]
    height = img_Segmentation.size[1]

    aR = 0
    aG = 0
    aB = 0
    for i in range(x1, x2+1):
        for j in range(y1, y2+1):        
            R, G, B = imgPIL.getpixel((i, j))
            aR += R
            aG += G
            aB += B
    size = abs(x2 - x1) * abs(y2 - y1)
    aR /= size
    aG /= size
    aB /= size 

    for x in range(height):
        for y in range(width):
            zR, zG, zB = imgPIL.getpixel((x, y))
            D = sqrt((zR - aR)**2 + (zG - aG)**2 + (zB - aB)**2)
            if D <= D0:
                img_Segmentation.putpixel((x, y), (255, 255, 255))
            else:
                img_Segmentation.putpixel((x, y), (zB, zG, zR))
    return img_Segmentation
#########################################################################

### MAIN PROCESSING ###
filename = r'lena_color.jpg'
img = cv2.imread(filename, cv2.IMREAD_COLOR)
imgPIL = Image.open(filename)
convertedImage = Segmentation_RGB(imgPIL, 80, 400, 150, 500, 45)
convertedImage = np.array(convertedImage)
cv2.imshow("Image after segmentation", convertedImage)

cv2.waitKey(0)
cv2.destroyAllWindows()
#########################################################################
