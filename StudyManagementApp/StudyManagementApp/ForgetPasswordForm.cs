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

        string code;

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txbEmail.Texts == "" || txbUserName.Texts == "")
            {
                MessageBox.Show("User name or email can't be blank", "Error");
            }
            else if (!AccountDAO.Instance.UserExist(txbUserName.Texts))
            {
                MessageBox.Show("User can't be found", "Error");
            }
            else if (!Email.IsValidEmail(txbEmail.Texts))
            {
                MessageBox.Show("Your email is invalid", "Error");
            }
            else
            {
                Email.SendEmail(txbEmail.Texts, out code);
                MessageBox.Show("Sent successfully", "Done");
                VerificationCodeForm vefCodeForm = new VerificationCodeForm(code, txbUserName.Texts);
                vefCodeForm.ShowDialog();
                this.Close();
            }
        }
    }
}
