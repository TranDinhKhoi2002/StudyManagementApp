using StudyManagementApp.TodolistFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyManagementApp
{
    public partial class TodoExportForm : Form
    {
        public TodoExportForm()
        {
            InitializeComponent();
            TypesRadioButton.Checked = true;
        }

        private void TodoExportButton_Click(object sender, EventArgs e)
        {
            if (TypesRadioButton.Checked == true)
            {
                var lines = new List<string>();
                string[] columnNames = WorkPlace.bang_AllTYPEITEM_TDL.Columns
                    .Cast<DataColumn>()
                    .Select(column => column.ColumnName)
                    .ToArray();

                var header = string.Join(",", columnNames.Select(name => $"\"{name}\""));
                lines.Add(header);

                var valueLines = WorkPlace.bang_AllTYPEITEM_TDL.AsEnumerable()
                    .Select(row => string.Join(",", row.ItemArray.Select(val => $"\"{val}\"")));
                string ExcelFilePath = "";
                lines.AddRange(valueLines);
                SaveFileDialog open = new SaveFileDialog();
                open.Filter = "xml files (*.xls)|*.xls|All files (*.*)|*.*";

                if (open.ShowDialog() == DialogResult.OK)
                    ExcelFilePath = open.FileName;

                if (open.FileName == "")
                    ExcelFilePath = "No name";

                File.WriteAllLines(ExcelFilePath, lines, Encoding.UTF8);
                InformSuccess inform = new InformSuccess();
                inform.Show();
             
            }
           if (TasksRadioButtion.Checked == true)
            {
                var lines = new List<string>();
                string[] columnNames = WorkPlace.bang_AllTASK_TDL.Columns
                    .Cast<DataColumn>()
                    .Select(column => column.ColumnName)
                    .ToArray();

                var header = string.Join(",", columnNames.Select(name => $"\"{name}\""));
                lines.Add(header);

                var valueLines = WorkPlace.bang_AllTASK_TDL.AsEnumerable()
                    .Select(row => string.Join(",", row.ItemArray.Select(val => $"\"{val}\"")));
                string ExcelFilePath = "";
                lines.AddRange(valueLines);

                SaveFileDialog open = new SaveFileDialog();
                open.Filter = "xml files (*.xls)|*.xls|All files (*.*)|*.*";
                if (open.ShowDialog() == DialogResult.OK)
                    ExcelFilePath = open.FileName;
                if (open.FileName == "")
                    ExcelFilePath = "No name";

                File.WriteAllLines(ExcelFilePath, lines, Encoding.UTF8);

                InformSuccess inform = new InformSuccess();
                inform.Show();
             
            }    
            
        }
    }
}
