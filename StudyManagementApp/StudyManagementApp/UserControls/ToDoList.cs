using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using StudyManagementApp.DAO;


namespace StudyManagementApp.UserControls
{
    public partial class ToDoList : UserControl
    {
        
        //Load Form
        public ToDoList()
        {
            InitializeComponent();
            
        }
        #region Load Form todolist
        private void ToDoList_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.Font = new Font(dataGridView1.Font.FontFamily, 13);

            dateTimePicker1.Value = DateTime.Now;
            
            ReLoadData();
        }
        #endregion

        #region 2 Nút Add, Delete Selected
        private void btn_AddTask_Click(object sender, EventArgs e)
        {
            Form f = new AddTask();
            f.ShowDialog();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (CountCheckBox() > 0)
                {

                    var strCons = DataProvider.Instance.SqlConn;
                    var sqlConn = new SqlConnection(strCons);
                    sqlConn.Open();

                    for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
                    {
                        bool ischeck = (bool)dataGridView1.Rows[i].Cells[0].Value;
                        if (ischeck)
                        {
                            var sqlCommand = new SqlCommand("DELETE FROM [StudyManagementApp].[dbo].[TASK] " +
                                                    " WHERE USERNAME = '" + UserInfo.Instance.Username + "'"
                                                    + " AND DATECREATE = '" + DataProvider.Instance.User_Time_Choose.ToString("yyyy-MM-dd") + "'"
                                                    + " AND DESCIPTION = '" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "'", sqlConn);
                            sqlCommand.ExecuteNonQuery();
                        }
                    }
                    sqlConn.Close();
                    MessageBox.Show("Xóa thành công");
                    refreshToolStripMenuItem_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Chưa chọn cái nào sao xóa");
                }
            }
            else
            {
                MessageBox.Show("Có gì đâu mà xóa!");
            }
        }

        // Đếm số lượng checkbox ng dùng tick vào để xóa
        private int CountCheckBox()
        {
            int count = 0;
            for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
            {

                if ((bool)dataGridView1.Rows[i].Cells[0].Value)
                {
                    count++;
                }
            }
            return count;
        }

        #endregion

        #region Event cuốn lịch
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DataProvider.Instance.User_Time_Choose = dateTimePicker1.Value;
            ReLoadData();
        }
        #endregion

        #region Event DataGrid
        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ReLoadData();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(new Point(MousePosition.X, MousePosition.Y));
            }
        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                contextMenuStrip2.Show(new Point(MousePosition.X, MousePosition.Y));
            }
        }
        #endregion

        #region Bấm chuột phải nó hiện ra event đống này
        private void markAsCompletedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.SelectedRows[0].Index;

            var strCons = DataProvider.Instance.SqlConn;
            var sqlConn = new SqlConnection(strCons);
            sqlConn.Open();
            var sqlCommand = new SqlCommand("UPDATE TASK SET DONE = 'Completed'" +
                                            " WHERE USERNAME = '" + UserInfo.Instance.Username + "'"
                                            + " AND DATECREATE = '" + DataProvider.Instance.User_Time_Choose.ToString("yyyy-MM-dd") + "'"
                                            + " AND DESCIPTION = '" + dataGridView1.Rows[rowindex].Cells[1].Value.ToString() + "'", sqlConn);
            sqlCommand.ExecuteNonQuery();
            sqlConn.Close();
            refreshToolStripMenuItem_Click(sender, e);
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.SelectedRows[0].Index;
            var strCons = DataProvider.Instance.SqlConn;
            var sqlConn = new SqlConnection(strCons);
            sqlConn.Open();
            var sqlCommand = new SqlCommand("DELETE FROM TASK" +
                                            " WHERE USERNAME = '" + UserInfo.Instance.Username + "'"
                                            + " AND DATECREATE = '" + DataProvider.Instance.User_Time_Choose.ToString("yyyy-MM-dd") + "'"
                                            + " AND DESCIPTION = '" + dataGridView1.Rows[rowindex].Cells[1].Value.ToString() + "'", sqlConn);
            sqlCommand.ExecuteNonQuery();
            sqlConn.Close();
            refreshToolStripMenuItem_Click(sender, e);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDatabase();
            ReLoadData();
        }
        #endregion

        #region Func update
        public void UpdateDatabase()
        {

            var strCons = DataProvider.Instance.SqlConn;
            var sqlConn = new SqlConnection(strCons);
            sqlConn.Open();

            var sqlCommand = new SqlCommand("UPDATE TASK SET DONE='Past Due' " +
                                             " WHERE USERNAME = '" + UserInfo.Instance.Username + "'"
                                            + " AND DONE != 'Completed' "
                                            + $" AND TIMEEND < GETDATE()", sqlConn);
            sqlCommand.ExecuteNonQuery();
            sqlConn.Close();

        }
        public void ReLoadData()
        {
            dataGridView1.Rows.Clear();

            var strCons = DataProvider.Instance.SqlConn;
            var sqlConn = new SqlConnection(strCons);
            sqlConn.Open();

            var sqlCommand = new SqlCommand("SELECT * FROM TASK WHERE USERNAME=@User AND YEAR(DATECREATE) = @Year AND MONTH(DATECREATE) = @Month AND DAY(DATECREATE) = @Day", sqlConn);
            sqlCommand.Parameters.AddWithValue("@Year", DataProvider.Instance.User_Time_Choose.Year);
            sqlCommand.Parameters.AddWithValue("@Month", DataProvider.Instance.User_Time_Choose.Month);
            sqlCommand.Parameters.AddWithValue("@Day", DataProvider.Instance.User_Time_Choose.Day);
            sqlCommand.Parameters.AddWithValue("@User", UserInfo.Instance.Username);
            //sqlCommand.Parameters.AddWithValue("@Date", dateTimePicker1.Value);



            var reader = sqlCommand.ExecuteReader();



            while (reader.Read())
            {
                DateTime timestart = Convert.ToDateTime(reader["TIMESTART"]);
                DateTime timeend = Convert.ToDateTime(reader["TIMEEND"]);

                dataGridView1.Rows.Add(false, reader["DESCIPTION"].ToString(), "Personal", timestart.ToString("HH:m"), timeend.ToString("HH:mm"), reader["DONE"]);
            }
            sqlConn.Close();

            UpdateDatabase();
        }
        #endregion

        #region 4 Nút Sort:All, Pending....
        private void btn_Task_Click(object sender, EventArgs e)
        {

        }

        private void btn_complete_Click(object sender, EventArgs e)
        {

        }

        private void btn_PastDue_Click(object sender, EventArgs e)
        {

        }

        private void btn_Pending_Click(object sender, EventArgs e)
        {

        }

        #endregion


    }
}
