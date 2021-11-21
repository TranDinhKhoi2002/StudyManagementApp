
namespace StudyManagementApp
{
    partial class AddTask
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
            this.Apply_btn = new System.Windows.Forms.Button();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.endtime_picker = new System.Windows.Forms.DateTimePicker();
            this.starttime_picker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_descip = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Apply_btn
            // 
            this.Apply_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apply_btn.Location = new System.Drawing.Point(48, 173);
            this.Apply_btn.Name = "Apply_btn";
            this.Apply_btn.Size = new System.Drawing.Size(97, 41);
            this.Apply_btn.TabIndex = 15;
            this.Apply_btn.Text = "Apply";
            this.Apply_btn.UseVisualStyleBackColor = true;
            this.Apply_btn.Click += new System.EventHandler(this.Apply_btn_Click);
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Btn.Location = new System.Drawing.Point(189, 173);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(97, 41);
            this.Cancel_Btn.TabIndex = 14;
            this.Cancel_Btn.Text = "Cancel";
            this.Cancel_Btn.UseVisualStyleBackColor = true;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            // endtime_picker
            // 
            this.endtime_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endtime_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endtime_picker.Location = new System.Drawing.Point(110, 125);
            this.endtime_picker.Name = "endtime_picker";
            this.endtime_picker.RightToLeftLayout = true;
            this.endtime_picker.ShowUpDown = true;
            this.endtime_picker.Size = new System.Drawing.Size(176, 27);
            this.endtime_picker.TabIndex = 13;
            this.endtime_picker.Value = new System.DateTime(2021, 11, 12, 0, 0, 0, 0);
            // 
            // starttime_picker
            // 
            this.starttime_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starttime_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.starttime_picker.Location = new System.Drawing.Point(110, 71);
            this.starttime_picker.Name = "starttime_picker";
            this.starttime_picker.RightToLeftLayout = true;
            this.starttime_picker.ShowUpDown = true;
            this.starttime_picker.Size = new System.Drawing.Size(176, 27);
            this.starttime_picker.TabIndex = 12;
            this.starttime_picker.Value = new System.DateTime(2021, 11, 12, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Time end";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Time start";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 9;
            this.label1.Tag = "";
            this.label1.Text = "Desciption";
            // 
            // tb_descip
            // 
            this.tb_descip.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_descip.Location = new System.Drawing.Point(110, 16);
            this.tb_descip.Name = "tb_descip";
            this.tb_descip.Size = new System.Drawing.Size(176, 27);
            this.tb_descip.TabIndex = 8;
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 234);
            this.Controls.Add(this.Apply_btn);
            this.Controls.Add(this.Cancel_Btn);
            this.Controls.Add(this.endtime_picker);
            this.Controls.Add(this.starttime_picker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_descip);
            this.Name = "AddTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTask";
            this.Load += new System.EventHandler(this.AddTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Apply_btn;
        private System.Windows.Forms.Button Cancel_Btn;
        private System.Windows.Forms.DateTimePicker endtime_picker;
        private System.Windows.Forms.DateTimePicker starttime_picker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_descip;
    }
}