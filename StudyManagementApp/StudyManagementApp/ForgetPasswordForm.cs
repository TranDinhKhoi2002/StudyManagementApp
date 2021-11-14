using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudyManagementApp.DAO;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;
using System.Globalization;

namespace StudyManagementApp
{
    public partial class ForgetPasswordForm : Form
    {
        public ForgetPasswordForm()
        {
            InitializeComponent();
        }

        public static string DomainMapper { get; private set; }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }
            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper, RegexOptions.None, TimeSpan.FromMilliseconds(200));
                
                string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();
                    string domainName = idn.GetAscii(match.Groups[2].Value);
                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            catch (AggregateException)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        Random rd;
        string code;

        private void button1_Click(object sender, EventArgs e)
        {
            if(txbEmail.Text == "" || txbUserName.Text == "")
            {
                MessageBox.Show("User name or email can't be blank");
            }
            else if(!AccountDAO.Instance.UserExist(txbUserName.Text))
            {
                MessageBox.Show("User can't be found", "Error");
            }
            else if (!IsValidEmail(txbEmail.Text))
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
                MailAddress toEmail = new MailAddress(txbEmail.Text, "Someone");

                rd = new Random();
                code = rd.Next(100000, 1000000).ToString();
                MailMessage message = new MailMessage()
                {
                    From = fromEmail,
                    Subject = "Verify your account",
                    Body = "Your verification code is: " + code
                };
                message.To.Add(toEmail);

                client.SendCompleted += Client_SendCompleted;
                client.SendMailAsync(message);
            }
        }

        private void Client_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("Something wrong: " + e.Error.Message, "Error");
                return;
            }

            MessageBox.Show("Sent successfully", "Done");
            VerificationCodeForm vefCodeForm = new VerificationCodeForm(code, txbUserName.Text);
            vefCodeForm.ShowDialog();
        }
    }
}
