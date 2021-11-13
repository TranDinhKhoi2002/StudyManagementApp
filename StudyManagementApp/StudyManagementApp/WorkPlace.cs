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
    public partial class WorkPlace : Form
    {
       
        public WorkPlace()
        {
            InitializeComponent();
            HideAllSubMenu();
           

            WorkPlacePanel.Visible = true;
            aboutUC1.Visible = false;
            helpUC1.Visible = false;
        }

        //Khi tắt workplace thì làm gì?
        private void WorkPlace_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        

        /*---------------------------------Điều khiển các item trong menu bên trái---------------------------------*/
        //Hàm dấu tất cả các subMenu_panel
        void HideAllSubMenu()
        {
            //Code giấu
            SubTableMenu_panel.Visible = false;
            SubToDoListMenu_panel.Visible = false;
            SubFreeStyleMenu_panel.Visible = false;
            //Code để icon tam giác trong các iconButton quay qua bên phải
            TableMenu_iconButton.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            ToDoListMenu_iconButton.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            FreeStyleMenu_iconButton.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
        }
        //Hàm hiện 1 subMenu_panel được truyền vào
        void ShowSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideAllSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        //Khi click Table_menu_iconButton thì làm gì?
        private void TableMenu_iconButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(SubTableMenu_panel);
            if (SubTableMenu_panel.Visible == true)
                TableMenu_iconButton.IconChar = FontAwesome.Sharp.IconChar.CaretDown;
            else
                TableMenu_iconButton.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
        }
        //Khi click ToDoList_menu_iconButton thì làm gì?
        private void ToDoListMenu_iconButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(SubToDoListMenu_panel);
            if (SubToDoListMenu_panel.Visible == true)
                ToDoListMenu_iconButton.IconChar = FontAwesome.Sharp.IconChar.CaretDown;
            else
                ToDoListMenu_iconButton.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
        }
        //Khi click FreeStyle_menu_iconButton thì làm gì?
        private void FreeStyleMenu_iconButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(SubFreeStyleMenu_panel);
            if (SubFreeStyleMenu_panel.Visible == true)
                FreeStyleMenu_iconButton.IconChar = FontAwesome.Sharp.IconChar.CaretDown;
            else
                FreeStyleMenu_iconButton.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
        }
        /*---------------------------------Điều khiển các item trong menu bên trái---------------------------------*/


        /*---------------------------------Chức năng 3 nút home, about, help---------------------------------*/
        //Khai báo 3 biến đánh dấu các nút được click chưa hay chưa?
        bool isHomeClick = true;
        bool isAboutClick = false;
        bool isHelpClick = false;
        //Nhấn Home thì làm gì?
        private void Home_iconButton_Click(object sender, EventArgs e)
        {
            if (isHomeClick)
            {
                return;
            }
            else
            {
                WorkPlacePanel.Visible = true;
                isHomeClick = true;
                Home_iconButton.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\clicked home.png");
                if (isAboutClick)
                {
                   
                    aboutUC1.Visible = false;
                    isAboutClick = false;
                    About_iconButton.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\about.png");
                }
                if (isHelpClick)
                {
                    
                    helpUC1.Visible = false;
                    isHelpClick = false;
                    Help_iconButton.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\help.png");
                }
            }
        }
        //Nhấn About thì làm gì?
        private void About_iconButton_Click(object sender, EventArgs e)
        {
            if (isAboutClick)
                return;
            else
            {
                aboutUC1.Visible = true;
                isAboutClick = true;
                About_iconButton.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\clicked about.png");
                if (isHomeClick)
                {
                    WorkPlacePanel.Visible = false;
                    isHomeClick = false;
                    Home_iconButton.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\home.png");
                }
                if (isHelpClick)
                {
                    helpUC1.Visible = false;
                    isHelpClick = false;
                    Help_iconButton.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\help.png");
                }
            }
        }
        //Nhấn Help thì làm gì?
        private void Help_iconButton_Click(object sender, EventArgs e)
        {
            if (isHelpClick)
                return;
            else
            {
                helpUC1.Visible = true;
                isHelpClick = true;
                Help_iconButton.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\clicked help.png");
                if (isHomeClick)
                {
                    WorkPlacePanel.Visible = false;
                    isHomeClick = false;
                    Home_iconButton.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\home.png");
                }
                if (isAboutClick)
                {
                    aboutUC1.Visible = false;
                    isAboutClick = false;
                    About_iconButton.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\about.png");
                }
               
            }
        }
        /*---------------------------------Chức năng 3 nút home, about, help---------------------------------*/

        /*---------------------------------Pomodoro---------------------------------*/
        //Khai báo các biến cần thiết
        enum PomoState
        {
            Pomodoro,ShortBreak,LongBreak
        }
        int numPomodoro = SettingPomodoro.pomodoro;
        int numShortBreak = SettingPomodoro.shortbreak;
        int numLongBreak = SettingPomodoro.longbreak;
        int numIntervalLongBreak = SettingPomodoro.interval;
        int numNotification = SettingPomodoro.notification;
        int typeNotification = SettingPomodoro.notification_type;
        PomoState pomoState = PomoState.Pomodoro;
        bool isRunning = false;
        //Setting cho pomo nghen
        private void PomodoroSetting_iconButton_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                SettingPomodoro setting = new SettingPomodoro();
                setting.ShowDialog();
                numPomodoro = SettingPomodoro.pomodoro;
                numShortBreak = SettingPomodoro.shortbreak;
                numLongBreak = SettingPomodoro.longbreak;
                numIntervalLongBreak = SettingPomodoro.interval;
                numNotification = SettingPomodoro.notification;
                typeNotification = SettingPomodoro.notification_type;

                if (pomoState == PomoState.Pomodoro)
                {
                    MinutePomo_Label.Text = numPomodoro.ToString();
                }
                else if (pomoState == PomoState.ShortBreak)
                {
                    MinutePomo_Label.Text = numShortBreak.ToString();
                }
                else if (pomoState == PomoState.LongBreak)
                {
                    MinutePomo_Label.Text = numLongBreak.ToString();
                }
                SecondPomo_Label.Text = "00";
            } 
        }
        //Nhấn nút start nghen
        private void Start_Stop_Pomodoro_button_Click(object sender, EventArgs e)
        {
            isRunning = !isRunning;
            if (isRunning)
            {
                Start_Stop_Pomodoro_button.Text = "Stop";
                Pomodoro_Timer.Start();
            }
            else
            {
                Start_Stop_Pomodoro_button.Text = "Start";
                Pomodoro_Timer.Stop();
            }
        }
        //Timmer đếm giờ nghen
        private void Pomodoro_Timer_Tick(object sender, EventArgs e)
        {
            if (int.Parse(SecondPomo_Label.Text) == 0)
            {
                SecondPomo_Label.Text = "59";
                MinutePomo_Label.Text = (int.Parse(MinutePomo_Label.Text) - 1).ToString();
            }
            else
                SecondPomo_Label.Text = (int.Parse(SecondPomo_Label.Text) - 1).ToString();
            if (numPomodoro>numNotification && int.Parse(MinutePomo_Label.Text) != 0)
            {
                if (typeNotification == 0)
                {
                    if (pomoState == PomoState.Pomodoro && int.Parse(MinutePomo_Label.Text) == numNotification && int.Parse(SecondPomo_Label.Text) == 0)
                    {
                        Pomodoro_notifyIcon.Visible = true;
                        Pomodoro_notifyIcon.ShowBalloonTip(5000, "Pomo🍅 nhắc bạn!", numNotification.ToString() + " phút nữa hết giờ học rồi!", ToolTipIcon.Warning);
                        Pomodoro_notifyIcon.Visible = false;

                    }
                }
                else
                {
                    if (pomoState == PomoState.Pomodoro && int.Parse(MinutePomo_Label.Text) % numNotification == (numPomodoro - numNotification) % numNotification && int.Parse(SecondPomo_Label.Text) == 0)
                    {
                        Pomodoro_notifyIcon.Visible = true;
                        Pomodoro_notifyIcon.ShowBalloonTip(5000, "Pomo🍅 nhắc bạn!", "Đã qua " + numNotification.ToString() + " phút rồi đó!", ToolTipIcon.Warning);
                        Pomodoro_notifyIcon.Visible = false;
                    }
                }
            }
            
            if (int.Parse(MinutePomo_Label.Text) == 0 && int.Parse(SecondPomo_Label.Text) == 0)
            {
                Pomodoro_Timer.Stop();
                if (pomoState == PomoState.Pomodoro)
                {
                    PomodoroCount_Label.Text = (int.Parse(PomodoroCount_Label.Text) + 1).ToString();
                    if (int.Parse(PomodoroCount_Label.Text) % numIntervalLongBreak == 0)
                        pomoState = PomoState.LongBreak;
                    else
                        pomoState = PomoState.ShortBreak;
                }
                else if (pomoState == PomoState.ShortBreak)
                {
                    ShortBreakCount_Label.Text = (int.Parse(ShortBreakCount_Label.Text) + 1).ToString();
                    pomoState = PomoState.Pomodoro;
                }
                else if (pomoState == PomoState.LongBreak)
                {
                    LongBreakCount_Label.Text = (int.Parse(LongBreakCount_Label.Text) + 1).ToString();
                    pomoState = PomoState.Pomodoro;
                }

                if (pomoState == PomoState.Pomodoro)
                {
                    MinutePomo_Label.Text = numPomodoro.ToString();
                    Pomo_PictureBox.Image = new Bitmap(Application.StartupPath + "\\Resources\\Images\\TomatoRed.png");
                    //225, 97, 111
                    MinutePomo_Label.BackColor = Color.FromArgb(225, 97, 111);
                    SecondPomo_Label.BackColor = Color.FromArgb(225, 97, 111);
                    HaiCham_Label.BackColor = Color.FromArgb(225, 97, 111);
                    NextStatePomo_iconButton.BackColor = Color.FromArgb(225, 97, 111);

                    Pomodoro_notifyIcon.Visible = true;
                    Pomodoro_notifyIcon.ShowBalloonTip(5000, "Pomo🍅 nhắc bạn!", "Đến giờ tập trung rồi!", ToolTipIcon.Warning);
                    Pomodoro_notifyIcon.Visible = false;
                    Pomodoro_Timer.Start();
                }
                else if (pomoState == PomoState.ShortBreak)
                {
                    MinutePomo_Label.Text = numShortBreak.ToString();
                    Pomo_PictureBox.Image = new Bitmap(Application.StartupPath + "\\Resources\\Images\\TomatoGreen.png");
                    //85, 145, 150
                    MinutePomo_Label.BackColor = Color.FromArgb(85, 145, 150);
                    SecondPomo_Label.BackColor = Color.FromArgb(85, 145, 150);
                    HaiCham_Label.BackColor = Color.FromArgb(85, 145, 150);
                    NextStatePomo_iconButton.BackColor = Color.FromArgb(85, 145, 150);

                    Pomodoro_notifyIcon.Visible = true;
                    Pomodoro_notifyIcon.ShowBalloonTip(5000, "Pomo🍅 nhắc bạn!", "Hãy nghỉ ngơi chút nào!", ToolTipIcon.Warning);
                    Pomodoro_notifyIcon.Visible = false;

                    Pomodoro_Timer.Start();
                }
                else if (pomoState == PomoState.LongBreak)
                {
                    MinutePomo_Label.Text = numLongBreak.ToString();
                    Pomo_PictureBox.Image = new Bitmap(Application.StartupPath + "\\Resources\\Images\\TomatoBlue.png");
                    //76,124,164
                    MinutePomo_Label.BackColor = Color.FromArgb(76, 124, 164);
                    SecondPomo_Label.BackColor = Color.FromArgb(76, 124, 164);
                    HaiCham_Label.BackColor = Color.FromArgb(76, 124, 164);
                    NextStatePomo_iconButton.BackColor = Color.FromArgb(76, 124, 164);

                    Pomodoro_notifyIcon.Visible = true;
                    Pomodoro_notifyIcon.ShowBalloonTip(5000, "Pomo🍅 nhắc bạn!", "Đến lúc giải lao rồi!", ToolTipIcon.Warning);
                    Pomodoro_notifyIcon.Visible = false;

                    Pomodoro_Timer.Start();
                }
                SecondPomo_Label.Text = "00";
            }
        }
        //chuyển state pomo nghen
        private void NextStatePomo_iconButton_Click(object sender, EventArgs e)
        {
            if(!isRunning)
            {
                if (pomoState == PomoState.Pomodoro)
                {
                    PomodoroCount_Label.Text = (int.Parse(PomodoroCount_Label.Text) + 1).ToString();
                    if (int.Parse(PomodoroCount_Label.Text) % numIntervalLongBreak == 0)
                        pomoState = PomoState.LongBreak;
                    else
                        pomoState = PomoState.ShortBreak;
                }
                else if (pomoState == PomoState.ShortBreak)
                {
                    ShortBreakCount_Label.Text = (int.Parse(ShortBreakCount_Label.Text) + 1).ToString();
                    pomoState = PomoState.Pomodoro;
                }
                else if (pomoState == PomoState.LongBreak)
                {
                    LongBreakCount_Label.Text = (int.Parse(LongBreakCount_Label.Text) + 1).ToString();
                    pomoState = PomoState.Pomodoro;
                }

                if (pomoState == PomoState.Pomodoro)
                {
                    MinutePomo_Label.Text = numPomodoro.ToString();
                    Pomo_PictureBox.Image = new Bitmap(Application.StartupPath + "\\Resources\\Images\\TomatoRed.png");
                    //225, 97, 111
                    MinutePomo_Label.BackColor = Color.FromArgb(225, 97, 111);
                    SecondPomo_Label.BackColor = Color.FromArgb(225, 97, 111);
                    HaiCham_Label.BackColor = Color.FromArgb(225, 97, 111);
                    NextStatePomo_iconButton.BackColor = Color.FromArgb(225, 97, 111);

                    Pomodoro_notifyIcon.ShowBalloonTip(5000, "Pomo🍅 nhắc bạn!", "Đến giờ tập trung rồi!", ToolTipIcon.Warning);
                }
                else if (pomoState == PomoState.ShortBreak)
                {
                    MinutePomo_Label.Text = numShortBreak.ToString();
                    Pomo_PictureBox.Image = new Bitmap(Application.StartupPath + "\\Resources\\Images\\TomatoGreen.png");
                    //85, 145, 150
                    MinutePomo_Label.BackColor = Color.FromArgb(85, 145, 150);
                    SecondPomo_Label.BackColor = Color.FromArgb(85, 145, 150);
                    HaiCham_Label.BackColor = Color.FromArgb(85, 145, 150);
                    NextStatePomo_iconButton.BackColor = Color.FromArgb(85, 145, 150);

                    Pomodoro_notifyIcon.ShowBalloonTip(5000, "Pomo🍅 nhắc bạn!", "Hãy nghỉ ngơi chút nào!", ToolTipIcon.Warning);
                }
                else if (pomoState == PomoState.LongBreak)
                {
                    MinutePomo_Label.Text = numLongBreak.ToString();
                    Pomo_PictureBox.Image = new Bitmap(Application.StartupPath + "\\Resources\\Images\\TomatoBlue.png");
                    //76,124,164
                    MinutePomo_Label.BackColor = Color.FromArgb(76, 124, 164);
                    SecondPomo_Label.BackColor = Color.FromArgb(76, 124, 164);
                    HaiCham_Label.BackColor = Color.FromArgb(76, 124, 164);
                    NextStatePomo_iconButton.BackColor = Color.FromArgb(76, 124, 164);

                    Pomodoro_notifyIcon.ShowBalloonTip(5000, "Pomo🍅 nhắc bạn!", "Đến lúc giải lao rồi!", ToolTipIcon.Warning);
                }
                SecondPomo_Label.Text = "00";
            }    
        }

        /*---------------------------------Pomodoro---------------------------------*/

        private void Edit_iconButton_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.ShowDialog(this);
        }

        /*---------------------------------Background---------------------------------*/

        private void notifyBackground_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void WorkPlace_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            DialogResult dialogResult = MessageBox.Show("Do you want to exit?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.ExitThread();
                Application.Exit(); 
            }
        }

        private void WorkPlace_Load(object sender, EventArgs e)
        {
            UserNameLabel.Text = UserInfo.getInstance().Username;
        }
    }
}
