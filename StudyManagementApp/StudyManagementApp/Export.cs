using StudyManagementApp.FlashCardFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyManagementApp
{
    public partial class Export : Form
    {
   
        enum State
        {
            Flashcard, Todo, Note, NULL
        }
        Color Flashcard, Todo, Note;
        State state = State.NULL;
        FlashcardExportForm frmFlashcard;
        TodoExportForm frmTodo;
        NoteExportForm frmNote;
        public Export()
        {
            InitializeComponent();
            Flashcard = Color.Teal;
            Todo = Color.SeaGreen;
            Note = Color.DarkGoldenrod;
        }
        public Export(string x)
        {
            InitializeComponent();
           
            if (x == "Flashcard")
            {
                state = State.Flashcard;
            }
            else if (x == "Todo")
            {
                state = State.Todo;
            }
            else
            {
                state = State.Note;
            }
        }

        private void Export_Load(object sender, EventArgs e)
        {
            switch (state)
            {
                case State.Flashcard:
                    this.Text = "Export Things In Flashcard";
                    frmFlashcard = new FlashcardExportForm();
                    frmFlashcard.TopLevel = false;
                    frmFlashcard.Dock = DockStyle.Fill;
                    main_panel.Controls.Add(frmFlashcard);
                    Title_Label.Text = "FlashCard";
                    Title_Label.ForeColor = Flashcard;
                    frmFlashcard.Show();
                    FlashcardExportButton.BackColor = Flashcard;
                    break;
                case State.Todo:
                    this.Text = "Export Things In To Do List";
                    frmTodo = new TodoExportForm();
                    frmTodo.TopLevel = false;
                    frmTodo.Dock = DockStyle.Fill;
                    main_panel.Controls.Add(frmTodo);
                    Title_Label.Text = "To Do List";
                    Title_Label.ForeColor = Todo;
                    frmTodo.Show();
                    TodoExportButton.BackColor = Todo;
                    break;
                case State.Note:
                    this.Text = "Export Things In Note";
                    frmNote = new NoteExportForm();        
                    frmNote.TopLevel = false;
                    frmNote.Dock = DockStyle.Fill;
                    main_panel.Controls.Add(frmNote);
                    Title_Label.Text = "Note";
                    Title_Label.ForeColor = Note;
                    frmNote.Show();
                    NoteExportButton.BackColor = Note;
                    break;
                default:
                    break;
            }
        }

        private void FlashcardExportButton_Click(object sender, EventArgs e)
        {
            PictureExcel.Visible = false;
            FlashCardForm fc = new FlashCardForm();
            fc.Show();
            fc.Close();
           
            if (state != State.Flashcard)
            {
                if (state == State.Todo)
                {
                    frmTodo.Close();
                    TodoExportButton.BackColor = Color.Transparent;
                }
                if (state == State.Note)
                {
                    frmNote.Close();
                    NoteExportButton.BackColor = Color.Transparent;
                }
                frmFlashcard = new FlashcardExportForm();
                frmFlashcard.TopLevel = false;
                frmFlashcard.Dock = DockStyle.Fill;
                main_panel.Controls.Add(frmFlashcard);
                Title_Label.Text = "Flashcard";
                Title_Label.ForeColor = Flashcard;
                frmFlashcard.Show();
                FlashcardExportButton.BackColor = Flashcard;
                state = State.Flashcard;
                this.Text = "Export Things In FlashCard";
            }
        }

        private void TodoExportButton_Click(object sender, EventArgs e)
        {
            PictureExcel.Visible = false;
           
            if (state != State.Todo)
            {
                if (state == State.Flashcard)
                {
                    frmFlashcard.Close();
                    FlashcardExportButton.BackColor = Color.Transparent;
                }
                if (state == State.Note)
                {
                    frmNote.Close();
                    NoteExportButton.BackColor = Color.Transparent;
                }
                frmTodo = new TodoExportForm();
                frmTodo.TopLevel = false;
                frmTodo.Dock = DockStyle.Fill;
                main_panel.Controls.Add(frmTodo);
                Title_Label.Text = "ToDo";
                Title_Label.ForeColor = Todo;
                frmTodo.Show();
                TodoExportButton.BackColor = Todo;
                state = State.Todo;
                this.Text = "Export Things In To Do List";
            }
        }
        private void NoteExportButton_Click(object sender, EventArgs e)
        {
            PictureExcel.Visible = false;
           
            if (state != State.Note)
            {
                if (state == State.Todo)
                {
                    frmTodo.Close();
                    TodoExportButton.BackColor = Color.Transparent;
                }
                if (state == State.Flashcard)
                {
                    frmFlashcard.Close();
                    FlashcardExportButton.BackColor = Color.Transparent;
                }
                frmNote = new NoteExportForm();
                frmNote.TopLevel = false;
                frmNote.Dock = DockStyle.Fill;
                main_panel.Controls.Add(frmNote);
                Title_Label.Text = "Note";
                Title_Label.ForeColor = Note;
                frmNote.Show();
                NoteExportButton.BackColor = Note;
                state = State.Note;
                this.Text = "Export Things In Note";
            }
        }
        private void close_iconButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
