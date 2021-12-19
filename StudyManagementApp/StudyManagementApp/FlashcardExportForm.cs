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
                string[] columnNames = FlashCardForm.FCDetail.Columns
                    .Cast<DataColumn>()
                    .Select(column => column.ColumnName)
                    .ToArray();

                var header = string.Join(",", columnNames.Select(name => $"\"{name}\""));
                lines.Add(header);

                var valueLines = FlashCardForm.FCDetail.AsEnumerable()
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
            if (DeckRadioButton.Checked == true)
            {
                var lines = new List<string>();
                string[] columnNames = FlashCardForm.deckTab.Columns
                    .Cast<DataColumn>()
                    .Select(column => column.ColumnName)
                    .ToArray();

                var header = string.Join(",", columnNames.Select(name => $"\"{name}\""));
                lines.Add(header);

                var valueLines = FlashCardForm.deckTab.AsEnumerable()
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
