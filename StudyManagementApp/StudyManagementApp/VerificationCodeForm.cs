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
        public VerificationCodeForm()
        {
            InitializeComponent();
        }
        public VerificationCodeForm(string code, string _userName)
        {
            InitializeComponent();
            verifyCode = code;
            userName = _userName;
        }

        public new void Show()
        {
            LoadMau();
            base.Show();
        }

        void HamDoiMau(Color x, Color y, Color z, Color t, Color u)
        {
            this.BackColor = x;
            lbInstruction.ForeColor = y;
            lbInstruction.BackColor = z;

            txbCode.BackColor = x;
            txbCode.ForeColor = t;
            txbCode.BorderFocusColor = t;
            txbCode.BorderColor = u;
            txbCode.PlaceholderColor = u;

            txbNewPassword.BackColor = x;
            txbNewPassword.ForeColor = t;
            txbNewPassword.BorderFocusColor = t;
            txbNewPassword.BorderColor = u;
            txbNewPassword.PlaceholderColor = u;

            txbConfirmPassword.BackColor = x;
            txbConfirmPassword.ForeColor = t;
            txbConfirmPassword.BorderFocusColor = t;
            txbConfirmPassword.BorderColor = u;
            txbConfirmPassword.PlaceholderColor = u;
        }

        void LoadMau()
        {
            if (Program.Theme == true)
            {
                HamDoiMau(SacMau.trangvua, Color.White, Color.Gray, SacMau.dendam, Color.Gray);


            }
            else
            {
                HamDoiMau(SacMau.dendam, SacMau.trangvua, SacMau.dennhat, SacMau.trangvua, Color.Gray);

            }
        }


        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (txbCode.Texts == "" || txbNewPassword.Texts == "" || txbConfirmPassword.Texts == "")
            {
                lbInstruction.Text = "Verification code or password can't be blank";
            }
            else if (txbCode.Texts != verifyCode)
            {
                lbInstruction.Text = "Verification code is not correct";
             
            }
            else if (txbNewPassword.Texts != txbConfirmPassword.Texts)
            {
                lbInstruction.Text = "Confirm password is not correct";
            }
            else
            {
                lbInstruction.Text = "Verify successfully";
                AccountDAO.Instance.ChangePassword(userName, txbNewPassword.Texts);
                txbCode.Texts = txbNewPassword.Texts = txbConfirmPassword.Texts = "";
            }
        }
    }
}
