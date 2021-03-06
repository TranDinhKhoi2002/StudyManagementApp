using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyManagementApp.UserControls
{
    public partial class CustomCalendar : UserControl
    {
        
        int row = 6;
        int col = 7;

        Point index_ngay_choosing = new Point(-1, -1);
        DateTime ngay_choosing = new DateTime(1, 1, 1);

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

        #region Đổi theme
        Color littleButton;
        Color littlecontentPanel;
        Color Today;
        Color Choosing;
        public new void Show()
        {
            NgayThangNam_customDateTimePicker.Font = new Font("Agency FB", 16, FontStyle.Bold);
            Sunday.Font = new Font("Agency FB", 13, FontStyle.Bold);
            Monday.Font = new Font("Agency FB", 13, FontStyle.Bold);
            Tuesday.Font = new Font("Agency FB", 13, FontStyle.Bold);
            Wednesday.Font = new Font("Agency FB", 13, FontStyle.Bold);
            Thursday.Font = new Font("Agency FB", 13, FontStyle.Bold);
            Friday.Font = new Font("Agency FB", 13, FontStyle.Bold);
            Saturday.Font = new Font("Agency FB", 13, FontStyle.Bold);
            LoadMau();
            Load_Ngay_IconItem(new DateTime(NgayThangNam_customDateTimePicker.Value.Year, NgayThangNam_customDateTimePicker.Value.Month, 1));
            base.Show();
        }

        void HamDoiMau(Color x,Color y,Color z)
        {
            this.BackColor = x;
            Sau_iconButton.IconColor = y;
            Truoc_iconButton.IconColor = y;

            NgayThangNam_customDateTimePicker.SkinColor = x;
            NgayThangNam_customDateTimePicker.TextColor = y;

            Today_Button.BackColor = y;
            Today_Button.ForeColor = z;
            Today_Button.BorderColor = z;
        }

        void LoadMau()
        {
            if (Program.Theme == true)
            {
                HamDoiMau(SacMau.trangvua, SacMau.dendam, SacMau.trangvua);


            }
            else
            {
                HamDoiMau(SacMau.dendam,SacMau.trangvua,SacMau.dennhat);

            }
        }
        #endregion

        #region Mấy icon nhỏ nhỏ
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
            if (string.IsNullOrEmpty(typecolor))
            {
                return Color.Silver;
            }
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
                if (temp.Date == dateTime.Date)
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

        void Load_Ngay_IconItem(DateTime temp)
        {
            int tangngay = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col ; j++)
                {
                    arrContentPanel[i][j].Controls.Clear();
                    if (arrButton[i][j].Text!="")
                    {
                        Load_IconItem_Date(temp.AddDays(tangngay++), arrContentPanel[i][j]);
                    }
                }
                
            }
        }
        #endregion

        //Khi cái usercontrol này load thì làm gì?
        private void CustomCalendar_Load(object sender, EventArgs e)
        {
            LoadControlCalendar();
            LoadDateCalendar();
            LoadColorDate();
            LoadMau();
            Load_Ngay_IconItem(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1));

        }

        //Khi nhấn nút bên phải thì làm gì?
        private void Sau_iconButton_Click(object sender, EventArgs e)
        {
            if (NgayThangNam_customDateTimePicker.Value.Month == 12)
                NgayThangNam_customDateTimePicker.Value = new DateTime(NgayThangNam_customDateTimePicker.Value.Year + 1, 1, 1);
            else
                NgayThangNam_customDateTimePicker.Value = new DateTime(NgayThangNam_customDateTimePicker.Value.Year, NgayThangNam_customDateTimePicker.Value.Month + 1, 1);
            Load_Ngay_IconItem(new DateTime(NgayThangNam_customDateTimePicker.Value.Year, NgayThangNam_customDateTimePicker.Value.Month, 1));
        }
        //Khi nhấn nút bên trái thì làm gì?
        private void Truoc_iconButton_Click(object sender, EventArgs e)
        {
            if (NgayThangNam_customDateTimePicker.Value.Month == 1)
                NgayThangNam_customDateTimePicker.Value = new DateTime(NgayThangNam_customDateTimePicker.Value.Year - 1, 12, 1);
            else
                NgayThangNam_customDateTimePicker.Value = new DateTime(NgayThangNam_customDateTimePicker.Value.Year, NgayThangNam_customDateTimePicker.Value.Month - 1, 1);
            Load_Ngay_IconItem(new DateTime(NgayThangNam_customDateTimePicker.Value.Year, NgayThangNam_customDateTimePicker.Value.Month, 1));
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
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<col;j++)
                {
                    arrButton[i][j].Click += new System.EventHandler(this.ArrButton_Click);
                    arrButton[i][j].Tag = i.ToString() + j.ToString();
                }
            }    
            littleButton = Color.Silver;
            littlecontentPanel = Color.Silver;
            Today = Color.FromArgb(254, 174, 130);
            Choosing = Color.FromArgb(114, 198, 218);

        }
        
        //Hàm lấy chỉ số của một ô ngày trong cuốn lịch
        Point LayChiSoKieuPoint(string x)
        {
            return new Point(int.Parse(x) / 10, int.Parse(x) % 10);
        }

        //Sự kiện của Today button click
        private void Today_Button_Click(object sender, EventArgs e)
        {
            if (NgayThangNam_customDateTimePicker.Value == DateTime.Now.Date)
                LoadColorDate();
            else
                NgayThangNam_customDateTimePicker.Value = DateTime.Now.Date;
            index_ngay_choosing = new Point(-1, -1);
            ngay_choosing = new DateTime(1, 1, 1);
        }

        //Sự kiện của các nút ngày trong cuốn lịch
        private void ArrButton_Click(object sender, EventArgs e)
        {
            
            Button nutngay = sender as Button;
            Point diem = LayChiSoKieuPoint(nutngay.Tag.ToString());
            if (!string.IsNullOrEmpty(nutngay.Text))
            {
                if (index_ngay_choosing.X == diem.X && index_ngay_choosing.Y == diem.Y)
                {
                    //Hủy chọn
                    if (NgayThangNam_customDateTimePicker.Value.Month == DateTime.Now.Month && NgayThangNam_customDateTimePicker.Value.Year == DateTime.Now.Year)
                    {
                        NgayThangNam_customDateTimePicker.Value = new DateTime(NgayThangNam_customDateTimePicker.Value.Year, NgayThangNam_customDateTimePicker.Value.Month, DateTime.Now.Day);
                    }
                    else
                    {
                        NgayThangNam_customDateTimePicker.Value = new DateTime(NgayThangNam_customDateTimePicker.Value.Year, NgayThangNam_customDateTimePicker.Value.Month, 1);
                    }    
                    index_ngay_choosing = new Point(-1, -1);
                    ngay_choosing = new DateTime(1, 1, 1);
                    WorkPlace.date_Choosing_ofWeek_ToDoList = DateTime.Now;
                    LoadColorDate();
                }
                else
                {
                    LoadColorDate();
                    //Chọn
                    index_ngay_choosing = diem;
                    ngay_choosing = new DateTime(NgayThangNam_customDateTimePicker.Value.Year, NgayThangNam_customDateTimePicker.Value.Month, int.Parse(nutngay.Text));
                    WorkPlace.date_Choosing_ofWeek_ToDoList = ngay_choosing;
                    WorkPlace.todolist_Form.Show(ngay_choosing);
                    this.Hide();
                    NgayThangNam_customDateTimePicker.Value = ngay_choosing;
                    arrButton[index_ngay_choosing.X][index_ngay_choosing.Y].BackColor = Choosing;
                    arrContentPanel[index_ngay_choosing.X][index_ngay_choosing.Y].BackColor = Choosing;
                }
            }
        }

        //Hàm load control lên hình
        void LoadControlCalendar()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    //47, 52, 55
                    arrPanel[i][j].BackColor = Color.Transparent;
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
                    arrButton[i][j].Font = new Font("Agency FB", 12);
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
        //Hàm load màu date lên hình
        void LoadColorDate()
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
                    }
                }
            }
        }

        //Khi cái picker value thay đổi thì làm gì?
        private void NgayThangNam_customDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadDateCalendar();
            LoadColorDate();
          
        }

        //Khi cả cái cuốn lịch đổi size thì làm gì?
        private void CustomCalendar_SizeChanged(object sender, EventArgs e)
        {
            if(arrButton.Count>0)
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
        private void CustomDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadDateCalendar();
            LoadColorDate();
        }

        private static void Client_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Notification", "Something wrong: \n" + e.Error.Message);
                customMessageBox.ShowDialog();
                return;
            }
        }
    }
}
