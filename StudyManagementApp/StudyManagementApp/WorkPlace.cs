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







        //---------------------------------Pomodoro------------------------------------------------------------

        //Tạo đối tượng form setting để lúc nhấn vô biểu tượng sẽ hiện ra
        //Dùng delegate để truyền 5 cái numberupdown, 1 cái combobox từ form setting qua đây để sử lý
        SettingPomodoro setting = new SettingPomodoro();
        bool flag = false; //Bật đúng và sai để khi nhấn biểu tượng setting sẽ đóng form
      
        private void btnSetting_Click(object sender, EventArgs e)
        {
            flag = !flag;
            if (flag)
            {
                setting.Show();
                setting.myData1 = new SettingPomodoro.GETDATA(getValue1);
                setting.myData2 = new SettingPomodoro.GETDATA(getValue2);
                setting.myData3 = new SettingPomodoro.GETDATA(getValue3);
                setting.myData4 = new SettingPomodoro.GETDATA(getValue4);
                setting.myData5 = new SettingPomodoro.GETDATA(getValue5);
                setting.myData6 = new SettingPomodoro.GETDATA(getValue6);

                setting.Show();
                btnStart.Enabled = true;
                btnStop.Enabled = true;

            }
            else
            {
                setting.Hide();
            }
        }


//Khai báo một loạt các biến sẽ dùng, ý tưởng là dùng 3 bộ biến 1,2,3 cho từng cái đếm ngược
//Tạo một static class để xài chung SelectType giữa 2 form
//Khai thác phép chia dư cho 3 để chuyển đổi giữa các loại timer


        public int NotificationType = 0; //Nhận vào chỉ số của các lựa chọn trọng thông báo, (0 là every, 1 là last) từ form setting
        public int NotificationTime = 0; //Nhận vào thời gian thông báo từ form setting
        public int LongBreakInterval = 0;//Nhận vào số pomo sẽ thực hiện sau đó ngắt ra tới long break và quay về lại pomo
        public int TempMin1 = 0, TempMin2 = 3, TempMin3 = 0; //Lưu giá trị nhận từ form kia để lát đếm ngược
        public int ConstantMin1 = 0, ConstantMin2 = 0, ConstantMin3 = 0; //Lưu giá trị y như trên nhưng sẽ không đổi, để có cái mà lặp lại tự động
        private int mins = 0 , seconds = 0; //2 biến để đếm ngược thời gian
        
        public void getValue1(string value)
        {
            if (ShareVar.SelectType % 3 == 0)
                labelTimer.Text = string.Format("{0}:{1}", formatMinute(int.Parse(value)), formatMinute(0));          
            TempMin1 = int.Parse(value);
            ConstantMin1 = int.Parse(value);
            btnStart.Enabled = true;
        }
        public void getValue2(string value)
        {
            if (ShareVar.SelectType % 3 == 1)
                labelTimer.Text = string.Format("{0}:{1}", formatMinute(int.Parse(value)), formatMinute(0));

            TempMin2 = int.Parse(value);
            ConstantMin2 = int.Parse(value);
            btnStart.Enabled = true;
        }
        public void getValue3(string value)
        {
            if(ShareVar.SelectType % 3 == 2)
                     labelTimer.Text = string.Format("{0}:{1}", formatMinute(int.Parse(value)), formatMinute(0));
            TempMin3 = int.Parse(value);
            ConstantMin3 = int.Parse(value);
            btnStart.Enabled = true;

        }
        public void getValue4(string value)
        {
            LongBreakInterval = int.Parse(value);
        }
        public void getValue5(string value)
        {
            NotificationTime = int.Parse(value);
            
        }
        public void getValue6(string value)
        {
            NotificationType = int.Parse(value);
        }

 //Click vào start thì sẽ bắt đầu đếm ngược, chỉ nhấn được 1 lần
 //Muốn nhấn lại thì phải apply lại setting mới
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnStart.Enabled = false;
            if (TempMin1 < 1 && TempMin2 < 1 && TempMin3 < 1)
                {
                    MessageBox.Show("PLEASE SET TIMER", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
               else
                {
                  
                    if(ShareVar.SelectType % 3 == 0)
                        mins = (int)TempMin1;
                    if (ShareVar.SelectType % 3 == 1)
                        mins = (int)TempMin2;
                    if (ShareVar.SelectType % 3 == 2)
                        mins = (int)TempMin3;
                    //Nhận vào 3 cái thời gian trong NumbericUpDown từ form setting
                }
           
        }
        private string formatMinute(int s)
        {
            string t = s.ToString();
            return s < 10 ? "0" + t : t;
        }//Format cho thời gian có dạng 00:00


        public bool flag1 = true;      //Xử lý nút stop/continue, nhấn nhiều lần sẽ luân phiên
        private void button1_Click_1(object sender, EventArgs e)
        {
            flag1 = !flag1;
            if (flag1)
            {
                timer1.Stop();
                btnNext.Enabled = true;
            }
            else
            {
                timer1.Start();
                btnNext.Enabled = false;
            }
        }

        int CountPomodoro = 0, CountShort = 0, CountLong = 0; //Biến để đếm số Pomo, Số Long, Số Short
        int countLeftTime = 0; // Biến để đếm thời gian còn lại, dùng cho thông báo last
        int CountPomo = 0; //Biến để đếm thời gian đã trôi qua, dùng cho thông báo every
        
        
        
 //****Cuộc sống gian nan từ đây nè****
 //Xử lý sự kiện tick của timer
        private void timer1_Tick(object sender, EventArgs e)
        {
        

//Code đếm ngược
            if (mins > 0 || seconds > 0)
            {
                if (seconds == 0 && mins > 0)
                {
                    seconds = 59;
                    mins -= 1;
                    countLeftTime++;
                }
                else
                {
                    seconds--;
                }

                //Nếu không nhập thời gian ở chỗ thông báo, sẽ bỏ qua phần này
                if (NotificationTime != 0) 
                {
                    if (NotificationType == 1)
                    {
                        if (countLeftTime == NotificationTime && seconds == 59)
                        {
                            MessageBox.Show(NotificationTime.ToString() + "minute(s) has goneby.", "INFORM", MessageBoxButtons.OK);
                            countLeftTime = 0;
                        }

                    }
                    else
                    {
                        if (mins == NotificationTime - 1 && seconds == 59)
                        {
                            MessageBox.Show((NotificationTime).ToString() + " minute(s) left.", "INFORM", MessageBoxButtons.OK);
                        }
                    }
                }
                
            }
 //Cập nhật nhãn           
            labelTimer.Text = string.Format("{0}:{1}", formatMinute(mins), formatMinute(seconds));


//Phút và giây bằng 0 thì trên đời có 2 thứ xảy ra
//Một là chuyển dạng timer, hai là tăng đếm số lần
            if (mins == 0 && seconds == 0)
            {
                ShareVar.SelectType++;
                CountPomo++;
                if (CountPomo == 1)
                {
                    CountPomodoro++;
                    PomodoroCount_Label.Text = "Pomodoro: " + CountPomodoro.ToString();

                }
                if (ShareVar.SelectType % 3 == 0 && CountPomo > 1 )
                {
                    
                    CountPomodoro++;
                    mins = ConstantMin1;
                    PomodoroCount_Label.Text = "Pomodoro: " + CountPomodoro.ToString();
                    labelTimer.Text = string.Format("{0}:{1}", formatMinute(ConstantMin1), formatMinute(0));
                    
                    this.PomodoroPanel.BackgroundImage = global::StudyManagementApp.Properties.Resources.TomatoRed;
                    this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(120)))));
                    this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(120)))));
                    this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(120)))));

                }
                else if (LongBreakInterval != 0 && CountPomodoro % LongBreakInterval == 0 )
                    {
                        CountLong++;
                        mins = ConstantMin3;
                        LongBreakCount_Label.Text = "Long Break: " + CountLong.ToString();
                        labelTimer.Text = string.Format("{0}:{1}", formatMinute(ConstantMin3), formatMinute(0));

                        this.PomodoroPanel.BackgroundImage = global::StudyManagementApp.Properties.Resources.TomatoBlue;
                        this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(124)))), ((int)(((byte)(164)))));
                        this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(124)))), ((int)(((byte)(164)))));
                        this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(124)))), ((int)(((byte)(164)))));
                    ShareVar.SelectType = 2;
                     
                    } 
                else if (ShareVar.SelectType % 3 == 1)
                    {
                    CountShort++;
                    mins = ConstantMin2;
                    ShortBreakCount_Label.Text = "Short Break: " + CountShort.ToString();
                    labelTimer.Text = string.Format("{0}:{1}", formatMinute(ConstantMin2), formatMinute(0));
                   
                    this.PomodoroPanel.BackgroundImage = global::StudyManagementApp.Properties.Resources.TomatoGreen;
                    this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(145)))), ((int)(((byte)(150)))));
                    this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(145)))), ((int)(((byte)(150)))));
                    this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(145)))), ((int)(((byte)(150)))));
                    ShareVar.SelectType = 2;
                }
                if(ShareVar.SelectType % 3 == 2)
                {

                }    

            }
        }
//Đây là nút Next, nhấn vô sẽ chuyển màu nền, chuyển nhãn, chuyển cái tham số nhận vào
//Chỉ được chuyển khi đã stop, sau khi chuyển thì mọi thứ sẽ theo cái mới
        private void button1_Click(object sender, EventArgs e)
        {
                    
            ShareVar.SelectType++;
            mins = 0;
            seconds = 0;
            if (ShareVar.SelectType % 3 == 0)
            {
                labelTimer.Text = string.Format("{0}:{1}", formatMinute(ConstantMin1), formatMinute(0));
                this.PomodoroPanel.BackgroundImage = global::StudyManagementApp.Properties.Resources.TomatoRed;
                this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(120)))));
                this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(120)))));
                this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(120)))));
            }
            if (ShareVar.SelectType % 3 == 1)
            {
                labelTimer.Text = string.Format("{0}:{1}", formatMinute(ConstantMin2), formatMinute(0));
                this.PomodoroPanel.BackgroundImage = global::StudyManagementApp.Properties.Resources.TomatoGreen;
                this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(145)))), ((int)(((byte)(150)))));
                this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(145)))), ((int)(((byte)(150)))));
                this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(145)))), ((int)(((byte)(150)))));
            }
            if(ShareVar.SelectType % 3 == 2)
            {
                labelTimer.Text = string.Format("{0}:{1}", formatMinute(ConstantMin3), formatMinute(0));
                this.PomodoroPanel.BackgroundImage = global::StudyManagementApp.Properties.Resources.TomatoBlue;
                this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(124)))), ((int)(((byte)(164)))));
                this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(124)))), ((int)(((byte)(164)))));
                this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(124)))), ((int)(((byte)(164)))));
            }
            
        }
    }
}
