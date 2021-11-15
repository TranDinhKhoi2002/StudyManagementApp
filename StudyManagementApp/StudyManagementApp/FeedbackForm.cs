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
    public partial class FeedbackForm : Form
    {
        public FeedbackForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbEmail.Text == "" || txbSubject.Text == "" || rtxbFeedback.Text == "")
            {
                MessageBox.Show("Email, Subject or Feedback can't be blank");
            }
            else if (!Email.IsValidEmail(txbEmail.Text))
            {
                MessageBox.Show("Your email is invalid");
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
                    Subject = txbSubject.Text,
                    Body = rtxbFeedback.Text
                };
                messageFeedback.To.Add(toEmailProducer);

                client.SendCompleted += Client_SendCompleted;
                client.Send(messageThanks);
                client.Send(messageFeedback);
                MessageBox.Show("Thank you for your feedback, we will try to be better in the future", "Done");
            }
        }

        private static void Client_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("Something wrong: " + e.Error.Message, "Error");
                return;
            }
        }
    }
}
