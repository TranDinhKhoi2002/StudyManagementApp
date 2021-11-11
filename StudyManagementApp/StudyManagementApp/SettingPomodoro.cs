using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyManagementApp
{
  
    public partial class SettingPomodoro : Form
    {
        public static int pomodoro = 25;
        public static int shortbreak = 5;
        public static int longbreak = 15;
        public static int interval = 4;
        public static int notification = 5;
        public static int notification_type = 0;
        public SettingPomodoro()
        {
            InitializeComponent();
            cbbNotification.SelectedIndex = notification_type;
            numPomodoro.Value = pomodoro;
            numShortBreak.Value = shortbreak;
            numLongBreak.Value = longbreak;
            numInterval.Value = interval;
            numNotification.Value = notification;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (numPomodoro.Value != 25 && numPomodoro.Value > 0)
            {
                pomodoro = Int32.Parse(numPomodoro.Value.ToString());
            }
            else
            {
                pomodoro = 25;
            }

            if (numShortBreak.Value != 25 && numShortBreak.Value > 0)
            {
                shortbreak = Int32.Parse(numShortBreak.Value.ToString());
            }
            else
            {
                shortbreak = 5;
            }

            if (numLongBreak.Value != 25 && numLongBreak.Value > 0)
            {
                longbreak = Int32.Parse(numLongBreak.Value.ToString());
            }
            else
            {
                longbreak = 15;
            }

            if (numInterval.Value != 25 && numInterval.Value > 0)
            {
                interval = Int32.Parse(numInterval.Value.ToString());
            }
            else
            {
                interval = 4;
            }

            if (numNotification.Value != 25 && numNotification.Value > 0)
            {
                notification = Int32.Parse(numNotification.Value.ToString());
            }
            else
            {
                notification = 5;
            }

            notification_type = cbbNotification.SelectedIndex;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            pomodoro = 25;
            shortbreak = 5;
            longbreak = 15;
            interval = 4;
            notification = 5;
            notification_type = 0;

            this.Close();
        }
    }
}
