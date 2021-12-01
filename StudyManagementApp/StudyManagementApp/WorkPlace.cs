using FontAwesome.Sharp;
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
            KhoiTaoCacIconMenu();
            ThemItemVaoSubMenu(Relax_SubMenu_Panel, SubMenuRelax_Item, relax_item);
            ThemItemVaoSubMenu(TodoLIst_SubMenu_Panel, SubMenuTodo_Item, todo_item);
            todolist_Form.TopLevel = false;
            todolist_Form.Dock = DockStyle.Fill;
            HomePanel.Controls.Add(todolist_Form);
        }

        //ấy lại hàm show
        public new void Show()
        {
            KeepFont();
            LoadMau();
            base.Show();
        }

        //Hàm load
        private void WorkPlace_Load(object sender, EventArgs e)
        {
            KhoiTaoCuonLich();
            UserNameLabel.Text = UserInfo.Instance.Username;
            bang_AllTASK_TDL = DAO.AccountDAO.Instance.GetAll_TASK_TDL(UserInfo.Instance.Username);
            bang_AllTYPEITEM_TDL = DAO.AccountDAO.Instance.GetAll_TYPEITEM_TDL(UserInfo.Instance.Username);

        }

        //Khi tắt workplace thì làm gì?
        private void WorkPlace_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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


            ToDoListMenu_iconButton.FlatAppearance.MouseOverBackColor = bg;

            ToDoListMenu_iconButton.IconColor = foretemplate;

            ToDoListMenu_iconButton.ForeColor = foretemplate;


            CalendarButton.BackColor = foretemplate;
            CalendarButton.ForeColor = forecanlendar;
            CalendarButton.BorderColor = forecanlendar;

            HomePanel.BackColor = forecanlendar;

            LayMauChoCacItem(SubMenuRelax_Item, foretemplate, bg);
            LayMauChoCacItem(SubMenuTodo_Item, foretemplate, bg);
            
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
       
        void KhoiTaoCuonLich()
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

        #region MenuBenTrai
        /*---------------------------------Điều khiển các item trong menu bên trái---------------------------------*/
        //Hàm dấu tất cả các subMenu_panel
        void HideAllSubMenu()
        {
            ToDoListMenu_iconButton.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            NoteMenu_iconButton.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            FlashCardMenu_iconButton.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            RelaxMenu_iconButton.IconChar = FontAwesome.Sharp.IconChar.CaretRight;

            TodoLIst_SubMenu_Panel.Hide();
            Note_SubMenu_Panel.Hide();
            FlashCard_SubMenu_Panel.Hide();
            Relax_SubMenu_Panel.Hide();

        }
        //Hàm hiện 1 subMenu_panel được truyền vào
        void ShowSubMenu(Panel submenu,IconButton iconmenu)
        {
            if (!submenu.Visible)
            {
                HideAllSubMenu();
                submenu.Hide();
                iconmenu.IconChar = IconChar.CaretDown;
            }
           else
            {
                submenu.Show();
                iconmenu.IconChar = IconChar.CaretRight;
            }
        }

        void LayMauChoCacItem(List<IconButton> item, Color fore, Color over)
        {
            for (int i = 0; i < item.Count; i++)
            {
                item[i].FlatAppearance.MouseOverBackColor = over;
                item[i].ForeColor = fore;
            }
        }
        //IconMenu
        IconButton ToDoListMenu_iconButton = new IconButton();
        IconButton RelaxMenu_iconButton = new IconButton();
        IconButton FlashCardMenu_iconButton = new IconButton();
        IconButton NoteMenu_iconButton = new IconButton();
        void KhoiTaoCacIconMenu()
        {
            // 
            // ToDoListMenu_iconButton
            // 
            this.ToDoListMenu_iconButton.BackColor = System.Drawing.Color.Transparent;
            this.ToDoListMenu_iconButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToDoListMenu_iconButton.FlatAppearance.BorderSize = 0;
            this.ToDoListMenu_iconButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            this.ToDoListMenu_iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToDoListMenu_iconButton.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDoListMenu_iconButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ToDoListMenu_iconButton.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            this.ToDoListMenu_iconButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ToDoListMenu_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ToDoListMenu_iconButton.IconSize = 40;
            this.ToDoListMenu_iconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToDoListMenu_iconButton.Location = new System.Drawing.Point(0, 0);
            this.ToDoListMenu_iconButton.Margin = new System.Windows.Forms.Padding(0);
            this.ToDoListMenu_iconButton.Name = "ToDoListMenu_iconButton";
            this.ToDoListMenu_iconButton.Size = new System.Drawing.Size(251, 46);
            this.ToDoListMenu_iconButton.TabIndex = 1;
            this.ToDoListMenu_iconButton.Tag = "Menu1";
            this.ToDoListMenu_iconButton.Text = "To-do list";
            this.ToDoListMenu_iconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToDoListMenu_iconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ToDoListMenu_iconButton.UseVisualStyleBackColor = false;
            this.ToDoListMenu_iconButton.Click += new System.EventHandler(this.ToDoListMenu_iconButton_Click);
            // 
            // NoteMenu_iconButton
            // 
            this.NoteMenu_iconButton.BackColor = System.Drawing.Color.Transparent;
            this.NoteMenu_iconButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.NoteMenu_iconButton.FlatAppearance.BorderSize = 0;
            this.NoteMenu_iconButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            this.NoteMenu_iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoteMenu_iconButton.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteMenu_iconButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.NoteMenu_iconButton.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            this.NoteMenu_iconButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.NoteMenu_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.NoteMenu_iconButton.IconSize = 40;
            this.NoteMenu_iconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NoteMenu_iconButton.Location = new System.Drawing.Point(0, 0);
            this.NoteMenu_iconButton.Margin = new System.Windows.Forms.Padding(0);
            this.NoteMenu_iconButton.Name = "NoteMenu_iconButton";
            this.NoteMenu_iconButton.Size = new System.Drawing.Size(251, 46);
            this.NoteMenu_iconButton.TabIndex = 2;
            this.NoteMenu_iconButton.Tag = "Menu2";
            this.NoteMenu_iconButton.Text = "Note";
            this.NoteMenu_iconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NoteMenu_iconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NoteMenu_iconButton.UseVisualStyleBackColor = false;
            this.NoteMenu_iconButton.Click += new System.EventHandler(this.ToDoListMenu_iconButton_Click);
            // 
            // FlashCardMenu_iconButton
            // 
            this.FlashCardMenu_iconButton.BackColor = System.Drawing.Color.Transparent;
            this.FlashCardMenu_iconButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.FlashCardMenu_iconButton.FlatAppearance.BorderSize = 0;
            this.FlashCardMenu_iconButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            this.FlashCardMenu_iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlashCardMenu_iconButton.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlashCardMenu_iconButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.FlashCardMenu_iconButton.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            this.FlashCardMenu_iconButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.FlashCardMenu_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FlashCardMenu_iconButton.IconSize = 40;
            this.FlashCardMenu_iconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FlashCardMenu_iconButton.Location = new System.Drawing.Point(0, 0);
            this.FlashCardMenu_iconButton.Margin = new System.Windows.Forms.Padding(0);
            this.FlashCardMenu_iconButton.Name = "FlashCardMenu_iconButton";
            this.FlashCardMenu_iconButton.Size = new System.Drawing.Size(251, 46);
            this.FlashCardMenu_iconButton.TabIndex = 3;
            this.FlashCardMenu_iconButton.Tag = "Menu3";
            this.FlashCardMenu_iconButton.Text = "FlashCard";
            this.FlashCardMenu_iconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FlashCardMenu_iconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FlashCardMenu_iconButton.UseVisualStyleBackColor = false;
            this.FlashCardMenu_iconButton.Click += new System.EventHandler(this.ToDoListMenu_iconButton_Click);
            // 
            // RelaxMenu_iconButton
            // 
            this.RelaxMenu_iconButton.BackColor = System.Drawing.Color.Transparent;
            this.RelaxMenu_iconButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RelaxMenu_iconButton.FlatAppearance.BorderSize = 0;
            this.RelaxMenu_iconButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            this.RelaxMenu_iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RelaxMenu_iconButton.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelaxMenu_iconButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.RelaxMenu_iconButton.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            this.RelaxMenu_iconButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.RelaxMenu_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RelaxMenu_iconButton.IconSize = 40;
            this.RelaxMenu_iconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RelaxMenu_iconButton.Location = new System.Drawing.Point(0, 0);
            this.RelaxMenu_iconButton.Margin = new System.Windows.Forms.Padding(0);
            this.RelaxMenu_iconButton.Name = "RelaxMenu_iconButton";
            this.RelaxMenu_iconButton.Size = new System.Drawing.Size(251, 46);
            this.RelaxMenu_iconButton.TabIndex = 4;
            this.RelaxMenu_iconButton.Tag = "Menu4";
            this.RelaxMenu_iconButton.Text = "Relax";
            this.RelaxMenu_iconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RelaxMenu_iconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RelaxMenu_iconButton.UseVisualStyleBackColor = false;
            this.RelaxMenu_iconButton.Click += new System.EventHandler(this.ToDoListMenu_iconButton_Click);

            //Them menuiconbutton
            ToDoList_Menu_Panel.Controls.Add(ToDoListMenu_iconButton);
            Note_Menu_Panel.Controls.Add(NoteMenu_iconButton);
            FlashCard_Menu_Panel.Controls.Add(FlashCardMenu_iconButton);
            Relax_Menu_Panel.Controls.Add(RelaxMenu_iconButton);
        }

        //
        //Todo
        //
        static List<IconButton> SubMenuTodo_Item = new List<IconButton>();
        static string[] todo_item = { "Previous", "Next", "Current" };
        //
        //Todo
        //

        //
        //Relax
        //
        static List<IconButton> SubMenuRelax_Item = new List<IconButton>();
        static string[] relax_item = { "Flappy Bird", "2048" };
        //
        //Relax
        //

        //Submenu item click của 4 dạng luôn
        void ALL_SubMenu_Item_Click(IconButton nut)
        {
            if (nut.Tag.ToString() == "todo")
            {
                if (nut.Text.Trim() == todo_item[2])
                {
                    HideAllControlInWorkPlacePanel();
                    todolist_Form.Show(date_Choosing_ofWeek_ToDoList);
                }
                if (nut.Text.Trim() == todo_item[1])
                {
                    date_Choosing_ofWeek_ToDoList = date_Choosing_ofWeek_ToDoList.AddDays(7);
                    HideAllControlInWorkPlacePanel();
                    todolist_Form.Show(date_Choosing_ofWeek_ToDoList);
                }
                if (nut.Text == todo_item[0])
                {
                    date_Choosing_ofWeek_ToDoList = date_Choosing_ofWeek_ToDoList.AddDays(-7);
                    HideAllControlInWorkPlacePanel();
                    todolist_Form.Show(date_Choosing_ofWeek_ToDoList);
                }
            }
            if (nut.Tag.ToString() == "relax")
            {
                if (nut.Text.Trim() == relax_item[1])
                {
                    Game2048 game = new Game2048();
                    game.ShowDialog();
                }
                if (nut.Text == relax_item[0])
                {
                    FlappyBirdForm gameFlappyBird = new FlappyBirdForm();
                    gameFlappyBird.ShowDialog();
                }
            }
        }
        private void SubMenu_Item_Click(object sender, EventArgs e)
        {
            IconButton nut = sender as IconButton;
            ALL_SubMenu_Item_Click(nut);
        }
        void ThemItemVaoSubMenu(Panel submenu, List<IconButton> item, string[] mang)
        {
            
            foreach(var x in mang)
            {
                IconButton nut = new IconButton();
                item.Add(nut);
                item[item.Count - 1].Text = x;
                item[item.Count - 1].Tag = submenu.Tag;
            }    
            
            int height = 0;
            for (int i = 0; i < item.Count; i++)
            {
                item[i].Margin = new Padding(0);
                item[i].Padding = new Padding(0);
                item[i].FlatStyle = FlatStyle.Flat;

                item[i].BackColor = Color.Transparent;
                item[i].Dock = DockStyle.Top;
                item[i].IconChar = IconChar.None;
                item[i].TextAlign = ContentAlignment.MiddleLeft;
                item[i].Font = new Font("Agency FB", 14, FontStyle.Bold);
                item[i].ForeColor = SacMau.trangvua;
                item[i].Size = new Size(251 - 41, 40);
                item[i].FlatAppearance.BorderSize = 0;
                item[i].FlatAppearance.MouseOverBackColor = Color.FromArgb(73, 75, 76);
                item[i].Click += new System.EventHandler(this.SubMenu_Item_Click);
                submenu.Controls.Add(item[i]);
                height += item[i].Height;
               
            }
            submenu.Size = new Size(251, height);
            submenu.Visible = false;
        }

        //icon menu click
        private void ToDoListMenu_iconButton_Click(object sender, EventArgs e)
        {
            IconButton nutClick = sender as IconButton;
            switch (nutClick.Tag.ToString())
            {
                case "Menu1":
                    ShowSubMenu(TodoLIst_SubMenu_Panel,ToDoListMenu_iconButton);
                    break;
                case "Menu2":
                    //ShowSubMenu(Note_SubMenu_Panel,NoteMenu_iconButton);
                    break;
                case "Menu3":
                   // ShowSubMenu(FlashCard_SubMenu_Panel,FlashCardMenu_iconButton);
                    break;
                case "Menu4":
                    ShowSubMenu(Relax_SubMenu_Panel, RelaxMenu_iconButton);
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
            if (currentstate_WorkPlace==State.Home)
            {
                return;
            }
            else
            {
                if (currentstate_WorkPlace==State.About)
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
            this.Hide();
            e.Cancel = true;
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
            if(currentstate_WorkPlace!=State.Home)
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

        private void Current_Timer_Tick(object sender, EventArgs e)
        {
            var hour = DateTime.Now.Hour;
            var minute = DateTime.Now.Minute;
            var second = DateTime.Now.Second;
            if (second % 2 == 0)
            {
                lbl_splash.Visible = true;
            }
            else
            {
                lbl_splash.Visible = false;
            }
            txt_hour.Value = hour;
            txt_minute.Value = minute;
            txt_second.Value = second;
        }
    }
}
