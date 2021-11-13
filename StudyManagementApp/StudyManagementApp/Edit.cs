using System;
using System.Windows.Forms;
using StudyManagementApp.DAO;

namespace StudyManagementApp
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
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
            if (!CurrentPassword_textbox.Texts.Equals(UserInfo.getInstance().Password))
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
                UserInfo.getInstance().Username,
                ReNewPassword_textbox.Texts
                );

            MessageBox.Show("Your password has been changed successfully.", "Password changed successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            Owner.Dispose();
            Program.globalLogin.Show();
        }
    }
}
