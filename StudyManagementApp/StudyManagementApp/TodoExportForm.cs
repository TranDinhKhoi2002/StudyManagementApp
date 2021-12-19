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
                string[] columnNames = Todolist_Form.TypeItem.Columns
                    .Cast<DataColumn>()
                    .Select(column => column.ColumnName)
                    .ToArray();

                var header = string.Join(",", columnNames.Select(name => $"\"{name}\""));
                lines.Add(header);

                var valueLines = Todolist_Form.TypeItem.AsEnumerable()
                    .Select(row => string.Join(",", row.ItemArray.Select(val => $"\"{val}\"")));
                string ExcelFilePath = "";
                lines.AddRange(valueLines);
                SaveFileDialog open = new SaveFileDialog();
                open.Filter = "xml files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                if (open.ShowDialog() == DialogResult.OK)
                    ExcelFilePath = open.FileName;
                File.WriteAllLines(ExcelFilePath, lines, Encoding.UTF8);
                MessageBox.Show("Saved successfully.", "Congratulation!");
            }
           if (TasksRadioButtion.Checked == true)
            {
                var lines = new List<string>();
                string[] columnNames = Todolist_Form.Task.Columns
                    .Cast<DataColumn>()
                    .Select(column => column.ColumnName)
                    .ToArray();

                var header = string.Join(",", columnNames.Select(name => $"\"{name}\""));
                lines.Add(header);

                var valueLines = Todolist_Form.Task.AsEnumerable()
                    .Select(row => string.Join(",", row.ItemArray.Select(val => $"\"{val}\"")));
                string ExcelFilePath = "";
                lines.AddRange(valueLines);
                SaveFileDialog open = new SaveFileDialog();
                open.Filter = "xml files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                if (open.ShowDialog() == DialogResult.OK)
                    ExcelFilePath = open.FileName;
                File.WriteAllLines(ExcelFilePath, lines, Encoding.UTF8);
                MessageBox.Show("Saved successfully.", "Congratulation!");
            }    
            
        }
    }
}
