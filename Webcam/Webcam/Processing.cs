using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Math;
using AForge.Imaging;
using AForge.Imaging.Filters;

namespace Webcam
{
    public partial class Processing : Form
    {

        public Processing()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    Bitmap pictureChosen = new Bitmap(open.FileName);
                    pbChoose.SizeMode = PictureBoxSizeMode.CenterImage;
                    pbChoose.Image = pictureChosen;

                }
            }

            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

            #region Operacje na obrazach
            private void cBFilters_SelectedIndexChanged(object sender, EventArgs e)
            {
                Bitmap pictureTransform = (Bitmap)pbChoose.Image;
                if ((string)cBFilters.SelectedItem == "HSL_Filter")
                {
                    AForge.Imaging.Filters.SaturationCorrection filter = new SaturationCorrection(0.1);
                    Bitmap newImage = filter.Apply(pictureTransform);
                    pbChoose.SizeMode = PictureBoxSizeMode.CenterImage;
                    pBNew.Image = newImage;
                }

                if ((string)cBFilters.SelectedItem == "Mediana")
                {
                    AForge.Imaging.Filters.Median filter = new Median();
                    Bitmap newImage = filter.Apply(pictureTransform);
                    pbChoose.SizeMode = PictureBoxSizeMode.CenterImage;
                    pBNew.Image = newImage;
                }

                /*if ((string)cBFilters.SelectedItem == "Fourier_Transformation")
                {
                 Complex[] dst = new Complex[n];
                  
                    AForge.Math.FourierTransform filter = AForge.Math.FourierTransform.DFT();// .FromBitmap(pictureTransform);
                    Bitmap newImage = filter.Apply();
                    pbChoose.SizeMode = PictureBoxSizeMode.CenterImage;
                    pBNew.Image = newImage;
                }*/

                if ((string)cBFilters.SelectedItem == "Binarization")
                {
                    pictureTransform = Grayscale.CommonAlgorithms.BT709.Apply(pictureTransform);
                    Threshold threshold = new Threshold(127);
                    threshold.ApplyInPlace(pictureTransform);
                    pbChoose.SizeMode = PictureBoxSizeMode.CenterImage;
                    pBNew.Image = pictureTransform;
                }

                if ((string)cBFilters.SelectedItem == "Grayscale")
                {
                    AForge.Imaging.Filters.Grayscale filter = new AForge.Imaging.Filters.Grayscale(0.2125, 0.7154, 0.0721);
                    Bitmap newImage = filter.Apply(pictureTransform);
                    pbChoose.SizeMode = PictureBoxSizeMode.CenterImage;
                    pBNew.Image = newImage;
                }

                if ((string)cBFilters.SelectedItem == "FillHoles")
                {

                    pictureTransform = Grayscale.CommonAlgorithms.BT709.Apply(pictureTransform);
                    Threshold threshold = new Threshold(127);
                    threshold.ApplyInPlace(pictureTransform);
                    AForge.Imaging.Filters.FillHoles filter = new AForge.Imaging.Filters.FillHoles();
                    filter.MaxHoleHeight = 5;
                    filter.MaxHoleWidth = 15;
                    filter.CoupledSizeFiltering = false;
                    Bitmap newImage = filter.Apply(pictureTransform);
                    pbChoose.SizeMode = PictureBoxSizeMode.CenterImage;
                    pBNew.Image = newImage;
                }

                if ((string)cBFilters.SelectedItem == "Opening")
                {
                    AForge.Imaging.Filters.Opening filter = new AForge.Imaging.Filters.Opening();
                    Bitmap newImage = filter.Apply(pictureTransform);
                    pbChoose.SizeMode = PictureBoxSizeMode.CenterImage;
                    pBNew.Image = newImage;
                }

                if ((string)cBFilters.SelectedItem == "Closing")
                {
                    AForge.Imaging.Filters.Closing filter = new AForge.Imaging.Filters.Closing();
                    Bitmap newImage = filter.Apply(pictureTransform);
                    pbChoose.SizeMode = PictureBoxSizeMode.CenterImage;
                    pBNew.Image = newImage;
                }

                if ((string)cBFilters.SelectedItem == "Erosion")
                {
                    AForge.Imaging.Filters.Erosion filter = new AForge.Imaging.Filters.Erosion();
                    Bitmap newImage = filter.Apply(pictureTransform);
                    pbChoose.SizeMode = PictureBoxSizeMode.CenterImage;
                    pBNew.Image = newImage;
                }

                if ((string)cBFilters.SelectedItem == "Dilatation")
                {
                    AForge.Imaging.Filters.Dilatation filter = new AForge.Imaging.Filters.Dilatation();
                    Bitmap newImage = filter.Apply(pictureTransform);
                    pbChoose.SizeMode = PictureBoxSizeMode.CenterImage;
                    pBNew.Image = newImage;
                }

                if ((string)cBFilters.SelectedItem == "Edges")
                {
                    AForge.Imaging.Filters.Edges filter = new AForge.Imaging.Filters.Edges();
                    Bitmap newImage = filter.Apply(pictureTransform);
                    pbChoose.SizeMode = PictureBoxSizeMode.CenterImage;
                    pBNew.Image = newImage;
                }
            }
            #endregion

            private void btnSaveTransform_Click(object sender, EventArgs e)
            {
                Bitmap pictureTransformSave = (Bitmap)pBNew.Image;
                  try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    pictureTransformSave.Save(save.FileName);
                }
              }
                catch (Exception)
                {
                    throw new ApplicationException("Save failed!");
                }
        }
            }


        }
    
