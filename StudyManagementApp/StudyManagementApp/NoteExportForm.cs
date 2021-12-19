using ClosedXML.Excel;
using Microsoft.Office.Interop.Excel;
using StudyManagementApp.FlashCardFolder;
using StudyManagementApp.NoteFolder;
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
using Application = Microsoft.Office.Interop.Excel.Application;

namespace StudyManagementApp
{
    public partial class NoteExportForm : Form
    {
        public  NoteExportForm()
        {
            InitializeComponent();
        }

        private void NoteExportButton_Click(object sender, EventArgs e)
        {
          
           var lines = new List<string>();
            string[] columnNames = Note_Form.All_notesitem.Columns
                .Cast<DataColumn>()
                .Select(column => column.ColumnName)
                .ToArray();

            var header = string.Join(",", columnNames.Select(name => $"\"{name}\""));
            lines.Add(header);

            var valueLines = Note_Form.All_notesitem.AsEnumerable()
                .Select(row => string.Join(",", row.ItemArray.Select(val => $"\"{val}\"")));
            string ExcelFilePath = "";
            lines.AddRange(valueLines);
            SaveFileDialog open = new SaveFileDialog();
            open.Filter = "xml files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
                 ExcelFilePath = open.FileName;
            File.WriteAllLines(ExcelFilePath, lines, Encoding.UTF8);
            MessageBox.Show("Lưu thành công.", "Congratulation!");
        }
    }
}
