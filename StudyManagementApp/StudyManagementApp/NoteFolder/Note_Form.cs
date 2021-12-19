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
    public partial class Note_Form : Form
    {
        List<Item_Note_Form> mang_item_Note_Forms = new List<Item_Note_Form>();
        static public DataTable All_notesitem;
        
        public Note_Form()
        {
            InitializeComponent();
          
        }


        public void LoadDATA()
        {
            DataTable all_notesitem = WorkPlace.bang_ALLNOTES;
            for (int i = 0; i < mang_item_Note_Forms.Count; i++)
            {
                main_flowLayoutPanel.Controls.Remove(mang_item_Note_Forms[i]);
            }
            mang_item_Note_Forms.Clear();
            
            for (int i = 0; i <all_notesitem.Rows.Count ; i++)
            {
                string pk_Notes = all_notesitem.Rows[i]["PK_NOTES"].ToString();
                DateTime datetimeCreate = (DateTime)all_notesitem.Rows[i]["DATETIMECREATE"];
                string title = all_notesitem.Rows[i]["TITLE"].ToString();
                string content = all_notesitem.Rows[i]["CONTENT"].ToString();
                string color_ID = all_notesitem.Rows[i]["COLOR_ID"].ToString();
                Item_Note_Form temp = new Item_Note_Form(pk_Notes, datetimeCreate, title, content, color_ID);
                mang_item_Note_Forms.Add(temp);
            }
            mang_item_Note_Forms.Reverse();
            for (int i = 0; i < mang_item_Note_Forms.Count; i++)
            {
                mang_item_Note_Forms[i].TopLevel = false;
                main_flowLayoutPanel.Controls.Add(mang_item_Note_Forms[i]);
                mang_item_Note_Forms[i].Show();
            }
            All_notesitem = all_notesitem;
           
        }

        public new void Show()
        {
            LoadDATA();
            LoadMau();
            base.Show();
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

        private void Note_Form_Load(object sender, EventArgs e)
        {
            LoadDATA();
        }
        private void Note_Form_Paint(object sender, PaintEventArgs e)
        {
            LoadDATA();
        }

        private void AddNote_iconButton_Click(object sender, EventArgs e)
        {
            DAO.AccountDAO.Instance.Add_NOTESITEM(UserInfo.Instance.Username, DateTime.Now, "Untitled", "", Item_Note_Form.colors[0]);
            WorkPlace.bang_ALLNOTES = DAO.AccountDAO.Instance.GetAll_ITEMNOTES(UserInfo.Instance.Username);
            LoadDATA();
        }

        
    }
}
