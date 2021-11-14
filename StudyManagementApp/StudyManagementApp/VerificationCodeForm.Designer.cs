
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCode = new System.Windows.Forms.TextBox();
            this.txbNewPassword = new System.Windows.Forms.TextBox();
            this.txbConfirmPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verification code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "New password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm new password";
            // 
            // txbCode
            // 
            this.txbCode.Location = new System.Drawing.Point(230, 32);
            this.txbCode.Name = "txbCode";
            this.txbCode.Size = new System.Drawing.Size(202, 20);
            this.txbCode.TabIndex = 3;
            // 
            // txbNewPassword
            // 
            this.txbNewPassword.Location = new System.Drawing.Point(230, 73);
            this.txbNewPassword.Name = "txbNewPassword";
            this.txbNewPassword.Size = new System.Drawing.Size(202, 20);
            this.txbNewPassword.TabIndex = 4;
            this.txbNewPassword.UseSystemPasswordChar = true;
            // 
            // txbConfirmPassword
            // 
            this.txbConfirmPassword.Location = new System.Drawing.Point(230, 117);
            this.txbConfirmPassword.Name = "txbConfirmPassword";
            this.txbConfirmPassword.Size = new System.Drawing.Size(202, 20);
            this.txbConfirmPassword.TabIndex = 5;
            this.txbConfirmPassword.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Verify";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VerificationCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 222);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbConfirmPassword);
            this.Controls.Add(this.txbNewPassword);
            this.Controls.Add(this.txbCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VerificationCodeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerificationCodeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCode;
        private System.Windows.Forms.TextBox txbNewPassword;
        private System.Windows.Forms.TextBox txbConfirmPassword;
        private System.Windows.Forms.Button button1;
    }
}