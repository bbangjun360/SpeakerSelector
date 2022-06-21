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
    public partial class SpeakerSelector : Form
    {
        
        public SpeakerSelector()
        {
            InitializeComponent();
            
        }

        public void SpeakerSelector_Load(object sender, EventArgs e)
        {
            Form2 SpeakerSelectorSetUp = new Form2(this);
            SpeakerSelectorSetUp.ShowDialog();
        }

        public void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)      //수신 이벤트가 발생하면 이 부분이 실행된다.
        {
            this.Invoke(new EventHandler(MySerialReceived1));                                    //메인 쓰레드와 수신 쓰레드의 충돌 방지를 위해 Invoke 사용. MySerialReceived로 이동하여 추가 작업 실행.
        }
        private void MySerialReceived1(object s, EventArgs e)                                    //여기에서 수신 데이타를 사용자의 용도에 따라 처리한다.
        {
            //tb_Serial.AppendText(serialPort1.ReadLine() + "\r\n");   //data_pcm += data_temp;     //원래:ReadExisting 으로 사용햇음    //시리얼 통신으로 들어온 데이터 data_pcm에 저장
        }
        private void PCM_send(string data_input)                                                    //
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(data_input + "\n");                                                   //텍스트박스의 텍스트를 시리얼통신으로 송신
            }
            else
                MessageBox.Show((String)"통신 연결을 먼저 진행해주세요!\r\n");
        }

        private bool btn_line1 = false;
        private bool btn_line2 = false;
        private bool btn_line3 = false;
        private bool btn_line4 = false;
        private bool btn_line5 = false;
        private bool btn_line6 = false;
        private bool btn_line7 = false;
        private bool btn_line8 = false;
        private void pb_ch1_Click(object sender, EventArgs e)
        {
            if (btn_line1 == true)
            {
                pb_ch1.BackgroundImage = Properties.Resources.spk_off;
                btn_line1 = false;
                PCM_send("L10");
            }
            else
            {
                pb_ch1.BackgroundImage = Properties.Resources.spk_on;
                btn_line1 = true;
                PCM_send("L11");
            }
        }

        private void pb_ch2_Click(object sender, EventArgs e)
        {
            if (btn_line2 == true)
            {
                pb_ch2.BackgroundImage = Properties.Resources.spk_off;
                btn_line2 = false;
                PCM_send("L50");
            }
            else
            {
                pb_ch2.BackgroundImage = Properties.Resources.spk_on;
                btn_line2 = true;
                PCM_send("L51");
            }
        }

        private void pb_ch3_Click(object sender, EventArgs e)
        {
            if (btn_line3 == true)
            {
                pb_ch3.BackgroundImage = Properties.Resources.spk_off;
                btn_line3 = false;
                PCM_send("L20");
            }
            else
            {
                pb_ch3.BackgroundImage = Properties.Resources.spk_on;
                btn_line3 = true;
                PCM_send("L21");
            }
        }

        private void pb_ch4_Click(object sender, EventArgs e)
        {
            if (btn_line4 == true)
            {
                pb_ch4.BackgroundImage = Properties.Resources.spk_off;
                btn_line4 = false;
                PCM_send("L60");
            }
            else
            {
                pb_ch4.BackgroundImage = Properties.Resources.spk_on;
                btn_line4 = true;
                PCM_send("L61");
            }
        }

        private void pb_ch5_Click(object sender, EventArgs e)
        {
            if (btn_line5 == true)
            {
                pb_ch5.BackgroundImage = Properties.Resources.spk_off;
                btn_line5 = false;
                PCM_send("L30");
            }
            else
            {
                pb_ch5.BackgroundImage = Properties.Resources.spk_on;
                btn_line5 = true;
                PCM_send("L31");
            }
        }

        private void pb_ch6_Click(object sender, EventArgs e)
        {
            if (btn_line6 == true)
            {
                pb_ch6.BackgroundImage = Properties.Resources.spk_off;
                btn_line6 = false;
                PCM_send("L70");
            }
            else
            {
                pb_ch6.BackgroundImage = Properties.Resources.spk_on;
                btn_line6 = true;
                PCM_send("L71");
            }
        }

        private void pb_ch7_Click(object sender, EventArgs e)
        {
            if (btn_line7 == true)
            {
                pb_ch7.BackgroundImage = Properties.Resources.spk_off;
                btn_line7 = false;
                PCM_send("L40");
            }
            else
            {
                pb_ch7.BackgroundImage = Properties.Resources.spk_on;
                btn_line7 = true;
                PCM_send("L41");
            }
        }

        private void pb_ch8_Click(object sender, EventArgs e)
        {
            if (btn_line8 == true)
            {
                pb_ch8.BackgroundImage = Properties.Resources.spk_off;
                btn_line8 = false;
                PCM_send("L80");
            }
            else
            {
                pb_ch8.BackgroundImage = Properties.Resources.spk_on;
                btn_line8 = true;
                PCM_send("L81");
            }
        }

        private void btnSetUp_Click(object sender, EventArgs e)
        {
            Form2 SpeakerSelectorSetUp = new Form2(this);
            SpeakerSelectorSetUp.ShowDialog();
        }

        public void setangle(String ang)
        {
            lb_ch1deg.Text = ang;
        }
    }
}
