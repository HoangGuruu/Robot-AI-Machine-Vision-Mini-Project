import cv2
import numpy as np
from PIL import Image 

# Convert RGB image to Grayscale image by luminance method
def ConvertToGrayscale(imgPIL):
    grayImg = Image.new(imgPIL.mode, imgPIL.size)
    width = grayImg.size[0]
    height = grayImg.size[1]
    for x in range(0, width):
        for y in range(0, height):
            R, G, B = imgPIL.getpixel((x,y))
            gray = np.uint8(0.2126*R + 0.7152*G + 0.00722*B) 
            grayImg.putpixel((x, y), (gray, gray, gray))
    return grayImg

# Edge Detection with Sobel method
def DetectEdgeSobel(grayImg):
    sobelImg = Image.new(grayImg.mode, grayImg.size)
    threshold = 130 
    width = sobelImg.size[0]
    height = sobelImg.size[1]
    xMatrix = np.array([[-1,-2,-1],[0,0,0],[1,2,1]])
    yMatrix = np.array([[-1,0,1],[-2,0,2],[-1,0,1]])
    for x in range(1, width-1):
        for y in range(1, height-1):
            Gx = 0
            Gy = 0
            for i in range(x-1, x+2):
                for j in range(y-1, y+2):
                    gray, gray, gray = grayImg.getpixel((i, j))
                    Gx += gray * xMatrix[i - (x - 1)][j - (y - 1)]
                    Gy += gray * yMatrix[i - (x - 1)][j - (y - 1)]
            M = abs(Gx) + abs(Gy)
            if M <= threshold:
                sobelImg.putpixel((x, y), (0, 0, 0))
            else:
                sobelImg.putpixel((x, y), (255, 255, 255))
    return sobelImg

#========== Main Process ==========
filename = r'lena_color.jpg'
imgPIL = Image.open(filename)
grayImg = ConvertToGrayscale(imgPIL)
sobelImg = DetectEdgeSobel(grayImg)
sobelImg = np.array(sobelImg)
cv2.imshow("Edge detection with Sobel method", sobelImg)
cv2.waitKey(0)
cv2.destroyAllWindows()
