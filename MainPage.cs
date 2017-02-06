using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge.Video.DirectShow;
using System.Windows.Media.Imaging;
using System.IO;
using System.Windows;
using System.Diagnostics;
using AForge.Video;
using AForge.Video.FFMPEG;
using System.Threading;
using System.Collections;
using AForge.Controls;
using System.Runtime.InteropServices;
// 下载于www.csaspx.com
namespace RayVideo
{
    public partial class MainPage : Form
    {
        public FilterInfoCollection videoDevices;
        private bool stopREC = true;
        private bool createNewFile = true;
        private bool showCamerDevicePage = true;
        private string videoFileFullPath = string.Empty; //视频文件全路径
        private string imageFileFullPath = string.Empty; //图像文件全路径
        private string videoPath = @""; //视频文件路径
        private string imagePath = @""; //图像文件路径
        private string videoFileName = string.Empty; //视频文件名
        private string imageFileName = string.Empty; //图像文件名
        private string drawDate = string.Empty;
        private VideoFileWriter videoWriter = null;
        IList<VideoSourcePlayer> videoPlayerlist = new List<VideoSourcePlayer>();
         
        Dictionary<string, bool> createNewFilelist = new Dictionary<string, bool>();
        Dictionary<string, Bitmap> videoImageList = new Dictionary<string, Bitmap>();
        Dictionary<string, VideoFileWriter> videoWriterList = new Dictionary<string, VideoFileWriter>();
        Dictionary<string, string> videoFileFullPathList = new Dictionary<string, string>();

        public TableLayoutPanel tablepanel = new TableLayoutPanel();

        int frameRate = 20; //默认帧率

        public MainPage()
        {

            InitializeComponent();


        }
        public void AddCamerItem(int index, int columns)
        {

            string sqlExists = string.Format("  SELECT * FROM camerDevice WHERE deviceID='{0}'", 
                videoDevices[index].MonikerString);
            DataTable ds= SQLiteHelper.ExecuteQuery(sqlExists).Tables[0];
            int videwplayerWidth = 320;
            int controlWidth = this.Width;
            // VideoCaptureDevice videoSource = new VideoCaptureDevice(videoDevices[index].MonikerString);
            VideoCaptureDevice videoSource = new VideoCaptureDevice(videoDevices[index > 1 ? 0 : index].MonikerString);
            //videoSource.DesiredFrameSize = new System.Drawing.Size(320, 240);
           // videoSource.DesiredFrameRate = 1;

            videoSource.VideoResolution = videoSource.VideoCapabilities[Convert.ToInt32(ds.Rows[0]["frameSizeIndex"])];
            VideoCapabilities d = videoSource.VideoCapabilities[0];// = new System.Drawing.Size(640, 480);
            AForge.Controls.VideoSourcePlayer videoplayer = new AForge.Controls.VideoSourcePlayer();
            videoplayer.Top = 100;
            videoplayer.Left = 320 * (index) + 1;
            videoplayer.Height = 240;
            videoplayer.Name = "videoplayer" + index;
            videoplayer.Tag = ds.Rows[0]["name"];
            videoplayer.Width = videwplayerWidth;
            videoplayer.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoPlayer_NewFrame);
            videoPlayerlist.Add(videoplayer);
            int columnsIndex = index % columns == 0 ? index / columns : index % columns;
            int rowIndex = index % columns == 0 ? (index - columns + 1) / columns : index / columns;
            tablepanel.Controls.Add(videoplayer, columnsIndex, rowIndex);

            videoplayer.VideoSource = videoSource;
            videoplayer.Start();
            //videoSourcePlayer.VideoSource = videoSource;
            //videoSourcePlayer.Start();

        }
        private void MainPage_Load(object sender, EventArgs e)
        {
            // photoPanel1.CameraIndex = 0;
            // photoPanel1.Start();
            // Thread.s
           if( SysConfigInfo.AutoVideo =="True")
             StartVideo();
        }
        private void ShowCamerDevicePage()
        {
            showCamerDevicePage = false;
            CamerDevice camerDevice = new CamerDevice(this);
            camerDevice.ShowDialog();
            camerDevice.Select();


        }
        /*
        public void StartCamera1()
        {
           // if (StartBtn.Text == "启动")
            {
                VideoCaptureDevice videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.DesiredFrameSize = new System.Drawing.Size(320, 240);
                videoSource.DesiredFrameRate = 20;
                //videoSourcePlayer.VideoSource = videoSource;
                //videoSourcePlayer.Start();
               
            }
            //else if (StartBtn.Text == "停止")
            //{
            //    if (videoSourcePlayer != null && videoSourcePlayer.IsRunning)
            //    {
            //        videoSourcePlayer.SignalToStop();
            //        videoSourcePlayer.WaitForStop();
            //    }
            //    StartBtn.Text = "启动";
            //}

            //拍照完成后关摄像头并刷新同时关窗体

        }
        */
        [DllImport("gdi32")]
        static extern int DeleteObject(IntPtr o);
        private void GetPicture(VideoSourcePlayer videoplayer)
        {
            //try
            {
                if (videoplayer.IsRunning)
                {
                    IntPtr ip =  videoplayer.GetCurrentVideoFrame().GetHbitmap();
                    BitmapSource bitmapSource = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                  ip,
                  IntPtr.Zero,
                   Int32Rect.Empty,
                  BitmapSizeOptions.FromEmptyOptions());
                    PngBitmapEncoder pE = new PngBitmapEncoder();
                    pE.Frames.Add(BitmapFrame.Create(bitmapSource));
                    drawDate = DateTime.Now.ToString("yyyy.MM.dd HH.mm.ss");
                    string picName = GetPath("Image") + "\\" + drawDate +videoplayer.Name+ ".jpg";
                    if (File.Exists(picName))
                    {
                        File.Delete(picName);
                    }
                    using (Stream stream = File.Create(picName))
                    {
                        pE.Save(stream);
                        
                    }
                    DeleteObject(ip);
                    //拍照完成后关摄像头并刷新同时关窗体
                    //if (videoSourcePlayer != null && videoSourcePlayer.IsRunning)
                    //{
                    //    videoSourcePlayer.SignalToStop();
                    //    videoSourcePlayer.WaitForStop();
                    //}
                    // this.Close();
                }
            }
            //catch (Exception ex)
           // {
           //     MessageBox.Show("摄像头异常：" + ex.Message);
           // }
        }

        private string GetPath(string file)
        {
            string personImgPath =(string.IsNullOrEmpty( SysConfigInfo.FilePath)?
                Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\SaveFiles" : SysConfigInfo.FilePath)
             + Path.DirectorySeparatorChar.ToString() + file;
            if (!Directory.Exists(personImgPath))
            {
                Directory.CreateDirectory(personImgPath);
            }

            return personImgPath;
        }




        private void videoPlayer_NewFrame(object sender, ref Bitmap image)
        {
            //录像
            Graphics g = Graphics.FromImage(image);
            SolidBrush drawBrush = new SolidBrush(Color.Yellow);
            VideoSourcePlayer senderPlayer = sender as VideoSourcePlayer;
            Font drawFont = new Font("Arial", 6, System.Drawing.FontStyle.Bold, GraphicsUnit.Millimeter);
            int xPos = image.Width - (image.Width - 15);
            int yPos = 10;
            //写到屏幕上的时间
            drawDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            g.DrawString(senderPlayer .Tag+ drawDate, drawFont, drawBrush, xPos, yPos);

             

            videoImageList[senderPlayer.Name] = image;


            //创建文件路径
            //fileFullPath = path + fileName;

            if (stopREC)
            {
                stopREC = true;
                createNewFile = true;  //这里要设置为true表示要创建新文件
                if (videoWriterList.Count > 0)
                {
                    if (videoWriterList.ContainsKey(senderPlayer.Name))
                        videoWriterList[senderPlayer.Name].Close();
                }
            }
            else
            {
                //开始录像
                if (!createNewFilelist.ContainsKey(senderPlayer.Name))
                {
                  
                    try
                    {
                       
                        {


                            if (videoFileFullPathList.Count > 0)
                            {
                                if (!videoFileFullPathList.ContainsKey(senderPlayer.Name))
                                {
                                    videoFileFullPathList[senderPlayer.Name] = GetPath("Video") + "\\" + DateTime.Now.ToString("yyyy.MM.dd HH.mm.ss") + senderPlayer.Name + ".avi";
                                }
                            }
                            else
                            {
                                videoFileFullPathList[senderPlayer.Name] = GetPath("Video") + "\\" + DateTime.Now.ToString("yyyy.MM.dd HH.mm.ss") + senderPlayer.Name + ".avi";

                            }
                            createNewFilelist[senderPlayer.Name] = false;
                            if (videoWriterList.Count > 0)
                            {
                                if (videoWriterList.ContainsKey(senderPlayer.Name))
                                {
                                    videoWriterList[senderPlayer.Name].Close();
                                    videoWriterList[senderPlayer.Name].Dispose();
                                }
                            }
                            videoWriterList[senderPlayer.Name] = new VideoFileWriter();
                            //这里必须是全路径，否则会默认保存到程序运行根据录下了
                           
                            videoWriterList[senderPlayer.Name].Open(videoFileFullPathList[senderPlayer.Name], videoImageList[senderPlayer.Name].Width,
                                    videoImageList[senderPlayer.Name].Height, frameRate, VideoCodec.MPEG4);
                             
                            videoWriterList[senderPlayer.Name].WriteVideoFrame(image);
                        }
                        //lock  IL会编译成如下写法
                          
                    }
                    catch (Exception ex)
                    {

                    }
                  
                }
                else
                {
                    if (videoWriterList.ContainsKey(senderPlayer.Name))
                    {
                        if (!videoWriterList[senderPlayer.Name].IsOpen)
                        {
                          videoWriterList[senderPlayer.Name].Open(videoFileFullPathList[senderPlayer.Name], videoImageList[senderPlayer.Name].Width,
                                    videoImageList[senderPlayer.Name].Height, frameRate, VideoCodec.MPEG4);
                        }
                        videoWriterList[senderPlayer.Name].WriteVideoFrame(videoImageList[senderPlayer.Name]);
                    }
                }
            }
            
        }


        private void MainPage_Activated(object sender, EventArgs e)
        {
            if (showCamerDevicePage)
                ShowCamerDevicePage();
        }

        private void videoBtn_Click(object sender, EventArgs e)
        {

            StartVideo();
        }


        private void StartVideo()
        {
            if (videoBtn.Enabled == true)
            {
                stopREC = false;
                frameRate = 20;// Convert.ToInt32(txtFrameRate.Text.Trim());
                videoBtn.Enabled = false;
                videoBtnItem.Enabled = false;
                createNewFilelist.Clear();
                videoFileFullPathList.Clear();

            }
            else if (videoBtn.Enabled == false)
            {
                stopREC = true;
                videoBtn.Enabled = true;
            }


        }
        private void pictureBtn_Click(object sender, EventArgs e)
        {
            foreach (VideoSourcePlayer item in videoPlayerlist)
                GetPicture(item);
            MessageBox.Show("拍照成功!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (SysConfigInfo.AfterPhoto == "True")
                OpenDirectory("Image");
        }

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseVideo();
        }
        private void CloseVideo()
        {
            foreach (VideoSourcePlayer item in videoPlayerlist)
            {
                item.SignalToStop();
                item.WaitForStop();
            }
            videoBtnItem.Enabled = true;
            videoBtn.Enabled = true;

        }
        public void CloseAppliaction()
        {
            CloseVideo();
            Application.Exit();
        }

        private void stopVideBtn_Click(object sender, EventArgs e)
        {
            StopVideo();
        }
        private void StopVideo()
        {
            stopREC = true;
            videoBtnItem.Enabled = true;
            videoBtn.Enabled = true;
            if(SysConfigInfo.AfterVideo=="True")
                OpenDirectory("Video");
        }
        private void pictureBtnItem_Click(object sender, EventArgs e)
        {
            foreach (VideoSourcePlayer item in videoPlayerlist)
                GetPicture(item);
        }

        private void videoBtnItem_Click(object sender, EventArgs e)
        {
            StartVideo();
            videoBtnItem.Enabled = false;
            videoBtn.Enabled = false;
        }

        private void stopVideBtnItem_Click(object sender, EventArgs e)
        {
            StopVideo();
        }

        private void filePpath_Click(object sender, EventArgs e)
        {
            OpenDirectory("");
        }
        private void OpenDirectory(string DirectoryType)
        {
            if (DirectoryType != "") DirectoryType = "\\" + DirectoryType;
            string fielpathStr = ((string.IsNullOrEmpty(SysConfigInfo.FilePath) ?
                   Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\SaveFiles" : SysConfigInfo.FilePath)) + DirectoryType;
            if (!Directory.Exists(fielpathStr))
            {
                Directory.CreateDirectory(fielpathStr);
            }
            System.Diagnostics.Process.Start(fielpathStr);
        }
        private void buttonItem8_Click(object sender, EventArgs e)
        {
            SysConfig sysconfig = new SysConfig();
            sysconfig.ShowDialog();
        }



    }
}
