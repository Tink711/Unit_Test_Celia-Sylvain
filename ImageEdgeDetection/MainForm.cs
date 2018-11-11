/*
 * The Following Code was developed by Dewald Esterhuizen
 * View Documentation at: http://softwarebydefault.com
 * Licensed under Ms-PL 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using ImageEdgeDetection.Filters;
using ImageEdgeDetection.EdgeDetections;

namespace ImageEdgeDetection
{
    public partial class MainForm : Form
    {
        private Bitmap originalBitmap = null;
        private Bitmap previewBitmap = null;
        private Bitmap resultBitmap = null;
        private Bitmap filterBitmap = null;

        private Dictionary<String, AbstractFilter> filterListItems;
        private Dictionary<String, EdgeDetectionAbstract> edgeDetectionListItems;
        
        public MainForm()
        {
            InitializeComponent();


            filterListItems = new Dictionary<string, AbstractFilter>
            {
                { "None", new NoneFilter() },
                { "Hell Filter", new HellFilter() },
                { "Miami Filter", new MiamiFilter() },
                { "Zen Filter", new ZenFilter() },
                { "Black and White Filter", new BlackAndWhiteFilter() },
                { "Swap Filter", new SwapFilter() },
                { "Crazy Filter", new CrazyFilter() },
                { "Mega Filter Green", new MegaFilterGreen() },
                { "Mega Filter Orange", new MegaFilterOrange() },
                { "Mega Filter Pink", new MegaFilterPink() },
                { "Rainbow Filter", new RainbowFilter() }
            };

            cmbFilter.Items.Clear();
            cmbFilter.Items.AddRange(filterListItems.Keys.ToArray());
            cmbFilter.SelectedIndex = 0;

            edgeDetectionListItems = new Dictionary<string, EdgeDetectionAbstract>
            {
                { "None", new None() },
                { "Laplacian 3x3", new Laplacian3x3() },
                { "Laplacian 3x3 Grayscale", new Laplacian3x3_grayscale() },
                { "Laplacian 5x5", new Laplacian5x5() },
                { "Laplacian 5x5 Grayscale", new Laplacian5x5_grayscale() },
                { "Laplacian of Gaussian", new LaplacianOfGaussianFilter() },
                { "Laplacian 3x3 of Gaussian 3x3", new LaplacianOfGaussian3x3() },
                { "Laplacian 3x3 of Gaussian 5x5 - 1", new LaplacianOfGaussien3x3_5x5_1() },
                { "Laplacian 3x3 of Gaussian 5x5 - 2", new LaplacianOfGaussien3x3_5x5_2() },
                { "Laplacian 5x5 of Gaussian 3x3", new LaplacianOfGaussien5x5_3x3() },
                { "Laplacian 5x5 of Gaussian 5x5 - 1", new LaplacianOfGaussien5x5_5x5_1() },
                { "Laplacian 5x5 of Gaussian 5x5 - 2", new LaplacianOfGaussien5x5_5x5_2() },
                { "Sobel 3x3", new Sobel3x3() },
                { "Sobel 3x3 Grayscale", new Sobel3x3_grayscale() },
                { "Prewitt", new Prewitt() },
                { "Prewitt Grayscale", new Prewitt_grayscale() },
                { "Kirsch", new Kirsch() },
                { "Kirsch Grayscale", new Kirsch_grayscale() }
            };

            comboEdgeDetection.Items.Clear();
            comboEdgeDetection.Items.AddRange(edgeDetectionListItems.Keys.ToArray());
            comboEdgeDetection.SelectedIndex = 0;
        }

        private void btnOpenOriginal_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an image file.";
            ofd.Filter = "Jpeg Images(*.jpg)|*.jpg|Png Images(*.png)|*.png";
            ofd.Filter += "|Bitmap Images(*.bmp)|*.bmp";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(ofd.FileName);
                originalBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
                streamReader.Close();

                previewBitmap = originalBitmap.CopyToSquareCanvas(picPreview.Width);
                picPreview.Image = previewBitmap;
            }
        }

        private void btnSaveNewImage_Click(object sender, EventArgs e)
        {
            ApplyFilter(false);
            ApplyEdgeDetection(false);

            if (resultBitmap != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Specify a file name and file path";
                sfd.Filter = "Jpeg Images(*.jpg)|*.jpg|Png Images(*.png)|*.png";
                sfd.Filter += "|Bitmap Images(*.bmp)|*.bmp";

                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fileExtension = Path.GetExtension(sfd.FileName).ToUpper();
                    ImageFormat imgFormat = ImageFormat.Png;

                    if (fileExtension == "BMP")
                    {
                        imgFormat = ImageFormat.Bmp;
                    }
                    else if (fileExtension == "JPG")
                    {
                        imgFormat = ImageFormat.Jpeg;
                    }

                    StreamWriter streamWriter = new StreamWriter(sfd.FileName, false);
                    resultBitmap.Save(streamWriter.BaseStream, imgFormat);
                    streamWriter.Flush();
                    streamWriter.Close();

                    resultBitmap = null;
                }
            }
        }

        private void ApplyEdgeDetection(bool preview)
        {
            if (previewBitmap == null || comboEdgeDetection.SelectedIndex == -1)
            {
                return;
            }

            Bitmap selectedSource = null;
            Bitmap bitmapResult = null;

            if (preview == true)
            {
                selectedSource = filterBitmap == null ? previewBitmap : filterBitmap;
            }
            else
            {
                selectedSource = originalBitmap;
            }

            if (selectedSource != null)
            {
                bitmapResult = edgeDetectionListItems[comboEdgeDetection.SelectedItem.ToString()].Apply(selectedSource);
            }

            if (bitmapResult != null)
            {
                if (preview == true)
                {
                    picPreview.Image = bitmapResult;
                }
                else
                {
                    resultBitmap = bitmapResult;
                }
            }
        }

        private void ApplyFilter(bool preview)
        {
            if (previewBitmap == null || cmbFilter.SelectedIndex == -1)
            {
                return;
            }

            Bitmap selectedSource = null;
            Bitmap bitmapResult = null;

            if (preview == true)
            {
                selectedSource = previewBitmap;
            }
            else
            {
                selectedSource = originalBitmap;
            }

            if (selectedSource != null)
            {

                bitmapResult = filterListItems[cmbFilter.SelectedItem.ToString()].Apply(selectedSource);
                filterBitmap = bitmapResult;
            }

            if (bitmapResult != null)
            {
                if (preview == true)
                {
                    picPreview.Image = bitmapResult;
                }
                else
                {
                    resultBitmap = bitmapResult;
                }
            }
        }

        private void EdgeDetectionChangedEventHandler(object sender, EventArgs e)
        {
            // apply edge detection
            ApplyEdgeDetection(true);
        }



        private void FilterChangedEventHandler(object sender, EventArgs e)
        {
            // apply filter
            ApplyFilter(true);
        }

        private void picPreview_Click(object sender, EventArgs e)
        {

        }
    }
}
