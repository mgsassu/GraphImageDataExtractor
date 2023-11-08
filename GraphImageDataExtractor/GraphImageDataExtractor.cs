using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace GraphImageDataExtractor
{
   public partial class formGraphImageDataExtractor : Form
   {
      private double[] zoomFactor = { 0.1, 0.25, 0.5, 1, 2, 3, 5, 10, 15 };
      public formGraphImageDataExtractor()
      {
         InitializeComponent();
         dgvScrollData.Rows.Add(5);
         dgvScrollData.Rows[0].Cells[0].Value = "X Coordinate";
         dgvScrollData.Rows[1].Cells[0].Value = "Y Coordinate";
         dgvScrollData.Rows[2].Cells[0].Value = "R";
         dgvScrollData.Rows[3].Cells[0].Value = "G";
         dgvScrollData.Rows[4].Cells[0].Value = "B";
      }

      private void btnLoadImage_Click(object sender, EventArgs e)
      {
         LoadImage();
      }

      private void LoadImage()
      {
         OpenFileDialog OpenGraph = new OpenFileDialog();
         OpenGraph.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "Graph Images\\";
         Bitmap GraphImageBitmap;
         if (OpenGraph.ShowDialog() == DialogResult.OK)
         {
            GraphImageBitmap = new Bitmap(OpenGraph.FileName);
         }
         else
         {
            MessageBox.Show("Unable to open file, please select a valid image.");
            return;
         }

         pbGraphImage.Image = GraphImageBitmap;
         pbGraphImage.SizeMode = PictureBoxSizeMode.AutoSize;
         pbGraphImage.Refresh();
      }

      private unsafe void pbGraphImage_MouseMove(object sender, MouseEventArgs e)
      {
         if (pbGraphImage.Image == null)
            return;

         try
         {
            Bitmap bmp = new Bitmap(pbGraphImage.Image);
            //BitmapData bd = bmp.LockBits(new 
            //    Rectangle(0,0,bmp.Width,bmp.Height),ImageLockMode.ReadOnly,PixelFormat.Format32bppRgb);

            //byte* ptr = (byte*)bd.Scan0;
            var pixelColor = bmp.GetPixel(e.X, e.Y);

            dgvScrollData.Rows[0].Cells[1].Value = e.X;
            dgvScrollData.Rows[1].Cells[1].Value = e.Y;
            dgvScrollData.Rows[2].Cells[1].Value = pixelColor.R;
            dgvScrollData.Rows[3].Cells[1].Value = pixelColor.G;
            dgvScrollData.Rows[4].Cells[1].Value = pixelColor.B;
            //bmp.UnlockBits(bd);
            bmp.Dispose();
         }
         catch
         {
            return;
         }
      }

      //private void setZoom()
      //{
      //    double newZoom = imageZoomControl1.HorizontalScroll.Value;
      //    pbGraphImage.Width = Convert.ToInt32(pbGraphImage.Width * newZoom);
      //    pbGraphImage.Height = Convert.ToInt32(pbGraphImage.Height * newZoom);
      //    pbGraphImage.Refresh();
      //}

      //private void imageZoomControl1_Scroll_1(object sender, ScrollEventArgs e)
      //{
      //    if (pbGraphImage.Image != null)
      //    {
      //        setZoom();
      //    }
      //}

      private void btnExtractData_Click(object sender, EventArgs e)
      {
         if (tbDataB.Text != null &
             tbDataG.Text != null &
             tbDataR.Text != null &
             tbXdatamax.Text != null &
             tbXdatamin.Text != null &
             tbXpixelmax.Text != null &
             tbXpixelmin.Text != null &
             tbYdatamax.Text != null &
             tbYdatamin.Text != null &
             tbYpixelmax.Text != null &
             tbYpixelmin.Text != null &
             tbOutputFileName.Text != null)
         {
            try
            {
               //Data color values
               int R = Convert.ToInt32(tbDataR.Text);
               int G = Convert.ToInt32(tbDataG.Text);
               int B = Convert.ToInt32(tbDataB.Text);

               //X Pixel and Data numbers
               int xPixelmin = Convert.ToInt32(tbXpixelmin.Text);
               int xPixelmax = Convert.ToInt32(tbXpixelmax.Text);
               int xPixelRange = xPixelmax - xPixelmin;

               double xDatamin = Convert.ToDouble(tbXdatamin.Text);
               double xDatamax = Convert.ToDouble(tbXdatamax.Text);
               double xIntervalAdded = xDatamin;
               double xInterval = (xDatamax - xDatamin) / Convert.ToDouble(xPixelRange);

               //Y Pixel and Data numbers
               int yPixelmin = Convert.ToInt32(tbYpixelmin.Text);
               int yPixelmax = Convert.ToInt32(tbYpixelmax.Text);
               int yPixelRange = yPixelmin - yPixelmax;

               double yDatamin = Convert.ToDouble(tbYdatamin.Text);
               double yDatamax = Convert.ToDouble(tbYdatamax.Text);
               double yDataRange = yDatamax - yDatamin;

               //double yInterval = (yDatamax - yDatamin) / Convert.ToDouble(yDataRange);

               //Data lists to be populated
               int dataPoint = 0;
               double[] xDoubleData = new double[xPixelRange];
               double[] yDoubleData = new double[xPixelRange];
               double yDataError = yDataRange / yPixelRange;

               Bitmap bmp = new Bitmap(pbGraphImage.Image);
               for (int x = xPixelmin; x < xPixelmax; x++)
               {
                  xDoubleData[dataPoint] = xIntervalAdded;

                  List<int> yPixelMatch = new List<int>();
                  for (int y = yPixelmax; y < yPixelmin; y++)
                  {
                     Color pixelColor = bmp.GetPixel(x, y);
                     if (pixelColor.R == R &
                         pixelColor.G == G &
                         pixelColor.B == B)
                     {
                        yPixelMatch.Add(y);
                     }
                  }
                  double yDataPoint = 0;
                  if (yPixelMatch.Count != 0)
                  {
                     yDataPoint = yDatamax - (((yPixelMatch.Average() - yPixelmax) / yPixelRange) * yDataRange);
                  }
                  yDoubleData[dataPoint] = yDataPoint;
                  dataPoint += 1;
                  xIntervalAdded += xInterval;
               }
               //Converts from doubles to integers via interpolation, if desired.
               if (cbIntegerValues.Checked)
               {
                  List<int> xIntegerData = new List<int>();
                  List<double> yInterpolatedData = new List<double>();
                  int xDataStart = Convert.ToInt32(Math.Ceiling(xDatamin));
                  for (int i = 1; i < xDoubleData.Length; i++)
                  {
                     if (xDoubleData[i] == xDataStart)
                     {
                        xIntegerData.Add(Convert.ToInt32(xDoubleData[i]));
                        yInterpolatedData.Add(yDoubleData[i]);
                        xDataStart += 1;
                     }
                     else if (xDoubleData[i] > xDataStart)
                     {
                        do
                        {
                           int j = 0;
                           double m = (yDoubleData[i + j] - yDoubleData[i - 1 + j]) / (xDoubleData[i + j] - xDoubleData[i - 1 + j]);
                           double b = yDoubleData[i + j] - m * xDoubleData[i + j];
                           double yint = m * xDataStart + b;
                           xIntegerData.Add(xDataStart);
                           yInterpolatedData.Add(yint);
                           j += 1;
                           xDataStart += 1;
                        } while (xDoubleData[i] > xDataStart);
                     }
                     else if (xDoubleData[i] < xDataStart)
                     {
                        continue;
                     }
                  }

                  //X as Integer, Data Output
                  StreamWriter s = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Data Output\\" + tbOutputFileName.Text.ToString() + ".csv");
                  s.WriteLine("y Error:" + yDataError.ToString());
                  for (int i = 0; i < xIntegerData.Count; i++)
                  {
                     s.WriteLine(xIntegerData[i].ToString() + "," + yInterpolatedData[i].ToString());
                  }
                  s.Close();
               }
               else
               {
                  //X as Double, Data Output
                  StreamWriter s = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Data Output\\" + tbOutputFileName.Text.ToString() + ".csv");
                  for (int i = 0; i < xDoubleData.Length; i++)
                  {
                     s.WriteLine(xDoubleData[i].ToString() + "," + yDoubleData[i].ToString());
                  }
                  s.Close();
               }
            }
            catch (Exception ex)
            {
               MessageBox.Show("Unknown error encountered. Please verify that all entered values are valid integers. Error message: " + ex.ToString());
               return;
            }
         }
         else
         {
            MessageBox.Show("Please enter values for ALL text boxes");
            return;
         }

      }

      private void btnZoomPositive_Click(object sender, EventArgs e)
      {
         //Bitmap bmp = new Bitmap(pbGraphImage.Image);
         //float newHresolution = Convert.ToSingle(bmp.HorizontalResolution * 1.2);
         //float newVresolution = Convert.ToSingle(bmp.VerticalResolution * 1.2);
         //bmp.SetResolution(newHresolution, newVresolution);
         //pbGraphImage.Image = bmp;
         //pbGraphImage.Refresh();
         pbGraphImage.Width = Convert.ToInt32(pbGraphImage.Width * 1.2);
         pbGraphImage.Height = Convert.ToInt32(pbGraphImage.Height * 1.2);
         pbGraphImage.Refresh();
      }

      private void btnZoomNegative_Click(object sender, EventArgs e)
      {
         pbGraphImage.Width = Convert.ToInt32(pbGraphImage.Width / 2);
         pbGraphImage.Height = Convert.ToInt32(pbGraphImage.Height / 2);
         pbGraphImage.Refresh();
      }

      private void btnOpenDataFolder_Click(object sender, EventArgs e)
      {
         try
         {
            System.Diagnostics.Process.Start("explorer.exe", AppDomain.CurrentDomain.BaseDirectory + "Data Output\\");
         }
         catch (Exception ex)
         {
            MessageBox.Show("Error encountered. File path may not exist. Error: " + ex.ToString());
         }
      }

      private void btnClearAll_Click(object sender, EventArgs e)
      {
         tbDataB.Clear();
         tbDataG.Clear();
         tbDataR.Clear();
         tbOutputFileName.Clear();
         tbXdatamax.Clear();
         tbXdatamin.Clear();
         tbXpixelmax.Clear();
         tbXpixelmin.Clear();
         tbYdatamax.Clear();
         tbYdatamin.Clear();
         tbYpixelmax.Clear();
         tbYpixelmin.Clear();
      }
   }
}
