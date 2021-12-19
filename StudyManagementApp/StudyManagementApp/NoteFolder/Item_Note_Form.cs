using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyManagementApp.NoteFolder
{
    public partial class Item_Note_Form : Form
    {
        public static List<string> colors = new List<string> 
        {
            "#3b6061",
            "#6E4B2E",
            "#394C63",
            "#686134",
            "#563B61",
            "#66363E"
        };

        string pk_Notes;
        DateTime datetimeCreate;
        string title;
        string content;
        string color_ID;

        public Item_Note_Form()
        {
            InitializeComponent();
        }
        public Item_Note_Form(string pk_notes, DateTime datetimecreate, string titLE, string contenT, string color_id)
        {
            InitializeComponent();
            pk_Notes = pk_notes;
            datetimeCreate = datetimecreate;
            title = titLE;
            content = contenT;
            color_ID = color_id;
        }
        private void color_comboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                string text = color_comboBox.Items[e.Index].ToString();

                Color color = ColorTranslator.FromHtml(text);
                Brush pincel = new SolidBrush(color);

                e.Graphics.FillRectangle(pincel, new Rectangle(e.Bounds.X+1, e.Bounds.Y+2, 48, e.Bounds.Height-4));
                e.DrawFocusRectangle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void HamDoiMau(Color x)
        {
            this.BackColor = x;
        }

        void LoadMau()
        {
            if (Program.Theme == true)
            {
                HamDoiMau(SacMau.trangvua);
            }
            else
            {
                HamDoiMau(SacMau.dendam);
            }
        }

        private void Item_Note_Form_Load(object sender, EventArgs e)
        {
            foreach (var item in colors)
            {
                color_comboBox.Items.Add(item);
            }
            LoadDATA();
            LoadMau();
        }

        void LoadDATA()
        {
            Noti_iconButton.Text = datetimeCreate.ToString("dd/MM/yyyy hh:mm tt");
            content_richTextBox.Text = content;
            title_textBox.Text = title;
            color_comboBox.SelectedIndex = colors.IndexOf(color_ID);
        }

        void Update_NOTESITEM()
        {
            string query = "UPDATE_NOTEITEM @pk_notes , @title , @content , @color_id ";
            DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { pk_Notes, title, content, color_ID });
            WorkPlace.bang_ALLNOTES = DAO.AccountDAO.Instance.GetAll_ITEMNOTES(UserInfo.Instance.Username);
        }

        private void color_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hex = color_comboBox.Items[color_comboBox.SelectedIndex].ToString();
            Color color = ColorTranslator.FromHtml(hex);
            mainbackground_panel.BackColor = color;
            title_textBox.BackColor = color;
            color_ID = hex;
            Update_NOTESITEM();
        }

        private void close_iconButton_Click(object sender, EventArgs e)
        {
            string query = "DELETE_NOTEITEM @pk_notes ";
            DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { pk_Notes });
            WorkPlace.bang_ALLNOTES = DAO.AccountDAO.Instance.GetAll_ITEMNOTES(UserInfo.Instance.Username);
            this.Close();
        }

        private void title_textBox_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(title_textBox.Text))
            {
                title_textBox.Text = "Untitled";
                return;
            }    
            if (title_textBox.Text != "Untitled")
            {
                title = title_textBox.Text;
                Update_NOTESITEM();
            }
        }

        private void content_richTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(title_textBox.Text))
            {
                return;
            }
            else
            {
                content = content_richTextBox.Text;
                Update_NOTESITEM();
            }
        }

        private void content_richTextBox_TextChanged(object sender, EventArgs e)
        {
            Note_Form temp = new Note_Form();               
            temp.LoadDATA();
        }
    }
}
