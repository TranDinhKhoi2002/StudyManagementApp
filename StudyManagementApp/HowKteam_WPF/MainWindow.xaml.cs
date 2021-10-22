using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using HowKteam_WPF.DAO;

namespace HowKteam_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            txbUserName.Text = "";
        }

        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txbUserName.Text == "User Name" || txbUserName.Text == "" || passWordBox.Password == "")
                {
                    MessageBox.Show("You have not entered user name or password", "Error login");
                    return;
                }

                string userName = txbUserName.Text;
                string passWord = passWordBox.Password;

                if (Login(userName, passWord))
                {
                    MessageBox.Show("Login successfully");
                }
                else
                {
                    lbNotify.Content = "User name or password is not correct";
                }
            }
            catch (Exception excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }
    }
}
