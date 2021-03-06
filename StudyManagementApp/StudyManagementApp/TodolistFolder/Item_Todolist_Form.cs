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
    public partial class Item_Todolist_Form : Form
    {
        DateTime datetimeCreate;
        string taskName;
        DateTime datetimeDeadline;
        string note;
        bool done;
        string pk_Color;
        DateTime datetimeNOTI;
        Color typeColor;//suy ra tu pk_color
        string nameType;
        public Item_Todolist_Form()
        {
            InitializeComponent();
        }
        public Item_Todolist_Form(DateTime datetimeCreate_,string taskName_, DateTime datetimeDeadline_, string note_, bool done_, string pk_Color_, DateTime datetimeNoti)
        {
            InitializeComponent();
            datetimeCreate = datetimeCreate_;
            taskName = taskName_;
            datetimeDeadline = datetimeDeadline_;
            note = note_;
            done = done_;
            pk_Color = pk_Color_;
            datetimeNOTI = datetimeNoti;
        }
        private void Item_Todolist_Form_Load(object sender, EventArgs e)
        {
            LoadMau();
            LoadIMauItem(pk_Color);
            LoadData();
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

        #region Màu cho type của task đó
        public void LoadIMauItem(string pk_color)
        {
            DataTable allTypeItem = WorkPlace.bang_AllTYPEITEM_TDL;

            for (int i = 0; i < allTypeItem.Rows.Count; i++)
            {
                if (allTypeItem.Rows[i]["PK_COLOR"].ToString()==pk_color)
                {
                    typeColor = ColorTranslator.FromHtml(allTypeItem.Rows[i]["TYPECOLOR"].ToString());
                    nameType = allTypeItem.Rows[i]["NAMETYPE"].ToString();
                }
            }
        }
        #endregion

        #region load content: taskname, thời gian,... cho form
        void LoadData()
        {
            taskname_textbox.Text = taskName;
            thoigian_deadline_label.Text = datetimeDeadline.ToShortTimeString();
            if (note=="")
            {
                description_textbox.Text = "Empty";
            }
            else
            {
                description_textbox.Text = note;
            }
            type_iconButton.IconColor = typeColor;
            type_iconButton.ForeColor = typeColor;
            type_iconButton.Text = nameType;
            if(done)
            {
                checkbox_iconButton.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            }
            else
            {
                checkbox_iconButton.IconChar = FontAwesome.Sharp.IconChar.Square;
            }
            Noti_iconButton.Text = datetimeNOTI.ToString("dd/MM/yyyy hh:mm tt");
        }
        #endregion

        #region Click nút checkbox
        private void checkbox_iconButton_Click(object sender, EventArgs e)
        {
            done = !done;
            DAO.AccountDAO.Instance.Update_TASKDONE_TDL(UserInfo.Instance.Username, datetimeCreate, done);
            WorkPlace.bang_AllTASK_TDL = DAO.AccountDAO.Instance.GetAll_TASK_TDL(UserInfo.Instance.Username);
            if (done)
            {
                checkbox_iconButton.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            }
            else
            {
                checkbox_iconButton.IconChar = FontAwesome.Sharp.IconChar.Square;
            }
        }
        #endregion

        #region Click thùng rác
        private void delete_iconButton_Click(object sender, EventArgs e)
        {
            string userName = UserInfo.Instance.Username;
            DateTime temp = datetimeCreate;
            Delete_Mot_Item(userName, temp);

        }
        #endregion

        #region Hàm xóa 1 task

        void Delete_Mot_Item(string userName, DateTime datetimeCreate)
        {
            string query = "DELETE_MOT_ITEM @userName , @datetimeCreate ";
            DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName, datetimeCreate });
            WorkPlace.bang_AllTASK_TDL = DAO.AccountDAO.Instance.GetAll_TASK_TDL(UserInfo.Instance.Username);
            this.Close();
        }
        #endregion

        #region cập nhật nhắc deadline
        private void Noti_iconButton_Click(object sender, EventArgs e)
        {
            Update_DatetimeNoti update_DatetimeNoti = new Update_DatetimeNoti(datetimeCreate, datetimeDeadline, datetimeNOTI);
            update_DatetimeNoti.ShowDialog();
            DataTable all_taskitem = WorkPlace.bang_AllTASK_TDL;
            for (int i = 0; i < all_taskitem.Rows.Count; i++)
            {
                string userNAME = all_taskitem.Rows[i]["USERNAME"].ToString();
                DateTime datetimecreate = (DateTime)all_taskitem.Rows[i]["DATETIMECREATE"];
                if (UserInfo.Instance.Username == userNAME && datetimeCreate == datetimecreate)
                {
                    datetimeNOTI = (DateTime)all_taskitem.Rows[i]["DATETIMENOTI"];
                    Noti_iconButton.Text = datetimeNOTI.ToString("dd/MM/yyyy hh:mm tt");
                }
            }

        }
        #endregion

        private void taskname_textbox_Leave(object sender, EventArgs e)
        {
            if (taskname_textbox.Text=="")
            {
                taskname_textbox.Text = taskName;
                return;
            }
            if (taskname_textbox.Text!=taskName)
            {
                taskName = taskname_textbox.Text;
                string query = "UPDATE_TASKNAME @userName , @datetimeCreate , @taskNAME ";
                DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { UserInfo.Instance.Username, datetimeCreate, taskName });
                WorkPlace.bang_AllTASK_TDL = DAO.AccountDAO.Instance.GetAll_TASK_TDL(UserInfo.Instance.Username);
            }
        }

        private void description_textbox_Leave(object sender, EventArgs e)
        {
            if (description_textbox.Text != note)
            {
                note = description_textbox.Text;
                string query = "UPDATE_DESCRIPTION @userName , @datetimeCreate , @note ";
                DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { UserInfo.Instance.Username, datetimeCreate, note });
                WorkPlace.bang_AllTASK_TDL = DAO.AccountDAO.Instance.GetAll_TASK_TDL(UserInfo.Instance.Username);
            }
            if (description_textbox.Text == "")
            {
                    description_textbox.Text = "Empty";
            }
        }

        private void description_textbox_Enter(object sender, EventArgs e)
        {
            if (description_textbox.Text=="Empty")
            {
                description_textbox.Clear();
            }
        }
    }
}
