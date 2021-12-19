
namespace StudyManagementApp.NoteFolder
{
    partial class Note_Form
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.main_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.add_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AddNote_iconButton = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.main_flowLayoutPanel.SuspendLayout();
            this.add_tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.Controls.Add(this.main_flowLayoutPanel, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1296, 605);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // main_flowLayoutPanel
            // 
            this.main_flowLayoutPanel.AutoScroll = true;
            this.main_flowLayoutPanel.Controls.Add(this.add_tableLayoutPanel);
            this.main_flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_flowLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.main_flowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.main_flowLayoutPanel.Name = "main_flowLayoutPanel";
            this.main_flowLayoutPanel.Size = new System.Drawing.Size(1272, 581);
            this.main_flowLayoutPanel.TabIndex = 0;
            // 
            // add_tableLayoutPanel
            // 
            this.add_tableLayoutPanel.ColumnCount = 3;
            this.add_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.add_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.add_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.add_tableLayoutPanel.Controls.Add(this.AddNote_iconButton, 1, 1);
            this.add_tableLayoutPanel.Location = new System.Drawing.Point(4, 4);
            this.add_tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add_tableLayoutPanel.Name = "add_tableLayoutPanel";
            this.add_tableLayoutPanel.RowCount = 3;
            this.add_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.add_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.add_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.add_tableLayoutPanel.Size = new System.Drawing.Size(630, 272);
            this.add_tableLayoutPanel.TabIndex = 1;
            // 
            // AddNote_iconButton
            // 
            this.AddNote_iconButton.BackColor = System.Drawing.Color.Silver;
            this.AddNote_iconButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddNote_iconButton.FlatAppearance.BorderSize = 0;
            this.AddNote_iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNote_iconButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.AddNote_iconButton.IconColor = System.Drawing.Color.DimGray;
            this.AddNote_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddNote_iconButton.IconSize = 55;
            this.AddNote_iconButton.Location = new System.Drawing.Point(12, 12);
            this.AddNote_iconButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddNote_iconButton.Name = "AddNote_iconButton";
            this.AddNote_iconButton.Size = new System.Drawing.Size(606, 248);
            this.AddNote_iconButton.TabIndex = 0;
            this.AddNote_iconButton.UseVisualStyleBackColor = false;
            this.AddNote_iconButton.Click += new System.EventHandler(this.AddNote_iconButton_Click);
            // 
            // Note_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1296, 605);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Note_Form";
            this.Text = "Note_Form";
            this.Load += new System.EventHandler(this.Note_Form_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Note_Form_Paint);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.main_flowLayoutPanel.ResumeLayout(false);
            this.add_tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel main_flowLayoutPanel;
        private FontAwesome.Sharp.IconButton AddNote_iconButton;
        private System.Windows.Forms.TableLayoutPanel add_tableLayoutPanel;
    }
}