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
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation11 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation12 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
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
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.bunifuTransition2 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.aboutUC1 = new StudyManagementApp.UserControls.AboutUC();
            this.helpUC1 = new StudyManagementApp.UserControls.HelpUC();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Help)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.About)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            this.HomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignInLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BottomPanel.Controls.Add(this.Help);
            this.BottomPanel.Controls.Add(this.About);
            this.BottomPanel.Controls.Add(this.Home);
            this.bunifuTransition2.SetDecoration(this.BottomPanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.BottomPanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 499);
            this.BottomPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1067, 55);
            this.BottomPanel.TabIndex = 1;
            this.BottomPanel.SizeChanged += new System.EventHandler(this.BottomPanel_SizeChanged);
            // 
            // Help
            // 
            this.bunifuTransition1.SetDecoration(this.Help, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.Help, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Help.Image = global::StudyManagementApp.Properties.Resources.help;
            this.Help.InitialImage = global::StudyManagementApp.Properties.Resources.help;
            this.Help.Location = new System.Drawing.Point(596, 4);
            this.Help.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(53, 48);
            this.Help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Help.TabIndex = 4;
            this.Help.TabStop = false;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            this.Help.MouseLeave += new System.EventHandler(this.Help_MouseLeave);
            this.Help.MouseHover += new System.EventHandler(this.Help_MouseHover);
            // 
            // About
            // 
            this.bunifuTransition1.SetDecoration(this.About, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.About, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.About.Image = global::StudyManagementApp.Properties.Resources.about;
            this.About.InitialImage = global::StudyManagementApp.Properties.Resources.about;
            this.About.Location = new System.Drawing.Point(507, 4);
            this.About.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(53, 48);
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
            this.bunifuTransition1.SetDecoration(this.Home, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.Home, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Home.Image = global::StudyManagementApp.Properties.Resources.clicked_home;
            this.Home.InitialImage = global::StudyManagementApp.Properties.Resources.clicked_home;
            this.Home.Location = new System.Drawing.Point(417, 4);
            this.Home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(54, 48);
            this.Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Home.TabIndex = 4;
            this.Home.TabStop = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            this.Home.MouseLeave += new System.EventHandler(this.Home_MouseLeave);
            this.Home.MouseHover += new System.EventHandler(this.Home_MouseHover);
            // 
            // HomePanel
            // 
            this.HomePanel.Controls.Add(this.TruyencamhungLabel);
            this.HomePanel.Controls.Add(this.NotificationLabel);
            this.HomePanel.Controls.Add(this.PasswordTextBox);
            this.HomePanel.Controls.Add(this.UsernameTextBox);
            this.HomePanel.Controls.Add(this.SignUpButton);
            this.HomePanel.Controls.Add(this.SignInButton);
            this.HomePanel.Controls.Add(this.SignInLogoPictureBox);
            this.bunifuTransition2.SetDecoration(this.HomePanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.HomePanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePanel.Location = new System.Drawing.Point(0, 0);
            this.HomePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(1067, 554);
            this.HomePanel.TabIndex = 3;
            this.HomePanel.SizeChanged += new System.EventHandler(this.MiddlePanel_SizeChanged);
            // 
            // TruyencamhungLabel
            // 
            this.bunifuTransition1.SetDecoration(this.TruyencamhungLabel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.TruyencamhungLabel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.TruyencamhungLabel.Font = new System.Drawing.Font("Agency FB", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TruyencamhungLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.TruyencamhungLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TruyencamhungLabel.Location = new System.Drawing.Point(0, 0);
            this.TruyencamhungLabel.Name = "TruyencamhungLabel";
            this.TruyencamhungLabel.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.TruyencamhungLabel.Size = new System.Drawing.Size(1067, 73);
            this.TruyencamhungLabel.TabIndex = 5;
            this.TruyencamhungLabel.Text = "Learning is the eye of the mind";
            this.TruyencamhungLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NotificationLabel
            // 
            this.NotificationLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.NotificationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.NotificationLabel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.NotificationLabel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.NotificationLabel.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotificationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.NotificationLabel.Image = global::StudyManagementApp.Properties.Resources.Message_small;
            this.NotificationLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NotificationLabel.Location = new System.Drawing.Point(368, 270);
            this.NotificationLabel.Name = "NotificationLabel";
            this.NotificationLabel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.NotificationLabel.Size = new System.Drawing.Size(331, 39);
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
            this.bunifuTransition1.SetDecoration(this.PasswordTextBox, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.PasswordTextBox, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PasswordTextBox.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.PasswordTextBox.Location = new System.Drawing.Point(596, 337);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.PasswordTextBox.Multiline = false;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.PasswordTextBox.PasswordChar = true;
            this.PasswordTextBox.PlaceholderColor = System.Drawing.Color.Gray;
            this.PasswordTextBox.PlaceholderText = "Password";
            this.PasswordTextBox.Size = new System.Drawing.Size(311, 42);
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
            this.bunifuTransition1.SetDecoration(this.UsernameTextBox, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.UsernameTextBox, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.UsernameTextBox.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.UsernameTextBox.Location = new System.Drawing.Point(160, 337);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.UsernameTextBox.Multiline = false;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.UsernameTextBox.PasswordChar = false;
            this.UsernameTextBox.PlaceholderColor = System.Drawing.Color.Gray;
            this.UsernameTextBox.PlaceholderText = "Username";
            this.UsernameTextBox.Size = new System.Drawing.Size(311, 42);
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
            this.bunifuTransition1.SetDecoration(this.SignUpButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.SignUpButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.SignUpButton.FlatAppearance.BorderSize = 0;
            this.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpButton.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.SignUpButton.Location = new System.Drawing.Point(569, 410);
            this.SignUpButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(151, 67);
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
            this.bunifuTransition1.SetDecoration(this.SignInButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.SignInButton, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.SignInButton.FlatAppearance.BorderSize = 0;
            this.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInButton.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.SignInButton.Location = new System.Drawing.Point(348, 410);
            this.SignInButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(151, 67);
            this.SignInButton.TabIndex = 2;
            this.SignInButton.Text = "Sign-in";
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // SignInLogoPictureBox
            // 
            this.bunifuTransition1.SetDecoration(this.SignInLogoPictureBox, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.SignInLogoPictureBox, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.SignInLogoPictureBox.Image = global::StudyManagementApp.Properties.Resources.Logo;
            this.SignInLogoPictureBox.Location = new System.Drawing.Point(447, 101);
            this.SignInLogoPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignInLogoPictureBox.Name = "SignInLogoPictureBox";
            this.SignInLogoPictureBox.Size = new System.Drawing.Size(175, 144);
            this.SignInLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SignInLogoPictureBox.TabIndex = 0;
            this.SignInLogoPictureBox.TabStop = false;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.VertBlind;
            this.bunifuTransition1.Cursor = null;
            animation11.AnimateOnlyDifferences = true;
            animation11.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.BlindCoeff")));
            animation11.LeafCoeff = 0F;
            animation11.MaxTime = 1F;
            animation11.MinTime = 0F;
            animation11.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.MosaicCoeff")));
            animation11.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation11.MosaicShift")));
            animation11.MosaicSize = 0;
            animation11.Padding = new System.Windows.Forms.Padding(0);
            animation11.RotateCoeff = 0F;
            animation11.RotateLimit = 0F;
            animation11.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.ScaleCoeff")));
            animation11.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.SlideCoeff")));
            animation11.TimeCoeff = 0F;
            animation11.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation11;
            this.bunifuTransition1.Interval = 5;
            this.bunifuTransition1.MaxAnimationTime = 1000;
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Scale;
            this.bunifuTransition2.Cursor = null;
            animation12.AnimateOnlyDifferences = true;
            animation12.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.BlindCoeff")));
            animation12.LeafCoeff = 0F;
            animation12.MaxTime = 1F;
            animation12.MinTime = 0F;
            animation12.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.MosaicCoeff")));
            animation12.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation12.MosaicShift")));
            animation12.MosaicSize = 0;
            animation12.Padding = new System.Windows.Forms.Padding(0);
            animation12.RotateCoeff = 0F;
            animation12.RotateLimit = 0F;
            animation12.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.ScaleCoeff")));
            animation12.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.SlideCoeff")));
            animation12.TimeCoeff = 0F;
            animation12.TransparencyCoeff = 0F;
            this.bunifuTransition2.DefaultAnimation = animation12;
            this.bunifuTransition2.Interval = 5;
            this.bunifuTransition2.MaxAnimationTime = 1000;
            // 
            // aboutUC1
            // 
            this.bunifuTransition1.SetDecoration(this.aboutUC1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.aboutUC1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.aboutUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutUC1.Location = new System.Drawing.Point(0, 0);
            this.aboutUC1.Name = "aboutUC1";
            this.aboutUC1.Size = new System.Drawing.Size(1067, 554);
            this.aboutUC1.TabIndex = 6;
            // 
            // helpUC1
            // 
            this.bunifuTransition1.SetDecoration(this.helpUC1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.helpUC1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.helpUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpUC1.Location = new System.Drawing.Point(0, 0);
            this.helpUC1.Name = "helpUC1";
            this.helpUC1.Size = new System.Drawing.Size(1067, 554);
            this.helpUC1.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.aboutUC1);
            this.Controls.Add(this.helpUC1);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.BottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Help)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.About)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).EndInit();
            this.HomePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SignInLogoPictureBox)).EndInit();
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
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition2;
        private UserControls.AboutUC aboutUC1;
        private UserControls.HelpUC helpUC1;
    }
}

