using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace StudyManagementApp
{
    class Email
    {
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

        public static void SendEmail(string _toEmail, out string code)
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
            MailAddress toEmail = new MailAddress(_toEmail, "Someone");

            Random rd = new Random();
            code = rd.Next(100000, 1000000).ToString();
            MailMessage message = new MailMessage()
            {
                From = fromEmail,
                Subject = "Verify your account",
                Body = "Your verification code is: " + code
            };
            message.To.Add(toEmail);

            client.SendCompleted += Client_SendCompleted; ;
            client.SendMailAsync(message);
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
