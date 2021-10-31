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
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();

            //Khởi tạo màu cho nền
            BottomPanel.BackColor = Color.FromArgb(55, 60, 63);
            MiddlePanel.BackColor = Color.FromArgb(47, 52, 55);
            
        }


        //khi Login được load sẽ làm gì?
        private void Login_Load(object sender, EventArgs e)
        {
            Home.Location = new Point(BottomPanel.Width / 2 - 130, 5);
            About.Location = new Point(BottomPanel.Width / 2 - 30, 5);
            Help.Location = new Point(BottomPanel.Width / 2 + 70, 5);

            SignInLogoPictureBox.Location = new Point(MiddlePanel.Width / 2 - SignInLogoPictureBox.Width / 2, TruyencamhungLabel.Height + 18);
            NotificationLabel.Size = new Size(350, 32);
            NotificationLabel.Location = new Point(MiddlePanel.Width / 2 - NotificationLabel.Width / 2, SignInLogoPictureBox.Location.Y + SignInLogoPictureBox.Height + 20);
            UsernameTextBox.Location = new Point(MiddlePanel.Width / 2 - 70 - UsernameTextBox.Width, NotificationLabel.Location.Y + NotificationLabel.Height + 18);
            PasswordTextBox.Location = new Point(MiddlePanel.Width / 2 + 70, NotificationLabel.Location.Y + NotificationLabel.Height + 18);
            SignInButton.Location = new Point(MiddlePanel.Width / 2 - SignInButton.Width - 40, UsernameTextBox.Location.Y + UsernameTextBox.Height + 24);
            SignUpButton.Location = new Point(MiddlePanel.Width / 2 + 40, UsernameTextBox.Location.Y + UsernameTextBox.Height + 24);

        }
        //Nhấn nút đăng ký thì làm gì?
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            Signup frmSignup = new Signup();
            frmSignup.ShowDialog(this);
        }
        //Nhấn nút đăng nhập thì làm gì?
        private void SignInButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsernameTextBox.Texts == "" || PasswordTextBox.Texts == "")
                {
                    NotificationLabel.Text = "Username and Password can't be blank";
                    return;
                }

                string userName = UsernameTextBox.Texts;
                string passWord = PasswordTextBox.Texts;

                if (AccountDAO.Instance.Login(userName, passWord))
                {
                    NotificationLabel.Text = "Login successfully!";

                }
                else
                {
                    NotificationLabel.Text = "User name or password is not correct";
                }
            }
            catch (Exception excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }


        /*---------------------------------Căn chỉnh các control---------------------------------*/
        //Hàm chỉnh control lúc maximum
        void AlignControls_Maximum()
        {
            SignInLogoPictureBox.Size = new Size(196, 180);
            NotificationLabel.Size = new Size(500, 48);
            NotificationLabel.Font = new Font("Agency FB", 23);
            UsernameTextBox.Size = new Size(350, 51);
            UsernameTextBox.Font = new Font("Agency FB", 25);
            PasswordTextBox.Size = new Size(350, 51);
            PasswordTextBox.Font = new Font("Agency FB", 25);
            SignInButton.Size = new Size(169, 59);
            SignInButton.Font = new Font("Agency FB", 27);
            SignUpButton.Size = new Size(169, 59);
            SignUpButton.Font = new Font("Agency FB", 27);

            TruyencamhungLabel.Font = new Font("Agency FB", 50, FontStyle.Bold);
            TruyencamhungLabel.Height = 130;

            SignInLogoPictureBox.Location = new Point(MiddlePanel.Width / 2 - SignInLogoPictureBox.Width / 2, TruyencamhungLabel.Height + 22);
            NotificationLabel.Location = new Point(MiddlePanel.Width / 2 - NotificationLabel.Width / 2, SignInLogoPictureBox.Location.Y + SignInLogoPictureBox.Height + 40);
            UsernameTextBox.Location = new Point(MiddlePanel.Width / 2 - 70 - UsernameTextBox.Width, NotificationLabel.Location.Y + NotificationLabel.Height + 40);
            PasswordTextBox.Location = new Point(MiddlePanel.Width / 2 + 70, NotificationLabel.Location.Y + NotificationLabel.Height + 40);
            SignInButton.Location = new Point(MiddlePanel.Width / 2 - SignInButton.Width - 40, UsernameTextBox.Location.Y + UsernameTextBox.Height + 40);
            SignUpButton.Location = new Point(MiddlePanel.Width / 2 + 40, UsernameTextBox.Location.Y + UsernameTextBox.Height + 40);
        }
        //Hàm chỉnh control lúc không maximum
        void AlignControls_Non_Maximum()
        {
            SignInLogoPictureBox.Size = new Size(131, 117);
            NotificationLabel.Size = new Size(350, 32);
            NotificationLabel.Font = new Font("Agency FB", 15);
            UsernameTextBox.Size = new Size(233, 35);
            UsernameTextBox.Font = new Font("Agency FB", 15);
            PasswordTextBox.Size = new Size(233, 35);
            PasswordTextBox.Font = new Font("Agency FB", 15);
            SignInButton.Size = new Size(113, 38);
            SignInButton.Font = new Font("Agency FB", 17);
            SignUpButton.Size = new Size(113, 38);
            SignUpButton.Font = new Font("Agency FB", 17);

            TruyencamhungLabel.Font = new Font("Agency FB", 30, FontStyle.Bold);
            TruyencamhungLabel.Height = 70;

            SignInLogoPictureBox.Location = new Point(MiddlePanel.Width / 2 - SignInLogoPictureBox.Width / 2, TruyencamhungLabel.Height + 18);
            NotificationLabel.Location = new Point(MiddlePanel.Width / 2 - NotificationLabel.Width / 2, SignInLogoPictureBox.Location.Y + SignInLogoPictureBox.Height + 20);
            UsernameTextBox.Location = new Point(MiddlePanel.Width / 2 - 70 - UsernameTextBox.Width, NotificationLabel.Location.Y + NotificationLabel.Height + 18);
            PasswordTextBox.Location = new Point(MiddlePanel.Width / 2 + 70, NotificationLabel.Location.Y + NotificationLabel.Height + 18);
            SignInButton.Location = new Point(MiddlePanel.Width / 2 - SignInButton.Width - 40, UsernameTextBox.Location.Y + UsernameTextBox.Height + 24);
            SignUpButton.Location = new Point(MiddlePanel.Width / 2 + 40, UsernameTextBox.Location.Y + UsernameTextBox.Height + 24);
        }
        //middle panel lúc app maximum size lên sẽ gọi hàm gì? 
        private void MiddlePanel_SizeChanged(object sender, EventArgs e)
        {
            if(WindowState==FormWindowState.Maximized)
            {
                AlignControls_Maximum();
            }
            else 
            {
                AlignControls_Non_Maximum();
            }
        }
        /*---------------------------------Căn chỉnh các control---------------------------------*/


        /*---------------------------------Căn chỉnh 3 nút dưới---------------------------------*/
        //Hàm chỉnh lại 3 nút ở bottom
        void AlignHomeAboutHelp()
        {
            Home.Location = new Point(BottomPanel.Width / 2 - 130, 5);
            About.Location = new Point(BottomPanel.Width / 2 - 30, 5);
            Help.Location = new Point(BottomPanel.Width / 2 + 70, 5);
        }
        //bottom panel lúc app maximum size lên sẽ gọi hàm gì? 
        private void BottomPanel_SizeChanged(object sender, EventArgs e)
        {
            AlignHomeAboutHelp();
        }
        /*---------------------------------Căn chỉnh 3 nút dưới---------------------------------*/


        /*---------------------------------Chức năng 3 nút dưới---------------------------------*/
        //Khai báo 3 biến đánh dấu các nút được click chưa hay chưa?
        bool isHomeClick = true;
        bool isAboutClick = false;
        bool isHelpClick = false;
        //Nhấn Home thì làm gì?
        private void Home_Click(object sender, EventArgs e)
        {
            if (isHomeClick)
                return;
            else
            {
                isHomeClick = true;
                Home.Image = new Bitmap(Application.StartupPath + "\\Resources\\Images\\clicked home.png");
                if (isAboutClick)
                {
                    isAboutClick = false;
                    About.Image = new Bitmap(Application.StartupPath + "\\Resources\\Images\\about.png");
                }
                if (isHelpClick)
                {
                    isHelpClick = false;
                    Help.Image = new Bitmap(Application.StartupPath + "\\Resources\\Images\\help.png");
                }
            }
        }
        //Nhấn About thì làm gì?
        private void About_Click(object sender, EventArgs e)
        {
            if (isAboutClick)
                return;
            else
            {
                isAboutClick = true;
                About.Image = new Bitmap(Application.StartupPath + "\\Resources\\Images\\clicked about.png");
                if (isHomeClick)
                {
                    isHomeClick = false;
                    Home.Image = new Bitmap(Application.StartupPath + "\\Resources\\Images\\home.png");
                }
                if (isHelpClick)
                {
                    isHelpClick = false;
                    Help.Image = new Bitmap(Application.StartupPath + "\\Resources\\Images\\help.png");
                }
            }
        }
        //Nhấn Help thì làm gì?
        private void Help_Click(object sender, EventArgs e)
        {
            if (isHelpClick)
                return;
            else
            {
                isHelpClick = true;
                Help.Image = new Bitmap(Application.StartupPath + "\\Resources\\Images\\clicked help.png");
                if (isHomeClick)
                {
                    isHomeClick = false;
                    Home.Image = new Bitmap(Application.StartupPath + "\\Resources\\Images\\home.png");
                }
                if (isAboutClick)
                {
                    isAboutClick = false;
                    About.Image = new Bitmap(Application.StartupPath + "\\Resources\\Images\\about.png");
                }
            }
        }

       
        /*---------------------------------Chức năng 3 nút dưới---------------------------------*/


    }
}
