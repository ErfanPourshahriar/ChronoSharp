using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication29
{
    public partial class Form1 : Form
    {
        bool isBtnStopEnabled = false;
        int min = 0;
        int sec = 0;
        int hour = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            if (sec == 60)
            {
                sec=0;
                min++;
                if (min == 60)
                {
                    min=0;
                    hour++;
                }
            }

            if (sec < 10)
                secLbl.Text = "0" + sec.ToString();
            else
                secLbl.Text = sec.ToString();
            if (min < 10)
                minLbl.Text = "0" + min.ToString();
            else
                minLbl.Text = min.ToString();
            if (hour < 10)
                hourLbl.Text = "0" + hour.ToString();
            else
                hourLbl.Text = hour.ToString();

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            if (isBtnStopEnabled == false)
            {
                isBtnStopEnabled = true;
                stopBtn.Text = "RESUME";
                timer1.Enabled = false;
            }
            else
            {
                isBtnStopEnabled = false;
                stopBtn.Text = "PAUSE";
                timer1.Enabled = true;
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            min = 0;
            sec = 0;
            hour = 0;
            secLbl.Text = "0" + sec.ToString();
            minLbl.Text = "0" + min.ToString();
            hourLbl.Text = "0" + hour.ToString();

        }
    }
}
