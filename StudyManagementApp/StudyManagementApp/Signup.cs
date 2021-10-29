using StudyManagementApp.DAO;
using System;
using System.Windows.Forms;

namespace StudyManagementApp
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
                MessageBox.Show("Username can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtPassword.Text == "")
                MessageBox.Show("Password can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtRepassword.Text == "")
                MessageBox.Show("RePassword can't be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtPassword.Text != txtRepassword.Text)
                MessageBox.Show("Re-Password don't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    string username = txtUsername.Text;
                    string password = txtPassword.Text;

                    if (AccountDAO.Instance.Signup(username, password) == true)
                    {
                        MessageBox.Show("Sign-up successfully!");
                        this.Close();
                        this.Owner.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sign-up fail!");
                    }
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Sign-up fail");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Exception: " + exception.ToString());
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }
     
        private void Signup_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text== "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = System.Drawing.Color.FromArgb(217, 217, 217);
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";

                txtUsername.ForeColor = System.Drawing.Color.FromArgb(107, 111, 114);
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = System.Drawing.Color.FromArgb(217, 217, 217);
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = System.Drawing.Color.FromArgb(107, 111, 114);
            }
        }
        private void txtRepassword_Enter(object sender, EventArgs e)
        {
            if (txtRepassword.Text == "Password")
            {
                txtRepassword.Text = "";
                txtRepassword.ForeColor = System.Drawing.Color.FromArgb(217, 217, 217);
            }
        }

        private void txtRepassword_Leave(object sender, EventArgs e)
        {
            if (txtRepassword.Text == "")
            {
                txtRepassword.Text = "Password";
                txtRepassword.ForeColor = System.Drawing.Color.FromArgb(107, 111, 114);
            }
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            pnlButton.Select();
        }
    }
}
