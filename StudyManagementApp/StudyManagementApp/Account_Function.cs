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
        State state = State.NULL;
        Signup frmSignup;
        ForgetPasswordForm frmForget;
        VerificationCodeForm frmVerify;
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
            switch (state)
            {
                case State.signup:
                    this.Text = "Sign-up with us";
                    frmSignup = new Signup();
                    frmSignup.TopLevel = false;
                    frmSignup.Dock = DockStyle.Fill;
                    main_panel.Controls.Add(frmSignup);
                    Title_Label.Text="Sign up";
                    Title_Label.ForeColor = signup;
                    frmSignup.Show();
                    SignUp_iconButton.BackColor = signup;
                    break;
                case State.forgot:
                    this.Text = "Don't worry! Your Password is right here";
                    frmForget = new ForgetPasswordForm();
                    frmForget.TopLevel = false;
                    frmForget.Dock = DockStyle.Fill;
                    main_panel.Controls.Add(frmForget);
                    Title_Label.Text = "Forgot";
                    Title_Label.ForeColor = forgot;
                    frmForget.Show();
                    ForgotPass_iconButton.BackColor = forgot;
                    break;
                case State.verify:
                    this.Text = "Let me know it's you";
                    if ((!string.IsNullOrEmpty(ForgetPasswordForm.code)) && !string.IsNullOrEmpty(ForgetPasswordForm.username))
                    {
                        frmVerify = new VerificationCodeForm(ForgetPasswordForm.code, ForgetPasswordForm.username);
                    }
                    else
                    {
                        frmVerify = new VerificationCodeForm();
                    }
                    frmVerify.TopLevel = false;
                    frmVerify.Dock = DockStyle.Fill;
                    main_panel.Controls.Add(frmVerify);
                    Title_Label.Text = "Verify";
                    Title_Label.ForeColor = verify;
                    frmVerify.Show();
                    Verify_iconButton.BackColor = verify;
                    break;
                default:
                    break;
            }

            LoadMau();
        }


        public new void Show()
        {
            LoadMau();
            base.Show();
        }

        void HamDoiMau(Color x, Color y)
        {
            this.BackColor = x;
            Title_panel.BackColor = y;
            close_panel.BackColor = y;
        }

        void LoadMau()
        {
            if (Program.Theme == true)
            {
                HamDoiMau(Color.Gray, SacMau.trangvua);


            }
            else
            {
                HamDoiMau(SacMau.dennhat, SacMau.dendam);

            }
        }



        private void Account_Function_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if(state==State.signup)
                {
                    frmSignup.Close();
                }    
                else if(state==State.forgot)
                {
                    frmForget.Close();
                }
                else if (state==State.verify)
                {
                    frmVerify.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Account_Function_closing: " + ex.Message);
            }
        }


        private void SignUp_iconButton_Click(object sender, EventArgs e)
        {
            if (state!=State.signup)
            {
                if (state==State.forgot)
                {
                    frmForget.Close();
                    ForgotPass_iconButton.BackColor = Color.Transparent;
                }
                if (state==State.verify)
                {
                    frmVerify.Close();
                    Verify_iconButton.BackColor = Color.Transparent;
                } 
                frmSignup = new Signup();
                frmSignup.TopLevel = false;
                frmSignup.Dock = DockStyle.Fill;
                main_panel.Controls.Add(frmSignup);
                Title_Label.Text = "Sign up";
                Title_Label.ForeColor = signup;
                frmSignup.Show();
                SignUp_iconButton.BackColor = signup;
                state = State.signup;
                this.Text = "Sign-up with us";
            }
        }

        private void close_iconButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ForgotPass_iconButton_Click(object sender, EventArgs e)
        {
            if (state != State.forgot)
            {
                if (state == State.signup)
                {
                    frmSignup.Close();
                    SignUp_iconButton.BackColor = Color.Transparent;
                }
                if (state == State.verify)
                {
                    frmVerify.Close();
                    Verify_iconButton.BackColor = Color.Transparent;
                }
                frmForget = new ForgetPasswordForm();
                frmForget.TopLevel = false;
                frmForget.Dock = DockStyle.Fill;
                main_panel.Controls.Add(frmForget);
                Title_Label.Text = "Forgot";
                Title_Label.ForeColor = forgot;
                frmForget.Show();
                ForgotPass_iconButton.BackColor = forgot;
                state = State.forgot;
                this.Text = "Don't worry! Your Password is right here";
            }
        }

        private void Verify_iconButton_Click(object sender, EventArgs e)
        {
            if (state != State.verify)
            {
                if (state == State.forgot)
                {
                    frmForget.Close();
                    ForgotPass_iconButton.BackColor = Color.Transparent;
                }
                if (state == State.signup)
                {
                    frmSignup.Close();
                    SignUp_iconButton.BackColor = Color.Transparent;
                }
                if ((!string.IsNullOrEmpty(ForgetPasswordForm.code)) && !string.IsNullOrEmpty(ForgetPasswordForm.username))
                {
                    frmVerify = new VerificationCodeForm(ForgetPasswordForm.code, ForgetPasswordForm.username);
                }
                else
                {
                    frmVerify = new VerificationCodeForm();
                }
                frmVerify.TopLevel = false;
                frmVerify.Dock = DockStyle.Fill;
                main_panel.Controls.Add(frmVerify);
                Title_Label.Text = "Verify";
                Title_Label.ForeColor = verify;
                frmVerify.Show();
                Verify_iconButton.BackColor = verify;
                state = State.verify;
                this.Text = "Let me know it's you";
            }
        }
    }
}
