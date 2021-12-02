using LiveCharts;
using LiveCharts.Wpf;
using StudyManagementApp.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyManagementApp
{
    public partial class ProgressForm : Form
    {
        Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);
        int totalCompleted = 0;
        int totalPastDue = 0;

        public ProgressForm()
        {
            InitializeComponent();

            var strCons = DataProvider.Instance.SqlConn;
            var sqlConn = new SqlConnection(strCons);
            sqlConn.Open();

            var sqlCommand = new SqlCommand("SELECT * FROM TASK WHERE USERNAME= '" + UserInfo.Instance.Username + "'", sqlConn);

            var reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                if (reader["DONE"].ToString() == "True")
                {
                    totalCompleted++;
                }
                else if (reader["DONE"].ToString() == "False")
                {
                    totalPastDue++;
                }
            }

            dtgvTodo.Rows.Add("Completed", totalCompleted);
            dtgvTodo.Rows.Add("Past Due", totalPastDue);

            sqlConn.Close();

            SeriesCollection series = new SeriesCollection();

            series.Add(new PieSeries()
            {
                Title = "Completed",
                Values = new ChartValues<int> { totalCompleted },
                DataLabels = true,
                LabelPoint = labelPoint
            });

            series.Add(new PieSeries()
            {
                Title = "Past Due",
                Values = new ChartValues<int> { totalPastDue },
                DataLabels = true,
                LabelPoint = labelPoint
            });
            pieChartToDo.Series = series;
            pieChartToDo.LegendLocation = LegendLocation.Bottom;
        }
    }
}
