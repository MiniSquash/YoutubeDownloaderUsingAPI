using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using YoutubeExplode;
using YoutubeExplode.Models;
using NReco.VideoConverter;

namespace YoutubeDownloaderUsingAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Class variable can be called from any class.
        bool VideoExist = false;
        bool PathSelected = false;
        string VideoID;

        private async void txtGetInfo_Click(object sender, EventArgs e)
        {
            YoutubeClient client = new YoutubeClient();

            //Get the VideoID
            string inputURL;

            inputURL = txtURL.Text;
            //This just checks if it is a youtube URL
            if (YoutubeClient.TryParseVideoId(inputURL, out VideoID)==false)
            {
                MessageBox.Show("Please ensure that you have entered the correct URL");
                txtURL.Clear();
                txtURL.Focus();
            }
            else
            {
                VideoExist = await client.CheckVideoExistsAsync(VideoID);
                if (VideoExist==false)
                {
                    MessageBox.Show("There is no video available.");
                }
                else
                {
                    //All the information stored within VideoInfo
                    VideoInfo VideoInfo = await client.GetVideoInfoAsync(VideoID);

                    //We can use it to do alot of stuff such as load image and text. (Currenttly just placing information in textbox)
                    PicVideoImage.Load(VideoInfo.ImageMediumResUrl);
                    txtTitle.Text = VideoInfo.Title;
                    txtLikes.Text = VideoInfo.LikeCount.ToString();
                    txtDislike.Text = VideoInfo.DislikeCount.ToString();
                    rtbDescription.Text = VideoInfo.Description;
                    txtAverageRating.Text = VideoInfo.AverageRating.ToString("N2");

                    //Prints al the arrays in MixedStream for easy selection :)
                    foreach (var MixedStream in VideoInfo.VideoStreams)
                    {
                        ComboQuality.Items.Add(MixedStream);
                    }
                    ComboQuality.DisplayMember = "VideoQualityLabel";
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderBrowser = new FolderBrowserDialog();
            FolderBrowser.Description = "Browse to the folder you want to save in.";

            if (FolderBrowser.ShowDialog() == DialogResult.OK)
            {
                PathSelected = true;
                string SelectedPath = FolderBrowser.SelectedPath;
                txtFilePath.Text = SelectedPath;
            }
        }

        private async void btnDLMp3_Click(object sender, EventArgs e)
        {
            if (VideoExist == false) //Because VideoExist checks for ID first. Therefore ID will forever be present :)
            {
                MessageBox.Show("Please press Get Video Information first.");
            }
            else if (txtFileName.Text == "")
            {
                MessageBox.Show("Please write in a file name.");
            }
            else if (PathSelected == false)
            {
                MessageBox.Show("Please select a file path.");
            }
            else
            {
                YoutubeClient client = new YoutubeClient();
                var VideoInfo = await client.GetVideoInfoAsync(VideoID);
                var AudioInfo = VideoInfo.AudioStreams.OrderBy(s => s.Bitrate).Last();

                //Get File Extension
                string fileExtension = AudioInfo.Container.GetFileExtension();
                string FilePath =  txtFilePath.Text + "\\" + txtFileName.Text + "." + fileExtension;

                //Download
                await client.DownloadMediaStreamAsync(AudioInfo, FilePath);


                // Create the FFMpeg Converter
                var ffMpeg = new FFMpegConverter();

                // Create the MP3 Path
                ffMpeg.ConvertMedia(FilePath, FilePath, "mp4");

                MessageBox.Show("Download Completed!");
            }
        }
    }
}
