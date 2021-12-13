using System;
using System.Drawing;
using System.Windows.Forms;
using StudyManagementApp.DAO;

namespace StudyManagementApp
{
    public partial class Edit : Form
    {
        bool lasttheme;
        bool isLogingOut = false;

        public Edit()
        {
            InitializeComponent();
            lasttheme = Program.Theme;
            if (Program.Theme == true)
            {
                toggleButton1.CheckState = CheckState.Checked;
                HamDoiMau(SacMau.trangvua, SacMau.dendam, Color.Gray, Color.White);
            }
            else
            {
                toggleButton1.CheckState = CheckState.Unchecked;
                HamDoiMau(SacMau.dendam, SacMau.trangvua, Color.Gray, Color.White);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            //Báo lỗi khi textbox trống
            if (
                CurrentPassword_textbox.Texts.Equals("") ||
                NewPassword_textbox.Texts.Equals("") ||
                ReNewPassword_textbox.Texts.Equals("")
                )
            {
                MessageBox.Show("Please fill in old password and new password.", "Fill in textbox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Kiểm tra thông tin nhập
            if (!CurrentPassword_textbox.Texts.Equals(UserInfo.Instance.Password))
            {
                MessageBox.Show("Current password wrong, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CurrentPassword_textbox.Texts = "";
                CurrentPassword_textbox.Focus();
                return;
            }
            else if (!NewPassword_textbox.Texts.Equals(ReNewPassword_textbox.Texts))
            {
                MessageBox.Show("New password don't matched, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReNewPassword_textbox.Texts = "";
                ReNewPassword_textbox.Focus();
                return;
            }
            //Đổi mật khẩu
            AccountDAO.Instance.ChangePassword(
                UserInfo.Instance.Username,
                ReNewPassword_textbox.Texts
                );

            MessageBox.Show("Your password has been changed successfully.", "Password changed successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        //Log-out nha
        private void Logout_button_Click(object sender, EventArgs e)
        {
            isLogingOut = true;
            Owner.Close();
            Program.globalLogin.Show();
        }

        //Đổi theme nha
        void HamDoiMau(Color x , Color y, Color z, Color t)
        {
            this.BackColor =x;
            Apply_Button.BorderColor = x;
            Logout_button.BorderColor = x;
            CancelButton.BorderColor = x;
            label1.ForeColor = label2.ForeColor = label3.ForeColor = label4.ForeColor = label5.ForeColor = y;

            Nickname_textbox.ForeColor = y;
            Nickname_textbox.PlaceholderColor = z;
            Nickname_textbox.BackColor = x;

            NewPassword_textbox.ForeColor = y;
            NewPassword_textbox.PlaceholderColor = z;
            NewPassword_textbox.BackColor = x;

            CurrentPassword_textbox.ForeColor = y;
            CurrentPassword_textbox.PlaceholderColor = z;
            CurrentPassword_textbox.BackColor = x;

            ReNewPassword_textbox.ForeColor = y;
            ReNewPassword_textbox.PlaceholderColor = z;
            ReNewPassword_textbox.BackColor = x;           
        }
        private void ToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            Program.Theme = toggleButton1.Checked;
            if(Program.Theme==true)
            {
                HamDoiMau(SacMau.trangvua, SacMau.dendam, Color.Gray, Color.White);
            }    
            else
            {
                HamDoiMau(SacMau.dendam, SacMau.trangvua, Color.Gray, Color.White);
            }    
        }

        private void Edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (lasttheme != Program.Theme && isLogingOut == false)
            {
                Owner.Close();
                Program.globalLogin.Show();
            }
            isLogingOut = false;
        }
    }
}
