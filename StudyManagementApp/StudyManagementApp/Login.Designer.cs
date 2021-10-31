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
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.Help = new System.Windows.Forms.PictureBox();
            this.About = new System.Windows.Forms.PictureBox();
            this.Home = new System.Windows.Forms.PictureBox();
            this.MiddlePanel = new System.Windows.Forms.Panel();
            this.TruyencamhungLabel = new System.Windows.Forms.Label();
            this.NotificationLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.UsernameTextBox = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.SignUpButton = new StudyManagementApp.UserControls.RoundedCornerButton();
            this.SignInButton = new StudyManagementApp.UserControls.RoundedCornerButton();
            this.SignInLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Help)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.About)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            this.MiddlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignInLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BottomPanel.Controls.Add(this.Help);
            this.BottomPanel.Controls.Add(this.About);
            this.BottomPanel.Controls.Add(this.Home);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 405);
            this.BottomPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(800, 45);
            this.BottomPanel.TabIndex = 1;
            this.BottomPanel.SizeChanged += new System.EventHandler(this.BottomPanel_SizeChanged);
            // 
            // Help
            // 
            this.Help.Image = global::StudyManagementApp.Properties.Resources.help;
            this.Help.InitialImage = global::StudyManagementApp.Properties.Resources.help;
            this.Help.Location = new System.Drawing.Point(447, 3);
            this.Help.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(40, 39);
            this.Help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Help.TabIndex = 4;
            this.Help.TabStop = false;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // About
            // 
            this.About.Image = global::StudyManagementApp.Properties.Resources.about;
            this.About.InitialImage = global::StudyManagementApp.Properties.Resources.about;
            this.About.Location = new System.Drawing.Point(380, 3);
            this.About.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(40, 39);
            this.About.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.About.TabIndex = 4;
            this.About.TabStop = false;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Home
            // 
            this.Home.Image = global::StudyManagementApp.Properties.Resources.clicked_home;
            this.Home.InitialImage = global::StudyManagementApp.Properties.Resources.clicked_home;
            this.Home.Location = new System.Drawing.Point(313, 3);
            this.Home.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(40, 39);
            this.Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Home.TabIndex = 4;
            this.Home.TabStop = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // MiddlePanel
            // 
            this.MiddlePanel.Controls.Add(this.TruyencamhungLabel);
            this.MiddlePanel.Controls.Add(this.NotificationLabel);
            this.MiddlePanel.Controls.Add(this.PasswordTextBox);
            this.MiddlePanel.Controls.Add(this.UsernameTextBox);
            this.MiddlePanel.Controls.Add(this.SignUpButton);
            this.MiddlePanel.Controls.Add(this.SignInButton);
            this.MiddlePanel.Controls.Add(this.SignInLogoPictureBox);
            this.MiddlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiddlePanel.Location = new System.Drawing.Point(0, 0);
            this.MiddlePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MiddlePanel.Name = "MiddlePanel";
            this.MiddlePanel.Size = new System.Drawing.Size(800, 405);
            this.MiddlePanel.TabIndex = 3;
            this.MiddlePanel.SizeChanged += new System.EventHandler(this.MiddlePanel_SizeChanged);
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
            this.TruyencamhungLabel.Size = new System.Drawing.Size(800, 70);
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
            this.NotificationLabel.Image = global::StudyManagementApp.Properties.Resources.Message_small;
            this.NotificationLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NotificationLabel.Location = new System.Drawing.Point(276, 219);
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
            this.PasswordTextBox.Multiline = false;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.PasswordTextBox.PasswordChar = true;
            this.PasswordTextBox.PlaceholderColor = System.Drawing.Color.Gray;
            this.PasswordTextBox.PlaceholderText = "Password";
            this.PasswordTextBox.Size = new System.Drawing.Size(233, 35);
            this.PasswordTextBox.TabIndex = 3;
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
            this.UsernameTextBox.Multiline = false;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.UsernameTextBox.PasswordChar = false;
            this.UsernameTextBox.PlaceholderColor = System.Drawing.Color.Gray;
            this.UsernameTextBox.PlaceholderText = "Username";
            this.UsernameTextBox.Size = new System.Drawing.Size(233, 35);
            this.UsernameTextBox.TabIndex = 3;
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
            this.SignUpButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(113, 38);
            this.SignUpButton.TabIndex = 2;
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
            this.SignInButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(113, 38);
            this.SignInButton.TabIndex = 2;
            this.SignInButton.Text = "Sign-in";
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // SignInLogoPictureBox
            // 
            this.SignInLogoPictureBox.Image = global::StudyManagementApp.Properties.Resources.Logo;
            this.SignInLogoPictureBox.Location = new System.Drawing.Point(335, 82);
            this.SignInLogoPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SignInLogoPictureBox.Name = "SignInLogoPictureBox";
            this.SignInLogoPictureBox.Size = new System.Drawing.Size(131, 117);
            this.SignInLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SignInLogoPictureBox.TabIndex = 0;
            this.SignInLogoPictureBox.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MiddlePanel);
            this.Controls.Add(this.BottomPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.BottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Help)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.About)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).EndInit();
            this.MiddlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SignInLogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.PictureBox Home;
        private System.Windows.Forms.PictureBox Help;
        private System.Windows.Forms.PictureBox About;
        private System.Windows.Forms.Panel MiddlePanel;
        private System.Windows.Forms.PictureBox SignInLogoPictureBox;
        private UserControls.RoundedCornerButton SignUpButton;
        private UserControls.RoundedCornerButton SignInButton;
        private UserControls.RoundedCornerTextBox PasswordTextBox;
        private UserControls.RoundedCornerTextBox UsernameTextBox;
        private System.Windows.Forms.Label NotificationLabel;
        private System.Windows.Forms.Label TruyencamhungLabel;
    }
}

