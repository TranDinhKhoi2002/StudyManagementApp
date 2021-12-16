using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyManagementApp
{
    public partial class FeedBackForm_FAKE : Form
    {
        public FeedBackForm_FAKE()
        {
            InitializeComponent(); 
            KhoiTaoEmoji();
        }
        #region Emoji
        void KhoiTaoEmoji()
        {
            panel_00.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\00.png");
            panel_01.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\01.png");
            panel_02.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\02.png");
            panel_03.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\03.png");
            panel_04.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\04.png");
            panel_05.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\05.png");
            panel_06.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\06.png");
            panel_07.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\07.png");
            panel_08.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\08.png");
            panel_09.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\09.png");
            panel_10.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\10.png");
            panel_11.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\11.png");
            panel_12.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\12.png");
            panel_13.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\13.png");
            panel_14.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\14.png");
            panel_15.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\15.png");
            panel_16.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\16.png");
            panel_17.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\17.png");
            panel_18.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\18.png");
            panel_19.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\19.png");
            panel_20.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\20.png");
            panel_21.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\21.png");
            panel_22.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\22.png");
            panel_23.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\23.png");
            panel_24.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\24.png");
            panel_25.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\25.png");
            panel_26.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\26.png");
            panel_27.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\27.png");
            panel_28.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\28.png");
            panel_29.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\29.png");
            panel_30.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\30.png");
            panel_31.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\31.png");
            panel_32.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\32.png");
            panel_33.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\33.png");
            panel_34.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\34.png");
            panel_35.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\35.png");

            panel_00.BackgroundImageLayout = ImageLayout.Zoom;
            panel_01.BackgroundImageLayout = ImageLayout.Zoom;
            panel_02.BackgroundImageLayout = ImageLayout.Zoom;
            panel_03.BackgroundImageLayout = ImageLayout.Zoom;
            panel_04.BackgroundImageLayout = ImageLayout.Zoom;
            panel_05.BackgroundImageLayout = ImageLayout.Zoom;
            panel_06.BackgroundImageLayout = ImageLayout.Zoom;
            panel_07.BackgroundImageLayout = ImageLayout.Zoom;
            panel_08.BackgroundImageLayout = ImageLayout.Zoom;
            panel_09.BackgroundImageLayout = ImageLayout.Zoom;
            panel_10.BackgroundImageLayout = ImageLayout.Zoom;
            panel_11.BackgroundImageLayout = ImageLayout.Zoom;
            panel_12.BackgroundImageLayout = ImageLayout.Zoom;
            panel_13.BackgroundImageLayout = ImageLayout.Zoom;
            panel_14.BackgroundImageLayout = ImageLayout.Zoom;
            panel_15.BackgroundImageLayout = ImageLayout.Zoom;
            panel_16.BackgroundImageLayout = ImageLayout.Zoom;
            panel_17.BackgroundImageLayout = ImageLayout.Zoom;
            panel_18.BackgroundImageLayout = ImageLayout.Zoom;
            panel_19.BackgroundImageLayout = ImageLayout.Zoom;
            panel_20.BackgroundImageLayout = ImageLayout.Zoom;
            panel_21.BackgroundImageLayout = ImageLayout.Zoom;
            panel_22.BackgroundImageLayout = ImageLayout.Zoom;
            panel_23.BackgroundImageLayout = ImageLayout.Zoom;
            panel_24.BackgroundImageLayout = ImageLayout.Zoom;
            panel_25.BackgroundImageLayout = ImageLayout.Zoom;
            panel_26.BackgroundImageLayout = ImageLayout.Zoom;
            panel_27.BackgroundImageLayout = ImageLayout.Zoom;
            panel_28.BackgroundImageLayout = ImageLayout.Zoom;
            panel_29.BackgroundImageLayout = ImageLayout.Zoom;
            panel_30.BackgroundImageLayout = ImageLayout.Zoom;
            panel_31.BackgroundImageLayout = ImageLayout.Zoom;
            panel_32.BackgroundImageLayout = ImageLayout.Zoom;
            panel_33.BackgroundImageLayout = ImageLayout.Zoom;
            panel_34.BackgroundImageLayout = ImageLayout.Zoom;
            panel_35.BackgroundImageLayout = ImageLayout.Zoom;

            panel_00.Margin = new Padding(2);
            panel_01.Margin = new Padding(2);
            panel_02.Margin = new Padding(2);
            panel_03.Margin = new Padding(2);
            panel_04.Margin = new Padding(2);
            panel_05.Margin = new Padding(2);
            panel_06.Margin = new Padding(2);
            panel_07.Margin = new Padding(2);
            panel_08.Margin = new Padding(2);
            panel_09.Margin = new Padding(2);
            panel_10.Margin = new Padding(2);
            panel_11.Margin = new Padding(2);
            panel_12.Margin = new Padding(2);
            panel_13.Margin = new Padding(2);
            panel_14.Margin = new Padding(2);
            panel_15.Margin = new Padding(2);
            panel_16.Margin = new Padding(2);
            panel_17.Margin = new Padding(2);
            panel_18.Margin = new Padding(2);
            panel_19.Margin = new Padding(2);
            panel_20.Margin = new Padding(2);
            panel_21.Margin = new Padding(2);
            panel_22.Margin = new Padding(2);
            panel_23.Margin = new Padding(2);
            panel_24.Margin = new Padding(2);
            panel_25.Margin = new Padding(2);
            panel_26.Margin = new Padding(2);
            panel_27.Margin = new Padding(2);
            panel_28.Margin = new Padding(2);
            panel_29.Margin = new Padding(2);
            panel_30.Margin = new Padding(2);
            panel_31.Margin = new Padding(2);
            panel_32.Margin = new Padding(2);
            panel_33.Margin = new Padding(2);
            panel_34.Margin = new Padding(2);
            panel_35.Margin = new Padding(2);
        }

        private void panel_00_Click(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            string haikitucuoi = panel.Name.ToString().Substring(panel.Name.ToString().Length - 2, 2);
            if (panel.Tag.ToString()=="0")
            {
                panel.Tag = "1";
                panel.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\"+haikitucuoi+"_.png");
            }
            else
            {
                panel.Tag = "0";
                panel.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\Images\\" + haikitucuoi + ".png");
            }
        }
        #endregion

        #region PlaceHolder
        private void Email_Textbox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Tag.ToString() == "email")
            {
                if (textBox.Text == "Your Email")
                {
                    textBox.ForeColor = Color.Black;
                    textBox.Text = "";
                }
            }
            else if (textBox.Tag.ToString() == "problem")
            {
                if (textBox.Text== "Your Problem")
                {
                    textBox.ForeColor = Color.Black;
                    textBox.Text = "";
                }
            }
            else if (textBox.Tag.ToString() == "feedback")
            {
                if (textBox.Text== "Your Feedback")
                {
                    textBox.ForeColor = Color.Black;
                    textBox.Text = "";
                }
            }
        }

        private void Email_Textbox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Tag.ToString() == "email")
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.ForeColor = Color.Gray;
                    textBox.Text = "Your Email";
                }
            }
            else if (textBox.Tag.ToString() == "problem")
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.ForeColor = Color.Gray;
                    textBox.Text = "Your Problem";
                }
            }
            else if (textBox.Tag.ToString() == "feedback")
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.ForeColor = Color.Gray;
                    textBox.Text = "Your Feedback";
                }
            }
        }


        #endregion

        //Thuc ra cancle button la 1 panel co image background
        private void Cancle_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //bool isAttached = false;
        
        private void Send_Button_Click(object sender, EventArgs e)
        {
            if (txbEmail.Text == "" || txbSubject.Text == "" || rtxbFeedback.Text == "")
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Feedback nhắc nhở", "Email, Subject, FeedBack không được để trống nhé!");
                customMessageBox.ShowDialog();
            }
            else if (!Email.IsValidEmail(txbEmail.Text))
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Feedback nhắc nhở", "Có vẻ Email chưa đúng!");
                customMessageBox.ShowDialog();
            }
            else
            {
                SmtpClient client = new SmtpClient()
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential()
                    {
                        UserName = "trandinhkhoi102@gmail.com",
                        Password = "fjbkcbthlqcrdrtu"
                    }
                };

                MailAddress fromEmail = new MailAddress("trandinhkhoi102@gmail.com", "Khoi test email");
                MailAddress toEmailClient = new MailAddress(txbEmail.Text, "Someone");
                MailAddress toEmailProducer = new MailAddress("trandinhkhoi102@gmail.com", "Feedback from user with email" + txbEmail.Text);

                MailMessage messageThanks = new MailMessage()
                {
                    From = fromEmail,
                    Subject = "THANKS FOR YOUR FEEDBACK",
                    Body = "Thank you for your valuable feedback, we will try to improve the product in the future"
                };
                messageThanks.To.Add(toEmailClient);

                MailMessage messageFeedback = new MailMessage()
                {
                    From = fromEmail,
                    Subject = "FEEDBACK FROM USER",
                    Body = rtxbFeedback.Text
                };
                if (pathFile != "")
                {
                    messageFeedback.Attachments.Add(new Attachment(pathFile));
                }
                messageFeedback.To.Add(toEmailProducer);

                client.SendCompleted += Client_SendCompleted;
                client.Send(messageThanks);
                client.Send(messageFeedback);
                txbEmail.Clear();
                txbSubject.Clear();
                rtxbFeedback.Clear();
                txbEmail.Focus();
                CustomMessageBox customMessageBox = new CustomMessageBox("Feedback nhắc nhở", "Cám ơn bạn nhé!");
                customMessageBox.ShowDialog();
            }
        }

        private static void Client_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Feedback nhắc nhở", "Điều gì đó đã xảy ra: " + e.Error.Message);
                customMessageBox.ShowDialog();
                return;
            }
        }

        string pathFile = "";
        private void panelattach_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfDialog = new OpenFileDialog();
            opfDialog.Filter = ".jpg|*.jpg|.png|*.png|.gif|*.gif|.psd|*.psd";

            if (opfDialog.ShowDialog() == DialogResult.OK)
            {
                pathFile = opfDialog.FileName;
                NamFile_Label.Text = opfDialog.FileName;
            }
        }
    }
}
