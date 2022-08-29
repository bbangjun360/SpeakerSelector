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
            this.btnConnect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_testStart = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gb_stimulationTime = new System.Windows.Forms.GroupBox();
            this.lb_stimulationTime = new System.Windows.Forms.Label();
            this.gb_routineCount = new System.Windows.Forms.GroupBox();
            this.lb_routineCount = new System.Windows.Forms.Label();
            this.lb_testtime = new System.Windows.Forms.Label();
            this.lb_testtimeText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rb_serial = new System.Windows.Forms.RadioButton();
            this.gb_mode = new System.Windows.Forms.GroupBox();
            this.rb_preset = new System.Windows.Forms.RadioButton();
            this.rb_random = new System.Windows.Forms.RadioButton();
            this.rb_manual = new System.Windows.Forms.RadioButton();
            this.lb_preset = new System.Windows.Forms.Label();
            this.lv_preset = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pb_ch5 = new System.Windows.Forms.PictureBox();
            this.pb_ch7 = new System.Windows.Forms.PictureBox();
            this.pb_ch1 = new System.Windows.Forms.PictureBox();
            this.pb_ch2 = new System.Windows.Forms.PictureBox();
            this.pb_ch8 = new System.Windows.Forms.PictureBox();
            this.pb_ch4 = new System.Windows.Forms.PictureBox();
            this.pb_ch6 = new System.Windows.Forms.PictureBox();
            this.pb_ch3 = new System.Windows.Forms.PictureBox();
            this.pb_ChairCircle = new System.Windows.Forms.PictureBox();
            this.lb_ch2 = new System.Windows.Forms.Label();
            this.gb_stimulationTime.SuspendLayout();
            this.gb_routineCount.SuspendLayout();
            this.gb_mode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ch5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ch7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ch1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ch2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ch8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ch4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ch6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ch3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ChairCircle)).BeginInit();
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
            // btn_testStart
            // 
            this.btn_testStart.BackColor = System.Drawing.Color.White;
            this.btn_testStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_testStart.Font = new System.Drawing.Font("휴먼둥근헤드라인", 15F);
            this.btn_testStart.Location = new System.Drawing.Point(663, 304);
            this.btn_testStart.Name = "btn_testStart";
            this.btn_testStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_testStart.Size = new System.Drawing.Size(234, 49);
            this.btn_testStart.TabIndex = 42;
            this.btn_testStart.Text = "TEST START";
            this.btn_testStart.UseVisualStyleBackColor = false;
            this.btn_testStart.Click += new System.EventHandler(this.btn_testStart_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(655, 364);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 2);
            this.panel3.TabIndex = 46;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(655, 221);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 2);
            this.panel4.TabIndex = 47;
            // 
            // gb_stimulationTime
            // 
            this.gb_stimulationTime.Controls.Add(this.lb_stimulationTime);
            this.gb_stimulationTime.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.gb_stimulationTime.Location = new System.Drawing.Point(663, 240);
            this.gb_stimulationTime.Name = "gb_stimulationTime";
            this.gb_stimulationTime.Size = new System.Drawing.Size(114, 57);
            this.gb_stimulationTime.TabIndex = 38;
            this.gb_stimulationTime.TabStop = false;
            this.gb_stimulationTime.Text = "Stimulation Time";
            // 
            // lb_stimulationTime
            // 
            this.lb_stimulationTime.AutoSize = true;
            this.lb_stimulationTime.Font = new System.Drawing.Font("휴먼둥근헤드라인", 15F);
            this.lb_stimulationTime.Location = new System.Drawing.Point(31, 32);
            this.lb_stimulationTime.Name = "lb_stimulationTime";
            this.lb_stimulationTime.Size = new System.Drawing.Size(77, 21);
            this.lb_stimulationTime.TabIndex = 40;
            this.lb_stimulationTime.Text = "1s/3s";
            // 
            // gb_routineCount
            // 
            this.gb_routineCount.Controls.Add(this.lb_routineCount);
            this.gb_routineCount.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.gb_routineCount.Location = new System.Drawing.Point(783, 240);
            this.gb_routineCount.Name = "gb_routineCount";
            this.gb_routineCount.Size = new System.Drawing.Size(114, 57);
            this.gb_routineCount.TabIndex = 39;
            this.gb_routineCount.TabStop = false;
            this.gb_routineCount.Text = "Routine Count";
            // 
            // lb_routineCount
            // 
            this.lb_routineCount.AutoSize = true;
            this.lb_routineCount.Font = new System.Drawing.Font("휴먼둥근헤드라인", 20F);
            this.lb_routineCount.Location = new System.Drawing.Point(76, 19);
            this.lb_routineCount.Name = "lb_routineCount";
            this.lb_routineCount.Size = new System.Drawing.Size(31, 28);
            this.lb_routineCount.TabIndex = 41;
            this.lb_routineCount.Text = "3";
            // 
            // lb_testtime
            // 
            this.lb_testtime.AutoSize = true;
            this.lb_testtime.Font = new System.Drawing.Font("휴먼둥근헤드라인", 50F);
            this.lb_testtime.Location = new System.Drawing.Point(658, 26);
            this.lb_testtime.Name = "lb_testtime";
            this.lb_testtime.Size = new System.Drawing.Size(246, 70);
            this.lb_testtime.TabIndex = 37;
            this.lb_testtime.Text = "00:00";
            // 
            // lb_testtimeText
            // 
            this.lb_testtimeText.AutoSize = true;
            this.lb_testtimeText.Font = new System.Drawing.Font("휴먼둥근헤드라인", 10F);
            this.lb_testtimeText.Location = new System.Drawing.Point(730, 9);
            this.lb_testtimeText.Name = "lb_testtimeText";
            this.lb_testtimeText.Size = new System.Drawing.Size(92, 15);
            this.lb_testtimeText.TabIndex = 37;
            this.lb_testtimeText.Text = "Test Time";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(916, -18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 648);
            this.panel2.TabIndex = 36;
            // 
            // rb_serial
            // 
            this.rb_serial.AutoSize = true;
            this.rb_serial.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F);
            this.rb_serial.Location = new System.Drawing.Point(7, 23);
            this.rb_serial.Name = "rb_serial";
            this.rb_serial.Size = new System.Drawing.Size(83, 21);
            this.rb_serial.TabIndex = 52;
            this.rb_serial.Text = "Serial";
            this.rb_serial.UseVisualStyleBackColor = true;
            // 
            // gb_mode
            // 
            this.gb_mode.Controls.Add(this.rb_preset);
            this.gb_mode.Controls.Add(this.rb_random);
            this.gb_mode.Controls.Add(this.rb_manual);
            this.gb_mode.Controls.Add(this.rb_serial);
            this.gb_mode.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.gb_mode.Location = new System.Drawing.Point(663, 113);
            this.gb_mode.Name = "gb_mode";
            this.gb_mode.Size = new System.Drawing.Size(234, 90);
            this.gb_mode.TabIndex = 53;
            this.gb_mode.TabStop = false;
            this.gb_mode.Text = "Mode";
            // 
            // rb_preset
            // 
            this.rb_preset.AutoSize = true;
            this.rb_preset.Checked = true;
            this.rb_preset.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F);
            this.rb_preset.Location = new System.Drawing.Point(129, 58);
            this.rb_preset.Name = "rb_preset";
            this.rb_preset.Size = new System.Drawing.Size(91, 21);
            this.rb_preset.TabIndex = 57;
            this.rb_preset.TabStop = true;
            this.rb_preset.Text = "Preset";
            this.rb_preset.UseVisualStyleBackColor = true;
            this.rb_preset.CheckedChanged += new System.EventHandler(this.rb_preset_CheckedChanged);
            // 
            // rb_random
            // 
            this.rb_random.AutoSize = true;
            this.rb_random.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F);
            this.rb_random.Location = new System.Drawing.Point(7, 58);
            this.rb_random.Name = "rb_random";
            this.rb_random.Size = new System.Drawing.Size(100, 21);
            this.rb_random.TabIndex = 55;
            this.rb_random.Text = "Random";
            this.rb_random.UseVisualStyleBackColor = true;
            // 
            // rb_manual
            // 
            this.rb_manual.AutoSize = true;
            this.rb_manual.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F);
            this.rb_manual.Location = new System.Drawing.Point(129, 23);
            this.rb_manual.Name = "rb_manual";
            this.rb_manual.Size = new System.Drawing.Size(95, 21);
            this.rb_manual.TabIndex = 54;
            this.rb_manual.Text = "Manual";
            this.rb_manual.UseVisualStyleBackColor = true;
            // 
            // lb_preset
            // 
            this.lb_preset.AutoSize = true;
            this.lb_preset.Font = new System.Drawing.Font("휴먼둥근헤드라인", 15F);
            this.lb_preset.Location = new System.Drawing.Point(924, 26);
            this.lb_preset.Name = "lb_preset";
            this.lb_preset.Size = new System.Drawing.Size(90, 21);
            this.lb_preset.TabIndex = 54;
            this.lb_preset.Text = "Preset";
            // 
            // lv_preset
            // 
            this.lv_preset.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv_preset.HideSelection = false;
            this.lv_preset.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.lv_preset.Location = new System.Drawing.Point(929, 61);
            this.lv_preset.Name = "lv_preset";
            this.lv_preset.Size = new System.Drawing.Size(294, 556);
            this.lv_preset.TabIndex = 56;
            this.lv_preset.UseCompatibleStateImageBehavior = false;
            this.lv_preset.View = System.Windows.Forms.View.Details;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "preset 1",
            "preset 2",
            "preset 3",
            "preset 4",
            "add"});
            this.comboBox1.Location = new System.Drawing.Point(1101, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 58;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::SpeakerSelector.Properties.Resources.programLogo;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(705, 467);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(150, 150);
            this.panel5.TabIndex = 57;
            // 
            // pb_ch5
            // 
            this.pb_ch5.BackgroundImage = global::SpeakerSelector.Properties.Resources.spk_off;
            this.pb_ch5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_ch5.Location = new System.Drawing.Point(283, 545);
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
            this.pb_ch7.Location = new System.Drawing.Point(11, 273);
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
            this.pb_ch1.Location = new System.Drawing.Point(284, 1);
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
            this.pb_ch2.Location = new System.Drawing.Point(495, 61);
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
            this.pb_ch8.Location = new System.Drawing.Point(72, 61);
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
            this.pb_ch4.Location = new System.Drawing.Point(495, 483);
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
            this.pb_ch6.Location = new System.Drawing.Point(73, 483);
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
            this.pb_ch3.Location = new System.Drawing.Point(557, 272);
            this.pb_ch3.Name = "pb_ch3";
            this.pb_ch3.Size = new System.Drawing.Size(75, 75);
            this.pb_ch3.TabIndex = 11;
            this.pb_ch3.TabStop = false;
            this.pb_ch3.Click += new System.EventHandler(this.pb_ch3_Click);
            // 
            // pb_ChairCircle
            // 
            this.pb_ChairCircle.BackgroundImage = global::SpeakerSelector.Properties.Resources.circlechair315d;
            this.pb_ChairCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_ChairCircle.InitialImage = null;
            this.pb_ChairCircle.Location = new System.Drawing.Point(19, 10);
            this.pb_ChairCircle.Name = "pb_ChairCircle";
            this.pb_ChairCircle.Size = new System.Drawing.Size(600, 600);
            this.pb_ChairCircle.TabIndex = 0;
            this.pb_ChairCircle.TabStop = false;
            // 
            // lb_ch2
            // 
            this.lb_ch2.AutoSize = true;
            this.lb_ch2.Font = new System.Drawing.Font("휴먼둥근헤드라인", 6F);
            this.lb_ch2.Location = new System.Drawing.Point(493, 61);
            this.lb_ch2.Name = "lb_ch2";
            this.lb_ch2.Size = new System.Drawing.Size(26, 8);
            this.lb_ch2.TabIndex = 20;
            this.lb_ch2.Text = "CH.2";
            // 
            // SpeakerSelector
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1234, 629);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lv_preset);
            this.Controls.Add(this.lb_preset);
            this.Controls.Add(this.gb_mode);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lb_testtimeText);
            this.Controls.Add(this.gb_routineCount);
            this.Controls.Add(this.lb_testtime);
            this.Controls.Add(this.gb_stimulationTime);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_testStart);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpeakerSelector";
            this.Text = "SoundCareTech.";
            this.Load += new System.EventHandler(this.SpeakerSelector_Load);
            this.gb_stimulationTime.ResumeLayout(false);
            this.gb_stimulationTime.PerformLayout();
            this.gb_routineCount.ResumeLayout(false);
            this.gb_routineCount.PerformLayout();
            this.gb_mode.ResumeLayout(false);
            this.gb_mode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ch5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ch7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ch1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ch2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ch8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ch4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ch6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ch3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ChairCircle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSetUp;
        private System.Windows.Forms.Label label1;
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
        public System.Windows.Forms.Label lb_ch3;
        public System.Windows.Forms.Label lb_ch4;
        public System.Windows.Forms.Label lb_ch5;
        public System.Windows.Forms.Label lb_ch6;
        public System.Windows.Forms.Label lb_ch7;
        public System.Windows.Forms.Label lb_ch8;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_testStart;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox gb_stimulationTime;
        private System.Windows.Forms.Label lb_stimulationTime;
        private System.Windows.Forms.GroupBox gb_routineCount;
        private System.Windows.Forms.Label lb_routineCount;
        private System.Windows.Forms.Label lb_testtime;
        private System.Windows.Forms.Label lb_testtimeText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rb_serial;
        private System.Windows.Forms.GroupBox gb_mode;
        private System.Windows.Forms.RadioButton rb_preset;
        private System.Windows.Forms.RadioButton rb_random;
        private System.Windows.Forms.RadioButton rb_manual;
        private System.Windows.Forms.Label lb_preset;
        private System.Windows.Forms.ListView lv_preset;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label lb_ch2;
        public System.Windows.Forms.PictureBox pb_ch3;
        public System.Windows.Forms.PictureBox pb_ch1;
        public System.Windows.Forms.PictureBox pb_ch5;
        public System.Windows.Forms.PictureBox pb_ch7;
        public System.Windows.Forms.Label lb_ch1;
    }
}

