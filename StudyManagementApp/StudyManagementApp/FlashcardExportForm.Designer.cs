
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
            this.FCRadioButton = new System.Windows.Forms.RadioButton();
            this.DeckRadioButton = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbInstruction = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbInstruction, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(604, 507);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ExportFCButton);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 338);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(604, 169);
            this.panel5.TabIndex = 14;
            // 
            // ExportFCButton
            // 
            this.ExportFCButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportFCButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ExportFCButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ExportFCButton.BorderRadius = 18;
            this.ExportFCButton.BorderSize = 0;
            this.ExportFCButton.FlatAppearance.BorderSize = 0;
            this.ExportFCButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportFCButton.Font = new System.Drawing.Font("Agency FB", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportFCButton.ForeColor = System.Drawing.Color.Green;
            this.ExportFCButton.Location = new System.Drawing.Point(128, 62);
            this.ExportFCButton.Name = "ExportFCButton";
            this.ExportFCButton.Size = new System.Drawing.Size(336, 64);
            this.ExportFCButton.TabIndex = 15;
            this.ExportFCButton.Text = "EXPORT FLASHCARD";
            this.ExportFCButton.UseVisualStyleBackColor = false;
            this.ExportFCButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // FCRadioButton
            // 
            this.FCRadioButton.AutoSize = true;
            this.FCRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FCRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FCRadioButton.Location = new System.Drawing.Point(164, 89);
            this.FCRadioButton.Name = "FCRadioButton";
            this.FCRadioButton.Size = new System.Drawing.Size(287, 36);
            this.FCRadioButton.TabIndex = 1;
            this.FCRadioButton.TabStop = true;
            this.FCRadioButton.Text = "ALL FLASHCARDS";
            this.FCRadioButton.UseVisualStyleBackColor = true;
            // 
            // DeckRadioButton
            // 
            this.DeckRadioButton.AutoSize = true;
            this.DeckRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeckRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DeckRadioButton.Location = new System.Drawing.Point(164, 25);
            this.DeckRadioButton.Name = "DeckRadioButton";
            this.DeckRadioButton.Size = new System.Drawing.Size(195, 36);
            this.DeckRadioButton.TabIndex = 1;
            this.DeckRadioButton.TabStop = true;
            this.DeckRadioButton.Text = "ALL DECKS";
            this.DeckRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DeckRadioButton);
            this.panel4.Controls.Add(this.FCRadioButton);
            this.panel4.Location = new System.Drawing.Point(0, 169);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(604, 148);
            this.panel4.TabIndex = 13;
            // 
            // lbInstruction
            // 
            this.lbInstruction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInstruction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lbInstruction.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstruction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.lbInstruction.Location = new System.Drawing.Point(0, 53);
            this.lbInstruction.Margin = new System.Windows.Forms.Padding(0);
            this.lbInstruction.Name = "lbInstruction";
            this.lbInstruction.Size = new System.Drawing.Size(604, 62);
            this.lbInstruction.TabIndex = 9;
            this.lbInstruction.Text = "CHOOSE WHAT TO EXPORT";
            this.lbInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FlashcardExportForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(604, 507);
            this.Controls.Add(this.tableLayoutPanel1);
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
    }
}