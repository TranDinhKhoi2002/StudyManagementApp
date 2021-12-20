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
using System.Net.Mail;
using System.Net;

namespace StudyManagementApp
{
    public partial class ForgetPasswordForm : Form
    {
        public ForgetPasswordForm()
        {
            InitializeComponent();
        }

        public new void Show()
        {
            LoadMau();
            base.Show();
        }

        void HamDoiMau(Color x,Color y, Color z,Color t,Color u)
        {
            this.BackColor = x;
            lbInstruction.ForeColor = y;
            lbInstruction.BackColor = z;

            txbUserName.BackColor = x;
            txbUserName.ForeColor = t;
            txbUserName.BorderFocusColor = t;
            txbUserName.BorderColor = u;
            txbUserName.PlaceholderColor = u;

            txbEmail.BackColor = x;
            txbEmail.ForeColor = t;
            txbEmail.BorderFocusColor = t;
            txbEmail.BorderColor = u;
            txbEmail.PlaceholderColor = u;
        }

        void LoadMau()
        {
            if (Program.Theme == true)
            {
                HamDoiMau(SacMau.trangvua,Color.White,Color.Gray,SacMau.dendam,Color.Gray);


            }
            else
            {
                HamDoiMau(SacMau.dendam,SacMau.trangvua,SacMau.dennhat,SacMau.trangvua,Color.Gray);

            }
        }


        public static string DomainMapper { get; private set; }

        public static string code;
        public static string username;

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txbEmail.Texts == "" || txbUserName.Texts == "")
            {
                lbInstruction.Text = "User name or email can't be blank";
            }
            else if (!AccountDAO.Instance.UserExist(txbUserName.Texts))
            {
                lbInstruction.Text = "User can't be found";
            }
            else if (!Email.IsValidEmail(txbEmail.Texts))
            {
                lbInstruction.Text = "Your email is invalid";
            }
            else if (!AccountDAO.Instance.EmailOfEachUser(txbUserName.Texts, txbEmail.Texts))
            {
                lbInstruction.Text = "Your email is incorrect";
            }
            else
            {
                Email.SendEmail(txbEmail.Texts, out code, Application.StartupPath + "\\Resources\\Image-email\\Verification.png");
                lbInstruction.Text = "We just sent you an email. Verify now!";
                username = txbUserName.Texts;
                txbUserName.Texts = txbEmail.Texts = "";
            }
        }

        private void ForgetPasswordForm_Load(object sender, EventArgs e)
        {
            LoadMau();
        }
    }
}
