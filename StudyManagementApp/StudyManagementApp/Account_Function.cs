using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyManagementApp
{
    public partial class Account_Function : Form
    {
        enum State
        {
            signup, forgot, verify, NULL
        }
        Color signup, forgot, verify;
        
        Signup frmSignup = new Signup();
        ForgetPasswordForm frmForget = new ForgetPasswordForm();
        VerificationCodeForm frmVerify = new VerificationCodeForm();
        State state = State.NULL;

        public Account_Function()
        {
            InitializeComponent();
            signup = Color.FromArgb(154, 73, 18);
            forgot = Color.FromArgb(2, 158, 253);
            verify = Color.ForestGreen;
        }

        public Account_Function(string x)
        {
            InitializeComponent();
            if(x=="signup")
            {
                state = State.signup;
            }
            else if (x=="forgot")
            {
                state = State.forgot;
            }
            else
            {
                state = State.verify;
            }
            signup = Color.FromArgb(154, 73, 18);
            forgot = Color.FromArgb(2, 158, 253);
            verify = Color.ForestGreen;
        }

        private void Account_Function_Load(object sender, EventArgs e)
        {
            frmSignup.TopLevel = false;
            frmSignup.Dock = DockStyle.Fill;
            main_panel.Controls.Add(frmSignup);

            frmForget.TopLevel = false;
            frmForget.Dock = DockStyle.Fill;
            main_panel.Controls.Add(frmForget);


            frmVerify.TopLevel = false;
            frmVerify.Dock = DockStyle.Fill;
            main_panel.Controls.Add(frmVerify);

            switch (state)
            {
                case State.signup:
                    Title_Label.Text="Sign up";
                    Title_Label.ForeColor = signup;
                    frmSignup.Show();
                    SignUp_iconButton.BackColor = signup;
                    break;
                case State.forgot:
                    Title_Label.Text = "Forgot";
                    Title_Label.ForeColor = forgot;
                    frmForget.Show();
                    ForgotPass_iconButton.BackColor = forgot;
                    break;
                case State.verify:
                    Title_Label.Text = "Verify";
                    Title_Label.ForeColor = verify;
                    frmVerify.Show();
                    Verify_iconButton.BackColor = verify;
                    break;
                default:
                    break;
            }

        }

        

        private void SignUp_iconButton_Click(object sender, EventArgs e)
        {
            if (state!=State.signup)
            {
                if (state==State.forgot)
                {
                    frmForget.Hide();
                    ForgotPass_iconButton.BackColor = Color.Transparent;
                }
                if (state==State.verify)
                {
                    frmVerify.Hide();
                    Verify_iconButton.BackColor = Color.Transparent;
                }
                Title_Label.Text = "Sign up";
                Title_Label.ForeColor = signup;
                frmSignup.Show();
                SignUp_iconButton.BackColor = signup;
                state = State.signup;
            }
        }

        private void ForgotPass_iconButton_Click(object sender, EventArgs e)
        {
            if (state != State.forgot)
            {
                if (state == State.signup)
                {
                    frmSignup.Hide();
                    SignUp_iconButton.BackColor = Color.Transparent;
                }
                if (state == State.verify)
                {
                    frmVerify.Hide();
                    Verify_iconButton.BackColor = Color.Transparent;
                }
                Title_Label.Text = "Forgot";
                Title_Label.ForeColor = forgot;
                frmForget.Show();
                ForgotPass_iconButton.BackColor = forgot;
                state = State.forgot;
            }
        }

        private void Verify_iconButton_Click(object sender, EventArgs e)
        {
            if (state != State.verify)
            {
                if (state == State.forgot)
                {
                    frmForget.Hide();
                    ForgotPass_iconButton.BackColor = Color.Transparent;
                }
                if (state == State.signup)
                {
                    frmSignup.Hide();
                    SignUp_iconButton.BackColor = Color.Transparent;
                }
                if((!string.IsNullOrEmpty(ForgetPasswordForm.code)) && !string.IsNullOrEmpty(ForgetPasswordForm.username))
                {
                    frmVerify = new VerificationCodeForm(ForgetPasswordForm.code, ForgetPasswordForm.username);
                }
                Title_Label.Text = "Verify";
                Title_Label.ForeColor = verify;
                frmVerify.Show();
                Verify_iconButton.BackColor = verify;
                state = State.verify;
            }
        }
    }
}
