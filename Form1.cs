using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageBot.Screenshot_Configurations;
using System.Diagnostics;
using System.IO;

namespace ImageBot
{
    public partial class Form1 : Form
    {
        
        private static IntPtr _hWnd = IntPtr.Zero;
       

        private IntPtr LastActiveWindow = IntPtr.Zero;

        public Form1()
        {
            InitializeComponent();
            wComboBox1.SelectedIndex = 0;
            wComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void locatePictureBox1_DoubleClick(object sender, EventArgs e)
        {
            imgLocateOfd.Filter = "Image files|*.bmp;*.png;*.jpg";
           
            DialogResult dResult = imgLocateOfd.ShowDialog();
            if(dResult == DialogResult.OK)
            {
                Image ofdImg = Image.FromFile(imgLocateOfd.FileName);
                if (ofdImg.Width > 20 || ofdImg.Height > 30)
                {
                    MessageBox.Show("Invalid File Size");
                    locatePictureBox1_DoubleClick(null, EventArgs.Empty);
                }
                else
                {
                    locatePictureBox1.Image = ofdImg;
                    GC.Collect();
                }

            }

        }

        private void CallBackCoordinates(int X, int Y,int imgX, int imgY)
        {
            Invoke((MethodInvoker)(() =>
            {
                widthLabel.Text = String.Format("X: {0}/" + imgX.ToString(), X.ToString());
                heightLabel.Text = String.Format("Y: {0}/" + imgY.ToString(), Y.ToString());
            }));
           
        }

        private void FormCallBack(string pName, IntPtr pHandle)
        {
            processLabel.Text = pName;
            _hWnd = pHandle;
        }

        private void lastActiveWindowTimer_Tick(object sender, EventArgs e)
        {
            if (pInvokes.GetForegroundWindow() != Process.GetCurrentProcess().MainWindowHandle)
                LastActiveWindow = pInvokes.GetForegroundWindow();
        }

     

        private void loadImageBTN_Click(object sender, EventArgs e)
        {
            switch (wComboBox1.SelectedIndex)
            {
                case 0:
                    if(LastActiveWindow != IntPtr.Zero)
                        previewPictureBox1.Image = Screenshot.OpenScWindow(LastActiveWindow);
                    break;

                case 1:
                    locImageOfd.Filter = "Image files|*.bmp;*.png;*.jpg";
                    DialogResult dResult = locImageOfd.ShowDialog();
                    if (dResult == DialogResult.OK)
                    {
                        previewPictureBox1.Image = Image.FromFile(locImageOfd.FileName);
                        GC.Collect();
                    }
                    break;

                case 2:
                    previewPictureBox1.Image = Screenshot.ScDesktop(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, Screen.PrimaryScreen.Bounds.Size);
                    break;

                case 3:
                    ProcessList p1 = new ProcessList(FormCallBack);
                    p1.StartPosition = FormStartPosition.Manual;
                    p1.Location = new Point(Location.X + (Width - p1.Width) / 2, Location.Y + (Height - p1.Height) / 2);
                    p1.ShowDialog();
                    if(_hWnd != IntPtr.Zero)
                        previewPictureBox1.Image = Screenshot.ScWindow(_hWnd);
                    break;

                default:
                    MessageBox.Show(this,"Invalid Choice!");
                    break;
            
            }
        }

        private async void locateButton_Click(object sender, EventArgs e)
        {

            Tuple<bool, Point> aTuple = await scLocator.Locate((Bitmap)previewPictureBox1.Image, (Bitmap)locatePictureBox1.Image,CallBackCoordinates);

            if (aTuple.Item1)
            {
                MessageBox.Show("Found!");
            }

        }
    }//20x30
}
