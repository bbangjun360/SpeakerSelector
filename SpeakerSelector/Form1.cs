using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeakerSelector
{
    public partial class SpeakerSelector : Form
    {
        
        public SpeakerSelector()
        {
            InitializeComponent();
            
        }

        private void SpeakerSelector_Load(object sender, EventArgs e)
        {
            Form2 SpeakerSelectorSetUp = new Form2(this);
            SpeakerSelectorSetUp.ShowDialog();
        }

        private void pb_ch1_Click(object sender, EventArgs e)
        {

        }

        private void pb_ch2_Click(object sender, EventArgs e)
        {

        }

        private void pb_ch3_Click(object sender, EventArgs e)
        {

        }

        private void pb_ch4_Click(object sender, EventArgs e)
        {

        }

        private void pb_ch5_Click(object sender, EventArgs e)
        {

        }

        private void pb_ch6_Click(object sender, EventArgs e)
        {

        }

        private void pb_ch7_Click(object sender, EventArgs e)
        {

        }

        private void pb_ch8_Click(object sender, EventArgs e)
        {

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
