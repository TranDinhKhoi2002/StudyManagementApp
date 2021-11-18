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

            Lb_Instruction.ForeColor = z;
            
            FeedBack_IconButton.IconColor = z;
            FeedBack_IconButton.FlatAppearance.MouseOverBackColor = t;
            FeedBack_IconButton.FlatAppearance.MouseDownBackColor = z;
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


        private void FeedBack_IconButton_Click(object sender, EventArgs e)
        {
            FeedBackForm_FAKE feedBackForm_FAKE = new FeedBackForm_FAKE();
            feedBackForm_FAKE.ShowDialog();
        }
    }
}
