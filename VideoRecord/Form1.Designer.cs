namespace VideoRecord
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
            this.cb_screenSelector = new System.Windows.Forms.ComboBox();
            this.cb_videoCodec = new System.Windows.Forms.ComboBox();
            this.cb_bitRate = new System.Windows.Forms.ComboBox();
            this.numFps = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFrames = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblStopWatch = new System.Windows.Forms.Label();
            this.lstSource = new System.Windows.Forms.ListBox();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.picCam = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numFps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_screenSelector
            // 
            this.cb_screenSelector.FormattingEnabled = true;
            this.cb_screenSelector.Location = new System.Drawing.Point(61, 66);
            this.cb_screenSelector.Name = "cb_screenSelector";
            this.cb_screenSelector.Size = new System.Drawing.Size(128, 21);
            this.cb_screenSelector.TabIndex = 0;
            // 
            // cb_videoCodec
            // 
            this.cb_videoCodec.FormattingEnabled = true;
            this.cb_videoCodec.Location = new System.Drawing.Point(73, 12);
            this.cb_videoCodec.Name = "cb_videoCodec";
            this.cb_videoCodec.Size = new System.Drawing.Size(128, 21);
            this.cb_videoCodec.TabIndex = 1;
            // 
            // cb_bitRate
            // 
            this.cb_bitRate.FormattingEnabled = true;
            this.cb_bitRate.Location = new System.Drawing.Point(252, 12);
            this.cb_bitRate.Name = "cb_bitRate";
            this.cb_bitRate.Size = new System.Drawing.Size(128, 21);
            this.cb_bitRate.TabIndex = 2;
            // 
            // numFps
            // 
            this.numFps.Location = new System.Drawing.Point(252, 67);
            this.numFps.Name = "numFps";
            this.numFps.Size = new System.Drawing.Size(111, 20);
            this.numFps.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Screens";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "VideoCodec";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bitrate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "FPS";
            // 
            // lblFrames
            // 
            this.lblFrames.AutoSize = true;
            this.lblFrames.Location = new System.Drawing.Point(15, 208);
            this.lblFrames.Name = "lblFrames";
            this.lblFrames.Size = new System.Drawing.Size(47, 13);
            this.lblFrames.TabIndex = 8;
            this.lblFrames.Text = "Frames :";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(199, 193);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(79, 43);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(284, 193);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(79, 43);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Save in folder :";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 167);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(351, 20);
            this.txtPath.TabIndex = 12;
            // 
            // lblStopWatch
            // 
            this.lblStopWatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStopWatch.Location = new System.Drawing.Point(35, 103);
            this.lblStopWatch.Name = "lblStopWatch";
            this.lblStopWatch.Size = new System.Drawing.Size(328, 43);
            this.lblStopWatch.TabIndex = 13;
            this.lblStopWatch.Text = "00:00:00.0000000";
            // 
            // lstSource
            // 
            this.lstSource.FormattingEnabled = true;
            this.lstSource.Items.AddRange(new object[] {
            "http://185.10.80.33:8082/cgi-bin/faststream.jpg?stream=half&fps=15&rand=COUNTER",
            "http://77.89.48.19:8000/cgi-bin/viewer/video.jpg?r=COUNTER",
            "http://162.245.149.145:80/mjpg/video.mjpg",
            "http://92.154.56.150:8888/mjpg/video.mjpg"});
            this.lstSource.Location = new System.Drawing.Point(975, 12);
            this.lstSource.Name = "lstSource";
            this.lstSource.Size = new System.Drawing.Size(332, 485);
            this.lstSource.TabIndex = 14;
            // 
            // btnStartStop
            // 
            this.btnStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartStop.Location = new System.Drawing.Point(453, 1);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(219, 36);
            this.btnStartStop.TabIndex = 15;
            this.btnStartStop.Text = "Start Stop";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // picCam
            // 
            this.picCam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCam.Location = new System.Drawing.Point(369, 43);
            this.picCam.Name = "picCam";
            this.picCam.Size = new System.Drawing.Size(600, 480);
            this.picCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCam.TabIndex = 16;
            this.picCam.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(690, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 36);
            this.button1.TabIndex = 17;
            this.button1.Text = "Random Source";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 535);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picCam);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.lstSource);
            this.Controls.Add(this.lblStopWatch);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblFrames);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numFps);
            this.Controls.Add(this.cb_bitRate);
            this.Controls.Add(this.cb_videoCodec);
            this.Controls.Add(this.cb_screenSelector);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numFps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_screenSelector;
        private System.Windows.Forms.ComboBox cb_videoCodec;
        private System.Windows.Forms.ComboBox cb_bitRate;
        private System.Windows.Forms.NumericUpDown numFps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFrames;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblStopWatch;
        private System.Windows.Forms.ListBox lstSource;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.PictureBox picCam;
        private System.Windows.Forms.Button button1;
    }
}

