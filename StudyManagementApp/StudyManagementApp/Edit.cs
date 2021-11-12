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
                roundedCornerTextBox1.Texts.Equals("") ||
                roundedCornerTextBox2.Texts.Equals("") ||
                roundedCornerTextBox3.Texts.Equals("")
                )
            {
                MessageBox.Show("Please fill in old password and new password.", "Fill in textbox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Kiểm tra thông tin nhập
            if (!roundedCornerTextBox1.Texts.Equals(UserInfo.getInstance().Password))
                MessageBox.Show("Current password wrong, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (!roundedCornerTextBox2.Texts.Equals(roundedCornerTextBox3.Texts))
                MessageBox.Show("New password don't matched, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Đổi mật khẩu
            AccountDAO.Instance.ChangePassword(
                UserInfo.getInstance().Username,
                roundedCornerTextBox3.Texts
                );

            MessageBox.Show("Your password has been changed successfully.", "Password changed successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
