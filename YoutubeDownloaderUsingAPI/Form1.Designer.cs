namespace YoutubeDownloaderUsingAPI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtGetInfo = new System.Windows.Forms.Button();
            this.PicVideoImage = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAverageRating = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.txtDislike = new System.Windows.Forms.TextBox();
            this.txtLikes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboQuality = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDLMp3 = new System.Windows.Forms.Button();
            this.btnDLVideo = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.PicVideoImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Youtube URL : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title : ";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(123, 12);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(454, 22);
            this.txtURL.TabIndex = 2;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(150, 30);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(412, 22);
            this.txtTitle.TabIndex = 3;
            // 
            // txtGetInfo
            // 
            this.txtGetInfo.Location = new System.Drawing.Point(9, 40);
            this.txtGetInfo.Name = "txtGetInfo";
            this.txtGetInfo.Size = new System.Drawing.Size(568, 57);
            this.txtGetInfo.TabIndex = 4;
            this.txtGetInfo.Text = "Get Video Information";
            this.txtGetInfo.UseVisualStyleBackColor = true;
            this.txtGetInfo.Click += new System.EventHandler(this.txtGetInfo_Click);
            // 
            // PicVideoImage
            // 
            this.PicVideoImage.Location = new System.Drawing.Point(9, 103);
            this.PicVideoImage.Name = "PicVideoImage";
            this.PicVideoImage.Size = new System.Drawing.Size(568, 207);
            this.PicVideoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicVideoImage.TabIndex = 7;
            this.PicVideoImage.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAverageRating);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rtbDescription);
            this.groupBox1.Controls.Add(this.txtDislike);
            this.groupBox1.Controls.Add(this.txtLikes);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 188);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video Information";
            // 
            // txtAverageRating
            // 
            this.txtAverageRating.Location = new System.Drawing.Point(150, 148);
            this.txtAverageRating.Name = "txtAverageRating";
            this.txtAverageRating.ReadOnly = true;
            this.txtAverageRating.Size = new System.Drawing.Size(412, 22);
            this.txtAverageRating.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Average Rating : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Description : ";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(150, 86);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(412, 56);
            this.rtbDescription.TabIndex = 11;
            this.rtbDescription.Text = "";
            // 
            // txtDislike
            // 
            this.txtDislike.Location = new System.Drawing.Point(389, 58);
            this.txtDislike.Name = "txtDislike";
            this.txtDislike.ReadOnly = true;
            this.txtDislike.Size = new System.Drawing.Size(173, 22);
            this.txtDislike.TabIndex = 10;
            // 
            // txtLikes
            // 
            this.txtLikes.Location = new System.Drawing.Point(150, 58);
            this.txtLikes.Name = "txtLikes";
            this.txtLikes.ReadOnly = true;
            this.txtLikes.Size = new System.Drawing.Size(166, 22);
            this.txtLikes.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dislike : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Likes : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFileName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.Controls.Add(this.txtFilePath);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(9, 510);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 86);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Information";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(150, 53);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(412, 22);
            this.txtFileName.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Save File Name : ";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(458, 25);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(104, 28);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(150, 25);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(302, 22);
            this.txtFilePath.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Save to File Path : ";
            // 
            // ComboQuality
            // 
            this.ComboQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboQuality.FormattingEnabled = true;
            this.ComboQuality.Location = new System.Drawing.Point(150, 25);
            this.ComboQuality.Name = "ComboQuality";
            this.ComboQuality.Size = new System.Drawing.Size(412, 24);
            this.ComboQuality.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Video Quality : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.ComboQuality);
            this.groupBox3.Location = new System.Drawing.Point(9, 602);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(568, 100);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Downloads";
            // 
            // btnDLMp3
            // 
            this.btnDLMp3.Location = new System.Drawing.Point(15, 708);
            this.btnDLMp3.Name = "btnDLMp3";
            this.btnDLMp3.Size = new System.Drawing.Size(260, 37);
            this.btnDLMp3.TabIndex = 13;
            this.btnDLMp3.Text = "Download Mp3";
            this.btnDLMp3.UseVisualStyleBackColor = true;
            this.btnDLMp3.Click += new System.EventHandler(this.btnDLMp3_Click);
            // 
            // btnDLVideo
            // 
            this.btnDLVideo.Location = new System.Drawing.Point(281, 708);
            this.btnDLVideo.Name = "btnDLVideo";
            this.btnDLVideo.Size = new System.Drawing.Size(296, 37);
            this.btnDLVideo.TabIndex = 14;
            this.btnDLVideo.Text = "Download Video";
            this.btnDLVideo.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 55);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(556, 28);
            this.progressBar1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 757);
            this.Controls.Add(this.btnDLVideo);
            this.Controls.Add(this.btnDLMp3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PicVideoImage);
            this.Controls.Add(this.txtGetInfo);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Youtube Downloader";
            ((System.ComponentModel.ISupportInitialize)(this.PicVideoImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button txtGetInfo;
        private System.Windows.Forms.PictureBox PicVideoImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDislike;
        private System.Windows.Forms.TextBox txtLikes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.TextBox txtAverageRating;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ComboQuality;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDLMp3;
        private System.Windows.Forms.Button btnDLVideo;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

