
namespace StudyManagementApp.NoteFolder
{
    partial class Item_Note_Form
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
            this.mainbackground_panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.title_textBox = new System.Windows.Forms.TextBox();
            this.color_comboBox = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Noti_iconButton = new FontAwesome.Sharp.IconButton();
            this.close_iconButton = new FontAwesome.Sharp.IconButton();
            this.content_richTextBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.mainbackground_panel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.Controls.Add(this.mainbackground_panel, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(630, 272);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // mainbackground_panel
            // 
            this.mainbackground_panel.BackColor = System.Drawing.Color.Gray;
            this.mainbackground_panel.Controls.Add(this.tableLayoutPanel2);
            this.mainbackground_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainbackground_panel.Location = new System.Drawing.Point(12, 12);
            this.mainbackground_panel.Margin = new System.Windows.Forms.Padding(0);
            this.mainbackground_panel.Name = "mainbackground_panel";
            this.mainbackground_panel.Size = new System.Drawing.Size(606, 248);
            this.mainbackground_panel.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.content_richTextBox, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(606, 248);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.title_textBox);
            this.panel4.Controls.Add(this.color_comboBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(12, 205);
            this.panel4.Margin = new System.Windows.Forms.Padding(12, 17, 12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(582, 31);
            this.panel4.TabIndex = 2;
            // 
            // title_textBox
            // 
            this.title_textBox.BackColor = System.Drawing.Color.Gray;
            this.title_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title_textBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_textBox.ForeColor = System.Drawing.Color.LightGray;
            this.title_textBox.Location = new System.Drawing.Point(0, 0);
            this.title_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.title_textBox.Name = "title_textBox";
            this.title_textBox.Size = new System.Drawing.Size(520, 33);
            this.title_textBox.TabIndex = 0;
            this.title_textBox.Text = "Title";
            this.title_textBox.Leave += new System.EventHandler(this.title_textBox_Leave);
            // 
            // color_comboBox
            // 
            this.color_comboBox.BackColor = System.Drawing.Color.Silver;
            this.color_comboBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.color_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.color_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.color_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color_comboBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color_comboBox.FormattingEnabled = true;
            this.color_comboBox.Location = new System.Drawing.Point(520, 0);
            this.color_comboBox.Margin = new System.Windows.Forms.Padding(4);
            this.color_comboBox.Name = "color_comboBox";
            this.color_comboBox.Size = new System.Drawing.Size(62, 34);
            this.color_comboBox.TabIndex = 1;
            this.color_comboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.color_comboBox_DrawItem);
            this.color_comboBox.SelectedIndexChanged += new System.EventHandler(this.color_comboBox_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Noti_iconButton);
            this.panel3.Controls.Add(this.close_iconButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(606, 36);
            this.panel3.TabIndex = 1;
            // 
            // Noti_iconButton
            // 
            this.Noti_iconButton.BackColor = System.Drawing.Color.Transparent;
            this.Noti_iconButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Noti_iconButton.FlatAppearance.BorderSize = 0;
            this.Noti_iconButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Noti_iconButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Noti_iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Noti_iconButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Noti_iconButton.ForeColor = System.Drawing.Color.LightGray;
            this.Noti_iconButton.IconChar = FontAwesome.Sharp.IconChar.History;
            this.Noti_iconButton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.Noti_iconButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Noti_iconButton.IconSize = 17;
            this.Noti_iconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Noti_iconButton.Location = new System.Drawing.Point(0, 0);
            this.Noti_iconButton.Margin = new System.Windows.Forms.Padding(0);
            this.Noti_iconButton.Name = "Noti_iconButton";
            this.Noti_iconButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Noti_iconButton.Size = new System.Drawing.Size(569, 36);
            this.Noti_iconButton.TabIndex = 5;
            this.Noti_iconButton.Text = "time";
            this.Noti_iconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Noti_iconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Noti_iconButton.UseVisualStyleBackColor = false;
            // 
            // close_iconButton
            // 
            this.close_iconButton.BackColor = System.Drawing.Color.Transparent;
            this.close_iconButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.close_iconButton.FlatAppearance.BorderSize = 0;
            this.close_iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_iconButton.ForeColor = System.Drawing.Color.Black;
            this.close_iconButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.close_iconButton.IconColor = System.Drawing.Color.LightGray;
            this.close_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.close_iconButton.IconSize = 30;
            this.close_iconButton.Location = new System.Drawing.Point(569, 0);
            this.close_iconButton.Margin = new System.Windows.Forms.Padding(4);
            this.close_iconButton.Name = "close_iconButton";
            this.close_iconButton.Size = new System.Drawing.Size(37, 36);
            this.close_iconButton.TabIndex = 1;
            this.close_iconButton.UseVisualStyleBackColor = false;
            this.close_iconButton.Click += new System.EventHandler(this.close_iconButton_Click);
            // 
            // content_richTextBox
            // 
            this.content_richTextBox.BackColor = System.Drawing.Color.Silver;
            this.content_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.content_richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content_richTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.content_richTextBox.Location = new System.Drawing.Point(12, 36);
            this.content_richTextBox.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.content_richTextBox.Name = "content_richTextBox";
            this.content_richTextBox.Size = new System.Drawing.Size(582, 152);
            this.content_richTextBox.TabIndex = 3;
            this.content_richTextBox.Text = "";
            this.content_richTextBox.TextChanged += new System.EventHandler(this.content_richTextBox_TextChanged);
            this.content_richTextBox.Leave += new System.EventHandler(this.content_richTextBox_Leave);
            // 
            // Item_Note_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(630, 272);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Item_Note_Form";
            this.Text = "Item_Note_Form";
            this.Load += new System.EventHandler(this.Item_Note_Form_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.mainbackground_panel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel mainbackground_panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox title_textBox;
        private FontAwesome.Sharp.IconButton close_iconButton;
        private System.Windows.Forms.RichTextBox content_richTextBox;
        private System.Windows.Forms.ComboBox color_comboBox;
        private FontAwesome.Sharp.IconButton Noti_iconButton;
    }
}