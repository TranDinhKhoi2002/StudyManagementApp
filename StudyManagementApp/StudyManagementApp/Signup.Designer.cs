namespace StudyManagementApp
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.picbxLogo = new System.Windows.Forms.PictureBox();
            this.lbInstruction = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PasswordTextBox = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.UsernameTextBox = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.RePasswordTextbox = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.SignUpButton = new StudyManagementApp.UserControls.RoundedCornerButton();
            this.CancelButton = new StudyManagementApp.UserControls.RoundedCornerButton();
            ((System.ComponentModel.ISupportInitialize)(this.picbxLogo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // picbxLogo
            // 
            this.picbxLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picbxLogo.ErrorImage")));
            this.picbxLogo.ImageLocation = "C:\\Users\\admin\\Documents\\Github\\StudyManagementApp\\StudyManagementApp\\StudyManage" +
    "mentApp\\Resources\\Images\\Logo.png";
            this.picbxLogo.Location = new System.Drawing.Point(135, 30);
            this.picbxLogo.Name = "picbxLogo";
            this.picbxLogo.Size = new System.Drawing.Size(100, 100);
            this.picbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxLogo.TabIndex = 6;
            this.picbxLogo.TabStop = false;
            // 
            // lbInstruction
            // 
            this.lbInstruction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lbInstruction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbInstruction.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstruction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lbInstruction.Location = new System.Drawing.Point(0, 0);
            this.lbInstruction.Name = "lbInstruction";
            this.lbInstruction.Size = new System.Drawing.Size(261, 33);
            this.lbInstruction.TabIndex = 9;
            this.lbInstruction.Text = "Fill in the textboxes below";
            this.lbInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel3.Controls.Add(this.lbInstruction);
            this.panel3.Location = new System.Drawing.Point(49, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 33);
            this.panel3.TabIndex = 10;
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
            this.PasswordTextBox.Location = new System.Drawing.Point(63, 255);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
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
            this.UsernameTextBox.Location = new System.Drawing.Point(63, 204);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(4);
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
            // RePasswordTextbox
            // 
            this.RePasswordTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.RePasswordTextbox.BorderColor = System.Drawing.Color.DimGray;
            this.RePasswordTextbox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.RePasswordTextbox.BorderRadius = 10;
            this.RePasswordTextbox.BorderSize = 2;
            this.RePasswordTextbox.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RePasswordTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.RePasswordTextbox.Location = new System.Drawing.Point(63, 302);
            this.RePasswordTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.RePasswordTextbox.Multiline = false;
            this.RePasswordTextbox.Name = "RePasswordTextbox";
            this.RePasswordTextbox.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.RePasswordTextbox.PasswordChar = true;
            this.RePasswordTextbox.PlaceholderColor = System.Drawing.Color.Gray;
            this.RePasswordTextbox.PlaceholderText = "Re-password";
            this.RePasswordTextbox.Size = new System.Drawing.Size(233, 35);
            this.RePasswordTextbox.TabIndex = 2;
            this.RePasswordTextbox.Texts = "";
            this.RePasswordTextbox.UnderlinedStyle = false;
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
            this.SignUpButton.Location = new System.Drawing.Point(63, 358);
            this.SignUpButton.Margin = new System.Windows.Forms.Padding(2);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(113, 38);
            this.SignUpButton.TabIndex = 3;
            this.SignUpButton.Text = "Sign-up";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(81)))), ((int)(((byte)(82)))));
            this.CancelButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(73)))), ((int)(((byte)(18)))));
            this.CancelButton.BorderRadius = 18;
            this.CancelButton.BorderSize = 0;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.CancelButton.Location = new System.Drawing.Point(183, 358);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(113, 38);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(351, 431);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.RePasswordTextbox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.picbxLogo);
            this.Controls.Add(this.panel3);
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Signup_FormClosed);
            this.Load += new System.EventHandler(this.Signup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbxLogo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picbxLogo;
        private System.Windows.Forms.Label lbInstruction;
        private System.Windows.Forms.Panel panel3;
        private UserControls.RoundedCornerTextBox PasswordTextBox;
        private UserControls.RoundedCornerTextBox UsernameTextBox;
        private UserControls.RoundedCornerTextBox RePasswordTextbox;
        private UserControls.RoundedCornerButton SignUpButton;
        private UserControls.RoundedCornerButton CancelButton;
    }
}