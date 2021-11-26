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

namespace StudyManagementApp
{
    public partial class AddTask : Form
    {
        public AddTask()
        {
            InitializeComponent();
        }

        private void AddTask_Load(object sender, EventArgs e)
        {
            starttime_picker.CustomFormat = "HH:mm";
            endtime_picker.CustomFormat = "HH:mm";
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Apply_btn_Click(object sender, EventArgs e)
        {
            if (tb_descip.Text == "")
                MessageBox.Show("Nội dung desciption không được bỏ trống");
            else if (endtime_picker.Value.Hour * 60 + endtime_picker.Value.Minute - starttime_picker.Value.Hour * 60 - starttime_picker.Value.Minute <= 0)
            {
                MessageBox.Show("Thời gian endtime phải cách starttime ít nhất 1 phút");
            }
            else
            {
                try
                {

                    var strCons = DataProvider.Instance.SqlConn;
                    var sqlConn = new SqlConnection(strCons);
                    sqlConn.Open();

                    var sqlCommand = new SqlCommand("INSERT INTO [StudyManagementApp].[dbo].[TASK] VALUES ('" + UserInfo.Instance.Username + "','" + DataProvider.Instance.User_Time_Choose.ToString("yyyy-MM-dd") + "','" + tb_descip.Text + "','" + DataProvider.Instance.User_Time_Choose.ToString("yyyy-MM-dd ") + starttime_picker.Value.ToString(" HH:mm") + "','" + DataProvider.Instance.User_Time_Choose.ToString("yyyy-MM-dd ") + endtime_picker.Value.ToString("HH:mm") + "','Pending')", sqlConn);
                    sqlCommand.ExecuteNonQuery();

                    /*  var sqlCommand = new SqlCommand("Insert into [StudyManagementApp].[dbo].[TASK] values ('@USERNAME' , '@DATECREATE' , '@Desciption' , '@TimeStart' , '@TimeEnd' , NULL)",sqlConn);

                      sqlCommand.Parameters.Add("@USERNAME", UserInfo.instance.Username);
                      sqlCommand.Parameters.Add("@DATECREATE", DataProvider.Instance.User_Time_Choose.ToString("yyyy-MM-dd"));
                      sqlCommand.Parameters.Add("@Desciption", tb_descip.Text);
                      sqlCommand.Parameters.Add("@TimeStart", starttime_picker.Value.ToString("HH:mm"));
                      sqlCommand.Parameters.Add("@TimeEnd", endtime_picker.Value.ToString("HH:mm"));
                      sqlCommand.ExecuteNonQuery();*/



                    sqlConn.Close();
                    MessageBox.Show("Thêm thành công");
                    //Program.globalWorkPlace.RefreshTodoList();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }


            }
        }
    }
}
