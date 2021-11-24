
namespace StudyManagementApp
{
    partial class ForgetPasswordForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.txbUserName = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.txbEmail = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.btnReset = new StudyManagementApp.UserControls.RoundedCornerButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(104, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "RESET PASSWORD";
            // 
            // txbUserName
            // 
            this.txbUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.txbUserName.BorderColor = System.Drawing.Color.Gray;
            this.txbUserName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txbUserName.BorderRadius = 10;
            this.txbUserName.BorderSize = 2;
            this.txbUserName.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txbUserName.Location = new System.Drawing.Point(67, 84);
            this.txbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txbUserName.Multiline = false;
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txbUserName.PasswordChar = false;
            this.txbUserName.PlaceholderColor = System.Drawing.Color.Gray;
            this.txbUserName.PlaceholderText = "User Name";
            this.txbUserName.Size = new System.Drawing.Size(233, 35);
            this.txbUserName.TabIndex = 12;
            this.txbUserName.Texts = "";
            this.txbUserName.UnderlinedStyle = false;
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.txbEmail.BorderColor = System.Drawing.Color.Gray;
            this.txbEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txbEmail.BorderRadius = 10;
            this.txbEmail.BorderSize = 2;
            this.txbEmail.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txbEmail.Location = new System.Drawing.Point(67, 141);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txbEmail.Multiline = false;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txbEmail.PasswordChar = false;
            this.txbEmail.PlaceholderColor = System.Drawing.Color.Gray;
            this.txbEmail.PlaceholderText = "Your Email";
            this.txbEmail.Size = new System.Drawing.Size(233, 35);
            this.txbEmail.TabIndex = 13;
            this.txbEmail.Texts = "";
            this.txbEmail.UnderlinedStyle = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(158)))), ((int)(((byte)(253)))));
            this.btnReset.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(73)))), ((int)(((byte)(18)))));
            this.btnReset.BorderRadius = 18;
            this.btnReset.BorderSize = 0;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnReset.Location = new System.Drawing.Point(67, 210);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(233, 38);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ForgetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(378, 283);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.label3);
            this.Name = "ForgetPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private UserControls.RoundedCornerTextBox txbUserName;
        private UserControls.RoundedCornerTextBox txbEmail;
        private UserControls.RoundedCornerButton btnReset;
    }
}