using System;
using System.Windows.Forms;

namespace StopwatchON
{
    public partial class Window : Form
    {
        byte timeSec, timeMin, timeHour;
        bool isActive;

        private void lblStop_Click(object sender, EventArgs e)
        {
            isActive = false;
        }

        private void ResetTime()
        {
            timeSec = 0;
            timeMin = 0;
            timeHour = 0;
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            isActive = false;
            ResetTime();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                timeSec++;
                if (timeSec >= 60)
                {
                    timeMin++;
                    timeSec = 0;
                    if (timeMin >= 60)
                    {
                        timeHour++;
                        timeMin = 0;
                        if (timeHour >= 99)
                        {
                            ResetTime();
                            isActive = false;
                        }
                    }
                }
            }
            DrawTime();
        }

        private void DrawTime()
        {
            lblSec.Text = String.Format("{0:00}", timeSec);
            lblMin.Text = String.Format("{0:00}", timeMin);
            lblHours.Text = String.Format("{0:00}", timeHour);
        }

        private void lblStart_Click(object sender, EventArgs e)
        {
            isActive = true;
        }

        public Window()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetTime();

            isActive = false;
        }
    }
}
