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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnSignup = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRepassword = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picbxLogo = new System.Windows.Forms.PictureBox();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.lbInstruction = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picbxLogo)).BeginInit();
            this.pnlInput.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.txtUsername.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.txtUsername.Location = new System.Drawing.Point(0, 0);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(288, 45);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "Username";
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(72)))), ((int)(((byte)(18)))));
            this.btnSignup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(72)))), ((int)(((byte)(18)))));
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnSignup.Location = new System.Drawing.Point(0, 20);
            this.btnSignup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(124, 57);
            this.btnSignup.TabIndex = 3;
            this.btnSignup.Text = "Sign-up";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.txtPassword.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.txtPassword.Location = new System.Drawing.Point(0, 74);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(288, 45);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Password";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtRepassword
            // 
            this.txtRepassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.txtRepassword.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(111)))), ((int)(((byte)(114)))));
            this.txtRepassword.Location = new System.Drawing.Point(0, 146);
            this.txtRepassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRepassword.Name = "txtRepassword";
            this.txtRepassword.Size = new System.Drawing.Size(288, 45);
            this.txtRepassword.TabIndex = 2;
            this.txtRepassword.Text = "Password";
            this.txtRepassword.UseSystemPasswordChar = true;
            this.txtRepassword.Enter += new System.EventHandler(this.txtRepassword_Enter);
            this.txtRepassword.Leave += new System.EventHandler(this.txtRepassword_Leave);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(81)))), ((int)(((byte)(82)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(81)))), ((int)(((byte)(82)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnCancel.Location = new System.Drawing.Point(165, 20);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 57);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // picbxLogo
            // 
            this.picbxLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picbxLogo.ErrorImage")));
            this.picbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picbxLogo.Image")));
            this.picbxLogo.ImageLocation = "C:\\Users\\admin\\Documents\\Github\\StudyManagementApp\\StudyManagementApp\\StudyManage" +
    "mentApp\\Resources\\Images\\Logo.png";
            this.picbxLogo.Location = new System.Drawing.Point(184, 45);
            this.picbxLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picbxLogo.Name = "picbxLogo";
            this.picbxLogo.Size = new System.Drawing.Size(150, 154);
            this.picbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxLogo.TabIndex = 6;
            this.picbxLogo.TabStop = false;
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.txtUsername);
            this.pnlInput.Controls.Add(this.txtPassword);
            this.pnlInput.Controls.Add(this.txtRepassword);
            this.pnlInput.Location = new System.Drawing.Point(116, 318);
            this.pnlInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(290, 195);
            this.pnlInput.TabIndex = 7;
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnCancel);
            this.pnlButton.Controls.Add(this.btnSignup);
            this.pnlButton.Location = new System.Drawing.Point(116, 537);
            this.pnlButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(290, 92);
            this.pnlButton.TabIndex = 8;
            // 
            // lbInstruction
            // 
            this.lbInstruction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lbInstruction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbInstruction.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstruction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lbInstruction.Location = new System.Drawing.Point(0, 0);
            this.lbInstruction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInstruction.Name = "lbInstruction";
            this.lbInstruction.Size = new System.Drawing.Size(336, 51);
            this.lbInstruction.TabIndex = 9;
            this.lbInstruction.Text = "Fill in the textboxes below";
            this.lbInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel3.Controls.Add(this.lbInstruction);
            this.panel3.Location = new System.Drawing.Point(94, 228);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(336, 51);
            this.panel3.TabIndex = 10;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(513, 663);
            this.Controls.Add(this.picbxLogo);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Signup_FormClosed);
            this.Load += new System.EventHandler(this.Signup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbxLogo)).EndInit();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRepassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox picbxLogo;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Label lbInstruction;
        private System.Windows.Forms.Panel panel3;
    }
}