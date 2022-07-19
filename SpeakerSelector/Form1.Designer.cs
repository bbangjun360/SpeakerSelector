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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "ch6",
            "1s / 3s",
            "1"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "ch1",
            "0.5s / 2s",
            "3"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "ch3",
            "2s / 1s",
            "2"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "ch2",
            "0.7s / 1s",
            "10"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "ch7",
            "3s / 0.5s",
            "4"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "ch8",
            "1s / 3s",
            "1"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpeakerSelector));
            this.btnSetUp = new System.Windows.Forms.Button();
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSetUp
            // 
            this.btnSetUp.BackColor = System.Drawing.Color.White;
            this.btnSetUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetUp.Font = new System.Drawing.Font("휴먼둥근헤드라인", 7F);
            this.btnSetUp.Location = new System.Drawing.Point(563, 0);
            this.btnSetUp.Name = "btnSetUp";
            this.btnSetUp.Size = new System.Drawing.Size(68, 21);
            this.btnSetUp.TabIndex = 1;
            this.btnSetUp.Text = "SetUp";
            this.btnSetUp.UseVisualStyleBackColor = false;
            this.btnSetUp.Click += new System.EventHandler(this.btnSetUp_Click);
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
            this.lb_ch1deg.Location = new System.Drawing.Point(321, 124);
            this.lb_ch1deg.Name = "lb_ch1deg";
            this.lb_ch1deg.Size = new System.Drawing.Size(32, 12);
            this.lb_ch1deg.TabIndex = 9;
            this.lb_ch1deg.Text = "0 °";
            // 
            // lb_ch1
            // 
            this.lb_ch1.AutoSize = true;
            this.lb_ch1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ch1.Location = new System.Drawing.Point(281, 0);
            this.lb_ch1.Name = "lb_ch1";
            this.lb_ch1.Size = new System.Drawing.Size(26, 8);
            this.lb_ch1.TabIndex = 19;
            this.lb_ch1.Text = "CH.1";
            // 
            // lb_ch2
            // 
            this.lb_ch2.AutoSize = true;
            this.lb_ch2.Font = new System.Drawing.Font("휴먼둥근헤드라인", 6F);
            this.lb_ch2.Location = new System.Drawing.Point(499, 52);
            this.lb_ch2.Name = "lb_ch2";
            this.lb_ch2.Size = new System.Drawing.Size(26, 8);
            this.lb_ch2.TabIndex = 20;
            this.lb_ch2.Text = "CH.2";
            // 
            // lb_ch3
            // 
            this.lb_ch3.AutoSize = true;
            this.lb_ch3.Font = new System.Drawing.Font("휴먼둥근헤드라인", 6F);
            this.lb_ch3.Location = new System.Drawing.Point(554, 272);
            this.lb_ch3.Name = "lb_ch3";
            this.lb_ch3.Size = new System.Drawing.Size(26, 8);
            this.lb_ch3.TabIndex = 21;
            this.lb_ch3.Text = "CH.3";
            // 
            // lb_ch4
            // 
            this.lb_ch4.AutoSize = true;
            this.lb_ch4.Font = new System.Drawing.Font("휴먼둥근헤드라인", 6F);
            this.lb_ch4.Location = new System.Drawing.Point(492, 483);
            this.lb_ch4.Name = "lb_ch4";
            this.lb_ch4.Size = new System.Drawing.Size(26, 8);
            this.lb_ch4.TabIndex = 22;
            this.lb_ch4.Text = "CH.4";
            // 
            // lb_ch5
            // 
            this.lb_ch5.AutoSize = true;
            this.lb_ch5.Font = new System.Drawing.Font("휴먼둥근헤드라인", 6F);
            this.lb_ch5.Location = new System.Drawing.Point(282, 545);
            this.lb_ch5.Name = "lb_ch5";
            this.lb_ch5.Size = new System.Drawing.Size(26, 8);
            this.lb_ch5.TabIndex = 23;
            this.lb_ch5.Text = "CH.5";
            // 
            // lb_ch6
            // 
            this.lb_ch6.AutoSize = true;
            this.lb_ch6.Font = new System.Drawing.Font("휴먼둥근헤드라인", 6F);
            this.lb_ch6.Location = new System.Drawing.Point(70, 483);
            this.lb_ch6.Name = "lb_ch6";
            this.lb_ch6.Size = new System.Drawing.Size(26, 8);
            this.lb_ch6.TabIndex = 24;
            this.lb_ch6.Text = "CH.6";
            // 
            // lb_ch7
            // 
            this.lb_ch7.AutoSize = true;
            this.lb_ch7.Font = new System.Drawing.Font("휴먼둥근헤드라인", 6F);
            this.lb_ch7.Location = new System.Drawing.Point(8, 273);
            this.lb_ch7.Name = "lb_ch7";
            this.lb_ch7.Size = new System.Drawing.Size(26, 8);
            this.lb_ch7.TabIndex = 25;
            this.lb_ch7.Text = "CH.7";
            // 
            // lb_ch8
            // 
            this.lb_ch8.AutoSize = true;
            this.lb_ch8.Font = new System.Drawing.Font("휴먼둥근헤드라인", 6F);
            this.lb_ch8.Location = new System.Drawing.Point(70, 61);
            this.lb_ch8.Name = "lb_ch8";
            this.lb_ch8.Size = new System.Drawing.Size(26, 8);
            this.lb_ch8.TabIndex = 26;
            this.lb_ch8.Text = "CH.8";
            // 
            // lb_ch7deg
            // 
            this.lb_ch7deg.AutoSize = true;
            this.lb_ch7deg.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ch7deg.Location = new System.Drawing.Point(108, 296);
            this.lb_ch7deg.Name = "lb_ch7deg";
            this.lb_ch7deg.Size = new System.Drawing.Size(50, 12);
            this.lb_ch7deg.TabIndex = 27;
            this.lb_ch7deg.Text = "270 °";
            // 
            // lb_ch6deg
            // 
            this.lb_ch6deg.AutoSize = true;
            this.lb_ch6deg.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ch6deg.Location = new System.Drawing.Point(146, 420);
            this.lb_ch6deg.Name = "lb_ch6deg";
            this.lb_ch6deg.Size = new System.Drawing.Size(50, 12);
            this.lb_ch6deg.TabIndex = 28;
            this.lb_ch6deg.Text = "225 °";
            // 
            // lb_ch5deg
            // 
            this.lb_ch5deg.AutoSize = true;
            this.lb_ch5deg.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ch5deg.Location = new System.Drawing.Point(268, 483);
            this.lb_ch5deg.Name = "lb_ch5deg";
            this.lb_ch5deg.Size = new System.Drawing.Size(50, 12);
            this.lb_ch5deg.TabIndex = 29;
            this.lb_ch5deg.Text = "180 °";
            // 
            // lb_ch4deg
            // 
            this.lb_ch4deg.AutoSize = true;
            this.lb_ch4deg.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ch4deg.Location = new System.Drawing.Point(411, 451);
            this.lb_ch4deg.Name = "lb_ch4deg";
            this.lb_ch4deg.Size = new System.Drawing.Size(50, 12);
            this.lb_ch4deg.TabIndex = 30;
            this.lb_ch4deg.Text = "135 °";
            // 
            // lb_ch3deg
            // 
            this.lb_ch3deg.AutoSize = true;
            this.lb_ch3deg.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ch3deg.Location = new System.Drawing.Point(492, 314);
            this.lb_ch3deg.Name = "lb_ch3deg";
            this.lb_ch3deg.Size = new System.Drawing.Size(41, 12);
            this.lb_ch3deg.TabIndex = 31;
            this.lb_ch3deg.Text = "90 °";
            // 
            // lb_ch2deg
            // 
            this.lb_ch2deg.AutoSize = true;
            this.lb_ch2deg.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ch2deg.Location = new System.Drawing.Point(453, 183);
            this.lb_ch2deg.Name = "lb_ch2deg";
            this.lb_ch2deg.Size = new System.Drawing.Size(41, 12);
            this.lb_ch2deg.TabIndex = 32;
            this.lb_ch2deg.Text = "45 °";
            // 
            // lb_ch8deg
            // 
            this.lb_ch8deg.AutoSize = true;
            this.lb_ch8deg.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ch8deg.Location = new System.Drawing.Point(180, 153);
            this.lb_ch8deg.Name = "lb_ch8deg";
            this.lb_ch8deg.Size = new System.Drawing.Size(50, 12);
            this.lb_ch8deg.TabIndex = 33;
            this.lb_ch8deg.Text = "315 °";
            // 
            // pb_ch5
            // 
            this.pb_ch5.BackgroundImage = global::SpeakerSelector.Properties.Resources.spk_off;
            this.pb_ch5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_ch5.Location = new System.Drawing.Point(282, 545);
            this.pb_ch5.Name = "pb_ch5";
            this.pb_ch5.Size = new System.Drawing.Size(75, 75);
            this.pb_ch5.TabIndex = 18;
            this.pb_ch5.TabStop = false;
            this.pb_ch5.Click += new System.EventHandler(this.pb_ch5_Click);
            // 
            // pb_ch7
            // 
            this.pb_ch7.BackgroundImage = global::SpeakerSelector.Properties.Resources.spk_off;
            this.pb_ch7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_ch7.Location = new System.Drawing.Point(10, 273);
            this.pb_ch7.Name = "pb_ch7";
            this.pb_ch7.Size = new System.Drawing.Size(75, 75);
            this.pb_ch7.TabIndex = 17;
            this.pb_ch7.TabStop = false;
            this.pb_ch7.Click += new System.EventHandler(this.pb_ch7_Click);
            // 
            // pb_ch1
            // 
            this.pb_ch1.BackgroundImage = global::SpeakerSelector.Properties.Resources.spk_off;
            this.pb_ch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_ch1.Location = new System.Drawing.Point(283, 1);
            this.pb_ch1.Name = "pb_ch1";
            this.pb_ch1.Size = new System.Drawing.Size(75, 75);
            this.pb_ch1.TabIndex = 16;
            this.pb_ch1.TabStop = false;
            this.pb_ch1.Click += new System.EventHandler(this.pb_ch1_Click);
            // 
            // pb_ch2
            // 
            this.pb_ch2.BackgroundImage = global::SpeakerSelector.Properties.Resources.spk_off;
            this.pb_ch2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_ch2.Location = new System.Drawing.Point(494, 61);
            this.pb_ch2.Name = "pb_ch2";
            this.pb_ch2.Size = new System.Drawing.Size(75, 75);
            this.pb_ch2.TabIndex = 15;
            this.pb_ch2.TabStop = false;
            this.pb_ch2.Click += new System.EventHandler(this.pb_ch2_Click);
            // 
            // pb_ch8
            // 
            this.pb_ch8.BackgroundImage = global::SpeakerSelector.Properties.Resources.spk_off;
            this.pb_ch8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_ch8.Location = new System.Drawing.Point(71, 61);
            this.pb_ch8.Name = "pb_ch8";
            this.pb_ch8.Size = new System.Drawing.Size(75, 75);
            this.pb_ch8.TabIndex = 14;
            this.pb_ch8.TabStop = false;
            this.pb_ch8.Click += new System.EventHandler(this.pb_ch8_Click);
            // 
            // pb_ch4
            // 
            this.pb_ch4.BackgroundImage = global::SpeakerSelector.Properties.Resources.spk_off;
            this.pb_ch4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_ch4.Location = new System.Drawing.Point(494, 483);
            this.pb_ch4.Name = "pb_ch4";
            this.pb_ch4.Size = new System.Drawing.Size(75, 75);
            this.pb_ch4.TabIndex = 13;
            this.pb_ch4.TabStop = false;
            this.pb_ch4.Click += new System.EventHandler(this.pb_ch4_Click);
            // 
            // pb_ch6
            // 
            this.pb_ch6.BackgroundImage = global::SpeakerSelector.Properties.Resources.spk_off;
            this.pb_ch6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_ch6.Location = new System.Drawing.Point(72, 483);
            this.pb_ch6.Name = "pb_ch6";
            this.pb_ch6.Size = new System.Drawing.Size(75, 75);
            this.pb_ch6.TabIndex = 12;
            this.pb_ch6.TabStop = false;
            this.pb_ch6.Click += new System.EventHandler(this.pb_ch6_Click);
            // 
            // pb_ch3
            // 
            this.pb_ch3.BackgroundImage = global::SpeakerSelector.Properties.Resources.spk_off;
            this.pb_ch3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_ch3.Location = new System.Drawing.Point(556, 272);
            this.pb_ch3.Name = "pb_ch3";
            this.pb_ch3.Size = new System.Drawing.Size(75, 75);
            this.pb_ch3.TabIndex = 11;
            this.pb_ch3.TabStop = false;
            this.pb_ch3.Click += new System.EventHandler(this.pb_ch3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::SpeakerSelector.Properties.Resources.logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(759, 544);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(98, 82);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pb_ChairCircle
            // 
            this.pb_ChairCircle.BackgroundImage = global::SpeakerSelector.Properties.Resources.circlechair315d;
            this.pb_ChairCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_ChairCircle.InitialImage = null;
            this.pb_ChairCircle.Location = new System.Drawing.Point(18, 10);
            this.pb_ChairCircle.Name = "pb_ChairCircle";
            this.pb_ChairCircle.Size = new System.Drawing.Size(600, 600);
            this.pb_ChairCircle.TabIndex = 0;
            this.pb_ChairCircle.TabStop = false;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.White;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("휴먼둥근헤드라인", 7F);
            this.btnConnect.Location = new System.Drawing.Point(494, 0);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConnect.Size = new System.Drawing.Size(68, 21);
            this.btnConnect.TabIndex = 34;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(643, -18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 648);
            this.panel1.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 15F);
            this.button1.Location = new System.Drawing.Point(663, 304);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(234, 49);
            this.button1.TabIndex = 42;
            this.button1.Text = "TEST START";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("휴먼둥근헤드라인", 15F);
            this.button3.Location = new System.Drawing.Point(663, 430);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(100, 49);
            this.button3.TabIndex = 44;
            this.button3.Text = "TRUE";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("휴먼둥근헤드라인", 15F);
            this.button4.Location = new System.Drawing.Point(797, 430);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button4.Size = new System.Drawing.Size(100, 49);
            this.button4.TabIndex = 45;
            this.button4.Text = "FALSE";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(655, 372);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 2);
            this.panel3.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("휴먼둥근헤드라인", 15F);
            this.label6.Location = new System.Drawing.Point(668, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 21);
            this.label6.TabIndex = 40;
            this.label6.Text = "Stimuation Check";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(655, 221);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 2);
            this.panel4.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("휴먼모음T", 18F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(834, 545);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 81);
            this.label7.TabIndex = 49;
            this.label7.Text = "Sound \r\nCare \r\nTech.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.groupBox1.Location = new System.Drawing.Point(663, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 57);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stimulation Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("휴먼둥근헤드라인", 15F);
            this.label4.Location = new System.Drawing.Point(31, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 40;
            this.label4.Text = "1s/3s";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.groupBox2.Location = new System.Drawing.Point(783, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 57);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Routine Count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("휴먼둥근헤드라인", 20F);
            this.label5.Location = new System.Drawing.Point(76, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 28);
            this.label5.TabIndex = 41;
            this.label5.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("휴먼둥근헤드라인", 50F);
            this.label2.Location = new System.Drawing.Point(658, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 70);
            this.label2.TabIndex = 37;
            this.label2.Text = "12:15";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("휴먼둥근헤드라인", 10F);
            this.label3.Location = new System.Drawing.Point(730, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 37;
            this.label3.Text = "Test Time";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(916, -18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 648);
            this.panel2.TabIndex = 36;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F);
            this.radioButton1.Location = new System.Drawing.Point(7, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 21);
            this.radioButton1.TabIndex = 52;
            this.radioButton1.Text = "Serial";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton6);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.groupBox3.Location = new System.Drawing.Point(663, 113);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 90);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mode";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F);
            this.radioButton3.Location = new System.Drawing.Point(129, 23);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(95, 21);
            this.radioButton3.TabIndex = 54;
            this.radioButton3.Text = "Manual";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F);
            this.radioButton4.Location = new System.Drawing.Point(7, 58);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(100, 21);
            this.radioButton4.TabIndex = 55;
            this.radioButton4.Text = "Random";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Checked = true;
            this.radioButton6.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F);
            this.radioButton6.Location = new System.Drawing.Point(129, 58);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(91, 21);
            this.radioButton6.TabIndex = 57;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Preset";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("휴먼둥근헤드라인", 15F);
            this.label8.Location = new System.Drawing.Point(924, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 21);
            this.label8.TabIndex = 54;
            this.label8.Text = "Preset #1 ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("휴먼둥근헤드라인", 7F);
            this.button2.Location = new System.Drawing.Point(1154, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 21);
            this.button2.TabIndex = 55;
            this.button2.Text = "custom";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.listView1.Location = new System.Drawing.Point(928, 61);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(294, 556);
            this.listView1.TabIndex = 56;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Speaker On";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Stimultion Time";
            this.columnHeader2.Width = 101;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Stimulation Count";
            this.columnHeader3.Width = 114;
            // 
            // SpeakerSelector
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1234, 629);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnConnect);
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
            this.Controls.Add(this.btnSetUp);
            this.Controls.Add(this.pb_ChairCircle);
            this.Controls.Add(this.pictureBox2);
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
        private System.Windows.Forms.Button btnSetUp;
        private System.Windows.Forms.PictureBox pictureBox2;
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
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

