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
using System.IO;

namespace SpeakerSelector
{
    public partial class SpeakerSelector : Form
    {
        System.Threading.Timer TESTTIME_ThreadTimer;
        System.Threading.Timer StimulationTime_ThreadTimer;
        System.Threading.Timer StimulationTimeWait_ThreadTimer;
        delegate void TimerEventFiredDelegate_TESTTIME();
        delegate void TimerEventFiredDelegate_StimulationTime();
        delegate void TimerEventFiredDelegate_StimulationTimeWait();
        public SpeakerSelector()
        {
            InitializeComponent();
            TESTTIME_ThreadTimer = new System.Threading.Timer(TESTTIME_timerCallBack);
            StimulationTime_ThreadTimer = new System.Threading.Timer(StimulationTime_timerCallBack);
            StimulationTimeWait_ThreadTimer = new System.Threading.Timer(StimulationTimeWait_timerCallBack);

            TESTTIME_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            StimulationTime_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            StimulationTimeWait_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
        }

        public void SpeakerSelector_Load(object sender, EventArgs e)
        {
            Form2 SpeakerSelectorSetUp = new Form2(this);
            SpeakerSelectorSetUp.ShowDialog();
            btn_csvOpen.PerformClick();
            switch(Properties.Settings.Default.save_selectedmode)
            {
                case 1: rb_serial.Checked = true; break;
                case 2: rb_random.Checked = true; break;
                case 3: rb_manual.Checked = true; break;
                case 4: rb_preset.Checked = true; break;
            }
            tb_form1StimulationTime.Text = Properties.Settings.Default.save_tb_stimulationTime;
            tb_form1StimulationTimeWait.Text = Properties.Settings.Default.save_tb_stimulationTimeWait;
            tb_form1RoutineCount.Text = Properties.Settings.Default.save_tb_routineTime;

            cb_clockwise.Enabled = false;
            cb_allRandom.Enabled = false;

            pb_ch1.Enabled = false;
            pb_ch2.Enabled = false;
            pb_ch3.Enabled = false;
            pb_ch4.Enabled = false;
            pb_ch5.Enabled = false;
            pb_ch6.Enabled = false;
            pb_ch7.Enabled = false;
            pb_ch8.Enabled = false;
            gb_mode.Enabled = false;
            gb_stimulationTime.Enabled = false;
            gb_routineCount.Enabled = false;
            btn_testStart.Enabled = false;
        }
        void TESTTIME_timerCallBack(Object state)
        {
            BeginInvoke(new TimerEventFiredDelegate_TESTTIME(TESTTIME_timerWork));
        }
        void StimulationTime_timerCallBack(Object state)
        {
            BeginInvoke(new TimerEventFiredDelegate_TESTTIME(StimulationTime_timerWork));
        }
        void StimulationTimeWait_timerCallBack(Object state)
        {
            BeginInvoke(new TimerEventFiredDelegate_TESTTIME(StimulationTimeWait_timerWork));
        }
        long testtime_time = 0;
        private void TESTTIME_timerWork()
        {
            testtime_time += 1;                                                                      //초 마다 타이머 함수 실행되면 -1해 남은시간 줄여줌
            lb_testtime.Text = (testtime_time / 60).ToString("00") + ":" + (testtime_time % 60).ToString("00");    //남은 시간 uint -> String으로 변환하는 작업
            testtime_timer_tick(lb_testtime.Text);

        }
        private void testtime_timer_tick(String clock_data)
        {

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
            /*else
                MessageBox.Show((String)"통신 연결을 먼저 진행해주세요!\r\n");*/
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
            ch1Click();
        }
        private void ch1Click()
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
            ch2Click();
        }
        private void ch2Click()
        {
            if (btn_line2 == true)
            {
                pb_ch2.BackgroundImage = Properties.Resources.spk_off;
                btn_line2 = false;
                PCM_send("L20");
            }
            else
            {
                pb_ch2.BackgroundImage = Properties.Resources.spk_on;
                btn_line2 = true;
                PCM_send("L21");
            }
        }

        private void pb_ch3_Click(object sender, EventArgs e)
        {
            ch3Click();
        }
        private void ch3Click()
        {
            if (btn_line3 == true)
            {
                pb_ch3.BackgroundImage = Properties.Resources.spk_off;
                btn_line3 = false;
                PCM_send("L30");
            }
            else
            {
                pb_ch3.BackgroundImage = Properties.Resources.spk_on;
                btn_line3 = true;
                PCM_send("L31");
            }
        }
        private void pb_ch4_Click(object sender, EventArgs e)
        {
            ch4Click();
        }
        private void ch4Click()
        {
            if (btn_line4 == true)
            {
                pb_ch4.BackgroundImage = Properties.Resources.spk_off;
                btn_line4 = false;
                PCM_send("L40");
            }
            else
            {
                pb_ch4.BackgroundImage = Properties.Resources.spk_on;
                btn_line4 = true;
                PCM_send("L41");
            }
        }

        private void pb_ch5_Click(object sender, EventArgs e)
        {
            ch5Click();
        }
        private void ch5Click()
        {
            if (btn_line5 == true)
            {
                pb_ch5.BackgroundImage = Properties.Resources.spk_off;
                btn_line5 = false;
                PCM_send("L50");
            }
            else
            {
                pb_ch5.BackgroundImage = Properties.Resources.spk_on;
                btn_line5 = true;
                PCM_send("L51");
            }
        }
        private void pb_ch6_Click(object sender, EventArgs e)
        {
            ch6Click();
        }
        private void ch6Click()
        {
            if (btn_line6 == true)
            {
                pb_ch6.BackgroundImage = Properties.Resources.spk_off;
                btn_line6 = false;
                PCM_send("L60");
            }
            else
            {
                pb_ch6.BackgroundImage = Properties.Resources.spk_on;
                btn_line6 = true;
                PCM_send("L61");
            }
        }
        private void pb_ch7_Click(object sender, EventArgs e)
        {
            ch7Click();
        }
        private void ch7Click()
        {
            if (btn_line7 == true)
            {
                pb_ch7.BackgroundImage = Properties.Resources.spk_off;
                btn_line7 = false;
                PCM_send("L70");
            }
            else
            {
                pb_ch7.BackgroundImage = Properties.Resources.spk_on;
                btn_line7 = true;
                PCM_send("L71");
            }
        }
        private void pb_ch8_Click(object sender, EventArgs e)
        {
            ch8Click();
        }
        private void ch8Click()
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
            Properties.Settings.Default.form2Opened = false;
            Properties.Settings.Default.Save();
            Form2 SpeakerSelectorSetUp = new Form2(this);
            SpeakerSelectorSetUp.ShowDialog();
        }

        public void setangle(String ang)
        {
            lb_ch1deg.Text = ang;
        }

        bool teststart = false;
        private void btn_testStart_Click(object sender, EventArgs e)
        {
            if (rb_manual.Checked)
            {
                if (teststart == false)
                {
                    if (rb_preset.Checked)
                    {
                        for (int i = 0; i < lv_preset.Items.Count; i++)
                            routineCntSum += Int32.Parse(lv_preset.Items[i].SubItems[2].Text);
                    }
                    teststart = true;
                    btn_testStart.Text = "TEST STOP";
                    lb_testtime.Text = "00:00";
                    testtime_time = -1;
                    TESTTIME_ThreadTimer.Change(0, 1000);
                    StimulationTime_ThreadTimer.Change(0, 1000);

                    Properties.Settings.Default.save_tb_stimulationTime = tb_form1StimulationTime.Text;
                    Properties.Settings.Default.save_tb_stimulationTimeWait = tb_form1StimulationTimeWait.Text;
                    Properties.Settings.Default.save_tb_routineTime = tb_form1RoutineCount.Text;
                    Properties.Settings.Default.Save();
                    tb_form1StimulationTime.Enabled = false;
                    tb_form1StimulationTimeWait.Enabled = false;
                    tb_form1RoutineCount.Enabled = false;
                }
                else
                {
                    testStop();
                }
            }
            else
            {
                if (tb_form1StimulationTime.Text == "")
                {
                    MessageBox.Show("Please Set StimulationTime First");
                }
                else if (tb_form1StimulationTimeWait.Text == "")
                {
                    MessageBox.Show("Please Set StimulationTimeWait First");
                }
                else if (tb_form1RoutineCount.Text == "")
                {
                    MessageBox.Show("Please Set RoutineCount First");
                }
                else
                {
                    if (teststart == false)
                    {
                        if (rb_preset.Checked)
                        {
                            for (int i = 0; i < lv_preset.Items.Count; i++)
                                routineCntSum += Int32.Parse(lv_preset.Items[i].SubItems[2].Text);
                        }
                        teststart = true;
                        btn_testStart.Text = "TEST STOP";
                        lb_testtime.Text = "00:00";
                        testtime_time = -1;

                        Properties.Settings.Default.save_tb_stimulationTime = tb_form1StimulationTime.Text;
                        Properties.Settings.Default.save_tb_stimulationTimeWait = tb_form1StimulationTimeWait.Text;
                        Properties.Settings.Default.save_tb_routineTime = tb_form1RoutineCount.Text;
                        Properties.Settings.Default.Save();
                        tb_form1StimulationTime.Enabled = false;
                        tb_form1StimulationTimeWait.Enabled = false;
                        tb_form1RoutineCount.Enabled = false;

                        TESTTIME_ThreadTimer.Change(0, 1000);
                        StimulationTime_ThreadTimer.Change(0, 1000);
                    }
                    else
                    {
                        testStop();
                    }
                }
            }
            if (rb_random.Checked)
            {
                Random rnd = new Random(DateTime.Now.Millisecond);
                if(Properties.Settings.Default.save_rb_8chsel == false)
                {
                    for(int i = 0; i < 4; i++)
                    {
                        randomArray[i] = rnd.Next(1, 5);
                    }
                    while (randomArray[0] != randomArray[1])
                    {
                        randomArray[1] = rnd.Next(1, 5);
                    }
                    while (randomArray[0] != randomArray[2] && randomArray[1] != randomArray[2])
                    {
                        randomArray[2] = rnd.Next(1, 5);
                    }
                    while (randomArray[0] != randomArray[3] && randomArray[1] != randomArray[3] && randomArray[2] != randomArray[3])
                    {
                        randomArray[3] = rnd.Next(1, 5);
                    }
                }
            }
        }
        int[] randomArray = new int[8];
        private void testStop()
        {
            teststart = false;
            btn_testStart.Text = "TEST START";
            TESTTIME_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            StimulationTime_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            StimulationTimeWait_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            routineCountChk = 0;
            currentCh = 0;
            randomvalue = 1;
            routineCntSum = 0;
            stimulationTime_time = 0;
            stimulationTimeWait_time = 0;
            tb_form1RoutineCount.Text = Properties.Settings.Default.save_tb_routineTime;
            pb_ch1.BackgroundImage = Properties.Resources.spk_off;
            btn_csvOpen.PerformClick();

            btn_line1 = false;
            PCM_send("AF"); //전체종료

            pb_ch2.BackgroundImage = Properties.Resources.spk_off;
            btn_line2 = false;
            pb_ch3.BackgroundImage = Properties.Resources.spk_off;
            btn_line3 = false;
            pb_ch4.BackgroundImage = Properties.Resources.spk_off;
            btn_line4 = false;
            pb_ch5.BackgroundImage = Properties.Resources.spk_off;
            btn_line5 = false;
            pb_ch6.BackgroundImage = Properties.Resources.spk_off;
            btn_line6 = false;
            pb_ch7.BackgroundImage = Properties.Resources.spk_off;
            btn_line7 = false;
            pb_ch8.BackgroundImage = Properties.Resources.spk_off;
            btn_line8 = false;

            tb_form1StimulationTime.Enabled = true;
            tb_form1StimulationTimeWait.Enabled = true;
            tb_form1RoutineCount.Enabled = true;
        }
        //mode 관련 함수
        int currentCh = 0;
        int routineCountChk = 0;
        bool rndSpkOn = false;
        int randomvalue = 1;
        int routineCntSum = 0;
        private void modeSelector()
        {
            if (rb_preset.Checked)
            {
                while (Int32.Parse(lv_preset.Items[currentCh].SubItems[2].Text) == 0)
                {
                    currentCh++;
                    if (lv_preset.Items.Count <= currentCh)
                        currentCh = 0;
                }
                string channels = lv_preset.Items[currentCh].SubItems[0].Text;
                string[] channel = channels.Split(' ');
                //Console.WriteLine(channel[0]);
                //Console.WriteLine(channel[1]);
                //Console.WriteLine(channels.Replace(" ", "").Length);
                int lenn = channels.Replace(" ", "").Length;
                for (int i = 0; i < lenn; i++)
                {
                    speakerSwitch(Int32.Parse(channel[i]));
                }
            }
            else
            {
                if (routineCountChk < Int32.Parse(Properties.Settings.Default.save_tb_routineTime))
                {
                    if (rb_serial.Checked)
                    {
                        if (cb_clockwise.Checked)
                        {
                            speakerSwitch(currentCh + 1);

                        }
                        else
                        {
                            speakerSwitch(4 - currentCh);
                        }
                    }
                    else if (rb_random.Checked)
                    {
                        if (rndSpkOn == false)
                        {
                            Random rnd = new Random(DateTime.Now.Millisecond);
                            
                            if (Properties.Settings.Default.save_rb_8chsel == false)
                            {   //4채널
                                randomvalue = rnd.Next(1, 5);
                            }
                            else
                            {   //8채널
                                randomvalue = rnd.Next(1, 9);
                            }
                            rndSpkOn = true;
                        }
                        speakerSwitch(randomvalue);
                    }
                    else if (rb_manual.Checked)
                    {
                        StimulationTime_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                    }
                }
                else
                {   // routineCount 끝나면 종료
                    testStop();
                }
            }
            
        }
        private void speakerSwitch(int speakerNum)
        {
            switch (speakerNum)
            {
                case 1: ch1Click(); break;
                case 2: ch2Click(); break;
                case 3: ch3Click(); break;
                case 4: ch4Click(); break;
                case 5: ch5Click(); break;
                case 6: ch6Click(); break;
                case 7: ch7Click(); break;
                case 8: ch8Click(); break;
            }
        }
        int stimulationTime_time = 0;
        int stimulationTimeWait_time = 0;
        private void StimulationTime_timerWork()
        {                                                                   //초 마다 타이머 함수 실행되면 -1해 남은시간 줄여줌
            if (teststart == true)
            {
                if (rb_preset.Checked)
                {
                    if (stimulationTime_time == 0)
                    {
                        modeSelector();
                        lv_preset.Items[currentCh].Selected = true;
                    }
                    else if (stimulationTime_time == Int32.Parse(lv_preset.Items[currentCh].SubItems[1].Text.Split('/')[0]))
                    {
                        modeSelector();
                        StimulationTime_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                        stimulationTimeWait_time = 0;
                        StimulationTimeWait_ThreadTimer.Change(0, 1000);
                    }
                }
                else
                {
                    if (stimulationTime_time == 0)
                    {
                        rndSpkOn = false;
                        modeSelector();
                    }
                    else if (stimulationTime_time == Int32.Parse(Properties.Settings.Default.save_tb_stimulationTime))
                    {
                        modeSelector();
                        StimulationTime_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                        stimulationTimeWait_time = 0;
                        StimulationTimeWait_ThreadTimer.Change(0, 1000);
                    }
                }
                stimulationTime_time += 1;
            }
        }
        private void StimulationTimeWait_timerWork()
        {                                                                   //초 마다 타이머 함수 실행되면 -1해 남은시간 줄여줌
            if (teststart == true)
            {
                if (rb_preset.Checked)
                {
                    if (stimulationTimeWait_time == Int32.Parse(lv_preset.Items[currentCh].SubItems[1].Text.Split('/')[1]))
                    {
                        StimulationTimeWait_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                        string dataChange = (Int32.Parse(lv_preset.Items[currentCh].SubItems[2].Text) - 1).ToString();
                        lv_preset.Items[currentCh].SubItems[2].Text = dataChange;
                        lv_preset.Items[currentCh].Selected = false;
                        currentCh++;
                        if (lv_preset.Items.Count <= currentCh)
                            currentCh = 0;
                        stimulationTime_time = 0;
                        routineCntSum--;
                        if (routineCntSum == 0)
                        {
                            btn_testStart.PerformClick();
                        }
                        else
                        {
                            StimulationTime_ThreadTimer.Change(0, 1000);
                        }
                    }
                }
                else
                {
                    if (stimulationTimeWait_time == Int32.Parse(Properties.Settings.Default.save_tb_stimulationTimeWait))
                    {
                        currentCh++;
                        if (Properties.Settings.Default.save_rb_8chsel == false)
                        {
                            if (currentCh == 4)
                            {
                                currentCh = 0;
                                routineCountChk++;
                                tb_form1RoutineCount.Text = (Int32.Parse(tb_form1RoutineCount.Text) - 1).ToString();
                            }
                        }
                        else
                        {
                            if (currentCh == 8)
                            {
                                currentCh = 0;
                                routineCountChk++;
                                tb_form1RoutineCount.Text = (Int32.Parse(tb_form1RoutineCount.Text) - 1).ToString();
                            }
                        }
                        StimulationTimeWait_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                        stimulationTime_time = 0;
                        StimulationTime_ThreadTimer.Change(0, 1000);
                    }
                }
                stimulationTimeWait_time += 1;
            }
        }
        //preset 관련 함수
        public string CheckBoxSpeakerChecked()
        {
            string speakerSelected = "";
            if (cb_listCh1.Checked) speakerSelected += "1 ";
            if (cb_listCh2.Checked) speakerSelected += "2 ";
            if (cb_listCh3.Checked) speakerSelected += "3 ";
            if (cb_listCh4.Checked) speakerSelected += "4 ";
            if (cb_listCh5.Checked) speakerSelected += "5 ";
            if (cb_listCh6.Checked) speakerSelected += "6 ";
            if (cb_listCh7.Checked) speakerSelected += "7 ";
            if (cb_listCh8.Checked) speakerSelected += "8 ";
            return speakerSelected;
        }
        public void CheckBoxSpeakerChecking(string str)
        {
            string[] channels = str.Split(new char[] { ' ' });
            int num = str.Replace(" ", "").Length / 3;
            for (int i = 0; i < num; i++)
            {
                if (channels[i].Contains("1")) cb_listCh1.Checked = true;
                else if (channels[i].Contains("2")) cb_listCh2.Checked = true;
                else if (channels[i].Contains("3")) cb_listCh3.Checked = true;
                else if (channels[i].Contains("4")) cb_listCh4.Checked = true;
                else if (channels[i].Contains("5")) cb_listCh5.Checked = true;
                else if (channels[i].Contains("6")) cb_listCh6.Checked = true;
                else if (channels[i].Contains("7")) cb_listCh7.Checked = true;
                else if (channels[i].Contains("8")) cb_listCh8.Checked = true;
            }
        }
        private void btn_listAdd_Click(object sender, EventArgs e)
        {
            string speakerOn = CheckBoxSpeakerChecked();
            string stimulationTime = tb_stimulationTime.Text + "/" + tb_stimulationTimeWait.Text;
            string stimulationCount = tb_stimulationCount.Text;
            string[] strs = new string[] { speakerOn, stimulationTime, stimulationCount };
            ListViewItem lvi = new ListViewItem(strs);
            lv_preset.Items.Add(lvi);
            ClearInputControl();
            btn_csvSave.PerformClick();
        }
        private void ClearInputControl()
        {
            cb_listCh1.Checked = false;
            cb_listCh2.Checked = false;
            cb_listCh3.Checked = false;
            cb_listCh4.Checked = false;
            cb_listCh5.Checked = false;
            cb_listCh6.Checked = false;
            cb_listCh7.Checked = false;
            cb_listCh8.Checked = false;
            tb_stimulationTime.Text = string.Empty;
            tb_stimulationTimeWait.Text = string.Empty;
            tb_stimulationCount.Text = string.Empty;
        }

        private void lv_preset_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool selected = lv_preset.SelectedItems.Count > 0;
            btn_listDelete.Enabled = btn_listModify.Enabled = selected;
            if (selected == false)
            {
                ClearInputControl();
                return;
            }
            ListViewItem lvi = lv_preset.SelectedItems[0];
            CheckBoxSpeakerChecking(lvi.SubItems[0].Text);
            string[] tempstr = lvi.SubItems[1].Text.Split('/');
            tb_stimulationTime.Text = (tempstr[0]);
            tb_stimulationTimeWait.Text = (tempstr[1]);
            tb_stimulationCount.Text = lvi.SubItems[2].Text;
        }

        private void btn_listDelete_Click(object sender, EventArgs e)
        {
            bool selected = lv_preset.SelectedItems.Count > 0;
            if (selected == false)
            {
                throw new ApplicationException("선택 항목이 없는데 삭제 요청하였습니다.");
            }
            ListViewItem lvi = lv_preset.SelectedItems[0];
            lv_preset.Items.Remove(lvi);
            ClearInputControl();
            btn_csvSave.PerformClick();
        }

        private void btn_listModify_Click(object sender, EventArgs e)
        {
            bool selected = lv_preset.SelectedItems.Count > 0;
            if (selected == false)
            {
                throw new ApplicationException(
                     "선택 항목이 없는데 수정 요청하였습니다.");
            }
            ListViewItem lvi = lv_preset.SelectedItems[0];
            string speakerOn = CheckBoxSpeakerChecked();
            string stimulationTime = tb_stimulationTime.Text + "/" + tb_stimulationTimeWait.Text;
            string stimulationCount = tb_stimulationCount.Text;
            lvi.SubItems[0].Text = speakerOn;
            lvi.SubItems[1].Text = stimulationTime;
            lvi.SubItems[2].Text = stimulationCount;
            ClearInputControl();
            btn_csvSave.PerformClick();
        }


        //preset 저장 불러오기 관련 함수
        const string fname = "presetData.csv";
        private void AddMember(string id, string name, string age)
        {
            string[] sitems = new string[] { id, name, age.ToString() };
            ListViewItem lvi = new ListViewItem(sitems);
            lv_preset.Items.Add(lvi);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lv_preset.Items.Clear();
            if (File.Exists(fname) == false)
            {
                return;
            }
            FileStream fs = File.OpenRead(fname);
            StreamReader sr = new StreamReader(fs);
            while (sr.EndOfStream == false)
            {
                string data = sr.ReadLine();
                if (data == null) { break; }
                string[] sitems = data.Split(',');
                AddMember(sitems[0], sitems[1], sitems[2]);
            }
            sr.Close();
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = File.Create(fname);
            StreamWriter sw = new StreamWriter(fs);
            foreach (ListViewItem lvi in lv_preset.Items)
            {
                string id = lvi.SubItems[0].Text;
                string name = lvi.SubItems[1].Text;
                string age = lvi.SubItems[2].Text;
                sw.WriteLine("{0},{1},{2}", id, name, age);
            }
            sw.Close();
            fs.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            serialPort1.Close();


            if (!serialPort1.IsOpen)                                                             //시리얼포트가 열려 있지 않으면
            {
                gb_mode.Enabled = true;
                btn_testStart.Enabled = true;
                if (rb_manual.Checked == true)
                {
                    gb_stimulationTime.Enabled = false;
                    gb_routineCount.Enabled = false;
                    pb_ch1.Enabled = true;
                    pb_ch2.Enabled = true;
                    pb_ch3.Enabled = true;
                    pb_ch4.Enabled = true;
                    pb_ch5.Enabled = true;
                    pb_ch6.Enabled = true;
                    pb_ch7.Enabled = true;
                    pb_ch8.Enabled = true;
                }
                else if (rb_serial.Checked)
                {
                    gb_stimulationTime.Enabled = true;
                    gb_routineCount.Enabled = true;
                    cb_clockwise.Enabled = true;
                }
                else if(rb_random.Checked)
                {
                    gb_stimulationTime.Enabled = true;
                    gb_routineCount.Enabled = true;
                    cb_allRandom.Enabled = true;
                }
                else
                {
                    gb_stimulationTime.Enabled = true;
                    gb_routineCount.Enabled = true;
                }

                serialPort1.PortName = Properties.Settings.Default.save_cb_SerialPort;                                   //콤보박스의 선택된 COM포트명을 시리얼포트명으로 지정
                serialPort1.BaudRate = 9600;                                                     //baudrate 변경이 필요하면 숫자 변경하기
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Parity = Parity.None;
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived); //PCM 시리얼 데이터가 들어오면 "serialPort_PCM_DataReceived"함수로 전송
                serialPort1.Open();                                                              //시리얼포트 열기
                //serialPort_PCM.Write("\n");

            }
            else                                                                                    //시리얼포트가 열려 있으면
            {
            }
            btnConnect.BackColor = System.Drawing.Color.Green;
            btnConnect.Text = "connected";
            
        }

        private void SpeakerSelector_FormClosing(object sender, FormClosingEventArgs e)
        {
            PCM_send("AF");
        }
        private void SpeakerSelector_FormClosed(object sender, FormClosedEventArgs e)
        {
            PCM_send("AF");
        }
        // radio 버튼 변경될 때 마다 저장하고 행동 실행하는 부분
        private void rb_serial_CheckedChanged(object sender, EventArgs e)
        {
            cb_clockwise.Enabled = true;
            cb_allRandom.Enabled = false;
            gb_stimulationTime.Enabled = true;
            gb_routineCount.Enabled = true;
            btn_testStart.Enabled = true;

            lb_testtime.Text = "00:00";
            testStop();
            if (rb_serial.Checked) Properties.Settings.Default.save_selectedmode = 1;
            else if (rb_random.Checked) Properties.Settings.Default.save_selectedmode = 2;
            else if (rb_manual.Checked)
            {
                gb_stimulationTime.Enabled = false;
                gb_routineCount.Enabled = false;
                Properties.Settings.Default.save_selectedmode = 3;
            }
            else if (rb_preset.Checked) Properties.Settings.Default.save_selectedmode = 4;
            Properties.Settings.Default.Save();

            pb_ch1.Enabled = false;
            pb_ch2.Enabled = false;
            pb_ch3.Enabled = false;
            pb_ch4.Enabled = false;
            pb_ch5.Enabled = false;
            pb_ch6.Enabled = false;
            pb_ch7.Enabled = false;
            pb_ch8.Enabled = false;

        }

        private void rb_random_CheckedChanged(object sender, EventArgs e)
        {
            cb_clockwise.Enabled = false;
            cb_allRandom.Enabled = true;
            btn_testStart.Enabled = true;
            gb_stimulationTime.Enabled = true;
            gb_routineCount.Enabled = true;

            lb_testtime.Text = "00:00";
            testStop();
            if (rb_serial.Checked) Properties.Settings.Default.save_selectedmode = 1;
            else if (rb_random.Checked) Properties.Settings.Default.save_selectedmode = 2;
            else if (rb_manual.Checked)
            {
                gb_stimulationTime.Enabled = false;
                gb_routineCount.Enabled = false;
                Properties.Settings.Default.save_selectedmode = 3;
            }
            else if (rb_preset.Checked) Properties.Settings.Default.save_selectedmode = 4;
            Properties.Settings.Default.Save();
            pb_ch1.Enabled = false;
            pb_ch2.Enabled = false;
            pb_ch3.Enabled = false;
            pb_ch4.Enabled = false;
            pb_ch5.Enabled = false;
            pb_ch6.Enabled = false;
            pb_ch7.Enabled = false;
            pb_ch8.Enabled = false;
        }

        private void rb_manual_CheckedChanged(object sender, EventArgs e)
        {
            cb_clockwise.Enabled = false;
            cb_allRandom.Enabled = false;
            gb_stimulationTime.Enabled = true;
            gb_routineCount.Enabled = true;
            btn_testStart.Enabled = false;

            lb_testtime.Text = "00:00";
            testStop();
            if (rb_serial.Checked) Properties.Settings.Default.save_selectedmode = 1;
            else if (rb_random.Checked) Properties.Settings.Default.save_selectedmode = 2;
            else if (rb_manual.Checked)
            {
                gb_stimulationTime.Enabled = false;
                gb_routineCount.Enabled = false;
                Properties.Settings.Default.save_selectedmode = 3;
            }
            else if (rb_preset.Checked) Properties.Settings.Default.save_selectedmode = 4;
            Properties.Settings.Default.Save();
            pb_ch1.Enabled = true;
            pb_ch2.Enabled = true;
            pb_ch3.Enabled = true;
            pb_ch4.Enabled = true;
            pb_ch5.Enabled = true;
            pb_ch6.Enabled = true;
            pb_ch7.Enabled = true;
            pb_ch8.Enabled = true;
        }
        private void rb_preset_CheckedChanged(object sender, EventArgs e)
        {
            cb_clockwise.Enabled = false;
            cb_allRandom.Enabled = false;
            gb_stimulationTime.Enabled = false;
            gb_routineCount.Enabled = false;
            btn_testStart.Enabled = true;
            

            testStop();
            lb_testtime.Text = "00:00";
            if (rb_serial.Checked) Properties.Settings.Default.save_selectedmode = 1;
            else if (rb_random.Checked) Properties.Settings.Default.save_selectedmode = 2;
            else if (rb_manual.Checked)
            {
                gb_stimulationTime.Enabled = false;
                gb_routineCount.Enabled = false;
                Properties.Settings.Default.save_selectedmode = 3;
            }
            else if (rb_preset.Checked)
            {
                Properties.Settings.Default.save_selectedmode = 4;
            }
            Properties.Settings.Default.Save();
            pb_ch1.Enabled = false;
            pb_ch2.Enabled = false;
            pb_ch3.Enabled = false;
            pb_ch4.Enabled = false;
            pb_ch5.Enabled = false;
            pb_ch6.Enabled = false;
            pb_ch7.Enabled = false;
            pb_ch8.Enabled = false;

            if (rb_preset.Checked)
            {
                this.Size = new Size(1250, 668);
            }
            else
            {
                this.Size = new Size(930, 668);
            }
        }

        private void btn_timerReset_Click(object sender, EventArgs e)
        {
            PCM_send("AF");
            pb_ch1.BackgroundImage = Properties.Resources.spk_off;
            btn_line1 = false;
            pb_ch2.BackgroundImage = Properties.Resources.spk_off;
            btn_line2 = false;
            pb_ch3.BackgroundImage = Properties.Resources.spk_off;
            btn_line3 = false;
            pb_ch4.BackgroundImage = Properties.Resources.spk_off;
            btn_line4 = false;
            pb_ch5.BackgroundImage = Properties.Resources.spk_off;
            btn_line5 = false;
            pb_ch6.BackgroundImage = Properties.Resources.spk_off;
            btn_line6 = false;
            pb_ch7.BackgroundImage = Properties.Resources.spk_off;
            btn_line7 = false;
            pb_ch8.BackgroundImage = Properties.Resources.spk_off;
            btn_line8 = false;

            testStop();
            MessageBox.Show("! HARDWARE RESET !","WARNING");
        }
    }
}
