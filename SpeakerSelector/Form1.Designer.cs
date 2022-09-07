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
            this.label5 = new System.Windows.Forms.Label();
            this.tb_form1StimulationTimeWait = new System.Windows.Forms.TextBox();
            this.tb_form1StimulationTime = new System.Windows.Forms.TextBox();
            this.lb_stimulationTime = new System.Windows.Forms.Label();
            this.gb_routineCount = new System.Windows.Forms.GroupBox();
            this.tb_form1RoutineCount = new System.Windows.Forms.TextBox();
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
            this.ch_speakerOn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_stimulationTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_stimulationCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.gb_listSpeakerOn = new System.Windows.Forms.GroupBox();
            this.cb_listCh6 = new System.Windows.Forms.CheckBox();
            this.cb_listCh7 = new System.Windows.Forms.CheckBox();
            this.cb_listCh8 = new System.Windows.Forms.CheckBox();
            this.cb_listCh5 = new System.Windows.Forms.CheckBox();
            this.cb_listCh3 = new System.Windows.Forms.CheckBox();
            this.cb_listCh4 = new System.Windows.Forms.CheckBox();
            this.cb_listCh2 = new System.Windows.Forms.CheckBox();
            this.cb_listCh1 = new System.Windows.Forms.CheckBox();
            this.gb_listStimulationTime = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_stimulationTimeWait = new System.Windows.Forms.TextBox();
            this.tb_stimulationTime = new System.Windows.Forms.TextBox();
            this.gb_listStimulationCount = new System.Windows.Forms.GroupBox();
            this.tb_stimulationCount = new System.Windows.Forms.TextBox();
            this.btn_listAdd = new System.Windows.Forms.Button();
            this.btn_listModify = new System.Windows.Forms.Button();
            this.btn_listDelete = new System.Windows.Forms.Button();
            this.btn_csvOpen = new System.Windows.Forms.Button();
            this.btn_csvSave = new System.Windows.Forms.Button();
            this.btn_timerReset = new System.Windows.Forms.Button();
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
            this.gb_listSpeakerOn.SuspendLayout();
            this.gb_listStimulationTime.SuspendLayout();
            this.gb_listStimulationCount.SuspendLayout();
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
            this.btnConnect.BackColor = System.Drawing.Color.Red;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("휴먼둥근헤드라인", 7F);
            this.btnConnect.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConnect.Location = new System.Drawing.Point(480, 0);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConnect.Size = new System.Drawing.Size(82, 21);
            this.btnConnect.TabIndex = 34;
            this.btnConnect.Text = "Disconnect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
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
            this.panel3.Location = new System.Drawing.Point(655, 366);
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
            this.gb_stimulationTime.Controls.Add(this.label5);
            this.gb_stimulationTime.Controls.Add(this.tb_form1StimulationTimeWait);
            this.gb_stimulationTime.Controls.Add(this.tb_form1StimulationTime);
            this.gb_stimulationTime.Controls.Add(this.lb_stimulationTime);
            this.gb_stimulationTime.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.gb_stimulationTime.Location = new System.Drawing.Point(663, 240);
            this.gb_stimulationTime.Name = "gb_stimulationTime";
            this.gb_stimulationTime.Size = new System.Drawing.Size(114, 57);
            this.gb_stimulationTime.TabIndex = 38;
            this.gb_stimulationTime.TabStop = false;
            this.gb_stimulationTime.Text = "Stimulation Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F);
            this.label5.Location = new System.Drawing.Point(49, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "/";
            // 
            // tb_form1StimulationTimeWait
            // 
            this.tb_form1StimulationTimeWait.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.tb_form1StimulationTimeWait.Location = new System.Drawing.Point(71, 27);
            this.tb_form1StimulationTimeWait.Name = "tb_form1StimulationTimeWait";
            this.tb_form1StimulationTimeWait.Size = new System.Drawing.Size(32, 24);
            this.tb_form1StimulationTimeWait.TabIndex = 42;
            this.tb_form1StimulationTimeWait.Text = "2";
            this.tb_form1StimulationTimeWait.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_form1StimulationTime
            // 
            this.tb_form1StimulationTime.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.tb_form1StimulationTime.Location = new System.Drawing.Point(11, 27);
            this.tb_form1StimulationTime.Name = "tb_form1StimulationTime";
            this.tb_form1StimulationTime.Size = new System.Drawing.Size(32, 24);
            this.tb_form1StimulationTime.TabIndex = 41;
            this.tb_form1StimulationTime.Text = "1";
            this.tb_form1StimulationTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_stimulationTime
            // 
            this.lb_stimulationTime.AutoSize = true;
            this.lb_stimulationTime.Font = new System.Drawing.Font("휴먼둥근헤드라인", 15F);
            this.lb_stimulationTime.Location = new System.Drawing.Point(31, 32);
            this.lb_stimulationTime.Name = "lb_stimulationTime";
            this.lb_stimulationTime.Size = new System.Drawing.Size(0, 21);
            this.lb_stimulationTime.TabIndex = 40;
            this.lb_stimulationTime.Visible = false;
            // 
            // gb_routineCount
            // 
            this.gb_routineCount.Controls.Add(this.tb_form1RoutineCount);
            this.gb_routineCount.Controls.Add(this.lb_routineCount);
            this.gb_routineCount.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.gb_routineCount.Location = new System.Drawing.Point(783, 240);
            this.gb_routineCount.Name = "gb_routineCount";
            this.gb_routineCount.Size = new System.Drawing.Size(114, 57);
            this.gb_routineCount.TabIndex = 39;
            this.gb_routineCount.TabStop = false;
            this.gb_routineCount.Text = "Routine Count";
            // 
            // tb_form1RoutineCount
            // 
            this.tb_form1RoutineCount.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.tb_form1RoutineCount.Location = new System.Drawing.Point(41, 27);
            this.tb_form1RoutineCount.Name = "tb_form1RoutineCount";
            this.tb_form1RoutineCount.Size = new System.Drawing.Size(32, 24);
            this.tb_form1RoutineCount.TabIndex = 44;
            this.tb_form1RoutineCount.Text = "2";
            this.tb_form1RoutineCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_routineCount
            // 
            this.lb_routineCount.AutoSize = true;
            this.lb_routineCount.Font = new System.Drawing.Font("휴먼둥근헤드라인", 20F);
            this.lb_routineCount.Location = new System.Drawing.Point(76, 19);
            this.lb_routineCount.Name = "lb_routineCount";
            this.lb_routineCount.Size = new System.Drawing.Size(0, 28);
            this.lb_routineCount.TabIndex = 41;
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
            this.rb_serial.CheckedChanged += new System.EventHandler(this.rb_serial_CheckedChanged);
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
            this.rb_random.CheckedChanged += new System.EventHandler(this.rb_random_CheckedChanged);
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
            this.rb_manual.CheckedChanged += new System.EventHandler(this.rb_manual_CheckedChanged);
            // 
            // lb_preset
            // 
            this.lb_preset.AutoSize = true;
            this.lb_preset.Font = new System.Drawing.Font("휴먼둥근헤드라인", 15F);
            this.lb_preset.Location = new System.Drawing.Point(924, 9);
            this.lb_preset.Name = "lb_preset";
            this.lb_preset.Size = new System.Drawing.Size(90, 21);
            this.lb_preset.TabIndex = 54;
            this.lb_preset.Text = "Preset";
            // 
            // lv_preset
            // 
            this.lv_preset.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_speakerOn,
            this.ch_stimulationTime,
            this.ch_stimulationCount});
            this.lv_preset.FullRowSelect = true;
            this.lv_preset.GridLines = true;
            this.lv_preset.HideSelection = false;
            this.lv_preset.LabelEdit = true;
            this.lv_preset.Location = new System.Drawing.Point(929, 38);
            this.lv_preset.MultiSelect = false;
            this.lv_preset.Name = "lv_preset";
            this.lv_preset.Size = new System.Drawing.Size(293, 407);
            this.lv_preset.TabIndex = 56;
            this.lv_preset.UseCompatibleStateImageBehavior = false;
            this.lv_preset.View = System.Windows.Forms.View.Details;
            this.lv_preset.SelectedIndexChanged += new System.EventHandler(this.lv_preset_SelectedIndexChanged);
            // 
            // ch_speakerOn
            // 
            this.ch_speakerOn.Text = "Speaker On";
            this.ch_speakerOn.Width = 80;
            // 
            // ch_stimulationTime
            // 
            this.ch_stimulationTime.Text = "Stimultion Time";
            this.ch_stimulationTime.Width = 101;
            // 
            // ch_stimulationCount
            // 
            this.ch_stimulationCount.Text = "Stimulation Count";
            this.ch_stimulationCount.Width = 114;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::SpeakerSelector.Properties.Resources.programLogo;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(670, 390);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(220, 220);
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
            // gb_listSpeakerOn
            // 
            this.gb_listSpeakerOn.Controls.Add(this.cb_listCh6);
            this.gb_listSpeakerOn.Controls.Add(this.cb_listCh7);
            this.gb_listSpeakerOn.Controls.Add(this.cb_listCh8);
            this.gb_listSpeakerOn.Controls.Add(this.cb_listCh5);
            this.gb_listSpeakerOn.Controls.Add(this.cb_listCh3);
            this.gb_listSpeakerOn.Controls.Add(this.cb_listCh4);
            this.gb_listSpeakerOn.Controls.Add(this.cb_listCh2);
            this.gb_listSpeakerOn.Controls.Add(this.cb_listCh1);
            this.gb_listSpeakerOn.Location = new System.Drawing.Point(929, 451);
            this.gb_listSpeakerOn.Name = "gb_listSpeakerOn";
            this.gb_listSpeakerOn.Size = new System.Drawing.Size(293, 62);
            this.gb_listSpeakerOn.TabIndex = 59;
            this.gb_listSpeakerOn.TabStop = false;
            this.gb_listSpeakerOn.Text = "Speaker On";
            // 
            // cb_listCh6
            // 
            this.cb_listCh6.AutoSize = true;
            this.cb_listCh6.Location = new System.Drawing.Point(82, 42);
            this.cb_listCh6.Name = "cb_listCh6";
            this.cb_listCh6.Size = new System.Drawing.Size(51, 16);
            this.cb_listCh6.TabIndex = 7;
            this.cb_listCh6.Text = "CH.6";
            this.cb_listCh6.UseVisualStyleBackColor = true;
            // 
            // cb_listCh7
            // 
            this.cb_listCh7.AutoSize = true;
            this.cb_listCh7.Location = new System.Drawing.Point(158, 42);
            this.cb_listCh7.Name = "cb_listCh7";
            this.cb_listCh7.Size = new System.Drawing.Size(51, 16);
            this.cb_listCh7.TabIndex = 6;
            this.cb_listCh7.Text = "CH.7";
            this.cb_listCh7.UseVisualStyleBackColor = true;
            // 
            // cb_listCh8
            // 
            this.cb_listCh8.AutoSize = true;
            this.cb_listCh8.Location = new System.Drawing.Point(234, 42);
            this.cb_listCh8.Name = "cb_listCh8";
            this.cb_listCh8.Size = new System.Drawing.Size(51, 16);
            this.cb_listCh8.TabIndex = 5;
            this.cb_listCh8.Text = "CH.8";
            this.cb_listCh8.UseVisualStyleBackColor = true;
            // 
            // cb_listCh5
            // 
            this.cb_listCh5.AutoSize = true;
            this.cb_listCh5.Location = new System.Drawing.Point(6, 42);
            this.cb_listCh5.Name = "cb_listCh5";
            this.cb_listCh5.Size = new System.Drawing.Size(51, 16);
            this.cb_listCh5.TabIndex = 4;
            this.cb_listCh5.Text = "CH.5";
            this.cb_listCh5.UseVisualStyleBackColor = true;
            // 
            // cb_listCh3
            // 
            this.cb_listCh3.AutoSize = true;
            this.cb_listCh3.Location = new System.Drawing.Point(158, 20);
            this.cb_listCh3.Name = "cb_listCh3";
            this.cb_listCh3.Size = new System.Drawing.Size(51, 16);
            this.cb_listCh3.TabIndex = 3;
            this.cb_listCh3.Text = "CH.3";
            this.cb_listCh3.UseVisualStyleBackColor = true;
            // 
            // cb_listCh4
            // 
            this.cb_listCh4.AutoSize = true;
            this.cb_listCh4.Location = new System.Drawing.Point(234, 20);
            this.cb_listCh4.Name = "cb_listCh4";
            this.cb_listCh4.Size = new System.Drawing.Size(51, 16);
            this.cb_listCh4.TabIndex = 2;
            this.cb_listCh4.Text = "CH.4";
            this.cb_listCh4.UseVisualStyleBackColor = true;
            // 
            // cb_listCh2
            // 
            this.cb_listCh2.AutoSize = true;
            this.cb_listCh2.Location = new System.Drawing.Point(82, 20);
            this.cb_listCh2.Name = "cb_listCh2";
            this.cb_listCh2.Size = new System.Drawing.Size(51, 16);
            this.cb_listCh2.TabIndex = 1;
            this.cb_listCh2.Text = "CH.2";
            this.cb_listCh2.UseVisualStyleBackColor = true;
            // 
            // cb_listCh1
            // 
            this.cb_listCh1.AutoSize = true;
            this.cb_listCh1.Location = new System.Drawing.Point(6, 20);
            this.cb_listCh1.Name = "cb_listCh1";
            this.cb_listCh1.Size = new System.Drawing.Size(51, 16);
            this.cb_listCh1.TabIndex = 0;
            this.cb_listCh1.Text = "CH.1";
            this.cb_listCh1.UseVisualStyleBackColor = true;
            // 
            // gb_listStimulationTime
            // 
            this.gb_listStimulationTime.Controls.Add(this.label4);
            this.gb_listStimulationTime.Controls.Add(this.label3);
            this.gb_listStimulationTime.Controls.Add(this.label2);
            this.gb_listStimulationTime.Controls.Add(this.tb_stimulationTimeWait);
            this.gb_listStimulationTime.Controls.Add(this.tb_stimulationTime);
            this.gb_listStimulationTime.Location = new System.Drawing.Point(930, 519);
            this.gb_listStimulationTime.Name = "gb_listStimulationTime";
            this.gb_listStimulationTime.Size = new System.Drawing.Size(167, 71);
            this.gb_listStimulationTime.TabIndex = 60;
            this.gb_listStimulationTime.TabStop = false;
            this.gb_listStimulationTime.Text = "Stimulation Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 20F);
            this.label4.Location = new System.Drawing.Point(76, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "s";
            // 
            // tb_stimulationTimeWait
            // 
            this.tb_stimulationTimeWait.Font = new System.Drawing.Font("굴림", 20F);
            this.tb_stimulationTimeWait.Location = new System.Drawing.Point(110, 20);
            this.tb_stimulationTimeWait.Name = "tb_stimulationTimeWait";
            this.tb_stimulationTimeWait.Size = new System.Drawing.Size(36, 38);
            this.tb_stimulationTimeWait.TabIndex = 1;
            this.tb_stimulationTimeWait.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_stimulationTime
            // 
            this.tb_stimulationTime.Font = new System.Drawing.Font("굴림", 20F);
            this.tb_stimulationTime.Location = new System.Drawing.Point(22, 20);
            this.tb_stimulationTime.Name = "tb_stimulationTime";
            this.tb_stimulationTime.Size = new System.Drawing.Size(36, 38);
            this.tb_stimulationTime.TabIndex = 0;
            this.tb_stimulationTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gb_listStimulationCount
            // 
            this.gb_listStimulationCount.Controls.Add(this.tb_stimulationCount);
            this.gb_listStimulationCount.Location = new System.Drawing.Point(1102, 519);
            this.gb_listStimulationCount.Name = "gb_listStimulationCount";
            this.gb_listStimulationCount.Size = new System.Drawing.Size(121, 71);
            this.gb_listStimulationCount.TabIndex = 61;
            this.gb_listStimulationCount.TabStop = false;
            this.gb_listStimulationCount.Text = "Stimulation Count";
            // 
            // tb_stimulationCount
            // 
            this.tb_stimulationCount.Font = new System.Drawing.Font("굴림", 20F);
            this.tb_stimulationCount.Location = new System.Drawing.Point(43, 20);
            this.tb_stimulationCount.Name = "tb_stimulationCount";
            this.tb_stimulationCount.Size = new System.Drawing.Size(36, 38);
            this.tb_stimulationCount.TabIndex = 2;
            this.tb_stimulationCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_listAdd
            // 
            this.btn_listAdd.Location = new System.Drawing.Point(931, 596);
            this.btn_listAdd.Name = "btn_listAdd";
            this.btn_listAdd.Size = new System.Drawing.Size(75, 23);
            this.btn_listAdd.TabIndex = 62;
            this.btn_listAdd.Text = "Add";
            this.btn_listAdd.UseVisualStyleBackColor = true;
            this.btn_listAdd.Click += new System.EventHandler(this.btn_listAdd_Click);
            // 
            // btn_listModify
            // 
            this.btn_listModify.Location = new System.Drawing.Point(1039, 596);
            this.btn_listModify.Name = "btn_listModify";
            this.btn_listModify.Size = new System.Drawing.Size(75, 23);
            this.btn_listModify.TabIndex = 63;
            this.btn_listModify.Text = "Modify";
            this.btn_listModify.UseVisualStyleBackColor = true;
            this.btn_listModify.Click += new System.EventHandler(this.btn_listModify_Click);
            // 
            // btn_listDelete
            // 
            this.btn_listDelete.Location = new System.Drawing.Point(1147, 596);
            this.btn_listDelete.Name = "btn_listDelete";
            this.btn_listDelete.Size = new System.Drawing.Size(75, 23);
            this.btn_listDelete.TabIndex = 64;
            this.btn_listDelete.Text = "Delete";
            this.btn_listDelete.UseVisualStyleBackColor = true;
            this.btn_listDelete.Click += new System.EventHandler(this.btn_listDelete_Click);
            // 
            // btn_csvOpen
            // 
            this.btn_csvOpen.Location = new System.Drawing.Point(1066, 9);
            this.btn_csvOpen.Name = "btn_csvOpen";
            this.btn_csvOpen.Size = new System.Drawing.Size(75, 23);
            this.btn_csvOpen.TabIndex = 65;
            this.btn_csvOpen.Text = "OPEN";
            this.btn_csvOpen.UseVisualStyleBackColor = true;
            this.btn_csvOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_csvSave
            // 
            this.btn_csvSave.Location = new System.Drawing.Point(1147, 9);
            this.btn_csvSave.Name = "btn_csvSave";
            this.btn_csvSave.Size = new System.Drawing.Size(75, 23);
            this.btn_csvSave.TabIndex = 66;
            this.btn_csvSave.Text = "SAVE";
            this.btn_csvSave.UseVisualStyleBackColor = true;
            this.btn_csvSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_timerReset
            // 
            this.btn_timerReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timerReset.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.btn_timerReset.Location = new System.Drawing.Point(889, 6);
            this.btn_timerReset.Name = "btn_timerReset";
            this.btn_timerReset.Size = new System.Drawing.Size(21, 21);
            this.btn_timerReset.TabIndex = 67;
            this.btn_timerReset.Text = "R";
            this.btn_timerReset.UseVisualStyleBackColor = true;
            this.btn_timerReset.Click += new System.EventHandler(this.btn_timerReset_Click);
            // 
            // SpeakerSelector
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1234, 629);
            this.Controls.Add(this.btn_timerReset);
            this.Controls.Add(this.btn_csvSave);
            this.Controls.Add(this.btn_csvOpen);
            this.Controls.Add(this.btn_listDelete);
            this.Controls.Add(this.btn_listModify);
            this.Controls.Add(this.btn_listAdd);
            this.Controls.Add(this.gb_listStimulationCount);
            this.Controls.Add(this.gb_listStimulationTime);
            this.Controls.Add(this.gb_listSpeakerOn);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpeakerSelector_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SpeakerSelector_FormClosed);
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
            this.gb_listSpeakerOn.ResumeLayout(false);
            this.gb_listSpeakerOn.PerformLayout();
            this.gb_listStimulationTime.ResumeLayout(false);
            this.gb_listStimulationTime.PerformLayout();
            this.gb_listStimulationCount.ResumeLayout(false);
            this.gb_listStimulationCount.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lb_testtime;
        private System.Windows.Forms.Label lb_testtimeText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rb_serial;
        private System.Windows.Forms.RadioButton rb_preset;
        private System.Windows.Forms.RadioButton rb_random;
        private System.Windows.Forms.RadioButton rb_manual;
        private System.Windows.Forms.Label lb_preset;
        private System.Windows.Forms.ListView lv_preset;
        private System.Windows.Forms.ColumnHeader ch_speakerOn;
        private System.Windows.Forms.ColumnHeader ch_stimulationTime;
        private System.Windows.Forms.ColumnHeader ch_stimulationCount;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Label lb_ch2;
        public System.Windows.Forms.PictureBox pb_ch3;
        public System.Windows.Forms.PictureBox pb_ch1;
        public System.Windows.Forms.PictureBox pb_ch5;
        public System.Windows.Forms.PictureBox pb_ch7;
        public System.Windows.Forms.Label lb_ch1;
        private System.Windows.Forms.GroupBox gb_listSpeakerOn;
        private System.Windows.Forms.GroupBox gb_listStimulationTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_stimulationTimeWait;
        private System.Windows.Forms.TextBox tb_stimulationTime;
        private System.Windows.Forms.GroupBox gb_listStimulationCount;
        private System.Windows.Forms.TextBox tb_stimulationCount;
        private System.Windows.Forms.Button btn_listAdd;
        private System.Windows.Forms.Button btn_listModify;
        private System.Windows.Forms.Button btn_listDelete;
        private System.Windows.Forms.Button btn_csvOpen;
        private System.Windows.Forms.Button btn_csvSave;
        public System.Windows.Forms.Label lb_stimulationTime;
        public System.Windows.Forms.Label lb_routineCount;
        public System.Windows.Forms.Button btnConnect;
        public System.Windows.Forms.CheckBox cb_listCh6;
        public System.Windows.Forms.CheckBox cb_listCh7;
        public System.Windows.Forms.CheckBox cb_listCh8;
        public System.Windows.Forms.CheckBox cb_listCh5;
        public System.Windows.Forms.CheckBox cb_listCh3;
        public System.Windows.Forms.CheckBox cb_listCh4;
        public System.Windows.Forms.CheckBox cb_listCh2;
        public System.Windows.Forms.CheckBox cb_listCh1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_form1StimulationTimeWait;
        private System.Windows.Forms.TextBox tb_form1StimulationTime;
        private System.Windows.Forms.TextBox tb_form1RoutineCount;
        public System.Windows.Forms.Button btn_testStart;
        public System.Windows.Forms.GroupBox gb_stimulationTime;
        public System.Windows.Forms.GroupBox gb_routineCount;
        public System.Windows.Forms.GroupBox gb_mode;
        private System.Windows.Forms.Button btn_timerReset;
    }
}

