using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyManagementApp.TodolistFolder
{
    public partial class Todolist_Form : Form
    {
        
        DateTime ngayToanCuc;
        DateTime date_choose;
        Color choose;
        Color khongchoose;
        public static List<DataItem_Todolist> mangItemTheoDate = new List<DataItem_Todolist>();
        public static List<Item_Todolist_Form> mangFormTheoDate = new List<Item_Todolist_Form>();

        static public DataTable TypeItem;
        static public DataTable Task;

        bool timedeadline_asc = true; //6am->7pm
        enum DisplayState
        {
            all, check_ed, uncheck_ed
        }

        DisplayState Filter_display_Task = DisplayState.all;


        public Todolist_Form()
        {
            InitializeComponent();
            choose = Color.Gray;
            khongchoose = Color.Silver;
        }

        private void Todolist_Form_Load(object sender, EventArgs e)
        {
            KhoiTao();
            LoadMau();
        }

        public void Show(DateTime temp)
        {
            search_textBox.Text = "";
            ngayToanCuc = temp;
            date_choose = temp;
            KhoiTao();
            LoadMau();
            base.Show();
        }

        void HamDoiMau(Color x)
        {
            this.BackColor = x;
        }

        void LoadMau()
        {
            if (Program.Theme == true)
            {
                HamDoiMau(SacMau.trangvua);
            }
            else
            {
                HamDoiMau(SacMau.dendam);
            }
        }

        private void ChuaItem_Panel_ControlRemoved(object sender, ControlEventArgs e)
        {
            Load_BayNgay_IconItem(ngayToanCuc);
        }

        #region Vùng khởi tạo mọi thứ 
        void KhoiTao()
        {
            DateTime temp;
            try
            {
                switch (ngayToanCuc.DayOfWeek)
                {
                    case DayOfWeek.Sunday:
                        temp = ngayToanCuc;
                        break;
                    case DayOfWeek.Monday:
                        temp = ngayToanCuc.AddDays(-1);
                        break;
                    case DayOfWeek.Tuesday:
                        temp = ngayToanCuc.AddDays(-2);
                        break;
                    case DayOfWeek.Wednesday:
                        temp = ngayToanCuc.AddDays(-3);
                        break;
                    case DayOfWeek.Thursday:
                        temp = ngayToanCuc.AddDays(-4);
                        break;
                    case DayOfWeek.Friday:
                        temp = ngayToanCuc.AddDays(-5);
                        break;
                    case DayOfWeek.Saturday:
                        temp = ngayToanCuc.AddDays(-6);
                        break;
                    default:
                        temp = DateTime.Now.Date;
                        break;
                }

                day_sun_button.Text = temp.Day.ToString();
                day_mon_button.Text = temp.AddDays(1).Day.ToString();
                day_tue_button.Text = temp.AddDays(2).Day.ToString();
                day_wed_button.Text = temp.AddDays(3).Day.ToString();
                day_thu_button.Text = temp.AddDays(4).Day.ToString();
                day_fri_button.Text = temp.AddDays(5).Day.ToString();
                day_sat_button.Text = temp.AddDays(6).Day.ToString();

                Load_DateChoose_FromWorkPlace(temp);
                Load_BayNgay_IconItem(temp);

                ngayToanCuc = temp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Todolist_Form: " + ex.Message);
            }
        }

        void Check_DateChoose_FromWorkPlace(DateTime dateTime ,IconButton iconButton)
        {
            iconButton.BackColor = khongchoose;
            if (dateTime.Date == date_choose.Date)
            {
                iconButton.BackColor = choose;
                date_choose = dateTime;
                LoadItemTheoDate(date_choose);
            }
        }
        
        void Load_DateChoose_FromWorkPlace(DateTime temp)
        {
            Check_DateChoose_FromWorkPlace(temp, day_sun_button);
            Check_DateChoose_FromWorkPlace(temp.AddDays(1), day_mon_button);
            Check_DateChoose_FromWorkPlace(temp.AddDays(2), day_tue_button);
            Check_DateChoose_FromWorkPlace(temp.AddDays(3), day_wed_button);
            Check_DateChoose_FromWorkPlace(temp.AddDays(4), day_thu_button);
            Check_DateChoose_FromWorkPlace(temp.AddDays(5), day_fri_button);
            Check_DateChoose_FromWorkPlace(temp.AddDays(6), day_sat_button);
        }
        #endregion

        #region Mấy icon mini dưới cái ngày
        Color Get_Color_FromPK_COLOR(string pk_color)
        {
            DataTable allTYPEITEM = WorkPlace.bang_AllTYPEITEM_TDL;
            string typecolor = "";
            for (int i = 0; i < allTYPEITEM.Rows.Count; i++)
            {
                if (allTYPEITEM.Rows[i]["PK_COLOR"].ToString() == pk_color)
                {
                    typecolor = allTYPEITEM.Rows[i]["TYPECOLOR"].ToString();

                }
            }
            TypeItem = allTYPEITEM;
            if (string.IsNullOrEmpty(typecolor))
                return Color.Silver;
            else
                return ColorTranslator.FromHtml(typecolor);

           
        }
        void Setting_IconItem(IconButton iconButton)
        {
            iconButton.BackColor = System.Drawing.Color.Transparent;
            iconButton.Dock = System.Windows.Forms.DockStyle.Left;
            iconButton.FlatAppearance.BorderSize = 0;
            iconButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            iconButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton.IconChar = FontAwesome.Sharp.IconChar.Circle;
            iconButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton.IconSize = 15;
            iconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            iconButton.Margin = new System.Windows.Forms.Padding(0);
            iconButton.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            iconButton.Size = new System.Drawing.Size(17, 24);
        }
        void Load_IconItem_Date(DateTime dateTime, Panel iconitempanel)
        {
            iconitempanel.Controls.Clear();
            DataTable allTask = WorkPlace.bang_AllTASK_TDL;
            for (int i = 0; i < allTask.Rows.Count; i++)
            {
                DateTime temp = (DateTime)allTask.Rows[i]["DATETIMEDEADLINE"];
                if (temp.Date==dateTime.Date )
                {
                    string pk_color = allTask.Rows[i]["PK_COLOR"].ToString();
                    Color color = Get_Color_FromPK_COLOR(pk_color);
                    IconButton iconButton = new IconButton();
                    Setting_IconItem(iconButton);
                    iconButton.IconColor = color;
                    iconitempanel.Controls.Add(iconButton);
                }
            }

        }
        void Load_BayNgay_IconItem(DateTime temp)
        {
            Load_IconItem_Date(temp, sun_iconitem_panel);
            Load_IconItem_Date(temp.AddDays(1), mon_iconitem_panel);
            Load_IconItem_Date(temp.AddDays(2), tue_iconitem_panel);
            Load_IconItem_Date(temp.AddDays(3), wed_iconitem_panel);
            Load_IconItem_Date(temp.AddDays(4), thu_iconitem_panel);
            Load_IconItem_Date(temp.AddDays(5), fri_iconitem_panel);
            Load_IconItem_Date(temp.AddDays(6), sat_iconitem_panel);

        }
        #endregion

        #region Các chức năng ở dưới
        private void additem_iconButton_Click(object sender, EventArgs e)
        {
            AddItem_Todolist addItem_Todolist = new AddItem_Todolist(date_choose);
            addItem_Todolist.ShowDialog();
            LoadItemTheoDate(date_choose);
        }
        private void sort_timedeadline_iconButton_Click(object sender, EventArgs e)
        {
            if (ChuaItem_Panel.Controls.Count>0)
            {
                timedeadline_asc = !timedeadline_asc;
                ChuaItem_Panel.Controls.Clear();
                mangItemTheoDate.Reverse();
                mangFormTheoDate.Reverse();
                for (int i = 0; i < mangFormTheoDate.Count; i++)
                {
                    if (Filter_display_Task != DisplayState.all)
                    {
                        if (Filter_display_Task == DisplayState.check_ed)
                        {
                            if (mangItemTheoDate[i].done == true)
                            {
                                mangFormTheoDate[i].TopLevel = false;
                                mangFormTheoDate[i].Dock = DockStyle.Top;
                                ChuaItem_Panel.Controls.Add(mangFormTheoDate[i]);
                                mangFormTheoDate[i].Show();
                            }
                        }
                        if (Filter_display_Task == DisplayState.uncheck_ed)
                        {
                            if (mangItemTheoDate[i].done == false)
                            {
                                mangFormTheoDate[i].TopLevel = false;
                                mangFormTheoDate[i].Dock = DockStyle.Top;
                                ChuaItem_Panel.Controls.Add(mangFormTheoDate[i]);
                                mangFormTheoDate[i].Show();
                            }
                        }
                    }
                    else
                    {
                        mangFormTheoDate[i].TopLevel = false;
                        mangFormTheoDate[i].Dock = DockStyle.Top;
                        ChuaItem_Panel.Controls.Add(mangFormTheoDate[i]);
                        mangFormTheoDate[i].Show();
                    }

                }
            }
            
        }
        private void filter_iconButton_Click(object sender, EventArgs e)
        {
            IconButton iconButton = sender as IconButton;
            switch (iconButton.Tag.ToString())
            {
                case "all":
                    Filter_display_Task = DisplayState.check_ed;
                    iconButton.IconChar = IconChar.CheckSquare;
                    iconButton.Tag = "checked";
                    break;
                case "checked":
                    Filter_display_Task = DisplayState.uncheck_ed;
                    iconButton.IconChar = IconChar.Square;
                    iconButton.Tag = "unchecked";
                    break;
                case "unchecked":
                    Filter_display_Task = DisplayState.all;
                    iconButton.IconChar = IconChar.Th;
                    iconButton.Tag = "all";
                    break;
                default:
                    break;
            }
            ChuaItem_Panel.Controls.Clear();
            for (int i = 0; i < mangFormTheoDate.Count; i++)
            {
                if (Filter_display_Task != DisplayState.all)
                {
                    if (Filter_display_Task == DisplayState.check_ed)
                    {
                        if (mangItemTheoDate[i].done == true)
                        {
                            mangFormTheoDate[i].TopLevel = false;
                            mangFormTheoDate[i].Dock = DockStyle.Top;
                            ChuaItem_Panel.Controls.Add(mangFormTheoDate[i]);
                            mangFormTheoDate[i].Show();
                        }
                    }
                    if (Filter_display_Task == DisplayState.uncheck_ed)
                    {
                        if (mangItemTheoDate[i].done == false)
                        {
                            mangFormTheoDate[i].TopLevel = false;
                            mangFormTheoDate[i].Dock = DockStyle.Top;
                            ChuaItem_Panel.Controls.Add(mangFormTheoDate[i]);
                            mangFormTheoDate[i].Show();
                        }
                    }
                }
                else
                {
                    mangFormTheoDate[i].TopLevel = false;
                    mangFormTheoDate[i].Dock = DockStyle.Top;
                    ChuaItem_Panel.Controls.Add(mangFormTheoDate[i]);
                    mangFormTheoDate[i].Show();
                }

            }
        }

        private void typecolor_iconButton_Click(object sender, EventArgs e)
        {
            Update_Delete_TYPECOLOR update_Delete_TYPECOLOR = new Update_Delete_TYPECOLOR();
            update_Delete_TYPECOLOR.ShowDialog();
            LoadItemTheoDate(date_choose);
        }

        private void search_textBox_TextChanged(object sender, EventArgs e)
        {
            ChuaItem_Panel.Controls.Clear();
            for (int i = 0; i < mangFormTheoDate.Count; i++)
            {
                if (string.IsNullOrEmpty(search_textBox.Text))
                {
                    if (Filter_display_Task != DisplayState.all)
                    {
                        if (Filter_display_Task == DisplayState.check_ed)
                        {
                            if (mangItemTheoDate[i].done == true)
                            {
                                mangFormTheoDate[i].TopLevel = false;
                                mangFormTheoDate[i].Dock = DockStyle.Top;
                                ChuaItem_Panel.Controls.Add(mangFormTheoDate[i]);
                                mangFormTheoDate[i].Show();
                            }
                        }
                        if (Filter_display_Task == DisplayState.uncheck_ed)
                        {
                            if (mangItemTheoDate[i].done == false)
                            {
                                mangFormTheoDate[i].TopLevel = false;
                                mangFormTheoDate[i].Dock = DockStyle.Top;
                                ChuaItem_Panel.Controls.Add(mangFormTheoDate[i]);
                                mangFormTheoDate[i].Show();
                            }
                        }
                    }
                    else
                    {
                        mangFormTheoDate[i].TopLevel = false;
                        mangFormTheoDate[i].Dock = DockStyle.Top;
                        ChuaItem_Panel.Controls.Add(mangFormTheoDate[i]);
                        mangFormTheoDate[i].Show();
                    }
                }
                else
                {
                    if (mangItemTheoDate[i].taskName.Contains(search_textBox.Text))
                    {
                        if (Filter_display_Task != DisplayState.all)
                        {
                            if (Filter_display_Task == DisplayState.check_ed)
                            {
                                if (mangItemTheoDate[i].done == true)
                                {
                                    mangFormTheoDate[i].TopLevel = false;
                                    mangFormTheoDate[i].Dock = DockStyle.Top;
                                    ChuaItem_Panel.Controls.Add(mangFormTheoDate[i]);
                                    mangFormTheoDate[i].Show();
                                }
                            }
                            if (Filter_display_Task == DisplayState.uncheck_ed)
                            {
                                if (mangItemTheoDate[i].done == false)
                                {
                                    mangFormTheoDate[i].TopLevel = false;
                                    mangFormTheoDate[i].Dock = DockStyle.Top;
                                    ChuaItem_Panel.Controls.Add(mangFormTheoDate[i]);
                                    mangFormTheoDate[i].Show();
                                }
                            }
                        }
                        else
                        {
                            mangFormTheoDate[i].TopLevel = false;
                            mangFormTheoDate[i].Dock = DockStyle.Top;
                            ChuaItem_Panel.Controls.Add(mangFormTheoDate[i]);
                            mangFormTheoDate[i].Show();
                        }
                    }
                }
            }
        }
        #endregion

        #region Hiện task
        void LoadItemTheoDate(DateTime datetimeDeadline)
        {
            mangItemTheoDate.Clear();
            mangFormTheoDate.Clear();
            ChuaItem_Panel.Controls.Clear();
            DataTable allTASK = WorkPlace.bang_AllTASK_TDL;
           
            for (int i = 0; i < allTASK.Rows.Count; i++)
            {
                DateTime DateTimeDeadline = (DateTime)allTASK.Rows[i]["DATETIMEDEADLINE"];
                if (datetimeDeadline.Date==DateTimeDeadline.Date)
                {
                    DateTime DateTimeCreate = (DateTime)allTASK.Rows[i]["DATETIMECREATE"];
                    string TaskName = allTASK.Rows[i]["TASKNAME"].ToString();
                    string Note = allTASK.Rows[i]["NOTE"].ToString();
                    string PK_Color = allTASK.Rows[i]["PK_COLOR"].ToString();
                    bool Done = (bool)allTASK.Rows[i]["DONE"];
                    DateTime DateTimeNOTI = (DateTime)allTASK.Rows[i]["DATETIMENOTI"];
                    DataItem_Todolist dataItem_Todolist = new DataItem_Todolist(DateTimeCreate, TaskName, DateTimeDeadline, Note, PK_Color, Done, DateTimeNOTI);
                    mangItemTheoDate.Add(dataItem_Todolist);
                }
            }
            //hàm sort này cho ra kết quả desc
            mangItemTheoDate = mangItemTheoDate.OrderBy(o => o.dateTimeDeadline.TimeOfDay).ToList();
            if (timedeadline_asc == true)
            {
                mangItemTheoDate.Reverse();
            }
            foreach (var item in mangItemTheoDate)
            {
                DateTime DateTimeCreate = item.dateTimeCreate;
                string TaskName = item.taskName;
                DateTime DateTimeDeadline = item.dateTimeDeadline;
                string Note = item.note;
                string PK_Color = item.pk_Color;
                bool Done = item.done;
                DateTime DateTimeNOTI = item.dateTimeNOTI;
                Item_Todolist_Form item_Todolist_Form = new Item_Todolist_Form(DateTimeCreate, TaskName, DateTimeDeadline, Note, Done, PK_Color, DateTimeNOTI);
                mangFormTheoDate.Add(item_Todolist_Form);
            }

            for (int i = 0; i < mangFormTheoDate.Count; i++)
            {
                if (Filter_display_Task != DisplayState.all)
                {
                    if (Filter_display_Task == DisplayState.check_ed)
                    {
                        if (mangItemTheoDate[i].done==true)
                        {
                            mangFormTheoDate[i].TopLevel = false;
                            mangFormTheoDate[i].Dock = DockStyle.Top;
                            ChuaItem_Panel.Controls.Add(mangFormTheoDate[i]);
                            mangFormTheoDate[i].Show();
                        }
                    }
                    if (Filter_display_Task == DisplayState.uncheck_ed)
                    {
                        if (mangItemTheoDate[i].done == false)
                        {
                            mangFormTheoDate[i].TopLevel = false;
                            mangFormTheoDate[i].Dock = DockStyle.Top;
                            ChuaItem_Panel.Controls.Add(mangFormTheoDate[i]);
                            mangFormTheoDate[i].Show();
                        }
                    }
                }
                else
                {
                    mangFormTheoDate[i].TopLevel = false;
                    mangFormTheoDate[i].Dock = DockStyle.Top;
                    ChuaItem_Panel.Controls.Add(mangFormTheoDate[i]);
                    mangFormTheoDate[i].Show();
                }    
               
            }
            Task = allTASK;
            
        }

       
        #endregion

        #region Click các nút ngày ở trên
        private void day_sun_button_Click(object sender, EventArgs e)
        {
            IconButton iconButton = sender as IconButton;
            day_sun_button.BackColor = khongchoose;
            day_mon_button.BackColor = khongchoose;
            day_tue_button.BackColor = khongchoose;
            day_wed_button.BackColor = khongchoose;
            day_thu_button.BackColor = khongchoose;
            day_fri_button.BackColor = khongchoose;
            day_sat_button.BackColor = khongchoose;

            iconButton.BackColor = choose;
            search_textBox.Text = "";
            if (iconButton.Tag.ToString()=="sun")
            {
                date_choose = ngayToanCuc;
            }
            if (iconButton.Tag.ToString() == "mon")
            {
                date_choose = ngayToanCuc.AddDays(1);
            }
            if (iconButton.Tag.ToString() == "tue")
            {
                date_choose = ngayToanCuc.AddDays(2);
            }
            if (iconButton.Tag.ToString() == "wed")
            {
                date_choose = ngayToanCuc.AddDays(3);
            }
            if (iconButton.Tag.ToString() == "thu")
            {
                date_choose = ngayToanCuc.AddDays(4);
            }
            if (iconButton.Tag.ToString() == "fri")
            {
                date_choose = ngayToanCuc.AddDays(5);
            }
            if (iconButton.Tag.ToString() == "sat")
            {
                date_choose = ngayToanCuc.AddDays(6);
            }
            LoadItemTheoDate(date_choose);
        }



        #endregion

       
    }
}
