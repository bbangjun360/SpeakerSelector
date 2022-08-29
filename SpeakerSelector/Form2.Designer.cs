namespace SpeakerSelector
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_apply = new System.Windows.Forms.Button();
            this.rb_4chsel = new System.Windows.Forms.RadioButton();
            this.rb_8chsel = new System.Windows.Forms.RadioButton();
            this.cg_4ch = new System.Windows.Forms.GroupBox();
            this.tb_ch2ang = new System.Windows.Forms.TextBox();
            this.lb_ch2 = new System.Windows.Forms.Label();
            this.tb_ch3ang = new System.Windows.Forms.TextBox();
            this.lb_ch3 = new System.Windows.Forms.Label();
            this.tb_ch4ang = new System.Windows.Forms.TextBox();
            this.lb_ch4 = new System.Windows.Forms.Label();
            this.tb_ch1ang = new System.Windows.Forms.TextBox();
            this.lb_ch1 = new System.Windows.Forms.Label();
            this.gb_8ch = new System.Windows.Forms.GroupBox();
            this.tb_ch6ang = new System.Windows.Forms.TextBox();
            this.lb_ch6 = new System.Windows.Forms.Label();
            this.tb_ch7ang = new System.Windows.Forms.TextBox();
            this.lb_ch7 = new System.Windows.Forms.Label();
            this.tb_ch8ang = new System.Windows.Forms.TextBox();
            this.lb_ch8 = new System.Windows.Forms.Label();
            this.tb_ch5ang = new System.Windows.Forms.TextBox();
            this.lb_ch5 = new System.Windows.Forms.Label();
            this.gb_Serial = new System.Windows.Forms.GroupBox();
            this.lb_SerialPort = new System.Windows.Forms.Label();
            this.btn_SerialOpen = new System.Windows.Forms.Button();
            this.cb_SerialPort = new System.Windows.Forms.ComboBox();
            this.gb_chairlocation = new System.Windows.Forms.GroupBox();
            this.cb_chairdeg = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cg_4ch.SuspendLayout();
            this.gb_8ch.SuspendLayout();
            this.gb_Serial.SuspendLayout();
            this.gb_chairlocation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.White;
            this.btn_close.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_close.Location = new System.Drawing.Point(158, 379);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(146, 35);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "닫기";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_apply
            // 
            this.btn_apply.BackColor = System.Drawing.Color.White;
            this.btn_apply.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_apply.Location = new System.Drawing.Point(12, 370);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(146, 35);
            this.btn_apply.TabIndex = 1;
            this.btn_apply.Text = "적용";
            this.btn_apply.UseVisualStyleBackColor = false;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // rb_4chsel
            // 
            this.rb_4chsel.AutoSize = true;
            this.rb_4chsel.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9.75F);
            this.rb_4chsel.Location = new System.Drawing.Point(6, 23);
            this.rb_4chsel.Name = "rb_4chsel";
            this.rb_4chsel.Size = new System.Drawing.Size(60, 17);
            this.rb_4chsel.TabIndex = 2;
            this.rb_4chsel.Text = "4채널";
            this.rb_4chsel.UseVisualStyleBackColor = true;
            this.rb_4chsel.CheckedChanged += new System.EventHandler(this.rb_4chsel_CheckedChanged);
            // 
            // rb_8chsel
            // 
            this.rb_8chsel.AutoSize = true;
            this.rb_8chsel.Checked = true;
            this.rb_8chsel.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rb_8chsel.Location = new System.Drawing.Point(72, 23);
            this.rb_8chsel.Name = "rb_8chsel";
            this.rb_8chsel.Size = new System.Drawing.Size(60, 17);
            this.rb_8chsel.TabIndex = 4;
            this.rb_8chsel.TabStop = true;
            this.rb_8chsel.Text = "8채널";
            this.rb_8chsel.UseVisualStyleBackColor = true;
            // 
            // cg_4ch
            // 
            this.cg_4ch.Controls.Add(this.tb_ch2ang);
            this.cg_4ch.Controls.Add(this.lb_ch2);
            this.cg_4ch.Controls.Add(this.tb_ch3ang);
            this.cg_4ch.Controls.Add(this.lb_ch3);
            this.cg_4ch.Controls.Add(this.tb_ch4ang);
            this.cg_4ch.Controls.Add(this.lb_ch4);
            this.cg_4ch.Controls.Add(this.tb_ch1ang);
            this.cg_4ch.Controls.Add(this.lb_ch1);
            this.cg_4ch.Controls.Add(this.rb_4chsel);
            this.cg_4ch.Controls.Add(this.rb_8chsel);
            this.cg_4ch.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cg_4ch.Location = new System.Drawing.Point(164, 12);
            this.cg_4ch.Name = "cg_4ch";
            this.cg_4ch.Size = new System.Drawing.Size(146, 158);
            this.cg_4ch.TabIndex = 5;
            this.cg_4ch.TabStop = false;
            this.cg_4ch.Text = "스피커 위치";
            // 
            // tb_ch2ang
            // 
            this.tb_ch2ang.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_ch2ang.Location = new System.Drawing.Point(53, 74);
            this.tb_ch2ang.Name = "tb_ch2ang";
            this.tb_ch2ang.Size = new System.Drawing.Size(63, 22);
            this.tb_ch2ang.TabIndex = 18;
            this.tb_ch2ang.Text = "0";
            // 
            // lb_ch2
            // 
            this.lb_ch2.AutoSize = true;
            this.lb_ch2.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ch2.Location = new System.Drawing.Point(6, 83);
            this.lb_ch2.Name = "lb_ch2";
            this.lb_ch2.Size = new System.Drawing.Size(41, 13);
            this.lb_ch2.TabIndex = 17;
            this.lb_ch2.Text = "CH2.";
            // 
            // tb_ch3ang
            // 
            this.tb_ch3ang.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_ch3ang.Location = new System.Drawing.Point(53, 102);
            this.tb_ch3ang.Name = "tb_ch3ang";
            this.tb_ch3ang.Size = new System.Drawing.Size(63, 22);
            this.tb_ch3ang.TabIndex = 12;
            this.tb_ch3ang.Text = "0";
            // 
            // lb_ch3
            // 
            this.lb_ch3.AutoSize = true;
            this.lb_ch3.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ch3.Location = new System.Drawing.Point(6, 111);
            this.lb_ch3.Name = "lb_ch3";
            this.lb_ch3.Size = new System.Drawing.Size(41, 13);
            this.lb_ch3.TabIndex = 11;
            this.lb_ch3.Text = "CH3.";
            // 
            // tb_ch4ang
            // 
            this.tb_ch4ang.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_ch4ang.Location = new System.Drawing.Point(53, 130);
            this.tb_ch4ang.Name = "tb_ch4ang";
            this.tb_ch4ang.Size = new System.Drawing.Size(63, 22);
            this.tb_ch4ang.TabIndex = 10;
            this.tb_ch4ang.Text = "0";
            // 
            // lb_ch4
            // 
            this.lb_ch4.AutoSize = true;
            this.lb_ch4.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ch4.Location = new System.Drawing.Point(6, 139);
            this.lb_ch4.Name = "lb_ch4";
            this.lb_ch4.Size = new System.Drawing.Size(41, 13);
            this.lb_ch4.TabIndex = 9;
            this.lb_ch4.Text = "CH4.";
            this.lb_ch4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_ch1ang
            // 
            this.tb_ch1ang.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_ch1ang.Location = new System.Drawing.Point(53, 46);
            this.tb_ch1ang.Name = "tb_ch1ang";
            this.tb_ch1ang.Size = new System.Drawing.Size(63, 22);
            this.tb_ch1ang.TabIndex = 8;
            this.tb_ch1ang.Text = "0";
            // 
            // lb_ch1
            // 
            this.lb_ch1.AutoSize = true;
            this.lb_ch1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ch1.Location = new System.Drawing.Point(6, 55);
            this.lb_ch1.Name = "lb_ch1";
            this.lb_ch1.Size = new System.Drawing.Size(41, 13);
            this.lb_ch1.TabIndex = 7;
            this.lb_ch1.Text = "CH1.";
            // 
            // gb_8ch
            // 
            this.gb_8ch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gb_8ch.Controls.Add(this.tb_ch6ang);
            this.gb_8ch.Controls.Add(this.lb_ch6);
            this.gb_8ch.Controls.Add(this.tb_ch7ang);
            this.gb_8ch.Controls.Add(this.lb_ch7);
            this.gb_8ch.Controls.Add(this.tb_ch8ang);
            this.gb_8ch.Controls.Add(this.lb_ch8);
            this.gb_8ch.Controls.Add(this.tb_ch5ang);
            this.gb_8ch.Controls.Add(this.lb_ch5);
            this.gb_8ch.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gb_8ch.Location = new System.Drawing.Point(164, 170);
            this.gb_8ch.Name = "gb_8ch";
            this.gb_8ch.Size = new System.Drawing.Size(146, 134);
            this.gb_8ch.TabIndex = 19;
            this.gb_8ch.TabStop = false;
            // 
            // tb_ch6ang
            // 
            this.tb_ch6ang.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_ch6ang.Location = new System.Drawing.Point(53, 48);
            this.tb_ch6ang.Name = "tb_ch6ang";
            this.tb_ch6ang.Size = new System.Drawing.Size(63, 22);
            this.tb_ch6ang.TabIndex = 18;
            this.tb_ch6ang.Text = "0";
            // 
            // lb_ch6
            // 
            this.lb_ch6.AutoSize = true;
            this.lb_ch6.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ch6.Location = new System.Drawing.Point(6, 57);
            this.lb_ch6.Name = "lb_ch6";
            this.lb_ch6.Size = new System.Drawing.Size(41, 13);
            this.lb_ch6.TabIndex = 17;
            this.lb_ch6.Text = "CH6.";
            // 
            // tb_ch7ang
            // 
            this.tb_ch7ang.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_ch7ang.Location = new System.Drawing.Point(53, 76);
            this.tb_ch7ang.Name = "tb_ch7ang";
            this.tb_ch7ang.Size = new System.Drawing.Size(63, 22);
            this.tb_ch7ang.TabIndex = 12;
            this.tb_ch7ang.Text = "0";
            // 
            // lb_ch7
            // 
            this.lb_ch7.AutoSize = true;
            this.lb_ch7.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ch7.Location = new System.Drawing.Point(6, 85);
            this.lb_ch7.Name = "lb_ch7";
            this.lb_ch7.Size = new System.Drawing.Size(41, 13);
            this.lb_ch7.TabIndex = 11;
            this.lb_ch7.Text = "CH7.";
            // 
            // tb_ch8ang
            // 
            this.tb_ch8ang.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_ch8ang.Location = new System.Drawing.Point(53, 104);
            this.tb_ch8ang.Name = "tb_ch8ang";
            this.tb_ch8ang.Size = new System.Drawing.Size(63, 22);
            this.tb_ch8ang.TabIndex = 10;
            this.tb_ch8ang.Text = "0";
            // 
            // lb_ch8
            // 
            this.lb_ch8.AutoSize = true;
            this.lb_ch8.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ch8.Location = new System.Drawing.Point(6, 113);
            this.lb_ch8.Name = "lb_ch8";
            this.lb_ch8.Size = new System.Drawing.Size(41, 13);
            this.lb_ch8.TabIndex = 9;
            this.lb_ch8.Text = "CH8.";
            this.lb_ch8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_ch5ang
            // 
            this.tb_ch5ang.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_ch5ang.Location = new System.Drawing.Point(53, 20);
            this.tb_ch5ang.Name = "tb_ch5ang";
            this.tb_ch5ang.Size = new System.Drawing.Size(63, 22);
            this.tb_ch5ang.TabIndex = 8;
            this.tb_ch5ang.Text = "0";
            // 
            // lb_ch5
            // 
            this.lb_ch5.AutoSize = true;
            this.lb_ch5.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ch5.Location = new System.Drawing.Point(6, 29);
            this.lb_ch5.Name = "lb_ch5";
            this.lb_ch5.Size = new System.Drawing.Size(41, 13);
            this.lb_ch5.TabIndex = 7;
            this.lb_ch5.Text = "CH5.";
            // 
            // gb_Serial
            // 
            this.gb_Serial.Controls.Add(this.lb_SerialPort);
            this.gb_Serial.Controls.Add(this.btn_SerialOpen);
            this.gb_Serial.Controls.Add(this.cb_SerialPort);
            this.gb_Serial.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.gb_Serial.Location = new System.Drawing.Point(12, 12);
            this.gb_Serial.Name = "gb_Serial";
            this.gb_Serial.Size = new System.Drawing.Size(146, 124);
            this.gb_Serial.TabIndex = 20;
            this.gb_Serial.TabStop = false;
            this.gb_Serial.Text = "장치 연결";
            // 
            // lb_SerialPort
            // 
            this.lb_SerialPort.AutoSize = true;
            this.lb_SerialPort.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.lb_SerialPort.Location = new System.Drawing.Point(24, 68);
            this.lb_SerialPort.Name = "lb_SerialPort";
            this.lb_SerialPort.Size = new System.Drawing.Size(119, 12);
            this.lb_SerialPort.TabIndex = 23;
            this.lb_SerialPort.Text = "포트를 선택해주세요";
            // 
            // btn_SerialOpen
            // 
            this.btn_SerialOpen.BackColor = System.Drawing.Color.White;
            this.btn_SerialOpen.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_SerialOpen.Location = new System.Drawing.Point(0, 83);
            this.btn_SerialOpen.Name = "btn_SerialOpen";
            this.btn_SerialOpen.Size = new System.Drawing.Size(140, 35);
            this.btn_SerialOpen.TabIndex = 22;
            this.btn_SerialOpen.Text = "연결";
            this.btn_SerialOpen.UseVisualStyleBackColor = false;
            this.btn_SerialOpen.Click += new System.EventHandler(this.btn_SerialOpen_Click);
            // 
            // cb_SerialPort
            // 
            this.cb_SerialPort.FormattingEnabled = true;
            this.cb_SerialPort.Location = new System.Drawing.Point(6, 23);
            this.cb_SerialPort.Name = "cb_SerialPort";
            this.cb_SerialPort.Size = new System.Drawing.Size(134, 24);
            this.cb_SerialPort.TabIndex = 21;
            this.cb_SerialPort.Click += new System.EventHandler(this.cb_SerialPort_Click);
            // 
            // gb_chairlocation
            // 
            this.gb_chairlocation.Controls.Add(this.cb_chairdeg);
            this.gb_chairlocation.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.gb_chairlocation.Location = new System.Drawing.Point(12, 142);
            this.gb_chairlocation.Name = "gb_chairlocation";
            this.gb_chairlocation.Size = new System.Drawing.Size(146, 55);
            this.gb_chairlocation.TabIndex = 24;
            this.gb_chairlocation.TabStop = false;
            this.gb_chairlocation.Text = "의자 각도";
            // 
            // cb_chairdeg
            // 
            this.cb_chairdeg.FormattingEnabled = true;
            this.cb_chairdeg.Items.AddRange(new object[] {
            "0도",
            "45도",
            "90도",
            "135도",
            "180도",
            "225도",
            "275도",
            "315도"});
            this.cb_chairdeg.Location = new System.Drawing.Point(6, 23);
            this.cb_chairdeg.Name = "cb_chairdeg";
            this.cb_chairdeg.Size = new System.Drawing.Size(134, 24);
            this.cb_chairdeg.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 21);
            this.textBox1.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.groupBox1.Location = new System.Drawing.Point(12, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 55);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stimulation Time";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(52, 21);
            this.textBox2.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F);
            this.label1.Location = new System.Drawing.Point(66, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "/";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.groupBox2.Location = new System.Drawing.Point(18, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 55);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Routine Count";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 28);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(134, 21);
            this.textBox4.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(18, 325);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 2);
            this.panel1.TabIndex = 28;
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(323, 574);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_chairlocation);
            this.Controls.Add(this.gb_Serial);
            this.Controls.Add(this.gb_8ch);
            this.Controls.Add(this.cg_4ch);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.btn_close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "SoundCareTech. Setting";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.cg_4ch.ResumeLayout(false);
            this.cg_4ch.PerformLayout();
            this.gb_8ch.ResumeLayout(false);
            this.gb_8ch.PerformLayout();
            this.gb_Serial.ResumeLayout(false);
            this.gb_Serial.PerformLayout();
            this.gb_chairlocation.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.RadioButton rb_4chsel;
        private System.Windows.Forms.RadioButton rb_8chsel;
        private System.Windows.Forms.GroupBox cg_4ch;
        private System.Windows.Forms.Label lb_ch1;
        private System.Windows.Forms.TextBox tb_ch2ang;
        private System.Windows.Forms.Label lb_ch2;
        private System.Windows.Forms.TextBox tb_ch3ang;
        private System.Windows.Forms.Label lb_ch3;
        private System.Windows.Forms.TextBox tb_ch4ang;
        private System.Windows.Forms.Label lb_ch4;
        private System.Windows.Forms.TextBox tb_ch1ang;
        private System.Windows.Forms.GroupBox gb_8ch;
        private System.Windows.Forms.TextBox tb_ch6ang;
        private System.Windows.Forms.Label lb_ch6;
        private System.Windows.Forms.TextBox tb_ch7ang;
        private System.Windows.Forms.Label lb_ch7;
        private System.Windows.Forms.TextBox tb_ch8ang;
        private System.Windows.Forms.Label lb_ch8;
        private System.Windows.Forms.TextBox tb_ch5ang;
        private System.Windows.Forms.Label lb_ch5;
        private System.Windows.Forms.GroupBox gb_Serial;
        private System.Windows.Forms.Label lb_SerialPort;
        private System.Windows.Forms.Button btn_SerialOpen;
        private System.Windows.Forms.ComboBox cb_SerialPort;
        private System.Windows.Forms.GroupBox gb_chairlocation;
        private System.Windows.Forms.ComboBox cb_chairdeg;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel1;
    }
}