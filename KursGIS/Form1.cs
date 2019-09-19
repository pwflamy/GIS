using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursGIS
{
    public partial class Form1 : Form
    {
        Bitmap InitImage = null, DamageImage = null, RestoreImage;
        byte[] InitByteArray;
        byte[] RestoreByteArray;
        bool CanStat = false;
        List<int> DamageLinesList = new List<int>();
        List<int> RestoreLinesList = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }
        
        //процедура зашумления изображения
        private void btnNoiseImage_Click(object sender, EventArgs e)
        {
            if (InitByteArray != null)
            {
                DamageLinesList.Clear();
                DamageImage = InitImage;
                byte[] DamageByteArray = new byte[InitByteArray.Length];
                Array.Copy(InitByteArray, DamageByteArray, InitByteArray.Length);
                Random rnd = new Random();
                int MaxDamageNumber = trackBar1.Value;   //число строк, которые должны быть зашумлены
                int DamageLineNumber = 0;
                for (int j = 0; j < MaxDamageNumber; j++)
                {
                    //случайно выбираем строки, которые зашумим
                    do
                    {
                        DamageLineNumber = rnd.Next(DamageImage.Height);               
                    } while (!((DamageLinesList.IndexOf(DamageLineNumber) == -1) & (DamageLinesList.IndexOf(DamageLineNumber + 1) == -1) &
                                    (DamageLinesList.IndexOf(DamageLineNumber - 1) == -1)));
                    DamageLinesList.Add(DamageLineNumber);
                    for (int i = 0; i < DamageImage.Width; i++)
                    {
                        //искажаем пиксель строки
                        int pix = DamageByteArray[DamageLineNumber * DamageImage.Width + i];
                        pix += rnd.Next(999) - 500;
                        if (pix > 255)
                        {
                            pix = 255;
                        }
                        if (pix < 0)
                        {
                            pix = 0;
                        }
                        DamageByteArray[DamageLineNumber * DamageImage.Width + i] = (byte)pix;
                    }
                }
                //выводим результат на экран
                Rectangle rect = new Rectangle(0, 0, DamageImage.Width, DamageImage.Height);
                System.Drawing.Imaging.BitmapData bmpData = DamageImage.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, DamageImage.PixelFormat);
                IntPtr ptr = bmpData.Scan0;
                int bytes = Math.Abs(bmpData.Stride) * DamageImage.Height;
                System.Runtime.InteropServices.Marshal.Copy(DamageByteArray, 0, ptr, bytes);
                DamageImage.UnlockBits(bmpData);
                pictureBox2.Width = DamageImage.Width;
                pictureBox2.Height = DamageImage.Height;
                pictureBox2.Image = DamageImage;
                lblDamageNum.Text = "Номера сбойных строк - ";
                DamageLinesList.Sort();
                foreach (int i in DamageLinesList)
                {
                    lblDamageNum.Text += i.ToString() + " ";
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblTrack.Text = trackBar1.Value.ToString();
        }

        //процедура вывода статистики восстановления
        private void btnStat_Click(object sender, EventArgs e)
        {
            if (CanStat)
            {
                double NumberDamagePix = DamageLinesList.Count * InitImage.Width;  //количество искаженных пикселей
                lblMaxDmgPix.Text = "Количество сбойных пикселей - " + NumberDamagePix.ToString();
                double NumberRestorePix = 0; //количество восстановленных пикселей
                foreach (int i in RestoreLinesList)
                {
                    for (int j = 0; j < InitImage.Width; j++)
                    {
                        int a = InitByteArray[i * InitImage.Width + j];
                        int b = RestoreByteArray[i * InitImage.Width + j];
                        if (Math.Abs(a - b) <= trackBar2.Value)
                            NumberRestorePix++;
                    }
                }
                lblNumRestore.Text = "Количество восстановленных пикселей - " + NumberRestorePix.ToString();
                double ProcentRestore = Math.Round((NumberRestorePix / NumberDamagePix * 100), 2);
                lblProcentRestore.Text = "Всего восстановлено в % - " + ProcentRestore.ToString() + "%";
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            lblTrackStat.Text = trackBar2.Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //процедура восстановления
        private void btnRestoreImage_Click(object sender, EventArgs e)
        {
            if (DamageImage != null)
            {
                RestoreLinesList.Clear();
                //загружаем искаженное изображение в массив байтов
                RestoreImage = DamageImage;
                Rectangle rect = new Rectangle(0, 0, RestoreImage.Width, RestoreImage.Height);
                System.Drawing.Imaging.BitmapData bmpData = RestoreImage.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, RestoreImage.PixelFormat);
                IntPtr ptr = bmpData.Scan0;
                int bytes = Math.Abs(bmpData.Stride) * RestoreImage.Height;
                RestoreByteArray = new byte[bytes];
                System.Runtime.InteropServices.Marshal.Copy(ptr, RestoreByteArray, 0, bytes);
                RestoreImage.UnlockBits(bmpData);
                //подсчитываем СКО каждой строки
                double[] SKOLines = new double[RestoreImage.Height];
                for (int i = 0; i < RestoreImage.Height; i++)
                {
                    double AveragePix = 0;
                    for (int j = 0; j < RestoreImage.Width; j++)
                    {
                        AveragePix += RestoreByteArray[i * RestoreImage.Width + j]; 
                    }
                    AveragePix = AveragePix / RestoreImage.Width;
                    double disp = 0;
                    for (int j = 0; j < RestoreImage.Width; j++)
                    {
                        disp += Math.Pow((RestoreByteArray[i * RestoreImage.Width + j] - AveragePix), 2);
                    }
                    disp = disp / (RestoreImage.Width - 1);
                    SKOLines[i] = Math.Sqrt(disp);
                }
                //На основании СКО находим сбойные строки,
                //Для определения сбойной строки разница между СКО соседних строк и сбойной должна быть больше 10
                for (int i = 0; i < RestoreImage.Height; i++)
                {
                    if (i == 0)
                    {
                        if ((SKOLines[i] - SKOLines[i+1]) > 10)
                        {
                            RestoreLinesList.Add(i);                           
                        }
                    }                
                    else if (i == RestoreImage.Height-1)
                    {
                        if ((SKOLines[i] - SKOLines[i - 1]) > 10)
                        {
                            RestoreLinesList.Add(i);
                        }
                    }
                    else
                    {
                        if (((SKOLines[i] - SKOLines[i - 1]) > 10) & ((SKOLines[i] - SKOLines[i + 1]) > 10))
                        {
                            RestoreLinesList.Add(i);
                        }
                    }
                }
                lblRestore.Text = "Найденные сбойные строки - ";
                foreach (int i in RestoreLinesList)
                {
                    lblRestore.Text += i.ToString() + " ";
                }
                //восстанавливаем найденные сбойные строки
                //восстановление выполняется как среднее арифметическое пикселей двух соседних строк
                int RestoreLineNumber = 0;
                foreach (int j in RestoreLinesList)
                {
                    RestoreLineNumber = j;
                    for (int i = 0; i < RestoreImage.Width; i++)
                    {
                        //для первой и последней строки для восстановления используем 2 строки, расположенные выше или ниже сбойной
                        if (RestoreLineNumber == 0) 
                        {
                            int rez = RestoreByteArray[(RestoreLineNumber + 1) * RestoreImage.Width + i] -
                                                  RestoreByteArray[(RestoreLineNumber + 2) * RestoreImage.Width + i];
                            rez += RestoreByteArray[(RestoreLineNumber + 1) * RestoreImage.Width + i];
                            if (rez > 255)
                                rez = 255;
                            else if (rez < 0)
                                rez = 0;
                            RestoreByteArray[RestoreLineNumber * RestoreImage.Width + i] = (byte)rez;
                        }
                        else if (RestoreLineNumber == RestoreImage.Height - 1)
                        {
                            int rez = RestoreByteArray[(RestoreLineNumber - 1) * RestoreImage.Width + i] -
                                                  RestoreByteArray[(RestoreLineNumber - 2) * RestoreImage.Width + i];
                            rez += RestoreByteArray[(RestoreLineNumber - 1) * RestoreImage.Width + i];
                            if (rez > 255)
                                rez = 255;
                            else if (rez < 0)
                                rez = 0;
                            RestoreByteArray[RestoreLineNumber * RestoreImage.Width + i] = (byte)rez;
                        }
                        else
                        {
                            byte rez = (byte)((RestoreByteArray[(RestoreLineNumber + 1) * RestoreImage.Width + i] +
                                                RestoreByteArray[(RestoreLineNumber - 1) * RestoreImage.Width + i]) / 2);
                            RestoreByteArray[RestoreLineNumber * RestoreImage.Width + i] = rez;
                        }
                    }
                }
                //выводим восстановленное изображение на экран
                bmpData = RestoreImage.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, RestoreImage.PixelFormat);
                ptr = bmpData.Scan0;
                bytes = Math.Abs(bmpData.Stride) * RestoreImage.Height;
                System.Runtime.InteropServices.Marshal.Copy(RestoreByteArray, 0, ptr, bytes);
                RestoreImage.UnlockBits(bmpData);
                pictureBox3.Width = RestoreImage.Width;
                pictureBox3.Height = RestoreImage.Height;
                pictureBox3.Image = RestoreImage;
                CanStat = true;
            }
        }

        //процедура загрузки изображения
        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Bitmap files(*.bmp)|*.bmp";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                InitImage = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Width = InitImage.Width;
                pictureBox1.Height = InitImage.Height;                
                pictureBox1.Image = InitImage;
                //загружаем изображение в массив байтов
                Rectangle rect = new Rectangle(0, 0, InitImage.Width, InitImage.Height);
                System.Drawing.Imaging.BitmapData bmpData = InitImage.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, InitImage.PixelFormat);
                IntPtr ptr = bmpData.Scan0;
                int bytes = Math.Abs(bmpData.Stride) * InitImage.Height;
                InitByteArray = new byte[bytes];
                System.Runtime.InteropServices.Marshal.Copy(ptr, InitByteArray, 0, bytes);
                InitImage.UnlockBits(bmpData);
             }
        }
    }
}
