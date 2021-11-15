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

        void HamDoiMau(Color x, Color y,Color z,Color t)
        {
            this.BackColor = x;
            lbInstruction.ForeColor = x;
            lbInstruction.BackColor = y;

            UsernameTextBox.BackColor = x;
            PasswordTextBox.BackColor = x;
            RePasswordTextbox.BackColor = x;

            UsernameTextBox.PlaceholderColor = z;
            PasswordTextBox.PlaceholderColor = z;
            RePasswordTextbox.PlaceholderColor = z;

            UsernameTextBox.BorderColor = z;
            PasswordTextBox.BorderColor = z;
            RePasswordTextbox.BorderColor = z;

            UsernameTextBox.ForeColor = t;
            PasswordTextBox.ForeColor = t;
            RePasswordTextbox.ForeColor = t;

            UsernameTextBox.BorderFocusColor = t;
            PasswordTextBox.BorderFocusColor = t;
            RePasswordTextbox.BorderFocusColor = t;
        }

        void LoadMau()
        {
            if (Program.Theme == true)
            {
                HamDoiMau(SacMau.trangvua, Color.Gray,Color.Gray,SacMau.dendam);


            }
            else
            {
                HamDoiMau(SacMau.dendam, SacMau.trangvua,Color.Gray,SacMau.trangvua);

            }
        }

        private void Signup_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
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
                        Owner.Show();
                        this.Close();
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            SignUpButton.Select();
            LoadMau();
        }
    }
}
