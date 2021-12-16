using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace StudyManagementApp
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox()
        {
            InitializeComponent();
        }

        string Title;
        string Content;
        public CustomMessageBox(string title, string content)
        {
            InitializeComponent();
            Title = title;
            Content = content;
        }

        private void CustomMessageBox_Load(object sender, EventArgs e)
        {
            Title_label.Text = Title;
            Content_label.Text = Content;
          
        }

        public new void ShowDialog()
        {
            SoundPlayer soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = Application.StartupPath + "\\Resources\\Sound\\Windows Background.wav";
            soundPlayer.Play();
            base.ShowDialog();
        }

        private void close_iconButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
