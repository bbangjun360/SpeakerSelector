﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SpeakerSelector
{
    public partial class Form2 : Form
    {
        SpeakerSelector form1;


        public Form2(SpeakerSelector form)
        {
            InitializeComponent();
            form1 = form;


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.save_rb_8chsel == true)
            {
                rb_8chsel.Checked = true;
                rb_4chsel.Checked = false;
            }
            else
            {
                rb_8chsel.Checked = false;
                rb_4chsel.Checked = true;
            }
            if (Properties.Settings.Default.save_selectedSpeakerAng == 1)
            {
                rb_180deg.Checked = true;
                rb_360deg.Checked = false;
            }
            else
            {
                rb_180deg.Checked = false;
                rb_360deg.Checked = true;
            }
            cb_chairdeg.SelectedIndex = Properties.Settings.Default.save_cb_chairdeg;
            rb_4chsel.Checked = !(Properties.Settings.Default.save_rb_8chsel);
            rb_8chsel.Checked = Properties.Settings.Default.save_rb_8chsel;
            tb_ch1ang.Text = Properties.Settings.Default.save_ch1ang;
            tb_ch2ang.Text = Properties.Settings.Default.save_ch2ang;
            tb_ch3ang.Text = Properties.Settings.Default.save_ch3ang;
            tb_ch4ang.Text = Properties.Settings.Default.save_ch4ang;
            tb_ch5ang.Text = Properties.Settings.Default.save_ch5ang;
            tb_ch6ang.Text = Properties.Settings.Default.save_ch6ang;
            tb_ch7ang.Text = Properties.Settings.Default.save_ch7ang;
            tb_ch8ang.Text = Properties.Settings.Default.save_ch8ang;
            btn_apply.PerformClick();
            if (Properties.Settings.Default.form2Opened == false)
            {
                Properties.Settings.Default.form2Opened = true;
                Properties.Settings.Default.Save();
                

                if (form1.serialPort1.IsOpen)
                {
                    cb_SerialPort.Text = "연결됨";
                }
                else
                {
                    cb_SerialPort.Text = Properties.Settings.Default.save_cb_SerialPort;
                }
            }
            else
            {
                this.Close();
            }
        }
        private void cb_SerialPort_Click(object sender, EventArgs e)
        {
            cb_SerialPort.DataSource = SerialPort.GetPortNames();
        }
        
        private void btn_SerialOpen_Click(object sender, EventArgs e)
        {
            form1.serialPort1.Close();
            if (!form1.serialPort1.IsOpen)                                                             //시리얼포트가 열려 있지 않으면
            {
                form1.gb_mode.Enabled = true;
                form1.btn_testStart.Enabled = true;
                if (form1.rb_manual.Checked == true)
                {
                    form1.gb_stimulationTime.Enabled = false;
                    form1.gb_routineCount.Enabled = false;
                    form1.pb_ch1.Enabled = true;
                    form1.pb_ch2.Enabled = true;
                    form1.pb_ch3.Enabled = true;
                    form1.pb_ch4.Enabled = true;
                    form1.pb_ch5.Enabled = true;
                    form1.pb_ch6.Enabled = true;
                    form1.pb_ch7.Enabled = true;
                    form1.pb_ch8.Enabled = true;
                }
                else
                {
                    form1.gb_stimulationTime.Enabled = true;
                    form1.gb_routineCount.Enabled = true;
                }

                form1.serialPort1.PortName = cb_SerialPort.Text;                                   //콤보박스의 선택된 COM포트명을 시리얼포트명으로 지정
                Properties.Settings.Default.save_cb_SerialPort = cb_SerialPort.Text;
                Properties.Settings.Default.Save();
                form1.serialPort1.BaudRate = 9600;                                                     //baudrate 변경이 필요하면 숫자 변경하기
                form1.serialPort1.DataBits = 8;
                form1.serialPort1.StopBits = StopBits.One;
                form1.serialPort1.Parity = Parity.None;
                form1.serialPort1.DataReceived += new SerialDataReceivedEventHandler(form1.serialPort1_DataReceived); //PCM 시리얼 데이터가 들어오면 "serialPort_PCM_DataReceived"함수로 전송
                form1.serialPort1.Open();                                                              //시리얼포트 열기

                lb_SerialPort.Text = "포트가 열렸습니다";
            }
            else                                                                                    //시리얼포트가 열려 있으면
            {
                lb_SerialPort.Text = "포트가 열려 있습니다.";
            }
            form1.btnConnect.BackColor = System.Drawing.Color.Green;
            form1.btnConnect.Text = "connected";
        }

        private void rb_4chsel_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_4chsel.Checked == true)
            {
                gb_8ch.Visible = false;
                gb_speakerAngle.Visible = true;

            }
            else if (rb_4chsel.Checked == false)
            {
                gb_8ch.Visible = true;
                gb_speakerAngle.Visible = false;

            }
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            form1.gb_mode.Enabled = true;
            form1.gb_stimulationTime.Enabled = true;
            form1.gb_routineCount.Enabled = true;
            form1.btn_testStart.Enabled = true;

            switch (cb_chairdeg.SelectedIndex)
            {
                case 0: form1.pb_ChairCircle.BackgroundImage = Properties.Resources.circlechair0d; break;
                case 1: form1.pb_ChairCircle.BackgroundImage = Properties.Resources.circlechair45d; break;
                case 2: form1.pb_ChairCircle.BackgroundImage = Properties.Resources.circlechair90d; break;
                case 3: form1.pb_ChairCircle.BackgroundImage = Properties.Resources.circlechair135d; break;
                case 4: form1.pb_ChairCircle.BackgroundImage = Properties.Resources.circlechair180d; break;
                case 5: form1.pb_ChairCircle.BackgroundImage = Properties.Resources.circlechair225d; break;
                case 6: form1.pb_ChairCircle.BackgroundImage = Properties.Resources.circlechair270d; break;
                case 7: form1.pb_ChairCircle.BackgroundImage = Properties.Resources.circlechair315d; break;
                default: form1.pb_ChairCircle.BackgroundImage = Properties.Resources.circlechair0d; break;
            }

            if (rb_4chsel.Checked == true)
            {
                gb_8ch.Visible = false;
                form1.pb_ch5.Visible = false;
                form1.lb_ch5.Visible = false;
                form1.pb_ch6.Visible = false;
                form1.lb_ch6.Visible = false;
                form1.pb_ch7.Visible = false;
                form1.lb_ch7.Visible = false;
                form1.pb_ch8.Visible = false;
                form1.lb_ch8.Visible = false;

                form1.cb_listCh5.Visible = false;
                form1.cb_listCh6.Visible = false;
                form1.cb_listCh7.Visible = false;
                form1.cb_listCh8.Visible = false;

                form1.lb_ch1deg.Text = tb_ch1ang.Text;
                form1.lb_ch2deg.Text = tb_ch2ang.Text;
                form1.lb_ch3deg.Text = tb_ch3ang.Text;
                form1.lb_ch4deg.Text = tb_ch4ang.Text;
                form1.lb_ch5deg.Text = "";
                form1.lb_ch6deg.Text = "";
                form1.lb_ch7deg.Text = "";
                form1.lb_ch8deg.Text = "";

                Properties.Settings.Default.save_ch1ang = tb_ch1ang.Text;
                Properties.Settings.Default.save_ch2ang = tb_ch2ang.Text;
                Properties.Settings.Default.save_ch3ang = tb_ch3ang.Text;
                Properties.Settings.Default.save_ch4ang = tb_ch4ang.Text;
                if (rb_180deg.Checked)
                {   
                    form1.pb_ChairCircle.BackgroundImage = Properties.Resources.HalfCircle90deg;
                    Properties.Settings.Default.save_selectedSpeakerAng = 1;

                    form1.pb_ch1.Location = new Point(0, 394);
                    form1.pb_ch2.Location = new Point(103, 113);
                    form1.pb_ch3.Location = new Point(464, 105);
                    form1.pb_ch4.Location = new Point(563, 394);

                    form1.lb_ch1.Location = new Point(0, 394);
                    form1.lb_ch2.Location = new Point(103, 113);
                    form1.lb_ch3.Location = new Point(464, 105);
                    form1.lb_ch4.Location = new Point(563, 394);

                    form1.lb_ch1deg.Location = new Point(98, 415);
                    form1.lb_ch2deg.Location = new Point(218, 240);
                    form1.lb_ch3deg.Location = new Point(420, 259);
                    form1.lb_ch4deg.Location = new Point(501, 436);

                    form1.cb_listCh1.Location = new Point(6, 31);
                    form1.cb_listCh2.Location = new Point(82, 31);
                    form1.cb_listCh3.Location = new Point(158, 31);
                    form1.cb_listCh4.Location = new Point(234, 31);
                }
                else if(rb_360deg.Checked)
                {
                    Properties.Settings.Default.save_selectedSpeakerAng = 2;

                    form1.pb_ch1.Location = new Point(284, 1);
                    form1.pb_ch2.Location = new Point(557, 272);
                    form1.pb_ch3.Location = new Point(283, 545);
                    form1.pb_ch4.Location = new Point(11, 273);

                    form1.lb_ch1.Location = new Point(284, 1);
                    form1.lb_ch2.Location = new Point(557, 272);
                    form1.lb_ch3.Location = new Point(283, 545);
                    form1.lb_ch4.Location = new Point(11, 273);

                    form1.lb_ch1deg.Location = new Point(321, 124);
                    form1.lb_ch2deg.Location = new Point(492, 314);
                    form1.lb_ch3deg.Location = new Point(268, 483);
                    form1.lb_ch4deg.Location = new Point(108, 296);

                    form1.cb_listCh1.Location = new Point(6, 31);
                    form1.cb_listCh2.Location = new Point(82, 31);
                    form1.cb_listCh3.Location = new Point(158, 31);
                    form1.cb_listCh4.Location = new Point(234, 31);
                }
                

            }
            else if (rb_4chsel.Checked == false)
            {
                gb_8ch.Visible = true;
                form1.pb_ch5.Visible = true;
                form1.lb_ch5.Visible = true;
                form1.pb_ch6.Visible = true;
                form1.lb_ch6.Visible = true;
                form1.pb_ch7.Visible = true;
                form1.lb_ch7.Visible = true;
                form1.pb_ch8.Visible = true;
                form1.lb_ch8.Visible = true;

                form1.pb_ch1.Location = new Point(284, 1);
                form1.pb_ch2.Location = new Point(495, 61);
                form1.pb_ch3.Location = new Point(557, 272);
                form1.pb_ch4.Location = new Point(495, 483);
                form1.lb_ch1.Location = new Point(284, 1);
                form1.lb_ch2.Location = new Point(495, 61);
                form1.lb_ch3.Location = new Point(557, 272);
                form1.lb_ch4.Location = new Point(495, 483);

                form1.lb_ch1deg.Text = tb_ch1ang.Text;
                form1.lb_ch2deg.Text = tb_ch2ang.Text;
                form1.lb_ch3deg.Text = tb_ch3ang.Text;
                form1.lb_ch4deg.Text = tb_ch4ang.Text;
                form1.lb_ch5deg.Text = tb_ch5ang.Text;
                form1.lb_ch6deg.Text = tb_ch6ang.Text;
                form1.lb_ch7deg.Text = tb_ch7ang.Text;
                form1.lb_ch8deg.Text = tb_ch8ang.Text;

                form1.lb_ch1deg.Location = new Point(321, 124);
                form1.lb_ch2deg.Location = new Point(453, 183);
                form1.lb_ch3deg.Location = new Point(492, 314);
                form1.lb_ch4deg.Location = new Point(411, 451);

                form1.cb_listCh1.Location = new Point(6, 20);
                form1.cb_listCh2.Location = new Point(82, 20);
                form1.cb_listCh3.Location = new Point(158, 20);
                form1.cb_listCh4.Location = new Point(234, 20);
                form1.cb_listCh5.Visible = true;
                form1.cb_listCh6.Visible = true;
                form1.cb_listCh7.Visible = true;
                form1.cb_listCh8.Visible = true;
            }

            Properties.Settings.Default.save_ch1ang = tb_ch1ang.Text;
            Properties.Settings.Default.save_ch2ang = tb_ch2ang.Text;
            Properties.Settings.Default.save_ch3ang = tb_ch3ang.Text;
            Properties.Settings.Default.save_ch4ang = tb_ch4ang.Text;
            Properties.Settings.Default.save_ch5ang = tb_ch5ang.Text;
            Properties.Settings.Default.save_ch6ang = tb_ch6ang.Text;
            Properties.Settings.Default.save_ch7ang = tb_ch7ang.Text;
            Properties.Settings.Default.save_ch8ang = tb_ch8ang.Text;

            Properties.Settings.Default.save_rb_8chsel = rb_8chsel.Checked;
            Properties.Settings.Default.save_cb_chairdeg = cb_chairdeg.SelectedIndex;

            Properties.Settings.Default.Save();



        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if(form1.serialPort1.IsOpen)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("연결을 먼저 진행해주세요!");
            }
            
        }
    }
}
