using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Drawing2D;

namespace PhotoBlogConverter
{
    class PhotoConverter
    {
        PhotoConverterOptions options { get; set; }
        private static StringBuilder setError(String message)
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(message);
            return output;
        }

        public static bool processDirectory(String directory, PhotoConverterOptions ops)
        {
            bool fail = false;
            if (ops.IncludeSubfolders == true)
            {
                //Process all sub folders            
                try
                {
                    String[] folderEntries = Directory.GetDirectories(directory);
                    foreach (String folderName in folderEntries)
                    {
                        fail = processDirectory(folderName, ops);
                    }
                }
                catch (Exception)
                {
                    fail = true;
                }
            }
            String outputFolder = ops.OutputPath + directory.Replace(ops.OriginPath, "");
            //Check if output folder exists, if not then create it
            if (Directory.Exists(outputFolder) == false)
            {
                try
                {
                    Directory.CreateDirectory(outputFolder);
                }
                catch (Exception)
                {
                    fail = true;
                }
            }

            //Process all files in current folder
            fail = processFiles(directory, outputFolder, ops);
            return fail;
        }

        private static bool processFiles(String inputDir, String outputDir, PhotoConverterOptions ops )
        {
            
            //For each selected file type in the source directory, do
            String[] fileEntries = Directory.GetFiles(inputDir, "*.*");
            ops.pbTemp.Minimum = 0;
            ops.pbTemp.Maximum = fileEntries.Length;
            ops.pbTemp.Step = 1;
            int fileCount = 0;
            bool fail = false;
            foreach (String fileName in fileEntries)
            {
                if (fail == true)
                    break;
                String actualName = fileName.Replace(inputDir + "\\", "");
                Image resizedImage;
                fileCount += 1;
                ops.pbTemp.Value = fileCount;
                try
                {
                    resizedImage = resizeImage(ops.MaxWidth, ops.MaxHeight, inputDir + "\\" + actualName);
                    resizedImage.Save(outputDir + "\\" + actualName);
                }
                catch (OutOfMemoryException ex)
                {
                    setError(actualName + ": El archivo no tiene un formato de imagen válido. GDI+ no admite el formato de píxel del archivo. ");
                }
            }
            ops.pbTemp.Value = 0;
            return fail;
        }

        public static Image resizeImage(double newWidth, double newHeight, string stPhotoPath)
        {
            Image imgPhoto = Image.FromFile(stPhotoPath);

            double resizeWidth = imgPhoto.Width;
            double resizeHeight = imgPhoto.Height;

            double aspect = resizeWidth / resizeHeight;

            if (resizeWidth > newWidth)
            {
                resizeWidth = newWidth;
                resizeHeight = resizeWidth / aspect;
            }
            if (resizeHeight > newHeight)
            {
                aspect = resizeWidth / resizeHeight;
                resizeHeight = newHeight;
                resizeWidth = resizeHeight * aspect;
            }

            newWidth = resizeWidth;
            newHeight = resizeHeight;

            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;

            int sourceX = 0, sourceY = 0, destX = 0, destY = 0;
            float nPercent = 0, nPercentW = 0, nPercentH = 0;

            nPercentW = ((float)newWidth / (float)sourceWidth);
            nPercentH = ((float)newHeight / (float)sourceHeight);
            if (nPercentH < nPercentW)
            {
                nPercent = nPercentH;
                destX = System.Convert.ToInt16((newWidth -
                          (sourceWidth * nPercent)) / 2);
            }
            else
            {
                nPercent = nPercentW;
                destY = System.Convert.ToInt16((newHeight -
                          (sourceHeight * nPercent)) / 2);
            }

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);


            Bitmap bmPhoto = new Bitmap((int)newWidth, (int)newHeight,
                          PixelFormat.Format24bppRgb);

            bmPhoto.SetResolution(imgPhoto.HorizontalResolution,
                         imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.Clear(Color.White);
            grPhoto.InterpolationMode =
                InterpolationMode.HighQualityBicubic;

            grPhoto.DrawImage(imgPhoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);

            grPhoto.Dispose();
            imgPhoto.Dispose();
            return bmPhoto;
        }
    }

    public class PhotoConverterOptions
    {
        public Boolean IncludeSubfolders { get; set; }
        public String OutputPath { get; set; }
        public String OriginPath { get; set; }
        public Double MaxWidth { get; set; }
        public Double MaxHeight { get; set; }
        public System.Windows.Forms.ProgressBar pbTemp { get; set; }
    }
}
