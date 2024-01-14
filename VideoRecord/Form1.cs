using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.FFMPEG;
using System.Diagnostics;

namespace VideoRecord
{

    public enum BitRates
    {
        _50kbit = 5000 ,
        _100kbit = 10000 ,
        _500kbit = 50000 ,
        _1000kbit = 1000000 ,
        _2000kbit = 2000000 ,
        _3000kbit = 3000000 ,
    }


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetSettings();  
        }

        private bool isRecording;
        private VideoFileWriter writer;
        private ScreenCaptureStream stream;
        private Stopwatch watch;
        private Rectangle screenBounds;
        private int frames;

        JPEGStream jPEG;
        MJPEGStream mJPEG;

        private void GetSettings()
        {
            //get screens
            List<string> screens = new List<string>();
            foreach (var item in Screen.AllScreens)
            {
                screens.Add(item.DeviceName);
            }
            cb_screenSelector.DataSource = screens;
            //display codecs
            cb_videoCodec.DataSource = Enum.GetValues(typeof(VideoCodec));
            //get bitrates
            cb_bitRate.DataSource = Enum.GetValues(typeof(BitRates));
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPath.TextLength < 1)
                {
                    FolderBrowserDialog fbd = new FolderBrowserDialog();
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        txtPath.Text = fbd.SelectedPath;
                        StartRecording(fbd.SelectedPath);
                    }
                }
                else
                {
                    StartRecording(txtPath.Text);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error"+ ex.StackTrace);
            }
        }

        private void StartRecording(string selectedPath)
        {
            //screenBounds = Screen.AllScreens.First(sc => sc.DeviceName == cb_videoCodec.Text).Bounds;
            screenBounds = Screen.AllScreens[cb_screenSelector.SelectedIndex].Bounds;

            string path = $"{txtPath.Text}\\{Environment.UserName}_{DateTime.Now.ToString("dd_MMM_yyyy HH_mm_ss")}.avi";
            writer = new VideoFileWriter();

            writer.Open(path,screenBounds.Width,
                screenBounds.Height,
                (int)numFps.Value,
                (VideoCodec)cb_videoCodec.SelectedValue,
                (int)(BitRates)cb_bitRate.SelectedValue);

            stream = new ScreenCaptureStream(screenBounds);
            stream.NewFrame += Stream_NewFrame;
            stream.Start();
            watch = new Stopwatch();
            watch.Start();
            isRecording = true;
        }

        private void Stream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            frames++;
            writer.WriteVideoFrame(eventArgs.Frame);
            lblFrames.Invoke(new MethodInvoker( () => { lblFrames.Text = $"Frames: {frames} "; }));
            lblStopWatch.Invoke(new MethodInvoker( ()=> { lblStopWatch.Text = watch.Elapsed.ToString(); } ));
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if(isRecording)
            {
                stream.Stop();
                writer.Close();
            }
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (lstSource.SelectedIndex == -1) return;
            string url = lstSource.SelectedItem.ToString();
            if (url.Contains("mjpg"))
            {
                if (jPEG != null) jPEG.Stop();
                if (mJPEG == null)
                { 
                    mJPEG = new MJPEGStream();
                    mJPEG.NewFrame += MJPEG_NewFrame;
                }
                if (mJPEG.Source != url)
                {
                    mJPEG.Source = url;
                    mJPEG.Start();
                    return;
                }
                mJPEG.Source = url;
                if (mJPEG.IsRunning)
                {
                    mJPEG.Stop();
                    picCam.Image = null;
                }
                else
                {
                    mJPEG.Start();
                }
            }
            else
            {
                if (mJPEG != null) mJPEG.Stop();
                if (jPEG == null)
                {
                    jPEG = new JPEGStream();
                    jPEG.NewFrame += JPEG_NewFrame;
                }
                jPEG.Source = url;
                if (jPEG.IsRunning)
                {
                    jPEG.Stop();
                }
                else
                {
                    jPEG.Start();
                }
            }
            
        }

        private void JPEG_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            picCam.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void MJPEG_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            picCam.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstSource.SelectedIndex = new Random().Next(lstSource.Items.Count);
            btnStartStop.PerformClick();
        }
    }
}
