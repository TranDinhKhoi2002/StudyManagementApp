using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyManagementApp.UserControls
{
    public partial class CustomCalendar : UserControl
    {
        Color littlebackgroundPanel;
        Color littleButton;
        Color littlecontentPanel;
        Color Today;
        Color Choosing;
        int row = 6;
        int col = 7;

        List<List<Panel>> arrPanel = new List<List<Panel>>();
        List<List<Button>> arrButton = new List<List<Button>>();
        List<List<Panel>> arrContentPanel = new List<List<Panel>>();
        List<string> arrDay = new List<string> {"Sunday","Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
       
        //Hàm khởi tạo của usercontrol
        public CustomCalendar()
        {
            InitializeComponent();
            KhoiTaoCacList();
        }
        WorkPlace workplace;
        public CustomCalendar(WorkPlace x)
        {
            InitializeComponent();
            KhoiTaoCacList();
            workplace = x;
        }

        //Khi cái usercontrol này load thì làm gì?
        private void CustomCalendar_Load(object sender, EventArgs e)
        {
            LoadControlCalendar();
            LoadDateCalendar();
            LoadColorToday_ChoosingDate();
        }

        //Khi nhấn nút bên phải thì làm gì?
        private void Sau_iconButton_Click(object sender, EventArgs e)
        {
            if (NgayThangNam_customDateTimePicker.Value.Month == 12)
                NgayThangNam_customDateTimePicker.Value = new DateTime(NgayThangNam_customDateTimePicker.Value.Year + 1, 1, 1);
            else
                NgayThangNam_customDateTimePicker.Value = new DateTime(NgayThangNam_customDateTimePicker.Value.Year, NgayThangNam_customDateTimePicker.Value.Month + 1, 1);

            if (NgayThangNam_customDateTimePicker.Value.Month == DateTime.Now.Month)
                NgayThangNam_customDateTimePicker.Value = DateTime.Now.Date;


        }
        //Khi nhấn nút bên trái thì làm gì?
        private void Truoc_iconButton_Click(object sender, EventArgs e)
        {
            if (NgayThangNam_customDateTimePicker.Value.Month == 1)
                NgayThangNam_customDateTimePicker.Value = new DateTime(NgayThangNam_customDateTimePicker.Value.Year - 1, 12, 1);
            else
                NgayThangNam_customDateTimePicker.Value = new DateTime(NgayThangNam_customDateTimePicker.Value.Year, NgayThangNam_customDateTimePicker.Value.Month - 1, 1);
            if (NgayThangNam_customDateTimePicker.Value.Month == DateTime.Now.Month)
                NgayThangNam_customDateTimePicker.Value = DateTime.Now.Date;
        }

        //Hàm khởi tạo 1 loạt các list
        void KhoiTaoCacList()
        {
            for (int i = 0; i < row; i++)
            {
                arrButton.Add(new List<Button>());
                arrPanel.Add(new List<Panel>());
                arrContentPanel.Add(new List<Panel>());
                for (int j = 0; j < col; j++)
                {
                    arrPanel[i].Add(new Panel());
                    arrButton[i].Add(new Button());
                    arrContentPanel[i].Add(new Panel());
                }
            }
            littlebackgroundPanel = Color.FromArgb(47, 52, 55);
            littleButton = Color.FromArgb(217, 217, 217);
            littlecontentPanel = Color.FromArgb(217, 217, 217);
            Today = Color.FromArgb(254, 174, 130);
            Choosing = Color.FromArgb(114, 198, 218);

        }

        //Hàm load control lên hình
        void LoadControlCalendar()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    //47, 52, 55
                    arrPanel[i][j].BackColor = littlebackgroundPanel;
                    arrPanel[i][j].Margin = new Padding(0, 0, 0, 0);
                    arrPanel[i][j].Padding = new Padding(2, 5, 2, 5);
                    arrPanel[i][j].Dock = DockStyle.Fill;

                    /*Button ngay` */
                    arrButton[i][j].Margin = new Padding(0, 0, 0, 0);
                    arrButton[i][j].Padding = new Padding(0);
                    arrButton[i][j].FlatStyle = FlatStyle.Flat;
                    arrButton[i][j].FlatAppearance.BorderSize = 0;
                    arrButton[i][j].Size = new Size(40, 51);
                    arrButton[i][j].Dock = DockStyle.Right;
                    arrButton[i][j].Font = new Font("Agency FB", 14);
                    arrButton[i][j].BackColor = littleButton;

                    /*ContentLabel ngay` */
                    arrContentPanel[i][j].BackColor = littlecontentPanel;
                    arrContentPanel[i][j].Margin = new Padding(0, 0, 0, 0);
                    arrContentPanel[i][j].Padding = new Padding(0);
                    arrContentPanel[i][j].Dock = DockStyle.Fill;

                    arrPanel[i][j].Controls.Add(arrButton[i][j]);
                    arrPanel[i][j].Controls.Add(arrContentPanel[i][j]);
                    MainDate_TablePanel.Controls.Add(arrPanel[i][j], j, i);
                   
                }
            }
        }
        //Hàm lấy ngày cuối tháng
        int LastDayOfMonth(int month, int year)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 30;
            }
        }
        //Hàm load ngày lên hình
        void LoadDateCalendar()
        {
            for(int i=0;i<row;i++)
            {
                for (int j = 0; j < col; j++)
                    arrButton[i][j].Text = "";
            }
            int month = NgayThangNam_customDateTimePicker.Value.Month;
            int year = NgayThangNam_customDateTimePicker.Value.Year;
            int lastday = LastDayOfMonth(month, year);
            DateTime temp = new DateTime(year, month, 1);

            int index_ngaydautien = arrDay.IndexOf(temp.DayOfWeek.ToString());

            int r = 0;
            int c = index_ngaydautien;
            for(int i=1;i<=lastday;i++)
            {
                arrButton[r][c].Text = i.ToString();
                c++;
                if(c>6)
                {
                    r++;
                    c = 0;
                }
                if (r > 5)
                    break;
            }
            if(arrButton[5][0].Text.Trim()=="")
            {
                for (int i = 0; i < col; i++)
                {
                    arrPanel[5][i].Visible = false;
                }
            }
            else
            {
                for (int i = 0; i < col; i++)
                {
                    arrPanel[5][i].Visible = true;
                }
            }

        }
        //Hàm load màu today, choosing lên hình
        void LoadColorToday_ChoosingDate()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arrButton[i][j].BackColor = littleButton;
                    arrContentPanel[i][j].BackColor = littlecontentPanel;
                }
            }
            if (NgayThangNam_customDateTimePicker.Value.Month == DateTime.Now.Month && NgayThangNam_customDateTimePicker.Value.Year == DateTime.Now.Year)
            {

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        if (arrButton[i][j].Text == DateTime.Now.Day.ToString())
                        {
                            arrButton[i][j].BackColor = Today;
                            arrContentPanel[i][j].BackColor = Today;
                        }
                        if (NgayThangNam_customDateTimePicker.Value.Day != DateTime.Now.Day && arrButton[i][j].Text == NgayThangNam_customDateTimePicker.Value.Day.ToString())
                        {
                            arrButton[i][j].BackColor = Choosing;
                            arrContentPanel[i][j].BackColor = Choosing;
                        }
                    }

                }
            }
            else
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        if (arrButton[i][j].Text == NgayThangNam_customDateTimePicker.Value.Day.ToString())
                        {
                            arrButton[i][j].BackColor = Choosing;
                            arrContentPanel[i][j].BackColor = Choosing;
                        }
                        else
                        {
                            arrButton[i][j].BackColor = littleButton;
                            arrContentPanel[i][j].BackColor = littlecontentPanel;
                        }
                    }
                }
            }
        }

        //Khi cái picker value thay đổi thì làm gì?
        private void NgayThangNam_customDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadDateCalendar();
            LoadColorToday_ChoosingDate();
        }

        private void CustomCalendar_SizeChanged(object sender, EventArgs e)
        {
            Monday.MaximumSize = new Size(arrPanel[0][0].Width, 10 + arrPanel[0][0].Height / 2);
            Tuesday.MaximumSize = new Size(arrPanel[0][0].Width, 10 + arrPanel[0][0].Height / 2);
            Wednesday.MaximumSize = new Size(arrPanel[0][0].Width, 10 + arrPanel[0][0].Height / 2);
            Thursday.MaximumSize = new Size(arrPanel[0][0].Width, 10 + arrPanel[0][0].Height / 2);
            Friday.MaximumSize = new Size(arrPanel[0][0].Width, 10 + arrPanel[0][0].Height / 2);
            Saturday.MaximumSize = new Size(arrPanel[0][0].Width, 10 + arrPanel[0][0].Height / 2);
            Sunday.MaximumSize = new Size(arrPanel[0][0].Width, 10 + arrPanel[0][0].Height / 2);
        }
    }
}
