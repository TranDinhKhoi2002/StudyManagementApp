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

namespace StudyManagementApp
{
    public partial class VerificationCodeForm : Form
    {
        string verifyCode, userName;
        public VerificationCodeForm(string code, string _userName)
        {
            InitializeComponent();
            verifyCode = code;
            userName = _userName;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (txbCode.Texts == "" || txbNewPassword.Texts == "" || txbConfirmPassword.Texts == "")
            {
                MessageBox.Show("Verification code or password can't be blank", "Error");
            }
            else if (txbCode.Texts != verifyCode)
            {
                MessageBox.Show("Verification code is not correct", "Error");
            }
            else if (txbNewPassword.Texts != txbConfirmPassword.Texts)
            {
                MessageBox.Show("Confirm password is not correct", "Error");
            }
            else
            {
                MessageBox.Show("Verify successfully", "Done");
                AccountDAO.Instance.ChangePassword(userName, txbNewPassword.Texts);
                this.Close();
            }
        }
    }
}
