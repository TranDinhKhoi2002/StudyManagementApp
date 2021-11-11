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
              /*  try
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
                }*/
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
        }
    }
}
