
namespace StudyManagementApp
{
    partial class SettingPomodoro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numLongBreak = new System.Windows.Forms.NumericUpDown();
            this.numShortBreak = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numPomodoro = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numNotification1 = new System.Windows.Forms.NumericUpDown();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.cbbNotification = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOK = new StudyManagementApp.UserControls.RoundedCornerButton();
            this.btnApply = new StudyManagementApp.UserControls.RoundedCornerButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLongBreak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShortBreak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPomodoro)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNotification1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::StudyManagementApp.Properties.Resources.TomatoRed;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(213, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 263);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Mistral", 28F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(37, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "POMODORO";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numLongBreak);
            this.panel2.Controls.Add(this.numShortBreak);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.numPomodoro);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(71, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 209);
            this.panel2.TabIndex = 1;
            // 
            // numLongBreak
            // 
            this.numLongBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLongBreak.Location = new System.Drawing.Point(447, 122);
            this.numLongBreak.Name = "numLongBreak";
            this.numLongBreak.Size = new System.Drawing.Size(145, 39);
            this.numLongBreak.TabIndex = 6;
            // 
            // numShortBreak
            // 
            this.numShortBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numShortBreak.Location = new System.Drawing.Point(248, 123);
            this.numShortBreak.Name = "numShortBreak";
            this.numShortBreak.Size = new System.Drawing.Size(148, 39);
            this.numShortBreak.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(441, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 41);
            this.label5.TabIndex = 4;
            this.label5.Text = "Long Break";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.label4.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label4.Location = new System.Drawing.Point(240, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 45);
            this.label4.TabIndex = 3;
            this.label4.Text = "Short Break";
            // 
            // numPomodoro
            // 
            this.numPomodoro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPomodoro.Location = new System.Drawing.Point(48, 122);
            this.numPomodoro.Name = "numPomodoro";
            this.numPomodoro.Size = new System.Drawing.Size(139, 39);
            this.numPomodoro.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(42, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pomodoro";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(210, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "Time(Minute): ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.numNotification1);
            this.panel3.Controls.Add(this.numInterval);
            this.panel3.Controls.Add(this.cbbNotification);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(71, 502);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(632, 124);
            this.panel3.TabIndex = 2;
            // 
            // numNotification1
            // 
            this.numNotification1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNotification1.Location = new System.Drawing.Point(493, 78);
            this.numNotification1.Name = "numNotification1";
            this.numNotification1.Size = new System.Drawing.Size(98, 39);
            this.numNotification1.TabIndex = 5;
            // 
            // numInterval
            // 
            this.numInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numInterval.Location = new System.Drawing.Point(50, 80);
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(96, 39);
            this.numInterval.TabIndex = 4;
            // 
            // cbbNotification
            // 
            this.cbbNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNotification.FormattingEnabled = true;
            this.cbbNotification.Items.AddRange(new object[] {
            "Last",
            "Every"});
            this.cbbNotification.Location = new System.Drawing.Point(342, 79);
            this.cbbNotification.Name = "cbbNotification";
            this.cbbNotification.Size = new System.Drawing.Size(115, 40);
            this.cbbNotification.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(316, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 45);
            this.label7.TabIndex = 2;
            this.label7.Text = "Notification:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(35, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 45);
            this.label6.TabIndex = 1;
            this.label6.Text = "Long Break Interval:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.DarkGray;
            this.btnOK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(73)))), ((int)(((byte)(18)))));
            this.btnOK.BorderRadius = 18;
            this.btnOK.BorderSize = 0;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnOK.Location = new System.Drawing.Point(413, 680);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(170, 58);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "CLOSE";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnApply.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(73)))), ((int)(((byte)(18)))));
            this.btnApply.BorderRadius = 18;
            this.btnApply.BorderSize = 0;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(200, 680);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(168, 58);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // SettingPomodoro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(767, 793);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SettingPomodoro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingPomodoro";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numLongBreak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShortBreak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPomodoro)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numNotification1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numLongBreak;
        private System.Windows.Forms.NumericUpDown numShortBreak;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numPomodoro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.ComboBox cbbNotification;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private UserControls.RoundedCornerButton btnOK;
        private System.Windows.Forms.NumericUpDown numNotification1;
        private UserControls.RoundedCornerButton btnApply;
    }
}