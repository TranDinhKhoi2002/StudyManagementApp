using Microsoft.Office.Interop.Excel;
using StudyManagementApp.FlashCardFolder;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Excel.Application;
using StudyManagementApp.DAO;


namespace StudyManagementApp
{
    public partial class FlashcardExportForm : Form
    {
        public FlashcardExportForm()
        {
            InitializeComponent();
            DeckRadioButton.Checked = true;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (FCRadioButton.Checked == true)
            {
                var lines = new List<string>();
                string[] columnNames = FlashCardForm.fc.Columns
                    .Cast<DataColumn>()
                    .Select(column => column.ColumnName)
                    .ToArray();

                var header = string.Join(",", columnNames.Select(name => $"\"{name}\""));
                lines.Add(header);

                var valueLines = FlashCardForm.fc.AsEnumerable()
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
            if (DeckRadioButton.Checked == true)
            {
                var lines = new List<string>();

                
                string[] columnNames = FlashCardForm.deck.Columns
                    .Cast<DataColumn>()
                    .Select(column => column.ColumnName)
                    .ToArray();

                var header = string.Join(",", columnNames.Select(name => $"\"{name}\""));
                lines.Add(header);

                var valueLines = FlashCardForm.deck.AsEnumerable()
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
