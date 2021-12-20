
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbInstruction = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TypesRadioButton = new System.Windows.Forms.RadioButton();
            this.TasksRadioButtion = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TodoExportButton = new StudyManagementApp.UserControls.RoundedCornerButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.lbInstruction);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(10, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel4.Size = new System.Drawing.Size(460, 78);
            this.panel4.TabIndex = 20;
            // 
            // lbInstruction
            // 
            this.lbInstruction.BackColor = System.Drawing.Color.SeaGreen;
            this.lbInstruction.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbInstruction.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstruction.ForeColor = System.Drawing.Color.White;
            this.lbInstruction.Location = new System.Drawing.Point(10, 0);
            this.lbInstruction.Margin = new System.Windows.Forms.Padding(0);
            this.lbInstruction.Name = "lbInstruction";
            this.lbInstruction.Size = new System.Drawing.Size(440, 44);
            this.lbInstruction.TabIndex = 10;
            this.lbInstruction.Text = "CHOOSE WHAT TO EXPORT";
            this.lbInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.TypesRadioButton);
            this.panel2.Controls.Add(this.TasksRadioButtion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 78);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel2.Size = new System.Drawing.Size(460, 195);
            this.panel2.TabIndex = 18;
            // 
            // TypesRadioButton
            // 
            this.TypesRadioButton.AutoSize = true;
            this.TypesRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.TypesRadioButton.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypesRadioButton.ForeColor = System.Drawing.Color.White;
            this.TypesRadioButton.Location = new System.Drawing.Point(10, 45);
            this.TypesRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.TypesRadioButton.Name = "TypesRadioButton";
            this.TypesRadioButton.Size = new System.Drawing.Size(440, 45);
            this.TypesRadioButton.TabIndex = 0;
            this.TypesRadioButton.TabStop = true;
            this.TypesRadioButton.Text = "ALL TYPES OF ITEMS";
            this.TypesRadioButton.UseVisualStyleBackColor = true;
            // 
            // TasksRadioButtion
            // 
            this.TasksRadioButtion.AutoSize = true;
            this.TasksRadioButtion.Dock = System.Windows.Forms.DockStyle.Top;
            this.TasksRadioButtion.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TasksRadioButtion.ForeColor = System.Drawing.Color.White;
            this.TasksRadioButtion.Location = new System.Drawing.Point(10, 0);
            this.TasksRadioButtion.Margin = new System.Windows.Forms.Padding(0);
            this.TasksRadioButtion.Name = "TasksRadioButtion";
            this.TasksRadioButtion.Size = new System.Drawing.Size(440, 45);
            this.TasksRadioButtion.TabIndex = 1;
            this.TasksRadioButtion.TabStop = true;
            this.TasksRadioButtion.Text = "ALL TASKS";
            this.TasksRadioButtion.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.TodoExportButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(10, 273);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(460, 118);
            this.panel3.TabIndex = 19;
            // 
            // TodoExportButton
            // 
            this.TodoExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TodoExportButton.BackColor = System.Drawing.Color.SeaGreen;
            this.TodoExportButton.BorderColor = System.Drawing.Color.SeaGreen;
            this.TodoExportButton.BorderRadius = 18;
            this.TodoExportButton.BorderSize = 0;
            this.TodoExportButton.FlatAppearance.BorderSize = 0;
            this.TodoExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TodoExportButton.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodoExportButton.ForeColor = System.Drawing.Color.White;
            this.TodoExportButton.Location = new System.Drawing.Point(131, 36);
            this.TodoExportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TodoExportButton.Name = "TodoExportButton";
            this.TodoExportButton.Size = new System.Drawing.Size(198, 47);
            this.TodoExportButton.TabIndex = 15;
            this.TodoExportButton.Text = "EXPORT TO-DO";
            this.TodoExportButton.UseVisualStyleBackColor = false;
            this.TodoExportButton.Click += new System.EventHandler(this.TodoExportButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(480, 391);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // TodoExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(480, 391);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TodoExportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPasswordForm";
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbInstruction;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton TypesRadioButton;
        private System.Windows.Forms.RadioButton TasksRadioButtion;
        private System.Windows.Forms.Panel panel3;
        private UserControls.RoundedCornerButton TodoExportButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}