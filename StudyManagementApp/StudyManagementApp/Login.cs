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

            HomePanel.Visible = true;
            aboutUC1.Visible = false;
            helpUC1.Visible = false;

            formbandau = new Size(this.Width, this.Height);

            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        //Sử lại hàm show của form
        public new void Show()
        {
            AlignControls_Non_Maximum();
            LoadMau();
            base.Show();
        }

        //khi Login được load sẽ làm gì?
        private void Login_Load(object sender, EventArgs e)
        {
            LoadMau();
            AlignHomeAboutHelp();
            AlignControls_Non_Maximum();
        }

        #region DoiTheme
        //Đổi theme nha
        void HamDoiMau(Color x, Color y, Color z, Color t,Color u,Color h)
        {
            HomePanel.BackColor = x;
            TruyencamhungLabel.ForeColor = h;

            NotificationLabel.ForeColor = u;
            NotificationLabel.BackColor = t;

            SignInButton.BorderColor = x;
            SignUpButton.BorderColor = x;

            BottomPanel.BackColor = t;

            UsernameTextBox.ForeColor = y;
            UsernameTextBox.BorderFocusColor = y;
            UsernameTextBox.PlaceholderColor = z;
            UsernameTextBox.BorderColor = z;
            UsernameTextBox.BackColor = x;

            PasswordTextBox.ForeColor = y;
            PasswordTextBox.BorderFocusColor = y;
            PasswordTextBox.PlaceholderColor = z;
            PasswordTextBox.BorderColor = z;
            PasswordTextBox.BackColor = x;
        }
        void LoadMau()
        {
            if (Program.Theme == true)
            {
                HamDoiMau(SacMau.trangvua, SacMau.dendam, Color.Gray, Color.Gray,Color.White,Color.Gray);
                SignInLogoPictureBox.Image=new Bitmap(Application.StartupPath +"\\Resources\\Images\\logoTrang.png");
            }
            else
            {
                HamDoiMau(SacMau.dendam, SacMau.trangvua, Color.Gray, SacMau.dennhat,SacMau.trangvua,SacMau.trangvua);
                SignInLogoPictureBox.Image = new Bitmap(Application.StartupPath + "\\Resources\\Images\\logo.png");
            }
        }
        #endregion

        #region NutDangKy_DangNhap
        //Nhấn nút đăng ký thì làm gì?
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            Signup frmSignup = new Signup();
            frmSignup.ShowDialog(this);
        }
        //Nhấn nút đăng nhập thì làm gì?
        private void SignInButton_Click(object sender, EventArgs e)
        {
            WorkPlace workPlace = new WorkPlace();
            workPlace.Show();
            this.Hide();
            /*try
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
                    //Cập nhật thông tin vào UserInfo để sử dụng trong chương trình
                    UserInfo.getInstance().Username = userName;
                    UserInfo.getInstance().Password = passWord;

                    //Vào chương trình
                    WorkPlace workPlace = new WorkPlace();
                    workPlace.Show();
                    this.Hide();
                }
                else
                {
                    NotificationLabel.Text = "User name or password is not correct";
                }
            }
            catch (Exception excpt)
            {
                MessageBox.Show(excpt.Message);
            }*/
        }
        #endregion

        #region CanChinhCacControl
        /*---------------------------------Căn chỉnh các control---------------------------------*/
        //Hàm chỉnh control lúc không maximum
        Size formbandau;
        void AlignControls_Non_Maximum()
        {
            this.MinimumSize = formbandau;
           
            this.StartPosition = FormStartPosition.CenterScreen;
            SignInLogoPictureBox.Size = new Size(131, 117);
            NotificationLabel.Size = new Size(350, 40);
            NotificationLabel.Font = new Font("Agency FB", 11);
            UsernameTextBox.Size = new Size(233, 35);
            UsernameTextBox.Font = new Font("Agency FB", 15);
            PasswordTextBox.Size = new Size(233, 35);
            PasswordTextBox.Font = new Font("Agency FB", 15);
            SignInButton.Size = new Size(113, 38);
            SignInButton.Font = new Font("Agency FB", 13);
            SignUpButton.Size = new Size(113, 38);
            SignUpButton.Font = new Font("Agency FB", 13);



            TruyencamhungLabel.Font = new Font("Agency FB", 23, FontStyle.Bold);
            TruyencamhungLabel.Height = 70;
            TruyencamhungLabel.TextAlign = ContentAlignment.MiddleCenter;

            SignInLogoPictureBox.Location = new Point(HomePanel.Width / 2 - SignInLogoPictureBox.Width / 2, TruyencamhungLabel.Height + 20);
            NotificationLabel.Location = new Point(HomePanel.Width / 2 - NotificationLabel.Width / 2, SignInLogoPictureBox.Location.Y + SignInLogoPictureBox.Height + 23);
            UsernameTextBox.Location = new Point(HomePanel.Width / 2 - 70 - UsernameTextBox.Width, NotificationLabel.Location.Y + NotificationLabel.Height + 21);
            PasswordTextBox.Location = new Point(HomePanel.Width / 2 + 70, NotificationLabel.Location.Y + NotificationLabel.Height + 21);
            SignInButton.Location = new Point(HomePanel.Width / 2 - SignInButton.Width - 40, UsernameTextBox.Location.Y + UsernameTextBox.Height + 26);
            SignUpButton.Location = new Point(HomePanel.Width / 2 + 40, UsernameTextBox.Location.Y + UsernameTextBox.Height + 26);
        }

        private void Login_SizeChanged(object sender, EventArgs e)
        {
            AlignControls_Non_Maximum();
        }
        /*---------------------------------Căn chỉnh các control---------------------------------*/
        #endregion

        #region CanChinh3NutDuoi
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
        #endregion

        #region ChucNang3NutDuoi
        /*---------------------------------Chức năng 3 nút dưới---------------------------------*/
        //Khai báo 3 biến đánh dấu các nút được click chưa hay chưa?
        bool isHomeClick = true;
        bool isAboutClick = false;
        bool isHelpClick = false;
        //Nhấn Home thì làm gì?
        private void Home_Click(object sender, EventArgs e)
        {
            if (isHomeClick)
            {
                return;
            }     
            else
            {
                isHomeClick = true;
                Home.Image = new Bitmap(Application.StartupPath + "\\Resources\\Images\\clicked home.png");
                if (isAboutClick)
                {
                    aboutUC1.Hide();
                    isAboutClick = false;
                    About.Image = new Bitmap(Application.StartupPath + "\\Resources\\Images\\about.png");
                }
                if (isHelpClick)
                {
                    helpUC1.Hide();
                    isHelpClick = false;
                    Help.Image = new Bitmap(Application.StartupPath + "\\Resources\\Images\\help.png");
                }
                HomePanel.Show();
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
                    HomePanel.Hide();
                    isHomeClick = false;
                    Home.Image = new Bitmap(Application.StartupPath + "\\Resources\\Images\\home.png");
                }
                if (isHelpClick)
                {
                    helpUC1.Hide();
                    isHelpClick = false;
                    Help.Image = new Bitmap(Application.StartupPath + "\\Resources\\Images\\help.png");
                }
                aboutUC1.Show();
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
                    HomePanel.Hide();
                    isHomeClick = false;
                    Home.Image = new Bitmap(Application.StartupPath + "\\Resources\\Images\\home.png");
                }
                if (isAboutClick)
                {
                    aboutUC1.Hide();
                    isAboutClick = false;
                    About.Image = new Bitmap(Application.StartupPath + "\\Resources\\Images\\about.png");
                }
                helpUC1.Show();
            }
        }

        private void Home_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void Home_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void About_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void About_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void Help_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void Help_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        /*---------------------------------Chức năng 3 nút dưới---------------------------------*/
        #endregion

        #region CauTruyenCamHung
        /*---------------------------------Câu truyền cảm hứng---------------------------------*/
        string GetTruyenCamHung()
        {
            List<string> text = new List<string>();
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(Application.StartupPath + "\\Resources\\Text\\truyencamhung.txt");
            while((line=file.ReadLine()) != null)
            {
                text.Add(line);
            }

            Random r = new Random();
            int t = r.Next(0, text.Count);
            return text[t];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TruyencamhungLabel.Text = GetTruyenCamHung();
        }

        /*---------------------------------Câu truyền cảm hứng---------------------------------*/
        #endregion
        
        //forget pass
        private void label1_Click(object sender, EventArgs e)
        {
            ForgetPasswordForm fgpForm = new ForgetPasswordForm();
            fgpForm.Show();
        }
    }
}
