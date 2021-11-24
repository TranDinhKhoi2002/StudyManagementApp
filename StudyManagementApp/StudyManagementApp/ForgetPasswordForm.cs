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

namespace StudyManagementApp
{
    public partial class ForgetPasswordForm : Form
    {
        public ForgetPasswordForm()
        {
            InitializeComponent();
        }

        public static string DomainMapper { get; private set; }

        public static string code;
        public static string username;

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txbEmail.Texts == "" || txbUserName.Texts == "")
            {
                lbInstruction.Text = "User name or email can't be blank";
            }
            else if (!AccountDAO.Instance.UserExist(txbUserName.Texts))
            {
                lbInstruction.Text = "User can't be found";
            }
            else if (!Email.IsValidEmail(txbEmail.Texts))
            {
                lbInstruction.Text = "Your email is invalid";
            }
            else
            {
                Email.SendEmail(txbEmail.Texts, out code);
                lbInstruction.Text = "Sent successfully";
                username = txbUserName.Texts;
                this.Hide();
            }
        }
    }
}
