
using System.Windows;
using System.Windows.Input;
using System.Data.SqlClient;
using HowKteam_WPF.DAO;
using System;

namespace HowKteam_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Signup : Window
    {
        public Signup()
        {
            InitializeComponent();
        }
        private void btnSignup_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text == "")
                MessageBox.Show("Username can't be blank!", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            else if (txtPassword.Password == "")
                MessageBox.Show("Password can't be blank!", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            else if (txtRePassword.Password == "")
                MessageBox.Show("RePassword can't be blank!", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            else if (txtPassword.Password != txtRePassword.Password)
                MessageBox.Show("Re-Password don't match", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                try
                {
                    string username = txtUsername.Text;
                    string password = txtPassword.Password;

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
                    MessageBox.Show("Username existed, please try another one.");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Exception: " + exception.ToString());
                }

            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Window_Closed(object sender, System.EventArgs e)
        {
            Owner.Show();
        }
    }
}
