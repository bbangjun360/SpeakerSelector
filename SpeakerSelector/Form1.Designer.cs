namespace SpeakerSelector
{
    partial class SpeakerSelector
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpeakerSelector));
            this.btnSetUp = new System.Windows.Forms.Button();
            this.lbLogo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_ch1deg = new System.Windows.Forms.Label();
            this.lb_ch1 = new System.Windows.Forms.Label();
            this.lb_ch2 = new System.Windows.Forms.Label();
            this.lb_ch3 = new System.Windows.Forms.Label();
            this.lb_ch4 = new System.Windows.Forms.Label();
            this.lb_ch5 = new System.Windows.Forms.Label();
            this.lb_ch6 = new System.Windows.Forms.Label();
            this.lb_ch7 = new System.Windows.Forms.Label();
            this.lb_ch8 = new System.Windows.Forms.Label();
            this.lb_ch7deg = new System.Windows.Forms.Label();
            this.lb_ch6deg = new System.Windows.Forms.Label();
            this.lb_ch5deg = new System.Windows.Forms.Label();
            this.lb_ch4deg = new System.Windows.Forms.Label();
            this.lb_ch3deg = new System.Windows.Forms.Label();
            this.lb_ch2deg = new System.Windows.Forms.Label();
            this.lb_ch8deg = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pb_ch5 = new System.Windows.Forms.PictureBox();
            this.pb_ch7 = new System.Windows.Forms.PictureBox();
            this.pb_ch1 = new System.Windows.Forms.PictureBox();
            this.pb_ch2 = new System.Windows.Forms.PictureBox();
            this.pb_ch8 = new System.Windows.Forms.PictureBox();
            this.pb_ch4 = new System.Windows.Forms.PictureBox();
            this.pb_ch6 = new System.Windows.Forms.PictureBox();
            this.pb_ch3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pb_ChairCircle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ch5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ch7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ch1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ch2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ch8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ch4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ch6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ch3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ChairCircle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSetUp
            // 
            this.btnSetUp.BackColor = System.Drawing.Color.White;
            this.btnSetUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetUp.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSetUp.Location = new System.Drawing.Point(807, 1);
            this.btnSetUp.Name = "btnSetUp";
            this.btnSetUp.Size = new System.Drawing.Size(75, 23);
            this.btnSetUp.TabIndex = 1;
            this.btnSetUp.Text = "SetUp";
            this.btnSetUp.UseVisualStyleBackColor = false;
            this.btnSetUp.Click += new System.EventHandler(this.btnSetUp_Click);
            // 
            // lbLogo
            // 
            this.lbLogo.AutoSize = true;
            this.lbLogo.Font = new System.Drawing.Font("휴먼모음T", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbLogo.Location = new System.Drawing.Point(761, 793);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(106, 54);
            this.lbLogo.TabIndex = 3;
            this.lbLogo.Text = "Sound\r\nSelector";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼모음T", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(765, 845);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sound.Care.Tech";
            // 
            // lb_ch1deg
            // 
            this.lb_ch1deg.AutoSize = true;
            this.lb_ch1deg.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ch1deg.Location = new System.Drawing.Point(446, 167);
            this.lb_ch1deg.Name = "lb_ch1deg";
            this.lb_ch1deg.Size = new System.Drawing.Size(32, 12);
            this.lb_ch1deg.TabIndex = 9;
            this.lb_ch1deg.Text = "0 °";
            // 
            // lb_ch1
            // 
            this.lb_ch1.AutoSize = true;
            this.lb_ch1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ch1.Location = new System.Drawing.Point(389, 12);
            this.lb_ch1.Name = "lb_ch1";
            this.lb_ch1.Size = new System.Drawing.Size(38, 12);
            this.lb_ch1.TabIndex = 19;
            this.lb_ch1.Text = "CH.1";
            // 
            // lb_ch2
            // 
            this.lb_ch2.AutoSize = true;
            this.lb_ch2.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ch2.Location = new System.Drawing.Point(676, 91);
            this.lb_ch2.Name = "lb_ch2";
            this.lb_ch2.Size = new System.Drawing.Size(38, 12);
            this.lb_ch2.TabIndex = 20;
            this.lb_ch2.Text = "CH.2";
            // 
            // lb_ch3
            // 
            this.lb_ch3.AutoSize = true;
            this.lb_ch3.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ch3.Location = new System.Drawing.Point(770, 377);
            this.lb_ch3.Name = "lb_ch3";
            this.lb_ch3.Size = new System.Drawing.Size(38, 12);
            this.lb_ch3.TabIndex = 21;
            this.lb_ch3.Text = "CH.3";
            // 
            // lb_ch4
            // 
            this.lb_ch4.AutoSize = true;
            this.lb_ch4.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ch4.Location = new System.Drawing.Point(676, 662);
            this.lb_ch4.Name = "lb_ch4";
            this.lb_ch4.Size = new System.Drawing.Size(38, 12);
            this.lb_ch4.TabIndex = 22;
            this.lb_ch4.Text = "CH.4";
            // 
            // lb_ch5
            // 
            this.lb_ch5.AutoSize = true;
            this.lb_ch5.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ch5.Location = new System.Drawing.Point(389, 745);
            this.lb_ch5.Name = "lb_ch5";
            this.lb_ch5.Size = new System.Drawing.Size(38, 12);
            this.lb_ch5.TabIndex = 23;
            this.lb_ch5.Text = "CH.5";
            // 
            // lb_ch6
            // 
            this.lb_ch6.AutoSize = true;
            this.lb_ch6.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ch6.Location = new System.Drawing.Point(104, 662);
            this.lb_ch6.Name = "lb_ch6";
            this.lb_ch6.Size = new System.Drawing.Size(38, 12);
            this.lb_ch6.TabIndex = 24;
            this.lb_ch6.Text = "CH.6";
            // 
            // lb_ch7
            // 
            this.lb_ch7.AutoSize = true;
            this.lb_ch7.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ch7.Location = new System.Drawing.Point(10, 377);
            this.lb_ch7.Name = "lb_ch7";
            this.lb_ch7.Size = new System.Drawing.Size(38, 12);
            this.lb_ch7.TabIndex = 25;
            this.lb_ch7.Text = "CH.7";
            // 
            // lb_ch8
            // 
            this.lb_ch8.AutoSize = true;
            this.lb_ch8.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ch8.Location = new System.Drawing.Point(104, 91);
            this.lb_ch8.Name = "lb_ch8";
            this.lb_ch8.Size = new System.Drawing.Size(38, 12);
            this.lb_ch8.TabIndex = 26;
            this.lb_ch8.Text = "CH.8";
            // 
            // lb_ch7deg
            // 
            this.lb_ch7deg.AutoSize = true;
            this.lb_ch7deg.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ch7deg.Location = new System.Drawing.Point(174, 410);
            this.lb_ch7deg.Name = "lb_ch7deg";
            this.lb_ch7deg.Size = new System.Drawing.Size(50, 12);
            this.lb_ch7deg.TabIndex = 27;
            this.lb_ch7deg.Text = "270 °";
            // 
            // lb_ch6deg
            // 
            this.lb_ch6deg.AutoSize = true;
            this.lb_ch6deg.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ch6deg.Location = new System.Drawing.Point(223, 580);
            this.lb_ch6deg.Name = "lb_ch6deg";
            this.lb_ch6deg.Size = new System.Drawing.Size(50, 12);
            this.lb_ch6deg.TabIndex = 28;
            this.lb_ch6deg.Text = "225 °";
            // 
            // lb_ch5deg
            // 
            this.lb_ch5deg.AutoSize = true;
            this.lb_ch5deg.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ch5deg.Location = new System.Drawing.Point(389, 672);
            this.lb_ch5deg.Name = "lb_ch5deg";
            this.lb_ch5deg.Size = new System.Drawing.Size(50, 12);
            this.lb_ch5deg.TabIndex = 29;
            this.lb_ch5deg.Text = "180 °";
            // 
            // lb_ch4deg
            // 
            this.lb_ch4deg.AutoSize = true;
            this.lb_ch4deg.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ch4deg.Location = new System.Drawing.Point(572, 621);
            this.lb_ch4deg.Name = "lb_ch4deg";
            this.lb_ch4deg.Size = new System.Drawing.Size(50, 12);
            this.lb_ch4deg.TabIndex = 30;
            this.lb_ch4deg.Text = "135 °";
            // 
            // lb_ch3deg
            // 
            this.lb_ch3deg.AutoSize = true;
            this.lb_ch3deg.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ch3deg.Location = new System.Drawing.Point(676, 433);
            this.lb_ch3deg.Name = "lb_ch3deg";
            this.lb_ch3deg.Size = new System.Drawing.Size(41, 12);
            this.lb_ch3deg.TabIndex = 31;
            this.lb_ch3deg.Text = "90 °";
            // 
            // lb_ch2deg
            // 
            this.lb_ch2deg.AutoSize = true;
            this.lb_ch2deg.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ch2deg.Location = new System.Drawing.Point(619, 257);
            this.lb_ch2deg.Name = "lb_ch2deg";
            this.lb_ch2deg.Size = new System.Drawing.Size(41, 12);
            this.lb_ch2deg.TabIndex = 32;
            this.lb_ch2deg.Text = "45 °";
            // 
            // lb_ch8deg
            // 
            this.lb_ch8deg.AutoSize = true;
            this.lb_ch8deg.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ch8deg.Location = new System.Drawing.Point(262, 232);
            this.lb_ch8deg.Name = "lb_ch8deg";
            this.lb_ch8deg.Size = new System.Drawing.Size(50, 12);
            this.lb_ch8deg.TabIndex = 33;
            this.lb_ch8deg.Text = "315 °";
            // 
            // pb_ch5
            // 
            this.pb_ch5.BackgroundImage = global::SpeakerSelector.Properties.Resources.spk_off;
            this.pb_ch5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_ch5.Location = new System.Drawing.Point(391, 745);
            this.pb_ch5.Name = "pb_ch5";
            this.pb_ch5.Size = new System.Drawing.Size(100, 100);
            this.pb_ch5.TabIndex = 18;
            this.pb_ch5.TabStop = false;
            this.pb_ch5.Click += new System.EventHandler(this.pb_ch5_Click);
            // 
            // pb_ch7
            // 
            this.pb_ch7.BackgroundImage = global::SpeakerSelector.Properties.Resources.spk_off;
            this.pb_ch7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_ch7.Location = new System.Drawing.Point(12, 377);
            this.pb_ch7.Name = "pb_ch7";
            this.pb_ch7.Size = new System.Drawing.Size(100, 100);
            this.pb_ch7.TabIndex = 17;
            this.pb_ch7.TabStop = false;
            this.pb_ch7.Click += new System.EventHandler(this.pb_ch7_Click);
            // 
            // pb_ch1
            // 
            this.pb_ch1.BackgroundImage = global::SpeakerSelector.Properties.Resources.spk_off;
            this.pb_ch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_ch1.Location = new System.Drawing.Point(391, 12);
            this.pb_ch1.Name = "pb_ch1";
            this.pb_ch1.Size = new System.Drawing.Size(100, 100);
            this.pb_ch1.TabIndex = 16;
            this.pb_ch1.TabStop = false;
            this.pb_ch1.Click += new System.EventHandler(this.pb_ch1_Click);
            // 
            // pb_ch2
            // 
            this.pb_ch2.BackgroundImage = global::SpeakerSelector.Properties.Resources.spk_off;
            this.pb_ch2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_ch2.Location = new System.Drawing.Point(678, 91);
            this.pb_ch2.Name = "pb_ch2";
            this.pb_ch2.Size = new System.Drawing.Size(100, 100);
            this.pb_ch2.TabIndex = 15;
            this.pb_ch2.TabStop = false;
            this.pb_ch2.Click += new System.EventHandler(this.pb_ch2_Click);
            // 
            // pb_ch8
            // 
            this.pb_ch8.BackgroundImage = global::SpeakerSelector.Properties.Resources.spk_off;
            this.pb_ch8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_ch8.Location = new System.Drawing.Point(106, 91);
            this.pb_ch8.Name = "pb_ch8";
            this.pb_ch8.Size = new System.Drawing.Size(100, 100);
            this.pb_ch8.TabIndex = 14;
            this.pb_ch8.TabStop = false;
            this.pb_ch8.Click += new System.EventHandler(this.pb_ch8_Click);
            // 
            // pb_ch4
            // 
            this.pb_ch4.BackgroundImage = global::SpeakerSelector.Properties.Resources.spk_off;
            this.pb_ch4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_ch4.Location = new System.Drawing.Point(677, 662);
            this.pb_ch4.Name = "pb_ch4";
            this.pb_ch4.Size = new System.Drawing.Size(100, 100);
            this.pb_ch4.TabIndex = 13;
            this.pb_ch4.TabStop = false;
            this.pb_ch4.Click += new System.EventHandler(this.pb_ch4_Click);
            // 
            // pb_ch6
            // 
            this.pb_ch6.BackgroundImage = global::SpeakerSelector.Properties.Resources.spk_off;
            this.pb_ch6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_ch6.Location = new System.Drawing.Point(106, 662);
            this.pb_ch6.Name = "pb_ch6";
            this.pb_ch6.Size = new System.Drawing.Size(100, 100);
            this.pb_ch6.TabIndex = 12;
            this.pb_ch6.TabStop = false;
            this.pb_ch6.Click += new System.EventHandler(this.pb_ch6_Click);
            // 
            // pb_ch3
            // 
            this.pb_ch3.BackgroundImage = global::SpeakerSelector.Properties.Resources.spk_off;
            this.pb_ch3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_ch3.Location = new System.Drawing.Point(772, 377);
            this.pb_ch3.Name = "pb_ch3";
            this.pb_ch3.Size = new System.Drawing.Size(100, 100);
            this.pb_ch3.TabIndex = 11;
            this.pb_ch3.TabStop = false;
            this.pb_ch3.Click += new System.EventHandler(this.pb_ch3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::SpeakerSelector.Properties.Resources.logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(702, 784);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 80);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pb_ChairCircle
            // 
            this.pb_ChairCircle.BackgroundImage = global::SpeakerSelector.Properties.Resources.CircleChair0deg;
            this.pb_ChairCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_ChairCircle.InitialImage = null;
            this.pb_ChairCircle.Location = new System.Drawing.Point(39, 27);
            this.pb_ChairCircle.Name = "pb_ChairCircle";
            this.pb_ChairCircle.Size = new System.Drawing.Size(800, 800);
            this.pb_ChairCircle.TabIndex = 0;
            this.pb_ChairCircle.TabStop = false;
            // 
            // SpeakerSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 861);
            this.Controls.Add(this.lb_ch8deg);
            this.Controls.Add(this.lb_ch2deg);
            this.Controls.Add(this.lb_ch3deg);
            this.Controls.Add(this.lb_ch4deg);
            this.Controls.Add(this.lb_ch5deg);
            this.Controls.Add(this.lb_ch6deg);
            this.Controls.Add(this.lb_ch7deg);
            this.Controls.Add(this.lb_ch8);
            this.Controls.Add(this.lb_ch7);
            this.Controls.Add(this.lb_ch6);
            this.Controls.Add(this.lb_ch5);
            this.Controls.Add(this.lb_ch4);
            this.Controls.Add(this.lb_ch3);
            this.Controls.Add(this.lb_ch2);
            this.Controls.Add(this.lb_ch1);
            this.Controls.Add(this.pb_ch5);
            this.Controls.Add(this.pb_ch7);
            this.Controls.Add(this.pb_ch1);
            this.Controls.Add(this.pb_ch2);
            this.Controls.Add(this.pb_ch8);
            this.Controls.Add(this.pb_ch4);
            this.Controls.Add(this.pb_ch6);
            this.Controls.Add(this.pb_ch3);
            this.Controls.Add(this.lb_ch1deg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLogo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnSetUp);
            this.Controls.Add(this.pb_ChairCircle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpeakerSelector";
            this.Text = "SoundCareTech.";
            this.Load += new System.EventHandler(this.SpeakerSelector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ch5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ch7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ch1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ch2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ch8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ch4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ch6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ch3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ChairCircle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSetUp;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_ch3;
        private System.Windows.Forms.PictureBox pb_ch1;
        private System.Windows.Forms.PictureBox pb_ch7;
        private System.Windows.Forms.PictureBox pb_ch5;
        private System.Windows.Forms.Label lb_ch1;
        public System.Windows.Forms.PictureBox pb_ChairCircle;
        public System.Windows.Forms.Label lb_ch1deg;
        public System.Windows.Forms.Label lb_ch7deg;
        public System.Windows.Forms.Label lb_ch6deg;
        public System.Windows.Forms.Label lb_ch5deg;
        public System.Windows.Forms.Label lb_ch4deg;
        public System.Windows.Forms.Label lb_ch3deg;
        public System.Windows.Forms.Label lb_ch2deg;
        public System.Windows.Forms.Label lb_ch8deg;
        public System.IO.Ports.SerialPort serialPort1;
        public System.Windows.Forms.PictureBox pb_ch6;
        public System.Windows.Forms.PictureBox pb_ch4;
        public System.Windows.Forms.PictureBox pb_ch8;
        public System.Windows.Forms.PictureBox pb_ch2;
        public System.Windows.Forms.Label lb_ch2;
        public System.Windows.Forms.Label lb_ch3;
        public System.Windows.Forms.Label lb_ch4;
        public System.Windows.Forms.Label lb_ch5;
        public System.Windows.Forms.Label lb_ch6;
        public System.Windows.Forms.Label lb_ch7;
        public System.Windows.Forms.Label lb_ch8;
    }
}

