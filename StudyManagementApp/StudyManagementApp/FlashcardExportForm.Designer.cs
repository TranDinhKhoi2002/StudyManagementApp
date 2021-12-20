
namespace StudyManagementApp
{
    partial class FlashcardExportForm
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.ExportFCButton = new StudyManagementApp.UserControls.RoundedCornerButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DeckRadioButton = new System.Windows.Forms.RadioButton();
            this.FCRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbInstruction = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(454, 385);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ExportFCButton);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 269);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(454, 116);
            this.panel5.TabIndex = 14;
            // 
            // ExportFCButton
            // 
            this.ExportFCButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportFCButton.BackColor = System.Drawing.Color.Teal;
            this.ExportFCButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ExportFCButton.BorderRadius = 18;
            this.ExportFCButton.BorderSize = 0;
            this.ExportFCButton.FlatAppearance.BorderSize = 0;
            this.ExportFCButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportFCButton.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportFCButton.ForeColor = System.Drawing.Color.White;
            this.ExportFCButton.Location = new System.Drawing.Point(113, 35);
            this.ExportFCButton.Name = "ExportFCButton";
            this.ExportFCButton.Size = new System.Drawing.Size(229, 47);
            this.ExportFCButton.TabIndex = 15;
            this.ExportFCButton.Text = "EXPORT FLASHCARD";
            this.ExportFCButton.UseVisualStyleBackColor = false;
            this.ExportFCButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DeckRadioButton);
            this.panel4.Controls.Add(this.FCRadioButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 77);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel4.Size = new System.Drawing.Size(454, 192);
            this.panel4.TabIndex = 13;
            // 
            // DeckRadioButton
            // 
            this.DeckRadioButton.AutoSize = true;
            this.DeckRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeckRadioButton.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeckRadioButton.ForeColor = System.Drawing.Color.White;
            this.DeckRadioButton.Location = new System.Drawing.Point(10, 45);
            this.DeckRadioButton.Name = "DeckRadioButton";
            this.DeckRadioButton.Size = new System.Drawing.Size(434, 45);
            this.DeckRadioButton.TabIndex = 1;
            this.DeckRadioButton.TabStop = true;
            this.DeckRadioButton.Text = "ALL DECKS";
            this.DeckRadioButton.UseVisualStyleBackColor = true;
            // 
            // FCRadioButton
            // 
            this.FCRadioButton.AutoSize = true;
            this.FCRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.FCRadioButton.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FCRadioButton.ForeColor = System.Drawing.Color.White;
            this.FCRadioButton.Location = new System.Drawing.Point(10, 0);
            this.FCRadioButton.Name = "FCRadioButton";
            this.FCRadioButton.Size = new System.Drawing.Size(434, 45);
            this.FCRadioButton.TabIndex = 1;
            this.FCRadioButton.TabStop = true;
            this.FCRadioButton.Text = "ALL FLASHCARDS";
            this.FCRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbInstruction);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel1.Size = new System.Drawing.Size(454, 77);
            this.panel1.TabIndex = 15;
            // 
            // lbInstruction
            // 
            this.lbInstruction.BackColor = System.Drawing.Color.Teal;
            this.lbInstruction.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbInstruction.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstruction.ForeColor = System.Drawing.Color.White;
            this.lbInstruction.Location = new System.Drawing.Point(10, 0);
            this.lbInstruction.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lbInstruction.Name = "lbInstruction";
            this.lbInstruction.Size = new System.Drawing.Size(434, 44);
            this.lbInstruction.TabIndex = 9;
            this.lbInstruction.Text = "CHOOSE WHAT TO EXPORT";
            this.lbInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 422F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(480, 391);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // FlashcardExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(480, 391);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FlashcardExportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private UserControls.RoundedCornerButton ExportFCButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton DeckRadioButton;
        private System.Windows.Forms.RadioButton FCRadioButton;
        private System.Windows.Forms.Label lbInstruction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
    }
}