using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyManagementApp.UserControls
{
    public partial class HelpUC : UserControl
    {
        public HelpUC()
        {
            InitializeComponent();
        }

        public new void Show()
        {
            LoadMau();
            base.Show();
        }

        void HamDoiMau(Color x, Color y, Color z,Color t)
        {
            this.BackColor = x;

            Pomodo_Title_Panel.BackColor = y;
            Pomodo_Content_Panel.BackColor = y;

            note_title_panel.BackColor = y;
            note_content_panel.BackColor = y;

            flashcard_title_panel.BackColor = y;
            flashcard_content_panel.BackColor = y;

            todo_title_panel.BackColor = y;
            todo_content_panel.BackColor = y;

            Lb_Instruction.ForeColor = z;
            
         
        }

        void LoadMau()
        {
            if (Program.Theme == true)
            {
               HamDoiMau(SacMau.trangvua, Color.Gray, Color.Gray,Color.Silver);
              
            }
            else
            {
                HamDoiMau(SacMau.dendam, SacMau.dennhat, SacMau.trangvua, Color.Gray);
               
            }
        }

        private void HelpUC_Load(object sender, EventArgs e)
        {
            LoadMau();
        }
    }
}
