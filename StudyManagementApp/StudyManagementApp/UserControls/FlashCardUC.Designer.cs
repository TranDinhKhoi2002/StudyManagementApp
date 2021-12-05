namespace StudyManagementApp.UserControls
{
    partial class FlashCardUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GlobalTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DisplayTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ControlTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.DeckComboBox = new System.Windows.Forms.ComboBox();
            this.FlashCardDisplayPanel = new System.Windows.Forms.Panel();
            this.WordPanel = new System.Windows.Forms.Panel();
            this.DefDesTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.WordLabel = new System.Windows.Forms.Label();
            this.DefinitionLabel = new System.Windows.Forms.Label();
            this.DescriptionPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DescriptionContentLabel = new System.Windows.Forms.Label();
            this.DeckMoreRcbtn = new StudyManagementApp.UserControls.RoundedCornerButton();
            this.FlipRcbtn = new StudyManagementApp.UserControls.RoundedCornerButton();
            this.RandomRcbtn = new StudyManagementApp.UserControls.RoundedCornerButton();
            this.NextRcbtn = new StudyManagementApp.UserControls.RoundedCornerButton();
            this.PreviousRcbtn = new StudyManagementApp.UserControls.RoundedCornerButton();
            this.FlashCardMoreRcbtn = new StudyManagementApp.UserControls.RoundedCornerButton();
            this.GlobalTableLayoutPanel.SuspendLayout();
            this.DisplayTableLayout.SuspendLayout();
            this.ControlTableLayout.SuspendLayout();
            this.FlashCardDisplayPanel.SuspendLayout();
            this.WordPanel.SuspendLayout();
            this.DefDesTableLayout.SuspendLayout();
            this.DescriptionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GlobalTableLayoutPanel
            // 
            this.GlobalTableLayoutPanel.ColumnCount = 1;
            this.GlobalTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalTableLayoutPanel.Controls.Add(this.ControlTableLayout, 0, 0);
            this.GlobalTableLayoutPanel.Controls.Add(this.DisplayTableLayout, 0, 1);
            this.GlobalTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.GlobalTableLayoutPanel.Name = "GlobalTableLayoutPanel";
            this.GlobalTableLayoutPanel.RowCount = 2;
            this.GlobalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.GlobalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.GlobalTableLayoutPanel.Size = new System.Drawing.Size(712, 403);
            this.GlobalTableLayoutPanel.TabIndex = 0;
            // 
            // DisplayTableLayout
            // 
            this.DisplayTableLayout.ColumnCount = 3;
            this.DisplayTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.DisplayTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DisplayTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.DisplayTableLayout.Controls.Add(this.FlashCardDisplayPanel, 1, 0);
            this.DisplayTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayTableLayout.Location = new System.Drawing.Point(3, 51);
            this.DisplayTableLayout.Name = "DisplayTableLayout";
            this.DisplayTableLayout.RowCount = 1;
            this.DisplayTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DisplayTableLayout.Size = new System.Drawing.Size(706, 349);
            this.DisplayTableLayout.TabIndex = 0;
            // 
            // ControlTableLayout
            // 
            this.ControlTableLayout.ColumnCount = 7;
            this.ControlTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.331665F));
            this.ControlTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.005F));
            this.ControlTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.331665F));
            this.ControlTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.331665F));
            this.ControlTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.331665F));
            this.ControlTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.331665F));
            this.ControlTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33667F));
            this.ControlTableLayout.Controls.Add(this.DeckMoreRcbtn, 0, 0);
            this.ControlTableLayout.Controls.Add(this.FlipRcbtn, 6, 0);
            this.ControlTableLayout.Controls.Add(this.RandomRcbtn, 5, 0);
            this.ControlTableLayout.Controls.Add(this.NextRcbtn, 4, 0);
            this.ControlTableLayout.Controls.Add(this.PreviousRcbtn, 3, 0);
            this.ControlTableLayout.Controls.Add(this.FlashCardMoreRcbtn, 2, 0);
            this.ControlTableLayout.Controls.Add(this.DeckComboBox, 1, 0);
            this.ControlTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlTableLayout.Location = new System.Drawing.Point(3, 3);
            this.ControlTableLayout.Name = "ControlTableLayout";
            this.ControlTableLayout.RowCount = 1;
            this.ControlTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ControlTableLayout.Size = new System.Drawing.Size(706, 42);
            this.ControlTableLayout.TabIndex = 1;
            // 
            // DeckComboBox
            // 
            this.DeckComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DeckComboBox.FormattingEnabled = true;
            this.DeckComboBox.Location = new System.Drawing.Point(63, 10);
            this.DeckComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.DeckComboBox.Name = "DeckComboBox";
            this.DeckComboBox.Size = new System.Drawing.Size(166, 21);
            this.DeckComboBox.TabIndex = 6;
            // 
            // FlashCardDisplayPanel
            // 
            this.FlashCardDisplayPanel.Controls.Add(this.DefDesTableLayout);
            this.FlashCardDisplayPanel.Controls.Add(this.WordPanel);
            this.FlashCardDisplayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlashCardDisplayPanel.Location = new System.Drawing.Point(3, 3);
            this.FlashCardDisplayPanel.Name = "FlashCardDisplayPanel";
            this.FlashCardDisplayPanel.Size = new System.Drawing.Size(700, 343);
            this.FlashCardDisplayPanel.TabIndex = 0;
            // 
            // WordPanel
            // 
            this.WordPanel.Controls.Add(this.WordLabel);
            this.WordPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WordPanel.Location = new System.Drawing.Point(0, 0);
            this.WordPanel.Name = "WordPanel";
            this.WordPanel.Size = new System.Drawing.Size(700, 343);
            this.WordPanel.TabIndex = 0;
            // 
            // DefDesTableLayout
            // 
            this.DefDesTableLayout.ColumnCount = 1;
            this.DefDesTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DefDesTableLayout.Controls.Add(this.DefinitionLabel, 0, 0);
            this.DefDesTableLayout.Controls.Add(this.DescriptionPanel, 0, 1);
            this.DefDesTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DefDesTableLayout.Location = new System.Drawing.Point(0, 0);
            this.DefDesTableLayout.Name = "DefDesTableLayout";
            this.DefDesTableLayout.RowCount = 2;
            this.DefDesTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DefDesTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DefDesTableLayout.Size = new System.Drawing.Size(700, 343);
            this.DefDesTableLayout.TabIndex = 1;
            // 
            // WordLabel
            // 
            this.WordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WordLabel.Location = new System.Drawing.Point(0, 0);
            this.WordLabel.Name = "WordLabel";
            this.WordLabel.Size = new System.Drawing.Size(700, 343);
            this.WordLabel.TabIndex = 0;
            this.WordLabel.Text = "[Word]";
            this.WordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DefinitionLabel
            // 
            this.DefinitionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DefinitionLabel.Location = new System.Drawing.Point(3, 0);
            this.DefinitionLabel.Name = "DefinitionLabel";
            this.DefinitionLabel.Size = new System.Drawing.Size(694, 171);
            this.DefinitionLabel.TabIndex = 1;
            this.DefinitionLabel.Text = "[Definition]";
            this.DefinitionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DescriptionPanel
            // 
            this.DescriptionPanel.Controls.Add(this.DescriptionContentLabel);
            this.DescriptionPanel.Controls.Add(this.label1);
            this.DescriptionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionPanel.Location = new System.Drawing.Point(3, 174);
            this.DescriptionPanel.Name = "DescriptionPanel";
            this.DescriptionPanel.Size = new System.Drawing.Size(694, 166);
            this.DescriptionPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DescriptionContentLabel
            // 
            this.DescriptionContentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionContentLabel.Location = new System.Drawing.Point(0, 13);
            this.DescriptionContentLabel.Name = "DescriptionContentLabel";
            this.DescriptionContentLabel.Size = new System.Drawing.Size(694, 153);
            this.DescriptionContentLabel.TabIndex = 1;
            this.DescriptionContentLabel.Text = "[Description]";
            // 
            // DeckMoreRcbtn
            // 
            this.DeckMoreRcbtn.BackColor = System.Drawing.Color.DarkGray;
            this.DeckMoreRcbtn.BorderColor = System.Drawing.Color.LightGray;
            this.DeckMoreRcbtn.BorderRadius = 10;
            this.DeckMoreRcbtn.BorderSize = 0;
            this.DeckMoreRcbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeckMoreRcbtn.FlatAppearance.BorderSize = 0;
            this.DeckMoreRcbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeckMoreRcbtn.Location = new System.Drawing.Point(5, 5);
            this.DeckMoreRcbtn.Margin = new System.Windows.Forms.Padding(5);
            this.DeckMoreRcbtn.Name = "DeckMoreRcbtn";
            this.DeckMoreRcbtn.Size = new System.Drawing.Size(48, 32);
            this.DeckMoreRcbtn.TabIndex = 5;
            this.DeckMoreRcbtn.Text = "More";
            this.DeckMoreRcbtn.UseVisualStyleBackColor = false;
            // 
            // FlipRcbtn
            // 
            this.FlipRcbtn.BackColor = System.Drawing.Color.DarkGray;
            this.FlipRcbtn.BorderColor = System.Drawing.Color.LightGray;
            this.FlipRcbtn.BorderRadius = 10;
            this.FlipRcbtn.BorderSize = 0;
            this.FlipRcbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlipRcbtn.FlatAppearance.BorderSize = 0;
            this.FlipRcbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlipRcbtn.Location = new System.Drawing.Point(471, 5);
            this.FlipRcbtn.Margin = new System.Windows.Forms.Padding(5);
            this.FlipRcbtn.Name = "FlipRcbtn";
            this.FlipRcbtn.Size = new System.Drawing.Size(230, 32);
            this.FlipRcbtn.TabIndex = 0;
            this.FlipRcbtn.Text = "Flip";
            this.FlipRcbtn.UseVisualStyleBackColor = false;
            this.FlipRcbtn.Click += new System.EventHandler(this.FlipRcbtn_Click);
            // 
            // RandomRcbtn
            // 
            this.RandomRcbtn.BackColor = System.Drawing.Color.DarkGray;
            this.RandomRcbtn.BorderColor = System.Drawing.Color.LightGray;
            this.RandomRcbtn.BorderRadius = 10;
            this.RandomRcbtn.BorderSize = 0;
            this.RandomRcbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RandomRcbtn.FlatAppearance.BorderSize = 0;
            this.RandomRcbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomRcbtn.Location = new System.Drawing.Point(413, 5);
            this.RandomRcbtn.Margin = new System.Windows.Forms.Padding(5);
            this.RandomRcbtn.Name = "RandomRcbtn";
            this.RandomRcbtn.Size = new System.Drawing.Size(48, 32);
            this.RandomRcbtn.TabIndex = 1;
            this.RandomRcbtn.Text = "?";
            this.RandomRcbtn.UseVisualStyleBackColor = false;
            // 
            // NextRcbtn
            // 
            this.NextRcbtn.BackColor = System.Drawing.Color.DarkGray;
            this.NextRcbtn.BorderColor = System.Drawing.Color.LightGray;
            this.NextRcbtn.BorderRadius = 10;
            this.NextRcbtn.BorderSize = 0;
            this.NextRcbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NextRcbtn.FlatAppearance.BorderSize = 0;
            this.NextRcbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextRcbtn.Location = new System.Drawing.Point(355, 5);
            this.NextRcbtn.Margin = new System.Windows.Forms.Padding(5);
            this.NextRcbtn.Name = "NextRcbtn";
            this.NextRcbtn.Size = new System.Drawing.Size(48, 32);
            this.NextRcbtn.TabIndex = 2;
            this.NextRcbtn.Text = ">";
            this.NextRcbtn.UseVisualStyleBackColor = false;
            // 
            // PreviousRcbtn
            // 
            this.PreviousRcbtn.BackColor = System.Drawing.Color.DarkGray;
            this.PreviousRcbtn.BorderColor = System.Drawing.Color.LightGray;
            this.PreviousRcbtn.BorderRadius = 10;
            this.PreviousRcbtn.BorderSize = 0;
            this.PreviousRcbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviousRcbtn.FlatAppearance.BorderSize = 0;
            this.PreviousRcbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousRcbtn.Location = new System.Drawing.Point(297, 5);
            this.PreviousRcbtn.Margin = new System.Windows.Forms.Padding(5);
            this.PreviousRcbtn.Name = "PreviousRcbtn";
            this.PreviousRcbtn.Size = new System.Drawing.Size(48, 32);
            this.PreviousRcbtn.TabIndex = 3;
            this.PreviousRcbtn.Text = "<";
            this.PreviousRcbtn.UseVisualStyleBackColor = false;
            // 
            // FlashCardMoreRcbtn
            // 
            this.FlashCardMoreRcbtn.BackColor = System.Drawing.Color.DarkGray;
            this.FlashCardMoreRcbtn.BorderColor = System.Drawing.Color.LightGray;
            this.FlashCardMoreRcbtn.BorderRadius = 10;
            this.FlashCardMoreRcbtn.BorderSize = 0;
            this.FlashCardMoreRcbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlashCardMoreRcbtn.FlatAppearance.BorderSize = 0;
            this.FlashCardMoreRcbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlashCardMoreRcbtn.Location = new System.Drawing.Point(239, 5);
            this.FlashCardMoreRcbtn.Margin = new System.Windows.Forms.Padding(5);
            this.FlashCardMoreRcbtn.Name = "FlashCardMoreRcbtn";
            this.FlashCardMoreRcbtn.Size = new System.Drawing.Size(48, 32);
            this.FlashCardMoreRcbtn.TabIndex = 4;
            this.FlashCardMoreRcbtn.Text = "More";
            this.FlashCardMoreRcbtn.UseVisualStyleBackColor = false;
            // 
            // FlashCardUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GlobalTableLayoutPanel);
            this.Name = "FlashCardUC";
            this.Size = new System.Drawing.Size(712, 403);
            this.Load += new System.EventHandler(this.FlashCardUC_Load);
            this.GlobalTableLayoutPanel.ResumeLayout(false);
            this.DisplayTableLayout.ResumeLayout(false);
            this.ControlTableLayout.ResumeLayout(false);
            this.FlashCardDisplayPanel.ResumeLayout(false);
            this.WordPanel.ResumeLayout(false);
            this.DefDesTableLayout.ResumeLayout(false);
            this.DescriptionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel GlobalTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel ControlTableLayout;
        private RoundedCornerButton DeckMoreRcbtn;
        private RoundedCornerButton FlipRcbtn;
        private RoundedCornerButton RandomRcbtn;
        private RoundedCornerButton NextRcbtn;
        private RoundedCornerButton PreviousRcbtn;
        private RoundedCornerButton FlashCardMoreRcbtn;
        private System.Windows.Forms.TableLayoutPanel DisplayTableLayout;
        private System.Windows.Forms.ComboBox DeckComboBox;
        private System.Windows.Forms.Panel FlashCardDisplayPanel;
        private System.Windows.Forms.TableLayoutPanel DefDesTableLayout;
        private System.Windows.Forms.Label DefinitionLabel;
        private System.Windows.Forms.Panel DescriptionPanel;
        private System.Windows.Forms.Label DescriptionContentLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel WordPanel;
        private System.Windows.Forms.Label WordLabel;
    }
}
