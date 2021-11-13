namespace StudyManagementApp
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.Help = new System.Windows.Forms.PictureBox();
            this.About = new System.Windows.Forms.PictureBox();
            this.Home = new System.Windows.Forms.PictureBox();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.TruyencamhungLabel = new System.Windows.Forms.Label();
            this.NotificationLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.UsernameTextBox = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.SignUpButton = new StudyManagementApp.UserControls.RoundedCornerButton();
            this.SignInButton = new StudyManagementApp.UserControls.RoundedCornerButton();
            this.SignInLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.aboutUC1 = new StudyManagementApp.UserControls.AboutUC();
            this.BackGroundSignIn_Panel = new System.Windows.Forms.Panel();
            this.helpUC1 = new StudyManagementApp.UserControls.HelpUC();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Help)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.About)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            this.HomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignInLogoPictureBox)).BeginInit();
            this.BackGroundSignIn_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(63)))));
            this.BottomPanel.Controls.Add(this.Help);
            this.BottomPanel.Controls.Add(this.About);
            this.BottomPanel.Controls.Add(this.Home);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 405);
            this.BottomPanel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(800, 45);
            this.BottomPanel.TabIndex = 1;
            this.BottomPanel.SizeChanged += new System.EventHandler(this.BottomPanel_SizeChanged);
            // 
            // Help
            // 
            this.Help.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Help.ErrorImage")));
            this.Help.Image = global::StudyManagementApp.Properties.Resources.help;
            this.Help.ImageLocation = "";
            this.Help.Location = new System.Drawing.Point(447, 3);
            this.Help.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(40, 39);
            this.Help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Help.TabIndex = 4;
            this.Help.TabStop = false;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            this.Help.MouseLeave += new System.EventHandler(this.Help_MouseLeave);
            this.Help.MouseHover += new System.EventHandler(this.Help_MouseHover);
            // 
            // About
            // 
            this.About.ErrorImage = ((System.Drawing.Image)(resources.GetObject("About.ErrorImage")));
            this.About.Image = global::StudyManagementApp.Properties.Resources.about;
            this.About.ImageLocation = "";
            this.About.Location = new System.Drawing.Point(380, 3);
            this.About.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(40, 39);
            this.About.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.About.TabIndex = 4;
            this.About.TabStop = false;
            this.About.Click += new System.EventHandler(this.About_Click);
            this.About.MouseLeave += new System.EventHandler(this.About_MouseLeave);
            this.About.MouseHover += new System.EventHandler(this.About_MouseHover);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.Cursor = System.Windows.Forms.Cursors.Default;
            this.Home.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Home.ErrorImage")));
            this.Home.Image = global::StudyManagementApp.Properties.Resources.clicked_home;
            this.Home.ImageLocation = "";
            this.Home.Location = new System.Drawing.Point(313, 3);
            this.Home.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(41, 39);
            this.Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Home.TabIndex = 4;
            this.Home.TabStop = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            this.Home.MouseLeave += new System.EventHandler(this.Home_MouseLeave);
            this.Home.MouseHover += new System.EventHandler(this.Home_MouseHover);
            // 
            // HomePanel
            // 
            this.HomePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HomePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.HomePanel.Controls.Add(this.TruyencamhungLabel);
            this.HomePanel.Controls.Add(this.NotificationLabel);
            this.HomePanel.Controls.Add(this.PasswordTextBox);
            this.HomePanel.Controls.Add(this.UsernameTextBox);
            this.HomePanel.Controls.Add(this.SignUpButton);
            this.HomePanel.Controls.Add(this.SignInButton);
            this.HomePanel.Controls.Add(this.SignInLogoPictureBox);
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePanel.Location = new System.Drawing.Point(0, 0);
            this.HomePanel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(800, 405);
            this.HomePanel.TabIndex = 3;
            this.HomePanel.SizeChanged += new System.EventHandler(this.MiddlePanel_SizeChanged);
            // 
            // TruyencamhungLabel
            // 
            this.TruyencamhungLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TruyencamhungLabel.Font = new System.Drawing.Font("Agency FB", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TruyencamhungLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.TruyencamhungLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TruyencamhungLabel.Location = new System.Drawing.Point(0, 0);
            this.TruyencamhungLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TruyencamhungLabel.Name = "TruyencamhungLabel";
            this.TruyencamhungLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.TruyencamhungLabel.Size = new System.Drawing.Size(800, 59);
            this.TruyencamhungLabel.TabIndex = 5;
            this.TruyencamhungLabel.Text = "Learning is the eye of the mind";
            this.TruyencamhungLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NotificationLabel
            // 
            this.NotificationLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.NotificationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NotificationLabel.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotificationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.NotificationLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NotificationLabel.Location = new System.Drawing.Point(276, 220);
            this.NotificationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NotificationLabel.Name = "NotificationLabel";
            this.NotificationLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.NotificationLabel.Size = new System.Drawing.Size(249, 32);
            this.NotificationLabel.TabIndex = 5;
            this.NotificationLabel.Text = "Sign-in for future";
            this.NotificationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.PasswordTextBox.BorderColor = System.Drawing.Color.DimGray;
            this.PasswordTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.PasswordTextBox.BorderRadius = 10;
            this.PasswordTextBox.BorderSize = 2;
            this.PasswordTextBox.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.PasswordTextBox.Location = new System.Drawing.Point(447, 274);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordTextBox.Multiline = false;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.PasswordTextBox.PasswordChar = true;
            this.PasswordTextBox.PlaceholderColor = System.Drawing.Color.Gray;
            this.PasswordTextBox.PlaceholderText = "Password";
            this.PasswordTextBox.Size = new System.Drawing.Size(233, 35);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.Texts = "";
            this.PasswordTextBox.UnderlinedStyle = false;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.UsernameTextBox.BorderColor = System.Drawing.Color.DimGray;
            this.UsernameTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.UsernameTextBox.BorderRadius = 10;
            this.UsernameTextBox.BorderSize = 2;
            this.UsernameTextBox.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.UsernameTextBox.Location = new System.Drawing.Point(120, 274);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UsernameTextBox.Multiline = false;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.UsernameTextBox.PasswordChar = false;
            this.UsernameTextBox.PlaceholderColor = System.Drawing.Color.Gray;
            this.UsernameTextBox.PlaceholderText = "Username";
            this.UsernameTextBox.Size = new System.Drawing.Size(233, 35);
            this.UsernameTextBox.TabIndex = 0;
            this.UsernameTextBox.Texts = "";
            this.UsernameTextBox.UnderlinedStyle = false;
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(73)))), ((int)(((byte)(18)))));
            this.SignUpButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(73)))), ((int)(((byte)(18)))));
            this.SignUpButton.BorderRadius = 18;
            this.SignUpButton.BorderSize = 0;
            this.SignUpButton.FlatAppearance.BorderSize = 0;
            this.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpButton.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.SignUpButton.Location = new System.Drawing.Point(427, 333);
            this.SignUpButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(113, 38);
            this.SignUpButton.TabIndex = 3;
            this.SignUpButton.Text = "Sign-up";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // SignInButton
            // 
            this.SignInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(105)))));
            this.SignInButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(105)))));
            this.SignInButton.BorderRadius = 18;
            this.SignInButton.BorderSize = 0;
            this.SignInButton.FlatAppearance.BorderSize = 0;
            this.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInButton.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.SignInButton.Location = new System.Drawing.Point(261, 333);
            this.SignInButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(113, 38);
            this.SignInButton.TabIndex = 2;
            this.SignInButton.Text = "Sign-in";
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // SignInLogoPictureBox
            // 
            this.SignInLogoPictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("SignInLogoPictureBox.ErrorImage")));
            this.SignInLogoPictureBox.Image = global::StudyManagementApp.Properties.Resources.Logo;
            this.SignInLogoPictureBox.ImageLocation = "";
            this.SignInLogoPictureBox.Location = new System.Drawing.Point(335, 82);
            this.SignInLogoPictureBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.SignInLogoPictureBox.Name = "SignInLogoPictureBox";
            this.SignInLogoPictureBox.Size = new System.Drawing.Size(131, 117);
            this.SignInLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SignInLogoPictureBox.TabIndex = 0;
            this.SignInLogoPictureBox.TabStop = false;
            this.SignInLogoPictureBox.Click += new System.EventHandler(this.SignInLogoPictureBox_Click);
            // 
            // aboutUC1
            // 
            this.aboutUC1.AutoScroll = true;
            this.aboutUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.aboutUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutUC1.Location = new System.Drawing.Point(0, 0);
            this.aboutUC1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.aboutUC1.Name = "aboutUC1";
            this.aboutUC1.Size = new System.Drawing.Size(800, 405);
            this.aboutUC1.TabIndex = 6;
            // 
            // BackGroundSignIn_Panel
            // 
            this.BackGroundSignIn_Panel.Controls.Add(this.HomePanel);
            this.BackGroundSignIn_Panel.Controls.Add(this.helpUC1);
            this.BackGroundSignIn_Panel.Controls.Add(this.aboutUC1);
            this.BackGroundSignIn_Panel.Controls.Add(this.BottomPanel);
            this.BackGroundSignIn_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackGroundSignIn_Panel.Location = new System.Drawing.Point(0, 0);
            this.BackGroundSignIn_Panel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BackGroundSignIn_Panel.Name = "BackGroundSignIn_Panel";
            this.BackGroundSignIn_Panel.Size = new System.Drawing.Size(800, 450);
            this.BackGroundSignIn_Panel.TabIndex = 4;
            // 
            // helpUC1
            // 
            this.helpUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.helpUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpUC1.Location = new System.Drawing.Point(0, 0);
            this.helpUC1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.helpUC1.Name = "helpUC1";
            this.helpUC1.Size = new System.Drawing.Size(800, 405);
            this.helpUC1.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login
            // 
            this.AcceptButton = this.SignInButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackGroundSignIn_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Z-st: Ứng dụng hỗ trợ học tập";
            this.Load += new System.EventHandler(this.Login_Load);
            this.BottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Help)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.About)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).EndInit();
            this.HomePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SignInLogoPictureBox)).EndInit();
            this.BackGroundSignIn_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.PictureBox Home;
        private System.Windows.Forms.PictureBox Help;
        private System.Windows.Forms.PictureBox About;
        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.PictureBox SignInLogoPictureBox;
        private UserControls.RoundedCornerButton SignUpButton;
        private UserControls.RoundedCornerButton SignInButton;
        private UserControls.RoundedCornerTextBox PasswordTextBox;
        private UserControls.RoundedCornerTextBox UsernameTextBox;
        private System.Windows.Forms.Label NotificationLabel;
        private System.Windows.Forms.Label TruyencamhungLabel;
        private UserControls.AboutUC aboutUC1;
        private System.Windows.Forms.Panel BackGroundSignIn_Panel;
        private UserControls.HelpUC helpUC1;
        private System.Windows.Forms.Timer timer1;
    }
}

