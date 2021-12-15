using System;
using System.Drawing;
using System.Windows.Forms;
using StudyManagementApp.DAO;

namespace StudyManagementApp
{
    public partial class Edit : Form
    {
        bool lasttheme;
      
        public Edit()
        {
            InitializeComponent();
            lasttheme = Program.Theme;
            passwork_panel.Hide();
            mode_panel.Dock = DockStyle.Fill;

            if (Program.Theme == true)
            {
                theme_toggleButton.CheckState = CheckState.Checked;
            }
            else
            {
                theme_toggleButton.CheckState = CheckState.Unchecked;
            }

            background_toggleButton.CheckState = Program.IsBackgroundRunningEnable ? CheckState.Checked : CheckState.Unchecked;
            startup_toggleButton.CheckState = Program.IsStartupEnable ? CheckState.Checked : CheckState.Unchecked;
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
            Owner.Dispose();
            Program.globalLogin.Show();
        }
        
        //nút mode menu trái
        private void Mode_iconButton_Click(object sender, EventArgs e)
        {
            if (mode_panel.Visible==false)
            {
                passwork_panel.Hide();
                pass_iconButton.BackColor = Color.DimGray;
                mode_panel.Show();
                mode_panel.Dock = DockStyle.Fill;
                Mode_iconButton.BackColor = Color.Gray;
                Title_Label.Text = "Mode";
            }
           
        }
        //nút pass menu trái
        private void pass_iconButton_Click(object sender, EventArgs e)
        {
            if (passwork_panel.Visible == false)
            {
                mode_panel.Hide();
                Mode_iconButton.BackColor = Color.DimGray;
                passwork_panel.Show();
                passwork_panel.Dock = DockStyle.Fill;
                pass_iconButton.BackColor = Color.Gray;
                Title_Label.Text = "Change Password";
            }
        }
        
        //btn đóng form
        private void close_iconButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //btn Apply các thể loại mode
        private void mode_apply_btn_Click(object sender, EventArgs e)
        {
            Program.Theme = theme_toggleButton.Checked;
            Program.IsBackgroundRunningEnable = background_toggleButton.Checked;
            Program.IsStartupEnable = startup_toggleButton.Checked;

            AccountDAO.Instance.UpdateUserConfig(
                UserInfo.Instance.Username,
                Program.Theme,
                Program.IsBackgroundRunningEnable,
                Program.IsStartupEnable
                );

            if (lasttheme != Program.Theme )
            {
                Owner.Dispose();
                this.Close();
                Program.globalLogin.Show();
            }

            using (Microsoft.Win32.RegistryKey reg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                string name = "StudyManagementApp";

                try
                {
                    if (Program.IsStartupEnable)
                    {
                        reg.SetValue(name, Application.ExecutablePath.ToString());
                    }
                    else
                    {
                        reg.DeleteValue(name);
                    }
                }
                catch (System.Exception ex) { }
            }
                
        }

        private void theme_toggleButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!theme_toggleButton.Checked)
            {
                darktheme_iconButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
                lighttheme_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            }
            else
            {
                darktheme_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
                lighttheme_iconButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            }
        }

        private void background_toggleButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!background_toggleButton.Checked)
            {
                no_background_running_iconButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
                no_background_running_iconButton.IconColor = Color.IndianRed;
                yes_background_running_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
                yes_background_running_iconButton.IconColor = Color.Black;
            }
            else
            {
                no_background_running_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
                no_background_running_iconButton.IconColor = Color.Black;
                yes_background_running_iconButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
                yes_background_running_iconButton.IconColor = Color.LightGreen;
            }
        }

        private void startup_toggleButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!startup_toggleButton.Checked)
            {
                no_startup_iconButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
                no_startup_iconButton.IconColor = Color.IndianRed;
                yes_startup_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
                yes_startup_iconButton.IconColor = Color.Black;
            }
            else
            {
                no_startup_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
                no_startup_iconButton.IconColor = Color.Black;
                yes_startup_iconButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
                yes_startup_iconButton.IconColor = Color.LightGreen;
            }
        }
    }
}
