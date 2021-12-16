
namespace StudyManagementApp
{
    partial class CustomMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title_label = new System.Windows.Forms.Label();
            this.close_iconButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.okay_btn = new StudyManagementApp.UserControls.RoundedCornerButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Content_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(381, 187);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.Title_label);
            this.panel1.Controls.Add(this.close_iconButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 40);
            this.panel1.TabIndex = 0;
            // 
            // Title_label
            // 
            this.Title_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title_label.Font = new System.Drawing.Font("Arial", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_label.ForeColor = System.Drawing.Color.DimGray;
            this.Title_label.Location = new System.Drawing.Point(0, 0);
            this.Title_label.Margin = new System.Windows.Forms.Padding(0);
            this.Title_label.Name = "Title_label";
            this.Title_label.Padding = new System.Windows.Forms.Padding(4, 5, 0, 0);
            this.Title_label.Size = new System.Drawing.Size(341, 40);
            this.Title_label.TabIndex = 3;
            this.Title_label.Text = "Title";
            // 
            // close_iconButton
            // 
            this.close_iconButton.BackColor = System.Drawing.Color.Transparent;
            this.close_iconButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.close_iconButton.FlatAppearance.BorderSize = 0;
            this.close_iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_iconButton.ForeColor = System.Drawing.Color.Black;
            this.close_iconButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.close_iconButton.IconColor = System.Drawing.Color.DimGray;
            this.close_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.close_iconButton.IconSize = 40;
            this.close_iconButton.Location = new System.Drawing.Point(341, 0);
            this.close_iconButton.Name = "close_iconButton";
            this.close_iconButton.Size = new System.Drawing.Size(40, 40);
            this.close_iconButton.TabIndex = 4;
            this.close_iconButton.UseVisualStyleBackColor = false;
            this.close_iconButton.Click += new System.EventHandler(this.close_iconButton_Click);
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 3);
            this.panel2.Controls.Add(this.okay_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 137);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 50);
            this.panel2.TabIndex = 1;
            // 
            // okay_btn
            // 
            this.okay_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.okay_btn.BackColor = System.Drawing.Color.IndianRed;
            this.okay_btn.BorderColor = System.Drawing.Color.Transparent;
            this.okay_btn.BorderRadius = 14;
            this.okay_btn.BorderSize = 0;
            this.okay_btn.FlatAppearance.BorderSize = 0;
            this.okay_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okay_btn.Font = new System.Drawing.Font("Agency FB", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okay_btn.ForeColor = System.Drawing.Color.White;
            this.okay_btn.Location = new System.Drawing.Point(124, 6);
            this.okay_btn.Margin = new System.Windows.Forms.Padding(25);
            this.okay_btn.Name = "okay_btn";
            this.okay_btn.Size = new System.Drawing.Size(132, 39);
            this.okay_btn.TabIndex = 14;
            this.okay_btn.Text = "Okay";
            this.okay_btn.UseVisualStyleBackColor = false;
            this.okay_btn.Click += new System.EventHandler(this.close_iconButton_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.Content_label);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(20, 45);
            this.panel3.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(341, 87);
            this.panel3.TabIndex = 2;
            // 
            // Content_label
            // 
            this.Content_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content_label.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Content_label.ForeColor = System.Drawing.Color.Black;
            this.Content_label.Location = new System.Drawing.Point(0, 0);
            this.Content_label.Margin = new System.Windows.Forms.Padding(0);
            this.Content_label.Name = "Content_label";
            this.Content_label.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.Content_label.Size = new System.Drawing.Size(341, 87);
            this.Content_label.TabIndex = 2;
            this.Content_label.Text = "Content";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.IndianRed;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(401, 207);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(401, 207);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomMessageBox";
            this.Load += new System.EventHandler(this.CustomMessageBox_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Content_label;
        private FontAwesome.Sharp.IconButton close_iconButton;
        private UserControls.RoundedCornerButton okay_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}