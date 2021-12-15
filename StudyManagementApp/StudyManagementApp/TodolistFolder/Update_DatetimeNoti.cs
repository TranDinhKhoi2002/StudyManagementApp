using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyManagementApp.TodolistFolder
{
    public partial class Update_DatetimeNoti : Form
    {
        DateTime DateTimeCreate;
        DateTime DateTimeDeadline;
        DateTime DateTimeNOTI;
        int dayindex;
        int timeindex;
        public Update_DatetimeNoti()
        {
            InitializeComponent();
        }
        public Update_DatetimeNoti(DateTime datetimeCreate,DateTime datetimeDeadline ,DateTime datetimeNoti)
        {
            InitializeComponent();
            DateTimeCreate = datetimeCreate;
            DateTimeNOTI = datetimeNoti;
            DateTimeDeadline = datetimeDeadline;
        }

        private void Update_DatetimeNoti_Load(object sender, EventArgs e)
        {
            DateTime x = DateTimeNOTI;
            DateTime y = DateTimeDeadline;
            if (x.Day == y.Day && x.Month == y.Month && x.Year == y.Year)
            {
                dayindex = 0;
            }
            else if (x.Day == y.AddDays(-1).Day && x.Month == y.AddDays(-1).Month && x.Year == y.AddDays(-1).Year)
            {
                dayindex = 1;
                y.AddDays(-1);
            }
            else if (x.Day == y.AddDays(-2).Day && x.Month == y.AddDays(-2).Month && x.Year == y.AddDays(-2).Year)
            {
                dayindex = 2;
                y.AddDays(-2);
            }
            else if(x.Day == y.AddDays(-7).Day && x.Month == y.AddDays(-7).Month && x.Year == y.AddDays(-7).Year)
            {
                dayindex = 3;
                y.AddDays(-7);
            }

            if (x.Hour==y.Hour && x.Minute==y.Minute && x.Second==y.Second)
            {
                timeindex = 0;
            }
            else if (x.Hour == y.AddMinutes(-5).Hour && x.Minute == y.AddMinutes(-5).Minute && x.Second == y.AddMinutes(-5).Second)
            {
                timeindex = 1;
            }
            else if (x.Hour == y.AddMinutes(-10).Hour && x.Minute == y.AddMinutes(-10).Minute && x.Second == y.AddMinutes(-10).Second)
            {
                timeindex = 2;
            }
            else if (x.Hour == y.AddMinutes(-15).Hour && x.Minute == y.AddMinutes(-15).Minute && x.Second == y.AddMinutes(-15).Second)
            {
                timeindex = 3;
            }
            else if (x.Hour == y.AddMinutes(-30).Hour && x.Minute == y.AddMinutes(-30).Minute && x.Second == y.AddMinutes(-30).Second)
            {
                timeindex = 4;
            }
            else if (x.Hour == y.AddHours(-1).Hour && x.Minute == y.AddHours(-1).Minute && x.Second == y.AddHours(-1).Second)
            {
                timeindex = 5;
            }
            else if (x.Hour == y.AddHours(-2).Hour && x.Minute == y.AddHours(-2).Minute && x.Second == y.AddHours(-2).Second)
            {
                timeindex = 6;
            }

            daynoti_comboBox.SelectedIndex = dayindex;
            timenoti_comboBox.SelectedIndex = timeindex;

        }
        DateTime Get_datetime_NOTI(DateTime datetimedeadline)
        {
            DateTime dateTime = datetimedeadline;
            switch (daynoti_comboBox.SelectedIndex)
            {
                case 0:
                    //dateTime = datetimedeadline;
                    break;
                case 1:
                    dateTime = datetimedeadline.AddDays(-1);
                    break;
                case 2:
                    dateTime = datetimedeadline.AddDays(-2);
                    break;
                case 3:
                    dateTime = datetimedeadline.AddDays(-7);
                    break;
                default:
                    break;
            }
            switch (timenoti_comboBox.SelectedIndex)
            {
                case 0:
                    //dateTime = dateTime;
                    break;
                case 1:
                    dateTime = dateTime.AddMinutes(-5);
                    break;
                case 2:
                    dateTime = dateTime.AddMinutes(-10);
                    break;
                case 3:
                    dateTime = dateTime.AddMinutes(-15);
                    break;
                case 4:
                    dateTime = dateTime.AddMinutes(-30);
                    break;
                case 5:
                    dateTime = dateTime.AddHours(-1);
                    break;
                case 6:
                    dateTime = dateTime.AddHours(-2);
                    break;
                default:
                    break;
            }
            return dateTime;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (daynoti_comboBox.SelectedIndex != dayindex || timenoti_comboBox.SelectedIndex != timeindex)
            {
                DateTime newDateTimeNOTI = Get_datetime_NOTI(DateTimeDeadline);
                string query = "UPDATE_DATETIMENOTI @userName , @datetimeCreate , @datetimeNOTI ";
                DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { UserInfo.Instance.Username, DateTimeCreate, newDateTimeNOTI });
                WorkPlace.bang_AllTASK_TDL = DAO.AccountDAO.Instance.GetAll_TASK_TDL(UserInfo.Instance.Username);
            }

            this.Close();
        }

        private void close_iconButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
