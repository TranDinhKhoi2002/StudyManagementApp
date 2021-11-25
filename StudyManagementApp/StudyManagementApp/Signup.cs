using StudyManagementApp.DAO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudyManagementApp
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
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

            UsernameTextBox.BackColor = x;
            UsernameTextBox.ForeColor = t;
            UsernameTextBox.BorderFocusColor = t;
            UsernameTextBox.BorderColor = u;
            UsernameTextBox.PlaceholderColor = u;

            PasswordTextBox.BackColor = x;
            PasswordTextBox.ForeColor = t;
            PasswordTextBox.BorderFocusColor = t;
            PasswordTextBox.BorderColor = u;
            PasswordTextBox.PlaceholderColor = u;

            RePasswordTextbox.BackColor = x;
            RePasswordTextbox.ForeColor = t;
            RePasswordTextbox.BorderFocusColor = t;
            RePasswordTextbox.BorderColor = u;
            RePasswordTextbox.PlaceholderColor = u;

            Email_TextBox.BackColor = x;
            Email_TextBox.ForeColor = t;
            Email_TextBox.BorderFocusColor = t;
            Email_TextBox.BorderColor = u;
            Email_TextBox.PlaceholderColor = u;
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

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Texts == "")
                lbInstruction.Text = "Username can't be blank!";
            else if (PasswordTextBox.Texts == "")
                lbInstruction.Text = "Password can't be blank!";
            else if (RePasswordTextbox.Texts == "")
                lbInstruction.Text = "Re-Password can't be blank!";
            else if (PasswordTextBox.Texts != RePasswordTextbox.Texts)
                lbInstruction.Text = "Re-Password don't match!";
            else
            {
                try
                {
                    string username = UsernameTextBox.Texts;
                    string password = PasswordTextBox.Texts;

                    if (AccountDAO.Instance.Signup(username, password) == true)
                    {
                        lbInstruction.Text = "Sign-up successfully!";
                    }
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    lbInstruction.Text = "Username existed, try another one!";
                }
                catch (Exception exception)
                {
                    lbInstruction.Text = "Exception: " + exception.ToString();
                }
            }
        }

     
        private void Signup_Load(object sender, EventArgs e)
        {
            SignUpButton.Select();
            LoadMau();
        }
    }
}
