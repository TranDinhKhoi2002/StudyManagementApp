using FontAwesome.Sharp;
using StudyManagementApp.DAO;
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
        enum State
        {
            Home, About, Help
        }

        State currentstate_WorkPlace = State.Home;

        public WorkPlace()
        {
            InitializeComponent();
            aboutUC1.Hide();
            helpUC1.Hide();
            HideAllSubMenu();
            Event_LEFTICONMENU();

            todolist_Form.TopLevel = false;
            todolist_Form.Dock = DockStyle.Fill;
            HomePanel.Controls.Add(todolist_Form);

            flashcard_Form.TopLevel = false;
            flashcard_Form.Dock = DockStyle.Fill;
            HomePanel.Controls.Add(flashcard_Form);
        }

        

        //ấy lại hàm show
        public new void Show()
        {
            bang_AllTASK_TDL = DAO.AccountDAO.Instance.GetAll_TASK_TDL(UserInfo.Instance.Username);
            bang_AllTYPEITEM_TDL = DAO.AccountDAO.Instance.GetAll_TYPEITEM_TDL(UserInfo.Instance.Username);
            
            // Todolist
            todolist_Form = new TodolistFolder.Todolist_Form();
            todolist_Form.TopLevel = false;
            todolist_Form.Dock = DockStyle.Fill;
            HomePanel.Controls.Add(todolist_Form);

            // Flashcard
            flashcard_Form = new FlashCardFolder.FlashCardForm();
            flashcard_Form.TopLevel = false;
            flashcard_Form.Dock = DockStyle.Fill;
            HomePanel.Controls.Add(flashcard_Form);

            date_Choosing_ofWeek_ToDoList = DateTime.Now;
            Main_customCalendar = new UserControls.CustomCalendar();
            SETTING_CuonLich();
            UserNameLabel.Text = UserInfo.Instance.Username;
            MoRongLeftMenu_iconButton.Hide();
            KeepFont();
            LoadMau();
            HideAllControlInWorkPlacePanel();
            Main_customCalendar.Show();
            Remind_taskdeadline_timer.Start();
            base.Show();
        }

        //hàm dispose
        public new void Dispose()
        {
            Remind_taskdeadline_timer.Stop();
            base.Dispose();
        }

        //Hàm load
        private void WorkPlace_Load(object sender, EventArgs e)
        {
            SETTING_CuonLich();
            UserNameLabel.Text = UserInfo.Instance.Username;
            bang_AllTASK_TDL = DAO.AccountDAO.Instance.GetAll_TASK_TDL(UserInfo.Instance.Username);
            bang_AllTYPEITEM_TDL = DAO.AccountDAO.Instance.GetAll_TYPEITEM_TDL(UserInfo.Instance.Username);
            HideAllControlInWorkPlacePanel();
            Main_customCalendar.Show();
            MoRongLeftMenu_iconButton.Hide();
        }

        #region DoiTheme
        /*---------------------------------Đổi theme---------------------------------*/
        void KeepFont()
        {
            UserNameLabel.Font = new Font("Agency FB", 13, FontStyle.Bold);
            CalendarButton.Font = new Font("Agency FB", 14, FontStyle.Bold);
            ToDoListMenu_iconButton.Font = new Font("Agency FB", 16, FontStyle.Bold);
            MinutePomo_Label.Font = new Font("Agency FB", 19, FontStyle.Bold);
            HaiCham_Label.Font = new Font("Agency FB", 19, FontStyle.Bold);
            SecondPomo_Label.Font = new Font("Agency FB", 19, FontStyle.Bold);
            Command_TextBox.Font = new Font("Agency FB", 18, FontStyle.Bold);
            NotificationFunctionLabel.Font = new Font("Agency FB", 17, FontStyle.Bold);
            SaveButton.Font = new Font("Agency FB", 12, FontStyle.Bold);
            SaveAsButton.Font = new Font("Agency FB", 12, FontStyle.Bold);
            PomodoroCount_Label.Font = new Font("Agency FB", 10, FontStyle.Bold);
            ShortBreakCount_Label.Font = new Font("Agency FB", 10, FontStyle.Bold);
            LongBreakCount_Label.Font = new Font("Agency FB", 10, FontStyle.Bold);
            Start_Stop_Pomodoro_button.Font = new Font("Agency FB", 13, FontStyle.Bold);
        }

        void HamDoiMau(Color bg, Color x, Color foretemplate, Color forecanlendar)
        {
            this.BackColor = bg;
            BaNut_Panel.BackColor = x;
            WordToolPanel.BackColor = x;
            PassageToolPanel.BackColor = x;
            SaveButtonTablePanel.BackColor = x;
            AddPic_Panel.BackColor = x;

            UserInforPanel.BackColor = x;
            TemplatePanel.BackColor = x;
            PomodoroPanel.BackColor = x;

            CalendarButton.BackColor = foretemplate;
            CalendarButton.ForeColor = forecanlendar;
            CalendarButton.BorderColor = forecanlendar;

            HomePanel.BackColor = forecanlendar;

            //
            //todo
            ToDoListMenu_iconButton.FlatAppearance.MouseOverBackColor = bg;
            ToDoListMenu_iconButton.IconColor = foretemplate;
            ToDoListMenu_iconButton.ForeColor = foretemplate;
            current_todoitem_iconbutton.ForeColor = foretemplate;
            current_todoitem_iconbutton.FlatAppearance.MouseOverBackColor = bg;
            previous_todoitem_iconbutton.ForeColor = foretemplate;
            previous_todoitem_iconbutton.FlatAppearance.MouseOverBackColor = bg;
            next_todoitem_iconbutton.ForeColor = foretemplate;
            next_todoitem_iconbutton.FlatAppearance.MouseOverBackColor = bg;
            progress_todoitem_iconbutton.ForeColor = foretemplate;
            progress_todoitem_iconbutton.FlatAppearance.MouseOverBackColor = bg;
            //

            //
            //note
            NoteMenu_iconButton.FlatAppearance.MouseOverBackColor = bg;
            NoteMenu_iconButton.IconColor = foretemplate;
            NoteMenu_iconButton.ForeColor = foretemplate;
            main_noteitem_iconButton.ForeColor = foretemplate;
            main_noteitem_iconButton.FlatAppearance.MouseOverBackColor = bg;
            //

            //
            //flashcard
            FlashCardMenu_iconButton.FlatAppearance.MouseOverBackColor = bg;
            FlashCardMenu_iconButton.IconColor = foretemplate;
            FlashCardMenu_iconButton.ForeColor = foretemplate;
            main_flashcarditem_iconButton.ForeColor = foretemplate;
            main_flashcarditem_iconButton.FlatAppearance.MouseOverBackColor = bg;
            //

            //
            //relax
            RelaxMenu_iconButton.FlatAppearance.MouseOverBackColor = bg;
            RelaxMenu_iconButton.IconColor = foretemplate;
            RelaxMenu_iconButton.ForeColor = foretemplate;
            hai048_relaxitem_iconbutton.ForeColor = foretemplate;
            hai048_relaxitem_iconbutton.FlatAppearance.MouseOverBackColor = bg;
            flappybird_relaxitem_iconbutton.ForeColor = foretemplate;
            flappybird_relaxitem_iconbutton.FlatAppearance.MouseOverBackColor = bg;
            //

            //
            //ChatBot
            ChatbotMenu_iconButton.FlatAppearance.MouseOverBackColor = bg;
            ChatbotMenu_iconButton.IconColor = foretemplate;
            ChatbotMenu_iconButton.ForeColor = foretemplate;
            start_chatbotitem_iconButton.ForeColor = foretemplate;
            start_chatbotitem_iconButton.FlatAppearance.MouseOverBackColor = bg;
            //
        }

        void LoadMau()
        {
            Start_Stop_Pomodoro_button.BorderColor = Color.FromArgb(225, 97, 111);
            if (Program.Theme == true)
            {
                HamDoiMau(Color.Silver, Color.DarkGray, SacMau.dendam, SacMau.trangvua);
                Logo_PictureBox.Image = new Bitmap(Application.StartupPath + "\\Resources\\Images\\logoTrang.png");

            }
            else
            {
                HamDoiMau(Color.FromArgb(73, 75, 76), SacMau.dennhat, SacMau.trangvua, SacMau.dendam);
                Logo_PictureBox.Image = new Bitmap(Application.StartupPath + "\\Resources\\Images\\Logo.png");

            }
        }
        /*---------------------------------Đổi theme---------------------------------*/
        #endregion

        #region CuonLich

        public static DataTable bang_AllTASK_TDL = new DataTable();
        public static DataTable bang_AllTYPEITEM_TDL = new DataTable();
        public static TodolistFolder.Todolist_Form todolist_Form = new TodolistFolder.Todolist_Form();
        public static DateTime date_Choosing_ofWeek_ToDoList = DateTime.Now;
        public UserControls.CustomCalendar Main_customCalendar = new UserControls.CustomCalendar();
        public static FlashCardFolder.FlashCardForm flashcard_Form = new FlashCardFolder.FlashCardForm();

        private void CalendarButton_Click(object sender, EventArgs e)
        {
            if (Main_customCalendar.Visible)
                Main_customCalendar.Hide();
            else
            {
                HideAllControlInWorkPlacePanel();
                Main_customCalendar.Show();
            }
        }

        void SETTING_CuonLich()
        {
            Main_customCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            Main_customCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            Main_customCalendar.Location = new System.Drawing.Point(0, 0);
            Main_customCalendar.Margin = new System.Windows.Forms.Padding(5);
            Main_customCalendar.Size = new System.Drawing.Size(1079, 504);
            Main_customCalendar.TabIndex = 0;
            HomePanel.Controls.Add(Main_customCalendar);
            Main_customCalendar.Hide();
        }
        #endregion

        #region Thu gọn, mở rộng menu trái
        private void ThuGonTraiButton_Click(object sender, EventArgs e)
        {
            LeftMenuTablePanel.Hide();
            Leftmenu_panel.Width = 50;
            MoRongLeftMenu_iconButton.Show();
        }

        private void MoRongLeftMenu_iconButton_Click(object sender, EventArgs e)
        {
            Leftmenu_panel.Width = 251;
            LeftMenuTablePanel.Show();
            MoRongLeftMenu_iconButton.Hide();
        }
        #endregion

        #region MenuBenTrai
        /*---------------------------------Điều khiển các item trong menu bên trái---------------------------------*/
        //Hàm dấu tất cả các subMenu_panel
        void HideAllSubMenu()
        {
            ToDoListMenu_iconButton.IconChar = IconChar.CaretRight;
            NoteMenu_iconButton.IconChar = IconChar.CaretRight;
            FlashCardMenu_iconButton.IconChar = IconChar.CaretRight;
            RelaxMenu_iconButton.IconChar = IconChar.CaretRight;
            ChatbotMenu_iconButton.IconChar = IconChar.CaretRight;
            TodoLIst_SubMenu_Panel.Hide();
            Note_SubMenu_Panel.Hide();
            FlashCard_SubMenu_Panel.Hide();
            Relax_SubMenu_Panel.Hide();
            Chatbot_submenu_panel.Hide();
        }
        //Hàm hiện 1 subMenu_panel được truyền vào
        void ShowSubMenu(Panel submenu, IconButton iconmenu)
        {
            if (submenu.Visible != true)
            {
                HideAllSubMenu();
                submenu.Show();
                iconmenu.IconChar = IconChar.CaretDown;
            }
            else
            {
                submenu.Hide();
                iconmenu.IconChar = IconChar.CaretRight;
            }
        }

        void Event_LEFTICONMENU()
        {
            this.ToDoListMenu_iconButton.Click += new System.EventHandler(this.ToDoListMenu_iconButton_Click);
            this.NoteMenu_iconButton.Click += new System.EventHandler(this.ToDoListMenu_iconButton_Click);
            this.FlashCardMenu_iconButton.Click += new System.EventHandler(this.ToDoListMenu_iconButton_Click);
            this.RelaxMenu_iconButton.Click += new System.EventHandler(this.ToDoListMenu_iconButton_Click);
            this.ChatbotMenu_iconButton.Click+= new System.EventHandler(this.ToDoListMenu_iconButton_Click);
        }

        //Current, Previous, Next, Progress-click
        private void Current_todoitem_iconbutton_Click(object sender, EventArgs e)
        {
            IconButton iconButton = sender as IconButton;
            switch (iconButton.Text)
            {
                case "Current":
                    HideAllControlInWorkPlacePanel();
                    date_Choosing_ofWeek_ToDoList = DateTime.Now;
                    todolist_Form.Show(date_Choosing_ofWeek_ToDoList);
                    break;
                case "Previous":
                    date_Choosing_ofWeek_ToDoList = date_Choosing_ofWeek_ToDoList.AddDays(-7);
                    HideAllControlInWorkPlacePanel();
                    todolist_Form.Show(date_Choosing_ofWeek_ToDoList);
                    break;
                case "Next":
                    date_Choosing_ofWeek_ToDoList = date_Choosing_ofWeek_ToDoList.AddDays(7);
                    HideAllControlInWorkPlacePanel();
                    todolist_Form.Show(date_Choosing_ofWeek_ToDoList);
                    break;
                case "Progress":
                    ProgressForm progress = new ProgressForm();
                    progress.ShowDialog();
                    break;
                default:
                    break;
            }
        }
        //2048, flappy bird-click
        private void hai048_relaxitem_iconbutton_Click(object sender, EventArgs e)
        {
            IconButton iconButton = sender as IconButton;
            switch (iconButton.Text)
            {
                case "2048":
                    Game2048 game = new Game2048();
                    game.ShowDialog();
                    break;
                case "Flappy bird":
                    lbStart gameFlappyBird = new lbStart();
                    gameFlappyBird.ShowDialog();
                    break;
                default:
                    break;
            }
        }
        //main của note click
        private void main_noteitem_iconButton_Click(object sender, EventArgs e)
        {
            IconButton iconButton = sender as IconButton;
            switch (iconButton.Text)
            {
                case "Main":
                    //Huy's code
                    break;
                default:
                    break;
            }
        }

        //main của flashcard click
        private void main_flashcarditem_iconButton_Click(object sender, EventArgs e)
        {
            IconButton iconButton = sender as IconButton;
            switch (iconButton.Text)
            {
                case "Main":
                    HideAllControlInWorkPlacePanel();
                    flashcard_Form.Show();
                    //Hên's code
                    break;
                default:
                    break;
            }
        }
        //start của chatbot click
        private void start_chatbotitem_iconButton_Click(object sender, EventArgs e)
        {
            IconButton iconButton = sender as IconButton;
            switch (iconButton.Text)
            {
                case "Start":
                    ChatBotForm chatbot = new ChatBotForm();
                    chatbot.ShowDialog();
                    break;
                default:
                    break;
            }
        }

        //icon menu click
        private void ToDoListMenu_iconButton_Click(object sender, EventArgs e)
        {
            IconButton nutClick = sender as IconButton;
            switch (nutClick.Tag.ToString())
            {
                case "Menu1":
                    ShowSubMenu(TodoLIst_SubMenu_Panel, ToDoListMenu_iconButton);
                    break;
                case "Menu2":
                    ShowSubMenu(Note_SubMenu_Panel, NoteMenu_iconButton);
                    break;
                case "Menu3":
                    ShowSubMenu(FlashCard_SubMenu_Panel, FlashCardMenu_iconButton);
                    break;
                case "Menu4":
                    ShowSubMenu(Relax_SubMenu_Panel, RelaxMenu_iconButton);
                    break;
                case "Menu5":
                    ShowSubMenu(Chatbot_submenu_panel, ChatbotMenu_iconButton);
                    break;
            }


        }
        /*---------------------------------Điều khiển các item trong menu bên trái---------------------------------*/
        #endregion

        #region 3nuthome_about_help
        /*---------------------------------Chức năng 3 nút home, about, help---------------------------------*/
        //Nhấn Home thì làm gì?
        private void Home_iconButton_Click(object sender, EventArgs e)
        {
            if (currentstate_WorkPlace == State.Home)
            {
                return;
            }
            else
            {
                if (currentstate_WorkPlace == State.About)
                {
                    aboutUC1.Hide();
                    About_iconButton.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\about.png");
                }
                if (currentstate_WorkPlace == State.Help)
                {

                    helpUC1.Hide();
                    Help_iconButton.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\help.png");
                }
                HomePanel.Show();
                currentstate_WorkPlace = State.Home;
                Home_iconButton.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\clicked home.png");
            }
        }
        //Nhấn About thì làm gì?
        private void About_iconButton_Click(object sender, EventArgs e)
        {
            if (currentstate_WorkPlace == State.About)
                return;
            else
            {
                if (currentstate_WorkPlace == State.Home)
                {
                    HomePanel.Hide();
                    Home_iconButton.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\home.png");
                }
                if (currentstate_WorkPlace == State.Help)
                {
                    helpUC1.Hide();
                    Help_iconButton.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\help.png");
                }
                aboutUC1.Show();
                currentstate_WorkPlace = State.About;
                About_iconButton.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\clicked about.png");

            }
        }
        //Nhấn Help thì làm gì?
        private void Help_iconButton_Click(object sender, EventArgs e)
        {
            if (currentstate_WorkPlace == State.Help)
                return;
            else
            {
                if (currentstate_WorkPlace == State.Home)
                {
                    HomePanel.Hide();
                    Home_iconButton.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\home.png");
                }
                if (currentstate_WorkPlace == State.About)
                {
                    aboutUC1.Hide();
                    About_iconButton.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\about.png");
                }
                helpUC1.Show();
                currentstate_WorkPlace = State.Help;
                Help_iconButton.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\clicked help.png");

            }
        }
        /*---------------------------------Chức năng 3 nút home, about, help---------------------------------*/
        #endregion

        #region Pomodoro
        /*---------------------------------Pomodoro---------------------------------*/
        //Khai báo các biến cần thiết
        enum PomoState
        {
            Pomodoro, ShortBreak, LongBreak
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
                int min = int.Parse(MinutePomo_Label.Text) - 1;
                if (min < 10)
                {
                    MinutePomo_Label.Text = "0" + (min).ToString();
                }
                else
                {
                    MinutePomo_Label.Text = (min).ToString();
                }
            }
            else
            {
                int sec = int.Parse(SecondPomo_Label.Text) - 1;
                if (sec < 10)
                {
                    SecondPomo_Label.Text = "0" + (sec).ToString();
                }
                else
                {
                    SecondPomo_Label.Text = (sec).ToString();
                }
            }
            if (numPomodoro > numNotification && int.Parse(MinutePomo_Label.Text) != 0)
            {
                if (typeNotification == 0)
                {
                    if (pomoState == PomoState.Pomodoro && int.Parse(MinutePomo_Label.Text) == numNotification && int.Parse(SecondPomo_Label.Text) == 0)
                    {
                        Zst_notifyIcon.ShowBalloonTip(5000, "Pomo🍅 nhắc bạn!", numNotification.ToString() + " phút nữa hết giờ học rồi!", ToolTipIcon.Warning);

                    }
                }
                else
                {
                    if (pomoState == PomoState.Pomodoro && int.Parse(MinutePomo_Label.Text) % numNotification == (numPomodoro - numNotification) % numNotification && int.Parse(SecondPomo_Label.Text) == 0)
                    {

                        Zst_notifyIcon.ShowBalloonTip(5000, "Pomo🍅 nhắc bạn!", "Đã qua " + numNotification.ToString() + " phút rồi đó!", ToolTipIcon.Warning);
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


                    Zst_notifyIcon.ShowBalloonTip(5000, "Pomo🍅 nhắc bạn!", "Đến giờ tập trung rồi!", ToolTipIcon.Warning);

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


                    Zst_notifyIcon.ShowBalloonTip(5000, "Pomo🍅 nhắc bạn!", "Hãy nghỉ ngơi chút nào!", ToolTipIcon.Warning);


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


                    Zst_notifyIcon.ShowBalloonTip(5000, "Pomo🍅 nhắc bạn!", "Đến lúc giải lao rồi!", ToolTipIcon.Warning);


                    Pomodoro_Timer.Start();
                }
                SecondPomo_Label.Text = "00";
            }
        }
        //chuyển state pomo nghen
        private void NextStatePomo_iconButton_Click(object sender, EventArgs e)
        {
            if (!isRunning)
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

                    Zst_notifyIcon.ShowBalloonTip(5000, "Pomo🍅 nhắc bạn!", "Đến giờ tập trung rồi!", ToolTipIcon.Warning);
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

                    Zst_notifyIcon.ShowBalloonTip(5000, "Pomo🍅 nhắc bạn!", "Hãy nghỉ ngơi chút nào!", ToolTipIcon.Warning);
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

                    Zst_notifyIcon.ShowBalloonTip(5000, "Pomo🍅 nhắc bạn!", "Đến lúc giải lao rồi!", ToolTipIcon.Warning);
                }
                SecondPomo_Label.Text = "00";
            }
        }

        #endregion

        #region FormEdit

        /*---------------------------------Edit---------------------------------*/
        private void Edit_iconButton_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.ShowDialog(this);
        }
        #endregion

        #region ChayNen
        /*---------------------------------Background---------------------------------*/

        private void NotifyBackground_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void WorkPlace_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.IsBackgroundRunningEnable)
            {
                this.Hide();
                e.Cancel = true;
            }
            else
            {
                Program.globalLogin.Show();
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            DialogResult dialogResult = MessageBox.Show("Do you want to exit?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.ExitThread();
                Application.Exit();
            }
        }
        #endregion

        #region CommandTextBox
        /*---------------------------------Command_textbox---------------------------------*/
        private void Command_TextBox_Enter(object sender, EventArgs e)
        {
            if (Command_TextBox.Text == "Enter Command")
            {
                Command_TextBox.ForeColor = Color.FromArgb(47, 52, 55);
                Command_TextBox.Text = "";
            }
        }

        private void Command_TextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Command_TextBox.Text))
            {
                Command_TextBox.ForeColor = Color.DarkGray;
                Command_TextBox.Text = "Enter Command";
            }
        }



        #endregion


        #region HideAllControlInHomePanel
        void HideAllControlInWorkPlacePanel()
        {
            if (currentstate_WorkPlace != State.Home)
            {
                if (currentstate_WorkPlace == State.About)
                {
                    aboutUC1.Hide();
                    About_iconButton.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\about.png");
                }
                if (currentstate_WorkPlace == State.Help)
                {

                    helpUC1.Hide();
                    Help_iconButton.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\help.png");
                }
                HomePanel.Show();
                currentstate_WorkPlace = State.Home;
                Home_iconButton.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\clicked home.png");
            }
            foreach (Control item in HomePanel.Controls)
            {
                item.Hide();
            }
        }

        #endregion

        #region Nhắc nhở deadline của task
        private void Remind_taskdeadline_timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < WorkPlace.bang_AllTASK_TDL.Rows.Count; i++)
            {
                DateTime datetimeNOTI = (DateTime)WorkPlace.bang_AllTASK_TDL.Rows[i]["DATETIMENOTI"];
                DateTime current = DateTime.Now;
                if (datetimeNOTI.Day == current.Day && datetimeNOTI.Month == current.Month && datetimeNOTI.Year == current.Year && datetimeNOTI.Hour == current.Hour && datetimeNOTI.Minute == current.Minute && current.Second == 0)
                {
                    if ((bool)WorkPlace.bang_AllTASK_TDL.Rows[i]["DONE"] == false)
                    {
                        string taskname = WorkPlace.bang_AllTASK_TDL.Rows[i]["TASKNAME"].ToString();
                        DateTime datetimeDeadline = (DateTime)WorkPlace.bang_AllTASK_TDL.Rows[i]["DATETIMEDEADLINE"];
                        string type;
                        for (int j = 0; j < WorkPlace.bang_AllTYPEITEM_TDL.Rows.Count; j++)
                        {
                            if (WorkPlace.bang_AllTASK_TDL.Rows[i]["PK_COLOR"].ToString() == WorkPlace.bang_AllTYPEITEM_TDL.Rows[j]["PK_COLOR"].ToString())
                            {
                                type = WorkPlace.bang_AllTYPEITEM_TDL.Rows[j]["NAMETYPE"].ToString();
                    
                                Zst_notifyIcon.ShowBalloonTip(5000, "Z-st nhắc bạn!", "Task: " + taskname + "\n-Deadline:\n   Day: " + datetimeDeadline.ToString("dddd, dd MMMM yyyy") + "\n   Time: " + datetimeDeadline.ToString("hh:mm tt") + "\n-Task's type: " + type, ToolTipIcon.Warning);
                                break;
                            }
                        }
                    }
                }
            }

        }

        #endregion

        
    }
}
