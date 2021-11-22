
namespace StudyManagementApp.UserControls
{
    partial class AboutUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUC));
            this.lbGroup = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Gender_PictureBox = new System.Windows.Forms.PictureBox();
            this.Name_PictureBox = new System.Windows.Forms.PictureBox();
            this.Gmail_PictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GioiThieu_Label = new System.Windows.Forms.Label();
            this.btnScan = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gender_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Name_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gmail_PictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbGroup
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.lbGroup, 3);
            this.lbGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbGroup.Font = new System.Drawing.Font("Agency FB", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lbGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbGroup.Location = new System.Drawing.Point(65, 0);
            this.lbGroup.Margin = new System.Windows.Forms.Padding(0);
            this.lbGroup.Name = "lbGroup";
            this.lbGroup.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lbGroup.Size = new System.Drawing.Size(687, 87);
            this.lbGroup.TabIndex = 6;
            this.lbGroup.Text = "TEAM 14 ";
            this.lbGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel2.Controls.Add(this.lbGroup, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Gender_PictureBox, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.Name_PictureBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.Gmail_PictureBox, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnScan, 4, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.16539F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.16794F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(821, 524);
            this.tableLayoutPanel2.TabIndex = 24;
            // 
            // Gender_PictureBox
            // 
            this.Gender_PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gender_PictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Gender_PictureBox.ErrorImage")));
            this.Gender_PictureBox.Image = global::StudyManagementApp.Properties.Resources.Gender;
            this.Gender_PictureBox.ImageLocation = "";
            this.Gender_PictureBox.Location = new System.Drawing.Point(296, 89);
            this.Gender_PictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.Gender_PictureBox.Name = "Gender_PictureBox";
            this.Gender_PictureBox.Size = new System.Drawing.Size(225, 232);
            this.Gender_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Gender_PictureBox.TabIndex = 7;
            this.Gender_PictureBox.TabStop = false;
            // 
            // Name_PictureBox
            // 
            this.Name_PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Name_PictureBox.ErrorImage = null;
            this.Name_PictureBox.Image = StudyManagementApp.Properties.Resources.Name;
            this.Name_PictureBox.ImageLocation = "";
            this.Name_PictureBox.Location = new System.Drawing.Point(67, 89);
            this.Name_PictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.Name_PictureBox.Name = "Name_PictureBox";
            this.Name_PictureBox.Size = new System.Drawing.Size(225, 232);
            this.Name_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Name_PictureBox.TabIndex = 8;
            this.Name_PictureBox.TabStop = false;
            // 
            // Gmail_PictureBox
            // 
            this.Gmail_PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gmail_PictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Gmail_PictureBox.ErrorImage")));
            this.Gmail_PictureBox.Image = global::StudyManagementApp.Properties.Resources.gmail;
            this.Gmail_PictureBox.ImageLocation = "";
            this.Gmail_PictureBox.Location = new System.Drawing.Point(525, 89);
            this.Gmail_PictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.Gmail_PictureBox.Name = "Gmail_PictureBox";
            this.Gmail_PictureBox.Size = new System.Drawing.Size(225, 232);
            this.Gmail_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Gmail_PictureBox.TabIndex = 9;
            this.Gmail_PictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.tableLayoutPanel2.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.GioiThieu_Label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(67, 325);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 197);
            this.panel1.TabIndex = 10;
            // 
            // GioiThieu_Label
            // 
            this.GioiThieu_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.GioiThieu_Label.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GioiThieu_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.GioiThieu_Label.Location = new System.Drawing.Point(0, 0);
            this.GioiThieu_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GioiThieu_Label.Name = "GioiThieu_Label";
            this.GioiThieu_Label.Size = new System.Drawing.Size(666, 646);
            this.GioiThieu_Label.TabIndex = 11;
            this.GioiThieu_Label.Text = resources.GetString("GioiThieu_Label.Text");
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnScan.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.Location = new System.Drawing.Point(755, 90);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(63, 230);
            this.btnScan.TabIndex = 11;
            this.btnScan.Text = "SCAN US";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // AboutUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "AboutUC";
            this.Size = new System.Drawing.Size(821, 524);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gender_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Name_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gmail_PictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox Gender_PictureBox;
        private System.Windows.Forms.PictureBox Name_PictureBox;
        private System.Windows.Forms.PictureBox Gmail_PictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label GioiThieu_Label;
        private System.Windows.Forms.Button btnScan;
    }
}
