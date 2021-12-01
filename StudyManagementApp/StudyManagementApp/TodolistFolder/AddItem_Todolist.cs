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
    public partial class AddItem_Todolist : Form
    {
        public AddItem_Todolist()
        {
            InitializeComponent();
        }

        List<string> colorType = new List<string>();
        List<string> nameType = new List<string>();

        #region Hàm load
        private void AddItem_Todolist_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable allTypeColor = WorkPlace.bang_AllTYPEITEM_TDL;
                for (int i = 0; i <allTypeColor.Rows.Count; i++)
                {
                    string colortype = allTypeColor.Rows[i]["TYPECOLOR"].ToString();
                    string nametype= allTypeColor.Rows[i]["NAMETYPE"].ToString();
                    colorType.Add(colortype);
                    nameType.Add(nametype);
                }
                foreach (var item in nameType)
                {
                    type_combobox.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AddItem_Todolist_Load: " + ex.Message);
            }
            

        }

        #endregion


        #region Create + Cancle
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(taskname_textBox.Text))
                {
                    MessageBox.Show("Task name không được để trống!");
                    taskname_textBox.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(type_combobox.Text))
                {
                    MessageBox.Show("Type không được để trống!");
                    return;
                }

                Color temp = typeColor_iconButton.IconColor;

                int index = colorType.FindIndex(a => a == ColorTranslator.ToHtml(temp));
                if (index < 0)
                {
                    string typeColor = ColorTranslator.ToHtml(temp);
                    string nametype = type_combobox.Text.ToLower();

                    DAO.AccountDAO.Instance.Add_TYPEITEM_TDL(UserInfo.Instance.Username, typeColor, nametype);
                    WorkPlace.bang_AllTYPEITEM_TDL = DAO.AccountDAO.Instance.GetAll_TYPEITEM_TDL(UserInfo.Instance.Username);
                    this.colorType.Add(typeColor);
                    this.nameType.Add(nametype);
                }
                else
                {
                    if (type_combobox.SelectedIndex!=index)
                    {
                        MessageBox.Show("TYPE không hợp lệ!");
                        type_combobox.Text = "";
                        type_combobox.Focus();
                        return;
                    }
                }

                string username = UserInfo.Instance.Username;
                DateTime datetimecreate = DateTime.Now;
                string taskname = taskname_textBox.Text;

                int year = date_monthCalendar.SelectionRange.Start.Year;
                int month = date_monthCalendar.SelectionRange.Start.Month;
                int day=date_monthCalendar.SelectionRange.Start.Day;
                int hour = time_dateTimePicker.Value.Hour;
                int minute = time_dateTimePicker.Value.Minute;
                int second = time_dateTimePicker.Value.Second;
                DateTime datetimedeadline = new DateTime(year, month, day, hour, minute, second);

                string note = note_textBox.Text;
                bool done = false;
                string pk_color = username + ColorTranslator.ToHtml(temp);
                
                if (note==note_textBox.Tag.ToString())
                {
                    note = "";
                }

                DAO.AccountDAO.Instance.Add_TASK_TDL(username, datetimecreate, taskname, datetimedeadline, note, done, pk_color);
                WorkPlace.bang_AllTASK_TDL = DAO.AccountDAO.Instance.GetAll_TASK_TDL(UserInfo.Instance.Username);
               
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AddItem_Todolist_btnCreate_click: " + ex.Message);
            }

        }
        #endregion

        #region Placeholder

        private void taskname_textBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == textBox.Tag.ToString())
            {
                textBox.ForeColor = SacMau.dendam;
                textBox.Text = "";
            }

        }

        private void taskname_textBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.ForeColor = Color.Silver;
                textBox.Text = textBox.Tag.ToString();
            }
        }
        #endregion

        #region phần type

        private void typeColor_iconButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog()==DialogResult.OK)
            {
                typeColor_iconButton.IconColor = colorDialog.Color;
                int index = colorType.FindIndex(a => a == colorDialog.Color.Name.ToString());
                if (index > -1)
                {
                    type_combobox.SelectedIndex = index;
                }
            }
              
                

        }
        private void type_combobox_TextChanged(object sender, EventArgs e)
        {
            int index = nameType.FindIndex(a => a == type_combobox.Text.ToLower());
            if (index>-1)
            {
                string hex = colorType[index];
                Color temp = System.Drawing.ColorTranslator.FromHtml(hex);
                typeColor_iconButton.IconColor = temp;
            }
        }

        #endregion


    }
}
