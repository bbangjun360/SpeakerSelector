using System;
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
            tb_ch1ang.Text = form1.lb_ch1deg.Text;
            tb_ch2ang.Text = form1.lb_ch2deg.Text;
            tb_ch3ang.Text = form1.lb_ch3deg.Text;
            tb_ch4ang.Text = form1.lb_ch4deg.Text;
            tb_ch5ang.Text = form1.lb_ch5deg.Text;
            tb_ch6ang.Text = form1.lb_ch6deg.Text;
            tb_ch7ang.Text = form1.lb_ch7deg.Text;
            tb_ch8ang.Text = form1.lb_ch8deg.Text;
            
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (form1.serialPort1.IsOpen)
            {
                cb_SerialPort.Text = "연결됨";
            }
            else
            {
                cb_SerialPort.Text = "해제됨";
            }
        }
        private void cb_SerialPort_Click(object sender, EventArgs e)
        {
            cb_SerialPort.DataSource = SerialPort.GetPortNames();
        }
        
        private void btn_SerialOpen_Click(object sender, EventArgs e)
        {
            if (!form1.serialPort1.IsOpen)                                                             //시리얼포트가 열려 있지 않으면
            {
                form1.serialPort1.PortName = cb_SerialPort.Text;                                   //콤보박스의 선택된 COM포트명을 시리얼포트명으로 지정
                form1.serialPort1.BaudRate = 9600;                                                     //baudrate 변경이 필요하면 숫자 변경하기
                form1.serialPort1.DataBits = 8;
                form1.serialPort1.StopBits = StopBits.One;
                form1.serialPort1.Parity = Parity.None;
                form1.serialPort1.DataReceived += new SerialDataReceivedEventHandler(form1.serialPort1_DataReceived); //PCM 시리얼 데이터가 들어오면 "serialPort_PCM_DataReceived"함수로 전송
                form1.serialPort1.Open();                                                              //시리얼포트 열기
                //serialPort_PCM.Write("\n");

                lb_SerialPort.Text = "포트가 열렸습니다";
                
            }
            else                                                                                    //시리얼포트가 열려 있으면
            {
                lb_SerialPort.Text = "포트가 열려 있습니다.";
            }
        }

        private void rb_4chsel_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_4chsel.Checked == true)
            {
                gb_8ch.Visible = false;
                form1.pb_ch2.Visible = false;
                form1.lb_ch2.Visible = false;
                form1.lb_ch3.Text = "CH.2";
                form1.pb_ch4.Visible = false;
                form1.lb_ch4.Visible = false;
                form1.lb_ch5.Text = "CH.3";
                form1.pb_ch6.Visible = false;
                form1.lb_ch6.Visible = false;
                form1.lb_ch7.Text = "CH.4"; 
                form1.pb_ch8.Visible = false;
                form1.lb_ch8.Visible = false;
                tb_ch2ang.Text = "90 °";
                tb_ch3ang.Text = "180 °";
                tb_ch4ang.Text = "270 °";

            }
            else if (rb_4chsel.Checked == false)
            {
                gb_8ch.Visible = true;
                form1.pb_ch2.Visible = true;
                form1.lb_ch2.Visible = true;
                form1.lb_ch3.Text = "CH.3";
                form1.pb_ch4.Visible = true;
                form1.lb_ch4.Visible = true;
                form1.lb_ch5.Text = "CH.5";
                form1.pb_ch6.Visible = true;
                form1.lb_ch6.Visible = true;
                form1.lb_ch7.Text = "CH.7";
                form1.pb_ch8.Visible = true;
                form1.lb_ch8.Visible = true;

            }
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            if (rb_4chsel.Checked == true)
            {
                form1.lb_ch1deg.Text = tb_ch1ang.Text;
                form1.lb_ch3deg.Text = tb_ch2ang.Text;
                form1.lb_ch5deg.Text = tb_ch3ang.Text;
                form1.lb_ch7deg.Text = tb_ch4ang.Text;
                form1.lb_ch2deg.Text = "";
                form1.lb_ch4deg.Text = "";
                form1.lb_ch6deg.Text = "";
                form1.lb_ch8deg.Text = "";
            }
             else if (rb_4chsel.Checked == false)
            {
                form1.lb_ch1deg.Text = tb_ch1ang.Text;
                form1.lb_ch2deg.Text = tb_ch2ang.Text;
                form1.lb_ch3deg.Text = tb_ch3ang.Text;
                form1.lb_ch4deg.Text = tb_ch4ang.Text;
                form1.lb_ch5deg.Text = tb_ch5ang.Text;
                form1.lb_ch6deg.Text = tb_ch6ang.Text;
                form1.lb_ch7deg.Text = tb_ch7ang.Text;
                form1.lb_ch8deg.Text = tb_ch8ang.Text;
            }

            switch (cb_chairdeg.SelectedIndex)
            {
                case 0: form1.pb_ChairCircle.BackgroundImage = Properties.Resources.CircleChair0deg;    break;
                case 1: form1.pb_ChairCircle.BackgroundImage = Properties.Resources.CircleChair45deg;   break;
                case 2: form1.pb_ChairCircle.BackgroundImage = Properties.Resources.CircleChair90deg;   break;
                case 3: form1.pb_ChairCircle.BackgroundImage = Properties.Resources.CircleChair135deg;  break;
                case 4: form1.pb_ChairCircle.BackgroundImage = Properties.Resources.CircleChair180deg;  break;
                case 5: form1.pb_ChairCircle.BackgroundImage = Properties.Resources.CircleChair225deg;  break;
                case 6: form1.pb_ChairCircle.BackgroundImage = Properties.Resources.CircleChair270deg;  break;
                case 7: form1.pb_ChairCircle.BackgroundImage = Properties.Resources.CircleChair315deg;  break;
            }
           
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
