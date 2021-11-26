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
using System.Data.SqlClient;

namespace StudyManagementApp.UserControls
{
    public partial class ToDoListTest : UserControl
    {
        public ToDoListTest()
        {
            InitializeComponent();
        }



        #region Func Reload, Update
        public void ReLoadData()
        {
            dataGridView1.Rows.Clear();

            var strCons = DataProvider.Instance.SqlConn;
            var sqlConn = new SqlConnection(strCons);
            sqlConn.Open();

            var sqlCommand = new SqlCommand();
            sqlCommand = new SqlCommand("SELECT * FROM TASK WHERE USERNAME= '" + UserInfo.Instance.Username + "' AND YEAR(DATECREATE) =" + DataProvider.Instance.User_Time_Choose.Year + "AND MONTH(DATECREATE) = " + DataProvider.Instance.User_Time_Choose.Month + " AND DAY(DATECREATE) = " + DataProvider.Instance.User_Time_Choose.Day, sqlConn);

            //sqlCommand.Parameters.AddWithValue("@Date", dateTimePicker1.Value);

            var reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                DateTime timestart = Convert.ToDateTime(reader["TIMESTART"]);
                DateTime timeend = Convert.ToDateTime(reader["TIMEEND"]);

                dataGridView1.Rows.Add(false, reader["DESCIPTION"].ToString(), "Personal", timestart.ToString("HH:m"), timeend.ToString("HH:mm"), reader["DONE"]);
            }
            sqlConn.Close();
        }

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
        #endregion

        #region 2 nút add delete
        private void Button1_Click(object sender, EventArgs e)
        {
            Form f = new AddTask();
            f.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
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
                    //refreshToolStripMenuItem_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Chọn vào ô checkbox item cần xóa!");
                }
            }
            else
            {
                MessageBox.Show("Có gì đâu mà xóa!");
            }
        }

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

        #region Event cuốn lịch, UI làm lại sau
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DataProvider.Instance.User_Time_Choose = dateTimePicker1.Value;
            ReLoadData();
        }
        #endregion

        #region Event DataGrid
        private void DataGridView1_SizeChanged(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ReLoadData();
        }

        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(new Point(MousePosition.X, MousePosition.Y));
            }
        }

        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {

                contextMenuStrip2.Show(new Point(MousePosition.X, MousePosition.Y));
            }
        }



        #endregion

        private void MarkAsCompleteToolStripMenuItem_Click(object sender, EventArgs e)
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
            RefreshToolStripMenuItem_Click(sender, e);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
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
            RefreshToolStripMenuItem_Click(sender, e);
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDatabase();
            ReLoadData();
        }
    }
}
