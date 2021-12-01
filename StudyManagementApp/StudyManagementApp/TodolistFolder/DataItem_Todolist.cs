using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyManagementApp.TodolistFolder
{
    public class DataItem_Todolist
    {
        private DateTime DateTimeCreate;
        private string TaskName;
        private DateTime DateTimeDeadline;
        private string Note;
        private string PK_Color;
        private bool Done;
        public DataItem_Todolist()
        { }
        public DataItem_Todolist(DateTime dateTimeCreate, string taskName, DateTime dateTimeDeadline, string note, string pK_Color, bool done)
        {
            DateTimeCreate = dateTimeCreate;
            TaskName = taskName;
            DateTimeDeadline = dateTimeDeadline;
            Note = note;
            PK_Color = pK_Color;
            Done = done;
        }

        public DateTime dateTimeCreate { get => DateTimeCreate; set => DateTimeCreate = value; }
        public string taskName { get => TaskName; set => TaskName = value; }
        public DateTime dateTimeDeadline { get => DateTimeDeadline; set => DateTimeDeadline = value; }
        public string note { get => Note; set => Note = value; }
        public string pk_Color { get => PK_Color; set => PK_Color = value; }
        public bool done { get => Done; set => Done = value; }
    }
}
