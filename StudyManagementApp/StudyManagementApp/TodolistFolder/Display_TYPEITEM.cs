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
    public partial class Display_TYPEITEM : Form
    {
        string pk_color;
        Color background;
        string text;
        public Display_TYPEITEM()
        {
            InitializeComponent();
        }

        public Display_TYPEITEM(string pk, Color bg, string txt)
        {
            InitializeComponent();
            DataTable all_typeitem = WorkPlace.bang_AllTYPEITEM_TDL;
            pk_color = pk;
            background = bg;
            text = txt;
        }
        void LoadData()
        {
            background_Main_panel.BackColor = background;
            main_textBox.Text = text;
        }

        public new void Show()
        {
            LoadData();
            base.Show();
        }

        private void color_iconButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog()==DialogResult.OK)
            {
                string temp_color = ColorTranslator.ToHtml(colorDialog.Color);
                DataTable all_typeitem = WorkPlace.bang_AllTYPEITEM_TDL;
                for (int i = 0; i < all_typeitem.Rows.Count; i++)
                {
                    if (temp_color==all_typeitem.Rows[i]["TYPECOLOR"].ToString())
                    {
                        CustomMessageBox customMessageBox = new CustomMessageBox("Todo nhắc nhở", "Màu không có sẵn!");
                        customMessageBox.ShowDialog();
                        return;
                    }
                }
                background = colorDialog.Color;
                background_Main_panel.BackColor = background;
            }
        }

        private void edit_iconButton_Click(object sender, EventArgs e)
        {
            string typecolor = ColorTranslator.ToHtml(background);
            DAO.AccountDAO.Instance.Update_TYPEITEM_TDL(pk_color, UserInfo.Instance.Username, typecolor, text);
            WorkPlace.bang_AllTYPEITEM_TDL = DAO.AccountDAO.Instance.GetAll_TYPEITEM_TDL(UserInfo.Instance.Username);
        }

        private void main_textBox_TextChanged(object sender, EventArgs e)
        {
            text = main_textBox.Text;
        }

        private void delete_iconButton_Click(object sender, EventArgs e)
        {
            DataTable all_task = WorkPlace.bang_AllTASK_TDL;
            for (int i = 0; i < all_task.Rows.Count; i++)
            {
                if (all_task.Rows[i]["PK_COLOR"].ToString()== pk_color)
                {
                    CustomMessageBox customMessageBox = new CustomMessageBox("Todo nhắc nhở", "Không thể xóa màu này.\nMàu vẫn đang được TASK nào đó sử dụng!");
                    customMessageBox.ShowDialog();
                    return;
                }
            }
            string query = "DELETE_TYPEITEM @pk_COLOR , @userName ";
            DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { pk_color, UserInfo.Instance.Username });
            WorkPlace.bang_AllTYPEITEM_TDL = DAO.AccountDAO.Instance.GetAll_TYPEITEM_TDL(UserInfo.Instance.Username);
            this.Close();
        }
    }
}
