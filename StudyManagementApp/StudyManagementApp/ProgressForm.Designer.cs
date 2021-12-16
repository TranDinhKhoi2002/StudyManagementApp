
namespace StudyManagementApp
{
    partial class ProgressForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressForm));
            this.pieChartToDo = new LiveCharts.WinForms.PieChart();
            this.dtgvTodo = new System.Windows.Forms.DataGridView();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTodo)).BeginInit();
            this.SuspendLayout();
            // 
            // pieChartToDo
            // 
            this.pieChartToDo.Location = new System.Drawing.Point(10, 17);
            this.pieChartToDo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pieChartToDo.Name = "pieChartToDo";
            this.pieChartToDo.Size = new System.Drawing.Size(377, 558);
            this.pieChartToDo.TabIndex = 1;
            this.pieChartToDo.Text = "pieChart1";
            // 
            // dtgvTodo
            // 
            this.dtgvTodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTodo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStatus,
            this.colTotal});
            this.dtgvTodo.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtgvTodo.Location = new System.Drawing.Point(415, 0);
            this.dtgvTodo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dtgvTodo.Name = "dtgvTodo";
            this.dtgvTodo.RowHeadersWidth = 51;
            this.dtgvTodo.Size = new System.Drawing.Size(337, 588);
            this.dtgvTodo.TabIndex = 2;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.Width = 150;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.Width = 150;
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(752, 588);
            this.Controls.Add(this.dtgvTodo);
            this.Controls.Add(this.pieChartToDo);
            this.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.Name = "ProgressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgressForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTodo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private LiveCharts.WinForms.PieChart pieChartToDo;
        private System.Windows.Forms.DataGridView dtgvTodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
    }
}