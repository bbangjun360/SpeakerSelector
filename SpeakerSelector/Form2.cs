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
            cb_SerialPort.DataSource = SerialPort.GetPortNames();
        }
        private void cb_SerialPort_Click(object sender, EventArgs e)
        {
            cb_SerialPort.DataSource = SerialPort.GetPortNames();
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)      //수신 이벤트가 발생하면 이 부분이 실행된다.
        {
            this.Invoke(new EventHandler(MySerialReceived1));                                    //메인 쓰레드와 수신 쓰레드의 충돌 방지를 위해 Invoke 사용. MySerialReceived로 이동하여 추가 작업 실행.
        }
        private void MySerialReceived1(object s, EventArgs e)                                    //여기에서 수신 데이타를 사용자의 용도에 따라 처리한다.
        {
            //tb_Serial.AppendText(serialPort1.ReadLine() + "\r\n");   //data_pcm += data_temp;     //원래:ReadExisting 으로 사용햇음    //시리얼 통신으로 들어온 데이터 data_pcm에 저장
        }
        private void btn_SerialOpen_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)                                                             //시리얼포트가 열려 있지 않으면
            {
                serialPort1.PortName = cb_SerialPort.Text;                                   //콤보박스의 선택된 COM포트명을 시리얼포트명으로 지정
                serialPort1.BaudRate = 9600;                                                     //baudrate 변경이 필요하면 숫자 변경하기
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Parity = Parity.None;
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived); //PCM 시리얼 데이터가 들어오면 "serialPort_PCM_DataReceived"함수로 전송
                serialPort1.Open();                                                              //시리얼포트 열기
                //serialPort_PCM.Write("\n");

                lb_SerialPort.Text = "포트가 열렸습니다";
                
            }
            else                                                                                    //시리얼포트가 열려 있으면
            {
                lb_SerialPort.Text = "포트가 열려 있습니다.";
            }
        }

        private void btn_SerialClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)                                                              //시리얼포트가 열려 있으면
            {
                serialPort1.Close();                                                             //시리얼포트 닫기
                lb_SerialPort.Text = "포트가 닫혔습니다.";                                     //COM포트설정 콤보박스 활성화
            }
            else                                                                                    //시리얼포트가 닫혀 있으면
            {
                lb_SerialPort.Text = "포트가 닫혀 있습니다.";
            }
        }

        private void rb_4chsel_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_4chsel.Checked == true)
            {
                gb_8ch.Visible = false;
                btn_apply.Location = new Point(12, 279);
                btn_close.Location = new Point(88, 279);
                this.Size = new Size(183, 347);
               
            }
            else if (rb_4chsel.Checked == false)
            {
                gb_8ch.Visible = true;
                btn_apply.Location = new Point(12, 413);
                btn_close.Location = new Point(88, 413);
                this.Size = new Size(183, 487);
            }
        }

        private void btn_apply_Click(object sender, EventArgs e)
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

        private void btn_close_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
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
