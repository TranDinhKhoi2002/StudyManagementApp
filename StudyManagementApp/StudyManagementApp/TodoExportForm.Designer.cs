
namespace StudyManagementApp
{
    partial class TodoExportForm
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
            this.TodoExportButton = new StudyManagementApp.UserControls.RoundedCornerButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbInstruction = new System.Windows.Forms.Label();
            this.TypesRadioButton = new System.Windows.Forms.RadioButton();
            this.TasksRadioButtion = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TodoExportButton
            // 
            this.TodoExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TodoExportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(100)))));
            this.TodoExportButton.BorderColor = System.Drawing.Color.SeaGreen;
            this.TodoExportButton.BorderRadius = 18;
            this.TodoExportButton.BorderSize = 0;
            this.TodoExportButton.FlatAppearance.BorderSize = 0;
            this.TodoExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TodoExportButton.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodoExportButton.ForeColor = System.Drawing.Color.Green;
            this.TodoExportButton.Location = new System.Drawing.Point(68, 23);
            this.TodoExportButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.TodoExportButton.Name = "TodoExportButton";
            this.TodoExportButton.Size = new System.Drawing.Size(441, 56);
            this.TodoExportButton.TabIndex = 15;
            this.TodoExportButton.Text = "EXPORT TO-DO";
            this.TodoExportButton.UseVisualStyleBackColor = false;
            this.TodoExportButton.Click += new System.EventHandler(this.TodoExportButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(605, 506);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TodoExportButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(10, 354);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(577, 102);
            this.panel3.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TypesRadioButton);
            this.panel2.Controls.Add(this.TasksRadioButtion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 252);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 102);
            this.panel2.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 150);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 102);
            this.panel1.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbInstruction);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(10, 48);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(577, 102);
            this.panel4.TabIndex = 20;
            // 
            // lbInstruction
            // 
            this.lbInstruction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInstruction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lbInstruction.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstruction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lbInstruction.Location = new System.Drawing.Point(12, 24);
            this.lbInstruction.Margin = new System.Windows.Forms.Padding(0);
            this.lbInstruction.Name = "lbInstruction";
            this.lbInstruction.Size = new System.Drawing.Size(553, 53);
            this.lbInstruction.TabIndex = 10;
            this.lbInstruction.Text = "CHOOSE WHAT TO EXPORT";
            this.lbInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TypesRadioButton
            // 
            this.TypesRadioButton.AutoSize = true;
            this.TypesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypesRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TypesRadioButton.Location = new System.Drawing.Point(18, 20);
            this.TypesRadioButton.Name = "TypesRadioButton";
            this.TypesRadioButton.Size = new System.Drawing.Size(329, 36);
            this.TypesRadioButton.TabIndex = 0;
            this.TypesRadioButton.TabStop = true;
            this.TypesRadioButton.Text = "ALL TYPES OF ITEMS";
            this.TypesRadioButton.UseVisualStyleBackColor = true;
            // 
            // TasksRadioButtion
            // 
            this.TasksRadioButtion.AutoSize = true;
            this.TasksRadioButtion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TasksRadioButtion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TasksRadioButtion.Location = new System.Drawing.Point(383, 20);
            this.TasksRadioButtion.Name = "TasksRadioButtion";
            this.TasksRadioButtion.Size = new System.Drawing.Size(191, 36);
            this.TasksRadioButtion.TabIndex = 1;
            this.TasksRadioButtion.TabStop = true;
            this.TasksRadioButtion.Text = "ALL TASKS";
            this.TasksRadioButtion.UseVisualStyleBackColor = true;
            // 
            // TodoExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(605, 506);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TodoExportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPasswordForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private UserControls.RoundedCornerButton TodoExportButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbInstruction;
        private System.Windows.Forms.RadioButton TasksRadioButtion;
        private System.Windows.Forms.RadioButton TypesRadioButton;
    }
}