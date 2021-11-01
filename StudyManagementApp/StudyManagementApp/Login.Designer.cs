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
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation7 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation8 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.Help = new System.Windows.Forms.PictureBox();
            this.About = new System.Windows.Forms.PictureBox();
            this.Home = new System.Windows.Forms.PictureBox();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.TruyencamhungLabel = new System.Windows.Forms.Label();
            this.NotificationLabel = new System.Windows.Forms.Label();
            this.SignInLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.AboutPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.HelpPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuTransition2 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.PasswordTextBox = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.UsernameTextBox = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.SignUpButton = new StudyManagementApp.UserControls.RoundedCornerButton();
            this.SignInButton = new StudyManagementApp.UserControls.RoundedCornerButton();
            this.roundedCornerTextBox13 = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.roundedCornerTextBox2 = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.roundedCornerTextBox12 = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.roundedCornerTextBox11 = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.roundedCornerTextBox5 = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.roundedCornerTextBox8 = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.roundedCornerTextBox7 = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.roundedCornerTextBox3 = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.roundedCornerTextBox6 = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.roundedCornerTextBox14 = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.roundedCornerTextBox15 = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.roundedCornerTextBox9 = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.roundedCornerTextBox16 = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.TbName = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.roundedCornerTextBox17 = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.roundedCornerTextBox10 = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.roundedCornerTextBox18 = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.roundedCornerTextBox4 = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Help)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.About)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            this.HomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignInLogoPictureBox)).BeginInit();
            this.AboutPanel.SuspendLayout();
            this.HelpPanel.SuspendLayout();
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
            this.TruyencamhungLabel.Dock = System.Windows.Forms.DockStyle.Top;
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
            animation7.AnimateOnlyDifferences = true;
            animation7.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.BlindCoeff")));
            animation7.LeafCoeff = 0F;
            animation7.MaxTime = 1F;
            animation7.MinTime = 0F;
            animation7.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicCoeff")));
            animation7.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicShift")));
            animation7.MosaicSize = 0;
            animation7.Padding = new System.Windows.Forms.Padding(0);
            animation7.RotateCoeff = 0F;
            animation7.RotateLimit = 0F;
            animation7.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.ScaleCoeff")));
            animation7.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.SlideCoeff")));
            animation7.TimeCoeff = 0F;
            animation7.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation7;
            this.bunifuTransition1.Interval = 5;
            this.bunifuTransition1.MaxAnimationTime = 1000;
            // 
            // AboutPanel
            // 
            this.AboutPanel.BackColor = System.Drawing.SystemColors.Menu;
            this.AboutPanel.Controls.Add(this.roundedCornerTextBox18);
            this.AboutPanel.Controls.Add(this.roundedCornerTextBox4);
            this.AboutPanel.Controls.Add(this.roundedCornerTextBox17);
            this.AboutPanel.Controls.Add(this.roundedCornerTextBox16);
            this.AboutPanel.Controls.Add(this.roundedCornerTextBox10);
            this.AboutPanel.Controls.Add(this.roundedCornerTextBox15);
            this.AboutPanel.Controls.Add(this.roundedCornerTextBox14);
            this.AboutPanel.Controls.Add(this.label1);
            this.AboutPanel.Controls.Add(this.roundedCornerTextBox3);
            this.AboutPanel.Controls.Add(this.roundedCornerTextBox7);
            this.AboutPanel.Controls.Add(this.roundedCornerTextBox8);
            this.AboutPanel.Controls.Add(this.TbName);
            this.AboutPanel.Controls.Add(this.roundedCornerTextBox6);
            this.AboutPanel.Controls.Add(this.roundedCornerTextBox5);
            this.AboutPanel.Controls.Add(this.roundedCornerTextBox9);
            this.AboutPanel.Controls.Add(this.roundedCornerTextBox11);
            this.AboutPanel.Controls.Add(this.roundedCornerTextBox12);
            this.AboutPanel.Controls.Add(this.roundedCornerTextBox13);
            this.AboutPanel.Controls.Add(this.roundedCornerTextBox2);
            this.bunifuTransition2.SetDecoration(this.AboutPanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.AboutPanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.AboutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AboutPanel.Location = new System.Drawing.Point(0, 0);
            this.AboutPanel.Name = "AboutPanel";
            this.AboutPanel.Size = new System.Drawing.Size(1067, 554);
            this.AboutPanel.TabIndex = 14;
            // 
            // label1
            // 
            this.bunifuTransition1.SetDecoration(this.label1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Algerian", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.label1.Size = new System.Drawing.Size(1067, 86);
            this.label1.TabIndex = 6;
            this.label1.Text = "TEAM 14 ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HelpPanel
            // 
            this.HelpPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.HelpPanel.Controls.Add(this.label2);
            this.bunifuTransition2.SetDecoration(this.HelpPanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.HelpPanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.HelpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HelpPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpPanel.Location = new System.Drawing.Point(0, 0);
            this.HelpPanel.Name = "HelpPanel";
            this.HelpPanel.Size = new System.Drawing.Size(1067, 554);
            this.HelpPanel.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 78);
            this.label2.TabIndex = 0;
            this.label2.Text = "Instruction";
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Scale;
            this.bunifuTransition2.Cursor = null;
            animation8.AnimateOnlyDifferences = true;
            animation8.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.BlindCoeff")));
            animation8.LeafCoeff = 0F;
            animation8.MaxTime = 1F;
            animation8.MinTime = 0F;
            animation8.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicCoeff")));
            animation8.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicShift")));
            animation8.MosaicSize = 0;
            animation8.Padding = new System.Windows.Forms.Padding(0);
            animation8.RotateCoeff = 0F;
            animation8.RotateLimit = 0F;
            animation8.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.ScaleCoeff")));
            animation8.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.SlideCoeff")));
            animation8.TimeCoeff = 0F;
            animation8.TransparencyCoeff = 0F;
            this.bunifuTransition2.DefaultAnimation = animation8;
            this.bunifuTransition2.Interval = 5;
            this.bunifuTransition2.MaxAnimationTime = 1000;
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
            this.SignUpButton.Size = new System.Drawing.Size(151, 47);
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
            this.SignInButton.Size = new System.Drawing.Size(151, 47);
            this.SignInButton.TabIndex = 2;
            this.SignInButton.Text = "Sign-in";
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // roundedCornerTextBox13
            // 
            this.roundedCornerTextBox13.BackColor = System.Drawing.SystemColors.Menu;
            this.roundedCornerTextBox13.BorderColor = System.Drawing.Color.Azure;
            this.roundedCornerTextBox13.BorderFocusColor = System.Drawing.Color.HotPink;
            this.roundedCornerTextBox13.BorderRadius = 15;
            this.roundedCornerTextBox13.BorderSize = 2;
            this.bunifuTransition1.SetDecoration(this.roundedCornerTextBox13, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.roundedCornerTextBox13, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.roundedCornerTextBox13.Enabled = false;
            this.roundedCornerTextBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedCornerTextBox13.ForeColor = System.Drawing.Color.Black;
            this.roundedCornerTextBox13.Location = new System.Drawing.Point(399, 395);
            this.roundedCornerTextBox13.Margin = new System.Windows.Forms.Padding(4);
            this.roundedCornerTextBox13.Multiline = false;
            this.roundedCornerTextBox13.Name = "roundedCornerTextBox13";
            this.roundedCornerTextBox13.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.roundedCornerTextBox13.PasswordChar = false;
            this.roundedCornerTextBox13.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.roundedCornerTextBox13.PlaceholderText = "";
            this.roundedCornerTextBox13.Size = new System.Drawing.Size(250, 41);
            this.roundedCornerTextBox13.TabIndex = 17;
            this.roundedCornerTextBox13.Texts = "Male";
            this.roundedCornerTextBox13.UnderlinedStyle = false;
            // 
            // roundedCornerTextBox2
            // 
            this.roundedCornerTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.roundedCornerTextBox2.BorderColor = System.Drawing.Color.Azure;
            this.roundedCornerTextBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.roundedCornerTextBox2.BorderRadius = 15;
            this.roundedCornerTextBox2.BorderSize = 2;
            this.bunifuTransition1.SetDecoration(this.roundedCornerTextBox2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.roundedCornerTextBox2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.roundedCornerTextBox2.Enabled = false;
            this.roundedCornerTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedCornerTextBox2.ForeColor = System.Drawing.Color.Black;
            this.roundedCornerTextBox2.Location = new System.Drawing.Point(463, 96);
            this.roundedCornerTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.roundedCornerTextBox2.Multiline = false;
            this.roundedCornerTextBox2.Name = "roundedCornerTextBox2";
            this.roundedCornerTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.roundedCornerTextBox2.PasswordChar = false;
            this.roundedCornerTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.roundedCornerTextBox2.PlaceholderText = "";
            this.roundedCornerTextBox2.Size = new System.Drawing.Size(115, 41);
            this.roundedCornerTextBox2.TabIndex = 2;
            this.roundedCornerTextBox2.Texts = "Gender";
            this.roundedCornerTextBox2.UnderlinedStyle = false;
            // 
            // roundedCornerTextBox12
            // 
            this.roundedCornerTextBox12.BackColor = System.Drawing.SystemColors.Menu;
            this.roundedCornerTextBox12.BorderColor = System.Drawing.Color.Azure;
            this.roundedCornerTextBox12.BorderFocusColor = System.Drawing.Color.HotPink;
            this.roundedCornerTextBox12.BorderRadius = 15;
            this.roundedCornerTextBox12.BorderSize = 2;
            this.bunifuTransition1.SetDecoration(this.roundedCornerTextBox12, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.roundedCornerTextBox12, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.roundedCornerTextBox12.Enabled = false;
            this.roundedCornerTextBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedCornerTextBox12.ForeColor = System.Drawing.Color.Black;
            this.roundedCornerTextBox12.Location = new System.Drawing.Point(399, 337);
            this.roundedCornerTextBox12.Margin = new System.Windows.Forms.Padding(4);
            this.roundedCornerTextBox12.Multiline = false;
            this.roundedCornerTextBox12.Name = "roundedCornerTextBox12";
            this.roundedCornerTextBox12.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.roundedCornerTextBox12.PasswordChar = false;
            this.roundedCornerTextBox12.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.roundedCornerTextBox12.PlaceholderText = "";
            this.roundedCornerTextBox12.Size = new System.Drawing.Size(250, 41);
            this.roundedCornerTextBox12.TabIndex = 16;
            this.roundedCornerTextBox12.Texts = "Male";
            this.roundedCornerTextBox12.UnderlinedStyle = false;
            // 
            // roundedCornerTextBox11
            // 
            this.roundedCornerTextBox11.BackColor = System.Drawing.SystemColors.Menu;
            this.roundedCornerTextBox11.BorderColor = System.Drawing.Color.Azure;
            this.roundedCornerTextBox11.BorderFocusColor = System.Drawing.Color.HotPink;
            this.roundedCornerTextBox11.BorderRadius = 15;
            this.roundedCornerTextBox11.BorderSize = 2;
            this.bunifuTransition1.SetDecoration(this.roundedCornerTextBox11, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.roundedCornerTextBox11, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.roundedCornerTextBox11.Enabled = false;
            this.roundedCornerTextBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedCornerTextBox11.ForeColor = System.Drawing.Color.Black;
            this.roundedCornerTextBox11.Location = new System.Drawing.Point(399, 273);
            this.roundedCornerTextBox11.Margin = new System.Windows.Forms.Padding(4);
            this.roundedCornerTextBox11.Multiline = false;
            this.roundedCornerTextBox11.Name = "roundedCornerTextBox11";
            this.roundedCornerTextBox11.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.roundedCornerTextBox11.PasswordChar = false;
            this.roundedCornerTextBox11.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.roundedCornerTextBox11.PlaceholderText = "";
            this.roundedCornerTextBox11.Size = new System.Drawing.Size(250, 41);
            this.roundedCornerTextBox11.TabIndex = 15;
            this.roundedCornerTextBox11.Texts = "Male";
            this.roundedCornerTextBox11.UnderlinedStyle = false;
            // 
            // roundedCornerTextBox5
            // 
            this.roundedCornerTextBox5.BackColor = System.Drawing.SystemColors.Menu;
            this.roundedCornerTextBox5.BorderColor = System.Drawing.Color.Azure;
            this.roundedCornerTextBox5.BorderFocusColor = System.Drawing.Color.HotPink;
            this.roundedCornerTextBox5.BorderRadius = 15;
            this.roundedCornerTextBox5.BorderSize = 2;
            this.bunifuTransition1.SetDecoration(this.roundedCornerTextBox5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.roundedCornerTextBox5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.roundedCornerTextBox5.Enabled = false;
            this.roundedCornerTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedCornerTextBox5.ForeColor = System.Drawing.Color.Black;
            this.roundedCornerTextBox5.Location = new System.Drawing.Point(399, 154);
            this.roundedCornerTextBox5.Margin = new System.Windows.Forms.Padding(4);
            this.roundedCornerTextBox5.Multiline = false;
            this.roundedCornerTextBox5.Name = "roundedCornerTextBox5";
            this.roundedCornerTextBox5.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.roundedCornerTextBox5.PasswordChar = false;
            this.roundedCornerTextBox5.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.roundedCornerTextBox5.PlaceholderText = "";
            this.roundedCornerTextBox5.Size = new System.Drawing.Size(250, 41);
            this.roundedCornerTextBox5.TabIndex = 8;
            this.roundedCornerTextBox5.Texts = "Male";
            this.roundedCornerTextBox5.UnderlinedStyle = false;
            // 
            // roundedCornerTextBox8
            // 
            this.roundedCornerTextBox8.BackColor = System.Drawing.SystemColors.Menu;
            this.roundedCornerTextBox8.BorderColor = System.Drawing.Color.Azure;
            this.roundedCornerTextBox8.BorderFocusColor = System.Drawing.Color.HotPink;
            this.roundedCornerTextBox8.BorderRadius = 15;
            this.roundedCornerTextBox8.BorderSize = 2;
            this.bunifuTransition1.SetDecoration(this.roundedCornerTextBox8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.roundedCornerTextBox8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.roundedCornerTextBox8.Enabled = false;
            this.roundedCornerTextBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedCornerTextBox8.ForeColor = System.Drawing.Color.Black;
            this.roundedCornerTextBox8.Location = new System.Drawing.Point(91, 273);
            this.roundedCornerTextBox8.Margin = new System.Windows.Forms.Padding(4);
            this.roundedCornerTextBox8.Multiline = false;
            this.roundedCornerTextBox8.Name = "roundedCornerTextBox8";
            this.roundedCornerTextBox8.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.roundedCornerTextBox8.PasswordChar = false;
            this.roundedCornerTextBox8.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.roundedCornerTextBox8.PlaceholderText = "";
            this.roundedCornerTextBox8.Size = new System.Drawing.Size(250, 41);
            this.roundedCornerTextBox8.TabIndex = 11;
            this.roundedCornerTextBox8.Texts = "Phan Trường Huy";
            this.roundedCornerTextBox8.UnderlinedStyle = false;
            // 
            // roundedCornerTextBox7
            // 
            this.roundedCornerTextBox7.BackColor = System.Drawing.SystemColors.Menu;
            this.roundedCornerTextBox7.BorderColor = System.Drawing.Color.Azure;
            this.roundedCornerTextBox7.BorderFocusColor = System.Drawing.Color.HotPink;
            this.roundedCornerTextBox7.BorderRadius = 15;
            this.roundedCornerTextBox7.BorderSize = 2;
            this.bunifuTransition1.SetDecoration(this.roundedCornerTextBox7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.roundedCornerTextBox7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.roundedCornerTextBox7.Enabled = false;
            this.roundedCornerTextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedCornerTextBox7.ForeColor = System.Drawing.Color.Black;
            this.roundedCornerTextBox7.Location = new System.Drawing.Point(91, 337);
            this.roundedCornerTextBox7.Margin = new System.Windows.Forms.Padding(4);
            this.roundedCornerTextBox7.Multiline = false;
            this.roundedCornerTextBox7.Name = "roundedCornerTextBox7";
            this.roundedCornerTextBox7.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.roundedCornerTextBox7.PasswordChar = false;
            this.roundedCornerTextBox7.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.roundedCornerTextBox7.PlaceholderText = "";
            this.roundedCornerTextBox7.Size = new System.Drawing.Size(250, 41);
            this.roundedCornerTextBox7.TabIndex = 10;
            this.roundedCornerTextBox7.Texts = "Nguyễn Minh Hiếu";
            this.roundedCornerTextBox7.UnderlinedStyle = false;
            // 
            // roundedCornerTextBox3
            // 
            this.roundedCornerTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.roundedCornerTextBox3.BorderColor = System.Drawing.Color.Azure;
            this.roundedCornerTextBox3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.roundedCornerTextBox3.BorderRadius = 15;
            this.roundedCornerTextBox3.BorderSize = 2;
            this.bunifuTransition1.SetDecoration(this.roundedCornerTextBox3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.roundedCornerTextBox3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.roundedCornerTextBox3.Enabled = false;
            this.roundedCornerTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedCornerTextBox3.ForeColor = System.Drawing.Color.Black;
            this.roundedCornerTextBox3.Location = new System.Drawing.Point(792, 96);
            this.roundedCornerTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.roundedCornerTextBox3.Multiline = false;
            this.roundedCornerTextBox3.Name = "roundedCornerTextBox3";
            this.roundedCornerTextBox3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.roundedCornerTextBox3.PasswordChar = false;
            this.roundedCornerTextBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.roundedCornerTextBox3.PlaceholderText = "";
            this.roundedCornerTextBox3.Size = new System.Drawing.Size(115, 41);
            this.roundedCornerTextBox3.TabIndex = 3;
            this.roundedCornerTextBox3.Texts = "Gmail";
            this.roundedCornerTextBox3.UnderlinedStyle = false;
            // 
            // roundedCornerTextBox6
            // 
            this.roundedCornerTextBox6.BackColor = System.Drawing.SystemColors.Menu;
            this.roundedCornerTextBox6.BorderColor = System.Drawing.Color.Azure;
            this.roundedCornerTextBox6.BorderFocusColor = System.Drawing.Color.HotPink;
            this.roundedCornerTextBox6.BorderRadius = 15;
            this.roundedCornerTextBox6.BorderSize = 2;
            this.bunifuTransition1.SetDecoration(this.roundedCornerTextBox6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.roundedCornerTextBox6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.roundedCornerTextBox6.Enabled = false;
            this.roundedCornerTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedCornerTextBox6.ForeColor = System.Drawing.Color.Black;
            this.roundedCornerTextBox6.Location = new System.Drawing.Point(91, 395);
            this.roundedCornerTextBox6.Margin = new System.Windows.Forms.Padding(4);
            this.roundedCornerTextBox6.Multiline = false;
            this.roundedCornerTextBox6.Name = "roundedCornerTextBox6";
            this.roundedCornerTextBox6.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.roundedCornerTextBox6.PasswordChar = false;
            this.roundedCornerTextBox6.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.roundedCornerTextBox6.PlaceholderText = "";
            this.roundedCornerTextBox6.Size = new System.Drawing.Size(250, 41);
            this.roundedCornerTextBox6.TabIndex = 9;
            this.roundedCornerTextBox6.Texts = "Trần Thanh Trí";
            this.roundedCornerTextBox6.UnderlinedStyle = false;
            // 
            // roundedCornerTextBox14
            // 
            this.roundedCornerTextBox14.BackColor = System.Drawing.SystemColors.Menu;
            this.roundedCornerTextBox14.BorderColor = System.Drawing.Color.Azure;
            this.roundedCornerTextBox14.BorderFocusColor = System.Drawing.Color.HotPink;
            this.roundedCornerTextBox14.BorderRadius = 15;
            this.roundedCornerTextBox14.BorderSize = 2;
            this.bunifuTransition1.SetDecoration(this.roundedCornerTextBox14, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.roundedCornerTextBox14, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.roundedCornerTextBox14.Enabled = false;
            this.roundedCornerTextBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedCornerTextBox14.ForeColor = System.Drawing.Color.Black;
            this.roundedCornerTextBox14.Location = new System.Drawing.Point(718, 154);
            this.roundedCornerTextBox14.Margin = new System.Windows.Forms.Padding(4);
            this.roundedCornerTextBox14.Multiline = false;
            this.roundedCornerTextBox14.Name = "roundedCornerTextBox14";
            this.roundedCornerTextBox14.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.roundedCornerTextBox14.PasswordChar = false;
            this.roundedCornerTextBox14.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.roundedCornerTextBox14.PlaceholderText = "";
            this.roundedCornerTextBox14.Size = new System.Drawing.Size(277, 41);
            this.roundedCornerTextBox14.TabIndex = 18;
            this.roundedCornerTextBox14.Texts = "20520328@gm.uit.edu.vn";
            this.roundedCornerTextBox14.UnderlinedStyle = false;
            // 
            // roundedCornerTextBox15
            // 
            this.roundedCornerTextBox15.BackColor = System.Drawing.SystemColors.Menu;
            this.roundedCornerTextBox15.BorderColor = System.Drawing.Color.Azure;
            this.roundedCornerTextBox15.BorderFocusColor = System.Drawing.Color.HotPink;
            this.roundedCornerTextBox15.BorderRadius = 15;
            this.roundedCornerTextBox15.BorderSize = 2;
            this.bunifuTransition1.SetDecoration(this.roundedCornerTextBox15, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.roundedCornerTextBox15, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.roundedCornerTextBox15.Enabled = false;
            this.roundedCornerTextBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedCornerTextBox15.ForeColor = System.Drawing.Color.Black;
            this.roundedCornerTextBox15.Location = new System.Drawing.Point(718, 214);
            this.roundedCornerTextBox15.Margin = new System.Windows.Forms.Padding(4);
            this.roundedCornerTextBox15.Multiline = false;
            this.roundedCornerTextBox15.Name = "roundedCornerTextBox15";
            this.roundedCornerTextBox15.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.roundedCornerTextBox15.PasswordChar = false;
            this.roundedCornerTextBox15.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.roundedCornerTextBox15.PlaceholderText = "";
            this.roundedCornerTextBox15.Size = new System.Drawing.Size(277, 41);
            this.roundedCornerTextBox15.TabIndex = 19;
            this.roundedCornerTextBox15.Texts = "20520328@gm.uit.edu.vn";
            this.roundedCornerTextBox15.UnderlinedStyle = false;
            // 
            // roundedCornerTextBox9
            // 
            this.roundedCornerTextBox9.BackColor = System.Drawing.SystemColors.Menu;
            this.roundedCornerTextBox9.BorderColor = System.Drawing.Color.Azure;
            this.roundedCornerTextBox9.BorderFocusColor = System.Drawing.Color.HotPink;
            this.roundedCornerTextBox9.BorderRadius = 15;
            this.roundedCornerTextBox9.BorderSize = 2;
            this.bunifuTransition1.SetDecoration(this.roundedCornerTextBox9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.roundedCornerTextBox9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.roundedCornerTextBox9.Enabled = false;
            this.roundedCornerTextBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedCornerTextBox9.ForeColor = System.Drawing.Color.Black;
            this.roundedCornerTextBox9.Location = new System.Drawing.Point(91, 214);
            this.roundedCornerTextBox9.Margin = new System.Windows.Forms.Padding(4);
            this.roundedCornerTextBox9.Multiline = false;
            this.roundedCornerTextBox9.Name = "roundedCornerTextBox9";
            this.roundedCornerTextBox9.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.roundedCornerTextBox9.PasswordChar = false;
            this.roundedCornerTextBox9.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.roundedCornerTextBox9.PlaceholderText = "";
            this.roundedCornerTextBox9.Size = new System.Drawing.Size(250, 41);
            this.roundedCornerTextBox9.TabIndex = 12;
            this.roundedCornerTextBox9.Texts = "Nguyễn Văn Hên";
            this.roundedCornerTextBox9.UnderlinedStyle = false;
            // 
            // roundedCornerTextBox16
            // 
            this.roundedCornerTextBox16.BackColor = System.Drawing.SystemColors.Menu;
            this.roundedCornerTextBox16.BorderColor = System.Drawing.Color.Azure;
            this.roundedCornerTextBox16.BorderFocusColor = System.Drawing.Color.HotPink;
            this.roundedCornerTextBox16.BorderRadius = 15;
            this.roundedCornerTextBox16.BorderSize = 2;
            this.bunifuTransition1.SetDecoration(this.roundedCornerTextBox16, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.roundedCornerTextBox16, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.roundedCornerTextBox16.Enabled = false;
            this.roundedCornerTextBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedCornerTextBox16.ForeColor = System.Drawing.Color.Black;
            this.roundedCornerTextBox16.Location = new System.Drawing.Point(718, 273);
            this.roundedCornerTextBox16.Margin = new System.Windows.Forms.Padding(4);
            this.roundedCornerTextBox16.Multiline = false;
            this.roundedCornerTextBox16.Name = "roundedCornerTextBox16";
            this.roundedCornerTextBox16.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.roundedCornerTextBox16.PasswordChar = false;
            this.roundedCornerTextBox16.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.roundedCornerTextBox16.PlaceholderText = "";
            this.roundedCornerTextBox16.Size = new System.Drawing.Size(277, 41);
            this.roundedCornerTextBox16.TabIndex = 20;
            this.roundedCornerTextBox16.Texts = "20520328@gm.uit.edu.vn";
            this.roundedCornerTextBox16.UnderlinedStyle = false;
            // 
            // TbName
            // 
            this.TbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TbName.BorderColor = System.Drawing.Color.Azure;
            this.TbName.BorderFocusColor = System.Drawing.Color.White;
            this.TbName.BorderRadius = 15;
            this.TbName.BorderSize = 2;
            this.bunifuTransition1.SetDecoration(this.TbName, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.TbName, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.TbName.Enabled = false;
            this.TbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbName.ForeColor = System.Drawing.Color.Black;
            this.TbName.Location = new System.Drawing.Point(154, 96);
            this.TbName.Margin = new System.Windows.Forms.Padding(4);
            this.TbName.Multiline = false;
            this.TbName.Name = "TbName";
            this.TbName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TbName.PasswordChar = false;
            this.TbName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TbName.PlaceholderText = "";
            this.TbName.Size = new System.Drawing.Size(115, 41);
            this.TbName.TabIndex = 1;
            this.TbName.Texts = "Name";
            this.TbName.UnderlinedStyle = false;
            // 
            // roundedCornerTextBox17
            // 
            this.roundedCornerTextBox17.BackColor = System.Drawing.SystemColors.Menu;
            this.roundedCornerTextBox17.BorderColor = System.Drawing.Color.Azure;
            this.roundedCornerTextBox17.BorderFocusColor = System.Drawing.Color.HotPink;
            this.roundedCornerTextBox17.BorderRadius = 15;
            this.roundedCornerTextBox17.BorderSize = 2;
            this.bunifuTransition1.SetDecoration(this.roundedCornerTextBox17, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.roundedCornerTextBox17, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.roundedCornerTextBox17.Enabled = false;
            this.roundedCornerTextBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedCornerTextBox17.ForeColor = System.Drawing.Color.Black;
            this.roundedCornerTextBox17.Location = new System.Drawing.Point(718, 337);
            this.roundedCornerTextBox17.Margin = new System.Windows.Forms.Padding(4);
            this.roundedCornerTextBox17.Multiline = false;
            this.roundedCornerTextBox17.Name = "roundedCornerTextBox17";
            this.roundedCornerTextBox17.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.roundedCornerTextBox17.PasswordChar = false;
            this.roundedCornerTextBox17.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.roundedCornerTextBox17.PlaceholderText = "";
            this.roundedCornerTextBox17.Size = new System.Drawing.Size(277, 41);
            this.roundedCornerTextBox17.TabIndex = 21;
            this.roundedCornerTextBox17.Texts = "20520328@gm.uit.edu.vn";
            this.roundedCornerTextBox17.UnderlinedStyle = false;
            // 
            // roundedCornerTextBox10
            // 
            this.roundedCornerTextBox10.BackColor = System.Drawing.SystemColors.Menu;
            this.roundedCornerTextBox10.BorderColor = System.Drawing.Color.Azure;
            this.roundedCornerTextBox10.BorderFocusColor = System.Drawing.Color.HotPink;
            this.roundedCornerTextBox10.BorderRadius = 15;
            this.roundedCornerTextBox10.BorderSize = 2;
            this.bunifuTransition1.SetDecoration(this.roundedCornerTextBox10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.roundedCornerTextBox10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.roundedCornerTextBox10.Enabled = false;
            this.roundedCornerTextBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedCornerTextBox10.ForeColor = System.Drawing.Color.Black;
            this.roundedCornerTextBox10.Location = new System.Drawing.Point(399, 214);
            this.roundedCornerTextBox10.Margin = new System.Windows.Forms.Padding(4);
            this.roundedCornerTextBox10.Multiline = false;
            this.roundedCornerTextBox10.Name = "roundedCornerTextBox10";
            this.roundedCornerTextBox10.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.roundedCornerTextBox10.PasswordChar = false;
            this.roundedCornerTextBox10.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.roundedCornerTextBox10.PlaceholderText = "";
            this.roundedCornerTextBox10.Size = new System.Drawing.Size(250, 41);
            this.roundedCornerTextBox10.TabIndex = 14;
            this.roundedCornerTextBox10.Texts = "Male";
            this.roundedCornerTextBox10.UnderlinedStyle = false;
            // 
            // roundedCornerTextBox18
            // 
            this.roundedCornerTextBox18.BackColor = System.Drawing.SystemColors.Menu;
            this.roundedCornerTextBox18.BorderColor = System.Drawing.Color.Azure;
            this.roundedCornerTextBox18.BorderFocusColor = System.Drawing.Color.HotPink;
            this.roundedCornerTextBox18.BorderRadius = 15;
            this.roundedCornerTextBox18.BorderSize = 2;
            this.bunifuTransition1.SetDecoration(this.roundedCornerTextBox18, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.roundedCornerTextBox18, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.roundedCornerTextBox18.Enabled = false;
            this.roundedCornerTextBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedCornerTextBox18.ForeColor = System.Drawing.Color.Black;
            this.roundedCornerTextBox18.Location = new System.Drawing.Point(718, 395);
            this.roundedCornerTextBox18.Margin = new System.Windows.Forms.Padding(4);
            this.roundedCornerTextBox18.Multiline = false;
            this.roundedCornerTextBox18.Name = "roundedCornerTextBox18";
            this.roundedCornerTextBox18.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.roundedCornerTextBox18.PasswordChar = false;
            this.roundedCornerTextBox18.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.roundedCornerTextBox18.PlaceholderText = "";
            this.roundedCornerTextBox18.Size = new System.Drawing.Size(277, 41);
            this.roundedCornerTextBox18.TabIndex = 22;
            this.roundedCornerTextBox18.Texts = "20520328@gm.uit.edu.vn";
            this.roundedCornerTextBox18.UnderlinedStyle = false;
            // 
            // roundedCornerTextBox4
            // 
            this.roundedCornerTextBox4.BackColor = System.Drawing.SystemColors.Menu;
            this.roundedCornerTextBox4.BorderColor = System.Drawing.Color.Azure;
            this.roundedCornerTextBox4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.roundedCornerTextBox4.BorderRadius = 15;
            this.roundedCornerTextBox4.BorderSize = 2;
            this.bunifuTransition1.SetDecoration(this.roundedCornerTextBox4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.roundedCornerTextBox4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.roundedCornerTextBox4.Enabled = false;
            this.roundedCornerTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedCornerTextBox4.ForeColor = System.Drawing.Color.Black;
            this.roundedCornerTextBox4.Location = new System.Drawing.Point(91, 154);
            this.roundedCornerTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.roundedCornerTextBox4.Multiline = false;
            this.roundedCornerTextBox4.Name = "roundedCornerTextBox4";
            this.roundedCornerTextBox4.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.roundedCornerTextBox4.PasswordChar = false;
            this.roundedCornerTextBox4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.roundedCornerTextBox4.PlaceholderText = "";
            this.roundedCornerTextBox4.Size = new System.Drawing.Size(250, 41);
            this.roundedCornerTextBox4.TabIndex = 7;
            this.roundedCornerTextBox4.Texts = "Trần Đình Khôi";
            this.roundedCornerTextBox4.UnderlinedStyle = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.AboutPanel);
            this.Controls.Add(this.HelpPanel);
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
            this.AboutPanel.ResumeLayout(false);
            this.HelpPanel.ResumeLayout(false);
            this.HelpPanel.PerformLayout();
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
        private System.Windows.Forms.Panel AboutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel HelpPanel;
        private System.Windows.Forms.Label label2;
        private UserControls.RoundedCornerTextBox roundedCornerTextBox18;
        private UserControls.RoundedCornerTextBox roundedCornerTextBox4;
        private UserControls.RoundedCornerTextBox roundedCornerTextBox17;
        private UserControls.RoundedCornerTextBox roundedCornerTextBox16;
        private UserControls.RoundedCornerTextBox roundedCornerTextBox10;
        private UserControls.RoundedCornerTextBox roundedCornerTextBox15;
        private UserControls.RoundedCornerTextBox roundedCornerTextBox14;
        private UserControls.RoundedCornerTextBox roundedCornerTextBox3;
        private UserControls.RoundedCornerTextBox roundedCornerTextBox7;
        private UserControls.RoundedCornerTextBox roundedCornerTextBox8;
        private UserControls.RoundedCornerTextBox TbName;
        private UserControls.RoundedCornerTextBox roundedCornerTextBox6;
        private UserControls.RoundedCornerTextBox roundedCornerTextBox5;
        private UserControls.RoundedCornerTextBox roundedCornerTextBox9;
        private UserControls.RoundedCornerTextBox roundedCornerTextBox11;
        private UserControls.RoundedCornerTextBox roundedCornerTextBox12;
        private UserControls.RoundedCornerTextBox roundedCornerTextBox13;
        private UserControls.RoundedCornerTextBox roundedCornerTextBox2;
    }
}

