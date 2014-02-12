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
        private StringBuilder setError(String message)
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(message);
            return output;
        }

        private bool processDirectory(String directory)
        {
            bool fail = false;
            if (options.IncludeSubfolders == true)
            {
                //Process all sub folders            
                try
                {
                    String[] folderEntries = Directory.GetDirectories(directory);
                    foreach (String folderName in folderEntries)
                    {
                        fail = processDirectory(folderName);
                    }
                }
                catch (Exception)
                {
                    fail = true;
                }
            }
            String outputFolder = txtSaveFolder.Text + directory.Replace(tbSourceFolder.Text, "");
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
            fail = processFiles(directory, outputFolder);
            return fail;
        }

        private bool processFiles(String inputDir, String outputDir)
        {
            //For each selected file type in the source directory, do
            String[] fileEntries = Directory.GetFiles(inputDir, "*.*");
            options.pbTemp.Minimum = 0;
            options.pbTemp.Maximum = fileEntries.Length;
            options.pbTemp.Step = 1;
            int fileCount = 0;
            bool fail = false;
            foreach (String fileName in fileEntries)
            {
                if (fail == true)
                    break;
                String actualName = fileName.Replace(inputDir + "\\", "");
                Image resizedImage;
                fileCount += 1;
                options.pbTemp.Value = fileCount;
                try
                {
                    resizedImage = resizeImage(Double.Parse(tbOutputWidth.Text), Double.Parse(this.tbOutputHeight.Text), inputDir + "\\" + actualName);
                    resizedImage.Save(outputDir + "\\" + actualName);
                }
                catch (OutOfMemoryException ex)
                {
                    setError(actualName + ": El archivo no tiene un formato de imagen válido. GDI+ no admite el formato de píxel del archivo. ");
                }
            }
            options.pbTemp.Value = 0;
            return fail;
        }

        public Image resizeImage(double newWidth, double newHeight, string stPhotoPath)
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
        public System.Windows.Forms.ProgressBar pbTemp { get; set; }
    }
}
