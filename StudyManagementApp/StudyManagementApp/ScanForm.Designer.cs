
namespace StudyManagementApp
{
    partial class ScanForm
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
            this.ptbQR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbQR)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "SCAN US FOR MORE INFORMATION";
            // 
            // ptbQR
            // 
            this.ptbQR.Location = new System.Drawing.Point(92, 27);
            this.ptbQR.Name = "ptbQR";
            this.ptbQR.Size = new System.Drawing.Size(304, 270);
            this.ptbQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbQR.TabIndex = 0;
            this.ptbQR.TabStop = false;
            // 
            // ScanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbQR);
            this.MaximizeBox = false;
            this.Name = "ScanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScanForm";
            ((System.ComponentModel.ISupportInitialize)(this.ptbQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbQR;
        private System.Windows.Forms.Label label1;
    }
}