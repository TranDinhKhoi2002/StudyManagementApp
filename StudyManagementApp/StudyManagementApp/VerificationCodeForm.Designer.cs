
namespace StudyManagementApp
{
    partial class VerificationCodeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerificationCodeForm));
            this.picbxLogo = new System.Windows.Forms.PictureBox();
            this.lbInstruction = new System.Windows.Forms.Label();
            this.txbCode = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.txbNewPassword = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.txbConfirmPassword = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.btnVerify = new StudyManagementApp.UserControls.RoundedCornerButton();
            ((System.ComponentModel.ISupportInitialize)(this.picbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picbxLogo
            // 
            this.picbxLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picbxLogo.ErrorImage")));
            this.picbxLogo.ImageLocation = "C:\\Users\\admin\\Documents\\Github\\StudyManagementApp\\StudyManagementApp\\StudyManage" +
    "mentApp\\Resources\\Images\\Logo.png";
            this.picbxLogo.Location = new System.Drawing.Point(159, 12);
            this.picbxLogo.Name = "picbxLogo";
            this.picbxLogo.Size = new System.Drawing.Size(100, 100);
            this.picbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxLogo.TabIndex = 7;
            this.picbxLogo.TabStop = false;
            // 
            // lbInstruction
            // 
            this.lbInstruction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lbInstruction.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstruction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lbInstruction.Location = new System.Drawing.Point(81, 129);
            this.lbInstruction.Name = "lbInstruction";
            this.lbInstruction.Size = new System.Drawing.Size(261, 33);
            this.lbInstruction.TabIndex = 10;
            this.lbInstruction.Text = "Fill in the verification code below";
            this.lbInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbCode
            // 
            this.txbCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.txbCode.BorderColor = System.Drawing.Color.Gray;
            this.txbCode.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txbCode.BorderRadius = 10;
            this.txbCode.BorderSize = 2;
            this.txbCode.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txbCode.Location = new System.Drawing.Point(95, 185);
            this.txbCode.Margin = new System.Windows.Forms.Padding(4);
            this.txbCode.Multiline = false;
            this.txbCode.Name = "txbCode";
            this.txbCode.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txbCode.PasswordChar = false;
            this.txbCode.PlaceholderColor = System.Drawing.Color.Gray;
            this.txbCode.PlaceholderText = "Verification Code";
            this.txbCode.Size = new System.Drawing.Size(233, 35);
            this.txbCode.TabIndex = 11;
            this.txbCode.Texts = "";
            this.txbCode.UnderlinedStyle = false;
            // 
            // txbNewPassword
            // 
            this.txbNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.txbNewPassword.BorderColor = System.Drawing.Color.Gray;
            this.txbNewPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txbNewPassword.BorderRadius = 10;
            this.txbNewPassword.BorderSize = 2;
            this.txbNewPassword.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txbNewPassword.Location = new System.Drawing.Point(95, 238);
            this.txbNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txbNewPassword.Multiline = false;
            this.txbNewPassword.Name = "txbNewPassword";
            this.txbNewPassword.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txbNewPassword.PasswordChar = true;
            this.txbNewPassword.PlaceholderColor = System.Drawing.Color.Gray;
            this.txbNewPassword.PlaceholderText = "New Password";
            this.txbNewPassword.Size = new System.Drawing.Size(233, 35);
            this.txbNewPassword.TabIndex = 12;
            this.txbNewPassword.Texts = "";
            this.txbNewPassword.UnderlinedStyle = false;
            // 
            // txbConfirmPassword
            // 
            this.txbConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.txbConfirmPassword.BorderColor = System.Drawing.Color.Gray;
            this.txbConfirmPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txbConfirmPassword.BorderRadius = 10;
            this.txbConfirmPassword.BorderSize = 2;
            this.txbConfirmPassword.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txbConfirmPassword.Location = new System.Drawing.Point(95, 292);
            this.txbConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txbConfirmPassword.Multiline = false;
            this.txbConfirmPassword.Name = "txbConfirmPassword";
            this.txbConfirmPassword.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txbConfirmPassword.PasswordChar = true;
            this.txbConfirmPassword.PlaceholderColor = System.Drawing.Color.Gray;
            this.txbConfirmPassword.PlaceholderText = "Repeat Password";
            this.txbConfirmPassword.Size = new System.Drawing.Size(233, 35);
            this.txbConfirmPassword.TabIndex = 13;
            this.txbConfirmPassword.Texts = "";
            this.txbConfirmPassword.UnderlinedStyle = false;
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnVerify.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(73)))), ((int)(((byte)(18)))));
            this.btnVerify.BorderRadius = 18;
            this.btnVerify.BorderSize = 0;
            this.btnVerify.FlatAppearance.BorderSize = 0;
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerify.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnVerify.Location = new System.Drawing.Point(95, 348);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(233, 38);
            this.btnVerify.TabIndex = 14;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // VerificationCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(444, 417);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.txbConfirmPassword);
            this.Controls.Add(this.txbNewPassword);
            this.Controls.Add(this.txbCode);
            this.Controls.Add(this.lbInstruction);
            this.Controls.Add(this.picbxLogo);
            this.Name = "VerificationCodeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verification Code Form";
            ((System.ComponentModel.ISupportInitialize)(this.picbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picbxLogo;
        private System.Windows.Forms.Label lbInstruction;
        private UserControls.RoundedCornerTextBox txbCode;
        private UserControls.RoundedCornerTextBox txbNewPassword;
        private UserControls.RoundedCornerTextBox txbConfirmPassword;
        private UserControls.RoundedCornerButton btnVerify;
    }
}