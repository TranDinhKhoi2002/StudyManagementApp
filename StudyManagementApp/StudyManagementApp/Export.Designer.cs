
namespace StudyManagementApp
{
    partial class Export
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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.close_panel = new System.Windows.Forms.Panel();
            this.close_iconButton = new FontAwesome.Sharp.IconButton();
            this.panel14 = new System.Windows.Forms.Panel();
            this.TodoExportButton = new StudyManagementApp.UserControls.RoundedCornerButton();
            this.FlashcardExportButton = new StudyManagementApp.UserControls.RoundedCornerButton();
            this.NoteExportButton = new StudyManagementApp.UserControls.RoundedCornerButton();
            this.Title_panel = new System.Windows.Forms.Panel();
            this.Title_Label = new System.Windows.Forms.Label();
            this.main_panel = new System.Windows.Forms.Panel();
            this.PictureExcel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4.SuspendLayout();
            this.close_panel.SuspendLayout();
            this.panel14.SuspendLayout();
            this.Title_panel.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.73171F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.26829F));
            this.tableLayoutPanel4.Controls.Add(this.close_panel, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel14, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.Title_panel, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.main_panel, 1, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(726, 587);
            this.tableLayoutPanel4.TabIndex = 16;
            // 
            // close_panel
            // 
            this.close_panel.BackColor = System.Drawing.Color.DarkCyan;
            this.close_panel.Controls.Add(this.close_iconButton);
            this.close_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.close_panel.Location = new System.Drawing.Point(150, 0);
            this.close_panel.Margin = new System.Windows.Forms.Padding(0);
            this.close_panel.Name = "close_panel";
            this.close_panel.Size = new System.Drawing.Size(576, 48);
            this.close_panel.TabIndex = 2;
            // 
            // close_iconButton
            // 
            this.close_iconButton.BackColor = System.Drawing.Color.Transparent;
            this.close_iconButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.close_iconButton.FlatAppearance.BorderSize = 0;
            this.close_iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_iconButton.ForeColor = System.Drawing.Color.Black;
            this.close_iconButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.close_iconButton.IconColor = System.Drawing.Color.White;
            this.close_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.close_iconButton.IconSize = 40;
            this.close_iconButton.Location = new System.Drawing.Point(528, 0);
            this.close_iconButton.Margin = new System.Windows.Forms.Padding(4);
            this.close_iconButton.Name = "close_iconButton";
            this.close_iconButton.Size = new System.Drawing.Size(48, 48);
            this.close_iconButton.TabIndex = 1;
            this.close_iconButton.UseVisualStyleBackColor = false;
            this.close_iconButton.Click += new System.EventHandler(this.close_iconButton_Click);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Gainsboro;
            this.panel14.Controls.Add(this.TodoExportButton);
            this.panel14.Controls.Add(this.FlashcardExportButton);
            this.panel14.Controls.Add(this.NoteExportButton);
            this.panel14.Location = new System.Drawing.Point(0, 139);
            this.panel14.Margin = new System.Windows.Forms.Padding(0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(150, 448);
            this.panel14.TabIndex = 2;
            // 
            // TodoExportButton
            // 
            this.TodoExportButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TodoExportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(100)))));
            this.TodoExportButton.BorderColor = System.Drawing.Color.Transparent;
            this.TodoExportButton.BorderRadius = 14;
            this.TodoExportButton.BorderSize = 0;
            this.TodoExportButton.FlatAppearance.BorderSize = 0;
            this.TodoExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TodoExportButton.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodoExportButton.ForeColor = System.Drawing.Color.Green;
            this.TodoExportButton.Location = new System.Drawing.Point(0, 194);
            this.TodoExportButton.Margin = new System.Windows.Forms.Padding(30);
            this.TodoExportButton.Name = "TodoExportButton";
            this.TodoExportButton.Size = new System.Drawing.Size(150, 69);
            this.TodoExportButton.TabIndex = 14;
            this.TodoExportButton.Text = "TO-DO LIST";
            this.TodoExportButton.UseVisualStyleBackColor = false;
            this.TodoExportButton.Click += new System.EventHandler(this.TodoExportButton_Click);
            // 
            // FlashcardExportButton
            // 
            this.FlashcardExportButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FlashcardExportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FlashcardExportButton.BorderColor = System.Drawing.Color.Transparent;
            this.FlashcardExportButton.BorderRadius = 14;
            this.FlashcardExportButton.BorderSize = 0;
            this.FlashcardExportButton.FlatAppearance.BorderSize = 0;
            this.FlashcardExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlashcardExportButton.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlashcardExportButton.ForeColor = System.Drawing.Color.Green;
            this.FlashcardExportButton.Location = new System.Drawing.Point(0, 66);
            this.FlashcardExportButton.Margin = new System.Windows.Forms.Padding(30);
            this.FlashcardExportButton.Name = "FlashcardExportButton";
            this.FlashcardExportButton.Size = new System.Drawing.Size(150, 68);
            this.FlashcardExportButton.TabIndex = 14;
            this.FlashcardExportButton.Text = "FLASHCARD";
            this.FlashcardExportButton.UseVisualStyleBackColor = false;
            this.FlashcardExportButton.Click += new System.EventHandler(this.FlashcardExportButton_Click);
            // 
            // NoteExportButton
            // 
            this.NoteExportButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NoteExportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.NoteExportButton.BorderColor = System.Drawing.Color.Transparent;
            this.NoteExportButton.BorderRadius = 14;
            this.NoteExportButton.BorderSize = 0;
            this.NoteExportButton.FlatAppearance.BorderSize = 0;
            this.NoteExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoteExportButton.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteExportButton.ForeColor = System.Drawing.Color.Green;
            this.NoteExportButton.Location = new System.Drawing.Point(0, 323);
            this.NoteExportButton.Margin = new System.Windows.Forms.Padding(30);
            this.NoteExportButton.Name = "NoteExportButton";
            this.NoteExportButton.Size = new System.Drawing.Size(150, 65);
            this.NoteExportButton.TabIndex = 14;
            this.NoteExportButton.Text = "NOTE";
            this.NoteExportButton.UseVisualStyleBackColor = false;
            this.NoteExportButton.Click += new System.EventHandler(this.NoteExportButton_Click);
            // 
            // Title_panel
            // 
            this.Title_panel.BackColor = System.Drawing.Color.Transparent;
            this.Title_panel.Controls.Add(this.Title_Label);
            this.Title_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title_panel.Location = new System.Drawing.Point(150, 48);
            this.Title_panel.Margin = new System.Windows.Forms.Padding(0);
            this.Title_panel.Name = "Title_panel";
            this.Title_panel.Size = new System.Drawing.Size(576, 91);
            this.Title_panel.TabIndex = 0;
            // 
            // Title_Label
            // 
            this.Title_Label.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Title_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title_Label.Font = new System.Drawing.Font("Agency FB", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Label.ForeColor = System.Drawing.Color.Lime;
            this.Title_Label.Location = new System.Drawing.Point(0, 0);
            this.Title_Label.Margin = new System.Windows.Forms.Padding(0);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(576, 91);
            this.Title_Label.TabIndex = 1;
            this.Title_Label.Text = "EXPORT";
            this.Title_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.PictureExcel);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(150, 139);
            this.main_panel.Margin = new System.Windows.Forms.Padding(0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(576, 448);
            this.main_panel.TabIndex = 1;
            // 
            // PictureExcel
            // 
            this.PictureExcel.BackgroundImage = global::StudyManagementApp.Properties.Resources.ExcelIcon1;
            this.PictureExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureExcel.Location = new System.Drawing.Point(92, 54);
            this.PictureExcel.Name = "PictureExcel";
            this.PictureExcel.Size = new System.Drawing.Size(304, 325);
            this.PictureExcel.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(750, 611);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(750, 611);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Export";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Export_Load);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.close_panel.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.Title_panel.ResumeLayout(false);
            this.main_panel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel close_panel;
        private FontAwesome.Sharp.IconButton close_iconButton;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel Title_panel;
        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private UserControls.RoundedCornerButton TodoExportButton;
        private UserControls.RoundedCornerButton NoteExportButton;
        private UserControls.RoundedCornerButton FlashcardExportButton;
        private System.Windows.Forms.Panel PictureExcel;
    }
}