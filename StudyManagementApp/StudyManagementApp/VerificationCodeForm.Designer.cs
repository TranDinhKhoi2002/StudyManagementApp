
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
            this.lbInstruction = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbConfirmPassword = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.txbNewPassword = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.txbCode = new StudyManagementApp.UserControls.RoundedCornerTextBox();
            this.btnVerify = new StudyManagementApp.UserControls.RoundedCornerButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbInstruction
            // 
            this.lbInstruction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInstruction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lbInstruction.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstruction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lbInstruction.Location = new System.Drawing.Point(10, 12);
            this.lbInstruction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInstruction.Name = "lbInstruction";
            this.lbInstruction.Size = new System.Drawing.Size(404, 44);
            this.lbInstruction.TabIndex = 10;
            this.lbInstruction.Text = "Fill in the verification code below";
            this.lbInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0005F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0005F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.00049F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9985F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(504, 422);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbConfirmPassword);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(40, 244);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(424, 68);
            this.panel3.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbNewPassword);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(40, 176);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 68);
            this.panel2.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbCode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(40, 108);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 68);
            this.panel1.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbInstruction);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(40, 40);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(424, 68);
            this.panel4.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnVerify);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(40, 312);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(424, 68);
            this.panel5.TabIndex = 21;
            // 
            // txbConfirmPassword
            // 
            this.txbConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.txbConfirmPassword.BorderColor = System.Drawing.Color.Gray;
            this.txbConfirmPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txbConfirmPassword.BorderRadius = 10;
            this.txbConfirmPassword.BorderSize = 2;
            this.txbConfirmPassword.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txbConfirmPassword.Location = new System.Drawing.Point(48, 13);
            this.txbConfirmPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txbConfirmPassword.Multiline = false;
            this.txbConfirmPassword.Name = "txbConfirmPassword";
            this.txbConfirmPassword.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.txbConfirmPassword.PasswordChar = true;
            this.txbConfirmPassword.PlaceholderColor = System.Drawing.Color.Gray;
            this.txbConfirmPassword.PlaceholderText = "Repeat Password";
            this.txbConfirmPassword.Size = new System.Drawing.Size(311, 42);
            this.txbConfirmPassword.TabIndex = 13;
            this.txbConfirmPassword.Texts = "";
            this.txbConfirmPassword.UnderlinedStyle = false;
            // 
            // txbNewPassword
            // 
            this.txbNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.txbNewPassword.BorderColor = System.Drawing.Color.Gray;
            this.txbNewPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txbNewPassword.BorderRadius = 10;
            this.txbNewPassword.BorderSize = 2;
            this.txbNewPassword.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txbNewPassword.Location = new System.Drawing.Point(48, 13);
            this.txbNewPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txbNewPassword.Multiline = false;
            this.txbNewPassword.Name = "txbNewPassword";
            this.txbNewPassword.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.txbNewPassword.PasswordChar = true;
            this.txbNewPassword.PlaceholderColor = System.Drawing.Color.Gray;
            this.txbNewPassword.PlaceholderText = "New Password";
            this.txbNewPassword.Size = new System.Drawing.Size(311, 42);
            this.txbNewPassword.TabIndex = 12;
            this.txbNewPassword.Texts = "";
            this.txbNewPassword.UnderlinedStyle = false;
            // 
            // txbCode
            // 
            this.txbCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.txbCode.BorderColor = System.Drawing.Color.Gray;
            this.txbCode.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txbCode.BorderRadius = 10;
            this.txbCode.BorderSize = 2;
            this.txbCode.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txbCode.Location = new System.Drawing.Point(48, 13);
            this.txbCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txbCode.Multiline = false;
            this.txbCode.Name = "txbCode";
            this.txbCode.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.txbCode.PasswordChar = false;
            this.txbCode.PlaceholderColor = System.Drawing.Color.Gray;
            this.txbCode.PlaceholderText = "Verification Code";
            this.txbCode.Size = new System.Drawing.Size(311, 42);
            this.txbCode.TabIndex = 11;
            this.txbCode.Texts = "";
            this.txbCode.UnderlinedStyle = false;
            // 
            // btnVerify
            // 
            this.btnVerify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerify.BackColor = System.Drawing.Color.ForestGreen;
            this.btnVerify.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(73)))), ((int)(((byte)(18)))));
            this.btnVerify.BorderRadius = 18;
            this.btnVerify.BorderSize = 0;
            this.btnVerify.FlatAppearance.BorderSize = 0;
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerify.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnVerify.Location = new System.Drawing.Point(48, 11);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(311, 47);
            this.btnVerify.TabIndex = 14;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // VerificationCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(504, 422);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VerificationCodeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verification Code Form";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbInstruction;
        private UserControls.RoundedCornerTextBox txbCode;
        private UserControls.RoundedCornerTextBox txbNewPassword;
        private UserControls.RoundedCornerTextBox txbConfirmPassword;
        private UserControls.RoundedCornerButton btnVerify;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}