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
    public partial class AboutUC : UserControl
    {
        public AboutUC()
        {
            InitializeComponent();
        }
        public new void Show()
        {
            LoadMau();
            base.Show();
        }

        void HamDoiMau(Color x, Color y, Color z, Color t)
        {
            this.BackColor = x;
            GioiThieu_Label.BackColor = x;
            lbGroup.ForeColor = z;
            GioiThieu_Label.ForeColor = t;

        }

        void LoadMau()
        {
            if (Program.Theme == true)
            {
                HamDoiMau(SacMau.trangvua, SacMau.dennhat, Color.Gray,Color.Black);
                Name_PictureBox.Image = new Bitmap(Application.StartupPath + "\\Resources\\Images\\NameTrang.png");
                Gender_PictureBox.Image = new Bitmap(Application.StartupPath + "\\Resources\\Images\\GenderTrang.png");
                Gmail_PictureBox.Image = new Bitmap(Application.StartupPath + "\\Resources\\Images\\GmailTrang.png");

            }
            else
            {
                HamDoiMau(SacMau.dendam, SacMau.trangvua, SacMau.trangvua,Color.White);
                Name_PictureBox.Image = new Bitmap(Application.StartupPath + "\\Resources\\Images\\Name.png");
                Gender_PictureBox.Image = new Bitmap(Application.StartupPath + "\\Resources\\Images\\Gender.png");
                Gmail_PictureBox.Image = new Bitmap(Application.StartupPath + "\\Resources\\Images\\gmail.png");
            }
        }

      
    }
}
