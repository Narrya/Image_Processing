using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV;


namespace Webcam
{
    public partial class Webcam : Form
    {
        public FilterInfoCollection usbCams;
        public VideoCaptureDevice cam = null;
        private Bitmap _lastFrame;


        public Webcam()
        {
            InitializeComponent();
        }

        void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbCamera.Image = (Bitmap)eventArgs.Frame.Clone();
            _lastFrame = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            usbCams = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo camera in usbCams)
            {
                MessageBox.Show(camera.Name);
            }
        }

        private void btnCStart_Click(object sender, EventArgs e)
        {
            usbCams = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            cam = new VideoCaptureDevice(usbCams[0].MonikerString);

            cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);

            cam.Start();
        }

        private void btnCStop_Click(object sender, EventArgs e)
        {
            cam.Stop();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            
            Bitmap savepicture = (Bitmap)_lastFrame.Clone();
        
            try
            {
                cam.Stop();
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    savepicture.Save(save.FileName);
                }
              }
                catch (Exception)
                {
                    throw new ApplicationException("Save failed!");
                }
        }


        private void imageProcessingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Processing przetwarzanie = new Processing();
            przetwarzanie.ShowDialog(this);

        }

        private void imageStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageStatistics statystyka = new ImageStatistics();
            statystyka.ShowDialog(this);
        }

        }

    }
